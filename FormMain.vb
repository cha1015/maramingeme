Imports MySql.Data.MySqlClient
Imports System.Data

Public Class FormMain

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateVenueCombo()
        LoadSearchResults()
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.ActiveControl = Nothing
    End Sub

    Private Sub PopulateVenueCombo()
        Dim venueQuery As String = "SELECT DISTINCT venue_name FROM EventPlaces ORDER BY venue_name ASC"
        Using connection As MySqlConnection = DBHelper.GetConnection()
            Using cmd As New MySqlCommand(venueQuery, connection)
                Dim dt As New DataTable()
                Dim adapter As New MySqlDataAdapter(cmd)
                Try
                    connection.Open()
                    adapter.Fill(dt)
                    cbVenue.Items.Clear()
                    For Each row As DataRow In dt.Rows
                        cbVenue.Items.Add(row("venue_name").ToString())
                    Next
                Catch ex As Exception
                    MessageBox.Show("Error loading venues for filter: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub LoadSearchResults()

        Dim query As String = "SELECT * FROM EventPlaces WHERE 1=1"
        If Not String.IsNullOrEmpty(cbVenueType.Text) Then
            query &= " AND venue_type = @venueType"
        End If
        If Not String.IsNullOrEmpty(cbEventType.Text) Then
            query &= " AND event_type = @eventType"
        End If
        If Not String.IsNullOrEmpty(cbLocation.Text) Then
            query &= " AND location = @location"
        End If
        If Not String.IsNullOrEmpty(cbVenue.Text) Then
            query &= " AND venue_name = @venueName"
        End If

        Dim numGuestsInt As Integer
        If Integer.TryParse(ExtractNumber(cbNumGuests.Text), numGuestsInt) Then
            query &= " AND capacity >= @numGuests"
        End If

        Dim dt As New DataTable()

        Using connection As MySqlConnection = DBHelper.GetConnection()
            Using cmd As New MySqlCommand(query, connection)
                If Not String.IsNullOrEmpty(cbVenueType.Text) Then
                    cmd.Parameters.AddWithValue("@venueType", cbVenueType.Text)
                End If
                If Not String.IsNullOrEmpty(cbEventType.Text) Then
                    cmd.Parameters.AddWithValue("@eventType", cbEventType.Text)
                End If
                If Not String.IsNullOrEmpty(cbLocation.Text) Then
                    cmd.Parameters.AddWithValue("@location", cbLocation.Text)
                End If
                If Not String.IsNullOrEmpty(cbVenue.Text) Then
                    cmd.Parameters.AddWithValue("@venueName", cbVenue.Text)
                End If
                If Integer.TryParse(ExtractNumber(cbNumGuests.Text), numGuestsInt) Then
                    cmd.Parameters.AddWithValue("@numGuests", numGuestsInt)
                End If

                Dim adapter As New MySqlDataAdapter(cmd)
                Try
                    connection.Open()
                    dt.Clear()
                    Static executionCount As Integer = 0
                    executionCount += 1
                    'Debug.WriteLine("Query Execution Count: " & executionCount)

                    adapter.Fill(dt)
                    'Debug.WriteLine(query)

                Catch ex As Exception
                    MessageBox.Show("Error loading venues: " & ex.Message)
                End Try
            End Using
        End Using

        flpResults.Controls.Clear()
        ResultsDisplayHelper.PopulateResults(flpResults, dt, AddressOf btnBook_Click)


    End Sub

    Private Sub btnBook_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim row As DataRow = CType(btn.Tag, DataRow)
        Dim placeId As Integer = CInt(row("place_id"))
        Dim venueName As String = row("venue_name").ToString()
        Dim capacity As Integer = CInt(row("capacity"))
        Dim pricePerDay As Decimal = CDec(row("price_per_day"))

        Dim bookingForm As New FormBooking()
        bookingForm.EventPlaceId = placeId
        bookingForm.EventPlaceName = venueName
        bookingForm.EventPlaceCapacity = capacity
        bookingForm.BasePricePerDay = pricePerDay

        bookingForm.ShowDialog()
        Me.Hide()
    End Sub


    Private Function ExtractNumber(text As String) As String
        Dim num As String = System.Text.RegularExpressions.Regex.Match(text, "\d+").Value
        Return num
    End Function

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchForm As New FormSearch()

        searchForm.FilterVenueType = cbVenueType.Text
        searchForm.FilterEventType = cbEventType.Text
        searchForm.FilterNumGuests = cbNumGuests.Text
        searchForm.FilterLocation = cbLocation.Text
        searchForm.FilterVenue = cbVenue.Text

        searchForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Dim signUpForm As New FormSignUp()
        signUpForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        Dim loginForm As New FormLogIn()
        loginForm.Show()
        Me.Hide()
    End Sub
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim nextForm As New FormBooking()
        NavigationHelper.GoNext(Me, nextForm, btnNext, btnBack)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        NavigationHelper.GoBack(Me, btnNext, btnBack)
    End Sub



End Class
