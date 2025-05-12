Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class FormLogIn

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        If String.IsNullOrWhiteSpace(txtEmail.Text) OrElse String.IsNullOrWhiteSpace(txtPass.Text) Then
            MessageBox.Show("Please enter both email and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If txtPass.Text <> txtConfPass.Text Then
            MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim query As String = "SELECT user_id, username, email, password_hash, role FROM Users WHERE email = @email"
        Dim parameters As New Dictionary(Of String, Object) From {{"@email", txtEmail.Text}}
        Dim dt As DataTable = DBHelper.GetDataTable(query, parameters)

        If dt.Rows.Count > 0 Then
            Dim storedHash As String = dt.Rows(0)("password_hash").ToString()

            If VerifyPassword(txtPass.Text, storedHash) Then
                ' Store user details in session
                CurrentUser.UserID = CInt(dt.Rows(0)("user_id"))
                CurrentUser.Username = dt.Rows(0)("username").ToString()
                CurrentUser.Email = dt.Rows(0)("email").ToString()

                MessageBox.Show("Login successful!", "Welcome " & CurrentUser.Username, MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Validate role before redirection
                Dim validRoles As List(Of String) = New List(Of String) From {"Admin", "User"}
                Dim userRole As String = dt.Rows(0)("role").ToString()

                If validRoles.Contains(userRole) Then
                    Me.Hide()
                    Select Case userRole
                        Case "Admin"
                            Dim adminForm As New FormAdminCenter()
                            adminForm.Show()
                        Case "User"
                            Dim mainForm As New FormMain()
                            mainForm.Show()
                    End Select
                Else
                    MessageBox.Show("Invalid role detected! Contact support.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Else
                MessageBox.Show("Invalid credentials.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Email not found.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Function VerifyPassword(inputPassword As String, storedHash As String) As Boolean
        Using sha256 As SHA256 = SHA256.Create()
            Dim inputHash As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(inputPassword))
            Return Convert.ToBase64String(inputHash) = storedHash
        End Using
    End Function
    Private Sub btnShowPass_Click(sender As Object, e As EventArgs) Handles btnShowPass.Click
        If txtPass.PasswordChar = "*"c Then
            txtPass.PasswordChar = ControlChars.NullChar
        Else
            txtPass.PasswordChar = "*"c
        End If
    End Sub

    Private Sub btnShowConfPass_Click(sender As Object, e As EventArgs) Handles btnShowConfPass.Click
        If txtConfPass.PasswordChar = "*"c Then
            txtConfPass.PasswordChar = ControlChars.NullChar
        Else
            txtConfPass.PasswordChar = "*"c
        End If
    End Sub

    'Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
    '    Dim nextForm As New FormBooking()
    '    NavigationHelper.GoNext(Me, nextForm, btnNext, btnBack)
    'End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        NavigationHelper.GoBack(Me, btnNext, btnBack)
    End Sub

    Private Sub lnklblSignUp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblSignUp.LinkClicked
        Dim signUpForm As New FormSignUp()
        Me.Hide()
        signUpForm.ShowDialog()
    End Sub

    Private Sub MoveToNextControl(sender As Object, e As KeyEventArgs) Handles txtEmail.KeyDown, txtPass.KeyDown, txtConfPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If sender Is txtConfPass Then
                btnLogIn.PerformClick()
            Else
                SelectNextControl(DirectCast(sender, Control), True, True, True, True)
            End If
        End If
    End Sub


End Class
