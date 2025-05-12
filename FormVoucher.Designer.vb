<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVoucher
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
        Me.pnlFirstTime = New System.Windows.Forms.Panel()
        Me.btnSelectFirstTime = New System.Windows.Forms.Button()
        Me.lblFirstTime = New System.Windows.Forms.Label()
        Me.pbFirstTime = New System.Windows.Forms.PictureBox()
        Me.pnlSenior = New System.Windows.Forms.Panel()
        Me.btnSelectSenior = New System.Windows.Forms.Button()
        Me.lblSenior = New System.Windows.Forms.Label()
        Me.pbSenior = New System.Windows.Forms.PictureBox()
        Me.pnlReferral = New System.Windows.Forms.Panel()
        Me.lblEnterReferralCode = New System.Windows.Forms.Label()
        Me.txtReferralCode = New System.Windows.Forms.TextBox()
        Me.btnSelectReferral = New System.Windows.Forms.Button()
        Me.lblReferral = New System.Windows.Forms.Label()
        Me.pbReferral = New System.Windows.Forms.PictureBox()
        Me.pnlBirthday = New System.Windows.Forms.Panel()
        Me.btnSelectBirthday = New System.Windows.Forms.Button()
        Me.lblBirthday = New System.Windows.Forms.Label()
        Me.pbBirthday = New System.Windows.Forms.PictureBox()
        Me.pnlLoyalty = New System.Windows.Forms.Panel()
        Me.btnSelectLoyalty = New System.Windows.Forms.Button()
        Me.lblLoyalty = New System.Windows.Forms.Label()
        Me.pbLoyalty = New System.Windows.Forms.PictureBox()
        Me.btnApplyVoucher = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.pnlFirstTime.SuspendLayout()
        CType(Me.pbFirstTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSenior.SuspendLayout()
        CType(Me.pbSenior, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlReferral.SuspendLayout()
        CType(Me.pbReferral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBirthday.SuspendLayout()
        CType(Me.pbBirthday, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLoyalty.SuspendLayout()
        CType(Me.pbLoyalty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlFirstTime
        '
        Me.pnlFirstTime.Controls.Add(Me.btnSelectFirstTime)
        Me.pnlFirstTime.Controls.Add(Me.lblFirstTime)
        Me.pnlFirstTime.Controls.Add(Me.pbFirstTime)
        Me.pnlFirstTime.Location = New System.Drawing.Point(223, 166)
        Me.pnlFirstTime.Name = "pnlFirstTime"
        Me.pnlFirstTime.Size = New System.Drawing.Size(486, 142)
        Me.pnlFirstTime.TabIndex = 0
        '
        'btnSelectFirstTime
        '
        Me.btnSelectFirstTime.Location = New System.Drawing.Point(375, 99)
        Me.btnSelectFirstTime.Name = "btnSelectFirstTime"
        Me.btnSelectFirstTime.Size = New System.Drawing.Size(98, 29)
        Me.btnSelectFirstTime.TabIndex = 2
        Me.btnSelectFirstTime.Text = "Select"
        Me.btnSelectFirstTime.UseVisualStyleBackColor = True
        '
        'lblFirstTime
        '
        Me.lblFirstTime.AutoSize = True
        Me.lblFirstTime.Location = New System.Drawing.Point(143, 14)
        Me.lblFirstTime.Name = "lblFirstTime"
        Me.lblFirstTime.Size = New System.Drawing.Size(52, 13)
        Me.lblFirstTime.TabIndex = 1
        Me.lblFirstTime.Text = "First Time"
        '
        'pbFirstTime
        '
        Me.pbFirstTime.Location = New System.Drawing.Point(14, 14)
        Me.pbFirstTime.Name = "pbFirstTime"
        Me.pbFirstTime.Size = New System.Drawing.Size(112, 114)
        Me.pbFirstTime.TabIndex = 0
        Me.pbFirstTime.TabStop = False
        '
        'pnlSenior
        '
        Me.pnlSenior.Controls.Add(Me.btnSelectSenior)
        Me.pnlSenior.Controls.Add(Me.lblSenior)
        Me.pnlSenior.Controls.Add(Me.pbSenior)
        Me.pnlSenior.Location = New System.Drawing.Point(223, 314)
        Me.pnlSenior.Name = "pnlSenior"
        Me.pnlSenior.Size = New System.Drawing.Size(486, 142)
        Me.pnlSenior.TabIndex = 1
        '
        'btnSelectSenior
        '
        Me.btnSelectSenior.Location = New System.Drawing.Point(375, 99)
        Me.btnSelectSenior.Name = "btnSelectSenior"
        Me.btnSelectSenior.Size = New System.Drawing.Size(98, 29)
        Me.btnSelectSenior.TabIndex = 3
        Me.btnSelectSenior.Text = "Select"
        Me.btnSelectSenior.UseVisualStyleBackColor = True
        '
        'lblSenior
        '
        Me.lblSenior.AutoSize = True
        Me.lblSenior.Location = New System.Drawing.Point(143, 14)
        Me.lblSenior.Name = "lblSenior"
        Me.lblSenior.Size = New System.Drawing.Size(37, 13)
        Me.lblSenior.TabIndex = 2
        Me.lblSenior.Text = "Senior"
        '
        'pbSenior
        '
        Me.pbSenior.Location = New System.Drawing.Point(14, 14)
        Me.pbSenior.Name = "pbSenior"
        Me.pbSenior.Size = New System.Drawing.Size(112, 114)
        Me.pbSenior.TabIndex = 0
        Me.pbSenior.TabStop = False
        '
        'pnlReferral
        '
        Me.pnlReferral.Controls.Add(Me.lblEnterReferralCode)
        Me.pnlReferral.Controls.Add(Me.txtReferralCode)
        Me.pnlReferral.Controls.Add(Me.btnSelectReferral)
        Me.pnlReferral.Controls.Add(Me.lblReferral)
        Me.pnlReferral.Controls.Add(Me.pbReferral)
        Me.pnlReferral.Location = New System.Drawing.Point(715, 314)
        Me.pnlReferral.Name = "pnlReferral"
        Me.pnlReferral.Size = New System.Drawing.Size(486, 142)
        Me.pnlReferral.TabIndex = 3
        '
        'lblEnterReferralCode
        '
        Me.lblEnterReferralCode.AutoSize = True
        Me.lblEnterReferralCode.Location = New System.Drawing.Point(161, 36)
        Me.lblEnterReferralCode.Name = "lblEnterReferralCode"
        Me.lblEnterReferralCode.Size = New System.Drawing.Size(72, 13)
        Me.lblEnterReferralCode.TabIndex = 7
        Me.lblEnterReferralCode.Text = "Referral Code"
        '
        'txtReferralCode
        '
        Me.txtReferralCode.Location = New System.Drawing.Point(164, 52)
        Me.txtReferralCode.Name = "txtReferralCode"
        Me.txtReferralCode.Size = New System.Drawing.Size(307, 20)
        Me.txtReferralCode.TabIndex = 8
        '
        'btnSelectReferral
        '
        Me.btnSelectReferral.Location = New System.Drawing.Point(396, 102)
        Me.btnSelectReferral.Name = "btnSelectReferral"
        Me.btnSelectReferral.Size = New System.Drawing.Size(75, 23)
        Me.btnSelectReferral.TabIndex = 7
        Me.btnSelectReferral.Text = "Select"
        Me.btnSelectReferral.UseVisualStyleBackColor = True
        '
        'lblReferral
        '
        Me.lblReferral.AutoSize = True
        Me.lblReferral.Location = New System.Drawing.Point(144, 14)
        Me.lblReferral.Name = "lblReferral"
        Me.lblReferral.Size = New System.Drawing.Size(44, 13)
        Me.lblReferral.TabIndex = 4
        Me.lblReferral.Text = "Referral"
        '
        'pbReferral
        '
        Me.pbReferral.Location = New System.Drawing.Point(14, 14)
        Me.pbReferral.Name = "pbReferral"
        Me.pbReferral.Size = New System.Drawing.Size(112, 114)
        Me.pbReferral.TabIndex = 0
        Me.pbReferral.TabStop = False
        '
        'pnlBirthday
        '
        Me.pnlBirthday.Controls.Add(Me.btnSelectBirthday)
        Me.pnlBirthday.Controls.Add(Me.lblBirthday)
        Me.pnlBirthday.Controls.Add(Me.pbBirthday)
        Me.pnlBirthday.Location = New System.Drawing.Point(223, 462)
        Me.pnlBirthday.Name = "pnlBirthday"
        Me.pnlBirthday.Size = New System.Drawing.Size(486, 142)
        Me.pnlBirthday.TabIndex = 2
        '
        'btnSelectBirthday
        '
        Me.btnSelectBirthday.Location = New System.Drawing.Point(375, 99)
        Me.btnSelectBirthday.Name = "btnSelectBirthday"
        Me.btnSelectBirthday.Size = New System.Drawing.Size(98, 29)
        Me.btnSelectBirthday.TabIndex = 4
        Me.btnSelectBirthday.Text = "Select"
        Me.btnSelectBirthday.UseVisualStyleBackColor = True
        '
        'lblBirthday
        '
        Me.lblBirthday.AutoSize = True
        Me.lblBirthday.Location = New System.Drawing.Point(143, 14)
        Me.lblBirthday.Name = "lblBirthday"
        Me.lblBirthday.Size = New System.Drawing.Size(45, 13)
        Me.lblBirthday.TabIndex = 3
        Me.lblBirthday.Text = "Birthday"
        '
        'pbBirthday
        '
        Me.pbBirthday.Location = New System.Drawing.Point(14, 14)
        Me.pbBirthday.Name = "pbBirthday"
        Me.pbBirthday.Size = New System.Drawing.Size(112, 114)
        Me.pbBirthday.TabIndex = 0
        Me.pbBirthday.TabStop = False
        '
        'pnlLoyalty
        '
        Me.pnlLoyalty.Controls.Add(Me.btnSelectLoyalty)
        Me.pnlLoyalty.Controls.Add(Me.lblLoyalty)
        Me.pnlLoyalty.Controls.Add(Me.pbLoyalty)
        Me.pnlLoyalty.Location = New System.Drawing.Point(715, 166)
        Me.pnlLoyalty.Name = "pnlLoyalty"
        Me.pnlLoyalty.Size = New System.Drawing.Size(486, 142)
        Me.pnlLoyalty.TabIndex = 4
        '
        'btnSelectLoyalty
        '
        Me.btnSelectLoyalty.Location = New System.Drawing.Point(396, 102)
        Me.btnSelectLoyalty.Name = "btnSelectLoyalty"
        Me.btnSelectLoyalty.Size = New System.Drawing.Size(75, 23)
        Me.btnSelectLoyalty.TabIndex = 6
        Me.btnSelectLoyalty.Text = "Select"
        Me.btnSelectLoyalty.UseVisualStyleBackColor = True
        '
        'lblLoyalty
        '
        Me.lblLoyalty.AutoSize = True
        Me.lblLoyalty.Location = New System.Drawing.Point(144, 14)
        Me.lblLoyalty.Name = "lblLoyalty"
        Me.lblLoyalty.Size = New System.Drawing.Size(40, 13)
        Me.lblLoyalty.TabIndex = 5
        Me.lblLoyalty.Text = "Loyalty"
        '
        'pbLoyalty
        '
        Me.pbLoyalty.Location = New System.Drawing.Point(14, 14)
        Me.pbLoyalty.Name = "pbLoyalty"
        Me.pbLoyalty.Size = New System.Drawing.Size(112, 114)
        Me.pbLoyalty.TabIndex = 0
        Me.pbLoyalty.TabStop = False
        '
        'btnApplyVoucher
        '
        Me.btnApplyVoucher.Location = New System.Drawing.Point(1111, 561)
        Me.btnApplyVoucher.Name = "btnApplyVoucher"
        Me.btnApplyVoucher.Size = New System.Drawing.Size(90, 23)
        Me.btnApplyVoucher.TabIndex = 5
        Me.btnApplyVoucher.Text = "Apply Voucher"
        Me.btnApplyVoucher.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(1111, 590)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 23)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'FormVoucher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1424, 771)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnApplyVoucher)
        Me.Controls.Add(Me.pnlLoyalty)
        Me.Controls.Add(Me.pnlReferral)
        Me.Controls.Add(Me.pnlSenior)
        Me.Controls.Add(Me.pnlBirthday)
        Me.Controls.Add(Me.pnlFirstTime)
        Me.Name = "FormVoucher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormVoucher"
        Me.pnlFirstTime.ResumeLayout(False)
        Me.pnlFirstTime.PerformLayout()
        CType(Me.pbFirstTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSenior.ResumeLayout(False)
        Me.pnlSenior.PerformLayout()
        CType(Me.pbSenior, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlReferral.ResumeLayout(False)
        Me.pnlReferral.PerformLayout()
        CType(Me.pbReferral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBirthday.ResumeLayout(False)
        Me.pnlBirthday.PerformLayout()
        CType(Me.pbBirthday, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLoyalty.ResumeLayout(False)
        Me.pnlLoyalty.PerformLayout()
        CType(Me.pbLoyalty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlFirstTime As Panel
    Friend WithEvents pbFirstTime As PictureBox
    Friend WithEvents pnlSenior As Panel
    Friend WithEvents pbSenior As PictureBox
    Friend WithEvents pnlReferral As Panel
    Friend WithEvents pbReferral As PictureBox
    Friend WithEvents pnlBirthday As Panel
    Friend WithEvents pbBirthday As PictureBox
    Friend WithEvents lblFirstTime As Label
    Friend WithEvents pnlLoyalty As Panel
    Friend WithEvents pbLoyalty As PictureBox
    Friend WithEvents lblSenior As Label
    Friend WithEvents lblReferral As Label
    Friend WithEvents lblBirthday As Label
    Friend WithEvents lblLoyalty As Label
    Friend WithEvents btnSelectFirstTime As Button
    Friend WithEvents btnSelectSenior As Button
    Friend WithEvents lblEnterReferralCode As Label
    Friend WithEvents txtReferralCode As TextBox
    Friend WithEvents btnSelectReferral As Button
    Friend WithEvents btnSelectBirthday As Button
    Friend WithEvents btnSelectLoyalty As Button
    Friend WithEvents btnApplyVoucher As Button
    Friend WithEvents btnCancel As Button
End Class
