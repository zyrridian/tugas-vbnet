Imports MySql.Data.MySqlClient

Public Class FormPayment

    ' Variable untuk menyimpan ID rental yang sedang diproses
    Private rentalID As String = ""
    
    ' Event saat form pertama kali dimuat
    Private Sub FormPayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set default state
        pnlCardDetails.Visible = False
        btnPrint.Enabled = False
        
        ' Jika ada parameter rental ID, load data rental tersebut
        If Not String.IsNullOrEmpty(rentalID) Then
            LoadRentalData(rentalID)
        End If
    End Sub
    
    ' Method untuk memuat data rental berdasarkan ID
    Public Sub LoadRentalData(ByVal id As String)
        rentalID = id
        
        ' Dalam implementasi nyata, data akan diambil dari database
        ' Untuk contoh, kita gunakan data dummy
        txtRentalID.Text = id
        txtCustomerName.Text = "John Doe"
        txtCarModel.Text = "Toyota Avanza"
        txtTotalAmount.Text = "Rp 500.000"
    End Sub
    
    ' Event saat radio button dipilih untuk menampilkan/menyembunyikan panel kartu kredit
    Private Sub rbCard_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCard.CheckedChanged
        pnlCardDetails.Visible = rbCard.Checked
    End Sub
    
    ' Event saat tombol Process diklik
    Private Sub btnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcess.Click
        ' Validasi: jika metode pembayaran kartu kredit, pastikan detail kartu diisi
        If rbCard.Checked Then
            If String.IsNullOrEmpty(txtCardNumber.Text.Trim()) OrElse String.IsNullOrEmpty(txtCardName.Text.Trim()) Then
                MessageBox.Show("Detail kartu kredit harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        End If
        
        ' Proses pembayaran (dalam implementasi nyata, ini akan terhubung ke database)
        Dim paymentMethod As String = ""
        If rbCash.Checked Then
            paymentMethod = "Cash"
        ElseIf rbCard.Checked Then
            paymentMethod = "Credit Card"
        ElseIf rbTransfer.Checked Then
            paymentMethod = "Bank Transfer"
        End If
        
        ' Tampilkan konfirmasi
        MessageBox.Show("Pembayaran " & paymentMethod & " berhasil diproses!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        
        ' Aktifkan tombol cetak
        btnPrint.Enabled = True
    End Sub
    
    ' Event saat tombol Print diklik
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        MessageBox.Show("Mencetak bukti pembayaran...", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' Implementasi cetak akan ditambahkan di sini
    End Sub
    
    ' Event saat tombol Cancel diklik
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    
    ' Event saat tombol Close diklik
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class