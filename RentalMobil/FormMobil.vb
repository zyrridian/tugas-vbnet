Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class FormMobil

    ' Variable untuk menyimpan ID mobil yang sedang diedit
    Private currentID As Integer = 0
    Private isEditMode As Boolean = False

    ' Event saat FormMobil dimuat
    Private Sub FormMobil_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Load data tipe ke ComboBox
        LoadComboBoxTipe()

        ' Reset field input saat form dibuka
        ClearInputs()

        ' Load data dari database ke DataGridView
        RefreshDataGridView()
    End Sub

    ' Method untuk menambahkan tipe mobil yang tersedia
    Private Sub LoadComboBoxTipe()
        cmbTipe.Items.Clear()
        cmbTipe.Items.Add("SUV")
        cmbTipe.Items.Add("MPV")
        cmbTipe.Items.Add("Sedan")
        cmbTipe.Items.Add("Hatchback")
        cmbTipe.Items.Add("Convertible")
    End Sub

    ' Method untuk membersihkan input fields
    Private Sub ClearInputs()
        txtMerk.Clear()
        txtModel.Clear()
        cmbTipe.SelectedIndex = -1
        txtPlat.Clear()
        txtTahun.Clear()
        txtHarga.Clear()
        currentID = 0
        isEditMode = False

        ' Fokus ke field pertama
        txtMerk.Focus()
    End Sub

    ' Method untuk refresh DataGridView
    Private Sub RefreshDataGridView()
        dgvMobil.Rows.Clear()

        Try
            ' Query untuk mengambil semua data mobil
            Dim query As String = "SELECT * FROM mobil ORDER BY id ASC"
            Dim dt As DataTable = ModuleConnection.ExecuteQuery(query)

            ' Jika ada data, tampilkan di DataGridView
            Dim index As Integer = 1
            For Each row As DataRow In dt.Rows
                Dim id As Integer = Convert.ToInt32(row("id"))
                Dim merk As String = row("merk").ToString()
                Dim model As String = row("model").ToString()
                Dim tipe As String = row("tipe").ToString()
                Dim plat As String = row("plat_nomor").ToString()
                Dim tahun As Integer = Convert.ToInt32(row("tahun"))
                Dim harga As Decimal = Convert.ToDecimal(row("harga_sewa_perhari"))

                ' Format harga ke mata uang Rupiah
                Dim hargaRupiah As String = harga.ToString("C0", New CultureInfo("id-ID"))

                ' Tambahkan ke DataGridView
                dgvMobil.Rows.Add(index, merk, model, tipe, plat, tahun, hargaRupiah)
                index += 1
            Next
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Event saat tombol Simpan diklik
    Private Sub btnSimpan_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSimpan.Click
        ' Validasi: Semua field harus diisi
        If txtMerk.Text.Trim() = "" OrElse txtModel.Text.Trim() = "" OrElse cmbTipe.SelectedIndex = -1 OrElse txtPlat.Text.Trim() = "" OrElse txtTahun.Text.Trim() = "" OrElse txtHarga.Text.Trim() = "" Then
            MessageBox.Show("Semua field harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validasi tahun harus angka dan masuk akal
        Dim tahun As Integer
        If Not Integer.TryParse(txtTahun.Text, tahun) OrElse tahun < 1900 OrElse tahun > Now.Year Then
            MessageBox.Show("Tahun tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTahun.Focus()
            Return
        End If

        ' Validasi harga harus angka positif
        Dim harga As Decimal
        If Not Decimal.TryParse(txtHarga.Text, harga) OrElse harga <= 0 Then
            MessageBox.Show("Harga harus berupa angka positif!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtHarga.Focus()
            Return
        End If

        ' Validasi plat nomor unik
        Dim platNomor As String = txtPlat.Text.Trim().ToUpper()
        Dim parameters As New Dictionary(Of String, Object)
        parameters.Add("@plat", platNomor)

        Dim whereClause As String = ""
        If isEditMode Then
            whereClause = " AND id <> @id"
            parameters.Add("@id", currentID)
        End If

        Dim checkQuery As String = "SELECT COUNT(*) FROM mobil WHERE plat_nomor = @plat" & whereClause
        Dim count As Integer = Convert.ToInt32(ModuleConnection.ExecuteScalar(checkQuery, parameters))

        If count > 0 Then
            MessageBox.Show("Nomor plat ini sudah terdaftar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPlat.Focus()
            Return
        End If

        Try
            ' Siapkan parameter untuk query
            Dim queryParams As New Dictionary(Of String, Object)
            queryParams.Add("@merk", txtMerk.Text.Trim())
            queryParams.Add("@model", txtModel.Text.Trim())
            queryParams.Add("@tipe", cmbTipe.SelectedItem.ToString())
            queryParams.Add("@plat", platNomor)
            queryParams.Add("@tahun", tahun)
            queryParams.Add("@harga", harga)

            If isEditMode Then
                ' Update data di database
                Dim updateQuery As String = "UPDATE mobil SET merk = @merk, model = @model, tipe = @tipe, plat_nomor = @plat, tahun = @tahun, harga_sewa_perhari = @harga WHERE id = @id"
                queryParams.Add("@id", currentID)
                ModuleConnection.ExecuteNonQuery(updateQuery, queryParams)

                MessageBox.Show("Data mobil berhasil diupdate!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' Simpan data baru ke database
                Dim insertQuery As String = "INSERT INTO mobil (merk, model, tipe, plat_nomor, tahun, harga_sewa_perhari, status) VALUES (@merk, @model, @tipe, @plat, @tahun, @harga, 'Available')"
                ModuleConnection.ExecuteNonQuery(insertQuery, queryParams)

                MessageBox.Show("Data mobil berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            ' Refresh DataGridView
            RefreshDataGridView()

            ' Reset semua field input agar siap untuk input berikutnya
            ClearInputs()
        Catch ex As Exception
            MessageBox.Show("Error saving data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Event saat tombol Hapus diklik
    Private Sub btnHapus_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnHapus.Click
        ' Periksa apakah ada baris yang dipilih
        If dgvMobil.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih mobil yang akan dihapus terlebih dahulu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Ambil index baris yang dipilih
        Dim selectedIndex As Integer = dgvMobil.SelectedRows(0).Index

        ' Dapatkan ID mobil dari database
        Try
            Dim query As String = "SELECT id FROM mobil ORDER BY id ASC"
            Dim dt As DataTable = ModuleConnection.ExecuteQuery(query)

            If selectedIndex >= dt.Rows.Count Then
                MessageBox.Show("Pilihan tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim mobileId As Integer = Convert.ToInt32(dt.Rows(selectedIndex)("id"))

            ' Konfirmasi penghapusan
            Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data mobil ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                ' Cek apakah mobil sedang digunakan dalam penyewaan aktif
                Dim checkQuery As String = "SELECT COUNT(*) FROM rental WHERE mobil_id = @id AND status = 'Active'"
                Dim parameters As New Dictionary(Of String, Object)
                parameters.Add("@id", mobileId)

                Dim rentalCount As Integer = 0
                Try
                    rentalCount = Convert.ToInt32(ModuleConnection.ExecuteScalar(checkQuery, parameters))
                Catch ex As Exception
                    ' Tabel rental mungkin belum ada, abaikan error
                End Try

                If rentalCount > 0 Then
                    MessageBox.Show("Mobil ini sedang digunakan dalam penyewaan aktif. Tidak dapat dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                ' Hapus dari database
                Dim deleteQuery As String = "DELETE FROM mobil WHERE id = @id"
                ModuleConnection.ExecuteNonQuery(deleteQuery, parameters)

                ' Refresh DataGridView
                RefreshDataGridView()

                MessageBox.Show("Data mobil berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error deleting data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Event saat tombol Batal diklik
    Private Sub btnBatal_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBatal.Click
        ' Menutup form
        Me.Close()
    End Sub

    ' Event saat dgvMobil diklik untuk mengisi form dengan data yang dipilih
    Private Sub dgvMobil_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvMobil.CellClick
        ' Periksa apakah klik pada header atau di luar baris yang valid
        If e.RowIndex < 0 Then Return

        Try
            ' Dapatkan ID mobil dari database
            Dim query As String = "SELECT * FROM mobil ORDER BY id ASC"
            Dim dt As DataTable = ModuleConnection.ExecuteQuery(query)

            ' Periksa apakah index valid
            If e.RowIndex >= dt.Rows.Count Then Return

            ' Set mode edit
            isEditMode = True

            ' Ambil data dari baris yang dipilih di database
            Dim row As DataRow = dt.Rows(e.RowIndex)
            currentID = Convert.ToInt32(row("id"))

            ' Isi form dengan data yang dipilih
            txtMerk.Text = row("merk").ToString()
            txtModel.Text = row("model").ToString()

            ' Set selected item di combobox
            Dim tipe As String = row("tipe").ToString()
            For i As Integer = 0 To cmbTipe.Items.Count - 1
                If cmbTipe.Items(i).ToString() = tipe Then
                    cmbTipe.SelectedIndex = i
                    Exit For
                End If
            Next

            txtPlat.Text = row("plat_nomor").ToString()
            txtTahun.Text = row("tahun").ToString()
            txtHarga.Text = row("harga_sewa_perhari").ToString()
        Catch ex As Exception
            MessageBox.Show("Error loading selected data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Validasi input hanya angka untuk field Tahun
    Private Sub txtTahun_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTahun.KeyPress
        ' Hanya terima angka dan tombol kontrol seperti backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Validasi input hanya angka untuk field Harga
    Private Sub txtHarga_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHarga.KeyPress
        ' Hanya terima angka dan tombol kontrol seperti backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class
