Public Class FormRental

    ' Fungsi untuk menghitung lama sewa dalam hari
    Private Sub HitungLamaSewa()
        Dim tglSewa As Date = dtpSewa.Value.Date
        Dim tglKembali As Date = dtpKembali.Value.Date

        ' Hitung selisih hari antara tanggal kembali dan sewa
        Dim lamaHari As Integer = (tglKembali - tglSewa).Days

        ' Isi lama sewa dengan minimal nilai 0
        dtpLamaSewa.Text = Math.Max(0, lamaHari).ToString()

        ' Hitung total biaya jika lama sewa berubah
        HitungTotalBiaya()
    End Sub

    ' Fungsi untuk menghitung total biaya sewa
    Private Sub HitungTotalBiaya()
        Dim durasi As Integer
        Dim harga As Integer

        ' Jika input valid (angka), lakukan perhitungan
        If Integer.TryParse(dtpLamaSewa.Text, durasi) AndAlso Integer.TryParse(txtHargaPerhari.Text, harga) Then
            Dim total As Integer = durasi * harga
            txtTotalBiaya.Text = total.ToString()
        Else
            ' Kosongkan jika input tidak valid
            txtTotalBiaya.Text = ""
        End If
    End Sub

    ' Event saat FormRental pertama kali dimuat
    Private Sub FormRental_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Isi ComboBox mobil dan metode pembayaran
        cmbMobil.Items.AddRange(New String() {"Avanza", "Xenia", "Innova"})
        cmbPembayaran.Items.AddRange(New String() {"Cash", "Transfer", "QRIS"})

        ' Inisialisasi lama sewa ke 0
        dtpLamaSewa.Text = "0"

        ' Tombol proses aktif sejak awal
        btnProses.Enabled = True

        ' Tambahkan event listener agar ketika tanggal/harga berubah, perhitungan dilakukan otomatis
        AddHandler dtpSewa.ValueChanged, AddressOf HitungLamaSewa
        AddHandler dtpKembali.ValueChanged, AddressOf HitungLamaSewa
        AddHandler txtHargaPerhari.TextChanged, AddressOf HitungTotalBiaya
    End Sub

    ' Event saat tombol Proses diklik
    Private Sub btnProses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProses.Click
        ' Validasi: tanggal kembali harus setelah tanggal sewa
        Dim tglSewa As Date = dtpSewa.Value.Date
        Dim tglKembali As Date = dtpKembali.Value.Date

        If tglKembali <= tglSewa Then
            MessageBox.Show("Tanggal kembali harus lebih besar dari tanggal sewa.", "Tanggal Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Validasi lama sewa tidak boleh 0 hari
        Dim lamaSewa As Integer
        Integer.TryParse(dtpLamaSewa.Text, lamaSewa)

        If lamaSewa = 0 Then
            MessageBox.Show("Lama sewa masih 0 hari. Silakan sesuaikan tanggal kembali.", "Lama Sewa Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Ambil semua data dari form
        Dim nama As String = txtNama.Text
        Dim telp As String = txtTelp.Text
        Dim mobil As String = If(cmbMobil.SelectedItem IsNot Nothing, cmbMobil.SelectedItem.ToString(), "-")
        Dim hargaPerHari As String = txtHargaPerhari.Text
        Dim totalBiaya As String = txtTotalBiaya.Text
        Dim pembayaran As String = If(cmbPembayaran.SelectedItem IsNot Nothing, cmbPembayaran.SelectedItem.ToString(), "-")
        Dim catatan As String = txtCatatan.Text

        ' Tampilkan konfirmasi
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin memproses data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Jika dikonfirmasi, tampilkan detail penyewaan
        If result = DialogResult.Yes Then
            Dim detail As String = String.Format(
                "Detail Data Penyewaan:" & vbCrLf &
                "Nama         : {0}" & vbCrLf &
                "Telepon      : {1}" & vbCrLf &
                "Mobil        : {2}" & vbCrLf &
                "Tgl Sewa     : {3}" & vbCrLf &
                "Tgl Kembali  : {4}" & vbCrLf &
                "Lama Sewa    : {5} Hari" & vbCrLf &
                "Harga/Hari   : Rp {6}" & vbCrLf &
                "Total Biaya  : Rp {7}" & vbCrLf &
                "Pembayaran   : {8}" & vbCrLf &
                "Catatan      : {9}",
                nama,
                telp,
                mobil,
                tglSewa.ToShortDateString(),
                tglKembali.ToShortDateString(),
                lamaSewa,
                hargaPerHari,
                totalBiaya,
                pembayaran,
                catatan
            )
            MessageBox.Show(detail, "Berhasil Diproses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' Event saat tombol Batal diklik
    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

End Class
