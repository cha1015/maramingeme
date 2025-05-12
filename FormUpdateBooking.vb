Imports MySql.Data.MySqlClient
Imports System.Data

Public Class FormUpdateBooking
    Private bookingId As Integer
    Private Sub FormUpdateBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEventPlaces()
    End Sub

    Public Sub New(_bookingId As Integer, _guestCount As Integer, _eventPlace As String, _eventType As String)
        InitializeComponent()
        bookingId = _bookingId
        lblBookingIDContainer.Text = "Booking ID: " & _bookingId.ToString()
        txtGuestCount.Text = _guestCount.ToString()
        cbEventPlace.SelectedItem = _eventPlace
        cbEventType.SelectedItem = _eventType
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrWhiteSpace(txtGuestCount.Text) OrElse cbEventPlace.SelectedItem Is Nothing OrElse cbEventType.SelectedItem Is Nothing Then
            MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim query As String = "UPDATE Reservations SET guest_count=@guestCount, event_place=@eventPlace, event_type=@eventType WHERE booking_id=@bookingId"
        Dim parameters As New Dictionary(Of String, Object) From {
        {"@guestCount", Integer.Parse(txtGuestCount.Text)},
        {"@eventPlace", cbEventPlace.SelectedItem.ToString()},
        {"@eventType", cbEventType.SelectedItem.ToString()},
        {"@bookingId", bookingId}
    }

        DBHelper.ExecuteQuery(query, parameters)

        MessageBox.Show("Booking updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub LoadEventPlaces()
        Dim query As String = "SELECT DISTINCT event_place FROM EventPlaces"
        Dim dt As DataTable = DBHelper.GetDataTable(query, New Dictionary(Of String, Object))

        cbEventPlace.Items.Clear()
        For Each row As DataRow In dt.Rows
            cbEventPlace.Items.Add(row("event_place").ToString())
        Next
    End Sub

    Private Sub LoadEventTypes()
        Dim query As String = "SELECT DISTINCT event_type FROM EventPlaces"
        Dim dt As DataTable = DBHelper.GetDataTable(query, New Dictionary(Of String, Object))

        cbEventType.Items.Clear()
        For Each row As DataRow In dt.Rows
            cbEventType.Items.Add(row("event_type").ToString())
        Next
    End Sub


End Class
