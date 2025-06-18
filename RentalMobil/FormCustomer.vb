Public Class FormCustomer

    ' List untuk menyimpan data customer
    Public Shared DaftarCustomer As New List(Of String)

    ' ID untuk customer (untuk keperluan identifikasi)
    Private currentID As Integer = 1

    ' Event saat FormCustomer dimuat
    Private Sub FormCustomer_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Reset field input saat form dibuka
        ClearInputs()

        ' Load data dari list global ke DataGridView
        RefreshDataGridView()
    End Sub

    ' Method untuk membersihkan input fields
    Private Sub ClearInputs()
        txtNama.Clear()
        txtTelepon.Clear()
        txtEmail.Clear()
        txtAlamat.Clear()

        ' Fokus ke field pertama
        txtNama.Focus()
    End Sub

    ' Method untuk refresh DataGridView
    Private Sub RefreshDataGridView()
        dgvCustomer.Rows.Clear()

        ' Jika ada data customer di list global, tampilkan di DataGridView
        Dim index As Integer = 1
        For Each customer As String In DaftarCustomer
            Dim parts As String() = customer.Split(New Char() {"|"c})
            If parts.Length >= 4 Then
                ' Format: "Nama|Telepon|Email|Alamat"
                Dim nama As String = parts(0).Trim()
                Dim telepon As String = parts(1).Trim()
                Dim email As String = parts(2).Trim()
                Dim alamat As String = parts(3).Trim()

                ' Tambahkan ke DataGridView
                dgvCustomer.Rows.Add(index, nama, telepon, email, alamat)
                index += 1
            End If
        Next

        ' Update currentID
        currentID = Math.Max(1, DaftarCustomer.Count + 1)
    End Sub

    ' Event saat tombol Simpan diklik
    Private Sub btnSimpan_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSimpan.Click
        ' Validasi: Nama dan Telepon harus diisi
        If String.IsNullOrEmpty(txtNama.Text.Trim()) OrElse String.IsNullOrEmpty(txtTelepon.Text.Trim()) Then
            MessageBox.Show("Nama dan Telepon harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validasi format email (basic)
        If Not String.IsNullOrEmpty(txtEmail.Text.Trim()) AndAlso Not txtEmail.Text.Contains("@") Then
            MessageBox.Show("Format email tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtEmail.Focus()
            Return
        End If

        ' Format data customer menjadi satu string
        Dim dataCustomer As String = String.Format("{0}|{1}|{2}|{3}",
                                                  txtNama.Text.Trim(),
                                                  txtTelepon.Text.Trim(),
                                                  txtEmail.Text.Trim(),
                                                  txtAlamat.Text.Trim())

        ' Simpan data ke list global
        DaftarCustomer.Add(dataCustomer)

        ' Refresh DataGridView
        RefreshDataGridView()

        ' Tampilkan pesan sukses
        MessageBox.Show("Data pelanggan berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Reset semua field input agar siap untuk input berikutnya
        ClearInputs()
    End Sub

    ' Event saat tombol Hapus diklik
    Private Sub btnHapus_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnHapus.Click
        ' Periksa apakah ada baris yang dipilih
        If dgvCustomer.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih pelanggan yang akan dihapus terlebih dahulu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Ambil index baris yang dipilih
        Dim selectedIndex As Integer = dgvCustomer.SelectedRows(0).Index

        ' Verifikasi bahwa index valid
        If selectedIndex < 0 OrElse selectedIndex >= DaftarCustomer.Count Then
            MessageBox.Show("Pilihan tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Konfirmasi penghapusan
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data pelanggan ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            ' Hapus dari list global
            DaftarCustomer.RemoveAt(selectedIndex)

            ' Refresh DataGridView
            RefreshDataGridView()

            MessageBox.Show("Data pelanggan berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' Event saat tombol Tutup diklik
    Private Sub btnTutup_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnTutup.Click
        ' Menutup form
        Me.Close()
    End Sub

    ' Event saat dgvCustomer diklik untuk mengisi form dengan data yang dipilih
    Private Sub dgvCustomer_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvCustomer.CellClick
        ' Periksa apakah klik pada header atau di luar baris yang valid
        If e.RowIndex < 0 Then Return

        ' Periksa apakah index valid
        If e.RowIndex >= DaftarCustomer.Count Then Return

        ' Ambil data dari baris yang dipilih
        Dim parts As String() = DaftarCustomer(e.RowIndex).Split(New Char() {"|"c})
        If parts.Length >= 4 Then
            ' Isi form dengan data yang dipilih
            txtNama.Text = parts(0).Trim()
            txtTelepon.Text = parts(1).Trim()
            txtEmail.Text = parts(2).Trim()
            txtAlamat.Text = parts(3).Trim()
        End If
    End Sub

    ' Validasi input hanya angka dan karakter khusus telepon untuk field Telepon
    Private Sub txtTelepon_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtTelepon.KeyPress
        ' Hanya terima angka, tanda +, dan tombol kontrol seperti backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "+"c AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class