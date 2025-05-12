Imports MySql.Data.MySqlClient
Imports System.Data

Public Class FormAdminCenter

    Private Sub FormEventPlaceMgmt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEventPlaces()
        LoadPendingBookings()
        LoadAvailability()
        LoadRevenueReports()
        LoadInvoices()
        LoadBookedDates()
    End Sub
    Private Sub LoadEventPlaces()
        Dim query As String = "SELECT * FROM EventPlaces ORDER BY event_place ASC"
        Dim dt As DataTable = DBHelper.GetDataTable(query, New Dictionary(Of String, Object))
        dgvEventPlaces.DataSource = dt
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If String.IsNullOrWhiteSpace(txtEventPlace.Text) OrElse String.IsNullOrWhiteSpace(txtCapacity.Text) OrElse String.IsNullOrWhiteSpace(txtPrice.Text) Then
            MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim query As String = "INSERT INTO EventPlaces (event_place, capacity, price_per_day, event_type) VALUES (@eventPlace, @capacity, @price, @eventType)"
        Dim parameters As New Dictionary(Of String, Object) From {
            {"@eventPlace", txtEventPlace.Text},
            {"@capacity", Integer.Parse(txtCapacity.Text)},
            {"@price", Decimal.Parse(txtPrice.Text)},
            {"@eventType", txtEventType.Text}
        }

        DBHelper.ExecuteQuery(query, parameters)
        LoadEventPlaces()
        MessageBox.Show("Event place added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgvEventPlaces.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an event place to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim placeId As String = CInt(dgvEventPlaces.SelectedRows(0).Cells("place_id").Value)

        Dim query As String = "UPDATE EventPlaces SET event_place=@eventPlace, capacity=@capacity, price_per_day=@price, event_type=@eventType WHERE place_id=@id"
        Dim parameters As New Dictionary(Of String, Object) From {
            {"@id", placeId},
            {"@eventPlace", txtEventPlace.Text},
            {"@capacity", Integer.Parse(txtCapacity.Text)},
            {"@price", Decimal.Parse(txtPrice.Text)},
            {"@eventType", txtEventType.Text}
        }

        DBHelper.ExecuteQuery(query, parameters)
        LoadEventPlaces()
        MessageBox.Show("Event place updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvEventPlaces.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an event place to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim placeId As String = CInt(dgvEventPlaces.SelectedRows(0).Cells("place_id").Value)

        Dim query As String = "DELETE FROM EventPlaces WHERE place_id=@id"
        Dim parameters As New Dictionary(Of String, Object) From {{"@id", placeId}}

        DBHelper.ExecuteQuery(query, parameters)
        LoadEventPlaces()
        MessageBox.Show("Event place deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub LoadPendingBookings()
        Dim query As String = "SELECT * FROM Reservations WHERE status='Pending' ORDER BY reservation_date ASC"
        Dim dt As DataTable = DBHelper.GetDataTable(query, New Dictionary(Of String, Object))
        dgvBookings.DataSource = dt
    End Sub

    Private Sub btnApprove_Click(sender As Object, e As EventArgs)
        If dgvBookings.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a booking to approve.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim bookingId As Integer = CInt(dgvBookings.SelectedRows(0).Cells("booking_id").Value)
        Dim query As String = "UPDATE Reservations SET status='Approved' WHERE booking_id=@id"
        Dim parameters As New Dictionary(Of String, Object) From {{"@id", bookingId}}

        DBHelper.ExecuteQuery(query, parameters)
        LoadPendingBookings()
        MessageBox.Show("Booking approved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnReject_Click(sender As Object, e As EventArgs)
        If dgvBookings.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a booking to reject.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim bookingId As Integer = CInt(dgvBookings.SelectedRows(0).Cells("booking_id").Value)
        Dim query As String = "UPDATE Reservations SET status='Rejected' WHERE booking_id=@id"
        Dim parameters As New Dictionary(Of String, Object) From {{"@id", bookingId}}

        DBHelper.ExecuteQuery(query, parameters)
        LoadPendingBookings()
        MessageBox.Show("Booking rejected successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub LoadAvailability()
        Dim query As String = "SELECT event_place, COUNT(*) AS bookings FROM Reservations WHERE status='Approved' GROUP BY event_place"
        Dim dt As DataTable = DBHelper.GetDataTable(query, New Dictionary(Of String, Object))
        dgvAvailability.DataSource = dt
    End Sub

    Private Sub LoadRevenueReports()
        Dim query As String = "SELECT event_place, SUM(price_per_day) AS total_revenue FROM Reservations WHERE status='Approved' GROUP BY event_place"
        Dim dt As DataTable = DBHelper.GetDataTable(query, New Dictionary(Of String, Object))
        dgvReportBookings.DataSource = dt
    End Sub

    Private Sub btnGenerateReport_Click(sender As Object, e As EventArgs) Handles btnGenerateReport.Click
        LoadRevenueReports()
        MessageBox.Show("Report generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Private Sub LoadInvoices()
        Dim query As String = "SELECT * FROM Invoices WHERE payment_status='Pending' ORDER BY invoice_date ASC"
        Dim dt As DataTable = DBHelper.GetDataTable(query, New Dictionary(Of String, Object))
        dgvInvoices.DataSource = dt
    End Sub

    Private Sub btnProcessPayment_Click(sender As Object, e As EventArgs) Handles btnProcessPayment.Click
        If dgvInvoices.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an invoice to process.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim invoiceId As Integer = CInt(dgvInvoices.SelectedRows(0).Cells("invoice_id").Value)
        Dim query As String = "UPDATE Invoices SET payment_status='Completed' WHERE invoice_id=@id"
        Dim parameters As New Dictionary(Of String, Object) From {{"@id", invoiceId}}

        DBHelper.ExecuteQuery(query, parameters)
        LoadInvoices()
        MessageBox.Show("Payment processed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnAdjustPricing_Click(sender As Object, e As EventArgs) Handles btnAdjustPricing.Click
        If nudPriceAdjust.Value <= 0 Then
            MessageBox.Show("Invalid price adjustment value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim query As String = "UPDATE EventPlaces SET price_per_day=@newPrice WHERE event_type=@eventType"
        Dim parameters As New Dictionary(Of String, Object) From {
            {"@newPrice", nudPriceAdjust.Value}}


        DBHelper.ExecuteQuery(query, parameters)
        LoadEventPlaces()
        MessageBox.Show("Pricing updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub btnUpdateCharges_Click(sender As Object, e As EventArgs)
        If dgvBookings.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a booking to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchQuery As String = txtSearch.Text.Trim()
        If String.IsNullOrEmpty(searchQuery) Then
            MessageBox.Show("Please enter a search term.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Search event places
        Dim eventPlaceQuery As String = "SELECT * FROM EventPlaces WHERE event_place LIKE @search"
        Dim eventParams As New Dictionary(Of String, Object) From {{"@search", "%" & searchQuery & "%"}}
        dgvEventPlaces.DataSource = DBHelper.GetDataTable(eventPlaceQuery, eventParams)

        ' Search pending bookings
        Dim bookingQuery As String = "SELECT * FROM Reservations WHERE customer_name LIKE @search"
        Dim bookingParams As New Dictionary(Of String, Object) From {{"@search", "%" & searchQuery & "%"}}
        dgvBookings.DataSource = DBHelper.GetDataTable(bookingQuery, bookingParams)
    End Sub

    Public Sub DisplayAdminUsername()
        lblUsername.Text = CurrentUser.Username
    End Sub

    Private Sub btnEditInformation_Click(sender As Object, e As EventArgs) Handles btnEditInformation.Click
        Dim editForm As New FormAdminInformation()
        editForm.ShowDialog()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        CurrentUser.Username = String.Empty
        CurrentUser.UserID = 0
        CurrentUser.Email = String.Empty

        Dim mainForm As New FormMain()
        mainForm.Show()
        Me.Close()
    End Sub

    Private Sub LoadBookedDates()
        Dim query As String = "SELECT reservation_date FROM Reservations WHERE status='Approved'"
        Dim dt As DataTable = DBHelper.GetDataTable(query, New Dictionary(Of String, Object))

        For Each row As DataRow In dt.Rows
            Dim bookedDate As DateTime = Convert.ToDateTime(row("reservation_date"))
            mcBookings.AddBoldedDate(bookedDate)
        Next
    End Sub

    Private Sub LoadTotalCustomers()
        Dim query As String = "SELECT COUNT(*) FROM Customers"
        lblNumCustomersContainer.Text = DBHelper.ExecuteScalarQuery(query, New Dictionary(Of String, Object)).ToString()
    End Sub

    Private Sub LoadTotalBookings()
        Dim query As String = "SELECT COUNT(*) FROM Reservations"
        lblTotalBookingsContainer.Text = DBHelper.ExecuteScalarQuery(query, New Dictionary(Of String, Object)).ToString()
    End Sub

    Private Sub LoadBookingStatusChart()
        chTotalStatus.Series("BookingStatus").Points.Clear()

        Dim query As String = "SELECT status, COUNT(*) AS count FROM Reservations GROUP BY status"
        Dim dt As DataTable = DBHelper.GetDataTable(query, New Dictionary(Of String, Object))

        For Each row As DataRow In dt.Rows
            chTotalStatus.Series("BookingStatus").Points.AddXY(row("status").ToString(), Convert.ToInt32(row("count")))
        Next
    End Sub

    Private Sub btnUpdateBookings_Click(sender As Object, e As EventArgs) Handles btnUpdateBookings.Click
        If dgvBookings.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a booking to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim bookingId As Integer = CInt(dgvBookings.SelectedRows(0).Cells("booking_id").Value)
        Dim guestCount As Integer = CInt(dgvBookings.SelectedRows(0).Cells("guest_count").Value)
        Dim eventPlace As String = dgvBookings.SelectedRows(0).Cells("event_place").Value.ToString()
        Dim eventType As String = dgvBookings.SelectedRows(0).Cells("event_type").Value.ToString()

        Dim updateForm As New FormUpdateBooking(bookingId, guestCount, eventPlace, eventType)
        updateForm.ShowDialog()
    End Sub


End Class
