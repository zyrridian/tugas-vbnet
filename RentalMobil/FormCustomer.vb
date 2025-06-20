Imports MySql.Data.MySqlClient

Public Class FormCustomer

    ' Variable untuk menyimpan ID customer yang sedang diedit
    Private currentID As Integer = 0
    Private isEditMode As Boolean = False

    ' Event saat FormCustomer dimuat
    Private Sub FormCustomer_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Reset field input saat form dibuka
        ClearInputs()

        ' Load data dari database ke DataGridView
        RefreshDataGridView()
    End Sub

    ' Method untuk membersihkan input fields
    Private Sub ClearInputs()
        txtNama.Clear()
        txtTelepon.Clear()
        txtEmail.Clear()
        txtAlamat.Clear()
        currentID = 0
        isEditMode = False

        ' Fokus ke field pertama
        txtNama.Focus()
    End Sub

    ' Method untuk refresh DataGridView
    Private Sub RefreshDataGridView()
        dgvCustomer.Rows.Clear()

        Try
            ' Query untuk mengambil semua data pelanggan
            Dim query As String = "SELECT * FROM pelanggan ORDER BY id ASC"
            Dim dt As DataTable = ModuleConnection.ExecuteQuery(query)

            ' Jika ada data, tampilkan di DataGridView
            Dim index As Integer = 1
            For Each row As DataRow In dt.Rows
                Dim id As Integer = Convert.ToInt32(row("id"))
                Dim nama As String = row("nama").ToString()
                Dim telepon As String = row("nomor_telepon").ToString()
                Dim email As String = row("email").ToString()
                Dim alamat As String = If(row("alamat") IsNot DBNull.Value, row("alamat").ToString(), "")

                ' Tambahkan ke DataGridView
                dgvCustomer.Rows.Add(index, nama, telepon, email, alamat)
                index += 1
            Next
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Event saat tombol Simpan diklik
    Private Sub btnSimpan_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSimpan.Click
        ' Validasi: Nama dan Telepon harus diisi
        If String.IsNullOrEmpty(txtNama.Text.Trim()) OrElse String.IsNullOrEmpty(txtTelepon.Text.Trim()) Then
            MessageBox.Show("Nama dan Telepon harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validasi format email (basic)
        Dim email As String = txtEmail.Text.Trim()
        If Not String.IsNullOrEmpty(email) AndAlso Not email.Contains("@") Then
            MessageBox.Show("Format email tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtEmail.Focus()
            Return
        End If

        ' Validasi nomor telepon unik
        Dim nomorTelepon As String = txtTelepon.Text.Trim()
        Dim parameters As New Dictionary(Of String, Object)
        parameters.Add("@telepon", nomorTelepon)

        Dim whereClause As String = ""
        If isEditMode Then
            whereClause = " AND id <> @id"
            parameters.Add("@id", currentID)
        End If

        Dim checkQuery As String = "SELECT COUNT(*) FROM pelanggan WHERE nomor_telepon = @telepon" & whereClause
        Dim count As Integer = Convert.ToInt32(ModuleConnection.ExecuteScalar(checkQuery, parameters))

        If count > 0 Then
            MessageBox.Show("Nomor telepon ini sudah terdaftar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTelepon.Focus()
            Return
        End If

        Try
            ' Siapkan parameter untuk query
            Dim queryParams As New Dictionary(Of String, Object)
            queryParams.Add("@nama", txtNama.Text.Trim())
            queryParams.Add("@telepon", nomorTelepon)
            queryParams.Add("@email", email)
            queryParams.Add("@alamat", txtAlamat.Text.Trim())

            If isEditMode Then
                ' Update data di database
                Dim updateQuery As String = "UPDATE pelanggan SET nama = @nama, nomor_telepon = @telepon, email = @email, alamat = @alamat WHERE id = @id"
                queryParams.Add("@id", currentID)
                ModuleConnection.ExecuteNonQuery(updateQuery, queryParams)

                MessageBox.Show("Data pelanggan berhasil diupdate!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' Simpan data baru ke database
                Dim insertQuery As String = "INSERT INTO pelanggan (nama, nomor_telepon, email, alamat) VALUES (@nama, @telepon, @email, @alamat)"
                ModuleConnection.ExecuteNonQuery(insertQuery, queryParams)

                MessageBox.Show("Data pelanggan berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        If dgvCustomer.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih pelanggan yang akan dihapus terlebih dahulu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Ambil index baris yang dipilih
        Dim selectedIndex As Integer = dgvCustomer.SelectedRows(0).Index

        ' Dapatkan ID customer dari database
        Try
            Dim query As String = "SELECT id FROM pelanggan ORDER BY id ASC"
            Dim dt As DataTable = ModuleConnection.ExecuteQuery(query)

            If selectedIndex >= dt.Rows.Count Then
                MessageBox.Show("Pilihan tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim customerId As Integer = Convert.ToInt32(dt.Rows(selectedIndex)("id"))

            ' Konfirmasi penghapusan
            Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data pelanggan ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                ' Cek apakah pelanggan sedang memiliki penyewaan aktif
                Dim checkQuery As String = "SELECT COUNT(*) FROM rental WHERE pelanggan_id = @id AND status = 'Active'"
                Dim parameters As New Dictionary(Of String, Object)
                parameters.Add("@id", customerId)

                Dim rentalCount As Integer = 0
                Try
                    rentalCount = Convert.ToInt32(ModuleConnection.ExecuteScalar(checkQuery, parameters))
                Catch ex As Exception
                    ' Tabel rental mungkin belum ada, abaikan error
                End Try

                If rentalCount > 0 Then
                    MessageBox.Show("Pelanggan ini memiliki penyewaan aktif. Tidak dapat dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                ' Hapus semua data rental yang sudah selesai (Completed) milik pelanggan
                Dim deleteRentalQuery As String = "DELETE FROM rental WHERE pelanggan_id = @id"
                ModuleConnection.ExecuteNonQuery(deleteRentalQuery, parameters)

                ' Hapus dari database
                Dim deleteQuery As String = "DELETE FROM pelanggan WHERE id = @id"
                ModuleConnection.ExecuteNonQuery(deleteQuery, parameters)

                ' Refresh DataGridView
                RefreshDataGridView()

                MessageBox.Show("Data pelanggan berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error deleting data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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

        Try
            ' Dapatkan ID pelanggan dari database
            Dim query As String = "SELECT * FROM pelanggan ORDER BY id ASC"
            Dim dt As DataTable = ModuleConnection.ExecuteQuery(query)

            ' Periksa apakah index valid
            If e.RowIndex >= dt.Rows.Count Then Return

            ' Set mode edit
            isEditMode = True

            ' Ambil data dari baris yang dipilih di database
            Dim row As DataRow = dt.Rows(e.RowIndex)
            currentID = Convert.ToInt32(row("id"))

            ' Isi form dengan data yang dipilih
            txtNama.Text = row("nama").ToString()
            txtTelepon.Text = row("nomor_telepon").ToString()
            txtEmail.Text = row("email").ToString()
            txtAlamat.Text = If(row("alamat") IsNot DBNull.Value, row("alamat").ToString(), "")
        Catch ex As Exception
            MessageBox.Show("Error loading selected data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Validasi input hanya angka dan karakter khusus telepon untuk field Telepon
    Private Sub txtTelepon_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtTelepon.KeyPress
        ' Hanya terima angka, tanda +, dan tombol kontrol seperti backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "+"c AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class