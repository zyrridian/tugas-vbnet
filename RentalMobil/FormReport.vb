Imports MySql.Data.MySqlClient

Public Class FormReport

    ' Class untuk menyimpan data rental
    Private Class RentalData
        Public Property ID As Integer
        Public Property Customer As String
        Public Property Phone As String
        Public Property Mobil As String
        Public Property TglSewa As Date
        Public Property TglKembali As Date
        Public Property Durasi As Integer
        Public Property Biaya As Decimal
    End Class

    ' List untuk menyimpan semua data rental
    'Private rentalData As New List(Of RentalData)

    ' Event saat form dimuat
    Private Sub FormReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set default date range (30 hari terakhir)
        dtpAwal.Value = DateTime.Now.AddDays(-30)
        dtpAkhir.Value = DateTime.Now

        ' Inisialisasi combobox tahun
        InitYearComboBox()

        ' Tampilkan data rental di DataGridView
        LoadRentalData()

        ' Tampilkan grafik pendapatan
        LoadRevenueChart()
    End Sub

    ' Inisialisasi combobox tahun dengan tahun saat ini dan 5 tahun ke belakang
    Private Sub InitYearComboBox()
        cmbTahun.Items.Clear()
        Dim currentYear As Integer = DateTime.Now.Year
        For i As Integer = 0 To 5
            cmbTahun.Items.Add((currentYear - i).ToString())
        Next
        cmbTahun.SelectedIndex = 0
    End Sub

    ' Buat data dummy untuk simulasi laporan
    Private Sub CreateDummyData()
        'rentalData.Clear()
        Dim rnd As New Random()
        
        ' Daftar mobil untuk data dummy
        Dim carList As String() = {"Avanza", "Xenia", "Innova", "Toyota Fortuner", "Honda Brio", "Honda HR-V"}
        
        ' Nama pelanggan untuk data dummy
        Dim nameList As String() = {"Budi Santoso", "Dewi Lestari", "Ahmad Wijaya", "Siti Rahayu", "Rudi Hartono", 
                                    "Nina Saputri", "Andi Prasetya", "Wati Susanti", "Doni Kusuma", "Maya Anggraini"}
        
        ' Buat 20 data rental dummy
        For i As Integer = 1 To 20
            Dim startDate As Date = DateTime.Now.AddDays(-rnd.Next(1, 60))
            Dim duration As Integer = rnd.Next(1, 15)
            'Dim data As New RentalData With {
            '    .ID = i,
            '   .Customer = nameList(rnd.Next(0, nameList.Length)),
            '   .Phone = "08" & rnd.Next(10000000, 99999999).ToString(),
            '  .Mobil = carList(rnd.Next(0, carList.Length)),
            '  .TglSewa = startDate,
            '   .TglKembali = startDate.AddDays(duration),
            '   .Durasi = duration,
            '.Biaya = duration * rnd.Next(200000, 700000)
            '  }
            '  rentalData.Add(data)
        Next
    End Sub

    ' Load dan filter data rental ke DataGridView
    Private Sub LoadRentalData(Optional filterStartDate As Date? = Nothing, Optional filterEndDate As Date? = Nothing)
        Dim startDate As Date = If(filterStartDate.HasValue, filterStartDate.Value, dtpAwal.Value)
        Dim endDate As Date = If(filterEndDate.HasValue, filterEndDate.Value, dtpAkhir.Value)
        
        ' Set endDate ke akhir hari
        endDate = endDate.AddHours(23).AddMinutes(59).AddSeconds(59)

        ' Clear DataGridView
        dgvRentalReport.Rows.Clear()
        
        Try
            ' Buat query untuk mengambil data rental berdasarkan tanggal
            Dim query As String = "SELECT r.id, p.nama AS customer_name, p.nomor_telepon AS phone, " & _
                               "CONCAT(m.merk, ' ', m.tipe) AS car_model, m.plat_nomor, " & _
                               "r.tanggal_sewa, r.tanggal_kembali, r.lama_sewa, r.total_biaya, r.status " & _
                               "FROM rental r " & _
                               "JOIN pelanggan p ON r.pelanggan_id = p.id " & _
                               "JOIN mobil m ON r.mobil_id = m.id " & _
                               "WHERE r.tanggal_sewa BETWEEN @start_date AND @end_date " & _
                               "ORDER BY r.tanggal_sewa DESC"
            
            ' Parameter untuk query
            Dim parameters As New Dictionary(Of String, Object)
            parameters.Add("@start_date", startDate)
            parameters.Add("@end_date", endDate)
            
            ' Jalankan query
            Dim dt As DataTable = ModuleConnection.ExecuteQuery(query, parameters)
            
            ' Variabel untuk menghitung total pendapatan
            Dim totalPendapatan As Decimal = 0
            
            ' Tambahkan data ke DataGridView
            For Each row As DataRow In dt.Rows
                Dim id As String = row("id").ToString()
                Dim customerName As String = row("customer_name").ToString()
                Dim carModel As String = row("car_model").ToString()
                Dim rentDate As Date = Convert.ToDateTime(row("tanggal_sewa"))
                Dim returnDate As Date = Convert.ToDateTime(row("tanggal_kembali"))
                Dim duration As Integer = Convert.ToInt32(row("lama_sewa"))
                Dim totalCost As Decimal = Convert.ToDecimal(row("total_biaya"))
                
                dgvRentalReport.Rows.Add(
                    id,
                    customerName,
                    carModel,
                    rentDate.ToShortDateString(),
                    returnDate.ToShortDateString(),
                    duration & " hari",
                    String.Format("Rp {0:N0}", totalCost)
                )
                
                ' Jumlahkan pendapatan
                totalPendapatan += totalCost
            Next
            
            ' Update label total pendapatan
            lblTotal.Text = "Total Pendapatan : " & String.Format("Rp {0:N0}", totalPendapatan)
            
        Catch ex As Exception
            MessageBox.Show("Error loading rental data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblTotal.Text = "Total Pendapatan : " & String.Format("Rp {0:N0}", 0)
        End Try
    End Sub

    ' Load data pendapatan untuk grafik
    Private Sub LoadRevenueChart(Optional year As Integer? = Nothing)
        Dim targetYear As Integer = If(year.HasValue, year.Value, DateTime.Now.Year)
        
        ' Persiapan chart
        chartPendapatan.Series(0).Points.Clear()
        chartPendapatan.Series(0).Name = "Pendapatan " & targetYear
        chartPendapatan.ChartAreas(0).AxisX.Title = "Bulan"
        chartPendapatan.ChartAreas(0).AxisY.Title = "Pendapatan (Rp)"
        
        ' Nama bulan
        Dim months As String() = {"Jan", "Feb", "Mar", "Apr", "Mei", "Jun", "Jul", "Ags", "Sep", "Okt", "Nov", "Des"}
        
        Try
            ' Hitung pendapatan per bulan dari database
            For month As Integer = 1 To 12
                ' Tanggal awal dan akhir bulan
                Dim startDate As New DateTime(targetYear, month, 1)
                Dim endDate As DateTime = startDate.AddMonths(1).AddDays(-1)
                
                ' Query untuk menghitung total pendapatan pada bulan tertentu
                Dim query As String = "SELECT COALESCE(SUM(total_biaya), 0) AS monthly_revenue " & _
                                    "FROM rental " & _
                                    "WHERE tanggal_sewa BETWEEN @start_date AND @end_date"
                
                ' Parameter untuk query
                Dim parameters As New Dictionary(Of String, Object)
                parameters.Add("@start_date", startDate)
                parameters.Add("@end_date", endDate)
                
                ' Jalankan query
                Dim result As Object = ModuleConnection.ExecuteScalar(query, parameters)
                Dim monthlyRevenue As Decimal = 0
                
                If result IsNot Nothing AndAlso Not Convert.IsDBNull(result) Then
                    monthlyRevenue = Convert.ToDecimal(result)
                End If
                
                ' Tambahkan data ke chart
                chartPendapatan.Series(0).Points.AddXY(months(month - 1), monthlyRevenue)
            Next
            
        Catch ex As Exception
            MessageBox.Show("Error loading revenue chart: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            
            ' Jika terjadi error, tambahkan data random untuk visualisasi
            Dim rnd As New Random()
            For month As Integer = 0 To 11
                chartPendapatan.Series(0).Points.AddXY(months(month), rnd.Next(1000000, 5000000))
            Next
        End Try

        ' Format tampilan chart
        chartPendapatan.Series(0).Color = System.Drawing.Color.FromArgb(41, 128, 185)
        chartPendapatan.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Column
    End Sub

    ' Event saat tombol filter pada tab laporan diklik
    Private Sub btnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilter.Click
        ' Validasi range tanggal
        If dtpAwal.Value > dtpAkhir.Value Then
            MessageBox.Show("Tanggal awal tidak boleh lebih besar dari tanggal akhir!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        
        ' Load data dengan filter
        LoadRentalData(dtpAwal.Value, dtpAkhir.Value)
    End Sub

    ' Event saat tombol filter pada tab grafik diklik
    Private Sub btnFilterGrafik_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilterGrafik.Click
        If cmbTahun.SelectedIndex < 0 Then
            MessageBox.Show("Silakan pilih tahun terlebih dahulu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        
        Dim selectedYear As Integer = Integer.Parse(cmbTahun.SelectedItem.ToString())
        LoadRevenueChart(selectedYear)
    End Sub

    ' Event saat tombol cetak diklik
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        ' Implementasi cetak laporan
        Try
            ' Export data ke format yang bisa dicetak (Excel, PDF, dll.)
            ' Contoh implementasi export ke CSV
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "CSV File (*.csv)|*.csv"
            saveFileDialog.Title = "Export Report Data"
            saveFileDialog.FileName = "Rental_Report_" & DateTime.Now.ToString("yyyyMMdd")
            
            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                Dim filePath As String = saveFileDialog.FileName
                
                ' Export data dari DataGridView ke CSV
                Using writer As New System.IO.StreamWriter(filePath)
                    ' Write header
                    Dim headers As New List(Of String)
                    For Each col As DataGridViewColumn In dgvRentalReport.Columns
                        headers.Add(col.HeaderText)
                    Next
                    writer.WriteLine(String.Join(",", headers))
                    
                    ' Write rows
                    For Each row As DataGridViewRow In dgvRentalReport.Rows
                        Dim cells As New List(Of String)
                        For Each cell As DataGridViewCell In row.Cells
                            ' Wrap with quotes to handle commas in data
                            cells.Add("""" & If(cell.Value IsNot Nothing, cell.Value.ToString(), "") & """")
                        Next
                        writer.WriteLine(String.Join(",", cells))
                    Next
                End Using
                
                MessageBox.Show("Data berhasil diekspor ke " & filePath, "Export Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error exporting data: " & ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Event saat tombol tutup diklik
    Private Sub btnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub
    
End Class