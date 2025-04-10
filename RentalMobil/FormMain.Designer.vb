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
        Me.btnPayments = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnCar = New System.Windows.Forms.Button()
        Me.btnRental = New System.Windows.Forms.Button()
        Me.btnRentalList = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPayments
        '
        Me.btnPayments.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnPayments.FlatAppearance.BorderSize = 0
        Me.btnPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPayments.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnPayments.ForeColor = System.Drawing.Color.White
        Me.btnPayments.Image = Global.RentalMobil.My.Resources.Resources.payment
        Me.btnPayments.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPayments.Location = New System.Drawing.Point(560, 82)
        Me.btnPayments.Name = "btnPayments"
        Me.btnPayments.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.btnPayments.Size = New System.Drawing.Size(224, 152)
        Me.btnPayments.TabIndex = 0
        Me.btnPayments.Text = "Payments"
        Me.btnPayments.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPayments.UseVisualStyleBackColor = False
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
        Me.btnLogout.Location = New System.Drawing.Point(560, 240)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.btnLogout.Size = New System.Drawing.Size(224, 152)
        Me.btnLogout.TabIndex = 0
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLogout.UseVisualStyleBackColor = False
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
        Me.btnCar.Location = New System.Drawing.Point(330, 82)
        Me.btnCar.Name = "btnCar"
        Me.btnCar.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.btnCar.Size = New System.Drawing.Size(224, 152)
        Me.btnCar.TabIndex = 0
        Me.btnCar.Text = "Manage Car"
        Me.btnCar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCar.UseVisualStyleBackColor = False
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
        Me.btnRental.Location = New System.Drawing.Point(100, 82)
        Me.btnRental.Name = "btnRental"
        Me.btnRental.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.btnRental.Size = New System.Drawing.Size(224, 152)
        Me.btnRental.TabIndex = 0
        Me.btnRental.Text = "New Rental"
        Me.btnRental.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRental.UseVisualStyleBackColor = False
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
        Me.btnRentalList.Location = New System.Drawing.Point(100, 240)
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
        Me.btnReports.Location = New System.Drawing.Point(330, 240)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.btnReports.Size = New System.Drawing.Size(224, 152)
        Me.btnReports.TabIndex = 0
        Me.btnReports.Text = "Reports"
        Me.btnReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnReports.UseVisualStyleBackColor = False
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(882, 483)
        Me.Controls.Add(Me.btnReports)
        Me.Controls.Add(Me.btnRentalList)
        Me.Controls.Add(Me.btnPayments)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnCar)
        Me.Controls.Add(Me.btnRental)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Utama"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRental As System.Windows.Forms.Button
    Friend WithEvents btnCar As System.Windows.Forms.Button
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnPayments As System.Windows.Forms.Button
    Friend WithEvents btnRentalList As System.Windows.Forms.Button
    Friend WithEvents btnReports As System.Windows.Forms.Button

End Class
