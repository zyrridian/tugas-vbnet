<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPayment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pnlCardDetails = New System.Windows.Forms.Panel()
        Me.txtCardName = New System.Windows.Forms.TextBox()
        Me.lblCardName = New System.Windows.Forms.Label()
        Me.txtCardNumber = New System.Windows.Forms.TextBox()
        Me.lblCardNumber = New System.Windows.Forms.Label()
        Me.pnlPaymentMethod = New System.Windows.Forms.Panel()
        Me.rbTransfer = New System.Windows.Forms.RadioButton()
        Me.rbCard = New System.Windows.Forms.RadioButton()
        Me.rbCash = New System.Windows.Forms.RadioButton()
        Me.lblPaymentMethod = New System.Windows.Forms.Label()
        Me.pnlPaymentDetails = New System.Windows.Forms.Panel()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.txtCarModel = New System.Windows.Forms.TextBox()
        Me.lblCarModel = New System.Windows.Forms.Label()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.txtRentalID = New System.Windows.Forms.TextBox()
        Me.lblRentalID = New System.Windows.Forms.Label()
        Me.lblPaymentDetails = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.pnlButtons.SuspendLayout()
        Me.pnlCardDetails.SuspendLayout()
        Me.pnlPaymentMethod.SuspendLayout()
        Me.pnlPaymentDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(650, 60)
        Me.pnlHeader.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(25, 18)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(189, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Payment Process"
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.pnlMain.Controls.Add(Me.pnlButtons)
        Me.pnlMain.Controls.Add(Me.pnlCardDetails)
        Me.pnlMain.Controls.Add(Me.pnlPaymentMethod)
        Me.pnlMain.Controls.Add(Me.pnlPaymentDetails)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 60)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Padding = New System.Windows.Forms.Padding(30)
        Me.pnlMain.Size = New System.Drawing.Size(650, 540)
        Me.pnlMain.TabIndex = 1
        '
        'pnlButtons
        '
        Me.pnlButtons.Controls.Add(Me.btnPrint)
        Me.pnlButtons.Controls.Add(Me.btnCancel)
        Me.pnlButtons.Controls.Add(Me.btnProcess)
        Me.pnlButtons.Controls.Add(Me.btnClose)
        Me.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlButtons.Location = New System.Drawing.Point(30, 460)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(590, 50)
        Me.pnlButtons.TabIndex = 3
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnPrint.Enabled = False
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(250, 10)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(90, 35)
        Me.btnPrint.TabIndex = 2
        Me.btnPrint.Text = "Print Receipt"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(470, 10)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 35)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnProcess
        '
        Me.btnProcess.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnProcess.FlatAppearance.BorderSize = 0
        Me.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcess.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnProcess.ForeColor = System.Drawing.Color.White
        Me.btnProcess.Location = New System.Drawing.Point(350, 10)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(110, 35)
        Me.btnProcess.TabIndex = 0
        Me.btnProcess.Text = "Process"
        Me.btnProcess.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(570, 10)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 35)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'pnlCardDetails
        '
        Me.pnlCardDetails.BackColor = System.Drawing.Color.White
        Me.pnlCardDetails.Controls.Add(Me.txtCardName)
        Me.pnlCardDetails.Controls.Add(Me.lblCardName)
        Me.pnlCardDetails.Controls.Add(Me.txtCardNumber)
        Me.pnlCardDetails.Controls.Add(Me.lblCardNumber)
        Me.pnlCardDetails.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCardDetails.Location = New System.Drawing.Point(30, 310)
        Me.pnlCardDetails.Name = "pnlCardDetails"
        Me.pnlCardDetails.Padding = New System.Windows.Forms.Padding(25)
        Me.pnlCardDetails.Size = New System.Drawing.Size(590, 120)
        Me.pnlCardDetails.TabIndex = 2
        Me.pnlCardDetails.Visible = False
        '
        'txtCardName
        '
        Me.txtCardName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCardName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtCardName.Location = New System.Drawing.Point(283, 43)
        Me.txtCardName.Name = "txtCardName"
        Me.txtCardName.Size = New System.Drawing.Size(200, 25)
        Me.txtCardName.TabIndex = 3
        '
        'lblCardName
        '
        Me.lblCardName.AutoSize = True
        Me.lblCardName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblCardName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.lblCardName.Location = New System.Drawing.Point(280, 25)
        Me.lblCardName.Name = "lblCardName"
        Me.lblCardName.Size = New System.Drawing.Size(101, 15)
        Me.lblCardName.TabIndex = 2
        Me.lblCardName.Text = "Cardholder Name"
        '
        'txtCardNumber
        '
        Me.txtCardNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCardNumber.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtCardNumber.Location = New System.Drawing.Point(28, 43)
        Me.txtCardNumber.Name = "txtCardNumber"
        Me.txtCardNumber.Size = New System.Drawing.Size(200, 25)
        Me.txtCardNumber.TabIndex = 1
        '
        'lblCardNumber
        '
        Me.lblCardNumber.AutoSize = True
        Me.lblCardNumber.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblCardNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.lblCardNumber.Location = New System.Drawing.Point(25, 25)
        Me.lblCardNumber.Name = "lblCardNumber"
        Me.lblCardNumber.Size = New System.Drawing.Size(79, 15)
        Me.lblCardNumber.TabIndex = 0
        Me.lblCardNumber.Text = "Card Number"
        '
        'pnlPaymentMethod
        '
        Me.pnlPaymentMethod.BackColor = System.Drawing.Color.White
        Me.pnlPaymentMethod.Controls.Add(Me.rbTransfer)
        Me.pnlPaymentMethod.Controls.Add(Me.rbCard)
        Me.pnlPaymentMethod.Controls.Add(Me.rbCash)
        Me.pnlPaymentMethod.Controls.Add(Me.lblPaymentMethod)
        Me.pnlPaymentMethod.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlPaymentMethod.Location = New System.Drawing.Point(30, 210)
        Me.pnlPaymentMethod.Name = "pnlPaymentMethod"
        Me.pnlPaymentMethod.Padding = New System.Windows.Forms.Padding(25)
        Me.pnlPaymentMethod.Size = New System.Drawing.Size(590, 100)
        Me.pnlPaymentMethod.TabIndex = 1
        '
        'rbTransfer
        '
        Me.rbTransfer.AutoSize = True
        Me.rbTransfer.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.rbTransfer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.rbTransfer.Location = New System.Drawing.Point(300, 55)
        Me.rbTransfer.Name = "rbTransfer"
        Me.rbTransfer.Size = New System.Drawing.Size(109, 23)
        Me.rbTransfer.TabIndex = 3
        Me.rbTransfer.Text = "Bank Transfer"
        Me.rbTransfer.UseVisualStyleBackColor = True
        '
        'rbCard
        '
        Me.rbCard.AutoSize = True
        Me.rbCard.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.rbCard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.rbCard.Location = New System.Drawing.Point(150, 55)
        Me.rbCard.Name = "rbCard"
        Me.rbCard.Size = New System.Drawing.Size(97, 23)
        Me.rbCard.TabIndex = 2
        Me.rbCard.Text = "Credit Card"
        Me.rbCard.UseVisualStyleBackColor = True
        '
        'rbCash
        '
        Me.rbCash.AutoSize = True
        Me.rbCash.Checked = True
        Me.rbCash.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.rbCash.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.rbCash.Location = New System.Drawing.Point(40, 55)
        Me.rbCash.Name = "rbCash"
        Me.rbCash.Size = New System.Drawing.Size(57, 23)
        Me.rbCash.TabIndex = 1
        Me.rbCash.TabStop = True
        Me.rbCash.Text = "Cash"
        Me.rbCash.UseVisualStyleBackColor = True
        '
        'lblPaymentMethod
        '
        Me.lblPaymentMethod.AutoSize = True
        Me.lblPaymentMethod.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPaymentMethod.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lblPaymentMethod.Location = New System.Drawing.Point(25, 25)
        Me.lblPaymentMethod.Name = "lblPaymentMethod"
        Me.lblPaymentMethod.Size = New System.Drawing.Size(142, 21)
        Me.lblPaymentMethod.TabIndex = 0
        Me.lblPaymentMethod.Text = "Payment Method"
        '
        'pnlPaymentDetails
        '
        Me.pnlPaymentDetails.BackColor = System.Drawing.Color.White
        Me.pnlPaymentDetails.Controls.Add(Me.txtTotalAmount)
        Me.pnlPaymentDetails.Controls.Add(Me.lblTotalAmount)
        Me.pnlPaymentDetails.Controls.Add(Me.txtCarModel)
        Me.pnlPaymentDetails.Controls.Add(Me.lblCarModel)
        Me.pnlPaymentDetails.Controls.Add(Me.txtCustomerName)
        Me.pnlPaymentDetails.Controls.Add(Me.lblCustomerName)
        Me.pnlPaymentDetails.Controls.Add(Me.txtRentalID)
        Me.pnlPaymentDetails.Controls.Add(Me.lblRentalID)
        Me.pnlPaymentDetails.Controls.Add(Me.lblPaymentDetails)
        Me.pnlPaymentDetails.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlPaymentDetails.Location = New System.Drawing.Point(30, 30)
        Me.pnlPaymentDetails.Name = "pnlPaymentDetails"
        Me.pnlPaymentDetails.Padding = New System.Windows.Forms.Padding(25)
        Me.pnlPaymentDetails.Size = New System.Drawing.Size(590, 180)
        Me.pnlPaymentDetails.TabIndex = 0
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.txtTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotalAmount.Enabled = False
        Me.txtTotalAmount.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotalAmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.txtTotalAmount.Location = New System.Drawing.Point(253, 128)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.Size = New System.Drawing.Size(120, 18)
        Me.txtTotalAmount.TabIndex = 8
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTotalAmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.lblTotalAmount.Location = New System.Drawing.Point(250, 110)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(79, 15)
        Me.lblTotalAmount.TabIndex = 7
        Me.lblTotalAmount.Text = "Total Amount"
        '
        'txtCarModel
        '
        Me.txtCarModel.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.txtCarModel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCarModel.Enabled = False
        Me.txtCarModel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtCarModel.Location = New System.Drawing.Point(28, 128)
        Me.txtCarModel.Name = "txtCarModel"
        Me.txtCarModel.Size = New System.Drawing.Size(150, 18)
        Me.txtCarModel.TabIndex = 6
        '
        'lblCarModel
        '
        Me.lblCarModel.AutoSize = True
        Me.lblCarModel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblCarModel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.lblCarModel.Location = New System.Drawing.Point(25, 110)
        Me.lblCarModel.Name = "lblCarModel"
        Me.lblCarModel.Size = New System.Drawing.Size(62, 15)
        Me.lblCarModel.TabIndex = 5
        Me.lblCarModel.Text = "Car Model"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCustomerName.Enabled = False
        Me.txtCustomerName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtCustomerName.Location = New System.Drawing.Point(178, 78)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(180, 18)
        Me.txtCustomerName.TabIndex = 4
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblCustomerName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.lblCustomerName.Location = New System.Drawing.Point(175, 60)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(94, 15)
        Me.lblCustomerName.TabIndex = 3
        Me.lblCustomerName.Text = "Customer Name"
        '
        'txtRentalID
        '
        Me.txtRentalID.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.txtRentalID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRentalID.Enabled = False
        Me.txtRentalID.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtRentalID.Location = New System.Drawing.Point(28, 78)
        Me.txtRentalID.Name = "txtRentalID"
        Me.txtRentalID.Size = New System.Drawing.Size(120, 18)
        Me.txtRentalID.TabIndex = 2
        '
        'lblRentalID
        '
        Me.lblRentalID.AutoSize = True
        Me.lblRentalID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblRentalID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.lblRentalID.Location = New System.Drawing.Point(25, 60)
        Me.lblRentalID.Name = "lblRentalID"
        Me.lblRentalID.Size = New System.Drawing.Size(54, 15)
        Me.lblRentalID.TabIndex = 1
        Me.lblRentalID.Text = "Rental ID"
        '
        'lblPaymentDetails
        '
        Me.lblPaymentDetails.AutoSize = True
        Me.lblPaymentDetails.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPaymentDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lblPaymentDetails.Location = New System.Drawing.Point(25, 25)
        Me.lblPaymentDetails.Name = "lblPaymentDetails"
        Me.lblPaymentDetails.Size = New System.Drawing.Size(135, 21)
        Me.lblPaymentDetails.TabIndex = 0
        Me.lblPaymentDetails.Text = "Payment Details"
        '
        'FormPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 600)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlButtons.ResumeLayout(False)
        Me.pnlCardDetails.ResumeLayout(False)
        Me.pnlCardDetails.PerformLayout()
        Me.pnlPaymentMethod.ResumeLayout(False)
        Me.pnlPaymentMethod.PerformLayout()
        Me.pnlPaymentDetails.ResumeLayout(False)
        Me.pnlPaymentDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlPaymentDetails As Panel
    Friend WithEvents lblPaymentDetails As Label
    Friend WithEvents lblRentalID As Label
    Friend WithEvents txtRentalID As TextBox
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents lblCarModel As Label
    Friend WithEvents txtCarModel As TextBox
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents txtTotalAmount As TextBox
    Friend WithEvents pnlPaymentMethod As Panel
    Friend WithEvents lblPaymentMethod As Label
    Friend WithEvents rbCash As RadioButton
    Friend WithEvents rbCard As RadioButton
    Friend WithEvents rbTransfer As RadioButton
    Friend WithEvents pnlCardDetails As Panel
    Friend WithEvents lblCardNumber As Label
    Friend WithEvents txtCardNumber As TextBox
    Friend WithEvents lblCardName As Label
    Friend WithEvents txtCardName As TextBox
    Friend WithEvents pnlButtons As Panel
    Friend WithEvents btnProcess As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnClose As Button
End Class