Public Class FormMobil

    ' List global untuk menyimpan data mobil sebagai string
    ' Format: "Merk - Tipe - Tahun - Harga"
    Public Shared DaftarMobil As New List(Of String)

    ' Event saat tombol Simpan diklik
    Private Sub btnSimpan_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSimpan.Click
        ' Validasi: Semua field harus diisi
        If txtMerk.Text.Trim() = "" OrElse cmbTipe.SelectedIndex = -1 OrElse txtTahun.Text.Trim() = "" OrElse txtHarga.Text.Trim() = "" Then
            MessageBox.Show("Semua field harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validasi tahun harus angka dan masuk akal
        Dim tahun As Integer
        If Not Integer.TryParse(txtTahun.Text, tahun) OrElse tahun < 1900 OrElse tahun > Now.Year Then
            MessageBox.Show("Tahun tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validasi harga harus angka positif
        Dim harga As Decimal
        If Not Decimal.TryParse(txtHarga.Text, harga) OrElse harga < 0 Then
            MessageBox.Show("Harga harus berupa angka positif!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Format data mobil menjadi satu string
        Dim dataMobil As String = String.Format("{0} - {1} - {2} - Rp {3:N0}",
                                                 txtMerk.Text.Trim(),
                                                 cmbTipe.SelectedItem.ToString(),
                                                 tahun,
                                                 harga)

        ' Simpan data ke list global
        DaftarMobil.Add(dataMobil)

        ' Tampilkan data baru ke ListBox
        lstMobil.Items.Add(dataMobil)

        ' Tampilkan pesan sukses
        MessageBox.Show("Data mobil berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Reset semua field input agar siap untuk input berikutnya
        txtMerk.Clear()
        cmbTipe.SelectedIndex = -1
        txtTahun.Clear()
        txtHarga.Clear()
    End Sub

    ' Event saat tombol Batal diklik
    Private Sub btnBatal_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBatal.Click
        ' Menutup form
        Me.Close()
    End Sub

    ' Event saat form pertama kali dimuat
    Private Sub FormMobil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Reset field input saat form dibuka
        txtMerk.Clear()
        cmbTipe.SelectedIndex = -1
        txtTahun.Clear()
        txtHarga.Clear()

        ' Jika ComboBox belum ada isinya, tambahkan daftar tipe mobil
        If cmbTipe.Items.Count = 0 Then
            cmbTipe.Items.AddRange(New Object() {"SUV", "Sedan", "Hatchback", "MPV", "Pickup", "Convertible"})
        End If

        ' Tampilkan kembali semua data mobil yang sudah disimpan di list global
        lstMobil.Items.Clear()
        For Each mobil As String In DaftarMobil
            lstMobil.Items.Add(mobil)
        Next
    End Sub

End Class
