<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
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
        Me.btnSignUp = New System.Windows.Forms.Button()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbNumGuests = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.cbEventType = New System.Windows.Forms.ComboBox()
        Me.pnlFilter = New System.Windows.Forms.Panel()
        Me.lblSearchFilters = New System.Windows.Forms.Label()
        Me.cbVenueType = New System.Windows.Forms.ComboBox()
        Me.lblVenueType = New System.Windows.Forms.Label()
        Me.cbLocation = New System.Windows.Forms.ComboBox()
        Me.flpResults = New System.Windows.Forms.FlowLayoutPanel()
        Me.cbVenue = New System.Windows.Forms.ComboBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.pnlFilter.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSignUp
        '
        Me.btnSignUp.Location = New System.Drawing.Point(1197, 25)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(99, 33)
        Me.btnSignUp.TabIndex = 0
        Me.btnSignUp.Text = "Sign Up"
        Me.btnSignUp.UseVisualStyleBackColor = True
        '
        'btnLogIn
        '
        Me.btnLogIn.Location = New System.Drawing.Point(1303, 25)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(99, 33)
        Me.btnLogIn.TabIndex = 1
        Me.btnLogIn.Text = "Log In"
        Me.btnLogIn.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(1092, 25)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(99, 33)
        Me.btnSearch.TabIndex = 17
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Number of Guests"
        '
        'cbNumGuests
        '
        Me.cbNumGuests.FormattingEnabled = True
        Me.cbNumGuests.Items.AddRange(New Object() {"Up to 5 pax", "6 - 25 pax", "26 - 50 pax", "51 - 100 pax", "101 - 150 pax", "151 - 200 pax", "201 - 250 pax", "251 - 300 pax", "300 pax and above"})
        Me.cbNumGuests.Location = New System.Drawing.Point(34, 203)
        Me.cbNumGuests.Name = "cbNumGuests"
        Me.cbNumGuests.Size = New System.Drawing.Size(247, 21)
        Me.cbNumGuests.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Type of Event"
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Location = New System.Drawing.Point(34, 237)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(48, 13)
        Me.lblLocation.TabIndex = 3
        Me.lblLocation.Text = "Location"
        '
        'cbEventType
        '
        Me.cbEventType.FormattingEnabled = True
        Me.cbEventType.Items.AddRange(New Object() {"Classes", "     Cooking", "     Fitness", "     Workshop", "     Yoga", "Corporate Event", "     Dining", "     Large Scale", "     Party", "     Small Scale", "Formal Meeting", "     Board Meeting", "     Client Meeting", "     Conference", "     Interview", "     Meeting", "     Sales Meeting", "Party", "     After Party", "     After Prom", "     Anniversary", "     Baby Shower", "     Baptismal", "     Birthday Party", "     Chinese New Year", "     Christmas Party", "     Deepavali", "     Dinner and Dance", "     Graduation Party", "     Halloween Party", "     Hari Raya", "     Lunch/Dinner", "     Prom", "     Year End Party", "Shoots", "     3D Virtual Studio Production", "     Fashion Shoot", "     Film", "     Green Screen Shoot", "     Live Stream", "     Live Webinar", "     Photo Shoot", "     Video Production", "     Video Shoot", "Team Meeting", "     Offsite Meeting", "     Team Bonding", "     Training", "Wedding", "     Bachelor Party", "     Bachelorette Party", "     Bridal Shower", "     Ceremony", "     Engagement", "     Proposal", "     Reception", "     Solemnization", "     Wedding", "Workshops", "     Art", "     Candle Making Workshop", "     Coffee Workshop", "     Cooking Workshop", "     Flower Workshop", "     Leather", "     Perfume", "     Tea", "     Tea Workshop"})
        Me.cbEventType.Location = New System.Drawing.Point(34, 143)
        Me.cbEventType.Name = "cbEventType"
        Me.cbEventType.Size = New System.Drawing.Size(247, 21)
        Me.cbEventType.TabIndex = 4
        '
        'pnlFilter
        '
        Me.pnlFilter.Controls.Add(Me.lblSearchFilters)
        Me.pnlFilter.Controls.Add(Me.cbVenueType)
        Me.pnlFilter.Controls.Add(Me.lblVenueType)
        Me.pnlFilter.Controls.Add(Me.cbEventType)
        Me.pnlFilter.Controls.Add(Me.cbLocation)
        Me.pnlFilter.Controls.Add(Me.lblLocation)
        Me.pnlFilter.Controls.Add(Me.Label2)
        Me.pnlFilter.Controls.Add(Me.cbNumGuests)
        Me.pnlFilter.Controls.Add(Me.Label3)
        Me.pnlFilter.Location = New System.Drawing.Point(1092, 64)
        Me.pnlFilter.Name = "pnlFilter"
        Me.pnlFilter.Size = New System.Drawing.Size(310, 681)
        Me.pnlFilter.TabIndex = 15
        '
        'lblSearchFilters
        '
        Me.lblSearchFilters.AutoSize = True
        Me.lblSearchFilters.Location = New System.Drawing.Point(34, 21)
        Me.lblSearchFilters.Name = "lblSearchFilters"
        Me.lblSearchFilters.Size = New System.Drawing.Size(71, 13)
        Me.lblSearchFilters.TabIndex = 20
        Me.lblSearchFilters.Text = "Search Filters"
        '
        'cbVenueType
        '
        Me.cbVenueType.FormattingEnabled = True
        Me.cbVenueType.Items.AddRange(New Object() {"Auditorium", "Ballroom", "Banquet", "Bar", "Cafe", "Club", "Co-Working Space", "Conference Hall", "Country Club", "Event Space", "Function Room", "Gallery", "Halal Venue", "Hotel", "Kids Friendly Venue", "MICE Venue", "Meeting Room", "Museum", "Outdoor Venue", "Private Estate", "Restaurant", "Rooftop Venue", "Seminar Room", "Studio", "Theater", "Training Room", "Unique Venue", "Yacht"})
        Me.cbVenueType.Location = New System.Drawing.Point(34, 83)
        Me.cbVenueType.Name = "cbVenueType"
        Me.cbVenueType.Size = New System.Drawing.Size(247, 21)
        Me.cbVenueType.TabIndex = 18
        '
        'lblVenueType
        '
        Me.lblVenueType.AutoSize = True
        Me.lblVenueType.Location = New System.Drawing.Point(34, 57)
        Me.lblVenueType.Name = "lblVenueType"
        Me.lblVenueType.Size = New System.Drawing.Size(65, 13)
        Me.lblVenueType.TabIndex = 19
        Me.lblVenueType.Text = "Venue Type"
        '
        'cbLocation
        '
        Me.cbLocation.FormattingEnabled = True
        Me.cbLocation.Items.AddRange(New Object() {"Region 1 - Ilocos Region", "    Ilocos Norte", "        Laoag City", "    Ilocos Sur", "        Vigan City", "        Candon City", "    La Union", "        San Fernando City", "    Pangasinan", "        Dagupan City", "        San Carlos City", "        Urdaneta City", "        Alaminos City", "Region 2 - Cagayan Valley", "    Batanes", "        Basco", "    Cagayan", "        Tuguegarao City", "    Isabela", "        Ilagan City", "        Cauayan City", "        Santiago City", "    Nueva Vizcaya", "        Bayombong", "    Quirino", "        Cabarroguis", "Region 3 - Central Luzon", "    Aurora", "        Baler", "    Bataan", "        Balanga City", "    Bulacan", "        Malolos City", "        San Jose del Monte City", "        Meycauayan City", "    Nueva Ecija", "        Cabanatuan City", "        Gapan City", "        San Jose City", "    Pampanga", "        Angeles City", "        San Fernando City", "    Tarlac", "        Tarlac City", "    Zambales", "        Olongapo City", "Region 4-A - CALABARZON", "    Cavite", "        Tagaytay City", "        Trece Martires City", "        Dasmariñas City", "        Bacoor City", "        Imus City", "    Laguna", "        Santa Rosa City", "        San Pablo City", "        Calamba City", "        Biñan City", "    Batangas", "        Batangas City", "        Lipa City", "        Tanauan City", "    Rizal", "        Antipolo City", "    Quezon", "        Lucena City", "        Tayabas City", "Region 4-B - MIMAROPA", "    Occidental Mindoro", "        San Jose", "    Oriental Mindoro", "        Calapan City", "    Marinduque", "        Boac", "    Romblon", "        Romblon", "    Palawan", "        Puerto Princesa City", "Region 5 - Bicol Region", "    Albay", "        Legazpi City", "        Ligao City", "        Tabaco City", "    Camarines Norte", "        Daet", "    Camarines Sur", "        Naga City", "        Iriga City", "    Catanduanes", "        Virac", "    Masbate", "        Masbate City", "    Sorsogon", "        Sorsogon City", "Region 6 - Western Visayas", "    Aklan", "        Kalibo", "    Antique", "        San Jose de Buenavista", "    Capiz", "        Roxas City", "    Guimaras", "        Jordan", "    Iloilo", "        Iloilo City", "        Passi City", "    Negros Occidental", "        Bacolod City", "        Silay City", "        Talisay City", "Region 7 - Central Visayas", "    Bohol", "        Tagbilaran City", "    Cebu", "        Cebu City", "        Lapu-Lapu City", "        Mandaue City", "        Talisay City", "    Negros Oriental", "        Dumaguete City", "        Bayawan City", "    Siquijor", "        Siquijor", "Region 8 - Eastern Visayas", "    Biliran", "        Naval", "    Eastern Samar", "        Borongan City", "    Leyte", "        Tacloban City", "        Ormoc City", "    Northern Samar", "        Catarman", "    Samar (Western Samar)", "        Calbayog City", "        Catbalogan City", "    Southern Leyte", "        Maasin City", "Region 9 - Zamboanga Peninsula", "    Zamboanga del Norte", "        Dipolog City", "        Dapitan City", "    Zamboanga del Sur", "        Pagadian City", "    Zamboanga Sibugay", "        Ipil", "Region 10 - Northern Mindanao", "    Bukidnon", "        Malaybalay City", "        Valencia City", "    Camiguin", "        Mambajao", "    Lanao del Norte", "        Iligan City", "    Misamis Occidental", "        Oroquieta City", "        Tangub City", "        Ozamiz City", "    Misamis Oriental", "        Cagayan de Oro City", "        Gingoog City", "Region 11 - Davao Region", "    Davao de Oro", "        Compostela", "    Davao del Norte", "        Tagum City", "        Panabo City", "        Samal City", "    Davao del Sur", "        Davao City", "    Davao Occidental", "        Malita", "    Davao Oriental", "        Mati City", "Region 12 - SOCCSKSARGEN", "    Cotabato", "        Kidapawan City", "    Sarangani", "        Alabel", "    South Cotabato", "        Koronadal City", "        General Santos City", "    Sultan Kudarat", "        Tacurong City", "Region 13 - Caraga", "    Agusan del Norte", "        Butuan City", "        Cabadbaran City", "    Agusan del Sur", "        Bayugan City", "    Dinagat Islands", "        San Jose", "    Surigao del Norte", "        Surigao City", "    Surigao del Sur", "        Tandag City", "        Bislig City", "CAR - Cordillera Administrative Region", "    Abra", "        Bangued", "    Apayao", "        Kabugao", "    Benguet", "        La Trinidad", "    Ifugao", "        Lagawe", "    Kalinga", "        Tabuk City", "    Mountain Province", "        Bontoc", "NCR - National Capital Region", "    Manila", "    Quezon City", "    Caloocan City", "    Las Piñas City", "    Makati City", "    Malabon City", "    Mandaluyong City", "    Marikina City", "    Muntinlupa City", "    Navotas City", "    Parañaque City", "    Pasay City", "    Pasig City", "    San Juan City", "    Taguig City", "    Valenzuela City", "BARMM - Bangsamoro Autonomous Region in Muslim Mindanao", "    Basilan", "        Isabela City", "        Lamitan City", "    Lanao del Sur", "        Marawi City", "    Maguindanao", "        Cotabato City", "    Sulu", "        Jolo", "    Tawi-Tawi", "        Bongao"})
        Me.cbLocation.Location = New System.Drawing.Point(34, 263)
        Me.cbLocation.Name = "cbLocation"
        Me.cbLocation.Size = New System.Drawing.Size(247, 21)
        Me.cbLocation.TabIndex = 2
        '
        'flpResults
        '
        Me.flpResults.AutoScroll = True
        Me.flpResults.Location = New System.Drawing.Point(23, 64)
        Me.flpResults.Name = "flpResults"
        Me.flpResults.Size = New System.Drawing.Size(1063, 681)
        Me.flpResults.TabIndex = 18
        '
        'cbVenue
        '
        Me.cbVenue.FormattingEnabled = True
        Me.cbVenue.Items.AddRange(New Object() {"Region 1 - Ilocos Region", "    Ilocos Norte", "        Laoag City", "    Ilocos Sur", "        Vigan City", "        Candon City", "    La Union", "        San Fernando City", "    Pangasinan", "        Dagupan City", "        San Carlos City", "        Urdaneta City", "        Alaminos City", "Region 2 - Cagayan Valley", "    Batanes", "        Basco", "    Cagayan", "        Tuguegarao City", "    Isabela", "        Ilagan City", "        Cauayan City", "        Santiago City", "    Nueva Vizcaya", "        Bayombong", "    Quirino", "        Cabarroguis", "Region 3 - Central Luzon", "    Aurora", "        Baler", "    Bataan", "        Balanga City", "    Bulacan", "        Malolos City", "        San Jose del Monte City", "        Meycauayan City", "    Nueva Ecija", "        Cabanatuan City", "        Gapan City", "        San Jose City", "    Pampanga", "        Angeles City", "        San Fernando City", "    Tarlac", "        Tarlac City", "    Zambales", "        Olongapo City", "Region 4-A - CALABARZON", "    Cavite", "        Tagaytay City", "        Trece Martires City", "        Dasmariñas City", "        Bacoor City", "        Imus City", "    Laguna", "        Santa Rosa City", "        San Pablo City", "        Calamba City", "        Biñan City", "    Batangas", "        Batangas City", "        Lipa City", "        Tanauan City", "    Rizal", "        Antipolo City", "    Quezon", "        Lucena City", "        Tayabas City", "Region 4-B - MIMAROPA", "    Occidental Mindoro", "        San Jose", "    Oriental Mindoro", "        Calapan City", "    Marinduque", "        Boac", "    Romblon", "        Romblon", "    Palawan", "        Puerto Princesa City", "Region 5 - Bicol Region", "    Albay", "        Legazpi City", "        Ligao City", "        Tabaco City", "    Camarines Norte", "        Daet", "    Camarines Sur", "        Naga City", "        Iriga City", "    Catanduanes", "        Virac", "    Masbate", "        Masbate City", "    Sorsogon", "        Sorsogon City", "Region 6 - Western Visayas", "    Aklan", "        Kalibo", "    Antique", "        San Jose de Buenavista", "    Capiz", "        Roxas City", "    Guimaras", "        Jordan", "    Iloilo", "        Iloilo City", "        Passi City", "    Negros Occidental", "        Bacolod City", "        Silay City", "        Talisay City", "Region 7 - Central Visayas", "    Bohol", "        Tagbilaran City", "    Cebu", "        Cebu City", "        Lapu-Lapu City", "        Mandaue City", "        Talisay City", "    Negros Oriental", "        Dumaguete City", "        Bayawan City", "    Siquijor", "        Siquijor", "Region 8 - Eastern Visayas", "    Biliran", "        Naval", "    Eastern Samar", "        Borongan City", "    Leyte", "        Tacloban City", "        Ormoc City", "    Northern Samar", "        Catarman", "    Samar (Western Samar)", "        Calbayog City", "        Catbalogan City", "    Southern Leyte", "        Maasin City", "Region 9 - Zamboanga Peninsula", "    Zamboanga del Norte", "        Dipolog City", "        Dapitan City", "    Zamboanga del Sur", "        Pagadian City", "    Zamboanga Sibugay", "        Ipil", "Region 10 - Northern Mindanao", "    Bukidnon", "        Malaybalay City", "        Valencia City", "    Camiguin", "        Mambajao", "    Lanao del Norte", "        Iligan City", "    Misamis Occidental", "        Oroquieta City", "        Tangub City", "        Ozamiz City", "    Misamis Oriental", "        Cagayan de Oro City", "        Gingoog City", "Region 11 - Davao Region", "    Davao de Oro", "        Compostela", "    Davao del Norte", "        Tagum City", "        Panabo City", "        Samal City", "    Davao del Sur", "        Davao City", "    Davao Occidental", "        Malita", "    Davao Oriental", "        Mati City", "Region 12 - SOCCSKSARGEN", "    Cotabato", "        Kidapawan City", "    Sarangani", "        Alabel", "    South Cotabato", "        Koronadal City", "        General Santos City", "    Sultan Kudarat", "        Tacurong City", "Region 13 - Caraga", "    Agusan del Norte", "        Butuan City", "        Cabadbaran City", "    Agusan del Sur", "        Bayugan City", "    Dinagat Islands", "        San Jose", "    Surigao del Norte", "        Surigao City", "    Surigao del Sur", "        Tandag City", "        Bislig City", "CAR - Cordillera Administrative Region", "    Abra", "        Bangued", "    Apayao", "        Kabugao", "    Benguet", "        La Trinidad", "    Ifugao", "        Lagawe", "    Kalinga", "        Tabuk City", "    Mountain Province", "        Bontoc", "NCR - National Capital Region", "    Manila", "    Quezon City", "    Caloocan City", "    Las Piñas City", "    Makati City", "    Malabon City", "    Mandaluyong City", "    Marikina City", "    Muntinlupa City", "    Navotas City", "    Parañaque City", "    Pasay City", "    Pasig City", "    San Juan City", "    Taguig City", "    Valenzuela City", "BARMM - Bangsamoro Autonomous Region in Muslim Mindanao", "    Basilan", "        Isabela City", "        Lamitan City", "    Lanao del Sur", "        Marawi City", "    Maguindanao", "        Cotabato City", "    Sulu", "        Jolo", "    Tawi-Tawi", "        Bongao"})
        Me.cbVenue.Location = New System.Drawing.Point(277, 32)
        Me.cbVenue.Name = "cbVenue"
        Me.cbVenue.Size = New System.Drawing.Size(809, 21)
        Me.cbVenue.TabIndex = 21
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
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1424, 771)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.cbVenue)
        Me.Controls.Add(Me.flpResults)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.pnlFilter)
        Me.Controls.Add(Me.btnLogIn)
        Me.Controls.Add(Me.btnSignUp)
        Me.Name = "FormMain"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.pnlFilter.ResumeLayout(False)
        Me.pnlFilter.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSignUp As Button
    Friend WithEvents btnLogIn As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents cbNumGuests As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblLocation As Label
    Friend WithEvents cbEventType As ComboBox
    Friend WithEvents pnlFilter As Panel
    Friend WithEvents cbLocation As ComboBox
    Friend WithEvents cbVenueType As ComboBox
    Friend WithEvents lblVenueType As Label
    Friend WithEvents flpResults As FlowLayoutPanel
    Friend WithEvents lblSearchFilters As Label
    Friend WithEvents cbVenue As ComboBox
    Friend WithEvents btnNext As Button
    Friend WithEvents btnBack As Button
End Class
