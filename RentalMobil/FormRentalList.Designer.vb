<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRentalList
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
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlToolbar = New System.Windows.Forms.Panel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.pnlSearch = New System.Windows.Forms.Panel()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.cmbFilter = New System.Windows.Forms.ComboBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.dgvRentals = New System.Windows.Forms.DataGridView()
        Me.colRentalID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCustomerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPhone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCarModel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRentDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colReturnDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDuration = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotalCost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlStatus = New System.Windows.Forms.Panel()
        Me.lblCompleted = New System.Windows.Forms.Label()
        Me.lblActive = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        Me.pnlToolbar.SuspendLayout()
        Me.pnlSearch.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        CType(Me.dgvRentals, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1000, 60)
        Me.pnlHeader.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(25, 18)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(120, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Rental List"
        '
        'pnlToolbar
        '
        Me.pnlToolbar.BackColor = System.Drawing.Color.White
        Me.pnlToolbar.Controls.Add(Me.btnDelete)
        Me.pnlToolbar.Controls.Add(Me.btnReturn)
        Me.pnlToolbar.Controls.Add(Me.btnTutup)
        Me.pnlToolbar.Controls.Add(Me.pnlSearch)
        Me.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlToolbar.Location = New System.Drawing.Point(0, 60)
        Me.pnlToolbar.Name = "pnlToolbar"
        Me.pnlToolbar.Padding = New System.Windows.Forms.Padding(25, 15, 25, 15)
        Me.pnlToolbar.Size = New System.Drawing.Size(1000, 70)
        Me.pnlToolbar.TabIndex = 1
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnDelete.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(705, 15)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(83, 40)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnReturn.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnReturn.FlatAppearance.BorderSize = 0
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnReturn.ForeColor = System.Drawing.Color.White
        Me.btnReturn.Location = New System.Drawing.Point(788, 15)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(108, 40)
        Me.btnReturn.TabIndex = 3
        Me.btnReturn.Text = "Return Car"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'btnTutup
        '
        Me.btnTutup.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnTutup.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnTutup.FlatAppearance.BorderSize = 0
        Me.btnTutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTutup.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnTutup.ForeColor = System.Drawing.Color.White
        Me.btnTutup.Location = New System.Drawing.Point(896, 15)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(79, 40)
        Me.btnTutup.TabIndex = 1
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.UseVisualStyleBackColor = False
        '
        'pnlSearch
        '
        Me.pnlSearch.Controls.Add(Me.lblFilter)
        Me.pnlSearch.Controls.Add(Me.cmbFilter)
        Me.pnlSearch.Controls.Add(Me.lblSearch)
        Me.pnlSearch.Controls.Add(Me.txtSearch)
        Me.pnlSearch.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSearch.Location = New System.Drawing.Point(25, 15)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(500, 40)
        Me.pnlSearch.TabIndex = 0
        '
        'lblFilter
        '
        Me.lblFilter.AutoSize = True
        Me.lblFilter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblFilter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.lblFilter.Location = New System.Drawing.Point(275, 12)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(33, 15)
        Me.lblFilter.TabIndex = 3
        Me.lblFilter.Text = "Filter"
        '
        'cmbFilter
        '
        Me.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFilter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmbFilter.FormattingEnabled = True
        Me.cmbFilter.Items.AddRange(New Object() {"All Status", "Active", "Completed", "Overdue"})
        Me.cmbFilter.Location = New System.Drawing.Point(310, 8)
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(173, 23)
        Me.cmbFilter.TabIndex = 2
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.lblSearch.Location = New System.Drawing.Point(5, 12)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(42, 15)
        Me.lblSearch.TabIndex = 1
        Me.lblSearch.Text = "Search"
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtSearch.Location = New System.Drawing.Point(60, 8)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(200, 25)
        Me.txtSearch.TabIndex = 0
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.pnlMain.Controls.Add(Me.dgvRentals)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 130)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Padding = New System.Windows.Forms.Padding(25, 20, 25, 20)
        Me.pnlMain.Size = New System.Drawing.Size(1000, 420)
        Me.pnlMain.TabIndex = 2
        '
        'dgvRentals
        '
        Me.dgvRentals.AllowUserToAddRows = False
        Me.dgvRentals.AllowUserToDeleteRows = False
        Me.dgvRentals.BackgroundColor = System.Drawing.Color.White
        Me.dgvRentals.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRentals.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colRentalID, Me.colCustomerName, Me.colPhone, Me.colCarModel, Me.colRentDate, Me.colReturnDate, Me.colDuration, Me.colTotalCost, Me.colStatus})
        Me.dgvRentals.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRentals.GridColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.dgvRentals.Location = New System.Drawing.Point(25, 20)
        Me.dgvRentals.MultiSelect = False
        Me.dgvRentals.Name = "dgvRentals"
        Me.dgvRentals.ReadOnly = True
        Me.dgvRentals.RowHeadersVisible = False
        Me.dgvRentals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRentals.Size = New System.Drawing.Size(950, 380)
        Me.dgvRentals.TabIndex = 0
        '
        'colRentalID
        '
        Me.colRentalID.HeaderText = "Rental ID"
        Me.colRentalID.Name = "colRentalID"
        Me.colRentalID.ReadOnly = True
        Me.colRentalID.Width = 80
        '
        'colCustomerName
        '
        Me.colCustomerName.HeaderText = "Customer Name"
        Me.colCustomerName.Name = "colCustomerName"
        Me.colCustomerName.ReadOnly = True
        Me.colCustomerName.Width = 150
        '
        'colPhone
        '
        Me.colPhone.HeaderText = "Phone"
        Me.colPhone.Name = "colPhone"
        Me.colPhone.ReadOnly = True
        '
        'colCarModel
        '
        Me.colCarModel.HeaderText = "Car Model"
        Me.colCarModel.Name = "colCarModel"
        Me.colCarModel.ReadOnly = True
        Me.colCarModel.Width = 120
        '
        'colRentDate
        '
        Me.colRentDate.HeaderText = "Rent Date"
        Me.colRentDate.Name = "colRentDate"
        Me.colRentDate.ReadOnly = True
        '
        'colReturnDate
        '
        Me.colReturnDate.HeaderText = "Return Date"
        Me.colReturnDate.Name = "colReturnDate"
        Me.colReturnDate.ReadOnly = True
        '
        'colDuration
        '
        Me.colDuration.HeaderText = "Duration (Days)"
        Me.colDuration.Name = "colDuration"
        Me.colDuration.ReadOnly = True
        Me.colDuration.Width = 90
        '
        'colTotalCost
        '
        Me.colTotalCost.HeaderText = "Total Cost"
        Me.colTotalCost.Name = "colTotalCost"
        Me.colTotalCost.ReadOnly = True
        '
        'colStatus
        '
        Me.colStatus.HeaderText = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.ReadOnly = True
        Me.colStatus.Width = 80
        '
        'pnlStatus
        '
        Me.pnlStatus.BackColor = System.Drawing.Color.White
        Me.pnlStatus.Controls.Add(Me.lblCompleted)
        Me.pnlStatus.Controls.Add(Me.lblActive)
        Me.pnlStatus.Controls.Add(Me.lblTotal)
        Me.pnlStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlStatus.Location = New System.Drawing.Point(0, 550)
        Me.pnlStatus.Name = "pnlStatus"
        Me.pnlStatus.Padding = New System.Windows.Forms.Padding(25, 10, 25, 10)
        Me.pnlStatus.Size = New System.Drawing.Size(1000, 50)
        Me.pnlStatus.TabIndex = 3
        '
        'lblCompleted
        '
        Me.lblCompleted.AutoSize = True
        Me.lblCompleted.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblCompleted.ForeColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.lblCompleted.Location = New System.Drawing.Point(320, 15)
        Me.lblCompleted.Name = "lblCompleted"
        Me.lblCompleted.Size = New System.Drawing.Size(91, 19)
        Me.lblCompleted.TabIndex = 2
        Me.lblCompleted.Text = "Completed: 0"
        '
        'lblActive
        '
        Me.lblActive.AutoSize = True
        Me.lblActive.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblActive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.lblActive.Location = New System.Drawing.Point(200, 15)
        Me.lblActive.Name = "lblActive"
        Me.lblActive.Size = New System.Drawing.Size(61, 19)
        Me.lblActive.TabIndex = 1
        Me.lblActive.Text = "Active: 0"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(25, 15)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(110, 19)
        Me.lblTotal.TabIndex = 0
        Me.lblTotal.Text = "Total Rentals: 0"
        '
        'FormRentalList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlStatus)
        Me.Controls.Add(Me.pnlToolbar)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormRentalList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rental List"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlToolbar.ResumeLayout(False)
        Me.pnlSearch.ResumeLayout(False)
        Me.pnlSearch.PerformLayout()
        Me.pnlMain.ResumeLayout(False)
        CType(Me.dgvRentals, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlStatus.ResumeLayout(False)
        Me.pnlStatus.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlToolbar As Panel
    Friend WithEvents pnlSearch As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblSearch As Label
    Friend WithEvents cmbFilter As ComboBox
    Friend WithEvents lblFilter As Label
    Friend WithEvents btnTutup As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents pnlMain As Panel
    Friend WithEvents dgvRentals As DataGridView
    Friend WithEvents colRentalID As DataGridViewTextBoxColumn
    Friend WithEvents colCustomerName As DataGridViewTextBoxColumn
    Friend WithEvents colPhone As DataGridViewTextBoxColumn
    Friend WithEvents colCarModel As DataGridViewTextBoxColumn
    Friend WithEvents colRentDate As DataGridViewTextBoxColumn
    Friend WithEvents colReturnDate As DataGridViewTextBoxColumn
    Friend WithEvents colDuration As DataGridViewTextBoxColumn
    Friend WithEvents colTotalCost As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents pnlStatus As Panel
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblActive As Label
    Friend WithEvents lblCompleted As Label
End Class
