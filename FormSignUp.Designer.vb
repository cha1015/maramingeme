<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSignUp
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
        Me.gbCreateAcc = New System.Windows.Forms.GroupBox()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.cbRole = New System.Windows.Forms.ComboBox()
        Me.btnShowPass = New System.Windows.Forms.Button()
        Me.btnShowConfPass = New System.Windows.Forms.Button()
        Me.btnSignUp = New System.Windows.Forms.Button()
        Me.lnklblLogIn = New System.Windows.Forms.LinkLabel()
        Me.lblConfPass = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtConfPass = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.gbCreateAcc.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbCreateAcc
        '
        Me.gbCreateAcc.Controls.Add(Me.btnNext)
        Me.gbCreateAcc.Controls.Add(Me.lblRole)
        Me.gbCreateAcc.Controls.Add(Me.lblConfPass)
        Me.gbCreateAcc.Controls.Add(Me.lblPass)
        Me.gbCreateAcc.Controls.Add(Me.lblEmail)
        Me.gbCreateAcc.Controls.Add(Me.lblUsername)
        Me.gbCreateAcc.Controls.Add(Me.lblLastName)
        Me.gbCreateAcc.Controls.Add(Me.lblFirstName)
        Me.gbCreateAcc.Location = New System.Drawing.Point(801, 143)
        Me.gbCreateAcc.Margin = New System.Windows.Forms.Padding(4)
        Me.gbCreateAcc.Name = "gbCreateAcc"
        Me.gbCreateAcc.Padding = New System.Windows.Forms.Padding(4)
        Me.gbCreateAcc.Size = New System.Drawing.Size(456, 359)
        Me.gbCreateAcc.TabIndex = 14
        Me.gbCreateAcc.TabStop = False
        Me.gbCreateAcc.Text = "Create Account"
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.Location = New System.Drawing.Point(13, 218)
        Me.lblRole.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(36, 16)
        Me.lblRole.TabIndex = 23
        Me.lblRole.Text = "Role"
        '
        'cbRole
        '
        Me.cbRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbRole.Font = New System.Drawing.Font("Poppins Light", 4.0!)
        Me.cbRole.FormattingEnabled = True
        Me.cbRole.Items.AddRange(New Object() {"User", "Admin"})
        Me.cbRole.Location = New System.Drawing.Point(97, 565)
        Me.cbRole.Margin = New System.Windows.Forms.Padding(4)
        Me.cbRole.Name = "cbRole"
        Me.cbRole.Size = New System.Drawing.Size(236, 20)
        Me.cbRole.TabIndex = 22
        '
        'btnShowPass
        '
        Me.btnShowPass.BackColor = System.Drawing.Color.Transparent
        Me.btnShowPass.FlatAppearance.BorderSize = 0
        Me.btnShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowPass.Location = New System.Drawing.Point(346, 453)
        Me.btnShowPass.Margin = New System.Windows.Forms.Padding(4)
        Me.btnShowPass.Name = "btnShowPass"
        Me.btnShowPass.Size = New System.Drawing.Size(70, 30)
        Me.btnShowPass.TabIndex = 21
        Me.btnShowPass.UseVisualStyleBackColor = False
        '
        'btnShowConfPass
        '
        Me.btnShowConfPass.BackColor = System.Drawing.Color.Transparent
        Me.btnShowConfPass.FlatAppearance.BorderSize = 0
        Me.btnShowConfPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowConfPass.Location = New System.Drawing.Point(346, 505)
        Me.btnShowConfPass.Margin = New System.Windows.Forms.Padding(4)
        Me.btnShowConfPass.Name = "btnShowConfPass"
        Me.btnShowConfPass.Size = New System.Drawing.Size(70, 30)
        Me.btnShowConfPass.TabIndex = 20
        Me.btnShowConfPass.UseVisualStyleBackColor = False
        '
        'btnSignUp
        '
        Me.btnSignUp.BackColor = System.Drawing.Color.Transparent
        Me.btnSignUp.FlatAppearance.BorderSize = 0
        Me.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignUp.Location = New System.Drawing.Point(1114, 638)
        Me.btnSignUp.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(218, 55)
        Me.btnSignUp.TabIndex = 19
        Me.btnSignUp.UseVisualStyleBackColor = False
        '
        'lnklblLogIn
        '
        Me.lnklblLogIn.AutoSize = True
        Me.lnklblLogIn.BackColor = System.Drawing.Color.Transparent
        Me.lnklblLogIn.Font = New System.Drawing.Font("Poppins", 11.0!)
        Me.lnklblLogIn.LinkColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lnklblLogIn.Location = New System.Drawing.Point(364, 599)
        Me.lnklblLogIn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lnklblLogIn.Name = "lnklblLogIn"
        Me.lnklblLogIn.Size = New System.Drawing.Size(70, 33)
        Me.lnklblLogIn.TabIndex = 18
        Me.lnklblLogIn.TabStop = True
        Me.lnklblLogIn.Text = "Log In"
        '
        'lblConfPass
        '
        Me.lblConfPass.AutoSize = True
        Me.lblConfPass.Location = New System.Drawing.Point(12, 187)
        Me.lblConfPass.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblConfPass.Name = "lblConfPass"
        Me.lblConfPass.Size = New System.Drawing.Size(115, 16)
        Me.lblConfPass.TabIndex = 17
        Me.lblConfPass.Text = "Confirm Password"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Location = New System.Drawing.Point(12, 154)
        Me.lblPass.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(67, 16)
        Me.lblPass.TabIndex = 16
        Me.lblPass.Text = "Password"
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Font = New System.Drawing.Font("Poppins Light", 8.0!)
        Me.txtEmail.Location = New System.Drawing.Point(97, 351)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(310, 20)
        Me.txtEmail.TabIndex = 13
        '
        'txtPass
        '
        Me.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPass.Font = New System.Drawing.Font("Poppins Light", 8.0!)
        Me.txtPass.Location = New System.Drawing.Point(97, 458)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(236, 20)
        Me.txtPass.TabIndex = 14
        '
        'txtConfPass
        '
        Me.txtConfPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtConfPass.Font = New System.Drawing.Font("Poppins Light", 8.0!)
        Me.txtConfPass.Location = New System.Drawing.Point(97, 511)
        Me.txtConfPass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtConfPass.Name = "txtConfPass"
        Me.txtConfPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfPass.Size = New System.Drawing.Size(236, 20)
        Me.txtConfPass.TabIndex = 15
        '
        'txtFirstName
        '
        Me.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFirstName.Font = New System.Drawing.Font("Poppins Light", 8.0!)
        Me.txtFirstName.Location = New System.Drawing.Point(97, 296)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(176, 20)
        Me.txtFirstName.TabIndex = 0
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(12, 121)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(41, 16)
        Me.lblEmail.TabIndex = 12
        Me.lblEmail.Text = "Email"
        '
        'txtLastName
        '
        Me.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLastName.Font = New System.Drawing.Font("Poppins Light", 8.0!)
        Me.txtLastName.Location = New System.Drawing.Point(287, 296)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(211, 20)
        Me.txtLastName.TabIndex = 1
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(12, 87)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(70, 16)
        Me.lblUsername.TabIndex = 11
        Me.lblUsername.Text = "Username"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(12, 54)
        Me.lblLastName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(72, 16)
        Me.lblLastName.TabIndex = 9
        Me.lblLastName.Text = "Last Name"
        '
        'txtUsername
        '
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Font = New System.Drawing.Font("Poppins Light", 8.0!)
        Me.txtUsername.Location = New System.Drawing.Point(97, 403)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(310, 20)
        Me.txtUsername.TabIndex = 6
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(12, 21)
        Me.lblFirstName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(72, 16)
        Me.lblFirstName.TabIndex = 8
        Me.lblFirstName.Text = "First Name"
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(213, 109)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(41, 41)
        Me.btnNext.TabIndex = 32
        Me.btnNext.Text = "→"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Location = New System.Drawing.Point(80, 652)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(139, 41)
        Me.btnBack.TabIndex = 31
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'FormSignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.maramingeme.My.Resources.Resources.SignUp_Window
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1422, 763)
        Me.Controls.Add(Me.btnSignUp)
        Me.Controls.Add(Me.btnShowConfPass)
        Me.Controls.Add(Me.lnklblLogIn)
        Me.Controls.Add(Me.btnShowPass)
        Me.Controls.Add(Me.cbRole)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.gbCreateAcc)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtConfPass)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormSignUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormSignUp"
        Me.gbCreateAcc.ResumeLayout(False)
        Me.gbCreateAcc.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbCreateAcc As GroupBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents btnSignUp As Button
    Friend WithEvents lnklblLogIn As LinkLabel
    Friend WithEvents lblConfPass As Label
    Friend WithEvents lblPass As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtConfPass As TextBox
    Friend WithEvents btnShowPass As Button
    Friend WithEvents btnShowConfPass As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents lblRole As Label
    Friend WithEvents cbRole As ComboBox
End Class
