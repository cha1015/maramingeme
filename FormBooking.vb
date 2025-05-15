Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Globalization
Imports System.Text

Public Class FormBooking
    ' ------------------ Properties ------------------
    Public Property EventPlaceId As Integer
    Public Property EventPlaceName As String
    Public Property EventPlaceCapacity As Integer
    Public Property BasePricePerDay As Decimal
    Public Property EventPlaceFeatures As String
    Public Property EventVenueType As String
    Public Property OpeningHours As String
    Public Property ClosingHours As String
    Public Property AvailableDays As String
    Public Property EventPlaceDescription As String
    Public Property EventTime As String
    Public Property VoucherDiscount As Decimal = 0

    Private _customerId As Integer

    ' Booked Dates
    Dim bookedDates As New List(Of Date)

    ' ------------------ Constructor ------------------
    Public Sub New(customerId As Integer)
        InitializeComponent()
        _customerId = customerId
    End Sub

    ' ------------------ Form Load ------------------
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
        dtpEventDateStart.MinDate = Date.Today
        dtpEventDateEnd.MinDate = Date.Today

        ' Default to a same-day event
        cbSameDayEvent.Checked = True
        dtpEventDateEnd.Value = dtpEventDateStart.Value
        dtpEventDateEnd.Enabled = False ' Disable modification
        lblEventDatePaymentContainer.Text = dtpEventDateStart.Value.ToShortDateString()

        ComputeTotalPrice()
        PopulateEventTypeCombo()
        LoadBookedDates()
        HighlightBookedDates()
    End Sub

    ' ------------------ Event Handlers ------------------
    Private Sub dtpBirthday_ValueChanged(sender As Object, e As EventArgs) Handles dtpBirthday.ValueChanged
        Dim birthDate As Date = dtpBirthday.Value
        Dim today As Date = Date.Today
        Dim age As Integer = today.Year - birthDate.Year
        If birthDate > today.AddYears(-age) Then age -= 1
        txtAge.Text = age.ToString()
    End Sub

    Private Sub txtField_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumGuests.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtNumGuests_TextChanged(sender As Object, e As EventArgs) Handles txtNumGuests.TextChanged
        ComputeTotalPrice() ' Auto-update total price on guest input change
    End Sub

    Private Sub cbStartHour_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbStartHour.SelectedIndexChanged, cbStartMinutes.SelectedIndexChanged, cbStartAMPM.SelectedIndexChanged
        AdjustEndDateForOvernightEvent() ' Ensure overnight events update end date properly
    End Sub

    Private Sub chkCatering_CheckedChanged(sender As Object, e As EventArgs) Handles chkCatering.CheckedChanged, chkClown.CheckedChanged, chkSinger.CheckedChanged, chkDancer.CheckedChanged, chkVideoke.CheckedChanged
        ComputeTotalPrice() ' Auto-update total price when services are toggled
    End Sub

    ' ------------------ Button Click Events ------------------
    Private Sub cbSameDayEvent_CheckedChanged(sender As Object, e As EventArgs) Handles cbSameDayEvent.CheckedChanged
        If cbSameDayEvent.Checked Then
            ' Set end date to match start date
            dtpEventDateEnd.Value = dtpEventDateStart.Value
            dtpEventDateEnd.Enabled = False ' Prevent user modification

            ' Update payment details to show only one date
            lblEventDatePaymentContainer.Text = dtpEventDateStart.Value.ToShortDateString()
        Else
            dtpEventDateEnd.Enabled = True ' Allow user modification again

            ' Revert to showing date range
            lblEventDatePaymentContainer.Text = $"{dtpEventDateStart.Value.ToShortDateString()} - {dtpEventDateEnd.Value.ToShortDateString()}"
        End If
    End Sub

    Private Sub dtpEventDateStart_ValueChanged(sender As Object, e As EventArgs) Handles dtpEventDateStart.ValueChanged
        If cbSameDayEvent.Checked Then
            dtpEventDateEnd.Value = dtpEventDateStart.Value
        End If
    End Sub

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

        If String.IsNullOrWhiteSpace(cbStartHour.Text) OrElse String.IsNullOrWhiteSpace(cbStartMinutes.Text) OrElse String.IsNullOrWhiteSpace(cbStartAMPM.Text) OrElse
       String.IsNullOrWhiteSpace(cbEndHour.Text) OrElse String.IsNullOrWhiteSpace(cbEndMinutes.Text) OrElse String.IsNullOrWhiteSpace(cbEndAMPM.Text) Then
            MessageBox.Show("Please complete the event time selection.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim eventStartTime As DateTime
        Dim eventEndTime As DateTime
        Dim openingTime As DateTime
        Dim closingTime As DateTime
        Dim timeFormat As String = "h:mm tt"

        If Not DateTime.TryParseExact($"{cbStartHour.Text}:{cbStartMinutes.Text} {cbStartAMPM.Text}", timeFormat,
                                  System.Globalization.CultureInfo.InvariantCulture,
                                  System.Globalization.DateTimeStyles.None, eventStartTime) OrElse
       Not DateTime.TryParseExact($"{cbEndHour.Text}:{cbEndMinutes.Text} {cbEndAMPM.Text}", timeFormat,
                                  System.Globalization.CultureInfo.InvariantCulture,
                                  System.Globalization.DateTimeStyles.None, eventEndTime) OrElse
       Not DateTime.TryParse(OpeningHours, openingTime) OrElse
       Not DateTime.TryParse(ClosingHours, closingTime) Then
            MessageBox.Show("Invalid time format. Please select a valid time.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If (eventStartTime < openingTime OrElse eventEndTime > closingTime) AndAlso Not chkOutsideAvailableHours.Checked Then
            MessageBox.Show("Your selected time is outside the venue's available hours. To proceed, either adjust your time or check 'Book outside available hours' to accept the extra charge.",
                        "Time Restriction", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim finalTotalPrice As Decimal = ComputeTotalPrice()

        If chkOutsideAvailableHours.Checked Then
            Dim perMinuteRate As Decimal = 17D
            Dim additionalCharges As Decimal = 0D

            If eventStartTime < openingTime Then
                Dim earlyMinutes As Integer = Math.Max(0, CInt((openingTime - eventStartTime).TotalMinutes))
                additionalCharges += earlyMinutes * perMinuteRate
            End If

            If eventEndTime > closingTime Then
                Dim overtimeMinutes As Integer = Math.Max(0, CInt((eventEndTime - closingTime).TotalMinutes))
                additionalCharges += overtimeMinutes * perMinuteRate
            End If

            finalTotalPrice += additionalCharges
        End If

        txtTotalPrice.Text = "₱" & finalTotalPrice.ToString("F2")
        lblTotalPricePaymentContainer.Tag = finalTotalPrice
        lblTotalPricePaymentContainer.Text = txtTotalPrice.Text

        Dim confirmProceed As DialogResult = MessageBox.Show($"Total Price Updated: {txtTotalPrice.Text}. Do you want to proceed to customer details?",
                                                         "Price Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If confirmProceed = DialogResult.Yes Then tcDetails.SelectedTab = tpCustomerDetails
    End Sub

    Private Sub btnCustomerProceed_Click(sender As Object, e As EventArgs) Handles btnCustomerProceed.Click
        ' Validate customer details
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
        ' ✅ Age validation: Ensure booking is made by an adult
        Dim birthDate As Date = dtpBirthday.Value
        Dim today As Date = Date.Today
        Dim age As Integer = today.Year - birthDate.Year

        If birthDate > today.AddYears(-age) Then age -= 1 ' Adjust for leap years

        If age < 18 Then
            MessageBox.Show("Only individuals aged 18 or older can book. A parent or guardian must handle the booking.", "Age Restriction", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        PopulatePaymentDetails()
        tcDetails.SelectedTab = tpPaymentDetails
    End Sub
    Private Sub btnPlaceBooking_Click(sender As Object, e As EventArgs) Handles btnPlaceBooking.Click
        ' Validate customer creation before proceeding
        Dim birthDate As Date = dtpBirthday.Value
        Dim today As Date = Date.Today
        Dim age As Integer = today.Year - birthDate.Year
        If birthDate > today.AddYears(-age) Then age -= 1

        Dim customerResult As CustomerResult = CreateNewCustomer(txtCustomerName.Text, dtpBirthday.Value, cmbSex.Text, txtAddress.Text, age)

        If customerResult.CustomerId <= 0 Then
            MessageBox.Show($"Customer creation failed! Error: {customerResult.ErrorMessage}", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim newCustomerId As Integer = customerResult.CustomerId

        If EventPlaceId <= 0 Then
            MessageBox.Show("Error: No valid event place selected!", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Debug.WriteLine($"EventPlaceId: {EventPlaceId}")

        Dim insertBookingQuery As String = "INSERT INTO Bookings (customer_id, place_id, num_guests, event_date, event_time, event_end_time, total_price) VALUES (@customer_id, @place_id, @num_guests, @event_date, @event_time, @event_end_time, @total_price); SELECT LAST_INSERT_ID();"

        ' ✅ Convert user-selected time for MySQL format
        Dim eventStartTime As DateTime = DateTime.Parse($"{cbStartHour.Text}:{cbStartMinutes.Text} {cbStartAMPM.Text}")
        Dim eventEndTime As DateTime = DateTime.Parse($"{cbEndHour.Text}:{cbEndMinutes.Text} {cbEndAMPM.Text}")
        Dim mysqlEventStartTime As String = eventStartTime.ToString("HH:mm:ss")
        Dim mysqlEventEndTime As String = eventEndTime.ToString("HH:mm:ss")

        ' ✅ Handle overnight booking
        Dim eventDateStart As Date = dtpEventDateStart.Value.Date
        Dim eventDateEnd As Date = dtpEventDateEnd.Value.Date
        If eventEndTime < eventStartTime Then
            eventDateEnd = eventDateStart.AddDays(1) ' Adjust for next day booking
            cbSameDayEvent.Checked = False
            dtpEventDateEnd.Value = eventDateEnd
        End If

        Using connection As MySqlConnection = DBHelper.GetConnection()
            connection.Open() ' Ensure connection is opened before commands

            Using cmd As New MySqlCommand(insertBookingQuery, connection)
                cmd.Parameters.AddWithValue("@customer_id", newCustomerId)
                cmd.Parameters.AddWithValue("@place_id", EventPlaceId)

                Dim numGuests As Integer
                If Not Integer.TryParse(txtNumGuests.Text, numGuests) Then
                    MessageBox.Show("Invalid guest count! Please enter a number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
                cmd.Parameters.AddWithValue("@num_guests", numGuests)

                cmd.Parameters.AddWithValue("@event_date", eventDateStart)
                cmd.Parameters.AddWithValue("@event_time", mysqlEventStartTime)
                cmd.Parameters.AddWithValue("@event_end_time", mysqlEventEndTime)
                cmd.Parameters.AddWithValue("@total_price", txtTotalPrice.Text.Replace("₱", "")) ' Ensure correct format

                Try
                    Dim bookingId As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    If bookingId > 0 Then
                        SaveBookingServices(bookingId)
                        MessageBox.Show("Booking successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Booking failed! Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If

                Catch ex As MySqlException
                    MessageBox.Show($"MySQL Error ({ex.Number}): {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Catch ex As Exception
                    MessageBox.Show("Unexpected Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
            connection.Close() ' Close connection at the end
        End Using
    End Sub


    ' ------------------ Helper Methods ------------------
    Private Sub PopulatePaymentDetails()
        lblCustomerContainer.Text = txtCustomerName.Text
        lblEventPlacePaymentContainer.Text = lblEventPlace.Text
        lblEventTypePaymentContainer.Text = cbEventType.Text
        lblNumGuestsPaymentContainer.Text = txtNumGuests.Text
        If cbSameDayEvent.Checked Then
            lblEventDatePaymentContainer.Text = dtpEventDateStart.Value.ToShortDateString()
        Else
            lblEventDatePaymentContainer.Text = $"{dtpEventDateStart.Value.ToShortDateString()} - {dtpEventDateEnd.Value.ToShortDateString()}"
        End If

        Dim startTime As String = $"{cbStartHour.Text}:{cbStartMinutes.Text} {cbStartAMPM.Text}"
        Dim endTime As String = $"{cbEndHour.Text}:{cbEndMinutes.Text} {cbEndAMPM.Text}"
        lblEventTimePaymentContainer.Text = $"{startTime} - {endTime}"

        Dim selectedServices As New List(Of String)
        If chkCatering.Checked Then selectedServices.Add("Catering")
        If chkClown.Checked Then selectedServices.Add("Clown")
        If chkSinger.Checked Then selectedServices.Add("Singer")
        If chkDancer.Checked Then selectedServices.Add("Dancer")
        If chkVideoke.Checked Then selectedServices.Add("Videoke")

        If selectedServices.Count > 0 Then
            lblServicesPaymentContainer.Text = String.Join(", ", selectedServices)
        Else
            lblServicesPaymentContainer.Text = "No additional services selected"
        End If

        lblTotalPricePaymentContainer.Text = txtTotalPrice.Text
    End Sub

    Private Function ComputeTotalPrice() As Decimal
        Dim numGuests As Integer
        If Not Integer.TryParse(txtNumGuests.Text, numGuests) Then numGuests = 0

        Dim excessCost As Integer = If(numGuests > EventPlaceCapacity, (numGuests - EventPlaceCapacity) * 100, 0)

        Dim servicesCost As Decimal = 0D
        Dim cateringRatePerGuest As Decimal = 400D
        Dim clownRatePerGuest As Decimal = 200D
        Dim singerRatePerGuest As Decimal = 140D
        Dim dancerRatePerGuest As Decimal = 140D
        Dim videokeRatePerGuest As Decimal = 20D

        If chkCatering.Checked Then servicesCost += cateringRatePerGuest * numGuests
        If chkClown.Checked Then servicesCost += clownRatePerGuest * numGuests
        If chkSinger.Checked Then servicesCost += singerRatePerGuest * numGuests
        If chkDancer.Checked Then servicesCost += dancerRatePerGuest * numGuests
        If chkVideoke.Checked Then servicesCost += videokeRatePerGuest * numGuests

        Dim totalPrice As Decimal = BasePricePerDay + excessCost + servicesCost

        If VoucherDiscount > 0 Then totalPrice -= totalPrice * VoucherDiscount

        Return totalPrice
    End Function

    Private Sub UpdateTotalPrice() Handles cbEndHour.SelectedIndexChanged, cbEndMinutes.SelectedIndexChanged, cbEndAMPM.SelectedIndexChanged,
                               cbStartHour.SelectedIndexChanged, cbStartMinutes.SelectedIndexChanged, cbStartAMPM.SelectedIndexChanged,
                               txtNumGuests.TextChanged, chkCatering.CheckedChanged, chkClown.CheckedChanged,
                               chkSinger.CheckedChanged, chkDancer.CheckedChanged, chkVideoke.CheckedChanged,
                               chkOutsideAvailableHours.CheckedChanged

        Dim finalTotalPrice As Decimal = ComputeTotalPrice()

        If String.IsNullOrWhiteSpace(cbEndHour.Text) OrElse String.IsNullOrWhiteSpace(cbEndMinutes.Text) OrElse String.IsNullOrWhiteSpace(cbEndAMPM.Text) OrElse
       String.IsNullOrWhiteSpace(cbStartHour.Text) OrElse String.IsNullOrWhiteSpace(cbStartMinutes.Text) OrElse String.IsNullOrWhiteSpace(cbStartAMPM.Text) Then
            chkOutsideAvailableHours.Checked = False
            chkOutsideAvailableHours.Enabled = False
            Exit Sub
        End If

        Dim timeFormat As String = "hh:mm tt"
        Dim eventStartTime As DateTime
        Dim eventEndTime As DateTime
        Dim openingTime As DateTime
        Dim closingTime As DateTime

        If Not DateTime.TryParseExact($"{cbStartHour.Text}:{cbStartMinutes.Text} {cbStartAMPM.Text}", timeFormat,
                                  System.Globalization.CultureInfo.InvariantCulture, DateTimeStyles.None, eventStartTime) OrElse
       Not DateTime.TryParseExact($"{cbEndHour.Text}:{cbEndMinutes.Text} {cbEndAMPM.Text}", timeFormat,
                                  System.Globalization.CultureInfo.InvariantCulture, DateTimeStyles.None, eventEndTime) OrElse
       Not DateTime.TryParse(OpeningHours, openingTime) OrElse
       Not DateTime.TryParse(ClosingHours, closingTime) Then
            MessageBox.Show("Invalid time format. Please select a valid time.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Adjust closing time if it spans midnight
        If closingTime < openingTime Then closingTime = closingTime.AddDays(1)

        ' Adjust event end time to ensure correct comparison
        If eventEndTime < eventStartTime Then eventEndTime = eventEndTime.AddDays(1)

        ' Fix validation logic for outside hours
        Dim isOutsideHours As Boolean = (eventStartTime < openingTime) OrElse (eventEndTime > closingTime)

        chkOutsideAvailableHours.Enabled = isOutsideHours
        If Not isOutsideHours Then chkOutsideAvailableHours.Checked = False

        ' Avoid incorrectly adding fees when inside hours
        Dim additionalCharges As Decimal = 0D
        Dim perMinuteRate As Decimal = 17D

        If chkOutsideAvailableHours.Checked Then
            If eventStartTime < openingTime Then
                Dim earlyMinutes As Integer = Math.Max(0, CInt((openingTime - eventStartTime).TotalMinutes))
                additionalCharges += earlyMinutes * perMinuteRate
            End If

            If eventEndTime > closingTime Then
                Dim overtimeMinutes As Integer = Math.Max(0, CInt((eventEndTime - closingTime).TotalMinutes))
                additionalCharges += overtimeMinutes * perMinuteRate
            End If
        End If

        ' **Fix Multi-Day Booking Logic**
        Dim totalDays As Integer = (dtpEventDateEnd.Value - dtpEventDateStart.Value).Days + 1
        finalTotalPrice *= totalDays

        finalTotalPrice += additionalCharges

        txtTotalPrice.Text = "₱" & finalTotalPrice.ToString("F2")
        lblTotalPricePaymentContainer.Text = txtTotalPrice.Text
        lblTotalPricePaymentContainer.Tag = finalTotalPrice

        ' *** Integrate Detailed Price Breakdown Here ***
        Dim breakdown As New StringBuilder()
        breakdown.AppendLine($"Base Price (x{totalDays} days): ₱{BasePricePerDay * totalDays:F2}")
        breakdown.AppendLine($"Total: ₱{finalTotalPrice:F2}")

        Dim numGuests As Integer
        If Not Integer.TryParse(txtNumGuests.Text, numGuests) Then numGuests = 0

        Dim excessCost As Integer = If(numGuests > EventPlaceCapacity, (numGuests - EventPlaceCapacity) * 100, 0)
        If excessCost > 0 Then breakdown.AppendLine($"Guest Capacity Exceeded Fee: ₱{excessCost:F2}")

        Dim servicesCost As Decimal = 0D
        Dim cateringRatePerGuest As Decimal = 400D
        Dim clownRatePerGuest As Decimal = 200D
        Dim singerRatePerGuest As Decimal = 140D
        Dim dancerRatePerGuest As Decimal = 140D
        Dim videokeRatePerGuest As Decimal = 20D

        If chkCatering.Checked Then
            Dim cost = cateringRatePerGuest * numGuests
            servicesCost += cost
            breakdown.AppendLine($"Catering: ₱{cost:F2}")
        End If

        If chkClown.Checked Then
            Dim cost = clownRatePerGuest * numGuests
            servicesCost += cost
            breakdown.AppendLine($"Clown Entertainment: ₱{cost:F2}")
        End If

        If chkSinger.Checked Then
            Dim cost = singerRatePerGuest * numGuests
            servicesCost += cost
            breakdown.AppendLine($"Singer Performance: ₱{cost:F2}")
        End If

        If chkDancer.Checked Then
            Dim cost = dancerRatePerGuest * numGuests
            servicesCost += cost
            breakdown.AppendLine($"Dancer Performance: ₱{cost:F2}")
        End If

        If chkVideoke.Checked Then
            Dim cost = videokeRatePerGuest * numGuests
            servicesCost += cost
            breakdown.AppendLine($"Videoke Rental: ₱{cost:F2}")
        End If

        If servicesCost > 0 Then breakdown.AppendLine($"Total Services Fee: ₱{servicesCost:F2}")

        If totalDays > 1 Then breakdown.AppendLine($"Multi-Day Fee ({totalDays} days): ₱{BasePricePerDay * totalDays:F2}")

        If chkOutsideAvailableHours.Checked AndAlso additionalCharges > 0 Then
            breakdown.AppendLine($"Outside Available Hours Fee: ₱{additionalCharges:F2}")
        End If

        If VoucherDiscount > 0 Then
            Dim discountAmount As Decimal = finalTotalPrice * VoucherDiscount
            breakdown.AppendLine($"Voucher Discount ({VoucherDiscount * 100}%): -₱{discountAmount:F2}")
        End If

        breakdown.AppendLine($"Total: ₱{finalTotalPrice:F2}")

        lblPriceBreakdown.Text = breakdown.ToString()
    End Sub

    Private Function CalculateOvertimeFee() As Decimal
        Dim eventEndTime As DateTime
        Dim closingTime As DateTime
        Dim overtimeFee As Decimal = 0D

        Dim timeFormat As String = "hh:mm tt"

        If DateTime.TryParseExact($"{cbEndHour.Text}:{cbEndMinutes.Text} {cbEndAMPM.Text}", timeFormat,
                              System.Globalization.CultureInfo.InvariantCulture,
                              System.Globalization.DateTimeStyles.None, eventEndTime) AndAlso
       DateTime.TryParse(ClosingHours, closingTime) Then

            ' Calculate overtime fee if applicable
            If eventEndTime > closingTime Then
                Dim overtimeMinutes As Integer = Math.Max(0, CInt((eventEndTime - closingTime).TotalMinutes))
                overtimeFee = (overtimeMinutes / 60) * 1000D
            End If
        End If

        Return overtimeFee
    End Function


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

    Private Function CreateNewCustomer(name As String, birthday As Date, sex As String, address As String, age As Integer) As CustomerResult
        Dim result As New CustomerResult()
        Dim insertQuery As String = "INSERT INTO Customers (name, birthday, sex, address, age) VALUES (@name, @birthday, @sex, @address, @age); SELECT LAST_INSERT_ID();"

        Using connection As MySqlConnection = DBHelper.GetConnection()
            Using cmd As New MySqlCommand(insertQuery, connection)
                cmd.Parameters.AddWithValue("@name", name)
                cmd.Parameters.AddWithValue("@birthday", birthday)
                cmd.Parameters.AddWithValue("@sex", sex)
                cmd.Parameters.AddWithValue("@address", address)
                cmd.Parameters.AddWithValue("@age", age)

                Try
                    connection.Open()
                    result.CustomerId = Convert.ToInt32(cmd.ExecuteScalar())
                    connection.Close()
                    result.ErrorMessage = String.Empty ' No error
                Catch ex As Exception
                    result.CustomerId = -1
                    result.ErrorMessage = $"Database Error: {ex.Message}"
                End Try
            End Using
        End Using

        Return result
    End Function

    Private Sub AdjustEndDateForOvernightEvent()
        ' Ensure all combo boxes have valid values
        If String.IsNullOrWhiteSpace(cbStartHour.Text) OrElse
           String.IsNullOrWhiteSpace(cbStartMinutes.Text) OrElse
           String.IsNullOrWhiteSpace(cbStartAMPM.Text) OrElse
           String.IsNullOrWhiteSpace(cbEndHour.Text) OrElse
           String.IsNullOrWhiteSpace(cbEndMinutes.Text) OrElse
           String.IsNullOrWhiteSpace(cbEndAMPM.Text) Then
            Exit Sub ' Prevent execution if any value is missing
        End If

        ' Construct time strings carefully
        Dim startTimeStr As String = $"{cbStartHour.Text.Trim()}:{cbStartMinutes.Text.Trim()} {cbStartAMPM.Text.Trim()}"
        Dim endTimeStr As String = $"{cbEndHour.Text.Trim()}:{cbEndMinutes.Text.Trim()} {cbEndAMPM.Text.Trim()}"

        Dim selectedStartTime As DateTime
        Dim selectedEndTime As DateTime

        ' Safely parse start time
        If Not DateTime.TryParseExact(startTimeStr, "h:mm tt", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, selectedStartTime) Then
            MessageBox.Show($"Invalid start time format: {startTimeStr}", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Safely parse end time
        If Not DateTime.TryParseExact(endTimeStr, "h:mm tt", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, selectedEndTime) Then
            MessageBox.Show($"Invalid end time format: {endTimeStr}", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Adjust date if event goes past midnight
        If selectedEndTime < selectedStartTime Then
            cbSameDayEvent.Checked = False
            dtpEventDateEnd.Value = dtpEventDateStart.Value.AddDays(1)
            dtpEventDateEnd.Enabled = False
            lblEventDatePaymentContainer.Text = $"{dtpEventDateStart.Value.ToShortDateString()} - {dtpEventDateEnd.Value.ToShortDateString()}"
        Else
            cbSameDayEvent.Checked = True
            dtpEventDateEnd.Value = dtpEventDateStart.Value
            dtpEventDateEnd.Enabled = True
            lblEventDatePaymentContainer.Text = dtpEventDateStart.Value.ToShortDateString()
        End If

    End Sub

    Private Sub tcDetails_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles tcDetails.Selecting
        ' ✅ Prevent switching to Customer Details unless all Booking Details fields are filled
        If e.TabPage Is tpCustomerDetails Then
            If String.IsNullOrWhiteSpace(cbEventType.Text) OrElse
           String.IsNullOrWhiteSpace(txtNumGuests.Text) OrElse Not IsNumeric(txtNumGuests.Text) OrElse
           dtpEventDateStart.Value.Date < Date.Today OrElse
           dtpEventDateEnd.Value.Date < dtpEventDateStart.Value.Date OrElse
           String.IsNullOrWhiteSpace(cbStartHour.Text) OrElse String.IsNullOrWhiteSpace(cbStartMinutes.Text) OrElse String.IsNullOrWhiteSpace(cbStartAMPM.Text) OrElse
           String.IsNullOrWhiteSpace(cbEndHour.Text) OrElse String.IsNullOrWhiteSpace(cbEndMinutes.Text) OrElse String.IsNullOrWhiteSpace(cbEndAMPM.Text) Then
                MessageBox.Show("Please complete all fields before proceeding.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                e.Cancel = True ' Stop tab change
                Exit Sub
            End If
        End If

        ' ✅ Prevent switching to Payment Details unless all Customer Details fields are filled
        If e.TabPage Is tpPaymentDetails Then
            If String.IsNullOrWhiteSpace(txtCustomerName.Text) OrElse
           dtpBirthday.Value.Date > Date.Today OrElse
           String.IsNullOrWhiteSpace(cmbSex.Text) OrElse
           String.IsNullOrWhiteSpace(txtAddress.Text) Then
                MessageBox.Show("Please complete all fields before proceeding.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                e.Cancel = True ' Stop tab change
                Exit Sub
            End If
        End If
    End Sub


    Private Function IsValidTimeSelection() As Boolean
        Dim eventEndTime As DateTime
        Dim timeFormat As String = "h:mm tt"

        ' Ensure time fields are not empty
        If String.IsNullOrWhiteSpace(cbEndHour.Text) OrElse String.IsNullOrWhiteSpace(cbEndMinutes.Text) OrElse String.IsNullOrWhiteSpace(cbEndAMPM.Text) Then
            Return False
        End If

        ' Validate format
        If Not DateTime.TryParseExact($"{cbEndHour.Text}:{cbEndMinutes.Text} {cbEndAMPM.Text}", timeFormat,
                                  System.Globalization.CultureInfo.InvariantCulture,
                                  System.Globalization.DateTimeStyles.None, eventEndTime) Then
            Return False
        End If

        Return True
    End Function

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub lblCapacityContainer_Click(sender As Object, e As EventArgs) Handles lblCapacityContainer.Click

    End Sub

    Private Sub lblAvailableDaysContainer_Click(sender As Object, e As EventArgs) Handles lblAvailableDaysContainer.Click

    End Sub

    Private Sub tpPaymentDetails_Click(sender As Object, e As EventArgs) Handles tpPaymentDetails.Click

    End Sub

    Private Sub lblPriceBreakdown_Click(sender As Object, e As EventArgs) Handles lblPriceBreakdown.Click

    End Sub
End Class
