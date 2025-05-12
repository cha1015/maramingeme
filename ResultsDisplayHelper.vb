Public Class ResultsDisplayHelper
    Public Shared Sub PopulateResults(flpResults As FlowLayoutPanel, dt As DataTable, btnClickHandler As EventHandler)
        Dim scrollbarWidth As Integer = SystemInformation.VerticalScrollBarWidth
        Dim availableWidth As Integer = 1063 - scrollbarWidth - (10 * 6)
        Dim panelWidth As Integer = availableWidth \ 3
        Dim panelHeight As Integer = 300

        flpResults.WrapContents = True
        flpResults.AutoScroll = True

        For Each row As DataRow In dt.Rows
            Dim panel As New Panel()
            panel.Size = New Size(panelWidth, panelHeight)
            panel.BorderStyle = BorderStyle.FixedSingle
            panel.Margin = New Padding(10)

            Dim pb As New PictureBox()
            pb.Size = New Size(panelWidth, 186)
            pb.Location = New Point(0, 0)
            pb.SizeMode = PictureBoxSizeMode.StretchImage

            Dim imageUrl As String = row("image_url").ToString()
            If Not String.IsNullOrEmpty(imageUrl) Then
                Try
                    pb.Load(imageUrl)
                Catch ex As Exception
                    pb.Image = Nothing
                End Try
            Else
                pb.Image = Nothing
            End If

            Dim lblName As New Label()
            lblName.AutoSize = False
            lblName.Size = New Size(panelWidth - 20, 26)
            lblName.Location = New Point(10, 185)
            lblName.Text = row("event_place").ToString()
            lblName.Font = New Font("Poppins", 12, FontStyle.Bold)

            Dim lblCapacity As New Label()
            lblCapacity.AutoSize = False
            lblCapacity.Size = New Size(panelWidth - 20, 24)
            lblCapacity.Location = New Point(10, 215)
            lblCapacity.Text = "Capacity: " & row("capacity").ToString()
            lblCapacity.Font = New Font("Poppins", 8)

            Dim lblPrice As New Label()
            lblPrice.AutoSize = False
            lblPrice.Size = New Size(panelWidth - 20, 24)
            lblPrice.Location = New Point(10, 239)
            lblPrice.Text = "Price per Day: " & row("price_per_day").ToString()
            lblPrice.Font = New Font("Poppins", 8)

            Dim lblEventType As New Label()
            lblEventType.AutoSize = False
            lblEventType.Size = New Size(panelWidth - 20, 24)
            lblEventType.Location = New Point(10, 263)
            lblEventType.Text = "Event Types: " & row("event_type").ToString()
            lblEventType.Font = New Font("Poppins", 8)
            lblEventType.ForeColor = Color.DarkGray

            Dim btnBook As New Button()
            btnBook.Text = "Book Now"
            btnBook.Size = New Size(80, 30)
            btnBook.Location = New Point(235, 233)
            btnBook.Tag = row

            AddHandler btnBook.Click, btnClickHandler

            panel.Controls.Add(btnBook)
            panel.Controls.Add(pb)
            panel.Controls.Add(lblName)
            panel.Controls.Add(lblCapacity)
            panel.Controls.Add(lblPrice)
            panel.Controls.Add(lblEventType)

            flpResults.Controls.Add(panel)
        Next
    End Sub
End Class
