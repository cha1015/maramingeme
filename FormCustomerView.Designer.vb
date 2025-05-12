<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCustomerView
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
        Me.dgvBookingHistory = New System.Windows.Forms.DataGridView()
        Me.lblBookingHistory = New System.Windows.Forms.Label()
        Me.lblPaymentHistory = New System.Windows.Forms.Label()
        Me.lblPastBookings = New System.Windows.Forms.Label()
        Me.dgvPastBookings = New System.Windows.Forms.DataGridView()
        Me.tcCustomerView = New System.Windows.Forms.TabControl()
        Me.tpBookingHistory = New System.Windows.Forms.TabPage()
        Me.tpPaymentHistory = New System.Windows.Forms.TabPage()
        Me.tpPastBookings = New System.Windows.Forms.TabPage()
        Me.btnMain = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.btnEditInformation = New System.Windows.Forms.Button()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.tpDashboard = New System.Windows.Forms.TabPage()
        Me.lblCurrentBooking = New System.Windows.Forms.Label()
        Me.flpCurrentBooking = New System.Windows.Forms.FlowLayoutPanel()
        Me.dgvPaymentHistory = New System.Windows.Forms.DataGridView()
        Me.mcBookings = New System.Windows.Forms.MonthCalendar()
        CType(Me.dgvBookingHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPastBookings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcCustomerView.SuspendLayout()
        Me.tpBookingHistory.SuspendLayout()
        Me.tpPaymentHistory.SuspendLayout()
        Me.tpPastBookings.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpDashboard.SuspendLayout()
        CType(Me.dgvPaymentHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBookingHistory
        '
        Me.dgvBookingHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBookingHistory.Location = New System.Drawing.Point(6, 19)
        Me.dgvBookingHistory.Name = "dgvBookingHistory"
        Me.dgvBookingHistory.Size = New System.Drawing.Size(1016, 645)
        Me.dgvBookingHistory.TabIndex = 0
        '
        'lblBookingHistory
        '
        Me.lblBookingHistory.AutoSize = True
        Me.lblBookingHistory.Location = New System.Drawing.Point(6, 3)
        Me.lblBookingHistory.Name = "lblBookingHistory"
        Me.lblBookingHistory.Size = New System.Drawing.Size(81, 13)
        Me.lblBookingHistory.TabIndex = 4
        Me.lblBookingHistory.Text = "Booking History"
        '
        'lblPaymentHistory
        '
        Me.lblPaymentHistory.AutoSize = True
        Me.lblPaymentHistory.Location = New System.Drawing.Point(3, 3)
        Me.lblPaymentHistory.Name = "lblPaymentHistory"
        Me.lblPaymentHistory.Size = New System.Drawing.Size(83, 13)
        Me.lblPaymentHistory.TabIndex = 5
        Me.lblPaymentHistory.Text = "Payment History"
        '
        'lblPastBookings
        '
        Me.lblPastBookings.AutoSize = True
        Me.lblPastBookings.Location = New System.Drawing.Point(6, 3)
        Me.lblPastBookings.Name = "lblPastBookings"
        Me.lblPastBookings.Size = New System.Drawing.Size(75, 13)
        Me.lblPastBookings.TabIndex = 7
        Me.lblPastBookings.Text = "Past Bookings"
        '
        'dgvPastBookings
        '
        Me.dgvPastBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPastBookings.Location = New System.Drawing.Point(9, 19)
        Me.dgvPastBookings.Name = "dgvPastBookings"
        Me.dgvPastBookings.Size = New System.Drawing.Size(1016, 645)
        Me.dgvPastBookings.TabIndex = 6
        '
        'tcCustomerView
        '
        Me.tcCustomerView.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.tcCustomerView.Controls.Add(Me.tpDashboard)
        Me.tcCustomerView.Controls.Add(Me.tpBookingHistory)
        Me.tcCustomerView.Controls.Add(Me.tpPaymentHistory)
        Me.tcCustomerView.Controls.Add(Me.tpPastBookings)
        Me.tcCustomerView.Location = New System.Drawing.Point(12, 81)
        Me.tcCustomerView.Multiline = True
        Me.tcCustomerView.Name = "tcCustomerView"
        Me.tcCustomerView.SelectedIndex = 0
        Me.tcCustomerView.Size = New System.Drawing.Size(1400, 678)
        Me.tcCustomerView.TabIndex = 9
        '
        'tpBookingHistory
        '
        Me.tpBookingHistory.Controls.Add(Me.lblBookingHistory)
        Me.tpBookingHistory.Controls.Add(Me.dgvBookingHistory)
        Me.tpBookingHistory.Location = New System.Drawing.Point(23, 4)
        Me.tpBookingHistory.Name = "tpBookingHistory"
        Me.tpBookingHistory.Padding = New System.Windows.Forms.Padding(3)
        Me.tpBookingHistory.Size = New System.Drawing.Size(1373, 670)
        Me.tpBookingHistory.TabIndex = 0
        Me.tpBookingHistory.Text = "Booking History"
        Me.tpBookingHistory.UseVisualStyleBackColor = True
        '
        'tpPaymentHistory
        '
        Me.tpPaymentHistory.Controls.Add(Me.dgvPaymentHistory)
        Me.tpPaymentHistory.Controls.Add(Me.lblPaymentHistory)
        Me.tpPaymentHistory.Location = New System.Drawing.Point(23, 4)
        Me.tpPaymentHistory.Name = "tpPaymentHistory"
        Me.tpPaymentHistory.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPaymentHistory.Size = New System.Drawing.Size(1373, 670)
        Me.tpPaymentHistory.TabIndex = 1
        Me.tpPaymentHistory.Text = "Payment History"
        Me.tpPaymentHistory.UseVisualStyleBackColor = True
        '
        'tpPastBookings
        '
        Me.tpPastBookings.Controls.Add(Me.lblPastBookings)
        Me.tpPastBookings.Controls.Add(Me.dgvPastBookings)
        Me.tpPastBookings.Location = New System.Drawing.Point(23, 4)
        Me.tpPastBookings.Name = "tpPastBookings"
        Me.tpPastBookings.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPastBookings.Size = New System.Drawing.Size(1373, 670)
        Me.tpPastBookings.TabIndex = 2
        Me.tpPastBookings.Text = "PastBookings"
        Me.tpPastBookings.UseVisualStyleBackColor = True
        '
        'btnMain
        '
        Me.btnMain.Location = New System.Drawing.Point(32, 22)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Size = New System.Drawing.Size(104, 23)
        Me.btnMain.TabIndex = 10
        Me.btnMain.Text = "Back to Main Page"
        Me.btnMain.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.PictureBox1.Location = New System.Drawing.Point(1213, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(1279, 15)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(35, 13)
        Me.lblUsername.TabIndex = 16
        Me.lblUsername.Text = "Guest"
        '
        'btnEditInformation
        '
        Me.btnEditInformation.Location = New System.Drawing.Point(1282, 48)
        Me.btnEditInformation.Name = "btnEditInformation"
        Me.btnEditInformation.Size = New System.Drawing.Size(108, 23)
        Me.btnEditInformation.TabIndex = 17
        Me.btnEditInformation.Text = "Edit Information"
        Me.btnEditInformation.UseVisualStyleBackColor = True
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.Location = New System.Drawing.Point(1279, 32)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(29, 13)
        Me.lblRole.TabIndex = 22
        Me.lblRole.Text = "User"
        '
        'tpDashboard
        '
        Me.tpDashboard.Controls.Add(Me.mcBookings)
        Me.tpDashboard.Controls.Add(Me.flpCurrentBooking)
        Me.tpDashboard.Controls.Add(Me.lblCurrentBooking)
        Me.tpDashboard.Location = New System.Drawing.Point(23, 4)
        Me.tpDashboard.Name = "tpDashboard"
        Me.tpDashboard.Padding = New System.Windows.Forms.Padding(3)
        Me.tpDashboard.Size = New System.Drawing.Size(1373, 670)
        Me.tpDashboard.TabIndex = 3
        Me.tpDashboard.Text = "Dashboard"
        Me.tpDashboard.UseVisualStyleBackColor = True
        '
        'lblCurrentBooking
        '
        Me.lblCurrentBooking.AutoSize = True
        Me.lblCurrentBooking.Location = New System.Drawing.Point(18, 16)
        Me.lblCurrentBooking.Name = "lblCurrentBooking"
        Me.lblCurrentBooking.Size = New System.Drawing.Size(83, 13)
        Me.lblCurrentBooking.TabIndex = 9
        Me.lblCurrentBooking.Text = "Current Booking"
        '
        'flpCurrentBooking
        '
        Me.flpCurrentBooking.Location = New System.Drawing.Point(21, 43)
        Me.flpCurrentBooking.Name = "flpCurrentBooking"
        Me.flpCurrentBooking.Size = New System.Drawing.Size(1334, 202)
        Me.flpCurrentBooking.TabIndex = 10
        '
        'dgvPaymentHistory
        '
        Me.dgvPaymentHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPaymentHistory.Location = New System.Drawing.Point(6, 19)
        Me.dgvPaymentHistory.Name = "dgvPaymentHistory"
        Me.dgvPaymentHistory.Size = New System.Drawing.Size(1016, 645)
        Me.dgvPaymentHistory.TabIndex = 6
        '
        'mcBookings
        '
        Me.mcBookings.Location = New System.Drawing.Point(21, 257)
        Me.mcBookings.Name = "mcBookings"
        Me.mcBookings.TabIndex = 13
        '
        'FormCustomerView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1424, 771)
        Me.Controls.Add(Me.lblRole)
        Me.Controls.Add(Me.btnEditInformation)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnMain)
        Me.Controls.Add(Me.tcCustomerView)
        Me.Name = "FormCustomerView"
        Me.Text = "FormCustomerView"
        CType(Me.dgvBookingHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPastBookings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcCustomerView.ResumeLayout(False)
        Me.tpBookingHistory.ResumeLayout(False)
        Me.tpBookingHistory.PerformLayout()
        Me.tpPaymentHistory.ResumeLayout(False)
        Me.tpPaymentHistory.PerformLayout()
        Me.tpPastBookings.ResumeLayout(False)
        Me.tpPastBookings.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpDashboard.ResumeLayout(False)
        Me.tpDashboard.PerformLayout()
        CType(Me.dgvPaymentHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvBookingHistory As DataGridView
    Friend WithEvents lblBookingHistory As Label
    Friend WithEvents lblPaymentHistory As Label
    Friend WithEvents lblPastBookings As Label
    Friend WithEvents dgvPastBookings As DataGridView
    Friend WithEvents tcCustomerView As TabControl
    Friend WithEvents tpBookingHistory As TabPage
    Friend WithEvents tpPaymentHistory As TabPage
    Friend WithEvents tpPastBookings As TabPage
    Friend WithEvents btnMain As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents btnEditInformation As Button
    Friend WithEvents lblRole As Label
    Friend WithEvents tpDashboard As TabPage
    Friend WithEvents flpCurrentBooking As FlowLayoutPanel
    Friend WithEvents lblCurrentBooking As Label
    Friend WithEvents dgvPaymentHistory As DataGridView
    Friend WithEvents mcBookings As MonthCalendar
End Class
