Public Class FormLogin
    Private Sub FormLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Fokus ke username saat form dibuka
        txtUsername.Focus()
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If username = "admin" AndAlso password = "123" Then
            MessageBox.Show("Login berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Buka form utama
            Dim formUtama As New FormMain()
            formUtama.Show()

            ' Bersihkan input
            txtUsername.Clear()
            txtPassword.Clear()
            txtUsername.Focus()

            ' Sembunyikan form login
            Me.Hide()
        Else
            MessageBox.Show("Username atau password salah.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Clear()
            txtPassword.Focus()
        End If
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        ' Bersihkan input
        txtUsername.Clear()
        txtPassword.Clear()
        txtUsername.Focus()
    End Sub
End Class
