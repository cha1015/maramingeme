Imports MySql.Data.MySqlClient
Imports System.Data


Public Class FormCustomerInformation
    Public Property CustomerId As Integer  ' Store customerId

    Private Sub dtpBirthday_ValueChanged(sender As Object, e As EventArgs) Handles dtpBirthday.ValueChanged
        Dim birthDate As Date = dtpBirthday.Value
        Dim today As Date = Date.Today
        Dim age As Integer = today.Year - birthDate.Year

        If birthDate > today.AddYears(-age) Then
            age -= 1
        End If

        txtAge.Text = age.ToString()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim customerName As String = txtCustomerName.Text.Trim()
        If String.IsNullOrEmpty(customerName) Then
            MessageBox.Show("Please enter customer name.")
            Return
        End If

        Dim age As Integer
        If Not Integer.TryParse(txtAge.Text, age) Then
            MessageBox.Show("Please enter a valid age.")
            Return
        End If

        Dim birthday As Date = dtpBirthday.Value.Date

        If cmbSex.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a sex.")
            Return
        End If
        Dim sex As String = cmbSex.SelectedItem.ToString()

        Dim address As String = txtAddress.Text.Trim()
        If String.IsNullOrEmpty(address) Then
            MessageBox.Show("Please enter an address.")
            Return
        End If

        CustomerId = InsertCustomer(customerName, age, birthday, sex, address)
        If CustomerId <= 0 Then
            MessageBox.Show("Failed to insert customer details.")
            Return
        End If

        Dim mainForm As FormMain = CType(Application.OpenForms("FormMain"), FormMain)
        If mainForm IsNot Nothing Then
            mainForm.SetCustomerId(CustomerId)
        End If

        MessageBox.Show("Customer information saved successfully!")

    End Sub

    Private Function InsertCustomer(name As String, age As Integer, birthday As Date, sex As String, address As String) As Integer
        Dim customerId As Integer = -1
        Dim insertCustomerQuery As String = "INSERT INTO Customers (name, age, birthday, sex, address) " &
                                            "VALUES (@name, @age, @birthday, @sex, @address); SELECT LAST_INSERT_ID();"
        Using connection As MySqlConnection = DBHelper.GetConnection()
            Using cmd As New MySqlCommand(insertCustomerQuery, connection)
                cmd.Parameters.AddWithValue("@name", name)
                cmd.Parameters.AddWithValue("@age", age)
                cmd.Parameters.AddWithValue("@birthday", birthday)
                cmd.Parameters.AddWithValue("@sex", sex)
                cmd.Parameters.AddWithValue("@address", address)
                Try
                    connection.Open()
                    customerId = Convert.ToInt32(cmd.ExecuteScalar())
                Catch ex As Exception
                    MessageBox.Show("Error inserting customer record: " & ex.Message)
                End Try
            End Using
        End Using
        Return customerId
    End Function

End Class