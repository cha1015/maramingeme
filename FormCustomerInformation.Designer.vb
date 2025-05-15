<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCustomerInformation
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
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.lblSex = New System.Windows.Forms.Label()
        Me.lblBirthday = New System.Windows.Forms.Label()
        Me.dtpBirthday = New System.Windows.Forms.DateTimePicker()
        Me.cmbSex = New System.Windows.Forms.ComboBox()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnShowPass = New System.Windows.Forms.Button()
        Me.btnShowConfPass = New System.Windows.Forms.Button()
        Me.lblConfPass = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtConfPass = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.gbCustomerInformation.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbCustomerInformation
        '
        Me.gbCustomerInformation.BackColor = System.Drawing.Color.Transparent
        Me.gbCustomerInformation.Controls.Add(Me.lblAddress)
        Me.gbCustomerInformation.Controls.Add(Me.lblSex)
        Me.gbCustomerInformation.Controls.Add(Me.lblBirthday)
        Me.gbCustomerInformation.Controls.Add(Me.lblAge)
        Me.gbCustomerInformation.Controls.Add(Me.lblName)
        Me.gbCustomerInformation.Location = New System.Drawing.Point(901, 210)
        Me.gbCustomerInformation.Margin = New System.Windows.Forms.Padding(4)
        Me.gbCustomerInformation.Name = "gbCustomerInformation"
        Me.gbCustomerInformation.Padding = New System.Windows.Forms.Padding(4)
        Me.gbCustomerInformation.Size = New System.Drawing.Size(456, 202)
        Me.gbCustomerInformation.TabIndex = 15
        Me.gbCustomerInformation.TabStop = False
        Me.gbCustomerInformation.Text = "Default Customer Information"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCustomerName.Font = New System.Drawing.Font("Poppins", 6.0!)
        Me.txtCustomerName.Location = New System.Drawing.Point(334, 278)
        Me.txtCustomerName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(360, 15)
        Me.txtCustomerName.TabIndex = 0
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(11, 161)
        Me.lblAddress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(58, 16)
        Me.lblAddress.TabIndex = 12
        Me.lblAddress.Text = "Address"
        '
        'txtAge
        '
        Me.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAge.Font = New System.Drawing.Font("Poppins", 6.0!)
        Me.txtAge.Location = New System.Drawing.Point(334, 373)
        Me.txtAge.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.ReadOnly = True
        Me.txtAge.Size = New System.Drawing.Size(360, 15)
        Me.txtAge.TabIndex = 1
        '
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.lblSex.Location = New System.Drawing.Point(11, 127)
        Me.lblSex.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(30, 16)
        Me.lblSex.TabIndex = 11
        Me.lblSex.Text = "Sex"
        '
        'lblBirthday
        '
        Me.lblBirthday.AutoSize = True
        Me.lblBirthday.Location = New System.Drawing.Point(11, 58)
        Me.lblBirthday.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBirthday.Name = "lblBirthday"
        Me.lblBirthday.Size = New System.Drawing.Size(56, 16)
        Me.lblBirthday.TabIndex = 10
        Me.lblBirthday.Text = "Birthday"
        '
        'dtpBirthday
        '
        Me.dtpBirthday.Font = New System.Drawing.Font("Poppins", 6.0!)
        Me.dtpBirthday.Location = New System.Drawing.Point(334, 325)
        Me.dtpBirthday.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpBirthday.Name = "dtpBirthday"
        Me.dtpBirthday.Size = New System.Drawing.Size(360, 22)
        Me.dtpBirthday.TabIndex = 4
        '
        'cmbSex
        '
        Me.cmbSex.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSex.Font = New System.Drawing.Font("Poppins", 6.0!)
        Me.cmbSex.FormattingEnabled = True
        Me.cmbSex.Items.AddRange(New Object() {"Male", "Female", "Non-Binary", "Other", "Prefer Not to Say"})
        Me.cmbSex.Location = New System.Drawing.Point(334, 414)
        Me.cmbSex.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSex.Name = "cmbSex"
        Me.cmbSex.Size = New System.Drawing.Size(360, 26)
        Me.cmbSex.TabIndex = 5
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(11, 92)
        Me.lblAge.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(32, 16)
        Me.lblAge.TabIndex = 9
        Me.lblAge.Text = "Age"
        '
        'txtAddress
        '
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAddress.Font = New System.Drawing.Font("Poppins", 6.0!)
        Me.txtAddress.Location = New System.Drawing.Point(334, 462)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(360, 15)
        Me.txtAddress.TabIndex = 6
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(11, 23)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(44, 16)
        Me.lblName.TabIndex = 8
        Me.lblName.Text = "Name"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(1143, 648)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(175, 40)
        Me.btnSave.TabIndex = 16
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(950, 646)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(175, 40)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnShowPass
        '
        Me.btnShowPass.BackColor = System.Drawing.Color.Transparent
        Me.btnShowPass.FlatAppearance.BorderSize = 0
        Me.btnShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowPass.Location = New System.Drawing.Point(630, 546)
        Me.btnShowPass.Margin = New System.Windows.Forms.Padding(4)
        Me.btnShowPass.Name = "btnShowPass"
        Me.btnShowPass.Size = New System.Drawing.Size(64, 28)
        Me.btnShowPass.TabIndex = 37
        Me.btnShowPass.UseVisualStyleBackColor = False
        '
        'btnShowConfPass
        '
        Me.btnShowConfPass.BackColor = System.Drawing.Color.Transparent
        Me.btnShowConfPass.FlatAppearance.BorderSize = 0
        Me.btnShowConfPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowConfPass.Location = New System.Drawing.Point(630, 590)
        Me.btnShowConfPass.Margin = New System.Windows.Forms.Padding(4)
        Me.btnShowConfPass.Name = "btnShowConfPass"
        Me.btnShowConfPass.Size = New System.Drawing.Size(64, 28)
        Me.btnShowConfPass.TabIndex = 36
        Me.btnShowConfPass.UseVisualStyleBackColor = False
        '
        'lblConfPass
        '
        Me.lblConfPass.AutoSize = True
        Me.lblConfPass.Location = New System.Drawing.Point(1002, 535)
        Me.lblConfPass.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblConfPass.Name = "lblConfPass"
        Me.lblConfPass.Size = New System.Drawing.Size(115, 16)
        Me.lblConfPass.TabIndex = 35
        Me.lblConfPass.Text = "Confirm Password"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Location = New System.Drawing.Point(1002, 502)
        Me.lblPass.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(67, 16)
        Me.lblPass.TabIndex = 34
        Me.lblPass.Text = "Password"
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Font = New System.Drawing.Font("Poppins", 6.0!)
        Me.txtEmail.Location = New System.Drawing.Point(334, 508)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(360, 15)
        Me.txtEmail.TabIndex = 31
        '
        'txtPass
        '
        Me.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPass.Font = New System.Drawing.Font("Poppins", 6.0!)
        Me.txtPass.Location = New System.Drawing.Point(334, 552)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(276, 15)
        Me.txtPass.TabIndex = 32
        '
        'txtConfPass
        '
        Me.txtConfPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtConfPass.Font = New System.Drawing.Font("Poppins", 6.0!)
        Me.txtConfPass.Location = New System.Drawing.Point(334, 597)
        Me.txtConfPass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtConfPass.Name = "txtConfPass"
        Me.txtConfPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfPass.Size = New System.Drawing.Size(276, 15)
        Me.txtConfPass.TabIndex = 33
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(1002, 468)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(41, 16)
        Me.lblEmail.TabIndex = 30
        Me.lblEmail.Text = "Email"
        '
        'FormCustomerInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.maramingeme.My.Resources.Resources.Customer_Information_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1422, 763)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.btnShowPass)
        Me.Controls.Add(Me.cmbSex)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.btnShowConfPass)
        Me.Controls.Add(Me.lblConfPass)
        Me.Controls.Add(Me.dtpBirthday)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtConfPass)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.gbCustomerInformation)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormCustomerInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormCustomerInformation"
        Me.gbCustomerInformation.ResumeLayout(False)
        Me.gbCustomerInformation.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbCustomerInformation As GroupBox
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents lblSex As Label
    Friend WithEvents lblBirthday As Label
    Friend WithEvents dtpBirthday As DateTimePicker
    Friend WithEvents cmbSex As ComboBox
    Friend WithEvents lblAge As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnShowPass As Button
    Friend WithEvents btnShowConfPass As Button
    Friend WithEvents lblConfPass As Label
    Friend WithEvents lblPass As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtConfPass As TextBox
    Friend WithEvents lblEmail As Label
End Class
