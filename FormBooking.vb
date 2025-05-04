Imports MySql.Data.MySqlClient
Imports System.Data

Public Class FormBooking
    Public Property EventPlaceId As Integer
    Public Property EventPlaceName As String
    Public Property EventPlaceCapacity As Integer
    Public Property BasePricePerDay As Decimal
    Public Property EventPlaceFeatures As String
    Public Property EventVenueType As String

    Private Sub FormBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPlaceID.Text = EventPlaceId.ToString()
        txtVenueName.Text = EventPlaceName
        txtCapacity.Text = EventPlaceCapacity.ToString()
        txtPricePerDay.Text = "₱" & BasePricePerDay.ToString("F2")
        txtFeatures.Text = EventPlaceFeatures

        ComputeTotalPrice()
    End Sub

    Private Sub dtpBirthday_ValueChanged(sender As Object, e As EventArgs) Handles dtpBirthday.ValueChanged
        Dim birthDate As Date = dtpBirthday.Value
        Dim today As Date = Date.Today
        Dim age As Integer = today.Year - birthDate.Year

        If birthDate > today.AddYears(-age) Then
            age -= 1
        End If

        txtAge.Text = age.ToString()
    End Sub


    Private Sub ComputeTotalPrice()
        Dim numGuests As Integer
        If Not Integer.TryParse(txtNumGuests.Text, numGuests) Then
            numGuests = 0
        End If

        Dim excessCost As Integer = 0
        If numGuests > EventPlaceCapacity Then
            excessCost = (numGuests - EventPlaceCapacity) * 100
        End If

        Dim servicesCost As Decimal = 0D

        If chkCatering.Checked Then servicesCost += 20000D
        If chkClown.Checked Then servicesCost += 10000D
        If chkSinger.Checked Then servicesCost += 7000D
        If chkDancer.Checked Then servicesCost += 7000D
        If chkVideoke.Checked Then servicesCost += 1000D

        Dim totalPrice As Decimal = BasePricePerDay + excessCost + servicesCost
        txtTotalPrice.Text = "₱" & totalPrice.ToString("F2")
    End Sub

    Private Sub UpdateTotalPrice(sender As Object, e As EventArgs) Handles txtNumGuests.TextChanged, chkCatering.CheckedChanged, chkClown.CheckedChanged, chkSinger.CheckedChanged, chkDancer.CheckedChanged, chkVideoke.CheckedChanged
        ComputeTotalPrice()
    End Sub

    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
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

        Dim numGuests As Integer
        If Not Integer.TryParse(txtNumGuests.Text, numGuests) Then
            MessageBox.Show("Please enter a valid number of guests.")
            Return
        End If

        Dim eventDate As Date = dtpEventDate.Value.Date

        Dim totalPrice As Decimal
        Dim priceText As String = txtTotalPrice.Text.Replace("₱", "").Trim()
        If Not Decimal.TryParse(priceText, totalPrice) Then
            MessageBox.Show("Error: Unable to determine total price.")
            Return
        End If

        Dim customerId As Integer = InsertCustomer(customerName, age, birthday, sex, address)
        If customerId <= 0 Then
            MessageBox.Show("Failed to insert customer details.")
            Return
        End If

        Dim insertBookingQuery As String = "INSERT INTO Bookings (customer_id, place_id, num_guests, event_date, total_price) " &
                                           "VALUES (@customer_id, @place_id, @num_guests, @event_date, @total_price); SELECT LAST_INSERT_ID();"

        Dim bookingId As Integer

        Using connection As MySqlConnection = DBHelper.GetConnection()
            Using cmd As New MySqlCommand(insertBookingQuery, connection)
                cmd.Parameters.AddWithValue("@customer_id", customerId)
                cmd.Parameters.AddWithValue("@place_id", EventPlaceId)
                cmd.Parameters.AddWithValue("@num_guests", numGuests)
                cmd.Parameters.AddWithValue("@event_date", eventDate)
                cmd.Parameters.AddWithValue("@total_price", totalPrice)

                Try
                    connection.Open()
                    bookingId = Convert.ToInt32(cmd.ExecuteScalar())
                    connection.Close()

                    SaveBookingServices(bookingId)

                    MessageBox.Show("Booking successful!")
                    Me.Close()
                Catch ex As Exception
                    MessageBox.Show("Error while saving booking: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub SaveBookingServices(bookingId As Integer)
        Dim deleteQuery As String = "DELETE FROM BookingServices WHERE booking_id = @bookingId"

        Using connection As MySqlConnection = DBHelper.GetConnection()
            Using cmdDelete As New MySqlCommand(deleteQuery, connection)
                cmdDelete.Parameters.AddWithValue("@bookingId", bookingId)
                connection.Open()
                cmdDelete.ExecuteNonQuery()
                connection.Close()
            End Using
        End Using

        Dim insertQuery As String = "INSERT INTO BookingServices (booking_id, service_id) VALUES (@bookingId, @serviceId)"

        Using connection As MySqlConnection = DBHelper.GetConnection()
            Using cmdInsert As New MySqlCommand(insertQuery, connection)
                cmdInsert.Parameters.AddWithValue("@bookingId", bookingId)

                Dim services As New List(Of Integer)
                If chkCatering.Checked Then services.Add(1)
                If chkClown.Checked Then services.Add(2)
                If chkSinger.Checked Then services.Add(3)
                If chkDancer.Checked Then services.Add(4)
                If chkVideoke.Checked Then services.Add(5)

                connection.Open()
                For Each serviceId In services
                    cmdInsert.Parameters.AddWithValue("@serviceId", serviceId)
                    cmdInsert.ExecuteNonQuery()
                    cmdInsert.Parameters.RemoveAt("@serviceId")
                Next
                connection.Close()
            End Using
        End Using
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

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim nextForm As New FormBooking()
        NavigationHelper.GoNext(Me, nextForm, btnNext, btnBack)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        NavigationHelper.GoBack(Me, btnNext, btnBack)
    End Sub



End Class
