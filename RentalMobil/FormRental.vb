Imports MySql.Data.MySqlClient

Public Class FormRental
    ' Variable untuk menyimpan ID mobil dan data terkait
    Private selectedMobilId As Integer = 0
    Private selectedCustomerId As Integer = 0

    ' Fungsi untuk menghitung lama sewa dalam hari
    Private Sub HitungLamaSewa()
        Dim tglSewa As Date = dtpSewa.Value.Date
        Dim tglKembali As Date = dtpKembali.Value.Date

        ' Hitung selisih hari antara tanggal kembali dan sewa
        Dim lamaHari As Integer = (tglKembali - tglSewa).Days

        ' Isi lama sewa dengan minimal nilai 0
        txtLamaSewa.Text = Math.Max(0, lamaHari).ToString()

        ' Hitung total biaya jika lama sewa berubah
        HitungTotalBiaya()
    End Sub

    ' Fungsi untuk menghitung total biaya sewa
    Private Sub HitungTotalBiaya()
        Dim durasi As Integer
        Dim harga As Integer

        ' Jika input valid (angka), lakukan perhitungan
        If Integer.TryParse(txtLamaSewa.Text, durasi) AndAlso Integer.TryParse(txtHargaPerhari.Text, harga) Then
            Dim total As Integer = durasi * harga
            ' Format dengan pemisah ribuan
            txtTotalBiaya.Text = FormatNumber(total, 0, , , TriState.False)
        Else
            ' Kosongkan jika input tidak valid
            txtTotalBiaya.Text = ""
        End If
    End Sub

    ' Fungsi untuk mengisi dropdown mobil dari database
    Private Sub IsiDataMobil()
        ' Clear existing items
        cmbMobil.Items.Clear()
        cmbMobil.ValueMember = "ID"
        cmbMobil.DisplayMember = "Nama"

        Try
            ' Query untuk mendapatkan mobil yang tersedia (tidak sedang disewa)
            Dim query As String = "SELECT id, CONCAT(merk, ' ', model, ' (', plat_nomor, ')') AS nama_mobil, " & _
                                 "harga_sewa_perhari FROM mobil WHERE status = 'Available' " & _
                                 "ORDER BY merk, tipe"

            ' Eksekusi query dan simpan hasilnya ke dalam DataTable
            Dim dt As DataTable = ModuleConnection.ExecuteQuery(query)

            ' Jika tidak ada data, keluar dari sub
            If dt.Rows.Count = 0 Then Exit Sub

            ' Tambahkan setiap baris data ke combobox
            For Each row As DataRow In dt.Rows
                cmbMobil.Items.Add(New With {
                    .Text = row("nama_mobil").ToString(),
                    .Value = Convert.ToInt32(row("id"))
                })
                
                ' Jika belum ada harga, set harga default dari database
                If String.IsNullOrWhiteSpace(txtHargaPerhari.Text) Then
                    txtHargaPerhari.Text = row("harga_sewa_perhari").ToString()
                End If
            Next

            ' Atur properti DisplayMember dan ValueMember
            cmbMobil.DisplayMember = "Text"
            cmbMobil.ValueMember = "Value"

            ' Pilih item pertama
            If cmbMobil.Items.Count > 0 Then
                cmbMobil.SelectedIndex = 0
            End If
        Catch ex As Exception
            ' Jika terjadi error, gunakan data default
            MessageBox.Show("Error loading car data: " & ex.Message & vbCrLf & "Using default data instead.",
                            "Database Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            ' Tambahkan data default ke combobox
            cmbMobil.Items.AddRange(New String() {"Avanza", "Xenia", "Innova"})

            ' Pilih item pertama
            cmbMobil.SelectedIndex = 0
        End Try
    End Sub

    ' Fungsi untuk mengisi dropdown pelanggan dari database
    Private Sub IsiDataPelanggan()
        ' Clear existing items
        cmbPelanggan.Items.Clear()
        cmbPelanggan.ValueMember = "ID"
        cmbPelanggan.DisplayMember = "Nama"

        Try
            ' Query untuk mendapatkan data pelanggan
            Dim query As String = "SELECT id, CONCAT(nama, ' (', nomor_telepon, ')') AS nama_pelanggan " & _
                                 "FROM pelanggan ORDER BY nama ASC"

            ' Eksekusi query dan simpan hasilnya ke dalam DataTable
            Dim dt As DataTable = ModuleConnection.ExecuteQuery(query)

            ' Jika tidak ada data, keluar dari sub
            If dt.Rows.Count = 0 Then Exit Sub

            ' Tambahkan setiap baris data ke combobox
            For Each row As DataRow In dt.Rows
                cmbPelanggan.Items.Add(New With {
                    .Text = row("nama_pelanggan").ToString(),
                    .Value = Convert.ToInt32(row("id"))
                })
            Next

            ' Atur properti DisplayMember dan ValueMember
            cmbPelanggan.DisplayMember = "Text"
            cmbPelanggan.ValueMember = "Value"

            ' Pilih item pertama jika ada
            If cmbPelanggan.Items.Count > 0 Then
                cmbPelanggan.SelectedIndex = 0
            End If
        Catch ex As Exception
            ' Jika terjadi error, tampilkan pesan
            MessageBox.Show("Error loading customer data: " & ex.Message,
                            "Database Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    ' Event saat mobil dipilih di combobox
    Private Sub cmbMobil_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbMobil.SelectedIndexChanged
        If cmbMobil.SelectedItem IsNot Nothing Then
            Try
                ' Ambil ID mobil yang dipilih
                Dim selectedItem = cmbMobil.SelectedItem
                selectedMobilId = selectedItem.Value
                
                ' Ambil data harga sewa mobil dari database
                Dim query As String = "SELECT harga_sewa_perhari FROM mobil WHERE id = @id"
                Dim parameters As New Dictionary(Of String, Object)
                parameters.Add("@id", selectedMobilId)
                
                Dim harga As Object = ModuleConnection.ExecuteScalar(query, parameters)
                If harga IsNot Nothing Then
                    txtHargaPerhari.Text = harga.ToString()
                    HitungTotalBiaya()
                End If
            Catch ex As Exception
                ' Jika error, gunakan harga default
                txtHargaPerhari.Text = "250000"
                HitungTotalBiaya()
            End Try
        End If
    End Sub

    ' Event saat pelanggan dipilih di combobox
    Private Sub cmbPelanggan_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        If cmbPelanggan.SelectedItem IsNot Nothing Then
            Try
                ' Ambil ID pelanggan yang dipilih
                Dim selectedItem = cmbPelanggan.SelectedItem
                selectedCustomerId = selectedItem.Value
            Catch ex As Exception
                selectedCustomerId = 0
            End Try
        End If
    End Sub

    ' Event saat FormRental pertama kali dimuat
    Private Sub FormRental_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Atur tanggal sewa ke hari ini
        dtpSewa.Value = Date.Today
        ' Atur tanggal kembali ke besok
        dtpKembali.Value = Date.Today.AddDays(1)

        ' Isi ComboBox mobil, pelanggan, dan metode pembayaran
        IsiDataMobil()
        IsiDataPelanggan()
        cmbPembayaran.Items.AddRange(New String() {"Cash", "Transfer Bank", "QRIS", "Kartu Kredit"})
        cmbPembayaran.SelectedIndex = 0

        ' Inisialisasi lama sewa ke 1 hari
        txtLamaSewa.Text = "1"

        ' Default harga sewa jika belum diisi dari database
        If String.IsNullOrEmpty(txtHargaPerhari.Text) Then
            txtHargaPerhari.Text = "250000"
        End If
        
        HitungTotalBiaya()

        ' Tombol proses aktif sejak awal
        btnProses.Enabled = True

        ' Tambahkan event listener agar ketika tanggal/harga berubah, perhitungan dilakukan otomatis
        AddHandler dtpSewa.ValueChanged, AddressOf HitungLamaSewa
        AddHandler dtpKembali.ValueChanged, AddressOf HitungLamaSewa
        AddHandler txtHargaPerhari.TextChanged, AddressOf HitungTotalBiaya
    End Sub

    ' Validasi inputan numerik untuk txtHargaPerhari
    Private Sub txtHargaPerhari_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHargaPerhari.KeyPress
        ' Hanya terima angka dan tombol kontrol seperti backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Event saat tombol Proses diklik
    Private Sub btnProses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProses.Click
        ' Validasi: form harus diisi
        If cmbPelanggan.SelectedIndex = -1 Then
            MessageBox.Show("Silakan pilih pelanggan terlebih dahulu.", "Data Tidak Lengkap", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbPelanggan.Focus()
            Exit Sub
        End If

        If cmbMobil.SelectedIndex = -1 Then
            MessageBox.Show("Silakan pilih mobil terlebih dahulu.", "Data Tidak Lengkap", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbMobil.Focus()
            Exit Sub
        End If

        If cmbPembayaran.SelectedIndex = -1 Then
            MessageBox.Show("Metode pembayaran harus dipilih.", "Data Tidak Lengkap", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbPembayaran.Focus()
            Exit Sub
        End If

        ' Validasi harga per hari
        If String.IsNullOrWhiteSpace(txtHargaPerhari.Text) Then
            MessageBox.Show("Harga per hari harus diisi.", "Data Tidak Lengkap", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtHargaPerhari.Focus()
            Exit Sub
        End If

        ' Validasi: tanggal kembali harus setelah tanggal sewa
        Dim tglSewa As Date = dtpSewa.Value.Date
        Dim tglKembali As Date = dtpKembali.Value.Date

        If tglKembali <= tglSewa Then
            MessageBox.Show("Tanggal kembali harus lebih besar dari tanggal sewa.", "Tanggal Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dtpKembali.Focus()
            Exit Sub
        End If

        ' Validasi lama sewa tidak boleh 0 hari
        Dim lamaSewa As Integer
        Integer.TryParse(txtLamaSewa.Text, lamaSewa)

        If lamaSewa = 0 Then
            MessageBox.Show("Lama sewa masih 0 hari. Silakan sesuaikan tanggal kembali.", "Lama Sewa Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dtpKembali.Focus()
            Exit Sub
        End If

        ' Pastikan ID mobil dan pelanggan valid
        If selectedMobilId <= 0 Then
            MessageBox.Show("Error: Mobil tidak valid atau tidak tersedia. Silakan pilih mobil lain.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If selectedCustomerId <= 0 Then
            MessageBox.Show("Error: Pelanggan tidak valid. Silakan pilih pelanggan lain.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Ambil semua data dari form
        Dim pelangganDisplay As String = If(cmbPelanggan.SelectedItem IsNot Nothing, cmbPelanggan.SelectedItem.Text, "-")
        Dim mobil As String = If(cmbMobil.SelectedItem IsNot Nothing, cmbMobil.SelectedItem.Text, "-")
        Dim hargaPerHari As Decimal = Decimal.Parse(txtHargaPerhari.Text.Trim())
        Dim totalBiaya As Decimal = hargaPerHari * lamaSewa
        Dim pembayaran As String = If(cmbPembayaran.SelectedItem IsNot Nothing, cmbPembayaran.SelectedItem.ToString(), "-")
        Dim catatan As String = txtCatatan.Text.Trim()

        ' Tampilkan konfirmasi
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin memproses data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Jika dikonfirmasi, simpan ke database
        If result = DialogResult.Yes Then
            Try
                ' Simpan data rental ke database
                Dim insertQuery As String = "INSERT INTO rental (pelanggan_id, mobil_id, tanggal_sewa, tanggal_kembali, " & _
                                           "lama_sewa, harga_perhari, total_biaya, metode_pembayaran, catatan, status) " & _
                                           "VALUES (@customer, @mobil, @tgl_sewa, @tgl_kembali, @durasi, @harga, @total, " & _
                                           "@pembayaran, @catatan, 'Active')"
                
                Dim parameters As New Dictionary(Of String, Object)
                parameters.Add("@customer", selectedCustomerId)
                parameters.Add("@mobil", selectedMobilId)
                parameters.Add("@tgl_sewa", tglSewa)
                parameters.Add("@tgl_kembali", tglKembali)
                parameters.Add("@durasi", lamaSewa)
                parameters.Add("@harga", hargaPerHari)
                parameters.Add("@total", totalBiaya)
                parameters.Add("@pembayaran", pembayaran)
                parameters.Add("@catatan", catatan)
                
                ModuleConnection.ExecuteNonQuery(insertQuery, parameters)
                
                ' Update status mobil menjadi Rented
                Dim updateMobilQuery As String = "UPDATE mobil SET status = 'Rented' WHERE id = @id"
                Dim mobilParams As New Dictionary(Of String, Object)
                mobilParams.Add("@id", selectedMobilId)
                ModuleConnection.ExecuteNonQuery(updateMobilQuery, mobilParams)
                
                Dim detail As String = String.Format(
                    "Detail Data Penyewaan:" & vbCrLf &
                    "Pelanggan    : {0}" & vbCrLf &
                    "Mobil        : {1}" & vbCrLf &
                    "Tgl Sewa     : {2}" & vbCrLf &
                    "Tgl Kembali  : {3}" & vbCrLf &
                    "Lama Sewa    : {4} Hari" & vbCrLf &
                    "Harga/Hari   : Rp {5}" & vbCrLf &
                    "Total Biaya  : Rp {6}" & vbCrLf &
                    "Pembayaran   : {7}" & vbCrLf &
                    "Catatan      : {8}",
                    pelangganDisplay,
                    mobil,
                    tglSewa.ToShortDateString(),
                    tglKembali.ToShortDateString(),
                    lamaSewa,
                    FormatNumber(hargaPerHari, 0, , , TriState.False),
                    FormatNumber(totalBiaya, 0, , , TriState.False),
                    pembayaran,
                    catatan
                )
                
                MessageBox.Show(detail, "Berhasil Diproses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                
                ' Reset form setelah berhasil untuk input baru
                ResetForm()
                
                ' Refresh data mobil karena ada mobil yang sudah diambil
                IsiDataMobil()
            Catch ex As Exception
                MessageBox.Show("Error menyimpan data rental: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' Reset semua field form ke keadaan awal
    Private Sub ResetForm()
        ' Atur tanggal sewa ke hari ini
        dtpSewa.Value = Date.Today
        ' Atur tanggal kembali ke besok
        dtpKembali.Value = Date.Today.AddDays(1)
        
        ' Reset combobox
        If cmbMobil.Items.Count > 0 Then
            cmbMobil.SelectedIndex = 0
        End If
        
        If cmbPelanggan.Items.Count > 0 Then
            cmbPelanggan.SelectedIndex = 0
        End If
        
        If cmbPembayaran.Items.Count > 0 Then
            cmbPembayaran.SelectedIndex = 0
        End If

        txtLamaSewa.Text = "1"
        txtCatatan.Clear()
        
        ' Reset ID
        selectedMobilId = 0
        selectedCustomerId = 0
    End Sub

    ' Event saat tombol Batal diklik
    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        ' Tanyakan konfirmasi jika ada data yang sudah diisi
        If Not String.IsNullOrWhiteSpace(txtCatatan.Text) Then
            Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin membatalkan? Data yang telah diisi akan hilang.", "Konfirmasi Batal", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.No Then
                Exit Sub
            End If
        End If
        
        Me.Close()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
End Class
