Imports MySql.Data.MySqlClient

Public Class FormLogin

    Private connectionError As Boolean = False

    ' Event saat form pertama kali dimuat
    Private Sub FormLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Fokuskan ke textbox username
        txtUsername.Focus()

        ' Set default credentials untuk development
        txtUsername.Text = "admin"
        txtPassword.Text = "admin123"

        ' Coba koneksi database
        Try
            Dim conn As MySqlConnection = ModuleConnection.OpenConnection()
            If conn IsNot Nothing Then
                ModuleConnection.CloseConnection()
                lblStatus.Text = ""
            End If
        Catch ex As Exception
            ' Tampilkan pesan error database
            lblStatus.Text = "Database tidak terhubung. Mode offline aktif."
            connectionError = True
        End Try
    End Sub

    ' Event saat tombol Login diklik
    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        ' Ambil username dan password dari textbox
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        ' Validasi: username dan password tidak boleh kosong
        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            lblStatus.Text = "Username dan password harus diisi."
            Return
        End If

        ' Mode offline: verifikasi dengan credentials default
        If connectionError Then
            If username = "admin" AndAlso password = "admin123" Then
                LoginSuccess()
            Else
                lblStatus.Text = "Username atau password salah."
            End If
            Return
        End If

        ' Mode online: verifikasi dengan database
        Try
            ' Buat query untuk login
            Dim query As String = "SELECT * FROM user WHERE username = @username AND password = @password AND status = 1"

            ' Parameter untuk query
            Dim parameters As New Dictionary(Of String, Object)
            parameters.Add("@username", username)
            parameters.Add("@password", password)

            ' Jalankan query
            Dim dt As DataTable = ModuleConnection.ExecuteQuery(query, parameters)

            ' Jika data ditemukan
            If dt.Rows.Count > 0 Then
                ' Update last_login
                Dim updateQuery As String = "UPDATE user SET last_login = NOW() WHERE id = @id"
                Dim updateParams As New Dictionary(Of String, Object)
                updateParams.Add("@id", dt.Rows(0)("id"))
                ModuleConnection.ExecuteNonQuery(updateQuery, updateParams)

                LoginSuccess()
            Else
                lblStatus.Text = "Username atau password salah."
            End If
        Catch ex As Exception
            ' Tampilkan pesan error login
            lblStatus.Text = "Gagal login: " & ex.Message
        End Try
    End Sub

    ' Proses setelah login berhasil
    Private Sub LoginSuccess()
        MessageBox.Show("Login berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Bersihkan input dan reset label status
        lblStatus.Text = ""

        ' Buka form utama
        Dim formUtama As New FormMain()
        formUtama.Show()

        ' Sembunyikan form login
        Me.Hide()
    End Sub

    ' Event saat tombol Tutup diklik
    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    ' Event untuk menampilkan atau menyembunyikan password
    Private Sub chkShowPassword_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowPassword.CheckedChanged
        ' Toggle passwordChar 
        If chkShowPassword.Checked Then
            txtPassword.PasswordChar = Nothing ' Tampilkan password
        Else
            txtPassword.PasswordChar = "*"c ' Sembunyikan password
        End If
    End Sub

    ' Handle saat form ditutup
    Protected Overrides Sub OnFormClosed(ByVal e As FormClosedEventArgs)
        ' Jika form ini ditutup, tutup juga aplikasi
        If Application.OpenForms.Count = 1 Then
            Application.Exit()
        End If

        MyBase.OnFormClosed(e)
    End Sub
End Class
