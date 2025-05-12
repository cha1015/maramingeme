<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUpdateBooking
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
        Me.lblGuestCount = New System.Windows.Forms.Label()
        Me.lblEventType2 = New System.Windows.Forms.Label()
        Me.txtGuestCount = New System.Windows.Forms.TextBox()
        Me.lblEventPlace = New System.Windows.Forms.Label()
        Me.txtAdditionalCharges = New System.Windows.Forms.TextBox()
        Me.lblAdditionalCharges = New System.Windows.Forms.Label()
        Me.cbEventPlace = New System.Windows.Forms.ComboBox()
        Me.cbEventType = New System.Windows.Forms.ComboBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblBookingID = New System.Windows.Forms.Label()
        Me.lblBookingIDContainer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblGuestCount
        '
        Me.lblGuestCount.AutoSize = True
        Me.lblGuestCount.Location = New System.Drawing.Point(604, 390)
        Me.lblGuestCount.Name = "lblGuestCount"
        Me.lblGuestCount.Size = New System.Drawing.Size(66, 13)
        Me.lblGuestCount.TabIndex = 9
        Me.lblGuestCount.Text = "Guest Count"
        '
        'lblEventType2
        '
        Me.lblEventType2.AutoSize = True
        Me.lblEventType2.Location = New System.Drawing.Point(604, 361)
        Me.lblEventType2.Name = "lblEventType2"
        Me.lblEventType2.Size = New System.Drawing.Size(62, 13)
        Me.lblEventType2.TabIndex = 12
        Me.lblEventType2.Text = "Event Type"
        '
        'txtGuestCount
        '
        Me.txtGuestCount.Location = New System.Drawing.Point(720, 388)
        Me.txtGuestCount.Name = "txtGuestCount"
        Me.txtGuestCount.Size = New System.Drawing.Size(121, 20)
        Me.txtGuestCount.TabIndex = 5
        '
        'lblEventPlace
        '
        Me.lblEventPlace.AutoSize = True
        Me.lblEventPlace.Location = New System.Drawing.Point(604, 337)
        Me.lblEventPlace.Name = "lblEventPlace"
        Me.lblEventPlace.Size = New System.Drawing.Size(65, 13)
        Me.lblEventPlace.TabIndex = 11
        Me.lblEventPlace.Text = "Event Place"
        '
        'txtAdditionalCharges
        '
        Me.txtAdditionalCharges.Location = New System.Drawing.Point(720, 415)
        Me.txtAdditionalCharges.Name = "txtAdditionalCharges"
        Me.txtAdditionalCharges.Size = New System.Drawing.Size(121, 20)
        Me.txtAdditionalCharges.TabIndex = 6
        '
        'lblAdditionalCharges
        '
        Me.lblAdditionalCharges.AutoSize = True
        Me.lblAdditionalCharges.Location = New System.Drawing.Point(604, 417)
        Me.lblAdditionalCharges.Name = "lblAdditionalCharges"
        Me.lblAdditionalCharges.Size = New System.Drawing.Size(95, 13)
        Me.lblAdditionalCharges.TabIndex = 10
        Me.lblAdditionalCharges.Text = "Additional Charges"
        '
        'cbEventPlace
        '
        Me.cbEventPlace.FormattingEnabled = True
        Me.cbEventPlace.Location = New System.Drawing.Point(720, 334)
        Me.cbEventPlace.Name = "cbEventPlace"
        Me.cbEventPlace.Size = New System.Drawing.Size(121, 21)
        Me.cbEventPlace.TabIndex = 7
        '
        'cbEventType
        '
        Me.cbEventType.FormattingEnabled = True
        Me.cbEventType.Location = New System.Drawing.Point(720, 361)
        Me.cbEventType.Name = "cbEventType"
        Me.cbEventType.Size = New System.Drawing.Size(121, 21)
        Me.cbEventType.TabIndex = 8
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(776, 536)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 15
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(776, 565)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 16
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblBookingID
        '
        Me.lblBookingID.AutoSize = True
        Me.lblBookingID.Location = New System.Drawing.Point(604, 313)
        Me.lblBookingID.Name = "lblBookingID"
        Me.lblBookingID.Size = New System.Drawing.Size(60, 13)
        Me.lblBookingID.TabIndex = 17
        Me.lblBookingID.Text = "Booking ID"
        '
        'lblBookingIDContainer
        '
        Me.lblBookingIDContainer.AutoSize = True
        Me.lblBookingIDContainer.Location = New System.Drawing.Point(717, 313)
        Me.lblBookingIDContainer.Name = "lblBookingIDContainer"
        Me.lblBookingIDContainer.Size = New System.Drawing.Size(10, 13)
        Me.lblBookingIDContainer.TabIndex = 18
        Me.lblBookingIDContainer.Text = "-"
        '
        'FormUpdateBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1424, 771)
        Me.Controls.Add(Me.lblBookingIDContainer)
        Me.Controls.Add(Me.lblBookingID)
        Me.Controls.Add(Me.lblGuestCount)
        Me.Controls.Add(Me.lblEventType2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtGuestCount)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.lblEventPlace)
        Me.Controls.Add(Me.txtAdditionalCharges)
        Me.Controls.Add(Me.cbEventType)
        Me.Controls.Add(Me.lblAdditionalCharges)
        Me.Controls.Add(Me.cbEventPlace)
        Me.Name = "FormUpdateBooking"
        Me.Text = "FormUpdateBooking"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblGuestCount As Label
    Friend WithEvents lblEventType2 As Label
    Friend WithEvents txtGuestCount As TextBox
    Friend WithEvents lblEventPlace As Label
    Friend WithEvents txtAdditionalCharges As TextBox
    Friend WithEvents lblAdditionalCharges As Label
    Friend WithEvents cbEventPlace As ComboBox
    Friend WithEvents cbEventType As ComboBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblBookingID As Label
    Friend WithEvents lblBookingIDContainer As Label
End Class
