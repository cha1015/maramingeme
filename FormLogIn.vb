Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class FormLogIn
    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        Dim query As String = "SELECT password_hash FROM Users WHERE email = @email"
        Dim parameters As New Dictionary(Of String, Object) From {{"@email", txtEmail.Text}}
        Dim storedHash As Object = DBHelper.ExecuteScalarQuery(query, parameters)

        If storedHash IsNot Nothing AndAlso VerifyPassword(txtPass.Text, storedHash.ToString()) Then
            MessageBox.Show("Login successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            Dim mainForm As New FormMain()
            mainForm.Show()
        Else
            MessageBox.Show("Invalid login credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function VerifyPassword(inputPassword As String, storedHash As String) As Boolean
        Dim sha256 As SHA256 = SHA256.Create()
        Dim inputHash As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(inputPassword))
        Return Convert.ToBase64String(inputHash) = storedHash
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

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim nextForm As New FormBooking()
        NavigationHelper.GoNext(Me, nextForm, btnNext, btnBack)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        NavigationHelper.GoBack(Me, btnNext, btnBack)
    End Sub



End Class
