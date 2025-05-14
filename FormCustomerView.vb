Imports MySql.Data.MySqlClient
Imports System.Data

Public Class FormCustomerView

    Private Sub FormCustomerView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCurrentBooking()
        LoadBookingHistory()
        LoadPaymentHistory()
        LoadPastBookings()
    End Sub

    ' Fetch current active booking
    Private Sub LoadCurrentBooking()
        Dim query As String = "SELECT event_place, reservation_date, status FROM Reservations WHERE user_id=@userID AND status='Approved' ORDER BY reservation_date DESC LIMIT 1"
        Dim parameters As New Dictionary(Of String, Object) From {{"@userID", CurrentUser.UserID}}
        Dim dt As DataTable = DBHelper.GetDataTable(query, parameters)

        If dt.Rows.Count > 0 Then
            lblCurrentBooking.Text = $"Current Booking: {dt.Rows(0)("event_place")} on {dt.Rows(0)("reservation_date")}"
        Else
            lblCurrentBooking.Text = "No active bookings."
        End If
    End Sub

    ' Load booking history (approved/rejected)
    Private Sub LoadBookingHistory()
        Dim query As String = "SELECT booking_id, event_place, reservation_date, status FROM Reservations WHERE user_id=@userID ORDER BY reservation_date DESC"
        Dim parameters As New Dictionary(Of String, Object) From {{"@userID", CurrentUser.UserID}}
        Dim dt As DataTable = DBHelper.GetDataTable(query, parameters)
        dgvBookingHistory.DataSource = dt
    End Sub

    ' Load payment history & invoices
    Private Sub LoadPaymentHistory()
        Dim query As String = "SELECT invoice_id, event_place, total_amount, payment_status FROM Invoices WHERE user_id=@userID ORDER BY invoice_date DESC"
        Dim parameters As New Dictionary(Of String, Object) From {{"@userID", CurrentUser.UserID}}
        Dim dt As DataTable = DBHelper.GetDataTable(query, parameters)
        dgvPaymentHistory.DataSource = dt
    End Sub

    ' Load past bookings
    Private Sub LoadPastBookings()
        Dim query As String = "SELECT event_place, reservation_date, status FROM Reservations WHERE user_id=@userID AND reservation_date < CURDATE() ORDER BY reservation_date DESC"
        Dim parameters As New Dictionary(Of String, Object) From {{"@userID", CurrentUser.UserID}}
        Dim dt As DataTable = DBHelper.GetDataTable(query, parameters)
        dgvPastBookings.DataSource = dt
    End Sub

    'Private Sub btnEditCustomer_Click(sender As Object, e As EventArgs) Handles btnEditCustomer.Click
    '    ' Pass customer details to FormCustomerInformation before opening it
    '    Dim customerForm As New FormCustomerInformation(txtCustomerName.Text, dtpBirthday.Value, cmbSex.Text, txtAddress.Text)
    '    customerForm.ShowDialog()
    'End Sub


    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        Dim mainForm As New FormMain()
        mainForm.Show()
        Me.Hide()
    End Sub
End Class
