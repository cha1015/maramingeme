<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBooking
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.dtpBirthday = New System.Windows.Forms.DateTimePicker()
        Me.cmbSex = New System.Windows.Forms.ComboBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblBirthday = New System.Windows.Forms.Label()
        Me.lblSex = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.gbCustomerInformation = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblFeatures = New System.Windows.Forms.Label()
        Me.txtCapacity = New System.Windows.Forms.TextBox()
        Me.txtFeatures = New System.Windows.Forms.TextBox()
        Me.txtPlaceID = New System.Windows.Forms.TextBox()
        Me.lblPricePerDay = New System.Windows.Forms.Label()
        Me.txtVenueName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPricePerDay = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnBook = New System.Windows.Forms.Button()
        Me.chkVideoke = New System.Windows.Forms.CheckBox()
        Me.chkDancer = New System.Windows.Forms.CheckBox()
        Me.chkSinger = New System.Windows.Forms.CheckBox()
        Me.chkClown = New System.Windows.Forms.CheckBox()
        Me.chkCatering = New System.Windows.Forms.CheckBox()
        Me.dtpEventDate = New System.Windows.Forms.DateTimePicker()
        Me.txtNumGuests = New System.Windows.Forms.TextBox()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.lblServicesAvailed = New System.Windows.Forms.Label()
        Me.lblEventDate = New System.Windows.Forms.Label()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.gbCustomerInformation.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(106, 19)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(226, 20)
        Me.txtCustomerName.TabIndex = 0
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(106, 71)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.ReadOnly = True
        Me.txtAge.Size = New System.Drawing.Size(226, 20)
        Me.txtAge.TabIndex = 1
        '
        'dtpBirthday
        '
        Me.dtpBirthday.Location = New System.Drawing.Point(106, 45)
        Me.dtpBirthday.Name = "dtpBirthday"
        Me.dtpBirthday.Size = New System.Drawing.Size(226, 20)
        Me.dtpBirthday.TabIndex = 4
        '
        'cmbSex
        '
        Me.cmbSex.FormattingEnabled = True
        Me.cmbSex.Items.AddRange(New Object() {"Male", "Female", "Non-Binary", "Other", "Prefer Not to Say"})
        Me.cmbSex.Location = New System.Drawing.Point(106, 97)
        Me.cmbSex.Name = "cmbSex"
        Me.cmbSex.Size = New System.Drawing.Size(226, 21)
        Me.cmbSex.TabIndex = 5
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(106, 124)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(226, 20)
        Me.txtAddress.TabIndex = 6
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(8, 19)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 8
        Me.lblName.Text = "Name"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(8, 75)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(26, 13)
        Me.lblAge.TabIndex = 9
        Me.lblAge.Text = "Age"
        '
        'lblBirthday
        '
        Me.lblBirthday.AutoSize = True
        Me.lblBirthday.Location = New System.Drawing.Point(8, 47)
        Me.lblBirthday.Name = "lblBirthday"
        Me.lblBirthday.Size = New System.Drawing.Size(45, 13)
        Me.lblBirthday.TabIndex = 10
        Me.lblBirthday.Text = "Birthday"
        '
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.lblSex.Location = New System.Drawing.Point(8, 103)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(25, 13)
        Me.lblSex.TabIndex = 11
        Me.lblSex.Text = "Sex"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(8, 131)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(45, 13)
        Me.lblAddress.TabIndex = 12
        Me.lblAddress.Text = "Address"
        '
        'gbCustomerInformation
        '
        Me.gbCustomerInformation.Controls.Add(Me.txtCustomerName)
        Me.gbCustomerInformation.Controls.Add(Me.lblAddress)
        Me.gbCustomerInformation.Controls.Add(Me.txtAge)
        Me.gbCustomerInformation.Controls.Add(Me.lblSex)
        Me.gbCustomerInformation.Controls.Add(Me.lblBirthday)
        Me.gbCustomerInformation.Controls.Add(Me.dtpBirthday)
        Me.gbCustomerInformation.Controls.Add(Me.cmbSex)
        Me.gbCustomerInformation.Controls.Add(Me.lblAge)
        Me.gbCustomerInformation.Controls.Add(Me.txtAddress)
        Me.gbCustomerInformation.Controls.Add(Me.lblName)
        Me.gbCustomerInformation.Location = New System.Drawing.Point(1050, 182)
        Me.gbCustomerInformation.Name = "gbCustomerInformation"
        Me.gbCustomerInformation.Size = New System.Drawing.Size(342, 164)
        Me.gbCustomerInformation.TabIndex = 13
        Me.gbCustomerInformation.TabStop = False
        Me.gbCustomerInformation.Text = "Customer Information"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblFeatures)
        Me.GroupBox1.Controls.Add(Me.txtCapacity)
        Me.GroupBox1.Controls.Add(Me.txtFeatures)
        Me.GroupBox1.Controls.Add(Me.txtPlaceID)
        Me.GroupBox1.Controls.Add(Me.lblPricePerDay)
        Me.GroupBox1.Controls.Add(Me.txtVenueName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtPricePerDay)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(60, 279)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(342, 164)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Event Place Details"
        '
        'lblFeatures
        '
        Me.lblFeatures.AutoSize = True
        Me.lblFeatures.Location = New System.Drawing.Point(8, 103)
        Me.lblFeatures.Name = "lblFeatures"
        Me.lblFeatures.Size = New System.Drawing.Size(48, 13)
        Me.lblFeatures.TabIndex = 15
        Me.lblFeatures.Text = "Features"
        '
        'txtCapacity
        '
        Me.txtCapacity.Location = New System.Drawing.Point(106, 73)
        Me.txtCapacity.Name = "txtCapacity"
        Me.txtCapacity.ReadOnly = True
        Me.txtCapacity.Size = New System.Drawing.Size(226, 20)
        Me.txtCapacity.TabIndex = 13
        '
        'txtFeatures
        '
        Me.txtFeatures.Location = New System.Drawing.Point(106, 100)
        Me.txtFeatures.Name = "txtFeatures"
        Me.txtFeatures.ReadOnly = True
        Me.txtFeatures.Size = New System.Drawing.Size(226, 20)
        Me.txtFeatures.TabIndex = 14
        '
        'txtPlaceID
        '
        Me.txtPlaceID.Location = New System.Drawing.Point(106, 19)
        Me.txtPlaceID.Name = "txtPlaceID"
        Me.txtPlaceID.ReadOnly = True
        Me.txtPlaceID.Size = New System.Drawing.Size(226, 20)
        Me.txtPlaceID.TabIndex = 0
        '
        'lblPricePerDay
        '
        Me.lblPricePerDay.AutoSize = True
        Me.lblPricePerDay.Location = New System.Drawing.Point(8, 131)
        Me.lblPricePerDay.Name = "lblPricePerDay"
        Me.lblPricePerDay.Size = New System.Drawing.Size(71, 13)
        Me.lblPricePerDay.TabIndex = 12
        Me.lblPricePerDay.Text = "Price per Day"
        '
        'txtVenueName
        '
        Me.txtVenueName.Location = New System.Drawing.Point(106, 46)
        Me.txtVenueName.Name = "txtVenueName"
        Me.txtVenueName.ReadOnly = True
        Me.txtVenueName.Size = New System.Drawing.Size(226, 20)
        Me.txtVenueName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Capacity"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Venue Name"
        '
        'txtPricePerDay
        '
        Me.txtPricePerDay.Location = New System.Drawing.Point(106, 127)
        Me.txtPricePerDay.Name = "txtPricePerDay"
        Me.txtPricePerDay.ReadOnly = True
        Me.txtPricePerDay.Size = New System.Drawing.Size(226, 20)
        Me.txtPricePerDay.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Place ID"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnBook)
        Me.GroupBox2.Controls.Add(Me.chkVideoke)
        Me.GroupBox2.Controls.Add(Me.chkDancer)
        Me.GroupBox2.Controls.Add(Me.chkSinger)
        Me.GroupBox2.Controls.Add(Me.chkClown)
        Me.GroupBox2.Controls.Add(Me.chkCatering)
        Me.GroupBox2.Controls.Add(Me.dtpEventDate)
        Me.GroupBox2.Controls.Add(Me.txtNumGuests)
        Me.GroupBox2.Controls.Add(Me.lblTotalPrice)
        Me.GroupBox2.Controls.Add(Me.lblServicesAvailed)
        Me.GroupBox2.Controls.Add(Me.lblEventDate)
        Me.GroupBox2.Controls.Add(Me.txtTotalPrice)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(1050, 356)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(342, 233)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Booking Details"
        '
        'btnBook
        '
        Me.btnBook.Location = New System.Drawing.Point(222, 199)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.Size = New System.Drawing.Size(110, 23)
        Me.btnBook.TabIndex = 20
        Me.btnBook.Text = "Book Now"
        Me.btnBook.UseVisualStyleBackColor = True
        '
        'chkVideoke
        '
        Me.chkVideoke.AutoSize = True
        Me.chkVideoke.Location = New System.Drawing.Point(222, 97)
        Me.chkVideoke.Name = "chkVideoke"
        Me.chkVideoke.Size = New System.Drawing.Size(65, 17)
        Me.chkVideoke.TabIndex = 18
        Me.chkVideoke.Text = "Videoke"
        Me.chkVideoke.UseVisualStyleBackColor = True
        '
        'chkDancer
        '
        Me.chkDancer.AutoSize = True
        Me.chkDancer.Location = New System.Drawing.Point(222, 76)
        Me.chkDancer.Name = "chkDancer"
        Me.chkDancer.Size = New System.Drawing.Size(61, 17)
        Me.chkDancer.TabIndex = 17
        Me.chkDancer.Text = "Dancer"
        Me.chkDancer.UseVisualStyleBackColor = True
        '
        'chkSinger
        '
        Me.chkSinger.AutoSize = True
        Me.chkSinger.Location = New System.Drawing.Point(106, 120)
        Me.chkSinger.Name = "chkSinger"
        Me.chkSinger.Size = New System.Drawing.Size(56, 17)
        Me.chkSinger.TabIndex = 16
        Me.chkSinger.Text = "Singer"
        Me.chkSinger.UseVisualStyleBackColor = True
        '
        'chkClown
        '
        Me.chkClown.AutoSize = True
        Me.chkClown.Location = New System.Drawing.Point(106, 97)
        Me.chkClown.Name = "chkClown"
        Me.chkClown.Size = New System.Drawing.Size(55, 17)
        Me.chkClown.TabIndex = 15
        Me.chkClown.Text = "Clown"
        Me.chkClown.UseVisualStyleBackColor = True
        '
        'chkCatering
        '
        Me.chkCatering.AutoSize = True
        Me.chkCatering.Location = New System.Drawing.Point(106, 75)
        Me.chkCatering.Name = "chkCatering"
        Me.chkCatering.Size = New System.Drawing.Size(65, 17)
        Me.chkCatering.TabIndex = 14
        Me.chkCatering.Text = "Catering"
        Me.chkCatering.UseVisualStyleBackColor = True
        '
        'dtpEventDate
        '
        Me.dtpEventDate.Location = New System.Drawing.Point(106, 45)
        Me.dtpEventDate.Name = "dtpEventDate"
        Me.dtpEventDate.Size = New System.Drawing.Size(226, 20)
        Me.dtpEventDate.TabIndex = 13
        '
        'txtNumGuests
        '
        Me.txtNumGuests.Location = New System.Drawing.Point(106, 19)
        Me.txtNumGuests.Name = "txtNumGuests"
        Me.txtNumGuests.Size = New System.Drawing.Size(226, 20)
        Me.txtNumGuests.TabIndex = 0
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.AutoSize = True
        Me.lblTotalPrice.Location = New System.Drawing.Point(8, 147)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(58, 13)
        Me.lblTotalPrice.TabIndex = 12
        Me.lblTotalPrice.Text = "Total Price"
        '
        'lblServicesAvailed
        '
        Me.lblServicesAvailed.AutoSize = True
        Me.lblServicesAvailed.Location = New System.Drawing.Point(8, 75)
        Me.lblServicesAvailed.Name = "lblServicesAvailed"
        Me.lblServicesAvailed.Size = New System.Drawing.Size(86, 13)
        Me.lblServicesAvailed.TabIndex = 11
        Me.lblServicesAvailed.Text = "Services Availed"
        '
        'lblEventDate
        '
        Me.lblEventDate.AutoSize = True
        Me.lblEventDate.Location = New System.Drawing.Point(8, 47)
        Me.lblEventDate.Name = "lblEventDate"
        Me.lblEventDate.Size = New System.Drawing.Size(61, 13)
        Me.lblEventDate.TabIndex = 9
        Me.lblEventDate.Text = "Event Date"
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Location = New System.Drawing.Point(106, 143)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.ReadOnly = True
        Me.txtTotalPrice.Size = New System.Drawing.Size(226, 20)
        Me.txtTotalPrice.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Number of Guests"
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
        'FormBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1424, 771)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbCustomerInformation)
        Me.Name = "FormBooking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormBooking"
        Me.gbCustomerInformation.ResumeLayout(False)
        Me.gbCustomerInformation.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents dtpBirthday As DateTimePicker
    Friend WithEvents cmbSex As ComboBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblBirthday As Label
    Friend WithEvents lblSex As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents gbCustomerInformation As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtPlaceID As TextBox
    Friend WithEvents lblPricePerDay As Label
    Friend WithEvents txtVenueName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPricePerDay As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblFeatures As Label
    Friend WithEvents txtCapacity As TextBox
    Friend WithEvents txtFeatures As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dtpEventDate As DateTimePicker
    Friend WithEvents txtNumGuests As TextBox
    Friend WithEvents lblTotalPrice As Label
    Friend WithEvents lblServicesAvailed As Label
    Friend WithEvents lblEventDate As Label
    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnBook As Button
    Friend WithEvents chkVideoke As CheckBox
    Friend WithEvents chkDancer As CheckBox
    Friend WithEvents chkSinger As CheckBox
    Friend WithEvents chkClown As CheckBox
    Friend WithEvents chkCatering As CheckBox
    Friend WithEvents btnBack As Button
    Friend WithEvents btnNext As Button
End Class
