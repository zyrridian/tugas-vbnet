Public Class FormMain

    ' Event saat FormMain dimuat pertama kali
    Private Sub FormMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Menonaktifkan tombol maximize pada form
        Me.MaximizeBox = False
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

    ' Tombol untuk fitur pembayaran (belum tersedia)
    Private Sub btnPayments_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayments.Click
        MessageBox.Show("Fitur ini akan tersedia segera!", "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Tombol untuk melihat daftar penyewaan (belum tersedia)
    Private Sub btnRentalList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRentalList.Click
        MessageBox.Show("Fitur ini akan tersedia segera!", "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Tombol untuk melihat laporan (belum tersedia)
    Private Sub btnReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReports.Click
        MessageBox.Show("Fitur ini akan tersedia segera!", "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' =========================
    ' === Logout dari sistem ==
    ' =========================

    ' Tombol logout kembali ke form login
    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Tutup FormRental jika sedang terbuka
            If Application.OpenForms().OfType(Of FormRental)().Any() Then
                Application.OpenForms("FormRental").Close()
            End If

            ' Tutup FormMobil jika sedang terbuka
            If Application.OpenForms().OfType(Of FormMobil)().Any() Then
                Application.OpenForms("FormMobil").Close()
            End If

            FormLogin.Show() ' Tampilkan kembali form login
            Me.Close()       ' Tutup form utama
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
