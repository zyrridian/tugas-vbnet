<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.lblDbStatus = New System.Windows.Forms.Label()
        Me.lblUserInfo = New System.Windows.Forms.Label()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.btnRental = New System.Windows.Forms.Button()
        Me.btnCar = New System.Windows.Forms.Button()
        Me.btnManageCustomer = New System.Windows.Forms.Button()
        Me.btnRentalList = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.pnlHeader.SuspendLayout()
        Me.pnlFooter.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(752, 60)
        Me.pnlHeader.TabIndex = 1
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(25, 15)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(304, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "APLIKASI RENTAL MOBIL V1"
        '
        'pnlFooter
        '
        Me.pnlFooter.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlFooter.Controls.Add(Me.lblDbStatus)
        Me.pnlFooter.Controls.Add(Me.lblUserInfo)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 433)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(752, 30)
        Me.pnlFooter.TabIndex = 2
        '
        'lblDbStatus
        '
        Me.lblDbStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDbStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblDbStatus.ForeColor = System.Drawing.Color.Green
        Me.lblDbStatus.Location = New System.Drawing.Point(541, 6)
        Me.lblDbStatus.Name = "lblDbStatus"
        Me.lblDbStatus.Size = New System.Drawing.Size(199, 18)
        Me.lblDbStatus.TabIndex = 1
        Me.lblDbStatus.Text = "Database: Connected"
        Me.lblDbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblUserInfo
        '
        Me.lblUserInfo.AutoSize = True
        Me.lblUserInfo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblUserInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblUserInfo.Location = New System.Drawing.Point(12, 7)
        Me.lblUserInfo.Name = "lblUserInfo"
        Me.lblUserInfo.Size = New System.Drawing.Size(109, 15)
        Me.lblUserInfo.TabIndex = 0
        Me.lblUserInfo.Text = "User: Administrator"
        '
        'pnlContent
        '
        Me.pnlContent.Controls.Add(Me.btnRental)
        Me.pnlContent.Controls.Add(Me.btnCar)
        Me.pnlContent.Controls.Add(Me.btnManageCustomer)
        Me.pnlContent.Controls.Add(Me.btnRentalList)
        Me.pnlContent.Controls.Add(Me.btnReports)
        Me.pnlContent.Controls.Add(Me.btnLogout)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(0, 60)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(752, 373)
        Me.pnlContent.TabIndex = 3
        '
        'btnRental
        '
        Me.btnRental.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnRental.FlatAppearance.BorderSize = 0
        Me.btnRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRental.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnRental.ForeColor = System.Drawing.Color.White
        Me.btnRental.Image = Global.RentalMobil.My.Resources.Resources.add
        Me.btnRental.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRental.Location = New System.Drawing.Point(32, 30)
        Me.btnRental.Name = "btnRental"
        Me.btnRental.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.btnRental.Size = New System.Drawing.Size(224, 152)
        Me.btnRental.TabIndex = 0
        Me.btnRental.Text = "New Rental"
        Me.btnRental.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRental.UseVisualStyleBackColor = False
        '
        'btnCar
        '
        Me.btnCar.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnCar.FlatAppearance.BorderSize = 0
        Me.btnCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCar.ForeColor = System.Drawing.Color.White
        Me.btnCar.Image = Global.RentalMobil.My.Resources.Resources.car
        Me.btnCar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCar.Location = New System.Drawing.Point(262, 30)
        Me.btnCar.Name = "btnCar"
        Me.btnCar.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.btnCar.Size = New System.Drawing.Size(224, 152)
        Me.btnCar.TabIndex = 0
        Me.btnCar.Text = "Manage Car"
        Me.btnCar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCar.UseVisualStyleBackColor = False
        '
        'btnManageCustomer
        '
        Me.btnManageCustomer.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnManageCustomer.FlatAppearance.BorderSize = 0
        Me.btnManageCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManageCustomer.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnManageCustomer.ForeColor = System.Drawing.Color.White
        Me.btnManageCustomer.Image = CType(resources.GetObject("btnManageCustomer.Image"), System.Drawing.Image)
        Me.btnManageCustomer.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnManageCustomer.Location = New System.Drawing.Point(492, 30)
        Me.btnManageCustomer.Name = "btnManageCustomer"
        Me.btnManageCustomer.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.btnManageCustomer.Size = New System.Drawing.Size(224, 152)
        Me.btnManageCustomer.TabIndex = 0
        Me.btnManageCustomer.Text = "Manage Customers"
        Me.btnManageCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnManageCustomer.UseVisualStyleBackColor = False
        '
        'btnRentalList
        '
        Me.btnRentalList.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnRentalList.FlatAppearance.BorderSize = 0
        Me.btnRentalList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRentalList.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnRentalList.ForeColor = System.Drawing.Color.White
        Me.btnRentalList.Image = Global.RentalMobil.My.Resources.Resources.list
        Me.btnRentalList.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRentalList.Location = New System.Drawing.Point(32, 188)
        Me.btnRentalList.Name = "btnRentalList"
        Me.btnRentalList.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.btnRentalList.Size = New System.Drawing.Size(224, 152)
        Me.btnRentalList.TabIndex = 0
        Me.btnRentalList.Text = "Rental List"
        Me.btnRentalList.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRentalList.UseVisualStyleBackColor = False
        '
        'btnReports
        '
        Me.btnReports.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnReports.FlatAppearance.BorderSize = 0
        Me.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReports.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnReports.ForeColor = System.Drawing.Color.White
        Me.btnReports.Image = Global.RentalMobil.My.Resources.Resources.chart
        Me.btnReports.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnReports.Location = New System.Drawing.Point(262, 188)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.btnReports.Size = New System.Drawing.Size(224, 152)
        Me.btnReports.TabIndex = 0
        Me.btnReports.Text = "Reports"
        Me.btnReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnReports.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Crimson
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLogout.Location = New System.Drawing.Point(492, 188)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.btnLogout.Size = New System.Drawing.Size(224, 152)
        Me.btnLogout.TabIndex = 0
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(752, 463)
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.pnlFooter)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Utama"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlFooter.ResumeLayout(False)
        Me.pnlFooter.PerformLayout()
        Me.pnlContent.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRental As System.Windows.Forms.Button
    Friend WithEvents btnCar As System.Windows.Forms.Button
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnManageCustomer As System.Windows.Forms.Button
    Friend WithEvents btnRentalList As System.Windows.Forms.Button
    Friend WithEvents btnReports As System.Windows.Forms.Button
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents lblUserInfo As System.Windows.Forms.Label
    Friend WithEvents lblDbStatus As System.Windows.Forms.Label
End Class
