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
        Me.gbCreateAcc.Controls.Add(Me.lblRole)
        Me.gbCreateAcc.Controls.Add(Me.cbRole)
        Me.gbCreateAcc.Controls.Add(Me.btnShowPass)
        Me.gbCreateAcc.Controls.Add(Me.btnShowConfPass)
        Me.gbCreateAcc.Controls.Add(Me.btnSignUp)
        Me.gbCreateAcc.Controls.Add(Me.lnklblLogIn)
        Me.gbCreateAcc.Controls.Add(Me.lblConfPass)
        Me.gbCreateAcc.Controls.Add(Me.lblPass)
        Me.gbCreateAcc.Controls.Add(Me.txtEmail)
        Me.gbCreateAcc.Controls.Add(Me.txtPass)
        Me.gbCreateAcc.Controls.Add(Me.txtConfPass)
        Me.gbCreateAcc.Controls.Add(Me.txtFirstName)
        Me.gbCreateAcc.Controls.Add(Me.lblEmail)
        Me.gbCreateAcc.Controls.Add(Me.txtLastName)
        Me.gbCreateAcc.Controls.Add(Me.lblUsername)
        Me.gbCreateAcc.Controls.Add(Me.lblLastName)
        Me.gbCreateAcc.Controls.Add(Me.txtUsername)
        Me.gbCreateAcc.Controls.Add(Me.lblFirstName)
        Me.gbCreateAcc.Location = New System.Drawing.Point(541, 271)
        Me.gbCreateAcc.Name = "gbCreateAcc"
        Me.gbCreateAcc.Size = New System.Drawing.Size(342, 292)
        Me.gbCreateAcc.TabIndex = 14
        Me.gbCreateAcc.TabStop = False
        Me.gbCreateAcc.Text = "Create Account"
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.Location = New System.Drawing.Point(10, 177)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(29, 13)
        Me.lblRole.TabIndex = 23
        Me.lblRole.Text = "Role"
        '
        'cbRole
        '
        Me.cbRole.FormattingEnabled = True
        Me.cbRole.Items.AddRange(New Object() {"User", "Admin"})
        Me.cbRole.Location = New System.Drawing.Point(107, 174)
        Me.cbRole.Name = "cbRole"
        Me.cbRole.Size = New System.Drawing.Size(226, 21)
        Me.cbRole.TabIndex = 22
        '
        'btnShowPass
        '
        Me.btnShowPass.Location = New System.Drawing.Point(285, 120)
        Me.btnShowPass.Name = "btnShowPass"
        Me.btnShowPass.Size = New System.Drawing.Size(48, 23)
        Me.btnShowPass.TabIndex = 21
        Me.btnShowPass.Text = "Show"
        Me.btnShowPass.UseVisualStyleBackColor = True
        '
        'btnShowConfPass
        '
        Me.btnShowConfPass.Location = New System.Drawing.Point(285, 145)
        Me.btnShowConfPass.Name = "btnShowConfPass"
        Me.btnShowConfPass.Size = New System.Drawing.Size(48, 23)
        Me.btnShowConfPass.TabIndex = 20
        Me.btnShowConfPass.Text = "Show"
        Me.btnShowConfPass.UseVisualStyleBackColor = True
        '
        'btnSignUp
        '
        Me.btnSignUp.Location = New System.Drawing.Point(258, 258)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(75, 23)
        Me.btnSignUp.TabIndex = 19
        Me.btnSignUp.Text = "Sign Up"
        Me.btnSignUp.UseVisualStyleBackColor = True
        '
        'lnklblLogIn
        '
        Me.lnklblLogIn.AutoSize = True
        Me.lnklblLogIn.Location = New System.Drawing.Point(9, 258)
        Me.lnklblLogIn.Name = "lnklblLogIn"
        Me.lnklblLogIn.Size = New System.Drawing.Size(130, 13)
        Me.lnklblLogIn.TabIndex = 18
        Me.lnklblLogIn.TabStop = True
        Me.lnklblLogIn.Text = "I have an account. Log In"
        '
        'lblConfPass
        '
        Me.lblConfPass.AutoSize = True
        Me.lblConfPass.Location = New System.Drawing.Point(9, 152)
        Me.lblConfPass.Name = "lblConfPass"
        Me.lblConfPass.Size = New System.Drawing.Size(91, 13)
        Me.lblConfPass.TabIndex = 17
        Me.lblConfPass.Text = "Confirm Password"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Location = New System.Drawing.Point(9, 125)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(53, 13)
        Me.lblPass.TabIndex = 16
        Me.lblPass.Text = "Password"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(107, 95)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(226, 20)
        Me.txtEmail.TabIndex = 13
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(107, 121)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(172, 20)
        Me.txtPass.TabIndex = 14
        '
        'txtConfPass
        '
        Me.txtConfPass.Location = New System.Drawing.Point(107, 147)
        Me.txtConfPass.Name = "txtConfPass"
        Me.txtConfPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfPass.Size = New System.Drawing.Size(172, 20)
        Me.txtConfPass.TabIndex = 15
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(107, 17)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(226, 20)
        Me.txtFirstName.TabIndex = 0
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(9, 98)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 12
        Me.lblEmail.Text = "Email"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(107, 43)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(226, 20)
        Me.txtLastName.TabIndex = 1
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(9, 71)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(55, 13)
        Me.lblUsername.TabIndex = 11
        Me.lblUsername.Text = "Username"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(9, 44)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(58, 13)
        Me.lblLastName.TabIndex = 9
        Me.lblLastName.Text = "Last Name"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(107, 69)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(226, 20)
        Me.txtUsername.TabIndex = 6
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(9, 17)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(57, 13)
        Me.lblFirstName.TabIndex = 8
        Me.lblFirstName.Text = "First Name"
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
        'FormSignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1424, 771)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.gbCreateAcc)
        Me.Name = "FormSignUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormSignUp"
        Me.gbCreateAcc.ResumeLayout(False)
        Me.gbCreateAcc.PerformLayout()
        Me.ResumeLayout(False)

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
