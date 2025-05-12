Imports MySql.Data.MySqlClient
Imports System.Data

Public Class FormMain

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlSignUpLogIn.Location = New Point(1314, 5)
        pnlAccount.Location = New Point(1092, 5)

        PopulateVenueCombo()
        LoadSearchResults()
        UpdatePanelVisibility()
    End Sub

    Private Sub UpdatePanelVisibility()
        If Not String.IsNullOrEmpty(CurrentUser.Username) Then
            pnlSignUpLogIn.Visible = False
            pnlAccount.Visible = True
            pnlAccount.BringToFront()
            lblUsername.Text = CurrentUser.Username
        Else
            pnlAccount.Visible = False
            pnlSignUpLogIn.Visible = True
            pnlSignUpLogIn.BringToFront()
        End If
    End Sub


    Private Sub FormMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.ActiveControl = Nothing
    End Sub

    Private Sub PopulateVenueCombo()
        Dim query As String = "SELECT DISTINCT event_place, opening_hours, closing_hours, available_days FROM eventplace ORDER BY event_place ASC"
        Using connection As MySqlConnection = DBHelper.GetConnection()
            Using cmd As New MySqlCommand(query, connection)
                Dim dt As New DataTable()
                Dim adapter As New MySqlDataAdapter(cmd)
                Try
                    connection.Open()
                    adapter.Fill(dt)
                Catch ex As Exception
                    MessageBox.Show("Error loading venue types: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub


    Private ReadOnly EventTypeMapping As New Dictionary(Of String, List(Of String)) From {
    {"Classes & Workshops", New List(Of String) From {"Cooking", "Fitness", "Coffee Workshop", "Tea Workshop"}},
    {"Corporate Event", New List(Of String) From {"Dining", "Party"}},
    {"Formal Meetings & Team Gatherings", New List(Of String) From {"Conference", "Interview", "Sales Meeting", "Team Meeting", "Offsite Meeting", "Team Bonding", "Training"}},
    {"Parties & Celebrations", New List(Of String) From {"Anniversary", "Baby Shower", "Birthday Party", "Holiday & Festive Celebrations", "Deepavali", "Hari Raya", "Year-End Party", "Graduation Party", "Dinner & Dance", "Lunch/Dinner", "Prom"}},
    {"Shoots & Productions", New List(Of String) From {"Green Screen Shoot", "Live Stream", "Live Webinar", "Photo Shoot", "Video Production"}},
    {"Weddings & Related Events", New List(Of String) From {"Bachelor/Bachelorette Party", "Bridal Shower", "Ceremony", "Engagement", "Proposal", "Reception", "Solemnization", "Wedding"}}
}


    Private Sub LoadSearchResults()
        Dim query As String = "SELECT * FROM eventplace WHERE 1=1"

        If cbAvailableOn.SelectedItem IsNot Nothing Then
            query &= " AND FIND_IN_SET(@available_day, available_days) > 0"
        End If

        Dim selectedEventTypes As New List(Of String)
        For Each selectedItem In clbEventType.CheckedItems
            Dim trimmedItem As String = selectedItem.ToString().Trim()

            If EventTypeMapping.ContainsKey(trimmedItem) Then
                selectedEventTypes.AddRange(EventTypeMapping(trimmedItem))
            Else
                selectedEventTypes.Add(trimmedItem)
            End If
        Next

        If selectedEventTypes.Count > 0 Then
            Dim typeConditions As New List(Of String)
            For Each eventType In selectedEventTypes
                typeConditions.Add($"event_type LIKE '%{eventType}%'")
            Next
            query &= " AND (" & String.Join(" OR ", typeConditions) & ")"
        End If

        Dim minCapacity, maxCapacity As Integer
        If Integer.TryParse(txtMinCapacity.Text, minCapacity) Then
            query &= " AND capacity >= @minCapacity"
        End If
        If Integer.TryParse(txtMaxCapacity.Text, maxCapacity) Then
            query &= " AND capacity <= @maxCapacity"
        End If

        Dim minPrice, maxPrice As Decimal
        If Decimal.TryParse(txtMinPrice.Text, minPrice) Then
            query &= " AND price_per_day >= @minPrice"
        End If
        If Decimal.TryParse(txtMaxPrice.Text, maxPrice) Then
            query &= " AND price_per_day <= @maxPrice"
        End If

        Dim sortColumn As String = ""
        Select Case cbSort.SelectedItem?.ToString()
            Case "Alphabetical"
                sortColumn = "event_place"
            Case "Capacity"
                sortColumn = "capacity"
            Case "Price"
                sortColumn = "price_per_day"
        End Select

        Dim sortDirection As String = If(cbSortDirection.SelectedItem?.ToString() = "Least to Greatest", "ASC", "DESC")
        If Not String.IsNullOrEmpty(sortColumn) Then
            query &= $" ORDER BY {sortColumn} {sortDirection}"
        End If


        Dim dt As New DataTable()
        Using connection As MySqlConnection = DBHelper.GetConnection()
            Using cmd As New MySqlCommand(query, connection)
                If Integer.TryParse(txtMinCapacity.Text, minCapacity) Then
                    cmd.Parameters.AddWithValue("@minCapacity", minCapacity)
                End If
                If Integer.TryParse(txtMaxCapacity.Text, maxCapacity) Then
                    cmd.Parameters.AddWithValue("@maxCapacity", maxCapacity)
                End If
                If Decimal.TryParse(txtMinPrice.Text, minPrice) Then
                    cmd.Parameters.AddWithValue("@minPrice", minPrice)
                End If
                If Decimal.TryParse(txtMaxPrice.Text, maxPrice) Then
                    cmd.Parameters.AddWithValue("@maxPrice", maxPrice)
                End If
                If cbAvailableOn.SelectedItem IsNot Nothing Then
                    cmd.Parameters.AddWithValue("@available_day", cbAvailableOn.SelectedItem.ToString())
                End If

                Dim adapter As New MySqlDataAdapter(cmd)
                Try
                    connection.Open()
                    dt.Clear()
                    adapter.Fill(dt)
                Catch ex As Exception
                    MessageBox.Show("Error loading venues: " & ex.Message)
                End Try
            End Using
        End Using

        flpResults.Controls.Clear()
        ResultsDisplayHelper.PopulateResults(flpResults, dt, AddressOf btnBook_Click)
    End Sub

    Private customerId As Integer = -1
    Public Sub SetCustomerId(newCustomerId As Integer)
        customerId = newCustomerId
    End Sub


    Private Sub btnBook_Click(sender As Object, e As EventArgs)
        If String.IsNullOrEmpty(CurrentUser.Username) Then
            MessageBox.Show("You need to log in to book an event place.", "Login Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Dim loginForm As New FormLogIn()
            loginForm.ShowDialog()
            Exit Sub
        End If

        Dim btn As Button = CType(sender, Button)
        Dim row As DataRow = CType(btn.Tag, DataRow)
        Dim placeId As Integer = CInt(row("place_id"))
        Dim capacity As Integer = CInt(row("capacity"))
        Dim pricePerDay As Decimal = CDec(row("price_per_day"))


        'If customerId <= 0 Then
        '    MessageBox.Show("Cannot proceed without a valid customer ID.")
        '    Return
        'End If

        Dim bookingForm As New FormBooking(customerId) With {
    .EventPlaceId = placeId,
    .EventPlaceName = row("event_place").ToString(),
    .EventPlaceCapacity = CInt(row("capacity")),
    .BasePricePerDay = CDec(row("price_per_day")),
    .EventPlaceFeatures = row("features").ToString(),
    .EventPlaceDescription = row("description").ToString(),
    .OpeningHours = row("opening_hours").ToString(),
    .ClosingHours = row("closing_hours").ToString(),
    .AvailableDays = row("available_days").ToString()
}


        bookingForm.ShowDialog()
        Me.Hide()

    End Sub


    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        LoadSearchResults()
    End Sub

    Private Sub btnCustomerView_Click(sender As Object, e As EventArgs) Handles btnCustomerView.Click
        Dim customerView As New FormCustomerView()
        customerView.Show()
        Me.Hide()
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Dim signUpForm As New FormSignUp()
        signUpForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        Dim loginForm As New FormLogIn()
        loginForm.ShowDialog()

        If Not String.IsNullOrEmpty(CurrentUser.Username) Then
            ' Force refresh of the UI
            UpdatePanelVisibility()
            Me.Refresh() ' This forces a UI update

            ' Bring FormMain to focus
            Me.BringToFront()
            Me.Focus()
        End If
    End Sub


    Private Sub txtField_Enter(sender As Object, e As EventArgs) Handles txtMinCapacity.Enter, txtMaxCapacity.Enter, txtMinPrice.Enter, txtMaxPrice.Enter
        Dim txt As TextBox = CType(sender, TextBox)
        If txt.Text = "Min" OrElse txt.Text = "Max" Then
            txt.Text = ""
        End If
    End Sub


    Private Sub txtField_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMinCapacity.KeyPress, txtMaxCapacity.KeyPress, txtMinPrice.KeyPress, txtMaxPrice.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchText As String = txtSearch.Text.Trim()

        'If String.IsNullOrWhiteSpace(searchText) Then
        '    MessageBox.Show("Please enter a search term.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    Exit Sub
        'End If

        Dim query As String = "SELECT * FROM eventplace WHERE event_place LIKE @search OR event_type LIKE @search"

        Dim dt As New DataTable()
        Using connection As MySqlConnection = DBHelper.GetConnection()
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@search", "%" & searchText & "%")

                Dim adapter As New MySqlDataAdapter(cmd)
                Try
                    connection.Open()
                    dt.Clear()
                    adapter.Fill(dt)
                Catch ex As Exception
                    MessageBox.Show("Error performing search: " & ex.Message)
                End Try
            End Using
        End Using

        flpResults.Controls.Clear()
        ResultsDisplayHelper.PopulateResults(flpResults, dt, AddressOf btnBook_Click)
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnSearch.PerformClick()
        End If
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        CurrentUser.Username = String.Empty ' Clear logged-in user
        pnlSignUpLogIn.Visible = True ' Show login options again
        btnSignUp.Visible = True
        btnLogIn.Visible = True
        btnCustomerView.Visible = False
        UpdatePanelVisibility()
    End Sub


End Class
