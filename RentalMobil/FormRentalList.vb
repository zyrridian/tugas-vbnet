Imports MySql.Data.MySqlClient

Public Class FormRentalList

    ' Class untuk menyimpan data rental
    Private Class RentalData
        Public Property ID As String
        Public Property CustomerName As String
        Public Property Phone As String
        Public Property CarModel As String
        Public Property RentDate As Date
        Public Property ReturnDate As Date
        Public Property Duration As Integer
        Public Property TotalCost As Decimal
        Public Property Status As String
    End Class

    ' Daftar rental untuk simulasi data
    Private rentalList As New List(Of RentalData)

    ' Event saat form dimuat
    Private Sub FormRentalList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set default filter
        cmbFilter.SelectedIndex = 0 ' "All Status"

        ' Tampilkan data di DataGridView
        LoadRentalData()
    End Sub

    ' Method untuk membuat data dummy
    Private Sub CreateDummyData()
        rentalList.Clear()

        ' Tambahkan beberapa data rental dummy
        rentalList.Add(New RentalData() With {
            .ID = "R001",
            .CustomerName = "John Doe",
            .Phone = "081234567890",
            .CarModel = "Toyota Avanza",
            .RentDate = DateTime.Now.AddDays(-5),
            .ReturnDate = DateTime.Now.AddDays(2),
            .Duration = 7,
            .TotalCost = 700000,
            .Status = "Active"
        })

        rentalList.Add(New RentalData() With {
            .ID = "R002",
            .CustomerName = "Jane Smith",
            .Phone = "089876543210",
            .CarModel = "Honda Jazz",
            .RentDate = DateTime.Now.AddDays(-10),
            .ReturnDate = DateTime.Now.AddDays(-3),
            .Duration = 7,
            .TotalCost = 800000,
            .Status = "Completed"
        })

        rentalList.Add(New RentalData() With {
            .ID = "R003",
            .CustomerName = "Robert Johnson",
            .Phone = "087812345678",
            .CarModel = "Suzuki Ertiga",
            .RentDate = DateTime.Now.AddDays(-15),
            .ReturnDate = DateTime.Now.AddDays(-10),
            .Duration = 5,
            .TotalCost = 500000,
            .Status = "Completed"
        })

        rentalList.Add(New RentalData() With {
            .ID = "R004",
            .CustomerName = "Michael Brown",
            .Phone = "081122334455",
            .CarModel = "Daihatsu Xenia",
            .RentDate = DateTime.Now.AddDays(-3),
            .ReturnDate = DateTime.Now.AddDays(-1),
            .Duration = 2,
            .TotalCost = 200000,
            .Status = "Overdue"
        })

        rentalList.Add(New RentalData() With {
            .ID = "R005",
            .CustomerName = "Sarah Williams",
            .Phone = "089988776655",
            .CarModel = "Toyota Rush",
            .RentDate = DateTime.Now,
            .ReturnDate = DateTime.Now.AddDays(3),
            .Duration = 3,
            .TotalCost = 450000,
            .Status = "Active"
        })
    End Sub

    ' Method untuk memuat data rental ke DataGridView
    Private Sub LoadRentalData(Optional filter As String = "All Status", Optional searchText As String = "")
        dgvRentals.Rows.Clear()

        Try
            ' Buat query untuk mengambil data rental dari database
            Dim query As String = "SELECT r.id, p.nama AS customer_name, p.nomor_telepon AS phone, " & _
                                 "CONCAT(m.merk, ' ', m.tipe) AS car_model, r.tanggal_sewa, r.tanggal_kembali, " & _
                                 "r.lama_sewa, r.total_biaya, r.status " & _
                                 "FROM rental r " & _
                                 "JOIN pelanggan p ON r.pelanggan_id = p.id " & _
                                 "JOIN mobil m ON r.mobil_id = m.id " & _
                                 "WHERE 1=1 "
            
            ' Parameter untuk query
            Dim parameters As New Dictionary(Of String, Object)
            
            ' Filter berdasarkan status
            If filter <> "All Status" Then
                query &= " AND r.status = @status"
                parameters.Add("@status", filter)
            End If

            ' Filter berdasarkan teks pencarian
            If Not String.IsNullOrEmpty(searchText) Then
                query &= " AND (p.nama LIKE @search OR m.merk LIKE @search OR m.tipe LIKE @search OR r.id LIKE @search)"
                parameters.Add("@search", "%" & searchText & "%")
            End If
            
            ' Urutkan berdasarkan ID rental terbaru
            query &= " ORDER BY r.id DESC"
            
            ' Jalankan query
            Dim dt As DataTable = ModuleConnection.ExecuteQuery(query, parameters)

            ' Tambahkan data ke DataGridView
            For Each row As DataRow In dt.Rows
                Dim id As String = row("id").ToString()
                Dim customerName As String = row("customer_name").ToString()
                Dim phone As String = row("phone").ToString()
                Dim carModel As String = row("car_model").ToString()
                Dim rentDate As Date = Convert.ToDateTime(row("tanggal_sewa"))
                Dim returnDate As Date = Convert.ToDateTime(row("tanggal_kembali"))
                Dim duration As Integer = Convert.ToInt32(row("lama_sewa"))
                Dim totalCost As Decimal = Convert.ToDecimal(row("total_biaya"))
                Dim status As String = row("status").ToString()

                dgvRentals.Rows.Add(
                    id,
                    customerName,
                    phone,
                    carModel,
                    rentDate.ToString("dd/MM/yyyy"),
                    returnDate.ToString("dd/MM/yyyy"),
                    duration,
                    String.Format("Rp {0:N0}", totalCost),
                    status
                )

                ' Set warna baris berdasarkan status
                Dim rowIndex As Integer = dgvRentals.Rows.Count - 1
                Select Case status
                    Case "Active"
                        dgvRentals.Rows(rowIndex).Cells("colStatus").Style.ForeColor = Color.Green
                    Case "Completed"
                        dgvRentals.Rows(rowIndex).Cells("colStatus").Style.ForeColor = Color.Blue
                    Case "Cancelled"
                        dgvRentals.Rows(rowIndex).Cells("colStatus").Style.ForeColor = Color.Red
                End Select
            Next
            
            ' Update label status
            UpdateStatusLabels(dt)
            
        Catch ex As Exception
            MessageBox.Show("Error loading rental data: " & ex.Message & vbCrLf & "Using dummy data instead.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Jika terjadi error, gunakan data dummy
            CreateDummyData()
        End Try
    End Sub

    ' Method untuk memperbarui label status
    Private Sub UpdateStatusLabels(ByVal dt As DataTable)
        Try
            lblTotal.Text = "Total Rentals: " & dt.Rows.Count
            
            ' Hitung jumlah status Active
            Dim activeCount As Integer = 0
            Dim completedCount As Integer = 0
            
            For Each row As DataRow In dt.Rows
                Dim status As String = row("status").ToString()
                If status = "Active" Then
                    activeCount += 1
                ElseIf status = "Completed" Then
                    completedCount += 1
                End If
            Next
            
            lblActive.Text = "Active: " & activeCount
            lblCompleted.Text = "Completed: " & completedCount
            
        Catch ex As Exception
            ' Ignore label update errors
            lblTotal.Text = "Total Rentals: " & dt.Rows.Count
        End Try
    End Sub

    ' Event saat tombol Refresh diklik
    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        ' Muat ulang data
        LoadRentalData(cmbFilter.Text, txtSearch.Text)
    End Sub

    ' Event saat filter berubah
    Private Sub cmbFilter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFilter.SelectedIndexChanged
        ' Muat ulang data dengan filter baru
        LoadRentalData(cmbFilter.Text, txtSearch.Text)
    End Sub

    ' Event saat teks pencarian berubah
    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        ' Muat ulang data dengan teks pencarian baru
        LoadRentalData(cmbFilter.Text, txtSearch.Text)
    End Sub

    ' Event saat tombol Edit diklik
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Periksa apakah ada baris yang dipilih
        If dgvRentals.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih data rental yang akan diedit!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Ambil ID rental yang dipilih
        Dim selectedID As String = dgvRentals.SelectedRows(0).Cells("colRentalID").Value.ToString()

        ' Dalam implementasi nyata, buka form edit dengan data rental yang dipilih
        MessageBox.Show("Edit rental dengan ID: " & selectedID, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Event saat tombol Return Car diklik
    Private Sub btnReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturn.Click
        ' Periksa apakah ada baris yang dipilih
        If dgvRentals.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih data rental untuk pengembalian mobil!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Ambil ID rental yang dipilih
        Dim selectedID As String = dgvRentals.SelectedRows(0).Cells("colRentalID").Value.ToString()
        Dim status As String = dgvRentals.SelectedRows(0).Cells("colStatus").Value.ToString()

        ' Periksa status
        If status = "Completed" Then
            MessageBox.Show("Rental ini sudah selesai!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Konfirmasi pengembalian
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin memproses pengembalian mobil untuk rental " & selectedID & "?",
                                                   "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Try
                ' Get mobil_id dari rental yang dipilih
                Dim getMobilQuery As String = "SELECT mobil_id FROM rental WHERE id = @id"
                Dim getParams As New Dictionary(Of String, Object)
                getParams.Add("@id", selectedID)
                Dim mobilId As Object = ModuleConnection.ExecuteScalar(getMobilQuery, getParams)
                
                ' Update status rental di database
                Dim updateQuery As String = "UPDATE rental SET status = 'Completed', updated_at = NOW() WHERE id = @id"
                Dim parameters As New Dictionary(Of String, Object)
                parameters.Add("@id", selectedID)
                
                Dim rowAffected As Integer = ModuleConnection.ExecuteNonQuery(updateQuery, parameters)
                
                If rowAffected > 0 Then
                    ' Update status mobil menjadi Available
                    If mobilId IsNot Nothing Then
                        Dim updateMobilQuery As String = "UPDATE mobil SET status = 'Available' WHERE id = @id"
                        Dim mobilParams As New Dictionary(Of String, Object)
                        mobilParams.Add("@id", mobilId)
                        ModuleConnection.ExecuteNonQuery(updateMobilQuery, mobilParams)
                    End If
                    
                    ' Muat ulang data
                    LoadRentalData(cmbFilter.Text, txtSearch.Text)
                    MessageBox.Show("Pengembalian mobil berhasil diproses!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Gagal memproses pengembalian mobil.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Error processing return: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' Event saat tombol Delete diklik
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        ' Periksa apakah ada baris yang dipilih
        If dgvRentals.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih data rental yang akan dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Ambil ID rental yang dipilih
        Dim selectedID As String = dgvRentals.SelectedRows(0).Cells("colRentalID").Value.ToString()

        ' Konfirmasi penghapusan
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data rental " & selectedID & "?",
                                                   "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Try
                ' Get mobil_id dari rental yang dipilih
                Dim getMobilQuery As String = "SELECT mobil_id, status FROM rental WHERE id = @id"
                Dim getParams As New Dictionary(Of String, Object)
                getParams.Add("@id", selectedID)
                Dim dt As DataTable = ModuleConnection.ExecuteQuery(getMobilQuery, getParams)
                
                Dim mobilId As Object = Nothing
                Dim rentalStatus As String = "Completed"
                
                If dt.Rows.Count > 0 Then
                    mobilId = dt.Rows(0)("mobil_id")
                    rentalStatus = dt.Rows(0)("status").ToString()
                End If
                
                ' Hapus data dari database
                Dim deleteQuery As String = "DELETE FROM rental WHERE id = @id"
                Dim parameters As New Dictionary(Of String, Object)
                parameters.Add("@id", selectedID)
                
                Dim rowAffected As Integer = ModuleConnection.ExecuteNonQuery(deleteQuery, parameters)
                
                If rowAffected > 0 Then
                    ' Update status mobil menjadi Available jika status rental masih Active
                    If mobilId IsNot Nothing AndAlso rentalStatus = "Active" Then
                        Dim updateMobilQuery As String = "UPDATE mobil SET status = 'Available' WHERE id = @id"
                        Dim mobilParams As New Dictionary(Of String, Object)
                        mobilParams.Add("@id", mobilId)
                        ModuleConnection.ExecuteNonQuery(updateMobilQuery, mobilParams)
                    End If
                    
                    ' Muat ulang data
                    LoadRentalData(cmbFilter.Text, txtSearch.Text)
                    MessageBox.Show("Data rental berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Gagal menghapus data rental.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Error deleting data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' Event saat tombol Close diklik
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class