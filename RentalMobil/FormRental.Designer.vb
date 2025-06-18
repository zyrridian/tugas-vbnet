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
        Me.txtLamaSewa = New System.Windows.Forms.TextBox()
        Me.txtHargaPerhari = New System.Windows.Forms.TextBox()
        Me.txtTotalBiaya = New System.Windows.Forms.TextBox()
        Me.cmbPembayaran = New System.Windows.Forms.ComboBox()
        Me.txtCatatan = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTelp = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmbPelanggan = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnProses
        '
        Me.btnProses.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnProses.FlatAppearance.BorderSize = 0
        Me.btnProses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProses.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnProses.ForeColor = System.Drawing.Color.White
        Me.btnProses.Location = New System.Drawing.Point(200, 20)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(120, 36)
        Me.btnProses.TabIndex = 11
        Me.btnProses.Text = "Proses"
        Me.btnProses.UseVisualStyleBackColor = False
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnBatal.FlatAppearance.BorderSize = 0
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnBatal.ForeColor = System.Drawing.Color.White
        Me.btnBatal.Location = New System.Drawing.Point(330, 20)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(90, 36)
        Me.btnBatal.TabIndex = 12
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(21, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pelanggan:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(21, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mobil"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(21, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tanggal Sewa"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(21, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Tanggal Kembali"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(21, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 19)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Lama Sewa (Hari)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(21, 250)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 19)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Harga per Hari"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(21, 285)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 19)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Total Biaya"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(21, 321)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 19)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Pembayaran"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(21, 355)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 19)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Catatan Tambahan"
        '
        'txtNama
        '
        Me.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNama.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.Location = New System.Drawing.Point(150, 90)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(270, 25)
        Me.txtNama.TabIndex = 1
        '
        'cmbMobil
        '
        Me.cmbMobil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMobil.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMobil.FormattingEnabled = True
        Me.cmbMobil.Location = New System.Drawing.Point(145, 108)
        Me.cmbMobil.Name = "cmbMobil"
        Me.cmbMobil.Size = New System.Drawing.Size(210, 25)
        Me.cmbMobil.TabIndex = 3
        '
        'dtpSewa
        '
        Me.dtpSewa.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpSewa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSewa.Location = New System.Drawing.Point(145, 143)
        Me.dtpSewa.Name = "dtpSewa"
        Me.dtpSewa.Size = New System.Drawing.Size(160, 25)
        Me.dtpSewa.TabIndex = 4
        '
        'dtpKembali
        '
        Me.dtpKembali.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpKembali.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpKembali.Location = New System.Drawing.Point(145, 178)
        Me.dtpKembali.Name = "dtpKembali"
        Me.dtpKembali.Size = New System.Drawing.Size(160, 25)
        Me.dtpKembali.TabIndex = 5
        '
        'txtLamaSewa
        '
        Me.txtLamaSewa.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtLamaSewa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLamaSewa.Enabled = False
        Me.txtLamaSewa.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLamaSewa.Location = New System.Drawing.Point(145, 213)
        Me.txtLamaSewa.Name = "txtLamaSewa"
        Me.txtLamaSewa.Size = New System.Drawing.Size(32, 25)
        Me.txtLamaSewa.TabIndex = 6
        '
        'txtHargaPerhari
        '
        Me.txtHargaPerhari.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtHargaPerhari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHargaPerhari.Enabled = False
        Me.txtHargaPerhari.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtHargaPerhari.Location = New System.Drawing.Point(145, 248)
        Me.txtHargaPerhari.Name = "txtHargaPerhari"
        Me.txtHargaPerhari.Size = New System.Drawing.Size(120, 25)
        Me.txtHargaPerhari.TabIndex = 7
        '
        'txtTotalBiaya
        '
        Me.txtTotalBiaya.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtTotalBiaya.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalBiaya.Enabled = False
        Me.txtTotalBiaya.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalBiaya.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtTotalBiaya.Location = New System.Drawing.Point(145, 283)
        Me.txtTotalBiaya.Name = "txtTotalBiaya"
        Me.txtTotalBiaya.Size = New System.Drawing.Size(120, 25)
        Me.txtTotalBiaya.TabIndex = 8
        '
        'cmbPembayaran
        '
        Me.cmbPembayaran.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPembayaran.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPembayaran.FormattingEnabled = True
        Me.cmbPembayaran.Location = New System.Drawing.Point(145, 318)
        Me.cmbPembayaran.Name = "cmbPembayaran"
        Me.cmbPembayaran.Size = New System.Drawing.Size(170, 25)
        Me.cmbPembayaran.TabIndex = 9
        '
        'txtCatatan
        '
        Me.txtCatatan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCatatan.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCatatan.Location = New System.Drawing.Point(145, 353)
        Me.txtCatatan.Multiline = True
        Me.txtCatatan.Name = "txtCatatan"
        Me.txtCatatan.Size = New System.Drawing.Size(270, 60)
        Me.txtCatatan.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(20, 125)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 17)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Nomor Telepon"
        '
        'txtTelp
        '
        Me.txtTelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelp.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelp.Location = New System.Drawing.Point(150, 125)
        Me.txtTelp.Name = "txtTelp"
        Me.txtTelp.Size = New System.Drawing.Size(200, 25)
        Me.txtTelp.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(450, 60)
        Me.Panel1.TabIndex = 21
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(20, 16)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(140, 28)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Proses Rental"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.btnProses)
        Me.Panel2.Controls.Add(Me.btnBatal)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 432)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(450, 70)
        Me.Panel2.TabIndex = 22
        '
        'cmbPelanggan
        '
        Me.cmbPelanggan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPelanggan.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.cmbPelanggan.FormattingEnabled = True
        Me.cmbPelanggan.Location = New System.Drawing.Point(145, 77)
        Me.cmbPelanggan.Name = "cmbPelanggan"
        Me.cmbPelanggan.Size = New System.Drawing.Size(270, 25)
        Me.cmbPelanggan.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 8)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 13)
        Me.Label12.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(5, 8)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(139, 15)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Dihitung secara otomatis"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Location = New System.Drawing.Point(275, 209)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(145, 30)
        Me.Panel3.TabIndex = 23
        '
        'FormRental
        '
        Me.AcceptButton = Me.btnProses
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(450, 502)
        Me.Controls.Add(Me.cmbPelanggan)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtCatatan)
        Me.Controls.Add(Me.cmbPembayaran)
        Me.Controls.Add(Me.txtTotalBiaya)
        Me.Controls.Add(Me.txtHargaPerhari)
        Me.Controls.Add(Me.txtLamaSewa)
        Me.Controls.Add(Me.dtpKembali)
        Me.Controls.Add(Me.dtpSewa)
        Me.Controls.Add(Me.cmbMobil)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FormRental"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proses Rental"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
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
    Friend WithEvents txtLamaSewa As System.Windows.Forms.TextBox
    Friend WithEvents txtHargaPerhari As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalBiaya As System.Windows.Forms.TextBox
    Friend WithEvents cmbPembayaran As System.Windows.Forms.ComboBox
    Friend WithEvents txtCatatan As System.Windows.Forms.TextBox
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtTelp As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmbPelanggan As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
End Class
