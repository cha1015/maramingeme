<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBooking
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblFeaturesContainer = New System.Windows.Forms.Label()
        Me.lblPricePerDayContainer = New System.Windows.Forms.Label()
        Me.lblCapacityContainer = New System.Windows.Forms.Label()
        Me.lblPlaceIDContainer = New System.Windows.Forms.Label()
        Me.lblFeatures = New System.Windows.Forms.Label()
        Me.lblPricePerDay = New System.Windows.Forms.Label()
        Me.lblCapacity = New System.Windows.Forms.Label()
        Me.lblPlaceID = New System.Windows.Forms.Label()
        Me.lblEventPlace = New System.Windows.Forms.Label()
        Me.lblEventSchedule = New System.Windows.Forms.Label()
        Me.btBookingProceed = New System.Windows.Forms.Button()
        Me.chkVideoke = New System.Windows.Forms.CheckBox()
        Me.chkDancer = New System.Windows.Forms.CheckBox()
        Me.chkSinger = New System.Windows.Forms.CheckBox()
        Me.chkClown = New System.Windows.Forms.CheckBox()
        Me.chkCatering = New System.Windows.Forms.CheckBox()
        Me.dtpEventDateStart = New System.Windows.Forms.DateTimePicker()
        Me.txtNumGuests = New System.Windows.Forms.TextBox()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.lblServicesAvailed = New System.Windows.Forms.Label()
        Me.lblEventDateStart = New System.Windows.Forms.Label()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.lblNumGuests = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblDescriptionContainer = New System.Windows.Forms.Label()
        Me.dtpEventDateEnd = New System.Windows.Forms.DateTimePicker()
        Me.lblEnd = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblEventTimeEnd = New System.Windows.Forms.Label()
        Me.lblEventTimeStart = New System.Windows.Forms.Label()
        Me.lblAvailability = New System.Windows.Forms.Label()
        Me.tcDetails = New System.Windows.Forms.TabControl()
        Me.tpBookingDetails = New System.Windows.Forms.TabPage()
        Me.pnlBookingDetails = New System.Windows.Forms.Panel()
        Me.chkOutsideAvailableHours = New System.Windows.Forms.CheckBox()
        Me.cbSameDayEvent = New System.Windows.Forms.CheckBox()
        Me.cbEndAMPM = New System.Windows.Forms.ComboBox()
        Me.cbEndMinutes = New System.Windows.Forms.ComboBox()
        Me.cbEndHour = New System.Windows.Forms.ComboBox()
        Me.cbStartAMPM = New System.Windows.Forms.ComboBox()
        Me.cbStartMinutes = New System.Windows.Forms.ComboBox()
        Me.cbStartHour = New System.Windows.Forms.ComboBox()
        Me.lblEventType = New System.Windows.Forms.Label()
        Me.cbEventType = New System.Windows.Forms.ComboBox()
        Me.tpCustomerDetails = New System.Windows.Forms.TabPage()
        Me.pnlCustomerDetails = New System.Windows.Forms.Panel()
        Me.btnCustomerProceed = New System.Windows.Forms.Button()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblSex = New System.Windows.Forms.Label()
        Me.cmbSex = New System.Windows.Forms.ComboBox()
        Me.lblBirthday = New System.Windows.Forms.Label()
        Me.dtpBirthday = New System.Windows.Forms.DateTimePicker()
        Me.tpPaymentDetails = New System.Windows.Forms.TabPage()
        Me.lblOffHoursMinutesContainer = New System.Windows.Forms.Label()
        Me.lblOffHoursTotalFeeContainer = New System.Windows.Forms.Label()
        Me.lblOffHoursBookingFee = New System.Windows.Forms.Label()
        Me.lblSelectedVoucherContainer = New System.Windows.Forms.Label()
        Me.lblSelectedVoucher = New System.Windows.Forms.Label()
        Me.btnPlaceBooking = New System.Windows.Forms.Button()
        Me.lblVoucherDiscountContainer = New System.Windows.Forms.Label()
        Me.lblVoucherDiscount = New System.Windows.Forms.Label()
        Me.lblVoucher = New System.Windows.Forms.Label()
        Me.btnVoucher = New System.Windows.Forms.Button()
        Me.txtPayAmount = New System.Windows.Forms.TextBox()
        Me.lblPayAmount = New System.Windows.Forms.Label()
        Me.lblTotalPricePaymentContainer = New System.Windows.Forms.Label()
        Me.lblTotalPricePayment = New System.Windows.Forms.Label()
        Me.lblServicesPaymentContainer = New System.Windows.Forms.Label()
        Me.lblServicesPayment = New System.Windows.Forms.Label()
        Me.lblEventTimePaymentContainer = New System.Windows.Forms.Label()
        Me.lblEventTimePayment = New System.Windows.Forms.Label()
        Me.lblEventDatePaymentContainer = New System.Windows.Forms.Label()
        Me.lblEventDatePayment = New System.Windows.Forms.Label()
        Me.lblNumGuestsPaymentContainer = New System.Windows.Forms.Label()
        Me.lblNumGuestsPayment = New System.Windows.Forms.Label()
        Me.lblEventTypePaymentContainer = New System.Windows.Forms.Label()
        Me.lblEventTypePayment = New System.Windows.Forms.Label()
        Me.lblEventPlacePaymentContainer = New System.Windows.Forms.Label()
        Me.lblEventPlacePayment = New System.Windows.Forms.Label()
        Me.lblCustomerContainer = New System.Windows.Forms.Label()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.lblHoursContainer = New System.Windows.Forms.Label()
        Me.lblAvailableDaysContainer = New System.Windows.Forms.Label()
        Me.mcAvailability = New System.Windows.Forms.MonthCalendar()
        Me.lblCapacityExceedanceFee = New System.Windows.Forms.Label()
        Me.lblBeyondAvailabilityFee = New System.Windows.Forms.Label()
        Me.lblPriceBreakdown = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcDetails.SuspendLayout()
        Me.tpBookingDetails.SuspendLayout()
        Me.pnlBookingDetails.SuspendLayout()
        Me.tpCustomerDetails.SuspendLayout()
        Me.pnlCustomerDetails.SuspendLayout()
        Me.tpPaymentDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFeaturesContainer
        '
        Me.lblFeaturesContainer.AutoSize = True
        Me.lblFeaturesContainer.Location = New System.Drawing.Point(209, 675)
        Me.lblFeaturesContainer.Name = "lblFeaturesContainer"
        Me.lblFeaturesContainer.Size = New System.Drawing.Size(10, 13)
        Me.lblFeaturesContainer.TabIndex = 19
        Me.lblFeaturesContainer.Text = "-"
        '
        'lblPricePerDayContainer
        '
        Me.lblPricePerDayContainer.AutoSize = True
        Me.lblPricePerDayContainer.Location = New System.Drawing.Point(514, 560)
        Me.lblPricePerDayContainer.Name = "lblPricePerDayContainer"
        Me.lblPricePerDayContainer.Size = New System.Drawing.Size(13, 13)
        Me.lblPricePerDayContainer.TabIndex = 18
        Me.lblPricePerDayContainer.Text = "0"
        '
        'lblCapacityContainer
        '
        Me.lblCapacityContainer.AutoSize = True
        Me.lblCapacityContainer.Location = New System.Drawing.Point(372, 560)
        Me.lblCapacityContainer.Name = "lblCapacityContainer"
        Me.lblCapacityContainer.Size = New System.Drawing.Size(13, 13)
        Me.lblCapacityContainer.TabIndex = 17
        Me.lblCapacityContainer.Text = "0"
        '
        'lblPlaceIDContainer
        '
        Me.lblPlaceIDContainer.AutoSize = True
        Me.lblPlaceIDContainer.Location = New System.Drawing.Point(225, 560)
        Me.lblPlaceIDContainer.Name = "lblPlaceIDContainer"
        Me.lblPlaceIDContainer.Size = New System.Drawing.Size(13, 13)
        Me.lblPlaceIDContainer.TabIndex = 16
        Me.lblPlaceIDContainer.Text = "0"
        '
        'lblFeatures
        '
        Me.lblFeatures.AutoSize = True
        Me.lblFeatures.Location = New System.Drawing.Point(176, 660)
        Me.lblFeatures.Name = "lblFeatures"
        Me.lblFeatures.Size = New System.Drawing.Size(48, 13)
        Me.lblFeatures.TabIndex = 15
        Me.lblFeatures.Text = "Features"
        '
        'lblPricePerDay
        '
        Me.lblPricePerDay.AutoSize = True
        Me.lblPricePerDay.Location = New System.Drawing.Point(437, 545)
        Me.lblPricePerDay.Name = "lblPricePerDay"
        Me.lblPricePerDay.Size = New System.Drawing.Size(71, 13)
        Me.lblPricePerDay.TabIndex = 12
        Me.lblPricePerDay.Text = "Price per Day"
        '
        'lblCapacity
        '
        Me.lblCapacity.AutoSize = True
        Me.lblCapacity.Location = New System.Drawing.Point(318, 545)
        Me.lblCapacity.Name = "lblCapacity"
        Me.lblCapacity.Size = New System.Drawing.Size(48, 13)
        Me.lblCapacity.TabIndex = 11
        Me.lblCapacity.Text = "Capacity"
        '
        'lblPlaceID
        '
        Me.lblPlaceID.AutoSize = True
        Me.lblPlaceID.Location = New System.Drawing.Point(171, 545)
        Me.lblPlaceID.Name = "lblPlaceID"
        Me.lblPlaceID.Size = New System.Drawing.Size(48, 13)
        Me.lblPlaceID.TabIndex = 8
        Me.lblPlaceID.Text = "Place ID"
        '
        'lblEventPlace
        '
        Me.lblEventPlace.AutoSize = True
        Me.lblEventPlace.Location = New System.Drawing.Point(171, 530)
        Me.lblEventPlace.Name = "lblEventPlace"
        Me.lblEventPlace.Size = New System.Drawing.Size(65, 13)
        Me.lblEventPlace.TabIndex = 9
        Me.lblEventPlace.Text = "Event Place"
        '
        'lblEventSchedule
        '
        Me.lblEventSchedule.AutoSize = True
        Me.lblEventSchedule.Location = New System.Drawing.Point(11, 71)
        Me.lblEventSchedule.Name = "lblEventSchedule"
        Me.lblEventSchedule.Size = New System.Drawing.Size(83, 13)
        Me.lblEventSchedule.TabIndex = 21
        Me.lblEventSchedule.Text = "Event Schedule"
        '
        'btBookingProceed
        '
        Me.btBookingProceed.Location = New System.Drawing.Point(638, 365)
        Me.btBookingProceed.Name = "btBookingProceed"
        Me.btBookingProceed.Size = New System.Drawing.Size(110, 23)
        Me.btBookingProceed.TabIndex = 20
        Me.btBookingProceed.Text = "Proceed"
        Me.btBookingProceed.UseVisualStyleBackColor = True
        '
        'chkVideoke
        '
        Me.chkVideoke.AutoSize = True
        Me.chkVideoke.Location = New System.Drawing.Point(274, 265)
        Me.chkVideoke.Name = "chkVideoke"
        Me.chkVideoke.Size = New System.Drawing.Size(140, 17)
        Me.chkVideoke.TabIndex = 18
        Me.chkVideoke.Text = "Videoke (₱20 per guest)"
        Me.chkVideoke.UseVisualStyleBackColor = True
        '
        'chkDancer
        '
        Me.chkDancer.AutoSize = True
        Me.chkDancer.Location = New System.Drawing.Point(274, 244)
        Me.chkDancer.Name = "chkDancer"
        Me.chkDancer.Size = New System.Drawing.Size(142, 17)
        Me.chkDancer.TabIndex = 17
        Me.chkDancer.Text = "Dancer (₱140 per guest)"
        Me.chkDancer.UseVisualStyleBackColor = True
        '
        'chkSinger
        '
        Me.chkSinger.AutoSize = True
        Me.chkSinger.Location = New System.Drawing.Point(116, 288)
        Me.chkSinger.Name = "chkSinger"
        Me.chkSinger.Size = New System.Drawing.Size(137, 17)
        Me.chkSinger.TabIndex = 16
        Me.chkSinger.Text = "Singer (₱140 per guest)"
        Me.chkSinger.UseVisualStyleBackColor = True
        '
        'chkClown
        '
        Me.chkClown.AutoSize = True
        Me.chkClown.Location = New System.Drawing.Point(116, 265)
        Me.chkClown.Name = "chkClown"
        Me.chkClown.Size = New System.Drawing.Size(136, 17)
        Me.chkClown.TabIndex = 15
        Me.chkClown.Text = "Clown (₱200 per guest)"
        Me.chkClown.UseVisualStyleBackColor = True
        '
        'chkCatering
        '
        Me.chkCatering.AutoSize = True
        Me.chkCatering.Location = New System.Drawing.Point(116, 243)
        Me.chkCatering.Name = "chkCatering"
        Me.chkCatering.Size = New System.Drawing.Size(146, 17)
        Me.chkCatering.TabIndex = 14
        Me.chkCatering.Text = "Catering (₱400 per guest)"
        Me.chkCatering.UseVisualStyleBackColor = True
        '
        'dtpEventDateStart
        '
        Me.dtpEventDateStart.Location = New System.Drawing.Point(113, 106)
        Me.dtpEventDateStart.Name = "dtpEventDateStart"
        Me.dtpEventDateStart.Size = New System.Drawing.Size(226, 20)
        Me.dtpEventDateStart.TabIndex = 13
        '
        'txtNumGuests
        '
        Me.txtNumGuests.Location = New System.Drawing.Point(109, 44)
        Me.txtNumGuests.Name = "txtNumGuests"
        Me.txtNumGuests.Size = New System.Drawing.Size(226, 20)
        Me.txtNumGuests.TabIndex = 0
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.AutoSize = True
        Me.lblTotalPrice.Location = New System.Drawing.Point(17, 321)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(58, 13)
        Me.lblTotalPrice.TabIndex = 12
        Me.lblTotalPrice.Text = "Total Price"
        '
        'lblServicesAvailed
        '
        Me.lblServicesAvailed.AutoSize = True
        Me.lblServicesAvailed.Location = New System.Drawing.Point(17, 243)
        Me.lblServicesAvailed.Name = "lblServicesAvailed"
        Me.lblServicesAvailed.Size = New System.Drawing.Size(86, 13)
        Me.lblServicesAvailed.TabIndex = 11
        Me.lblServicesAvailed.Text = "Services Availed"
        '
        'lblEventDateStart
        '
        Me.lblEventDateStart.AutoSize = True
        Me.lblEventDateStart.Location = New System.Drawing.Point(69, 112)
        Me.lblEventDateStart.Name = "lblEventDateStart"
        Me.lblEventDateStart.Size = New System.Drawing.Size(29, 13)
        Me.lblEventDateStart.TabIndex = 9
        Me.lblEventDateStart.Text = "Start"
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Location = New System.Drawing.Point(114, 318)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.ReadOnly = True
        Me.txtTotalPrice.Size = New System.Drawing.Size(226, 20)
        Me.txtTotalPrice.TabIndex = 6
        '
        'lblNumGuests
        '
        Me.lblNumGuests.AutoSize = True
        Me.lblNumGuests.Location = New System.Drawing.Point(11, 47)
        Me.lblNumGuests.Name = "lblNumGuests"
        Me.lblNumGuests.Size = New System.Drawing.Size(92, 13)
        Me.lblNumGuests.TabIndex = 8
        Me.lblNumGuests.Text = "Number of Guests"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(23, 25)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(31, 33)
        Me.btnBack.TabIndex = 19
        Me.btnBack.Text = "←"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(60, 25)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(31, 33)
        Me.btnNext.TabIndex = 29
        Me.btnNext.Text = "→"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 92)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(613, 411)
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(176, 690)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(60, 13)
        Me.lblDescription.TabIndex = 31
        Me.lblDescription.Text = "Description"
        '
        'lblDescriptionContainer
        '
        Me.lblDescriptionContainer.AutoSize = True
        Me.lblDescriptionContainer.Location = New System.Drawing.Point(209, 705)
        Me.lblDescriptionContainer.Name = "lblDescriptionContainer"
        Me.lblDescriptionContainer.Size = New System.Drawing.Size(10, 13)
        Me.lblDescriptionContainer.TabIndex = 32
        Me.lblDescriptionContainer.Text = "-"
        '
        'dtpEventDateEnd
        '
        Me.dtpEventDateEnd.Location = New System.Drawing.Point(113, 132)
        Me.dtpEventDateEnd.Name = "dtpEventDateEnd"
        Me.dtpEventDateEnd.Size = New System.Drawing.Size(226, 20)
        Me.dtpEventDateEnd.TabIndex = 24
        '
        'lblEnd
        '
        Me.lblEnd.AutoSize = True
        Me.lblEnd.Location = New System.Drawing.Point(72, 137)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(26, 13)
        Me.lblEnd.TabIndex = 23
        Me.lblEnd.Text = "End"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(43, 94)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(30, 13)
        Me.lblDate.TabIndex = 25
        Me.lblDate.Text = "Date"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(43, 153)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(30, 13)
        Me.lblTime.TabIndex = 26
        Me.lblTime.Text = "Time"
        '
        'lblEventTimeEnd
        '
        Me.lblEventTimeEnd.AutoSize = True
        Me.lblEventTimeEnd.Location = New System.Drawing.Point(72, 196)
        Me.lblEventTimeEnd.Name = "lblEventTimeEnd"
        Me.lblEventTimeEnd.Size = New System.Drawing.Size(26, 13)
        Me.lblEventTimeEnd.TabIndex = 28
        Me.lblEventTimeEnd.Text = "End"
        '
        'lblEventTimeStart
        '
        Me.lblEventTimeStart.AutoSize = True
        Me.lblEventTimeStart.Location = New System.Drawing.Point(69, 171)
        Me.lblEventTimeStart.Name = "lblEventTimeStart"
        Me.lblEventTimeStart.Size = New System.Drawing.Size(29, 13)
        Me.lblEventTimeStart.TabIndex = 27
        Me.lblEventTimeStart.Text = "Start"
        '
        'lblAvailability
        '
        Me.lblAvailability.AutoSize = True
        Me.lblAvailability.Location = New System.Drawing.Point(171, 582)
        Me.lblAvailability.Name = "lblAvailability"
        Me.lblAvailability.Size = New System.Drawing.Size(56, 13)
        Me.lblAvailability.TabIndex = 33
        Me.lblAvailability.Text = "Availability"
        '
        'tcDetails
        '
        Me.tcDetails.Controls.Add(Me.tpBookingDetails)
        Me.tcDetails.Controls.Add(Me.tpCustomerDetails)
        Me.tcDetails.Controls.Add(Me.tpPaymentDetails)
        Me.tcDetails.Location = New System.Drawing.Point(631, 77)
        Me.tcDetails.Name = "tcDetails"
        Me.tcDetails.SelectedIndex = 0
        Me.tcDetails.Size = New System.Drawing.Size(781, 426)
        Me.tcDetails.TabIndex = 35
        '
        'tpBookingDetails
        '
        Me.tpBookingDetails.Controls.Add(Me.pnlBookingDetails)
        Me.tpBookingDetails.Location = New System.Drawing.Point(4, 22)
        Me.tpBookingDetails.Name = "tpBookingDetails"
        Me.tpBookingDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.tpBookingDetails.Size = New System.Drawing.Size(773, 400)
        Me.tpBookingDetails.TabIndex = 0
        Me.tpBookingDetails.Text = "Booking Details"
        Me.tpBookingDetails.UseVisualStyleBackColor = True
        '
        'pnlBookingDetails
        '
        Me.pnlBookingDetails.Controls.Add(Me.lblPriceBreakdown)
        Me.pnlBookingDetails.Controls.Add(Me.lblBeyondAvailabilityFee)
        Me.pnlBookingDetails.Controls.Add(Me.lblCapacityExceedanceFee)
        Me.pnlBookingDetails.Controls.Add(Me.chkOutsideAvailableHours)
        Me.pnlBookingDetails.Controls.Add(Me.cbSameDayEvent)
        Me.pnlBookingDetails.Controls.Add(Me.cbEndAMPM)
        Me.pnlBookingDetails.Controls.Add(Me.cbEndMinutes)
        Me.pnlBookingDetails.Controls.Add(Me.cbEndHour)
        Me.pnlBookingDetails.Controls.Add(Me.cbStartAMPM)
        Me.pnlBookingDetails.Controls.Add(Me.cbStartMinutes)
        Me.pnlBookingDetails.Controls.Add(Me.cbStartHour)
        Me.pnlBookingDetails.Controls.Add(Me.lblEventType)
        Me.pnlBookingDetails.Controls.Add(Me.cbEventType)
        Me.pnlBookingDetails.Controls.Add(Me.lblNumGuests)
        Me.pnlBookingDetails.Controls.Add(Me.lblEventTimeEnd)
        Me.pnlBookingDetails.Controls.Add(Me.txtTotalPrice)
        Me.pnlBookingDetails.Controls.Add(Me.lblEventTimeStart)
        Me.pnlBookingDetails.Controls.Add(Me.lblEventDateStart)
        Me.pnlBookingDetails.Controls.Add(Me.lblTime)
        Me.pnlBookingDetails.Controls.Add(Me.lblServicesAvailed)
        Me.pnlBookingDetails.Controls.Add(Me.lblDate)
        Me.pnlBookingDetails.Controls.Add(Me.lblTotalPrice)
        Me.pnlBookingDetails.Controls.Add(Me.dtpEventDateEnd)
        Me.pnlBookingDetails.Controls.Add(Me.txtNumGuests)
        Me.pnlBookingDetails.Controls.Add(Me.lblEnd)
        Me.pnlBookingDetails.Controls.Add(Me.dtpEventDateStart)
        Me.pnlBookingDetails.Controls.Add(Me.chkCatering)
        Me.pnlBookingDetails.Controls.Add(Me.lblEventSchedule)
        Me.pnlBookingDetails.Controls.Add(Me.chkClown)
        Me.pnlBookingDetails.Controls.Add(Me.btBookingProceed)
        Me.pnlBookingDetails.Controls.Add(Me.chkSinger)
        Me.pnlBookingDetails.Controls.Add(Me.chkVideoke)
        Me.pnlBookingDetails.Controls.Add(Me.chkDancer)
        Me.pnlBookingDetails.Location = New System.Drawing.Point(6, 6)
        Me.pnlBookingDetails.Name = "pnlBookingDetails"
        Me.pnlBookingDetails.Size = New System.Drawing.Size(761, 388)
        Me.pnlBookingDetails.TabIndex = 36
        '
        'chkOutsideAvailableHours
        '
        Me.chkOutsideAvailableHours.AutoSize = True
        Me.chkOutsideAvailableHours.Location = New System.Drawing.Point(72, 221)
        Me.chkOutsideAvailableHours.Name = "chkOutsideAvailableHours"
        Me.chkOutsideAvailableHours.Size = New System.Drawing.Size(221, 17)
        Me.chkOutsideAvailableHours.TabIndex = 45
        Me.chkOutsideAvailableHours.Text = "Book outside available hours (+ extra fee)"
        Me.chkOutsideAvailableHours.UseVisualStyleBackColor = True
        '
        'cbSameDayEvent
        '
        Me.cbSameDayEvent.AutoSize = True
        Me.cbSameDayEvent.Location = New System.Drawing.Point(234, 83)
        Me.cbSameDayEvent.Name = "cbSameDayEvent"
        Me.cbSameDayEvent.Size = New System.Drawing.Size(106, 17)
        Me.cbSameDayEvent.TabIndex = 44
        Me.cbSameDayEvent.Text = "Same Day Event"
        Me.cbSameDayEvent.UseVisualStyleBackColor = True
        '
        'cbEndAMPM
        '
        Me.cbEndAMPM.FormattingEnabled = True
        Me.cbEndAMPM.Items.AddRange(New Object() {"AM", "PM"})
        Me.cbEndAMPM.Location = New System.Drawing.Point(258, 193)
        Me.cbEndAMPM.Name = "cbEndAMPM"
        Me.cbEndAMPM.Size = New System.Drawing.Size(66, 21)
        Me.cbEndAMPM.TabIndex = 43
        '
        'cbEndMinutes
        '
        Me.cbEndMinutes.FormattingEnabled = True
        Me.cbEndMinutes.Items.AddRange(New Object() {"00", "05", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55"})
        Me.cbEndMinutes.Location = New System.Drawing.Point(186, 193)
        Me.cbEndMinutes.Name = "cbEndMinutes"
        Me.cbEndMinutes.Size = New System.Drawing.Size(66, 21)
        Me.cbEndMinutes.TabIndex = 42
        '
        'cbEndHour
        '
        Me.cbEndHour.FormattingEnabled = True
        Me.cbEndHour.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cbEndHour.Location = New System.Drawing.Point(114, 193)
        Me.cbEndHour.Name = "cbEndHour"
        Me.cbEndHour.Size = New System.Drawing.Size(66, 21)
        Me.cbEndHour.TabIndex = 41
        '
        'cbStartAMPM
        '
        Me.cbStartAMPM.FormattingEnabled = True
        Me.cbStartAMPM.Items.AddRange(New Object() {"AM", "PM"})
        Me.cbStartAMPM.Location = New System.Drawing.Point(258, 168)
        Me.cbStartAMPM.Name = "cbStartAMPM"
        Me.cbStartAMPM.Size = New System.Drawing.Size(66, 21)
        Me.cbStartAMPM.TabIndex = 40
        '
        'cbStartMinutes
        '
        Me.cbStartMinutes.FormattingEnabled = True
        Me.cbStartMinutes.Items.AddRange(New Object() {"00", "05", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55"})
        Me.cbStartMinutes.Location = New System.Drawing.Point(186, 168)
        Me.cbStartMinutes.Name = "cbStartMinutes"
        Me.cbStartMinutes.Size = New System.Drawing.Size(66, 21)
        Me.cbStartMinutes.TabIndex = 39
        '
        'cbStartHour
        '
        Me.cbStartHour.FormattingEnabled = True
        Me.cbStartHour.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cbStartHour.Location = New System.Drawing.Point(114, 168)
        Me.cbStartHour.Name = "cbStartHour"
        Me.cbStartHour.Size = New System.Drawing.Size(66, 21)
        Me.cbStartHour.TabIndex = 38
        '
        'lblEventType
        '
        Me.lblEventType.AutoSize = True
        Me.lblEventType.Location = New System.Drawing.Point(11, 17)
        Me.lblEventType.Name = "lblEventType"
        Me.lblEventType.Size = New System.Drawing.Size(62, 13)
        Me.lblEventType.TabIndex = 37
        Me.lblEventType.Text = "Event Type"
        '
        'cbEventType
        '
        Me.cbEventType.FormattingEnabled = True
        Me.cbEventType.Location = New System.Drawing.Point(110, 17)
        Me.cbEventType.Name = "cbEventType"
        Me.cbEventType.Size = New System.Drawing.Size(224, 21)
        Me.cbEventType.TabIndex = 36
        '
        'tpCustomerDetails
        '
        Me.tpCustomerDetails.Controls.Add(Me.pnlCustomerDetails)
        Me.tpCustomerDetails.Location = New System.Drawing.Point(4, 22)
        Me.tpCustomerDetails.Name = "tpCustomerDetails"
        Me.tpCustomerDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCustomerDetails.Size = New System.Drawing.Size(660, 400)
        Me.tpCustomerDetails.TabIndex = 1
        Me.tpCustomerDetails.Text = "Customer Details"
        Me.tpCustomerDetails.UseVisualStyleBackColor = True
        '
        'pnlCustomerDetails
        '
        Me.pnlCustomerDetails.Controls.Add(Me.btnCustomerProceed)
        Me.pnlCustomerDetails.Controls.Add(Me.txtCustomerName)
        Me.pnlCustomerDetails.Controls.Add(Me.lblName)
        Me.pnlCustomerDetails.Controls.Add(Me.lblAddress)
        Me.pnlCustomerDetails.Controls.Add(Me.txtAddress)
        Me.pnlCustomerDetails.Controls.Add(Me.txtAge)
        Me.pnlCustomerDetails.Controls.Add(Me.lblAge)
        Me.pnlCustomerDetails.Controls.Add(Me.lblSex)
        Me.pnlCustomerDetails.Controls.Add(Me.cmbSex)
        Me.pnlCustomerDetails.Controls.Add(Me.lblBirthday)
        Me.pnlCustomerDetails.Controls.Add(Me.dtpBirthday)
        Me.pnlCustomerDetails.Location = New System.Drawing.Point(6, 6)
        Me.pnlCustomerDetails.Name = "pnlCustomerDetails"
        Me.pnlCustomerDetails.Size = New System.Drawing.Size(367, 373)
        Me.pnlCustomerDetails.TabIndex = 36
        '
        'btnCustomerProceed
        '
        Me.btnCustomerProceed.Location = New System.Drawing.Point(237, 350)
        Me.btnCustomerProceed.Name = "btnCustomerProceed"
        Me.btnCustomerProceed.Size = New System.Drawing.Size(110, 23)
        Me.btnCustomerProceed.TabIndex = 21
        Me.btnCustomerProceed.Text = "Proceed"
        Me.btnCustomerProceed.UseVisualStyleBackColor = True
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(119, 11)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(226, 20)
        Me.txtCustomerName.TabIndex = 0
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(21, 11)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 8
        Me.lblName.Text = "Name"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(21, 123)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(45, 13)
        Me.lblAddress.TabIndex = 12
        Me.lblAddress.Text = "Address"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(119, 116)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(226, 20)
        Me.txtAddress.TabIndex = 6
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(119, 63)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.ReadOnly = True
        Me.txtAge.Size = New System.Drawing.Size(226, 20)
        Me.txtAge.TabIndex = 1
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(21, 67)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(26, 13)
        Me.lblAge.TabIndex = 9
        Me.lblAge.Text = "Age"
        '
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.lblSex.Location = New System.Drawing.Point(21, 95)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(25, 13)
        Me.lblSex.TabIndex = 11
        Me.lblSex.Text = "Sex"
        '
        'cmbSex
        '
        Me.cmbSex.FormattingEnabled = True
        Me.cmbSex.Items.AddRange(New Object() {"Male", "Female", "Non-Binary", "Other", "Prefer Not to Say"})
        Me.cmbSex.Location = New System.Drawing.Point(119, 89)
        Me.cmbSex.Name = "cmbSex"
        Me.cmbSex.Size = New System.Drawing.Size(226, 21)
        Me.cmbSex.TabIndex = 5
        '
        'lblBirthday
        '
        Me.lblBirthday.AutoSize = True
        Me.lblBirthday.Location = New System.Drawing.Point(21, 39)
        Me.lblBirthday.Name = "lblBirthday"
        Me.lblBirthday.Size = New System.Drawing.Size(45, 13)
        Me.lblBirthday.TabIndex = 10
        Me.lblBirthday.Text = "Birthday"
        '
        'dtpBirthday
        '
        Me.dtpBirthday.Location = New System.Drawing.Point(119, 37)
        Me.dtpBirthday.Name = "dtpBirthday"
        Me.dtpBirthday.Size = New System.Drawing.Size(226, 20)
        Me.dtpBirthday.TabIndex = 4
        '
        'tpPaymentDetails
        '
        Me.tpPaymentDetails.Controls.Add(Me.lblOffHoursMinutesContainer)
        Me.tpPaymentDetails.Controls.Add(Me.lblOffHoursTotalFeeContainer)
        Me.tpPaymentDetails.Controls.Add(Me.lblOffHoursBookingFee)
        Me.tpPaymentDetails.Controls.Add(Me.lblSelectedVoucherContainer)
        Me.tpPaymentDetails.Controls.Add(Me.lblSelectedVoucher)
        Me.tpPaymentDetails.Controls.Add(Me.btnPlaceBooking)
        Me.tpPaymentDetails.Controls.Add(Me.lblVoucherDiscountContainer)
        Me.tpPaymentDetails.Controls.Add(Me.lblVoucherDiscount)
        Me.tpPaymentDetails.Controls.Add(Me.lblVoucher)
        Me.tpPaymentDetails.Controls.Add(Me.btnVoucher)
        Me.tpPaymentDetails.Controls.Add(Me.txtPayAmount)
        Me.tpPaymentDetails.Controls.Add(Me.lblPayAmount)
        Me.tpPaymentDetails.Controls.Add(Me.lblTotalPricePaymentContainer)
        Me.tpPaymentDetails.Controls.Add(Me.lblTotalPricePayment)
        Me.tpPaymentDetails.Controls.Add(Me.lblServicesPaymentContainer)
        Me.tpPaymentDetails.Controls.Add(Me.lblServicesPayment)
        Me.tpPaymentDetails.Controls.Add(Me.lblEventTimePaymentContainer)
        Me.tpPaymentDetails.Controls.Add(Me.lblEventTimePayment)
        Me.tpPaymentDetails.Controls.Add(Me.lblEventDatePaymentContainer)
        Me.tpPaymentDetails.Controls.Add(Me.lblEventDatePayment)
        Me.tpPaymentDetails.Controls.Add(Me.lblNumGuestsPaymentContainer)
        Me.tpPaymentDetails.Controls.Add(Me.lblNumGuestsPayment)
        Me.tpPaymentDetails.Controls.Add(Me.lblEventTypePaymentContainer)
        Me.tpPaymentDetails.Controls.Add(Me.lblEventTypePayment)
        Me.tpPaymentDetails.Controls.Add(Me.lblEventPlacePaymentContainer)
        Me.tpPaymentDetails.Controls.Add(Me.lblEventPlacePayment)
        Me.tpPaymentDetails.Controls.Add(Me.lblCustomerContainer)
        Me.tpPaymentDetails.Controls.Add(Me.lblCustomerName)
        Me.tpPaymentDetails.Location = New System.Drawing.Point(4, 22)
        Me.tpPaymentDetails.Name = "tpPaymentDetails"
        Me.tpPaymentDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPaymentDetails.Size = New System.Drawing.Size(660, 400)
        Me.tpPaymentDetails.TabIndex = 2
        Me.tpPaymentDetails.Text = "Payment Details"
        Me.tpPaymentDetails.UseVisualStyleBackColor = True
        '
        'lblOffHoursMinutesContainer
        '
        Me.lblOffHoursMinutesContainer.AutoSize = True
        Me.lblOffHoursMinutesContainer.Location = New System.Drawing.Point(119, 110)
        Me.lblOffHoursMinutesContainer.Name = "lblOffHoursMinutesContainer"
        Me.lblOffHoursMinutesContainer.Size = New System.Drawing.Size(10, 13)
        Me.lblOffHoursMinutesContainer.TabIndex = 29
        Me.lblOffHoursMinutesContainer.Text = "-"
        '
        'lblOffHoursTotalFeeContainer
        '
        Me.lblOffHoursTotalFeeContainer.AutoSize = True
        Me.lblOffHoursTotalFeeContainer.Location = New System.Drawing.Point(274, 110)
        Me.lblOffHoursTotalFeeContainer.Name = "lblOffHoursTotalFeeContainer"
        Me.lblOffHoursTotalFeeContainer.Size = New System.Drawing.Size(10, 13)
        Me.lblOffHoursTotalFeeContainer.TabIndex = 28
        Me.lblOffHoursTotalFeeContainer.Text = "-"
        '
        'lblOffHoursBookingFee
        '
        Me.lblOffHoursBookingFee.AutoSize = True
        Me.lblOffHoursBookingFee.Location = New System.Drawing.Point(17, 92)
        Me.lblOffHoursBookingFee.Name = "lblOffHoursBookingFee"
        Me.lblOffHoursBookingFee.Size = New System.Drawing.Size(109, 13)
        Me.lblOffHoursBookingFee.TabIndex = 27
        Me.lblOffHoursBookingFee.Text = "Off-hours booking fee"
        '
        'lblSelectedVoucherContainer
        '
        Me.lblSelectedVoucherContainer.AutoSize = True
        Me.lblSelectedVoucherContainer.Location = New System.Drawing.Point(129, 263)
        Me.lblSelectedVoucherContainer.Name = "lblSelectedVoucherContainer"
        Me.lblSelectedVoucherContainer.Size = New System.Drawing.Size(10, 13)
        Me.lblSelectedVoucherContainer.TabIndex = 26
        Me.lblSelectedVoucherContainer.Text = "-"
        '
        'lblSelectedVoucher
        '
        Me.lblSelectedVoucher.AutoSize = True
        Me.lblSelectedVoucher.Location = New System.Drawing.Point(18, 263)
        Me.lblSelectedVoucher.Name = "lblSelectedVoucher"
        Me.lblSelectedVoucher.Size = New System.Drawing.Size(92, 13)
        Me.lblSelectedVoucher.TabIndex = 25
        Me.lblSelectedVoucher.Text = "Selected Voucher"
        '
        'btnPlaceBooking
        '
        Me.btnPlaceBooking.Location = New System.Drawing.Point(237, 350)
        Me.btnPlaceBooking.Name = "btnPlaceBooking"
        Me.btnPlaceBooking.Size = New System.Drawing.Size(120, 23)
        Me.btnPlaceBooking.TabIndex = 24
        Me.btnPlaceBooking.Text = "Place Booking"
        Me.btnPlaceBooking.UseVisualStyleBackColor = True
        '
        'lblVoucherDiscountContainer
        '
        Me.lblVoucherDiscountContainer.AutoSize = True
        Me.lblVoucherDiscountContainer.Location = New System.Drawing.Point(275, 301)
        Me.lblVoucherDiscountContainer.Name = "lblVoucherDiscountContainer"
        Me.lblVoucherDiscountContainer.Size = New System.Drawing.Size(10, 13)
        Me.lblVoucherDiscountContainer.TabIndex = 23
        Me.lblVoucherDiscountContainer.Text = "-"
        '
        'lblVoucherDiscount
        '
        Me.lblVoucherDiscount.AutoSize = True
        Me.lblVoucherDiscount.Location = New System.Drawing.Point(164, 301)
        Me.lblVoucherDiscount.Name = "lblVoucherDiscount"
        Me.lblVoucherDiscount.Size = New System.Drawing.Size(92, 13)
        Me.lblVoucherDiscount.TabIndex = 22
        Me.lblVoucherDiscount.Text = "Voucher Discount"
        '
        'lblVoucher
        '
        Me.lblVoucher.AutoSize = True
        Me.lblVoucher.Location = New System.Drawing.Point(17, 239)
        Me.lblVoucher.Name = "lblVoucher"
        Me.lblVoucher.Size = New System.Drawing.Size(47, 13)
        Me.lblVoucher.TabIndex = 19
        Me.lblVoucher.Text = "Voucher"
        '
        'btnVoucher
        '
        Me.btnVoucher.Location = New System.Drawing.Point(119, 234)
        Me.btnVoucher.Name = "btnVoucher"
        Me.btnVoucher.Size = New System.Drawing.Size(238, 23)
        Me.btnVoucher.TabIndex = 18
        Me.btnVoucher.Text = "Select Voucher"
        Me.btnVoucher.UseVisualStyleBackColor = True
        '
        'txtPayAmount
        '
        Me.txtPayAmount.Location = New System.Drawing.Point(119, 324)
        Me.txtPayAmount.Name = "txtPayAmount"
        Me.txtPayAmount.Size = New System.Drawing.Size(238, 20)
        Me.txtPayAmount.TabIndex = 17
        '
        'lblPayAmount
        '
        Me.lblPayAmount.AutoSize = True
        Me.lblPayAmount.Location = New System.Drawing.Point(17, 327)
        Me.lblPayAmount.Name = "lblPayAmount"
        Me.lblPayAmount.Size = New System.Drawing.Size(64, 13)
        Me.lblPayAmount.TabIndex = 16
        Me.lblPayAmount.Text = "Pay Amount"
        '
        'lblTotalPricePaymentContainer
        '
        Me.lblTotalPricePaymentContainer.AutoSize = True
        Me.lblTotalPricePaymentContainer.Location = New System.Drawing.Point(275, 288)
        Me.lblTotalPricePaymentContainer.Name = "lblTotalPricePaymentContainer"
        Me.lblTotalPricePaymentContainer.Size = New System.Drawing.Size(10, 13)
        Me.lblTotalPricePaymentContainer.TabIndex = 15
        Me.lblTotalPricePaymentContainer.Text = "-"
        '
        'lblTotalPricePayment
        '
        Me.lblTotalPricePayment.AutoSize = True
        Me.lblTotalPricePayment.Location = New System.Drawing.Point(198, 288)
        Me.lblTotalPricePayment.Name = "lblTotalPricePayment"
        Me.lblTotalPricePayment.Size = New System.Drawing.Size(58, 13)
        Me.lblTotalPricePayment.TabIndex = 14
        Me.lblTotalPricePayment.Text = "Total Price"
        '
        'lblServicesPaymentContainer
        '
        Me.lblServicesPaymentContainer.AutoSize = True
        Me.lblServicesPaymentContainer.Location = New System.Drawing.Point(120, 133)
        Me.lblServicesPaymentContainer.Name = "lblServicesPaymentContainer"
        Me.lblServicesPaymentContainer.Size = New System.Drawing.Size(10, 13)
        Me.lblServicesPaymentContainer.TabIndex = 13
        Me.lblServicesPaymentContainer.Text = "-"
        '
        'lblServicesPayment
        '
        Me.lblServicesPayment.AutoSize = True
        Me.lblServicesPayment.Location = New System.Drawing.Point(16, 133)
        Me.lblServicesPayment.Name = "lblServicesPayment"
        Me.lblServicesPayment.Size = New System.Drawing.Size(86, 13)
        Me.lblServicesPayment.TabIndex = 12
        Me.lblServicesPayment.Text = "Services Availed"
        '
        'lblEventTimePaymentContainer
        '
        Me.lblEventTimePaymentContainer.AutoSize = True
        Me.lblEventTimePaymentContainer.Location = New System.Drawing.Point(120, 67)
        Me.lblEventTimePaymentContainer.Name = "lblEventTimePaymentContainer"
        Me.lblEventTimePaymentContainer.Size = New System.Drawing.Size(10, 13)
        Me.lblEventTimePaymentContainer.TabIndex = 11
        Me.lblEventTimePaymentContainer.Text = "-"
        '
        'lblEventTimePayment
        '
        Me.lblEventTimePayment.AutoSize = True
        Me.lblEventTimePayment.Location = New System.Drawing.Point(16, 67)
        Me.lblEventTimePayment.Name = "lblEventTimePayment"
        Me.lblEventTimePayment.Size = New System.Drawing.Size(61, 13)
        Me.lblEventTimePayment.TabIndex = 10
        Me.lblEventTimePayment.Text = "Event Time"
        '
        'lblEventDatePaymentContainer
        '
        Me.lblEventDatePaymentContainer.AutoSize = True
        Me.lblEventDatePaymentContainer.Location = New System.Drawing.Point(120, 54)
        Me.lblEventDatePaymentContainer.Name = "lblEventDatePaymentContainer"
        Me.lblEventDatePaymentContainer.Size = New System.Drawing.Size(10, 13)
        Me.lblEventDatePaymentContainer.TabIndex = 9
        Me.lblEventDatePaymentContainer.Text = "-"
        '
        'lblEventDatePayment
        '
        Me.lblEventDatePayment.AutoSize = True
        Me.lblEventDatePayment.Location = New System.Drawing.Point(16, 54)
        Me.lblEventDatePayment.Name = "lblEventDatePayment"
        Me.lblEventDatePayment.Size = New System.Drawing.Size(61, 13)
        Me.lblEventDatePayment.TabIndex = 8
        Me.lblEventDatePayment.Text = "Event Date"
        '
        'lblNumGuestsPaymentContainer
        '
        Me.lblNumGuestsPaymentContainer.AutoSize = True
        Me.lblNumGuestsPaymentContainer.Location = New System.Drawing.Point(120, 41)
        Me.lblNumGuestsPaymentContainer.Name = "lblNumGuestsPaymentContainer"
        Me.lblNumGuestsPaymentContainer.Size = New System.Drawing.Size(10, 13)
        Me.lblNumGuestsPaymentContainer.TabIndex = 7
        Me.lblNumGuestsPaymentContainer.Text = "-"
        '
        'lblNumGuestsPayment
        '
        Me.lblNumGuestsPayment.AutoSize = True
        Me.lblNumGuestsPayment.Location = New System.Drawing.Point(16, 41)
        Me.lblNumGuestsPayment.Name = "lblNumGuestsPayment"
        Me.lblNumGuestsPayment.Size = New System.Drawing.Size(92, 13)
        Me.lblNumGuestsPayment.TabIndex = 6
        Me.lblNumGuestsPayment.Text = "Number of Guests"
        '
        'lblEventTypePaymentContainer
        '
        Me.lblEventTypePaymentContainer.AutoSize = True
        Me.lblEventTypePaymentContainer.Location = New System.Drawing.Point(338, 25)
        Me.lblEventTypePaymentContainer.Name = "lblEventTypePaymentContainer"
        Me.lblEventTypePaymentContainer.Size = New System.Drawing.Size(10, 13)
        Me.lblEventTypePaymentContainer.TabIndex = 5
        Me.lblEventTypePaymentContainer.Text = "-"
        '
        'lblEventTypePayment
        '
        Me.lblEventTypePayment.AutoSize = True
        Me.lblEventTypePayment.Location = New System.Drawing.Point(234, 25)
        Me.lblEventTypePayment.Name = "lblEventTypePayment"
        Me.lblEventTypePayment.Size = New System.Drawing.Size(62, 13)
        Me.lblEventTypePayment.TabIndex = 4
        Me.lblEventTypePayment.Text = "Event Type"
        '
        'lblEventPlacePaymentContainer
        '
        Me.lblEventPlacePaymentContainer.AutoSize = True
        Me.lblEventPlacePaymentContainer.Location = New System.Drawing.Point(338, 12)
        Me.lblEventPlacePaymentContainer.Name = "lblEventPlacePaymentContainer"
        Me.lblEventPlacePaymentContainer.Size = New System.Drawing.Size(10, 13)
        Me.lblEventPlacePaymentContainer.TabIndex = 3
        Me.lblEventPlacePaymentContainer.Text = "-"
        '
        'lblEventPlacePayment
        '
        Me.lblEventPlacePayment.AutoSize = True
        Me.lblEventPlacePayment.Location = New System.Drawing.Point(234, 12)
        Me.lblEventPlacePayment.Name = "lblEventPlacePayment"
        Me.lblEventPlacePayment.Size = New System.Drawing.Size(65, 13)
        Me.lblEventPlacePayment.TabIndex = 2
        Me.lblEventPlacePayment.Text = "Event Place"
        '
        'lblCustomerContainer
        '
        Me.lblCustomerContainer.AutoSize = True
        Me.lblCustomerContainer.Location = New System.Drawing.Point(120, 12)
        Me.lblCustomerContainer.Name = "lblCustomerContainer"
        Me.lblCustomerContainer.Size = New System.Drawing.Size(10, 13)
        Me.lblCustomerContainer.TabIndex = 1
        Me.lblCustomerContainer.Text = "-"
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Location = New System.Drawing.Point(16, 12)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(51, 13)
        Me.lblCustomerName.TabIndex = 0
        Me.lblCustomerName.Text = "Customer"
        '
        'lblHoursContainer
        '
        Me.lblHoursContainer.AutoSize = True
        Me.lblHoursContainer.Location = New System.Drawing.Point(212, 599)
        Me.lblHoursContainer.Name = "lblHoursContainer"
        Me.lblHoursContainer.Size = New System.Drawing.Size(10, 13)
        Me.lblHoursContainer.TabIndex = 36
        Me.lblHoursContainer.Text = "-"
        '
        'lblAvailableDaysContainer
        '
        Me.lblAvailableDaysContainer.AutoSize = True
        Me.lblAvailableDaysContainer.Location = New System.Drawing.Point(212, 612)
        Me.lblAvailableDaysContainer.Name = "lblAvailableDaysContainer"
        Me.lblAvailableDaysContainer.Size = New System.Drawing.Size(53, 13)
        Me.lblAvailableDaysContainer.TabIndex = 38
        Me.lblAvailableDaysContainer.Text = "Available:"
        '
        'mcAvailability
        '
        Me.mcAvailability.Location = New System.Drawing.Point(914, 530)
        Me.mcAvailability.Name = "mcAvailability"
        Me.mcAvailability.TabIndex = 39
        '
        'lblCapacityExceedanceFee
        '
        Me.lblCapacityExceedanceFee.AutoSize = True
        Me.lblCapacityExceedanceFee.Location = New System.Drawing.Point(341, 47)
        Me.lblCapacityExceedanceFee.Name = "lblCapacityExceedanceFee"
        Me.lblCapacityExceedanceFee.Size = New System.Drawing.Size(135, 26)
        Me.lblCapacityExceedanceFee.TabIndex = 46
        Me.lblCapacityExceedanceFee.Text = "Capacity Exceedance Fee " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(₱100 per additional)"
        '
        'lblBeyondAvailabilityFee
        '
        Me.lblBeyondAvailabilityFee.AutoSize = True
        Me.lblBeyondAvailabilityFee.Location = New System.Drawing.Point(341, 168)
        Me.lblBeyondAvailabilityFee.Name = "lblBeyondAvailabilityFee"
        Me.lblBeyondAvailabilityFee.Size = New System.Drawing.Size(119, 26)
        Me.lblBeyondAvailabilityFee.TabIndex = 47
        Me.lblBeyondAvailabilityFee.Text = "Beyond Availability Fee " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(₱17 per minute)"
        '
        'lblPriceBreakdown
        '
        Me.lblPriceBreakdown.AutoSize = True
        Me.lblPriceBreakdown.Location = New System.Drawing.Point(477, 17)
        Me.lblPriceBreakdown.Name = "lblPriceBreakdown"
        Me.lblPriceBreakdown.Size = New System.Drawing.Size(88, 13)
        Me.lblPriceBreakdown.TabIndex = 48
        Me.lblPriceBreakdown.Text = "Price Breakdown"
        '
        'FormBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1424, 771)
        Me.Controls.Add(Me.mcAvailability)
        Me.Controls.Add(Me.lblAvailableDaysContainer)
        Me.Controls.Add(Me.lblHoursContainer)
        Me.Controls.Add(Me.tcDetails)
        Me.Controls.Add(Me.lblAvailability)
        Me.Controls.Add(Me.lblDescriptionContainer)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblPricePerDayContainer)
        Me.Controls.Add(Me.lblFeaturesContainer)
        Me.Controls.Add(Me.lblPricePerDay)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblFeatures)
        Me.Controls.Add(Me.lblPlaceIDContainer)
        Me.Controls.Add(Me.lblCapacityContainer)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblEventPlace)
        Me.Controls.Add(Me.lblPlaceID)
        Me.Controls.Add(Me.lblCapacity)
        Me.Name = "FormBooking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormBooking"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcDetails.ResumeLayout(False)
        Me.tpBookingDetails.ResumeLayout(False)
        Me.pnlBookingDetails.ResumeLayout(False)
        Me.pnlBookingDetails.PerformLayout()
        Me.tpCustomerDetails.ResumeLayout(False)
        Me.pnlCustomerDetails.ResumeLayout(False)
        Me.pnlCustomerDetails.PerformLayout()
        Me.tpPaymentDetails.ResumeLayout(False)
        Me.tpPaymentDetails.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPricePerDay As Label
    Friend WithEvents lblCapacity As Label
    Friend WithEvents lblEventPlace As Label
    Friend WithEvents lblPlaceID As Label
    Friend WithEvents lblFeatures As Label
    Friend WithEvents dtpEventDateStart As DateTimePicker
    Friend WithEvents txtNumGuests As TextBox
    Friend WithEvents lblTotalPrice As Label
    Friend WithEvents lblServicesAvailed As Label
    Friend WithEvents lblEventDateStart As Label
    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents lblNumGuests As Label
    Friend WithEvents btBookingProceed As Button
    Friend WithEvents chkVideoke As CheckBox
    Friend WithEvents chkDancer As CheckBox
    Friend WithEvents chkSinger As CheckBox
    Friend WithEvents chkClown As CheckBox
    Friend WithEvents chkCatering As CheckBox
    Friend WithEvents btnBack As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblFeaturesContainer As Label
    Friend WithEvents lblPricePerDayContainer As Label
    Friend WithEvents lblCapacityContainer As Label
    Friend WithEvents lblPlaceIDContainer As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblDescriptionContainer As Label
    Friend WithEvents lblEventSchedule As Label
    Friend WithEvents dtpEventDateEnd As DateTimePicker
    Friend WithEvents lblEnd As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblEventTimeEnd As Label
    Friend WithEvents lblEventTimeStart As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblAvailability As Label
    Friend WithEvents tcDetails As TabControl
    Friend WithEvents tpBookingDetails As TabPage
    Friend WithEvents pnlBookingDetails As Panel
    Friend WithEvents tpCustomerDetails As TabPage
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents lblSex As Label
    Friend WithEvents lblBirthday As Label
    Friend WithEvents dtpBirthday As DateTimePicker
    Friend WithEvents cmbSex As ComboBox
    Friend WithEvents lblAge As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents pnlCustomerDetails As Panel
    Friend WithEvents tpPaymentDetails As TabPage
    Friend WithEvents btnCustomerProceed As Button
    Friend WithEvents lblCustomerContainer As Label
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents lblEventTypePayment As Label
    Friend WithEvents lblEventPlacePaymentContainer As Label
    Friend WithEvents lblEventPlacePayment As Label
    Friend WithEvents lblEventType As Label
    Friend WithEvents cbEventType As ComboBox
    Friend WithEvents lblServicesPaymentContainer As Label
    Friend WithEvents lblServicesPayment As Label
    Friend WithEvents lblEventTimePaymentContainer As Label
    Friend WithEvents lblEventTimePayment As Label
    Friend WithEvents lblEventDatePaymentContainer As Label
    Friend WithEvents lblEventDatePayment As Label
    Friend WithEvents lblNumGuestsPaymentContainer As Label
    Friend WithEvents lblNumGuestsPayment As Label
    Friend WithEvents lblEventTypePaymentContainer As Label
    Friend WithEvents btnVoucher As Button
    Friend WithEvents txtPayAmount As TextBox
    Friend WithEvents lblPayAmount As Label
    Friend WithEvents lblTotalPricePaymentContainer As Label
    Friend WithEvents lblTotalPricePayment As Label
    Friend WithEvents lblVoucher As Label
    Friend WithEvents lblVoucherDiscountContainer As Label
    Friend WithEvents lblVoucherDiscount As Label
    Friend WithEvents btnPlaceBooking As Button
    Friend WithEvents lblHoursContainer As Label
    Friend WithEvents lblAvailableDaysContainer As Label
    Friend WithEvents mcAvailability As MonthCalendar
    Friend WithEvents lblSelectedVoucherContainer As Label
    Friend WithEvents lblSelectedVoucher As Label
    Friend WithEvents cbEndAMPM As ComboBox
    Friend WithEvents cbEndMinutes As ComboBox
    Friend WithEvents cbEndHour As ComboBox
    Friend WithEvents cbStartAMPM As ComboBox
    Friend WithEvents cbStartMinutes As ComboBox
    Friend WithEvents cbStartHour As ComboBox
    Friend WithEvents cbSameDayEvent As CheckBox
    Friend WithEvents lblOffHoursBookingFee As Label
    Friend WithEvents lblOffHoursMinutesContainer As Label
    Friend WithEvents lblOffHoursTotalFeeContainer As Label
    Friend WithEvents chkOutsideAvailableHours As CheckBox
    Friend WithEvents lblCapacityExceedanceFee As Label
    Friend WithEvents lblBeyondAvailabilityFee As Label
    Friend WithEvents lblPriceBreakdown As Label
End Class
