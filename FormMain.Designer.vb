<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
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
        Me.btnApply = New System.Windows.Forms.Button()
        Me.lblCapacity = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.pnlFilter = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cbAvailableOn = New System.Windows.Forms.ComboBox()
        Me.lblAvailability = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblSortDirection = New System.Windows.Forms.Label()
        Me.cbSortDirection = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblSortBy = New System.Windows.Forms.Label()
        Me.cbSort = New System.Windows.Forms.ComboBox()
        Me.pnlPrice = New System.Windows.Forms.Panel()
        Me.txtMinPrice = New System.Windows.Forms.TextBox()
        Me.txtMaxPrice = New System.Windows.Forms.TextBox()
        Me.pnlCapacity = New System.Windows.Forms.Panel()
        Me.txtMinCapacity = New System.Windows.Forms.TextBox()
        Me.txtMaxCapacity = New System.Windows.Forms.TextBox()
        Me.pnlEventType = New System.Windows.Forms.Panel()
        Me.clbEventType = New System.Windows.Forms.CheckedListBox()
        Me.flpResults = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnCustomerView = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.pbProfile = New System.Windows.Forms.PictureBox()
        Me.pnlAccount = New System.Windows.Forms.Panel()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.btnSignUp = New System.Windows.Forms.Button()
        Me.pnlSignUpLogIn = New System.Windows.Forms.Panel()
        Me.pnlFilter.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlPrice.SuspendLayout()
        Me.pnlCapacity.SuspendLayout()
        Me.pnlEventType.SuspendLayout()
        CType(Me.pbProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAccount.SuspendLayout()
        Me.pnlSignUpLogIn.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(204, 629)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(99, 33)
        Me.btnApply.TabIndex = 17
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'lblCapacity
        '
        Me.lblCapacity.AutoSize = True
        Me.lblCapacity.Location = New System.Drawing.Point(17, 9)
        Me.lblCapacity.Name = "lblCapacity"
        Me.lblCapacity.Size = New System.Drawing.Size(48, 13)
        Me.lblCapacity.TabIndex = 7
        Me.lblCapacity.Text = "Capacity"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Type of Event"
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Location = New System.Drawing.Point(17, 9)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(31, 13)
        Me.lblLocation.TabIndex = 3
        Me.lblLocation.Text = "Price"
        '
        'pnlFilter
        '
        Me.pnlFilter.Controls.Add(Me.Panel3)
        Me.pnlFilter.Controls.Add(Me.Panel2)
        Me.pnlFilter.Controls.Add(Me.Panel1)
        Me.pnlFilter.Controls.Add(Me.pnlPrice)
        Me.pnlFilter.Controls.Add(Me.pnlCapacity)
        Me.pnlFilter.Controls.Add(Me.pnlEventType)
        Me.pnlFilter.Controls.Add(Me.btnApply)
        Me.pnlFilter.Location = New System.Drawing.Point(1092, 82)
        Me.pnlFilter.Name = "pnlFilter"
        Me.pnlFilter.Size = New System.Drawing.Size(324, 681)
        Me.pnlFilter.TabIndex = 15
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.cbAvailableOn)
        Me.Panel3.Controls.Add(Me.lblAvailability)
        Me.Panel3.Location = New System.Drawing.Point(25, 378)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(278, 54)
        Me.Panel3.TabIndex = 30
        '
        'cbAvailableOn
        '
        Me.cbAvailableOn.FormattingEnabled = True
        Me.cbAvailableOn.Items.AddRange(New Object() {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"})
        Me.cbAvailableOn.Location = New System.Drawing.Point(20, 26)
        Me.cbAvailableOn.Name = "cbAvailableOn"
        Me.cbAvailableOn.Size = New System.Drawing.Size(241, 21)
        Me.cbAvailableOn.TabIndex = 8
        '
        'lblAvailability
        '
        Me.lblAvailability.AutoSize = True
        Me.lblAvailability.Location = New System.Drawing.Point(17, 9)
        Me.lblAvailability.Name = "lblAvailability"
        Me.lblAvailability.Size = New System.Drawing.Size(65, 13)
        Me.lblAvailability.TabIndex = 7
        Me.lblAvailability.Text = "Available on"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblSortDirection)
        Me.Panel2.Controls.Add(Me.cbSortDirection)
        Me.Panel2.Location = New System.Drawing.Point(189, 558)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(114, 65)
        Me.Panel2.TabIndex = 32
        '
        'lblSortDirection
        '
        Me.lblSortDirection.AutoSize = True
        Me.lblSortDirection.Location = New System.Drawing.Point(17, 6)
        Me.lblSortDirection.Name = "lblSortDirection"
        Me.lblSortDirection.Size = New System.Drawing.Size(69, 13)
        Me.lblSortDirection.TabIndex = 29
        Me.lblSortDirection.Text = "Sort direction"
        '
        'cbSortDirection
        '
        Me.cbSortDirection.FormattingEnabled = True
        Me.cbSortDirection.Items.AddRange(New Object() {"Least to Greatest", "Greatest to Least"})
        Me.cbSortDirection.Location = New System.Drawing.Point(20, 22)
        Me.cbSortDirection.Name = "cbSortDirection"
        Me.cbSortDirection.Size = New System.Drawing.Size(77, 21)
        Me.cbSortDirection.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblSortBy)
        Me.Panel1.Controls.Add(Me.cbSort)
        Me.Panel1.Location = New System.Drawing.Point(25, 558)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(158, 65)
        Me.Panel1.TabIndex = 31
        '
        'lblSortBy
        '
        Me.lblSortBy.AutoSize = True
        Me.lblSortBy.Location = New System.Drawing.Point(17, 6)
        Me.lblSortBy.Name = "lblSortBy"
        Me.lblSortBy.Size = New System.Drawing.Size(40, 13)
        Me.lblSortBy.TabIndex = 29
        Me.lblSortBy.Text = "Sort by"
        '
        'cbSort
        '
        Me.cbSort.FormattingEnabled = True
        Me.cbSort.Items.AddRange(New Object() {"Alphabetical", "Capacity", "Price"})
        Me.cbSort.Location = New System.Drawing.Point(20, 22)
        Me.cbSort.Name = "cbSort"
        Me.cbSort.Size = New System.Drawing.Size(127, 21)
        Me.cbSort.TabIndex = 0
        '
        'pnlPrice
        '
        Me.pnlPrice.Controls.Add(Me.lblLocation)
        Me.pnlPrice.Controls.Add(Me.txtMinPrice)
        Me.pnlPrice.Controls.Add(Me.txtMaxPrice)
        Me.pnlPrice.Location = New System.Drawing.Point(25, 498)
        Me.pnlPrice.Name = "pnlPrice"
        Me.pnlPrice.Size = New System.Drawing.Size(278, 54)
        Me.pnlPrice.TabIndex = 30
        '
        'txtMinPrice
        '
        Me.txtMinPrice.Location = New System.Drawing.Point(20, 25)
        Me.txtMinPrice.Name = "txtMinPrice"
        Me.txtMinPrice.Size = New System.Drawing.Size(74, 20)
        Me.txtMinPrice.TabIndex = 27
        Me.txtMinPrice.Text = "Min"
        '
        'txtMaxPrice
        '
        Me.txtMaxPrice.Location = New System.Drawing.Point(187, 25)
        Me.txtMaxPrice.Name = "txtMaxPrice"
        Me.txtMaxPrice.Size = New System.Drawing.Size(74, 20)
        Me.txtMaxPrice.TabIndex = 28
        Me.txtMaxPrice.Text = "Max"
        '
        'pnlCapacity
        '
        Me.pnlCapacity.Controls.Add(Me.lblCapacity)
        Me.pnlCapacity.Controls.Add(Me.txtMinCapacity)
        Me.pnlCapacity.Controls.Add(Me.txtMaxCapacity)
        Me.pnlCapacity.Location = New System.Drawing.Point(25, 438)
        Me.pnlCapacity.Name = "pnlCapacity"
        Me.pnlCapacity.Size = New System.Drawing.Size(278, 54)
        Me.pnlCapacity.TabIndex = 29
        '
        'txtMinCapacity
        '
        Me.txtMinCapacity.Location = New System.Drawing.Point(20, 25)
        Me.txtMinCapacity.Name = "txtMinCapacity"
        Me.txtMinCapacity.Size = New System.Drawing.Size(74, 20)
        Me.txtMinCapacity.TabIndex = 24
        Me.txtMinCapacity.Text = "Min"
        '
        'txtMaxCapacity
        '
        Me.txtMaxCapacity.Location = New System.Drawing.Point(187, 25)
        Me.txtMaxCapacity.Name = "txtMaxCapacity"
        Me.txtMaxCapacity.Size = New System.Drawing.Size(74, 20)
        Me.txtMaxCapacity.TabIndex = 25
        Me.txtMaxCapacity.Text = "Max"
        '
        'pnlEventType
        '
        Me.pnlEventType.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlEventType.Controls.Add(Me.clbEventType)
        Me.pnlEventType.Controls.Add(Me.Label2)
        Me.pnlEventType.Location = New System.Drawing.Point(22, 19)
        Me.pnlEventType.Name = "pnlEventType"
        Me.pnlEventType.Size = New System.Drawing.Size(281, 353)
        Me.pnlEventType.TabIndex = 22
        '
        'clbEventType
        '
        Me.clbEventType.FormattingEnabled = True
        Me.clbEventType.Items.AddRange(New Object() {"Classes & Workshops", "    Coffee Workshop", "    Cooking", "    Fitness", "    Tea Workshop", "Corporate Event", "    Dining", "    Party", "Formal Meetings & Team Gatherings", "    Conference", "    Interview", "    Sales Meeting", "    Team Meeting", "        Offsite Meeting", "        Team Bonding", "        Training", "Parties & Celebrations", "    Anniversary", "    Baby Shower", "    Birthday Party", "    Holiday & Festive Celebrations", "        Deepavali", "        Hari Raya", "        Year-End Party", "    Graduation Party", "    Dinner & Dance", "    Lunch/Dinner", "    Prom", "Shoots & Productions", "    Green Screen Shoot", "    Live Stream", "    Live Webinar", "    Photo Shoot", "    Video Production", "Weddings & Related Events", "    Bachelor/Bachelorette Party", "    Bridal Shower", "    Ceremony", "    Engagement", "    Proposal", "    Reception", "    Solemnization", "    Wedding"})
        Me.clbEventType.Location = New System.Drawing.Point(3, 16)
        Me.clbEventType.Name = "clbEventType"
        Me.clbEventType.Size = New System.Drawing.Size(275, 334)
        Me.clbEventType.TabIndex = 0
        '
        'flpResults
        '
        Me.flpResults.AutoScroll = True
        Me.flpResults.Location = New System.Drawing.Point(23, 82)
        Me.flpResults.Name = "flpResults"
        Me.flpResults.Size = New System.Drawing.Size(1063, 681)
        Me.flpResults.TabIndex = 18
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(60, 25)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(31, 33)
        Me.btnNext.TabIndex = 32
        Me.btnNext.Text = "→"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(23, 25)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(31, 33)
        Me.btnBack.TabIndex = 31
        Me.btnBack.Text = "←"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnCustomerView
        '
        Me.btnCustomerView.Location = New System.Drawing.Point(222, 9)
        Me.btnCustomerView.Name = "btnCustomerView"
        Me.btnCustomerView.Size = New System.Drawing.Size(99, 25)
        Me.btnCustomerView.TabIndex = 2
        Me.btnCustomerView.Text = "My Account"
        Me.btnCustomerView.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(97, 30)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(884, 20)
        Me.txtSearch.TabIndex = 34
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(987, 27)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(99, 33)
        Me.btnSearch.TabIndex = 35
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnLogOut
        '
        Me.btnLogOut.Location = New System.Drawing.Point(222, 34)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(99, 23)
        Me.btnLogOut.TabIndex = 40
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(69, 29)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(29, 13)
        Me.lblUser.TabIndex = 39
        Me.lblUser.Text = "User"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(69, 8)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(55, 13)
        Me.lblUsername.TabIndex = 37
        Me.lblUsername.Text = "Username"
        '
        'pbProfile
        '
        Me.pbProfile.BackColor = System.Drawing.Color.Gainsboro
        Me.pbProfile.Location = New System.Drawing.Point(3, 8)
        Me.pbProfile.Name = "pbProfile"
        Me.pbProfile.Size = New System.Drawing.Size(60, 60)
        Me.pbProfile.TabIndex = 36
        Me.pbProfile.TabStop = False
        '
        'pnlAccount
        '
        Me.pnlAccount.Controls.Add(Me.pbProfile)
        Me.pnlAccount.Controls.Add(Me.btnLogOut)
        Me.pnlAccount.Controls.Add(Me.lblUsername)
        Me.pnlAccount.Controls.Add(Me.lblUser)
        Me.pnlAccount.Controls.Add(Me.btnCustomerView)
        Me.pnlAccount.Location = New System.Drawing.Point(1092, 5)
        Me.pnlAccount.Name = "pnlAccount"
        Me.pnlAccount.Size = New System.Drawing.Size(324, 74)
        Me.pnlAccount.TabIndex = 41
        '
        'btnLogIn
        '
        Me.btnLogIn.Location = New System.Drawing.Point(3, 31)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(99, 24)
        Me.btnLogIn.TabIndex = 1
        Me.btnLogIn.Text = "Log In"
        Me.btnLogIn.UseVisualStyleBackColor = True
        '
        'btnSignUp
        '
        Me.btnSignUp.Location = New System.Drawing.Point(3, 3)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(99, 24)
        Me.btnSignUp.TabIndex = 0
        Me.btnSignUp.Text = "Sign Up"
        Me.btnSignUp.UseVisualStyleBackColor = True
        '
        'pnlSignUpLogIn
        '
        Me.pnlSignUpLogIn.Controls.Add(Me.btnSignUp)
        Me.pnlSignUpLogIn.Controls.Add(Me.btnLogIn)
        Me.pnlSignUpLogIn.Location = New System.Drawing.Point(983, 5)
        Me.pnlSignUpLogIn.Name = "pnlSignUpLogIn"
        Me.pnlSignUpLogIn.Size = New System.Drawing.Size(103, 68)
        Me.pnlSignUpLogIn.TabIndex = 42
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1424, 771)
        Me.Controls.Add(Me.pnlSignUpLogIn)
        Me.Controls.Add(Me.pnlAccount)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.flpResults)
        Me.Controls.Add(Me.pnlFilter)
        Me.Name = "FormMain"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.pnlFilter.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlPrice.ResumeLayout(False)
        Me.pnlPrice.PerformLayout()
        Me.pnlCapacity.ResumeLayout(False)
        Me.pnlCapacity.PerformLayout()
        Me.pnlEventType.ResumeLayout(False)
        Me.pnlEventType.PerformLayout()
        CType(Me.pbProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAccount.ResumeLayout(False)
        Me.pnlAccount.PerformLayout()
        Me.pnlSignUpLogIn.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnApply As Button
    Friend WithEvents lblCapacity As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblLocation As Label
    Friend WithEvents pnlFilter As Panel
    Friend WithEvents flpResults As FlowLayoutPanel
    Friend WithEvents btnNext As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents pnlEventType As Panel
    Friend WithEvents clbEventType As CheckedListBox
    Friend WithEvents txtMaxCapacity As TextBox
    Friend WithEvents txtMinCapacity As TextBox
    Friend WithEvents txtMaxPrice As TextBox
    Friend WithEvents txtMinPrice As TextBox
    Friend WithEvents btnCustomerView As Button
    Friend WithEvents pnlPrice As Panel
    Friend WithEvents pnlCapacity As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblSortDirection As Label
    Friend WithEvents cbSortDirection As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblSortBy As Label
    Friend WithEvents cbSort As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cbAvailableOn As ComboBox
    Friend WithEvents lblAvailability As Label
    Friend WithEvents btnLogOut As Button
    Friend WithEvents lblUser As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents pbProfile As PictureBox
    Friend WithEvents pnlAccount As Panel
    Friend WithEvents btnLogIn As Button
    Friend WithEvents btnSignUp As Button
    Friend WithEvents pnlSignUpLogIn As Panel
End Class
