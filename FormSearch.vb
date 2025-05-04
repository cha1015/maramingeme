Imports MySql.Data.MySqlClient
Imports System.Data

Public Class FormSearch

    Public Property FilterVenueType As String
    Public Property FilterEventType As String
    Public Property FilterNumGuests As String
    Public Property FilterLocation As String
    Public Property FilterVenue As String

    Private Sub FormSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cbVenueType.Text = FilterVenueType
        cbEventType.Text = FilterEventType
        cbNumGuests.Text = FilterNumGuests
        cbLocation.Text = FilterLocation
        cbVenue.Text = FilterVenue

        LoadSearchResults()

    End Sub

    Private Sub FormSearch_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.ActiveControl = Nothing
    End Sub


    Private Sub LoadSearchResults()

        Dim query As String = "SELECT * FROM EventPlaces WHERE 1=1"
        If Not String.IsNullOrEmpty(FilterVenueType) Then
            query &= " AND venue_type = @venueType"
        End If
        If Not String.IsNullOrEmpty(FilterEventType) Then
            query &= " AND event_type = @eventType"
        End If
        If Not String.IsNullOrEmpty(FilterLocation) Then
            query &= " AND location = @location"
        End If
        If Not String.IsNullOrEmpty(FilterVenue) Then
            query &= " AND venue_name = @venueName"
        End If

        Dim numGuestsInt As Integer
        If Integer.TryParse(ExtractNumber(FilterNumGuests), numGuestsInt) Then
            query &= " AND capacity >= @numGuests"
        End If

        Dim dt As New DataTable()

        Using connection As MySqlConnection = DBHelper.GetConnection()
            Using cmd As New MySqlCommand(query, connection)
                If Not String.IsNullOrEmpty(FilterVenueType) Then
                    cmd.Parameters.AddWithValue("@venueType", FilterVenueType)
                End If
                If Not String.IsNullOrEmpty(FilterEventType) Then
                    cmd.Parameters.AddWithValue("@eventType", FilterEventType)
                End If
                If Not String.IsNullOrEmpty(FilterLocation) Then
                    cmd.Parameters.AddWithValue("@location", FilterLocation)
                End If
                If Not String.IsNullOrEmpty(FilterVenue) Then
                    cmd.Parameters.AddWithValue("@venueName", FilterVenue)
                End If
                If Integer.TryParse(ExtractNumber(FilterNumGuests), numGuestsInt) Then
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
                    MessageBox.Show("Error loading venues in FormSearch: " & ex.Message)
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

    Private Sub FilterSelectionChanged(sender As Object, e As EventArgs) Handles cbVenueType.SelectedIndexChanged, cbEventType.SelectedIndexChanged, cbNumGuests.SelectedIndexChanged, cbLocation.SelectedIndexChanged, cbVenue.SelectedIndexChanged
        Select Case sender.Name
            Case "cbVenueType"
                FilterVenueType = cbVenueType.SelectedItem.ToString()
            Case "cbEventType"
                FilterEventType = cbEventType.SelectedItem.ToString()
            Case "cbNumGuests"
                FilterNumGuests = cbNumGuests.Text
            Case "cbLocation"
                FilterLocation = cbLocation.SelectedItem.ToString()
            Case "cbVenue"
                FilterVenue = cbVenue.Text
        End Select
        LoadSearchResults()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadSearchResults()
    End Sub

    Private Function ExtractNumber(text As String) As String
        Dim num As String = System.Text.RegularExpressions.Regex.Match(text, "\d+").Value
        Return num
    End Function

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
