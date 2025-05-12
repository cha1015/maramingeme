Imports MySql.Data.MySqlClient
Imports System.Data

Public Class FormBooking
    Public Property EventPlaceId As Integer
    Public Property EventPlaceName As String
    Public Property EventPlaceCapacity As Integer
    Public Property BasePricePerDay As Decimal
    Public Property EventPlaceFeatures As String
    Public Property EventVenueType As String

    Public Property OpeningHours As String
    Public Property ClosingHours As String
    Public Property AvailableDays As String

    Private ReadOnly _customerId As Integer
    Public ReadOnly Property CustomerId As Integer
        Get
            Return _customerId
        End Get
    End Property
    Public Property EventPlaceDescription As String
    Public Property EventTime As String
    Public Property VoucherDiscount As Decimal = 0

    Public Sub New(customerId As Integer)
        InitializeComponent()
        _customerId = customerId
    End Sub

    Private Sub FormBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblEventPlace.Text = EventPlaceName
        lblPlaceIDContainer.Text = EventPlaceId.ToString()
        lblCapacityContainer.Text = EventPlaceCapacity.ToString()
        lblPricePerDayContainer.Text = "₱" & BasePricePerDay.ToString("F2")
        lblFeaturesContainer.Text = EventPlaceFeatures
        lblDescriptionContainer.Text = EventPlaceDescription
        lblHoursContainer.Text = DateTime.Parse(OpeningHours).ToString("hh:mm tt") & " - " & DateTime.Parse(ClosingHours).ToString("hh:mm tt")
        lblAvailableDaysContainer.Text = "Available: " & FormatAvailableDays(AvailableDays)

        dtpEventDateStart.Value = Date.Today
        dtpEventTimeStart.Value = Date.Now

        dtpEventDateStart.MinDate = Date.Today
        dtpEventDateEnd.MinDate = Date.Today

        dtpEventTimeStart.Format = DateTimePickerFormat.Custom
        dtpEventTimeStart.CustomFormat = "hh:mm tt"
        dtpEventTimeStart.ShowUpDown = True

        dtpEventTimeEnd.Format = DateTimePickerFormat.Custom
        dtpEventTimeEnd.CustomFormat = "hh:mm tt"
        dtpEventTimeEnd.ShowUpDown = True

        ' Hide the default pickers but keep them functional
        dtpEventTimeStart.Visible = False
        dtpEventTimeEnd.Visible = False

        mtxtEventTimeStart.Mask = "00:00 AA" ' Allows full manual typing (AM/PM)
        mtxtEventTimeEnd.Mask = "00:00 AA"


        mtxtEventTimeStart.Text = dtpEventTimeStart.Value.ToString("hh:mm tt")
        mtxtEventTimeEnd.Text = dtpEventTimeEnd.Value.ToString("hh:mm tt")

        ComputeTotalPrice()
        PopulateEventTypeCombo()
        LoadBookedDates()
        HighlightBookedDates()

    End Sub

    '---------- Buttons ----------
    Private Sub btnBookingProceed_Click(sender As Object, e As EventArgs) Handles btBookingProceed.Click
        If String.IsNullOrWhiteSpace(cbEventType.Text) Then
            MessageBox.Show("Please select an event type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If dtpEventDateStart.Value.Date < Date.Today Then
            MessageBox.Show("Event start date cannot be in the past.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If dtpEventDateEnd.Value.Date < dtpEventDateStart.Value.Date Then
            MessageBox.Show("Event end date must be after the start date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If dtpEventTimeEnd.Value <= dtpEventTimeStart.Value Then
            MessageBox.Show("Event end time must be after the start time.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim numGuests As Integer
        If Not Integer.TryParse(txtNumGuests.Text, numGuests) Then
            MessageBox.Show("Please enter a valid number of guests.")
            Return
        End If

        Dim eventDate As Date = dtpEventDateStart.Value.Date
        Dim eventTime As String = dtpEventTimeStart.Value.ToString("hh:mm tt") ' Convert to 12-hour format

        Dim totalPrice As Decimal
        Dim priceText As String = txtTotalPrice.Text.Replace("₱", "").Trim()
        If Not Decimal.TryParse(priceText, totalPrice) Then
            MessageBox.Show("Error: Unable to determine total price.")
            Return
        End If

        Dim insertBookingQuery As String = "INSERT INTO Bookings (customer_id, place_id, num_guests, event_date, event_time, total_price) " &
                               "VALUES (@customer_id, @place_id, @num_guests, @event_date, @event_time, @total_price); SELECT LAST_INSERT_ID();"

        Dim bookingId As Integer

        Using connection As MySqlConnection = DBHelper.GetConnection()
            Using cmd As New MySqlCommand(insertBookingQuery, connection)
                cmd.Parameters.AddWithValue("@customer_id", _customerId)
                cmd.Parameters.AddWithValue("@place_id", EventPlaceId)
                cmd.Parameters.AddWithValue("@num_guests", numGuests)
                cmd.Parameters.AddWithValue("@event_date", eventDate)
                cmd.Parameters.AddWithValue("@event_time", eventTime)
                cmd.Parameters.AddWithValue("@total_price", totalPrice)

                Try
                    connection.Open()
                    bookingId = Convert.ToInt32(cmd.ExecuteScalar())
                    connection.Close()

                    SaveBookingServices(bookingId)

                    MessageBox.Show("Booking successful!")

                    ' Move to next tab **after successful validation**
                    tcDetails.SelectedTab = tpCustomerDetails

                Catch ex As Exception
                    MessageBox.Show("Error while saving booking: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnVoucher_Click(sender As Object, e As EventArgs) Handles btnVoucher.Click
        Dim isFirstTimeCustomer As Boolean = CheckIfFirstTimeCustomer(CustomerId)
        Dim hasLoyalty As Boolean = CheckIfLoyaltyCustomer(CustomerId) ' Corrected

        Dim voucherForm As New FormVoucher(CustomerId, dtpBirthday.Value, isFirstTimeCustomer, hasLoyalty)

        voucherForm.ShowDialog()

        If Not String.IsNullOrEmpty(voucherForm.SelectedVoucherName) Then
            lblSelectedVoucherContainer.Text = voucherForm.SelectedVoucherName
            VoucherDiscount = voucherForm.SelectedVoucherDiscount
        End If

        ComputeTotalPrice()
    End Sub

    Private Sub btnCustomerProceed_Click(sender As Object, e As EventArgs) Handles btnCustomerProceed.Click
        If String.IsNullOrWhiteSpace(txtCustomerName.Text) Then
            MessageBox.Show("Customer name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If dtpBirthday.Value.Date > Date.Today Then
            MessageBox.Show("Birthday cannot be in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(cmbSex.Text) Then
            MessageBox.Show("Please select a gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtAddress.Text) Then
            MessageBox.Show("Address is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        tcDetails.SelectedTab = tpPaymentDetails
    End Sub

    ' ---------- Methods, Functions, Others ----------

    Private Sub mtxtEventTimeStart_TextChanged(sender As Object, e As EventArgs) Handles mtxtEventTimeStart.TextChanged
        Dim parsedTime As DateTime
        If DateTime.TryParse(mtxtEventTimeStart.Text, parsedTime) Then
            dtpEventTimeStart.Value = parsedTime ' Sync with DateTimePicker
        End If
    End Sub

    Private Sub mtxtEventTimeEnd_TextChanged(sender As Object, e As EventArgs) Handles mtxtEventTimeEnd.TextChanged
        Dim parsedTime As DateTime
        If DateTime.TryParse(mtxtEventTimeEnd.Text, parsedTime) Then
            dtpEventTimeEnd.Value = parsedTime ' Sync with DateTimePicker
        End If
    End Sub

    Private Function FormatAvailableDays(daysString As String) As String
        Dim days As String() = daysString.Split(","c).Select(Function(d) d.Trim()).ToArray()
        Dim dayNames As String() = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"}

        Dim sortedDays As List(Of String) = days.OrderBy(Function(d) Array.IndexOf(dayNames, d)).ToList()

        If sortedDays.Count <= 1 Then
            Return String.Join(", ", sortedDays) ' If only 1 day, show it normally
        End If

        Dim startDay As String = sortedDays.First()
        Dim endDay As String = sortedDays.Last()

        ' If all days are selected, just show "All Week"
        If sortedDays.SequenceEqual(dayNames.ToList()) Then
            Return "All Week"
        End If

        Return $"{startDay} - {endDay}"
    End Function

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

        Dim cateringRate, clownRate, singerRate, dancerRate, videokeRate As Decimal

        If numGuests <= 50 Then
            cateringRate = 500D
            clownRate = 200D
            singerRate = 150D
            dancerRate = 150D
            videokeRate = 50D
        ElseIf numGuests <= 100 Then
            cateringRate = 450D
            clownRate = 180D
            singerRate = 130D
            dancerRate = 130D
            videokeRate = 45D
        Else
            cateringRate = 400D
            clownRate = 160D
            singerRate = 120D
            dancerRate = 120D
            videokeRate = 40D
        End If

        If chkCatering.Checked Then servicesCost += cateringRate * numGuests
        If chkClown.Checked Then servicesCost += clownRate * numGuests
        If chkSinger.Checked Then servicesCost += singerRate * numGuests
        If chkDancer.Checked Then servicesCost += dancerRate * numGuests
        If chkVideoke.Checked Then servicesCost += videokeRate * numGuests

        Dim totalPrice As Decimal = BasePricePerDay + excessCost + servicesCost

        If VoucherDiscount > 0 Then
            totalPrice -= totalPrice * VoucherDiscount
        End If

        txtTotalPrice.Text = "₱" & totalPrice.ToString("F2")

    End Sub

    Private Sub UpdateTotalPrice(sender As Object, e As EventArgs) Handles txtNumGuests.TextChanged, chkCatering.CheckedChanged, chkClown.CheckedChanged, chkSinger.CheckedChanged, chkDancer.CheckedChanged, chkVideoke.CheckedChanged
        ComputeTotalPrice()
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

    Private Sub PopulatePaymentDetails()
        lblCustomerContainer.Text = txtCustomerName.Text
        lblEventPlacePaymentContainer.Text = EventPlaceName
        lblEventTypePaymentContainer.Text = cbEventType.Text
        lblNumGuestsPaymentContainer.Text = txtNumGuests.Text
        lblEventDatePaymentContainer.Text = $"{dtpEventDateStart.Value.ToShortDateString()} - {dtpEventDateEnd.Value.ToShortDateString()}"
        lblEventTimePaymentContainer.Text = $"{dtpEventTimeStart.Value.ToShortTimeString()} - {dtpEventTimeEnd.Value.ToShortTimeString()}"

        Dim selectedServices As New List(Of String)
        If chkCatering.Checked Then selectedServices.Add("Catering")
        If chkClown.Checked Then selectedServices.Add("Clown")
        If chkSinger.Checked Then selectedServices.Add("Singer")
        If chkDancer.Checked Then selectedServices.Add("Dancer")
        If chkVideoke.Checked Then selectedServices.Add("Videoke")

        lblServicesPaymentContainer.Text = String.Join(", ", selectedServices)
    End Sub
    Private Sub PopulateEventTypeCombo()
        cbEventType.Items.Clear()

        Dim query As String = "SELECT event_type FROM eventplace WHERE event_place = @event_place"

        Using connection As MySqlConnection = DBHelper.GetConnection()
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@event_place", EventPlaceName)

                Try
                    connection.Open()
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim eventTypes As String = reader("event_type").ToString()

                            Dim separatedTypes As String() = eventTypes.Split(","c)

                            For Each eventType As String In separatedTypes
                                cbEventType.Items.Add(eventType.Trim())
                            Next
                        End While
                    End Using
                    connection.Close()
                Catch ex As Exception
                    MessageBox.Show("Error loading event types: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub


    Dim bookedDates As New List(Of Date)

    Private Sub LoadBookedDates()
        Dim query As String = "SELECT DISTINCT event_date FROM Bookings WHERE place_id = @place_id"

        Using connection As MySqlConnection = DBHelper.GetConnection()
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@place_id", EventPlaceId)

                Try
                    connection.Open()
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            bookedDates.Add(Convert.ToDateTime(reader("event_date")))
                        End While
                    End Using
                    connection.Close()
                Catch ex As Exception
                    MessageBox.Show("Error loading booked dates: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub HighlightBookedDates()
        For Each bookedDate In bookedDates
            mcAvailability.BoldedDates = bookedDates.ToArray()
        Next
    End Sub


    Private Sub txtField_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumGuests.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Function CheckIfFirstTimeCustomer(customerId As Integer) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM Bookings WHERE customer_id = @customer_id"

        Using connection As MySqlConnection = DBHelper.GetConnection()
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@customer_id", customerId)

                Try
                    connection.Open()
                    Dim bookingCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    connection.Close()
                    Return bookingCount = 0
                Catch ex As Exception
                    MessageBox.Show("Error checking customer booking history: " & ex.Message)
                    Return False
                End Try
            End Using
        End Using
    End Function
    Private Function CheckIfLoyaltyCustomer(customerId As Integer) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM Bookings WHERE customer_id = @customer_id"

        Using connection As MySqlConnection = DBHelper.GetConnection()
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@customer_id", customerId)

                Try
                    connection.Open()
                    Dim bookingCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    connection.Close()
                    Return bookingCount >= 5 ' Example: Loyalty discount applies after 5 bookings
                Catch ex As Exception
                    MessageBox.Show("Error checking loyalty status: " & ex.Message)
                    Return False
                End Try
            End Using
        End Using
    End Function

End Class
