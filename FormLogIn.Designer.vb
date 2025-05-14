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
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.lnklblSignUp = New System.Windows.Forms.LinkLabel()
        Me.lblConfPass = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.btnShowPass = New System.Windows.Forms.Button()
        Me.btnShowConfPass = New System.Windows.Forms.Button()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtConfPass = New System.Windows.Forms.TextBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.gbCustomerInformation.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbCustomerInformation
        '
        Me.gbCustomerInformation.Controls.Add(Me.lblConfPass)
        Me.gbCustomerInformation.Controls.Add(Me.lblPass)
        Me.gbCustomerInformation.Controls.Add(Me.lblEmail)
        Me.gbCustomerInformation.Controls.Add(Me.btnNext)
        Me.gbCustomerInformation.Location = New System.Drawing.Point(797, 233)
        Me.gbCustomerInformation.Margin = New System.Windows.Forms.Padding(4)
        Me.gbCustomerInformation.Name = "gbCustomerInformation"
        Me.gbCustomerInformation.Padding = New System.Windows.Forms.Padding(4)
        Me.gbCustomerInformation.Size = New System.Drawing.Size(456, 282)
        Me.gbCustomerInformation.TabIndex = 15
        Me.gbCustomerInformation.TabStop = False
        Me.gbCustomerInformation.Text = "Log In"
        '
        'btnLogIn
        '
        Me.btnLogIn.BackColor = System.Drawing.Color.Transparent
        Me.btnLogIn.FlatAppearance.BorderSize = 0
        Me.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogIn.Location = New System.Drawing.Point(1108, 629)
        Me.btnLogIn.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(230, 71)
        Me.btnLogIn.TabIndex = 19
        Me.btnLogIn.UseVisualStyleBackColor = False
        '
        'lnklblSignUp
        '
        Me.lnklblSignUp.AutoSize = True
        Me.lnklblSignUp.BackColor = System.Drawing.Color.Transparent
        Me.lnklblSignUp.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnklblSignUp.LinkColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lnklblSignUp.Location = New System.Drawing.Point(372, 582)
        Me.lnklblSignUp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lnklblSignUp.Name = "lnklblSignUp"
        Me.lnklblSignUp.Size = New System.Drawing.Size(102, 35)
        Me.lnklblSignUp.TabIndex = 18
        Me.lnklblSignUp.TabStop = True
        Me.lnklblSignUp.Text = " Sign Up"
        '
        'lblConfPass
        '
        Me.lblConfPass.AutoSize = True
        Me.lblConfPass.Location = New System.Drawing.Point(12, 139)
        Me.lblConfPass.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblConfPass.Name = "lblConfPass"
        Me.lblConfPass.Size = New System.Drawing.Size(115, 16)
        Me.lblConfPass.TabIndex = 17
        Me.lblConfPass.Text = "Confirm Password"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Location = New System.Drawing.Point(12, 106)
        Me.lblPass.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(67, 16)
        Me.lblPass.TabIndex = 16
        Me.lblPass.Text = "Password"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(12, 73)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(41, 16)
        Me.lblEmail.TabIndex = 12
        Me.lblEmail.Text = "Email"
        '
        'btnShowPass
        '
        Me.btnShowPass.BackColor = System.Drawing.Color.Transparent
        Me.btnShowPass.FlatAppearance.BorderSize = 0
        Me.btnShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowPass.Location = New System.Drawing.Point(579, 412)
        Me.btnShowPass.Margin = New System.Windows.Forms.Padding(4)
        Me.btnShowPass.Name = "btnShowPass"
        Me.btnShowPass.Size = New System.Drawing.Size(127, 52)
        Me.btnShowPass.TabIndex = 23
        Me.btnShowPass.UseVisualStyleBackColor = False
        '
        'btnShowConfPass
        '
        Me.btnShowConfPass.BackColor = System.Drawing.Color.Transparent
        Me.btnShowConfPass.FlatAppearance.BorderSize = 0
        Me.btnShowConfPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowConfPass.Location = New System.Drawing.Point(579, 513)
        Me.btnShowConfPass.Margin = New System.Windows.Forms.Padding(4)
        Me.btnShowConfPass.Name = "btnShowConfPass"
        Me.btnShowConfPass.Size = New System.Drawing.Size(127, 52)
        Me.btnShowConfPass.TabIndex = 22
        Me.btnShowConfPass.UseVisualStyleBackColor = False
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Font = New System.Drawing.Font("Poppins Light", 11.0!)
        Me.txtEmail.Location = New System.Drawing.Point(115, 318)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(573, 28)
        Me.txtEmail.TabIndex = 13
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPass.Font = New System.Drawing.Font("Poppins Light", 11.0!)
        Me.txtPass.Location = New System.Drawing.Point(115, 421)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(429, 28)
        Me.txtPass.TabIndex = 14
        '
        'txtConfPass
        '
        Me.txtConfPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtConfPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtConfPass.Font = New System.Drawing.Font("Poppins Light", 11.0!)
        Me.txtConfPass.Location = New System.Drawing.Point(115, 522)
        Me.txtConfPass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtConfPass.Name = "txtConfPass"
        Me.txtConfPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfPass.Size = New System.Drawing.Size(429, 28)
        Me.txtConfPass.TabIndex = 15
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(283, 61)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(41, 41)
        Me.btnNext.TabIndex = 34
        Me.btnNext.Text = "→"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Location = New System.Drawing.Point(80, 643)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(144, 57)
        Me.btnBack.TabIndex = 33
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'FormLogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.maramingeme.My.Resources.Resources.LogIn_Bg_2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1422, 763)
        Me.Controls.Add(Me.btnLogIn)
        Me.Controls.Add(Me.btnShowConfPass)
        Me.Controls.Add(Me.lnklblSignUp)
        Me.Controls.Add(Me.btnShowPass)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.gbCustomerInformation)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtConfPass)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormLogIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLogIn"
        Me.gbCustomerInformation.ResumeLayout(False)
        Me.gbCustomerInformation.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
