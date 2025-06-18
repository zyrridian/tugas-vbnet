Imports MySql.Data.MySqlClient

Public Class FormMain
    ' Username user yang sedang login
    Public Shared LoggedInUsername As String = "admin"
    Public Shared LoggedInUserRole As String = "Administrator"

    ' Status database
    Private dbConnected As Boolean = False

    ' Event saat FormMain dimuat pertama kali
    Private Sub FormMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Menonaktifkan tombol maximize pada form
        Me.MaximizeBox = False

        ' Cek koneksi database dan update status
        CheckDatabaseConnection()

        ' Tampilkan informasi user yang login
        lblUserInfo.Text = "User: " & LoggedInUsername & " (" & LoggedInUserRole & ")"
    End Sub

    ' Method untuk memeriksa koneksi database
    Private Sub CheckDatabaseConnection()
        Try
            Dim conn As MySqlConnection = ModuleConnection.OpenConnection()
            If conn IsNot Nothing Then
                dbConnected = True
                lblDbStatus.Text = "Database: Connected"
                lblDbStatus.ForeColor = System.Drawing.Color.Green
                ModuleConnection.CloseConnection()
            End If
        Catch ex As Exception
            dbConnected = False
            lblDbStatus.Text = "Database: Disconnected"
            lblDbStatus.ForeColor = System.Drawing.Color.Red
        End Try
    End Sub

    ' ======================
    ' === Navigasi Utama ===
    ' ======================

    ' Tombol untuk membuka form penyewaan mobil
    Private Sub btnRental_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRental.Click
        Dim form As New FormRental()
        form.ShowDialog()
    End Sub

    ' Tombol untuk membuka form data mobil
    Private Sub btnCar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCar.Click
        Dim form As New FormMobil()
        form.ShowDialog()
    End Sub

    ' Tombol untuk fitur kelola pelanggan
    Private Sub btnManageCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManageCustomer.Click
        Dim form As New FormCustomer()
        form.ShowDialog()
    End Sub

    ' Tombol untuk melihat daftar penyewaan
    Private Sub btnRentalList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRentalList.Click
        Dim form As New FormRentalList()
        form.ShowDialog()
    End Sub

    ' Tombol untuk melihat laporan
    Private Sub btnReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReports.Click
        Dim form As New FormReport()
        form.ShowDialog()
    End Sub

    ' =========================
    ' === Logout dari sistem ==
    ' =========================

    ' Tombol logout kembali ke form login
    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Tutup semua form yang mungkin sedang terbuka
            For Each form As Form In Application.OpenForms
                If form IsNot Me AndAlso form IsNot FormLogin Then
                    form.Close()
                End If
            Next

            ' Reset variable user yang login
            LoggedInUsername = ""
            LoggedInUserRole = ""

            ' Tampilkan form login
            FormLogin.Show()

            ' Tutup form utama
            Me.Close()
        End If
    End Sub

    ' =============================
    ' === Mencegah tombol [X] ====
    ' =============================

    ' Override CreateParams untuk menonaktifkan tombol close (X) di pojok kanan atas
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Const CS_NOCLOSE As Integer = &H200
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or CS_NOCLOSE
            Return cp
        End Get
    End Property

End Class
