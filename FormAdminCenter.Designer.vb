<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAdminCenter
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.btnEditInformation = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.pbAdmin = New System.Windows.Forms.PictureBox()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.tpBillingSettings = New System.Windows.Forms.TabPage()
        Me.lblEventTypeSetting = New System.Windows.Forms.Label()
        Me.lblPriceAdjust = New System.Windows.Forms.Label()
        Me.lblInvoices = New System.Windows.Forms.Label()
        Me.cbEventTypeSetting = New System.Windows.Forms.ComboBox()
        Me.nudPriceAdjust = New System.Windows.Forms.NumericUpDown()
        Me.btnAdjustPricing = New System.Windows.Forms.Button()
        Me.btnProcessPayment = New System.Windows.Forms.Button()
        Me.dgvInvoices = New System.Windows.Forms.DataGridView()
        Me.tpEventPlaceMgmt = New System.Windows.Forms.TabPage()
        Me.lblEventPlaces = New System.Windows.Forms.Label()
        Me.dgvEventPlaces = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtPlaceID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEventType = New System.Windows.Forms.TextBox()
        Me.lblEventType = New System.Windows.Forms.Label()
        Me.txtEventPlace = New System.Windows.Forms.TextBox()
        Me.lblVenueType = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCapacity = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtCapacity = New System.Windows.Forms.TextBox()
        Me.tpSearchReports = New System.Windows.Forms.TabPage()
        Me.lblAvailability = New System.Windows.Forms.Label()
        Me.dgvAvailability = New System.Windows.Forms.DataGridView()
        Me.btnUpdateBookings = New System.Windows.Forms.Button()
        Me.btnReject = New System.Windows.Forms.Button()
        Me.btnApprove = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.chTotalStatus = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lblBookings = New System.Windows.Forms.Label()
        Me.dgvBookings = New System.Windows.Forms.DataGridView()
        Me.pnlTotalBookings = New System.Windows.Forms.Panel()
        Me.pbTotalBookingsIcon = New System.Windows.Forms.PictureBox()
        Me.lblTotalBookingsContainer = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlNumCustomers = New System.Windows.Forms.Panel()
        Me.pbNumCustomersIcon = New System.Windows.Forms.PictureBox()
        Me.lblNumCustomersContainer = New System.Windows.Forms.Label()
        Me.lblNumCustomers = New System.Windows.Forms.Label()
        Me.lblPopularPlaces = New System.Windows.Forms.Label()
        Me.lblReportType = New System.Windows.Forms.Label()
        Me.lblReportBookings = New System.Windows.Forms.Label()
        Me.btnGenerateReport = New System.Windows.Forms.Button()
        Me.cbReportType = New System.Windows.Forms.ComboBox()
        Me.chartPopularPlaces = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.mcBookings = New System.Windows.Forms.MonthCalendar()
        Me.dgvReportBookings = New System.Windows.Forms.DataGridView()
        Me.tcAdminCenter = New System.Windows.Forms.TabControl()
        Me.tpCustomerRecords = New System.Windows.Forms.TabPage()
        Me.btnLogOut = New System.Windows.Forms.Button()
        CType(Me.pbAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpBillingSettings.SuspendLayout()
        CType(Me.nudPriceAdjust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvInvoices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpEventPlaceMgmt.SuspendLayout()
        CType(Me.dgvEventPlaces, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.tpSearchReports.SuspendLayout()
        CType(Me.dgvAvailability, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chTotalStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBookings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTotalBookings.SuspendLayout()
        CType(Me.pbTotalBookingsIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlNumCustomers.SuspendLayout()
        CType(Me.pbNumCustomersIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chartPopularPlaces, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvReportBookings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcAdminCenter.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEditInformation
        '
        Me.btnEditInformation.Location = New System.Drawing.Point(1352, 15)
        Me.btnEditInformation.Name = "btnEditInformation"
        Me.btnEditInformation.Size = New System.Drawing.Size(56, 23)
        Me.btnEditInformation.TabIndex = 20
        Me.btnEditInformation.Text = "Edit"
        Me.btnEditInformation.UseVisualStyleBackColor = True
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(1234, 15)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(67, 13)
        Me.lblUsername.TabIndex = 19
        Me.lblUsername.Text = "Admin Name"
        '
        'pbAdmin
        '
        Me.pbAdmin.BackColor = System.Drawing.Color.Gainsboro
        Me.pbAdmin.Location = New System.Drawing.Point(1168, 15)
        Me.pbAdmin.Name = "pbAdmin"
        Me.pbAdmin.Size = New System.Drawing.Size(60, 60)
        Me.pbAdmin.TabIndex = 18
        Me.pbAdmin.TabStop = False
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.Location = New System.Drawing.Point(1234, 36)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(36, 13)
        Me.lblRole.TabIndex = 21
        Me.lblRole.Text = "Admin"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(450, 33)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(569, 20)
        Me.txtSearch.TabIndex = 22
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(1025, 33)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 23
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'tpBillingSettings
        '
        Me.tpBillingSettings.Controls.Add(Me.lblEventTypeSetting)
        Me.tpBillingSettings.Controls.Add(Me.lblPriceAdjust)
        Me.tpBillingSettings.Controls.Add(Me.lblInvoices)
        Me.tpBillingSettings.Controls.Add(Me.cbEventTypeSetting)
        Me.tpBillingSettings.Controls.Add(Me.nudPriceAdjust)
        Me.tpBillingSettings.Controls.Add(Me.btnAdjustPricing)
        Me.tpBillingSettings.Controls.Add(Me.btnProcessPayment)
        Me.tpBillingSettings.Controls.Add(Me.dgvInvoices)
        Me.tpBillingSettings.Location = New System.Drawing.Point(23, 4)
        Me.tpBillingSettings.Name = "tpBillingSettings"
        Me.tpBillingSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.tpBillingSettings.Size = New System.Drawing.Size(1373, 670)
        Me.tpBillingSettings.TabIndex = 3
        Me.tpBillingSettings.Text = "Billing & Settings"
        Me.tpBillingSettings.UseVisualStyleBackColor = True
        '
        'lblEventTypeSetting
        '
        Me.lblEventTypeSetting.AutoSize = True
        Me.lblEventTypeSetting.Location = New System.Drawing.Point(260, 485)
        Me.lblEventTypeSetting.Name = "lblEventTypeSetting"
        Me.lblEventTypeSetting.Size = New System.Drawing.Size(98, 13)
        Me.lblEventTypeSetting.TabIndex = 21
        Me.lblEventTypeSetting.Text = "Event Type Setting"
        '
        'lblPriceAdjust
        '
        Me.lblPriceAdjust.AutoSize = True
        Me.lblPriceAdjust.Location = New System.Drawing.Point(260, 457)
        Me.lblPriceAdjust.Name = "lblPriceAdjust"
        Me.lblPriceAdjust.Size = New System.Drawing.Size(63, 13)
        Me.lblPriceAdjust.TabIndex = 20
        Me.lblPriceAdjust.Text = "Price Adjust"
        '
        'lblInvoices
        '
        Me.lblInvoices.AutoSize = True
        Me.lblInvoices.Location = New System.Drawing.Point(260, 8)
        Me.lblInvoices.Name = "lblInvoices"
        Me.lblInvoices.Size = New System.Drawing.Size(47, 13)
        Me.lblInvoices.TabIndex = 19
        Me.lblInvoices.Text = "Invoices"
        '
        'cbEventTypeSetting
        '
        Me.cbEventTypeSetting.FormattingEnabled = True
        Me.cbEventTypeSetting.Location = New System.Drawing.Point(383, 482)
        Me.cbEventTypeSetting.Name = "cbEventTypeSetting"
        Me.cbEventTypeSetting.Size = New System.Drawing.Size(121, 21)
        Me.cbEventTypeSetting.TabIndex = 4
        '
        'nudPriceAdjust
        '
        Me.nudPriceAdjust.Location = New System.Drawing.Point(383, 455)
        Me.nudPriceAdjust.Name = "nudPriceAdjust"
        Me.nudPriceAdjust.Size = New System.Drawing.Size(120, 20)
        Me.nudPriceAdjust.TabIndex = 3
        '
        'btnAdjustPricing
        '
        Me.btnAdjustPricing.Location = New System.Drawing.Point(263, 426)
        Me.btnAdjustPricing.Name = "btnAdjustPricing"
        Me.btnAdjustPricing.Size = New System.Drawing.Size(124, 23)
        Me.btnAdjustPricing.TabIndex = 2
        Me.btnAdjustPricing.Text = "Adjust Pricing"
        Me.btnAdjustPricing.UseVisualStyleBackColor = True
        '
        'btnProcessPayment
        '
        Me.btnProcessPayment.Location = New System.Drawing.Point(263, 397)
        Me.btnProcessPayment.Name = "btnProcessPayment"
        Me.btnProcessPayment.Size = New System.Drawing.Size(124, 23)
        Me.btnProcessPayment.TabIndex = 1
        Me.btnProcessPayment.Text = "Process Payment"
        Me.btnProcessPayment.UseVisualStyleBackColor = True
        '
        'dgvInvoices
        '
        Me.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInvoices.Location = New System.Drawing.Point(263, 24)
        Me.dgvInvoices.Name = "dgvInvoices"
        Me.dgvInvoices.Size = New System.Drawing.Size(699, 367)
        Me.dgvInvoices.TabIndex = 0
        '
        'tpEventPlaceMgmt
        '
        Me.tpEventPlaceMgmt.Controls.Add(Me.lblEventPlaces)
        Me.tpEventPlaceMgmt.Controls.Add(Me.dgvEventPlaces)
        Me.tpEventPlaceMgmt.Controls.Add(Me.GroupBox1)
        Me.tpEventPlaceMgmt.Location = New System.Drawing.Point(23, 4)
        Me.tpEventPlaceMgmt.Name = "tpEventPlaceMgmt"
        Me.tpEventPlaceMgmt.Padding = New System.Windows.Forms.Padding(3)
        Me.tpEventPlaceMgmt.Size = New System.Drawing.Size(1373, 670)
        Me.tpEventPlaceMgmt.TabIndex = 0
        Me.tpEventPlaceMgmt.Text = "Event Place Management"
        Me.tpEventPlaceMgmt.UseVisualStyleBackColor = True
        '
        'lblEventPlaces
        '
        Me.lblEventPlaces.AutoSize = True
        Me.lblEventPlaces.Location = New System.Drawing.Point(263, 5)
        Me.lblEventPlaces.Name = "lblEventPlaces"
        Me.lblEventPlaces.Size = New System.Drawing.Size(70, 13)
        Me.lblEventPlaces.TabIndex = 11
        Me.lblEventPlaces.Text = "Event Places"
        '
        'dgvEventPlaces
        '
        Me.dgvEventPlaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEventPlaces.Location = New System.Drawing.Point(263, 24)
        Me.dgvEventPlaces.Name = "dgvEventPlaces"
        Me.dgvEventPlaces.Size = New System.Drawing.Size(699, 367)
        Me.dgvEventPlaces.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDescription)
        Me.GroupBox1.Controls.Add(Me.lblDescription)
        Me.GroupBox1.Controls.Add(Me.txtPlaceID)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtEventType)
        Me.GroupBox1.Controls.Add(Me.lblEventType)
        Me.GroupBox1.Controls.Add(Me.txtEventPlace)
        Me.GroupBox1.Controls.Add(Me.lblVenueType)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnUpdate)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblCapacity)
        Me.GroupBox1.Controls.Add(Me.txtPrice)
        Me.GroupBox1.Controls.Add(Me.txtCapacity)
        Me.GroupBox1.Location = New System.Drawing.Point(263, 397)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(699, 251)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Event Place"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(108, 162)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(216, 70)
        Me.txtDescription.TabIndex = 17
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(6, 162)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(60, 13)
        Me.lblDescription.TabIndex = 16
        Me.lblDescription.Text = "Description"
        '
        'txtPlaceID
        '
        Me.txtPlaceID.Location = New System.Drawing.Point(108, 50)
        Me.txtPlaceID.Name = "txtPlaceID"
        Me.txtPlaceID.Size = New System.Drawing.Size(216, 20)
        Me.txtPlaceID.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Place ID"
        '
        'txtEventType
        '
        Me.txtEventType.Location = New System.Drawing.Point(108, 77)
        Me.txtEventType.Name = "txtEventType"
        Me.txtEventType.Size = New System.Drawing.Size(216, 20)
        Me.txtEventType.TabIndex = 13
        '
        'lblEventType
        '
        Me.lblEventType.AutoSize = True
        Me.lblEventType.Location = New System.Drawing.Point(6, 78)
        Me.lblEventType.Name = "lblEventType"
        Me.lblEventType.Size = New System.Drawing.Size(74, 13)
        Me.lblEventType.TabIndex = 13
        Me.lblEventType.Text = "Type of Event"
        '
        'txtEventPlace
        '
        Me.txtEventPlace.Location = New System.Drawing.Point(108, 22)
        Me.txtEventPlace.Name = "txtEventPlace"
        Me.txtEventPlace.Size = New System.Drawing.Size(216, 20)
        Me.txtEventPlace.TabIndex = 12
        '
        'lblVenueType
        '
        Me.lblVenueType.AutoSize = True
        Me.lblVenueType.Location = New System.Drawing.Point(6, 22)
        Me.lblVenueType.Name = "lblVenueType"
        Me.lblVenueType.Size = New System.Drawing.Size(65, 13)
        Me.lblVenueType.TabIndex = 12
        Me.lblVenueType.Text = "Event Place"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(349, 80)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(349, 51)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 7
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(349, 22)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Price"
        '
        'lblCapacity
        '
        Me.lblCapacity.AutoSize = True
        Me.lblCapacity.Location = New System.Drawing.Point(6, 106)
        Me.lblCapacity.Name = "lblCapacity"
        Me.lblCapacity.Size = New System.Drawing.Size(48, 13)
        Me.lblCapacity.TabIndex = 4
        Me.lblCapacity.Text = "Capacity"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(108, 131)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(216, 20)
        Me.txtPrice.TabIndex = 2
        '
        'txtCapacity
        '
        Me.txtCapacity.Location = New System.Drawing.Point(108, 103)
        Me.txtCapacity.Name = "txtCapacity"
        Me.txtCapacity.Size = New System.Drawing.Size(216, 20)
        Me.txtCapacity.TabIndex = 1
        '
        'tpSearchReports
        '
        Me.tpSearchReports.Controls.Add(Me.lblAvailability)
        Me.tpSearchReports.Controls.Add(Me.dgvAvailability)
        Me.tpSearchReports.Controls.Add(Me.btnUpdateBookings)
        Me.tpSearchReports.Controls.Add(Me.btnReject)
        Me.tpSearchReports.Controls.Add(Me.btnApprove)
        Me.tpSearchReports.Controls.Add(Me.lblStatus)
        Me.tpSearchReports.Controls.Add(Me.chTotalStatus)
        Me.tpSearchReports.Controls.Add(Me.lblBookings)
        Me.tpSearchReports.Controls.Add(Me.dgvBookings)
        Me.tpSearchReports.Controls.Add(Me.pnlTotalBookings)
        Me.tpSearchReports.Controls.Add(Me.pnlNumCustomers)
        Me.tpSearchReports.Controls.Add(Me.lblPopularPlaces)
        Me.tpSearchReports.Controls.Add(Me.lblReportType)
        Me.tpSearchReports.Controls.Add(Me.lblReportBookings)
        Me.tpSearchReports.Controls.Add(Me.btnGenerateReport)
        Me.tpSearchReports.Controls.Add(Me.cbReportType)
        Me.tpSearchReports.Controls.Add(Me.chartPopularPlaces)
        Me.tpSearchReports.Controls.Add(Me.mcBookings)
        Me.tpSearchReports.Controls.Add(Me.dgvReportBookings)
        Me.tpSearchReports.Location = New System.Drawing.Point(23, 4)
        Me.tpSearchReports.Name = "tpSearchReports"
        Me.tpSearchReports.Padding = New System.Windows.Forms.Padding(3)
        Me.tpSearchReports.Size = New System.Drawing.Size(1373, 670)
        Me.tpSearchReports.TabIndex = 2
        Me.tpSearchReports.Text = "Dashboard"
        Me.tpSearchReports.UseVisualStyleBackColor = True
        '
        'lblAvailability
        '
        Me.lblAvailability.AutoSize = True
        Me.lblAvailability.Location = New System.Drawing.Point(27, 203)
        Me.lblAvailability.Name = "lblAvailability"
        Me.lblAvailability.Size = New System.Drawing.Size(56, 13)
        Me.lblAvailability.TabIndex = 30
        Me.lblAvailability.Text = "Availability"
        '
        'dgvAvailability
        '
        Me.dgvAvailability.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAvailability.Location = New System.Drawing.Point(30, 219)
        Me.dgvAvailability.Name = "dgvAvailability"
        Me.dgvAvailability.Size = New System.Drawing.Size(227, 419)
        Me.dgvAvailability.TabIndex = 29
        '
        'btnUpdateBookings
        '
        Me.btnUpdateBookings.Location = New System.Drawing.Point(1271, 347)
        Me.btnUpdateBookings.Name = "btnUpdateBookings"
        Me.btnUpdateBookings.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateBookings.TabIndex = 28
        Me.btnUpdateBookings.Text = "Update"
        Me.btnUpdateBookings.UseVisualStyleBackColor = True
        '
        'btnReject
        '
        Me.btnReject.Location = New System.Drawing.Point(1271, 318)
        Me.btnReject.Name = "btnReject"
        Me.btnReject.Size = New System.Drawing.Size(75, 23)
        Me.btnReject.TabIndex = 27
        Me.btnReject.Text = "Reject"
        Me.btnReject.UseVisualStyleBackColor = True
        '
        'btnApprove
        '
        Me.btnApprove.Location = New System.Drawing.Point(1271, 289)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(75, 23)
        Me.btnApprove.TabIndex = 26
        Me.btnApprove.Text = "Approve"
        Me.btnApprove.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(771, 39)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(37, 13)
        Me.lblStatus.TabIndex = 25
        Me.lblStatus.Text = "Status"
        '
        'chTotalStatus
        '
        ChartArea1.Name = "ChartArea1"
        Me.chTotalStatus.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chTotalStatus.Legends.Add(Legend1)
        Me.chTotalStatus.Location = New System.Drawing.Point(771, 55)
        Me.chTotalStatus.Name = "chTotalStatus"
        Me.chTotalStatus.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chTotalStatus.Series.Add(Series1)
        Me.chTotalStatus.Size = New System.Drawing.Size(301, 202)
        Me.chTotalStatus.TabIndex = 24
        Me.chTotalStatus.Text = "Popular Places"
        '
        'lblBookings
        '
        Me.lblBookings.AutoSize = True
        Me.lblBookings.Location = New System.Drawing.Point(771, 267)
        Me.lblBookings.Name = "lblBookings"
        Me.lblBookings.Size = New System.Drawing.Size(51, 13)
        Me.lblBookings.TabIndex = 23
        Me.lblBookings.Text = "Bookings"
        '
        'dgvBookings
        '
        Me.dgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBookings.Location = New System.Drawing.Point(774, 289)
        Me.dgvBookings.Name = "dgvBookings"
        Me.dgvBookings.Size = New System.Drawing.Size(491, 349)
        Me.dgvBookings.TabIndex = 22
        '
        'pnlTotalBookings
        '
        Me.pnlTotalBookings.Controls.Add(Me.pbTotalBookingsIcon)
        Me.pnlTotalBookings.Controls.Add(Me.lblTotalBookingsContainer)
        Me.pnlTotalBookings.Controls.Add(Me.Label4)
        Me.pnlTotalBookings.Location = New System.Drawing.Point(517, 34)
        Me.pnlTotalBookings.Name = "pnlTotalBookings"
        Me.pnlTotalBookings.Size = New System.Drawing.Size(248, 100)
        Me.pnlTotalBookings.TabIndex = 20
        '
        'pbTotalBookingsIcon
        '
        Me.pbTotalBookingsIcon.Location = New System.Drawing.Point(3, 5)
        Me.pbTotalBookingsIcon.Name = "pbTotalBookingsIcon"
        Me.pbTotalBookingsIcon.Size = New System.Drawing.Size(90, 90)
        Me.pbTotalBookingsIcon.TabIndex = 2
        Me.pbTotalBookingsIcon.TabStop = False
        '
        'lblTotalBookingsContainer
        '
        Me.lblTotalBookingsContainer.AutoSize = True
        Me.lblTotalBookingsContainer.Location = New System.Drawing.Point(99, 27)
        Me.lblTotalBookingsContainer.Name = "lblTotalBookingsContainer"
        Me.lblTotalBookingsContainer.Size = New System.Drawing.Size(13, 13)
        Me.lblTotalBookingsContainer.TabIndex = 1
        Me.lblTotalBookingsContainer.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(99, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Total Bookings"
        '
        'pnlNumCustomers
        '
        Me.pnlNumCustomers.Controls.Add(Me.pbNumCustomersIcon)
        Me.pnlNumCustomers.Controls.Add(Me.lblNumCustomersContainer)
        Me.pnlNumCustomers.Controls.Add(Me.lblNumCustomers)
        Me.pnlNumCustomers.Location = New System.Drawing.Point(263, 34)
        Me.pnlNumCustomers.Name = "pnlNumCustomers"
        Me.pnlNumCustomers.Size = New System.Drawing.Size(248, 100)
        Me.pnlNumCustomers.TabIndex = 19
        '
        'pbNumCustomersIcon
        '
        Me.pbNumCustomersIcon.Location = New System.Drawing.Point(3, 5)
        Me.pbNumCustomersIcon.Name = "pbNumCustomersIcon"
        Me.pbNumCustomersIcon.Size = New System.Drawing.Size(90, 90)
        Me.pbNumCustomersIcon.TabIndex = 2
        Me.pbNumCustomersIcon.TabStop = False
        '
        'lblNumCustomersContainer
        '
        Me.lblNumCustomersContainer.AutoSize = True
        Me.lblNumCustomersContainer.Location = New System.Drawing.Point(99, 27)
        Me.lblNumCustomersContainer.Name = "lblNumCustomersContainer"
        Me.lblNumCustomersContainer.Size = New System.Drawing.Size(13, 13)
        Me.lblNumCustomersContainer.TabIndex = 1
        Me.lblNumCustomersContainer.Text = "0"
        '
        'lblNumCustomers
        '
        Me.lblNumCustomers.AutoSize = True
        Me.lblNumCustomers.Location = New System.Drawing.Point(99, 5)
        Me.lblNumCustomers.Name = "lblNumCustomers"
        Me.lblNumCustomers.Size = New System.Drawing.Size(83, 13)
        Me.lblNumCustomers.TabIndex = 0
        Me.lblNumCustomers.Text = "Total Customers"
        '
        'lblPopularPlaces
        '
        Me.lblPopularPlaces.AutoSize = True
        Me.lblPopularPlaces.Location = New System.Drawing.Point(263, 426)
        Me.lblPopularPlaces.Name = "lblPopularPlaces"
        Me.lblPopularPlaces.Size = New System.Drawing.Size(78, 13)
        Me.lblPopularPlaces.TabIndex = 18
        Me.lblPopularPlaces.Text = "Popular Places"
        '
        'lblReportType
        '
        Me.lblReportType.AutoSize = True
        Me.lblReportType.Location = New System.Drawing.Point(263, 401)
        Me.lblReportType.Name = "lblReportType"
        Me.lblReportType.Size = New System.Drawing.Size(66, 13)
        Me.lblReportType.TabIndex = 17
        Me.lblReportType.Text = "Report Type"
        '
        'lblReportBookings
        '
        Me.lblReportBookings.AutoSize = True
        Me.lblReportBookings.Location = New System.Drawing.Point(263, 148)
        Me.lblReportBookings.Name = "lblReportBookings"
        Me.lblReportBookings.Size = New System.Drawing.Size(86, 13)
        Me.lblReportBookings.TabIndex = 16
        Me.lblReportBookings.Text = "Report Bookings"
        '
        'btnGenerateReport
        '
        Me.btnGenerateReport.Location = New System.Drawing.Point(642, 396)
        Me.btnGenerateReport.Name = "btnGenerateReport"
        Me.btnGenerateReport.Size = New System.Drawing.Size(113, 23)
        Me.btnGenerateReport.TabIndex = 3
        Me.btnGenerateReport.Text = "Generate Report"
        Me.btnGenerateReport.UseVisualStyleBackColor = True
        '
        'cbReportType
        '
        Me.cbReportType.FormattingEnabled = True
        Me.cbReportType.Location = New System.Drawing.Point(335, 395)
        Me.cbReportType.Name = "cbReportType"
        Me.cbReportType.Size = New System.Drawing.Size(294, 21)
        Me.cbReportType.TabIndex = 2
        '
        'chartPopularPlaces
        '
        ChartArea2.Name = "ChartArea1"
        Me.chartPopularPlaces.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.chartPopularPlaces.Legends.Add(Legend2)
        Me.chartPopularPlaces.Location = New System.Drawing.Point(266, 442)
        Me.chartPopularPlaces.Name = "chartPopularPlaces"
        Me.chartPopularPlaces.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.chartPopularPlaces.Series.Add(Series2)
        Me.chartPopularPlaces.Size = New System.Drawing.Size(499, 196)
        Me.chartPopularPlaces.TabIndex = 1
        Me.chartPopularPlaces.Text = "Popular Places"
        '
        'mcBookings
        '
        Me.mcBookings.Location = New System.Drawing.Point(30, 32)
        Me.mcBookings.Name = "mcBookings"
        Me.mcBookings.TabIndex = 12
        '
        'dgvReportBookings
        '
        Me.dgvReportBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReportBookings.Location = New System.Drawing.Point(266, 164)
        Me.dgvReportBookings.Name = "dgvReportBookings"
        Me.dgvReportBookings.Size = New System.Drawing.Size(489, 225)
        Me.dgvReportBookings.TabIndex = 0
        '
        'tcAdminCenter
        '
        Me.tcAdminCenter.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.tcAdminCenter.Controls.Add(Me.tpSearchReports)
        Me.tcAdminCenter.Controls.Add(Me.tpBillingSettings)
        Me.tcAdminCenter.Controls.Add(Me.tpEventPlaceMgmt)
        Me.tcAdminCenter.Controls.Add(Me.tpCustomerRecords)
        Me.tcAdminCenter.Location = New System.Drawing.Point(12, 81)
        Me.tcAdminCenter.Multiline = True
        Me.tcAdminCenter.Name = "tcAdminCenter"
        Me.tcAdminCenter.SelectedIndex = 0
        Me.tcAdminCenter.Size = New System.Drawing.Size(1400, 678)
        Me.tcAdminCenter.TabIndex = 11
        '
        'tpCustomerRecords
        '
        Me.tpCustomerRecords.Location = New System.Drawing.Point(23, 4)
        Me.tpCustomerRecords.Name = "tpCustomerRecords"
        Me.tpCustomerRecords.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCustomerRecords.Size = New System.Drawing.Size(1373, 670)
        Me.tpCustomerRecords.TabIndex = 4
        Me.tpCustomerRecords.Text = "Customer Records"
        Me.tpCustomerRecords.UseVisualStyleBackColor = True
        '
        'btnLogOut
        '
        Me.btnLogOut.Location = New System.Drawing.Point(1352, 44)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(56, 23)
        Me.btnLogOut.TabIndex = 24
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'FormAdminCenter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1424, 771)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblRole)
        Me.Controls.Add(Me.btnEditInformation)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.pbAdmin)
        Me.Controls.Add(Me.tcAdminCenter)
        Me.Name = "FormAdminCenter"
        Me.Text = "FormAdminCenter"
        CType(Me.pbAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpBillingSettings.ResumeLayout(False)
        Me.tpBillingSettings.PerformLayout()
        CType(Me.nudPriceAdjust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvInvoices, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpEventPlaceMgmt.ResumeLayout(False)
        Me.tpEventPlaceMgmt.PerformLayout()
        CType(Me.dgvEventPlaces, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tpSearchReports.ResumeLayout(False)
        Me.tpSearchReports.PerformLayout()
        CType(Me.dgvAvailability, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chTotalStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBookings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTotalBookings.ResumeLayout(False)
        Me.pnlTotalBookings.PerformLayout()
        CType(Me.pbTotalBookingsIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlNumCustomers.ResumeLayout(False)
        Me.pnlNumCustomers.PerformLayout()
        CType(Me.pbNumCustomersIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chartPopularPlaces, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvReportBookings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcAdminCenter.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEditInformation As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents pbAdmin As PictureBox
    Friend WithEvents lblRole As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents tpBillingSettings As TabPage
    Friend WithEvents lblEventTypeSetting As Label
    Friend WithEvents lblPriceAdjust As Label
    Friend WithEvents lblInvoices As Label
    Friend WithEvents cbEventTypeSetting As ComboBox
    Friend WithEvents nudPriceAdjust As NumericUpDown
    Friend WithEvents btnAdjustPricing As Button
    Friend WithEvents btnProcessPayment As Button
    Friend WithEvents dgvInvoices As DataGridView
    Friend WithEvents tpEventPlaceMgmt As TabPage
    Friend WithEvents lblEventPlaces As Label
    Friend WithEvents dgvEventPlaces As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents txtPlaceID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEventType As TextBox
    Friend WithEvents lblEventType As Label
    Friend WithEvents txtEventPlace As TextBox
    Friend WithEvents lblVenueType As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCapacity As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtCapacity As TextBox
    Friend WithEvents tpSearchReports As TabPage
    Friend WithEvents lblAvailability As Label
    Friend WithEvents dgvAvailability As DataGridView
    Friend WithEvents btnUpdateBookings As Button
    Friend WithEvents btnReject As Button
    Friend WithEvents btnApprove As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents chTotalStatus As DataVisualization.Charting.Chart
    Friend WithEvents lblBookings As Label
    Friend WithEvents dgvBookings As DataGridView
    Friend WithEvents pnlTotalBookings As Panel
    Friend WithEvents pbTotalBookingsIcon As PictureBox
    Friend WithEvents lblTotalBookingsContainer As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents pnlNumCustomers As Panel
    Friend WithEvents pbNumCustomersIcon As PictureBox
    Friend WithEvents lblNumCustomersContainer As Label
    Friend WithEvents lblNumCustomers As Label
    Friend WithEvents lblPopularPlaces As Label
    Friend WithEvents lblReportType As Label
    Friend WithEvents lblReportBookings As Label
    Friend WithEvents btnGenerateReport As Button
    Friend WithEvents cbReportType As ComboBox
    Friend WithEvents chartPopularPlaces As DataVisualization.Charting.Chart
    Friend WithEvents mcBookings As MonthCalendar
    Friend WithEvents dgvReportBookings As DataGridView
    Friend WithEvents tcAdminCenter As TabControl
    Friend WithEvents btnLogOut As Button
    Friend WithEvents tpCustomerRecords As TabPage
End Class
