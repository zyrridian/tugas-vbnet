<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRental
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnProses = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.cmbMobil = New System.Windows.Forms.ComboBox()
        Me.dtpSewa = New System.Windows.Forms.DateTimePicker()
        Me.dtpKembali = New System.Windows.Forms.DateTimePicker()
        Me.dtpLamaSewa = New System.Windows.Forms.TextBox()
        Me.txtHargaPerhari = New System.Windows.Forms.TextBox()
        Me.txtTotalBiaya = New System.Windows.Forms.TextBox()
        Me.cmbPembayaran = New System.Windows.Forms.ComboBox()
        Me.txtCatatan = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTelp = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnProses
        '
        Me.btnProses.BackColor = System.Drawing.Color.DarkGreen
        Me.btnProses.FlatAppearance.BorderSize = 0
        Me.btnProses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProses.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnProses.ForeColor = System.Drawing.Color.White
        Me.btnProses.Location = New System.Drawing.Point(160, 405)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(120, 36)
        Me.btnProses.TabIndex = 11
        Me.btnProses.Text = "Proses"
        Me.btnProses.UseVisualStyleBackColor = False
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.DarkRed
        Me.btnBatal.FlatAppearance.BorderSize = 0
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnBatal.ForeColor = System.Drawing.Color.White
        Me.btnBatal.Location = New System.Drawing.Point(290, 405)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(70, 36)
        Me.btnBatal.TabIndex = 12
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(30, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nama Pelanggan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(30, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mobil"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(30, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tanggal Sewa"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(30, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Tanggal Kembali"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(30, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 19)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Lama Sewa (Hari)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(30, 230)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 19)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Harga per Hari"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(30, 265)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 19)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Total Biaya"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(30, 300)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 19)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Pembayaran"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(30, 335)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 19)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Catatan Tambahan"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(160, 18)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(200, 20)
        Me.txtNama.TabIndex = 1
        '
        'cmbMobil
        '
        Me.cmbMobil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMobil.FormattingEnabled = True
        Me.cmbMobil.Location = New System.Drawing.Point(160, 88)
        Me.cmbMobil.Name = "cmbMobil"
        Me.cmbMobil.Size = New System.Drawing.Size(200, 21)
        Me.cmbMobil.TabIndex = 3
        '
        'dtpSewa
        '
        Me.dtpSewa.Location = New System.Drawing.Point(160, 123)
        Me.dtpSewa.Name = "dtpSewa"
        Me.dtpSewa.Size = New System.Drawing.Size(200, 20)
        Me.dtpSewa.TabIndex = 4
        '
        'dtpKembali
        '
        Me.dtpKembali.Location = New System.Drawing.Point(160, 158)
        Me.dtpKembali.Name = "dtpKembali"
        Me.dtpKembali.Size = New System.Drawing.Size(200, 20)
        Me.dtpKembali.TabIndex = 5
        '
        'dtpLamaSewa
        '
        Me.dtpLamaSewa.Enabled = False
        Me.dtpLamaSewa.Location = New System.Drawing.Point(160, 193)
        Me.dtpLamaSewa.Name = "dtpLamaSewa"
        Me.dtpLamaSewa.Size = New System.Drawing.Size(60, 20)
        Me.dtpLamaSewa.TabIndex = 6
        '
        'txtHargaPerhari
        '
        Me.txtHargaPerhari.Location = New System.Drawing.Point(160, 228)
        Me.txtHargaPerhari.Name = "txtHargaPerhari"
        Me.txtHargaPerhari.Size = New System.Drawing.Size(100, 20)
        Me.txtHargaPerhari.TabIndex = 7
        '
        'txtTotalBiaya
        '
        Me.txtTotalBiaya.Enabled = False
        Me.txtTotalBiaya.Location = New System.Drawing.Point(160, 263)
        Me.txtTotalBiaya.Name = "txtTotalBiaya"
        Me.txtTotalBiaya.Size = New System.Drawing.Size(120, 20)
        Me.txtTotalBiaya.TabIndex = 8
        '
        'cmbPembayaran
        '
        Me.cmbPembayaran.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPembayaran.FormattingEnabled = True
        Me.cmbPembayaran.Location = New System.Drawing.Point(160, 298)
        Me.cmbPembayaran.Name = "cmbPembayaran"
        Me.cmbPembayaran.Size = New System.Drawing.Size(200, 21)
        Me.cmbPembayaran.TabIndex = 9
        '
        'txtCatatan
        '
        Me.txtCatatan.Location = New System.Drawing.Point(160, 333)
        Me.txtCatatan.Multiline = True
        Me.txtCatatan.Name = "txtCatatan"
        Me.txtCatatan.Size = New System.Drawing.Size(200, 60)
        Me.txtCatatan.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(30, 55)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 17)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Nomor Telepon"
        '
        'txtTelp
        '
        Me.txtTelp.Location = New System.Drawing.Point(160, 53)
        Me.txtTelp.Name = "txtTelp"
        Me.txtTelp.Size = New System.Drawing.Size(200, 20)
        Me.txtTelp.TabIndex = 2
        '
        'FormRental
        '
        Me.AcceptButton = Me.btnProses
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(420, 459)
        Me.Controls.Add(Me.txtTelp)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.txtCatatan)
        Me.Controls.Add(Me.cmbPembayaran)
        Me.Controls.Add(Me.txtTotalBiaya)
        Me.Controls.Add(Me.txtHargaPerhari)
        Me.Controls.Add(Me.dtpLamaSewa)
        Me.Controls.Add(Me.dtpKembali)
        Me.Controls.Add(Me.dtpSewa)
        Me.Controls.Add(Me.cmbMobil)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnProses)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormRental"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proses Rental"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnProses As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents cmbMobil As System.Windows.Forms.ComboBox
    Friend WithEvents dtpSewa As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpKembali As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpLamaSewa As System.Windows.Forms.TextBox
    Friend WithEvents txtHargaPerhari As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalBiaya As System.Windows.Forms.TextBox
    Friend WithEvents cmbPembayaran As System.Windows.Forms.ComboBox
    Friend WithEvents txtCatatan As System.Windows.Forms.TextBox
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtTelp As System.Windows.Forms.TextBox
End Class
