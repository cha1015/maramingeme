<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogIn
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
        Me.gbCustomerInformation = New System.Windows.Forms.GroupBox()
        Me.btnShowPass = New System.Windows.Forms.Button()
        Me.btnShowConfPass = New System.Windows.Forms.Button()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.lnklblSignUp = New System.Windows.Forms.LinkLabel()
        Me.lblConfPass = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtConfPass = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.gbCustomerInformation.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbCustomerInformation
        '
        Me.gbCustomerInformation.Controls.Add(Me.btnShowPass)
        Me.gbCustomerInformation.Controls.Add(Me.btnShowConfPass)
        Me.gbCustomerInformation.Controls.Add(Me.btnLogIn)
        Me.gbCustomerInformation.Controls.Add(Me.lnklblSignUp)
        Me.gbCustomerInformation.Controls.Add(Me.lblConfPass)
        Me.gbCustomerInformation.Controls.Add(Me.lblPass)
        Me.gbCustomerInformation.Controls.Add(Me.txtEmail)
        Me.gbCustomerInformation.Controls.Add(Me.txtPass)
        Me.gbCustomerInformation.Controls.Add(Me.txtConfPass)
        Me.gbCustomerInformation.Controls.Add(Me.lblEmail)
        Me.gbCustomerInformation.Location = New System.Drawing.Point(541, 271)
        Me.gbCustomerInformation.Name = "gbCustomerInformation"
        Me.gbCustomerInformation.Size = New System.Drawing.Size(342, 229)
        Me.gbCustomerInformation.TabIndex = 15
        Me.gbCustomerInformation.TabStop = False
        Me.gbCustomerInformation.Text = "Log In"
        '
        'btnShowPass
        '
        Me.btnShowPass.Location = New System.Drawing.Point(285, 81)
        Me.btnShowPass.Name = "btnShowPass"
        Me.btnShowPass.Size = New System.Drawing.Size(48, 23)
        Me.btnShowPass.TabIndex = 23
        Me.btnShowPass.Text = "Show"
        Me.btnShowPass.UseVisualStyleBackColor = True
        '
        'btnShowConfPass
        '
        Me.btnShowConfPass.Location = New System.Drawing.Point(285, 106)
        Me.btnShowConfPass.Name = "btnShowConfPass"
        Me.btnShowConfPass.Size = New System.Drawing.Size(48, 23)
        Me.btnShowConfPass.TabIndex = 22
        Me.btnShowConfPass.Text = "Show"
        Me.btnShowConfPass.UseVisualStyleBackColor = True
        '
        'btnLogIn
        '
        Me.btnLogIn.Location = New System.Drawing.Point(258, 150)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(75, 23)
        Me.btnLogIn.TabIndex = 19
        Me.btnLogIn.Text = "Log In"
        Me.btnLogIn.UseVisualStyleBackColor = True
        '
        'lnklblSignUp
        '
        Me.lnklblSignUp.AutoSize = True
        Me.lnklblSignUp.Location = New System.Drawing.Point(9, 150)
        Me.lnklblSignUp.Name = "lnklblSignUp"
        Me.lnklblSignUp.Size = New System.Drawing.Size(163, 13)
        Me.lnklblSignUp.TabIndex = 18
        Me.lnklblSignUp.TabStop = True
        Me.lnklblSignUp.Text = "Don't have an account? Sign Up"
        '
        'lblConfPass
        '
        Me.lblConfPass.AutoSize = True
        Me.lblConfPass.Location = New System.Drawing.Point(9, 113)
        Me.lblConfPass.Name = "lblConfPass"
        Me.lblConfPass.Size = New System.Drawing.Size(91, 13)
        Me.lblConfPass.TabIndex = 17
        Me.lblConfPass.Text = "Confirm Password"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Location = New System.Drawing.Point(9, 86)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(53, 13)
        Me.lblPass.TabIndex = 16
        Me.lblPass.Text = "Password"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(107, 56)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(226, 20)
        Me.txtEmail.TabIndex = 13
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(107, 82)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(172, 20)
        Me.txtPass.TabIndex = 14
        '
        'txtConfPass
        '
        Me.txtConfPass.Location = New System.Drawing.Point(107, 108)
        Me.txtConfPass.Name = "txtConfPass"
        Me.txtConfPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfPass.Size = New System.Drawing.Size(172, 20)
        Me.txtConfPass.TabIndex = 15
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(9, 59)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 12
        Me.lblEmail.Text = "Email"
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(60, 25)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(31, 33)
        Me.btnNext.TabIndex = 34
        Me.btnNext.Text = "→"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(23, 25)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(31, 33)
        Me.btnBack.TabIndex = 33
        Me.btnBack.Text = "←"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'FormLogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1424, 771)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.gbCustomerInformation)
        Me.Name = "FormLogIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLogIn"
        Me.gbCustomerInformation.ResumeLayout(False)
        Me.gbCustomerInformation.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbCustomerInformation As GroupBox
    Friend WithEvents btnLogIn As Button
    Friend WithEvents lnklblSignUp As LinkLabel
    Friend WithEvents lblConfPass As Label
    Friend WithEvents lblPass As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtConfPass As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents btnShowPass As Button
    Friend WithEvents btnShowConfPass As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnBack As Button
End Class
