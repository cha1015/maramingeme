Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class FormSignUp
    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        If String.IsNullOrWhiteSpace(txtFirstName.Text) OrElse
       String.IsNullOrWhiteSpace(txtLastName.Text) OrElse
       String.IsNullOrWhiteSpace(txtUsername.Text) OrElse
       String.IsNullOrWhiteSpace(txtEmail.Text) OrElse
       String.IsNullOrWhiteSpace(txtPass.Text) OrElse
       String.IsNullOrWhiteSpace(txtConfPass.Text) OrElse
       cbRole.SelectedItem Is Nothing Then

            MessageBox.Show("All fields are required. Please fill in all the information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If txtPass.Text <> txtConfPass.Text Then
            MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim hashedPassword As String = HashPassword(txtPass.Text)
        Dim query As String = "INSERT INTO Users (first_name, last_name, username, email, password_hash, role) VALUES (@fname, @lname, @uname, @email, @pass, @role)"
        Dim parameters As New Dictionary(Of String, Object) From {
        {"@fname", txtFirstName.Text},
        {"@lname", txtLastName.Text},
        {"@uname", txtUsername.Text},
        {"@email", txtEmail.Text},
        {"@pass", hashedPassword},
        {"@role", cbRole.SelectedItem.ToString()}
    }

        Try
            DBHelper.ExecuteQuery(query, parameters)
            MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            Dim loginForm As New FormLogIn()
            loginForm.Show()
        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function HashPassword(password As String) As String
        Dim sha256 As SHA256 = SHA256.Create()
        Dim hashedBytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
        Return Convert.ToBase64String(hashedBytes)
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
            txtConfPass.PasswordChar = ControlChars.NullChar ' Reveals text
        Else
            txtConfPass.PasswordChar = "*"c ' Hides text
        End If
    End Sub

    'Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
    '    Dim nextForm As New FormBooking()
    '    NavigationHelper.GoNext(Me, nextForm, btnNext, btnBack)
    'End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        NavigationHelper.GoBack(Me, btnNext, btnBack)
    End Sub

    Private Sub lnklblLogIn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblLogIn.LinkClicked
        Dim loginForm As New FormLogIn()
        loginForm.Show()
        Me.Hide()
    End Sub

    Private Sub MoveToNextControl(sender As Object, e As KeyEventArgs) Handles txtFirstName.KeyDown, txtLastName.KeyDown, txtUsername.KeyDown, txtEmail.KeyDown, txtPass.KeyDown, txtConfPass.KeyDown, cbRole.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If sender Is cbRole Then
                btnSignUp.PerformClick()
            Else
                SelectNextControl(DirectCast(sender, Control), True, True, True, True)
            End If
        End If
    End Sub

End Class
