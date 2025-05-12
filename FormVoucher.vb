Imports MySql.Data.MySqlClient

Public Class FormVoucher
    Public Property SelectedVoucherDiscount As Decimal = 0
    Public Property SelectedVoucherName As String = ""
    Public Property CustomerId As Integer
    Public Property CustomerBirthday As Date
    Public Property CustomerAge As Integer
    Public Property IsFirstTimeCustomer As Boolean
    Public Property HasLoyaltyDiscount As Boolean

    Public Sub New(customerId As Integer, customerBirthday As Date, isFirstTime As Boolean, hasLoyalty As Boolean)
        InitializeComponent()
        Me.CustomerId = customerId
        Me.CustomerBirthday = customerBirthday
        Me.CustomerAge = DateDiff(DateInterval.Year, customerBirthday, Date.Today)
        Me.IsFirstTimeCustomer = isFirstTime
        Me.HasLoyaltyDiscount = hasLoyalty
    End Sub

    Private Sub btnSelectFirstTime_Click(sender As Object, e As EventArgs) Handles btnSelectFirstTime.Click
        If Not IsFirstTimeCustomer Then
            MessageBox.Show("This discount is only for first-time customers.", "Eligibility Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        SelectedVoucherDiscount = 0.1
        SelectedVoucherName = "First Time Customer - 10% Off"
        MessageBox.Show("Voucher selected: First Time Customer - 10% Off", "Selection Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnSelectSenior_Click(sender As Object, e As EventArgs) Handles btnSelectSenior.Click
        If CustomerAge < 60 Then
            MessageBox.Show("You must be at least 60 years old to claim the senior citizen discount.", "Eligibility Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        SelectedVoucherDiscount = 0.15
        SelectedVoucherName = "Senior Citizen Discount - 15% Off"
        MessageBox.Show("Voucher selected: Senior Citizen Discount - 15% Off", "Selection Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnSelectBirthday_Click(sender As Object, e As EventArgs) Handles btnSelectBirthday.Click
        If CustomerBirthday.Month <> Date.Today.Month Or CustomerBirthday.Day <> Date.Today.Day Then
            MessageBox.Show("This discount is only valid on your birthday.", "Eligibility Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        SelectedVoucherDiscount = 0.2
        SelectedVoucherName = "Birthday Discount - 20% Off"
        MessageBox.Show("Voucher selected: Birthday Discount - 20% Off", "Selection Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnSelectLoyalty_Click(sender As Object, e As EventArgs) Handles btnSelectLoyalty.Click
        If Not HasLoyaltyDiscount Then
            MessageBox.Show("You must have a booking history to claim the loyalty discount.", "Eligibility Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        SelectedVoucherDiscount = 0.12
        SelectedVoucherName = "Loyalty Discount - 12% Off"
        MessageBox.Show("Voucher selected: Loyalty Discount - 12% Off", "Selection Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Dim validReferralCodes As New HashSet(Of String) From {
        "REF12345", "DISCOUNT10", "SAVE2025", "WELCOME50", "VIPACCESS",
        "FRIEND10", "PROMO2025", "REFERME", "GETREWARD", "LOYALTY25"
    }

    Private Sub btnSelectReferral_Click(sender As Object, e As EventArgs) Handles btnSelectReferral.Click
        Dim enteredCode As String = txtReferralCode.Text.Trim().ToUpper()

        If String.IsNullOrWhiteSpace(enteredCode) Then
            MessageBox.Show("Please enter a referral code before applying the discount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not validReferralCodes.Contains(enteredCode) Then
            MessageBox.Show("Invalid referral code. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        SelectedVoucherDiscount = 0.05
        SelectedVoucherName = $"Referral Code Discount - 5% Off ({enteredCode})"
        MessageBox.Show($"Voucher selected: Referral Code Discount - 5% Off ({enteredCode})", "Selection Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnApplyVoucher_Click(sender As Object, e As EventArgs) Handles btnApplyVoucher.Click
        If String.IsNullOrEmpty(SelectedVoucherName) Then
            MessageBox.Show("Please select a voucher before applying.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        MessageBox.Show($"Voucher applied: {SelectedVoucherName}. Discount: {SelectedVoucherDiscount * 100}%", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        SelectedVoucherDiscount = 0
        SelectedVoucherName = ""
        MessageBox.Show("Voucher selection canceled.", "Action Reversed", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub




End Class
