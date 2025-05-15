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
        Me.lblPriceBreakdown = New System.Windows.Forms.Label()
        Me.lblBeyondAvailabilityFee = New System.Windows.Forms.Label()
        Me.lblCapacityExceedanceFee = New System.Windows.Forms.Label()
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
        Me.lblFeaturesContainer.BackColor = System.Drawing.Color.Transparent
        Me.lblFeaturesContainer.Font = New System.Drawing.Font("Poppins Light", 6.0!)
        Me.lblFeaturesContainer.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblFeaturesContainer.Location = New System.Drawing.Point(77, 610)
        Me.lblFeaturesContainer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFeaturesContainer.Name = "lblFeaturesContainer"
        Me.lblFeaturesContainer.Size = New System.Drawing.Size(13, 18)
        Me.lblFeaturesContainer.TabIndex = 19
        Me.lblFeaturesContainer.Text = "-"
        '
        'lblPricePerDayContainer
        '
        Me.lblPricePerDayContainer.AutoSize = True
        Me.lblPricePerDayContainer.BackColor = System.Drawing.Color.Transparent
        Me.lblPricePerDayContainer.Font = New System.Drawing.Font("Poppins Medium", 7.8!, System.Drawing.FontStyle.Bold)
        Me.lblPricePerDayContainer.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblPricePerDayContainer.Location = New System.Drawing.Point(252, 507)
        Me.lblPricePerDayContainer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPricePerDayContainer.Name = "lblPricePerDayContainer"
        Me.lblPricePerDayContainer.Size = New System.Drawing.Size(19, 23)
        Me.lblPricePerDayContainer.TabIndex = 18
        Me.lblPricePerDayContainer.Text = "0"
        '
        'lblCapacityContainer
        '
        Me.lblCapacityContainer.AutoSize = True
        Me.lblCapacityContainer.BackColor = System.Drawing.Color.Transparent
        Me.lblCapacityContainer.Font = New System.Drawing.Font("Poppins Medium", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapacityContainer.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblCapacityContainer.Location = New System.Drawing.Point(102, 507)
        Me.lblCapacityContainer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCapacityContainer.Name = "lblCapacityContainer"
        Me.lblCapacityContainer.Size = New System.Drawing.Size(19, 23)
        Me.lblCapacityContainer.TabIndex = 17
        Me.lblCapacityContainer.Text = "0"
        '
        'lblPlaceIDContainer
        '
        Me.lblPlaceIDContainer.AutoSize = True
        Me.lblPlaceIDContainer.BackColor = System.Drawing.Color.Transparent
        Me.lblPlaceIDContainer.Font = New System.Drawing.Font("Poppins Medium", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblPlaceIDContainer.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblPlaceIDContainer.Location = New System.Drawing.Point(517, 465)
        Me.lblPlaceIDContainer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlaceIDContainer.Name = "lblPlaceIDContainer"
        Me.lblPlaceIDContainer.Size = New System.Drawing.Size(21, 25)
        Me.lblPlaceIDContainer.TabIndex = 16
        Me.lblPlaceIDContainer.Text = "0"
        '
        'lblFeatures
        '
        Me.lblFeatures.AutoSize = True
        Me.lblFeatures.Location = New System.Drawing.Point(261, 715)
        Me.lblFeatures.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFeatures.Name = "lblFeatures"
        Me.lblFeatures.Size = New System.Drawing.Size(60, 16)
        Me.lblFeatures.TabIndex = 15
        Me.lblFeatures.Text = "Features"
        '
        'lblPricePerDay
        '
        Me.lblPricePerDay.AutoSize = True
        Me.lblPricePerDay.Location = New System.Drawing.Point(79, 709)
        Me.lblPricePerDay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPricePerDay.Name = "lblPricePerDay"
        Me.lblPricePerDay.Size = New System.Drawing.Size(89, 16)
        Me.lblPricePerDay.TabIndex = 12
        Me.lblPricePerDay.Text = "Price per Day"
        '
        'lblCapacity
        '
        Me.lblCapacity.AutoSize = True
        Me.lblCapacity.Location = New System.Drawing.Point(176, 709)
        Me.lblCapacity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCapacity.Name = "lblCapacity"
        Me.lblCapacity.Size = New System.Drawing.Size(60, 16)
        Me.lblCapacity.TabIndex = 11
        Me.lblCapacity.Text = "Capacity"
        '
        'lblPlaceID
        '
        Me.lblPlaceID.AutoSize = True
        Me.lblPlaceID.Location = New System.Drawing.Point(243, 693)
        Me.lblPlaceID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlaceID.Name = "lblPlaceID"
        Me.lblPlaceID.Size = New System.Drawing.Size(58, 16)
        Me.lblPlaceID.TabIndex = 8
        Me.lblPlaceID.Text = "Place ID"
        '
        'lblEventPlace
        '
        Me.lblEventPlace.AutoSize = True
        Me.lblEventPlace.BackColor = System.Drawing.Color.Transparent
        Me.lblEventPlace.Font = New System.Drawing.Font("Poppins", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventPlace.Location = New System.Drawing.Point(46, 453)
        Me.lblEventPlace.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEventPlace.Name = "lblEventPlace"
        Me.lblEventPlace.Size = New System.Drawing.Size(219, 58)
        Me.lblEventPlace.TabIndex = 9
        Me.lblEventPlace.Text = "Event Place"
        '
        'lblEventSchedule
        '
        Me.lblEventSchedule.AutoSize = True
        Me.lblEventSchedule.Font = New System.Drawing.Font("Poppins Medium", 7.0!, System.Drawing.FontStyle.Bold)
        Me.lblEventSchedule.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblEventSchedule.Location = New System.Drawing.Point(15, 87)
        Me.lblEventSchedule.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEventSchedule.Name = "lblEventSchedule"
        Me.lblEventSchedule.Size = New System.Drawing.Size(107, 21)
        Me.lblEventSchedule.TabIndex = 21
        Me.lblEventSchedule.Text = "Event Schedule"
        '
        'btBookingProceed
        '
        Me.btBookingProceed.BackgroundImage = Global.maramingeme.My.Resources.Resources.btnProceed
        Me.btBookingProceed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btBookingProceed.FlatAppearance.BorderSize = 0
        Me.btBookingProceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btBookingProceed.Font = New System.Drawing.Font("Poppins", 7.0!)
        Me.btBookingProceed.Location = New System.Drawing.Point(585, 487)
        Me.btBookingProceed.Margin = New System.Windows.Forms.Padding(4)
        Me.btBookingProceed.Name = "btBookingProceed"
        Me.btBookingProceed.Size = New System.Drawing.Size(175, 50)
        Me.btBookingProceed.TabIndex = 20
        Me.btBookingProceed.UseVisualStyleBackColor = True
        '
        'chkVideoke
        '
        Me.chkVideoke.AutoSize = True
        Me.chkVideoke.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.chkVideoke.Location = New System.Drawing.Point(306, 360)
        Me.chkVideoke.Margin = New System.Windows.Forms.Padding(4)
        Me.chkVideoke.Name = "chkVideoke"
        Me.chkVideoke.Size = New System.Drawing.Size(189, 27)
        Me.chkVideoke.TabIndex = 18
        Me.chkVideoke.Text = "Videoke (₱20 per guest)"
        Me.chkVideoke.UseVisualStyleBackColor = True
        '
        'chkDancer
        '
        Me.chkDancer.AutoSize = True
        Me.chkDancer.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.chkDancer.Location = New System.Drawing.Point(306, 334)
        Me.chkDancer.Margin = New System.Windows.Forms.Padding(4)
        Me.chkDancer.Name = "chkDancer"
        Me.chkDancer.Size = New System.Drawing.Size(189, 27)
        Me.chkDancer.TabIndex = 17
        Me.chkDancer.Text = "Dancer (₱140 per guest)"
        Me.chkDancer.UseVisualStyleBackColor = True
        '
        'chkSinger
        '
        Me.chkSinger.AutoSize = True
        Me.chkSinger.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.chkSinger.Location = New System.Drawing.Point(96, 388)
        Me.chkSinger.Margin = New System.Windows.Forms.Padding(4)
        Me.chkSinger.Name = "chkSinger"
        Me.chkSinger.Size = New System.Drawing.Size(183, 27)
        Me.chkSinger.TabIndex = 16
        Me.chkSinger.Text = "Singer (₱140 per guest)"
        Me.chkSinger.UseVisualStyleBackColor = True
        '
        'chkClown
        '
        Me.chkClown.AutoSize = True
        Me.chkClown.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.chkClown.Location = New System.Drawing.Point(96, 360)
        Me.chkClown.Margin = New System.Windows.Forms.Padding(4)
        Me.chkClown.Name = "chkClown"
        Me.chkClown.Size = New System.Drawing.Size(185, 27)
        Me.chkClown.TabIndex = 15
        Me.chkClown.Text = "Clown (₱200 per guest)"
        Me.chkClown.UseVisualStyleBackColor = True
        '
        'chkCatering
        '
        Me.chkCatering.AutoSize = True
        Me.chkCatering.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.chkCatering.Location = New System.Drawing.Point(96, 333)
        Me.chkCatering.Margin = New System.Windows.Forms.Padding(4)
        Me.chkCatering.Name = "chkCatering"
        Me.chkCatering.Size = New System.Drawing.Size(203, 27)
        Me.chkCatering.TabIndex = 14
        Me.chkCatering.Text = "Catering (₱400 per guest)"
        Me.chkCatering.UseVisualStyleBackColor = True
        '
        'dtpEventDateStart
        '
        Me.dtpEventDateStart.Location = New System.Drawing.Point(151, 130)
        Me.dtpEventDateStart.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpEventDateStart.Name = "dtpEventDateStart"
        Me.dtpEventDateStart.Size = New System.Drawing.Size(300, 27)
        Me.dtpEventDateStart.TabIndex = 13
        '
        'txtNumGuests
        '
        Me.txtNumGuests.Location = New System.Drawing.Point(147, 55)
        Me.txtNumGuests.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumGuests.Name = "txtNumGuests"
        Me.txtNumGuests.Size = New System.Drawing.Size(226, 27)
        Me.txtNumGuests.TabIndex = 0
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.AutoSize = True
        Me.lblTotalPrice.Font = New System.Drawing.Font("Poppins Medium", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalPrice.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblTotalPrice.Location = New System.Drawing.Point(670, 404)
        Me.lblTotalPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(90, 25)
        Me.lblTotalPrice.TabIndex = 12
        Me.lblTotalPrice.Text = "Total Price"
        '
        'lblServicesAvailed
        '
        Me.lblServicesAvailed.AutoSize = True
        Me.lblServicesAvailed.Font = New System.Drawing.Font("Poppins Medium", 7.0!, System.Drawing.FontStyle.Bold)
        Me.lblServicesAvailed.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblServicesAvailed.Location = New System.Drawing.Point(23, 299)
        Me.lblServicesAvailed.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblServicesAvailed.Name = "lblServicesAvailed"
        Me.lblServicesAvailed.Size = New System.Drawing.Size(113, 21)
        Me.lblServicesAvailed.TabIndex = 11
        Me.lblServicesAvailed.Text = "Services Availed"
        '
        'lblEventDateStart
        '
        Me.lblEventDateStart.AutoSize = True
        Me.lblEventDateStart.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblEventDateStart.Location = New System.Drawing.Point(92, 138)
        Me.lblEventDateStart.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEventDateStart.Name = "lblEventDateStart"
        Me.lblEventDateStart.Size = New System.Drawing.Size(42, 23)
        Me.lblEventDateStart.TabIndex = 9
        Me.lblEventDateStart.Text = "Start"
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotalPrice.Font = New System.Drawing.Font("Poppins Medium", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotalPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTotalPrice.Location = New System.Drawing.Point(460, 427)
        Me.txtTotalPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.ReadOnly = True
        Me.txtTotalPrice.Size = New System.Drawing.Size(300, 45)
        Me.txtTotalPrice.TabIndex = 6
        '
        'lblNumGuests
        '
        Me.lblNumGuests.AutoSize = True
        Me.lblNumGuests.Font = New System.Drawing.Font("Poppins Medium", 7.0!, System.Drawing.FontStyle.Bold)
        Me.lblNumGuests.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblNumGuests.Location = New System.Drawing.Point(15, 58)
        Me.lblNumGuests.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumGuests.Name = "lblNumGuests"
        Me.lblNumGuests.Size = New System.Drawing.Size(124, 21)
        Me.lblNumGuests.TabIndex = 8
        Me.lblNumGuests.Text = "Number of Guests"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(31, 31)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(41, 41)
        Me.btnBack.TabIndex = 19
        Me.btnBack.Text = "←"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(80, 31)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(41, 41)
        Me.btnNext.TabIndex = 29
        Me.btnNext.Text = "→"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(56, 166)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(502, 283)
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(329, 709)
        Me.lblDescription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(75, 16)
        Me.lblDescription.TabIndex = 31
        Me.lblDescription.Text = "Description"
        '
        'lblDescriptionContainer
        '
        Me.lblDescriptionContainer.AutoSize = True
        Me.lblDescriptionContainer.BackColor = System.Drawing.Color.Transparent
        Me.lblDescriptionContainer.Font = New System.Drawing.Font("Poppins Light", 6.0!)
        Me.lblDescriptionContainer.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblDescriptionContainer.Location = New System.Drawing.Point(77, 659)
        Me.lblDescriptionContainer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescriptionContainer.Name = "lblDescriptionContainer"
        Me.lblDescriptionContainer.Size = New System.Drawing.Size(13, 18)
        Me.lblDescriptionContainer.TabIndex = 32
        Me.lblDescriptionContainer.Text = "-"
        '
        'dtpEventDateEnd
        '
        Me.dtpEventDateEnd.Location = New System.Drawing.Point(151, 162)
        Me.dtpEventDateEnd.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpEventDateEnd.Name = "dtpEventDateEnd"
        Me.dtpEventDateEnd.Size = New System.Drawing.Size(300, 27)
        Me.dtpEventDateEnd.TabIndex = 24
        '
        'lblEnd
        '
        Me.lblEnd.AutoSize = True
        Me.lblEnd.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblEnd.Location = New System.Drawing.Point(96, 169)
        Me.lblEnd.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(34, 23)
        Me.lblEnd.TabIndex = 23
        Me.lblEnd.Text = "End"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblDate.Location = New System.Drawing.Point(57, 116)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(41, 23)
        Me.lblDate.TabIndex = 25
        Me.lblDate.Text = "Date"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblTime.Location = New System.Drawing.Point(57, 188)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(41, 23)
        Me.lblTime.TabIndex = 26
        Me.lblTime.Text = "Time"
        '
        'lblEventTimeEnd
        '
        Me.lblEventTimeEnd.AutoSize = True
        Me.lblEventTimeEnd.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblEventTimeEnd.Location = New System.Drawing.Point(96, 241)
        Me.lblEventTimeEnd.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEventTimeEnd.Name = "lblEventTimeEnd"
        Me.lblEventTimeEnd.Size = New System.Drawing.Size(34, 23)
        Me.lblEventTimeEnd.TabIndex = 28
        Me.lblEventTimeEnd.Text = "End"
        '
        'lblEventTimeStart
        '
        Me.lblEventTimeStart.AutoSize = True
        Me.lblEventTimeStart.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblEventTimeStart.Location = New System.Drawing.Point(92, 210)
        Me.lblEventTimeStart.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEventTimeStart.Name = "lblEventTimeStart"
        Me.lblEventTimeStart.Size = New System.Drawing.Size(42, 23)
        Me.lblEventTimeStart.TabIndex = 27
        Me.lblEventTimeStart.Text = "Start"
        '
        'lblAvailability
        '
        Me.lblAvailability.AutoSize = True
        Me.lblAvailability.Location = New System.Drawing.Point(309, 693)
        Me.lblAvailability.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAvailability.Name = "lblAvailability"
        Me.lblAvailability.Size = New System.Drawing.Size(72, 16)
        Me.lblAvailability.TabIndex = 33
        Me.lblAvailability.Text = "Availability"
        '
        'tcDetails
        '
        Me.tcDetails.Controls.Add(Me.tpBookingDetails)
        Me.tcDetails.Controls.Add(Me.tpCustomerDetails)
        Me.tcDetails.Controls.Add(Me.tpPaymentDetails)
        Me.tcDetails.Font = New System.Drawing.Font("Poppins", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcDetails.Location = New System.Drawing.Point(566, 132)
        Me.tcDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.tcDetails.Name = "tcDetails"
        Me.tcDetails.SelectedIndex = 0
        Me.tcDetails.Size = New System.Drawing.Size(825, 645)
        Me.tcDetails.TabIndex = 35
        '
        'tpBookingDetails
        '
        Me.tpBookingDetails.Controls.Add(Me.pnlBookingDetails)
        Me.tpBookingDetails.Location = New System.Drawing.Point(4, 32)
        Me.tpBookingDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.tpBookingDetails.Name = "tpBookingDetails"
        Me.tpBookingDetails.Padding = New System.Windows.Forms.Padding(4)
        Me.tpBookingDetails.Size = New System.Drawing.Size(817, 609)
        Me.tpBookingDetails.TabIndex = 0
        Me.tpBookingDetails.Text = "Booking Details"
        Me.tpBookingDetails.UseVisualStyleBackColor = True
        '
        'pnlBookingDetails
        '
        Me.pnlBookingDetails.BackgroundImage = Global.maramingeme.My.Resources.Resources.panel
        Me.pnlBookingDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
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
        Me.pnlBookingDetails.Location = New System.Drawing.Point(8, 8)
        Me.pnlBookingDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlBookingDetails.Name = "pnlBookingDetails"
        Me.pnlBookingDetails.Size = New System.Drawing.Size(790, 605)
        Me.pnlBookingDetails.TabIndex = 36
        '
        'lblPriceBreakdown
        '
        Me.lblPriceBreakdown.AutoSize = True
        Me.lblPriceBreakdown.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblPriceBreakdown.Location = New System.Drawing.Point(23, 427)
        Me.lblPriceBreakdown.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPriceBreakdown.Name = "lblPriceBreakdown"
        Me.lblPriceBreakdown.Size = New System.Drawing.Size(118, 23)
        Me.lblPriceBreakdown.TabIndex = 48
        Me.lblPriceBreakdown.Text = "Price Breakdown"
        '
        'lblBeyondAvailabilityFee
        '
        Me.lblBeyondAvailabilityFee.AutoSize = True
        Me.lblBeyondAvailabilityFee.Font = New System.Drawing.Font("Poppins", 6.0!)
        Me.lblBeyondAvailabilityFee.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblBeyondAvailabilityFee.Location = New System.Drawing.Point(430, 207)
        Me.lblBeyondAvailabilityFee.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBeyondAvailabilityFee.Name = "lblBeyondAvailabilityFee"
        Me.lblBeyondAvailabilityFee.Size = New System.Drawing.Size(125, 36)
        Me.lblBeyondAvailabilityFee.TabIndex = 47
        Me.lblBeyondAvailabilityFee.Text = "Beyond Availability Fee " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(₱17 per minute)"
        '
        'lblCapacityExceedanceFee
        '
        Me.lblCapacityExceedanceFee.AutoSize = True
        Me.lblCapacityExceedanceFee.Font = New System.Drawing.Font("Poppins", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapacityExceedanceFee.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblCapacityExceedanceFee.Location = New System.Drawing.Point(379, 54)
        Me.lblCapacityExceedanceFee.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCapacityExceedanceFee.Name = "lblCapacityExceedanceFee"
        Me.lblCapacityExceedanceFee.Size = New System.Drawing.Size(141, 36)
        Me.lblCapacityExceedanceFee.TabIndex = 46
        Me.lblCapacityExceedanceFee.Text = "Capacity Exceedance Fee " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(₱100 per additional)"
        '
        'chkOutsideAvailableHours
        '
        Me.chkOutsideAvailableHours.AutoSize = True
        Me.chkOutsideAvailableHours.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.chkOutsideAvailableHours.Location = New System.Drawing.Point(96, 272)
        Me.chkOutsideAvailableHours.Margin = New System.Windows.Forms.Padding(4)
        Me.chkOutsideAvailableHours.Name = "chkOutsideAvailableHours"
        Me.chkOutsideAvailableHours.Size = New System.Drawing.Size(299, 27)
        Me.chkOutsideAvailableHours.TabIndex = 45
        Me.chkOutsideAvailableHours.Text = "Book outside available hours (+ extra fee)"
        Me.chkOutsideAvailableHours.UseVisualStyleBackColor = True
        '
        'cbSameDayEvent
        '
        Me.cbSameDayEvent.AutoSize = True
        Me.cbSameDayEvent.Location = New System.Drawing.Point(312, 102)
        Me.cbSameDayEvent.Margin = New System.Windows.Forms.Padding(4)
        Me.cbSameDayEvent.Name = "cbSameDayEvent"
        Me.cbSameDayEvent.Size = New System.Drawing.Size(136, 27)
        Me.cbSameDayEvent.TabIndex = 44
        Me.cbSameDayEvent.Text = "Same Day Event"
        Me.cbSameDayEvent.UseVisualStyleBackColor = True
        '
        'cbEndAMPM
        '
        Me.cbEndAMPM.FormattingEnabled = True
        Me.cbEndAMPM.Items.AddRange(New Object() {"AM", "PM"})
        Me.cbEndAMPM.Location = New System.Drawing.Point(344, 238)
        Me.cbEndAMPM.Margin = New System.Windows.Forms.Padding(4)
        Me.cbEndAMPM.Name = "cbEndAMPM"
        Me.cbEndAMPM.Size = New System.Drawing.Size(87, 31)
        Me.cbEndAMPM.TabIndex = 43
        '
        'cbEndMinutes
        '
        Me.cbEndMinutes.FormattingEnabled = True
        Me.cbEndMinutes.Items.AddRange(New Object() {"00", "05", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55"})
        Me.cbEndMinutes.Location = New System.Drawing.Point(248, 238)
        Me.cbEndMinutes.Margin = New System.Windows.Forms.Padding(4)
        Me.cbEndMinutes.Name = "cbEndMinutes"
        Me.cbEndMinutes.Size = New System.Drawing.Size(87, 31)
        Me.cbEndMinutes.TabIndex = 42
        '
        'cbEndHour
        '
        Me.cbEndHour.FormattingEnabled = True
        Me.cbEndHour.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cbEndHour.Location = New System.Drawing.Point(152, 238)
        Me.cbEndHour.Margin = New System.Windows.Forms.Padding(4)
        Me.cbEndHour.Name = "cbEndHour"
        Me.cbEndHour.Size = New System.Drawing.Size(87, 31)
        Me.cbEndHour.TabIndex = 41
        '
        'cbStartAMPM
        '
        Me.cbStartAMPM.FormattingEnabled = True
        Me.cbStartAMPM.Items.AddRange(New Object() {"AM", "PM"})
        Me.cbStartAMPM.Location = New System.Drawing.Point(344, 207)
        Me.cbStartAMPM.Margin = New System.Windows.Forms.Padding(4)
        Me.cbStartAMPM.Name = "cbStartAMPM"
        Me.cbStartAMPM.Size = New System.Drawing.Size(87, 31)
        Me.cbStartAMPM.TabIndex = 40
        '
        'cbStartMinutes
        '
        Me.cbStartMinutes.FormattingEnabled = True
        Me.cbStartMinutes.Items.AddRange(New Object() {"00", "05", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55"})
        Me.cbStartMinutes.Location = New System.Drawing.Point(248, 207)
        Me.cbStartMinutes.Margin = New System.Windows.Forms.Padding(4)
        Me.cbStartMinutes.Name = "cbStartMinutes"
        Me.cbStartMinutes.Size = New System.Drawing.Size(87, 31)
        Me.cbStartMinutes.TabIndex = 39
        '
        'cbStartHour
        '
        Me.cbStartHour.FormattingEnabled = True
        Me.cbStartHour.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cbStartHour.Location = New System.Drawing.Point(152, 207)
        Me.cbStartHour.Margin = New System.Windows.Forms.Padding(4)
        Me.cbStartHour.Name = "cbStartHour"
        Me.cbStartHour.Size = New System.Drawing.Size(87, 31)
        Me.cbStartHour.TabIndex = 38
        '
        'lblEventType
        '
        Me.lblEventType.AutoSize = True
        Me.lblEventType.Font = New System.Drawing.Font("Poppins Medium", 7.0!, System.Drawing.FontStyle.Bold)
        Me.lblEventType.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblEventType.Location = New System.Drawing.Point(15, 29)
        Me.lblEventType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEventType.Name = "lblEventType"
        Me.lblEventType.Size = New System.Drawing.Size(78, 21)
        Me.lblEventType.TabIndex = 37
        Me.lblEventType.Text = "Event Type"
        '
        'cbEventType
        '
        Me.cbEventType.FormattingEnabled = True
        Me.cbEventType.Location = New System.Drawing.Point(147, 21)
        Me.cbEventType.Margin = New System.Windows.Forms.Padding(4)
        Me.cbEventType.Name = "cbEventType"
        Me.cbEventType.Size = New System.Drawing.Size(224, 31)
        Me.cbEventType.TabIndex = 36
        '
        'tpCustomerDetails
        '
        Me.tpCustomerDetails.BackColor = System.Drawing.Color.Snow
        Me.tpCustomerDetails.Controls.Add(Me.pnlCustomerDetails)
        Me.tpCustomerDetails.Location = New System.Drawing.Point(4, 32)
        Me.tpCustomerDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.tpCustomerDetails.Name = "tpCustomerDetails"
        Me.tpCustomerDetails.Padding = New System.Windows.Forms.Padding(4)
        Me.tpCustomerDetails.Size = New System.Drawing.Size(817, 609)
        Me.tpCustomerDetails.TabIndex = 1
        Me.tpCustomerDetails.Text = "Customer Details"
        '
        'pnlCustomerDetails
        '
        Me.pnlCustomerDetails.BackColor = System.Drawing.Color.Transparent
        Me.pnlCustomerDetails.BackgroundImage = Global.maramingeme.My.Resources.Resources.panel
        Me.pnlCustomerDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
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
        Me.pnlCustomerDetails.Location = New System.Drawing.Point(8, 7)
        Me.pnlCustomerDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlCustomerDetails.Name = "pnlCustomerDetails"
        Me.pnlCustomerDetails.Size = New System.Drawing.Size(790, 605)
        Me.pnlCustomerDetails.TabIndex = 36
        '
        'btnCustomerProceed
        '
        Me.btnCustomerProceed.BackgroundImage = Global.maramingeme.My.Resources.Resources.btnProceed
        Me.btnCustomerProceed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCustomerProceed.Location = New System.Drawing.Point(585, 487)
        Me.btnCustomerProceed.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCustomerProceed.Name = "btnCustomerProceed"
        Me.btnCustomerProceed.Size = New System.Drawing.Size(175, 50)
        Me.btnCustomerProceed.TabIndex = 21
        Me.btnCustomerProceed.UseVisualStyleBackColor = True
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.txtCustomerName.Location = New System.Drawing.Point(162, 54)
        Me.txtCustomerName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(424, 32)
        Me.txtCustomerName.TabIndex = 0
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Poppins Medium", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblName.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblName.Location = New System.Drawing.Point(24, 55)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(74, 33)
        Me.lblName.TabIndex = 8
        Me.lblName.Text = "Name"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Poppins Medium", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblAddress.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblAddress.Location = New System.Drawing.Point(24, 223)
        Me.lblAddress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(97, 33)
        Me.lblAddress.TabIndex = 12
        Me.lblAddress.Text = "Address"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.txtAddress.Location = New System.Drawing.Point(162, 227)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(424, 32)
        Me.txtAddress.TabIndex = 6
        '
        'txtAge
        '
        Me.txtAge.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.txtAge.Location = New System.Drawing.Point(162, 140)
        Me.txtAge.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.ReadOnly = True
        Me.txtAge.Size = New System.Drawing.Size(424, 32)
        Me.txtAge.TabIndex = 1
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Poppins Medium", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblAge.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblAge.Location = New System.Drawing.Point(24, 139)
        Me.lblAge.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(54, 33)
        Me.lblAge.TabIndex = 9
        Me.lblAge.Text = "Age"
        '
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.lblSex.Font = New System.Drawing.Font("Poppins Medium", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblSex.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblSex.Location = New System.Drawing.Point(24, 181)
        Me.lblSex.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(49, 33)
        Me.lblSex.TabIndex = 11
        Me.lblSex.Text = "Sex"
        '
        'cmbSex
        '
        Me.cmbSex.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.cmbSex.FormattingEnabled = True
        Me.cmbSex.Items.AddRange(New Object() {"Male", "Female", "Non-Binary", "Other", "Prefer Not to Say"})
        Me.cmbSex.Location = New System.Drawing.Point(162, 181)
        Me.cmbSex.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSex.Name = "cmbSex"
        Me.cmbSex.Size = New System.Drawing.Size(424, 38)
        Me.cmbSex.TabIndex = 5
        '
        'lblBirthday
        '
        Me.lblBirthday.AutoSize = True
        Me.lblBirthday.Font = New System.Drawing.Font("Poppins Medium", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblBirthday.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblBirthday.Location = New System.Drawing.Point(24, 97)
        Me.lblBirthday.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBirthday.Name = "lblBirthday"
        Me.lblBirthday.Size = New System.Drawing.Size(100, 33)
        Me.lblBirthday.TabIndex = 10
        Me.lblBirthday.Text = "Birthday"
        '
        'dtpBirthday
        '
        Me.dtpBirthday.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.dtpBirthday.Location = New System.Drawing.Point(162, 98)
        Me.dtpBirthday.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpBirthday.Name = "dtpBirthday"
        Me.dtpBirthday.Size = New System.Drawing.Size(424, 32)
        Me.dtpBirthday.TabIndex = 4
        '
        'tpPaymentDetails
        '
        Me.tpPaymentDetails.BackgroundImage = Global.maramingeme.My.Resources.Resources.panel
        Me.tpPaymentDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
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
        Me.tpPaymentDetails.Location = New System.Drawing.Point(4, 32)
        Me.tpPaymentDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.tpPaymentDetails.Name = "tpPaymentDetails"
        Me.tpPaymentDetails.Padding = New System.Windows.Forms.Padding(4)
        Me.tpPaymentDetails.Size = New System.Drawing.Size(817, 609)
        Me.tpPaymentDetails.TabIndex = 2
        Me.tpPaymentDetails.Text = "Payment Details"
        Me.tpPaymentDetails.UseVisualStyleBackColor = True
        '
        'lblOffHoursMinutesContainer
        '
        Me.lblOffHoursMinutesContainer.AutoSize = True
        Me.lblOffHoursMinutesContainer.ForeColor = System.Drawing.Color.Gray
        Me.lblOffHoursMinutesContainer.Location = New System.Drawing.Point(159, 135)
        Me.lblOffHoursMinutesContainer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOffHoursMinutesContainer.Name = "lblOffHoursMinutesContainer"
        Me.lblOffHoursMinutesContainer.Size = New System.Drawing.Size(17, 23)
        Me.lblOffHoursMinutesContainer.TabIndex = 29
        Me.lblOffHoursMinutesContainer.Text = "-"
        '
        'lblOffHoursTotalFeeContainer
        '
        Me.lblOffHoursTotalFeeContainer.AutoSize = True
        Me.lblOffHoursTotalFeeContainer.Location = New System.Drawing.Point(365, 135)
        Me.lblOffHoursTotalFeeContainer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOffHoursTotalFeeContainer.Name = "lblOffHoursTotalFeeContainer"
        Me.lblOffHoursTotalFeeContainer.Size = New System.Drawing.Size(17, 23)
        Me.lblOffHoursTotalFeeContainer.TabIndex = 28
        Me.lblOffHoursTotalFeeContainer.Text = "-"
        '
        'lblOffHoursBookingFee
        '
        Me.lblOffHoursBookingFee.AutoSize = True
        Me.lblOffHoursBookingFee.Font = New System.Drawing.Font("Poppins Medium", 7.0!, System.Drawing.FontStyle.Bold)
        Me.lblOffHoursBookingFee.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblOffHoursBookingFee.Location = New System.Drawing.Point(23, 113)
        Me.lblOffHoursBookingFee.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOffHoursBookingFee.Name = "lblOffHoursBookingFee"
        Me.lblOffHoursBookingFee.Size = New System.Drawing.Size(147, 21)
        Me.lblOffHoursBookingFee.TabIndex = 27
        Me.lblOffHoursBookingFee.Text = "Off-hours booking fee"
        '
        'lblSelectedVoucherContainer
        '
        Me.lblSelectedVoucherContainer.AutoSize = True
        Me.lblSelectedVoucherContainer.Location = New System.Drawing.Point(172, 324)
        Me.lblSelectedVoucherContainer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSelectedVoucherContainer.Name = "lblSelectedVoucherContainer"
        Me.lblSelectedVoucherContainer.Size = New System.Drawing.Size(17, 23)
        Me.lblSelectedVoucherContainer.TabIndex = 26
        Me.lblSelectedVoucherContainer.Text = "-"
        '
        'lblSelectedVoucher
        '
        Me.lblSelectedVoucher.AutoSize = True
        Me.lblSelectedVoucher.Font = New System.Drawing.Font("Poppins Medium", 7.0!, System.Drawing.FontStyle.Bold)
        Me.lblSelectedVoucher.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblSelectedVoucher.Location = New System.Drawing.Point(24, 324)
        Me.lblSelectedVoucher.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSelectedVoucher.Name = "lblSelectedVoucher"
        Me.lblSelectedVoucher.Size = New System.Drawing.Size(123, 21)
        Me.lblSelectedVoucher.TabIndex = 25
        Me.lblSelectedVoucher.Text = "Selected Voucher"
        '
        'btnPlaceBooking
        '
        Me.btnPlaceBooking.BackgroundImage = Global.maramingeme.My.Resources.Resources.btnPlaceBooking
        Me.btnPlaceBooking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPlaceBooking.FlatAppearance.BorderSize = 0
        Me.btnPlaceBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlaceBooking.Location = New System.Drawing.Point(585, 487)
        Me.btnPlaceBooking.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPlaceBooking.Name = "btnPlaceBooking"
        Me.btnPlaceBooking.Size = New System.Drawing.Size(175, 50)
        Me.btnPlaceBooking.TabIndex = 24
        Me.btnPlaceBooking.UseVisualStyleBackColor = True
        '
        'lblVoucherDiscountContainer
        '
        Me.lblVoucherDiscountContainer.AutoSize = True
        Me.lblVoucherDiscountContainer.ForeColor = System.Drawing.Color.Gray
        Me.lblVoucherDiscountContainer.Location = New System.Drawing.Point(367, 370)
        Me.lblVoucherDiscountContainer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVoucherDiscountContainer.Name = "lblVoucherDiscountContainer"
        Me.lblVoucherDiscountContainer.Size = New System.Drawing.Size(17, 23)
        Me.lblVoucherDiscountContainer.TabIndex = 23
        Me.lblVoucherDiscountContainer.Text = "-"
        '
        'lblVoucherDiscount
        '
        Me.lblVoucherDiscount.AutoSize = True
        Me.lblVoucherDiscount.Font = New System.Drawing.Font("Poppins Medium", 7.0!, System.Drawing.FontStyle.Bold)
        Me.lblVoucherDiscount.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblVoucherDiscount.Location = New System.Drawing.Point(219, 370)
        Me.lblVoucherDiscount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVoucherDiscount.Name = "lblVoucherDiscount"
        Me.lblVoucherDiscount.Size = New System.Drawing.Size(123, 21)
        Me.lblVoucherDiscount.TabIndex = 22
        Me.lblVoucherDiscount.Text = "Voucher Discount"
        '
        'lblVoucher
        '
        Me.lblVoucher.AutoSize = True
        Me.lblVoucher.Font = New System.Drawing.Font("Poppins Medium", 7.0!, System.Drawing.FontStyle.Bold)
        Me.lblVoucher.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblVoucher.Location = New System.Drawing.Point(23, 294)
        Me.lblVoucher.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVoucher.Name = "lblVoucher"
        Me.lblVoucher.Size = New System.Drawing.Size(64, 21)
        Me.lblVoucher.TabIndex = 19
        Me.lblVoucher.Text = "Voucher"
        '
        'btnVoucher
        '
        Me.btnVoucher.Location = New System.Drawing.Point(159, 288)
        Me.btnVoucher.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVoucher.Name = "btnVoucher"
        Me.btnVoucher.Size = New System.Drawing.Size(317, 28)
        Me.btnVoucher.TabIndex = 18
        Me.btnVoucher.Text = "Select Voucher"
        Me.btnVoucher.UseVisualStyleBackColor = True
        '
        'txtPayAmount
        '
        Me.txtPayAmount.Location = New System.Drawing.Point(159, 399)
        Me.txtPayAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPayAmount.Name = "txtPayAmount"
        Me.txtPayAmount.Size = New System.Drawing.Size(316, 27)
        Me.txtPayAmount.TabIndex = 17
        '
        'lblPayAmount
        '
        Me.lblPayAmount.AutoSize = True
        Me.lblPayAmount.Font = New System.Drawing.Font("Poppins Medium", 7.0!, System.Drawing.FontStyle.Bold)
        Me.lblPayAmount.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblPayAmount.Location = New System.Drawing.Point(23, 402)
        Me.lblPayAmount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPayAmount.Name = "lblPayAmount"
        Me.lblPayAmount.Size = New System.Drawing.Size(86, 21)
        Me.lblPayAmount.TabIndex = 16
        Me.lblPayAmount.Text = "Pay Amount"
        '
        'lblTotalPricePaymentContainer
        '
        Me.lblTotalPricePaymentContainer.AutoSize = True
        Me.lblTotalPricePaymentContainer.ForeColor = System.Drawing.Color.Gray
        Me.lblTotalPricePaymentContainer.Location = New System.Drawing.Point(367, 354)
        Me.lblTotalPricePaymentContainer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalPricePaymentContainer.Name = "lblTotalPricePaymentContainer"
        Me.lblTotalPricePaymentContainer.Size = New System.Drawing.Size(17, 23)
        Me.lblTotalPricePaymentContainer.TabIndex = 15
        Me.lblTotalPricePaymentContainer.Text = "-"
        '
        'lblTotalPricePayment
        '
        Me.lblTotalPricePayment.AutoSize = True
        Me.lblTotalPricePayment.Font = New System.Drawing.Font("Poppins Medium", 7.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalPricePayment.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblTotalPricePayment.Location = New System.Drawing.Point(264, 354)
        Me.lblTotalPricePayment.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalPricePayment.Name = "lblTotalPricePayment"
        Me.lblTotalPricePayment.Size = New System.Drawing.Size(75, 21)
        Me.lblTotalPricePayment.TabIndex = 14
        Me.lblTotalPricePayment.Text = "Total Price"
        '
        'lblServicesPaymentContainer
        '
        Me.lblServicesPaymentContainer.AutoSize = True
        Me.lblServicesPaymentContainer.ForeColor = System.Drawing.Color.Gray
        Me.lblServicesPaymentContainer.Location = New System.Drawing.Point(160, 164)
        Me.lblServicesPaymentContainer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblServicesPaymentContainer.Name = "lblServicesPaymentContainer"
        Me.lblServicesPaymentContainer.Size = New System.Drawing.Size(17, 23)
        Me.lblServicesPaymentContainer.TabIndex = 13
        Me.lblServicesPaymentContainer.Text = "-"
        '
        'lblServicesPayment
        '
        Me.lblServicesPayment.AutoSize = True
        Me.lblServicesPayment.Font = New System.Drawing.Font("Poppins Medium", 7.0!, System.Drawing.FontStyle.Bold)
        Me.lblServicesPayment.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblServicesPayment.Location = New System.Drawing.Point(21, 164)
        Me.lblServicesPayment.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblServicesPayment.Name = "lblServicesPayment"
        Me.lblServicesPayment.Size = New System.Drawing.Size(113, 21)
        Me.lblServicesPayment.TabIndex = 12
        Me.lblServicesPayment.Text = "Services Availed"
        '
        'lblEventTimePaymentContainer
        '
        Me.lblEventTimePaymentContainer.AutoSize = True
        Me.lblEventTimePaymentContainer.ForeColor = System.Drawing.Color.Gray
        Me.lblEventTimePaymentContainer.Location = New System.Drawing.Point(160, 82)
        Me.lblEventTimePaymentContainer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEventTimePaymentContainer.Name = "lblEventTimePaymentContainer"
        Me.lblEventTimePaymentContainer.Size = New System.Drawing.Size(17, 23)
        Me.lblEventTimePaymentContainer.TabIndex = 11
        Me.lblEventTimePaymentContainer.Text = "-"
        '
        'lblEventTimePayment
        '
        Me.lblEventTimePayment.AutoSize = True
        Me.lblEventTimePayment.Font = New System.Drawing.Font("Poppins Medium", 7.0!, System.Drawing.FontStyle.Bold)
        Me.lblEventTimePayment.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblEventTimePayment.Location = New System.Drawing.Point(21, 82)
        Me.lblEventTimePayment.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEventTimePayment.Name = "lblEventTimePayment"
        Me.lblEventTimePayment.Size = New System.Drawing.Size(79, 21)
        Me.lblEventTimePayment.TabIndex = 10
        Me.lblEventTimePayment.Text = "Event Time"
        '
        'lblEventDatePaymentContainer
        '
        Me.lblEventDatePaymentContainer.AutoSize = True
        Me.lblEventDatePaymentContainer.ForeColor = System.Drawing.Color.Gray
        Me.lblEventDatePaymentContainer.Location = New System.Drawing.Point(160, 66)
        Me.lblEventDatePaymentContainer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEventDatePaymentContainer.Name = "lblEventDatePaymentContainer"
        Me.lblEventDatePaymentContainer.Size = New System.Drawing.Size(17, 23)
        Me.lblEventDatePaymentContainer.TabIndex = 9
        Me.lblEventDatePaymentContainer.Text = "-"
        '
        'lblEventDatePayment
        '
        Me.lblEventDatePayment.AutoSize = True
        Me.lblEventDatePayment.Font = New System.Drawing.Font("Poppins Medium", 7.0!, System.Drawing.FontStyle.Bold)
        Me.lblEventDatePayment.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblEventDatePayment.Location = New System.Drawing.Point(21, 66)
        Me.lblEventDatePayment.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEventDatePayment.Name = "lblEventDatePayment"
        Me.lblEventDatePayment.Size = New System.Drawing.Size(78, 21)
        Me.lblEventDatePayment.TabIndex = 8
        Me.lblEventDatePayment.Text = "Event Date"
        '
        'lblNumGuestsPaymentContainer
        '
        Me.lblNumGuestsPaymentContainer.AutoSize = True
        Me.lblNumGuestsPaymentContainer.ForeColor = System.Drawing.Color.Gray
        Me.lblNumGuestsPaymentContainer.Location = New System.Drawing.Point(160, 50)
        Me.lblNumGuestsPaymentContainer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumGuestsPaymentContainer.Name = "lblNumGuestsPaymentContainer"
        Me.lblNumGuestsPaymentContainer.Size = New System.Drawing.Size(17, 23)
        Me.lblNumGuestsPaymentContainer.TabIndex = 7
        Me.lblNumGuestsPaymentContainer.Text = "-"
        '
        'lblNumGuestsPayment
        '
        Me.lblNumGuestsPayment.AutoSize = True
        Me.lblNumGuestsPayment.Font = New System.Drawing.Font("Poppins Medium", 7.0!, System.Drawing.FontStyle.Bold)
        Me.lblNumGuestsPayment.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblNumGuestsPayment.Location = New System.Drawing.Point(21, 50)
        Me.lblNumGuestsPayment.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumGuestsPayment.Name = "lblNumGuestsPayment"
        Me.lblNumGuestsPayment.Size = New System.Drawing.Size(124, 21)
        Me.lblNumGuestsPayment.TabIndex = 6
        Me.lblNumGuestsPayment.Text = "Number of Guests"
        '
        'lblEventTypePaymentContainer
        '
        Me.lblEventTypePaymentContainer.AutoSize = True
        Me.lblEventTypePaymentContainer.ForeColor = System.Drawing.Color.Gray
        Me.lblEventTypePaymentContainer.Location = New System.Drawing.Point(451, 31)
        Me.lblEventTypePaymentContainer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEventTypePaymentContainer.Name = "lblEventTypePaymentContainer"
        Me.lblEventTypePaymentContainer.Size = New System.Drawing.Size(17, 23)
        Me.lblEventTypePaymentContainer.TabIndex = 5
        Me.lblEventTypePaymentContainer.Text = "-"
        '
        'lblEventTypePayment
        '
        Me.lblEventTypePayment.AutoSize = True
        Me.lblEventTypePayment.Location = New System.Drawing.Point(312, 31)
        Me.lblEventTypePayment.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEventTypePayment.Name = "lblEventTypePayment"
        Me.lblEventTypePayment.Size = New System.Drawing.Size(79, 23)
        Me.lblEventTypePayment.TabIndex = 4
        Me.lblEventTypePayment.Text = "Event Type"
        '
        'lblEventPlacePaymentContainer
        '
        Me.lblEventPlacePaymentContainer.AutoSize = True
        Me.lblEventPlacePaymentContainer.ForeColor = System.Drawing.Color.Gray
        Me.lblEventPlacePaymentContainer.Location = New System.Drawing.Point(451, 15)
        Me.lblEventPlacePaymentContainer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEventPlacePaymentContainer.Name = "lblEventPlacePaymentContainer"
        Me.lblEventPlacePaymentContainer.Size = New System.Drawing.Size(17, 23)
        Me.lblEventPlacePaymentContainer.TabIndex = 3
        Me.lblEventPlacePaymentContainer.Text = "-"
        '
        'lblEventPlacePayment
        '
        Me.lblEventPlacePayment.AutoSize = True
        Me.lblEventPlacePayment.Location = New System.Drawing.Point(312, 15)
        Me.lblEventPlacePayment.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEventPlacePayment.Name = "lblEventPlacePayment"
        Me.lblEventPlacePayment.Size = New System.Drawing.Size(84, 23)
        Me.lblEventPlacePayment.TabIndex = 2
        Me.lblEventPlacePayment.Text = "Event Place"
        '
        'lblCustomerContainer
        '
        Me.lblCustomerContainer.AutoSize = True
        Me.lblCustomerContainer.ForeColor = System.Drawing.Color.Gray
        Me.lblCustomerContainer.Location = New System.Drawing.Point(160, 15)
        Me.lblCustomerContainer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCustomerContainer.Name = "lblCustomerContainer"
        Me.lblCustomerContainer.Size = New System.Drawing.Size(17, 23)
        Me.lblCustomerContainer.TabIndex = 1
        Me.lblCustomerContainer.Text = "-"
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Poppins Medium", 7.0!, System.Drawing.FontStyle.Bold)
        Me.lblCustomerName.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblCustomerName.Location = New System.Drawing.Point(21, 15)
        Me.lblCustomerName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(74, 21)
        Me.lblCustomerName.TabIndex = 0
        Me.lblCustomerName.Text = "Customer"
        '
        'lblHoursContainer
        '
        Me.lblHoursContainer.AutoSize = True
        Me.lblHoursContainer.BackColor = System.Drawing.Color.Transparent
        Me.lblHoursContainer.Font = New System.Drawing.Font("Poppins Light", 6.0!)
        Me.lblHoursContainer.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblHoursContainer.Location = New System.Drawing.Point(78, 563)
        Me.lblHoursContainer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHoursContainer.Name = "lblHoursContainer"
        Me.lblHoursContainer.Size = New System.Drawing.Size(13, 18)
        Me.lblHoursContainer.TabIndex = 36
        Me.lblHoursContainer.Text = "-"
        '
        'lblAvailableDaysContainer
        '
        Me.lblAvailableDaysContainer.AutoSize = True
        Me.lblAvailableDaysContainer.BackColor = System.Drawing.Color.Transparent
        Me.lblAvailableDaysContainer.Font = New System.Drawing.Font("Poppins Light", 8.0!)
        Me.lblAvailableDaysContainer.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblAvailableDaysContainer.Location = New System.Drawing.Point(387, 560)
        Me.lblAvailableDaysContainer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAvailableDaysContainer.Name = "lblAvailableDaysContainer"
        Me.lblAvailableDaysContainer.Size = New System.Drawing.Size(77, 25)
        Me.lblAvailableDaysContainer.TabIndex = 38
        Me.lblAvailableDaysContainer.Text = "Available:"
        '
        'mcAvailability
        '
        Me.mcAvailability.Font = New System.Drawing.Font("Poppins", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcAvailability.Location = New System.Drawing.Point(246, 47)
        Me.mcAvailability.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.mcAvailability.Name = "mcAvailability"
        Me.mcAvailability.TabIndex = 39
        '
        'FormBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.maramingeme.My.Resources.Resources.no_pan
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1422, 763)
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
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(4)
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
