<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReport
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
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.tabReport = New System.Windows.Forms.TabControl()
        Me.tabRentalReport = New System.Windows.Forms.TabPage()
        Me.dgvRentalReport = New System.Windows.Forms.DataGridView()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCustomer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMobil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTglSewa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTglKembali = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDurasi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBiaya = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlFilter = New System.Windows.Forms.Panel()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.dtpAkhir = New System.Windows.Forms.DateTimePicker()
        Me.lblSampai = New System.Windows.Forms.Label()
        Me.dtpAwal = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tabReportGrafik = New System.Windows.Forms.TabPage()
        Me.chartPendapatan = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.pnlFilterGrafik = New System.Windows.Forms.Panel()
        Me.btnFilterGrafik = New System.Windows.Forms.Button()
        Me.cmbTahun = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.pnlHeader.SuspendLayout()
        Me.tabReport.SuspendLayout()
        Me.tabRentalReport.SuspendLayout()
        CType(Me.dgvRentalReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFilter.SuspendLayout()
        Me.tabReportGrafik.SuspendLayout()
        CType(Me.chartPendapatan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFilterGrafik.SuspendLayout()
        Me.pnlFooter.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(884, 60)
        Me.pnlHeader.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(25, 15)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(195, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Laporan Penyewa"
        '
        'tabReport
        '
        Me.tabReport.Controls.Add(Me.tabRentalReport)
        Me.tabReport.Controls.Add(Me.tabReportGrafik)
        Me.tabReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabReport.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.tabReport.Location = New System.Drawing.Point(0, 60)
        Me.tabReport.Name = "tabReport"
        Me.tabReport.SelectedIndex = 0
        Me.tabReport.Size = New System.Drawing.Size(884, 421)
        Me.tabReport.TabIndex = 1
        '
        'tabRentalReport
        '
        Me.tabRentalReport.Controls.Add(Me.dgvRentalReport)
        Me.tabRentalReport.Controls.Add(Me.pnlFilter)
        Me.tabRentalReport.Location = New System.Drawing.Point(4, 26)
        Me.tabRentalReport.Name = "tabRentalReport"
        Me.tabRentalReport.Padding = New System.Windows.Forms.Padding(3)
        Me.tabRentalReport.Size = New System.Drawing.Size(876, 391)
        Me.tabRentalReport.TabIndex = 0
        Me.tabRentalReport.Text = "Laporan Penyewaan"
        Me.tabRentalReport.UseVisualStyleBackColor = True
        '
        'dgvRentalReport
        '
        Me.dgvRentalReport.AllowUserToAddRows = False
        Me.dgvRentalReport.AllowUserToDeleteRows = False
        Me.dgvRentalReport.BackgroundColor = System.Drawing.Color.White
        Me.dgvRentalReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRentalReport.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colCustomer, Me.colMobil, Me.colTglSewa, Me.colTglKembali, Me.colDurasi, Me.colBiaya})
        Me.dgvRentalReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRentalReport.Location = New System.Drawing.Point(3, 83)
        Me.dgvRentalReport.Name = "dgvRentalReport"
        Me.dgvRentalReport.ReadOnly = True
        Me.dgvRentalReport.Size = New System.Drawing.Size(870, 305)
        Me.dgvRentalReport.TabIndex = 1
        '
        'colID
        '
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.Width = 50
        '
        'colCustomer
        '
        Me.colCustomer.HeaderText = "Customer"
        Me.colCustomer.Name = "colCustomer"
        Me.colCustomer.ReadOnly = True
        Me.colCustomer.Width = 150
        '
        'colMobil
        '
        Me.colMobil.HeaderText = "Mobil"
        Me.colMobil.Name = "colMobil"
        Me.colMobil.ReadOnly = True
        Me.colMobil.Width = 120
        '
        'colTglSewa
        '
        Me.colTglSewa.HeaderText = "Tgl Sewa"
        Me.colTglSewa.Name = "colTglSewa"
        Me.colTglSewa.ReadOnly = True
        '
        'colTglKembali
        '
        Me.colTglKembali.HeaderText = "Tgl Kembali"
        Me.colTglKembali.Name = "colTglKembali"
        Me.colTglKembali.ReadOnly = True
        Me.colTglKembali.Width = 110
        '
        'colDurasi
        '
        Me.colDurasi.HeaderText = "Durasi"
        Me.colDurasi.Name = "colDurasi"
        Me.colDurasi.ReadOnly = True
        Me.colDurasi.Width = 60
        '
        'colBiaya
        '
        Me.colBiaya.HeaderText = "Total Biaya"
        Me.colBiaya.Name = "colBiaya"
        Me.colBiaya.ReadOnly = True
        Me.colBiaya.Width = 130
        '
        'pnlFilter
        '
        Me.pnlFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pnlFilter.Controls.Add(Me.btnFilter)
        Me.pnlFilter.Controls.Add(Me.dtpAkhir)
        Me.pnlFilter.Controls.Add(Me.lblSampai)
        Me.pnlFilter.Controls.Add(Me.dtpAwal)
        Me.pnlFilter.Controls.Add(Me.Label3)
        Me.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFilter.Location = New System.Drawing.Point(3, 3)
        Me.pnlFilter.Name = "pnlFilter"
        Me.pnlFilter.Size = New System.Drawing.Size(870, 80)
        Me.pnlFilter.TabIndex = 0
        '
        'btnFilter
        '
        Me.btnFilter.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnFilter.FlatAppearance.BorderSize = 0
        Me.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFilter.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnFilter.ForeColor = System.Drawing.Color.White
        Me.btnFilter.Location = New System.Drawing.Point(519, 26)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(90, 28)
        Me.btnFilter.TabIndex = 3
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = False
        '
        'dtpAkhir
        '
        Me.dtpAkhir.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAkhir.Location = New System.Drawing.Point(345, 28)
        Me.dtpAkhir.Name = "dtpAkhir"
        Me.dtpAkhir.Size = New System.Drawing.Size(150, 25)
        Me.dtpAkhir.TabIndex = 2
        '
        'lblSampai
        '
        Me.lblSampai.AutoSize = True
        Me.lblSampai.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.lblSampai.Location = New System.Drawing.Point(289, 33)
        Me.lblSampai.Name = "lblSampai"
        Me.lblSampai.Size = New System.Drawing.Size(50, 17)
        Me.lblSampai.TabIndex = 2
        Me.lblSampai.Text = "sampai"
        '
        'dtpAwal
        '
        Me.dtpAwal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAwal.Location = New System.Drawing.Point(133, 28)
        Me.dtpAwal.Name = "dtpAwal"
        Me.dtpAwal.Size = New System.Drawing.Size(150, 25)
        Me.dtpAwal.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(15, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Filter Tanggal  : "
        '
        'tabReportGrafik
        '
        Me.tabReportGrafik.Controls.Add(Me.chartPendapatan)
        Me.tabReportGrafik.Controls.Add(Me.pnlFilterGrafik)
        Me.tabReportGrafik.Location = New System.Drawing.Point(4, 26)
        Me.tabReportGrafik.Name = "tabReportGrafik"
        Me.tabReportGrafik.Padding = New System.Windows.Forms.Padding(3)
        Me.tabReportGrafik.Size = New System.Drawing.Size(876, 451)
        Me.tabReportGrafik.TabIndex = 1
        Me.tabReportGrafik.Text = "Grafik Pendapatan"
        Me.tabReportGrafik.UseVisualStyleBackColor = True
        '
        'chartPendapatan
        '
        ChartArea3.Name = "ChartArea1"
        Me.chartPendapatan.ChartAreas.Add(ChartArea3)
        Me.chartPendapatan.Dock = System.Windows.Forms.DockStyle.Fill
        Legend3.Name = "Legend1"
        Me.chartPendapatan.Legends.Add(Legend3)
        Me.chartPendapatan.Location = New System.Drawing.Point(3, 83)
        Me.chartPendapatan.Name = "chartPendapatan"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Pendapatan"
        Me.chartPendapatan.Series.Add(Series3)
        Me.chartPendapatan.Size = New System.Drawing.Size(870, 365)
        Me.chartPendapatan.TabIndex = 1
        Me.chartPendapatan.Text = "Grafik Pendapatan"
        '
        'pnlFilterGrafik
        '
        Me.pnlFilterGrafik.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pnlFilterGrafik.Controls.Add(Me.btnFilterGrafik)
        Me.pnlFilterGrafik.Controls.Add(Me.cmbTahun)
        Me.pnlFilterGrafik.Controls.Add(Me.Label1)
        Me.pnlFilterGrafik.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFilterGrafik.Location = New System.Drawing.Point(3, 3)
        Me.pnlFilterGrafik.Name = "pnlFilterGrafik"
        Me.pnlFilterGrafik.Size = New System.Drawing.Size(870, 80)
        Me.pnlFilterGrafik.TabIndex = 0
        '
        'btnFilterGrafik
        '
        Me.btnFilterGrafik.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnFilterGrafik.FlatAppearance.BorderSize = 0
        Me.btnFilterGrafik.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFilterGrafik.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnFilterGrafik.ForeColor = System.Drawing.Color.White
        Me.btnFilterGrafik.Location = New System.Drawing.Point(258, 28)
        Me.btnFilterGrafik.Name = "btnFilterGrafik"
        Me.btnFilterGrafik.Size = New System.Drawing.Size(90, 28)
        Me.btnFilterGrafik.TabIndex = 2
        Me.btnFilterGrafik.Text = "Filter"
        Me.btnFilterGrafik.UseVisualStyleBackColor = False
        '
        'cmbTahun
        '
        Me.cmbTahun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTahun.FormattingEnabled = True
        Me.cmbTahun.Location = New System.Drawing.Point(133, 29)
        Me.cmbTahun.Name = "cmbTahun"
        Me.cmbTahun.Size = New System.Drawing.Size(107, 25)
        Me.cmbTahun.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(30, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pilih Tahun  : "
        '
        'pnlFooter
        '
        Me.pnlFooter.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlFooter.Controls.Add(Me.lblTotal)
        Me.pnlFooter.Controls.Add(Me.btnPrint)
        Me.pnlFooter.Controls.Add(Me.btnTutup)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 481)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(884, 60)
        Me.pnlFooter.TabIndex = 2
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotal.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.lblTotal.Location = New System.Drawing.Point(25, 19)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(189, 21)
        Me.lblTotal.TabIndex = 2
        Me.lblTotal.Text = "Total Pendapatan : Rp 0"
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(669, 12)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(100, 36)
        Me.btnPrint.TabIndex = 1
        Me.btnPrint.Text = "Cetak"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnTutup
        '
        Me.btnTutup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTutup.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnTutup.FlatAppearance.BorderSize = 0
        Me.btnTutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTutup.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnTutup.ForeColor = System.Drawing.Color.White
        Me.btnTutup.Location = New System.Drawing.Point(775, 12)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(80, 36)
        Me.btnTutup.TabIndex = 0
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.UseVisualStyleBackColor = False
        '
        'FormReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 541)
        Me.Controls.Add(Me.tabReport)
        Me.Controls.Add(Me.pnlFooter)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FormReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laporan"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.tabReport.ResumeLayout(False)
        Me.tabRentalReport.ResumeLayout(False)
        CType(Me.dgvRentalReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFilter.ResumeLayout(False)
        Me.pnlFilter.PerformLayout()
        Me.tabReportGrafik.ResumeLayout(False)
        CType(Me.chartPendapatan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFilterGrafik.ResumeLayout(False)
        Me.pnlFilterGrafik.PerformLayout()
        Me.pnlFooter.ResumeLayout(False)
        Me.pnlFooter.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents tabReport As TabControl
    Friend WithEvents tabRentalReport As TabPage
    Friend WithEvents tabReportGrafik As TabPage
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents btnTutup As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents pnlFilter As Panel
    Friend WithEvents dgvRentalReport As DataGridView
    Friend WithEvents dtpAwal As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents lblSampai As Label
    Friend WithEvents btnFilter As Button
    Friend WithEvents dtpAkhir As DateTimePicker
    Friend WithEvents pnlFilterGrafik As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbTahun As ComboBox
    Friend WithEvents btnFilterGrafik As Button
    Friend WithEvents chartPendapatan As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents colCustomer As DataGridViewTextBoxColumn
    Friend WithEvents colMobil As DataGridViewTextBoxColumn
    Friend WithEvents colTglSewa As DataGridViewTextBoxColumn
    Friend WithEvents colTglKembali As DataGridViewTextBoxColumn
    Friend WithEvents colDurasi As DataGridViewTextBoxColumn
    Friend WithEvents colBiaya As DataGridViewTextBoxColumn
End Class