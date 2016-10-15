<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Billing
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Billing))
        Me.lblInsurancePln = New System.Windows.Forms.Label()
        Me.lblInsuranceCmpyName = New System.Windows.Forms.Label()
        Me.lblRefill = New System.Windows.Forms.Label()
        Me.lblPrescriptionDate = New System.Windows.Forms.Label()
        Me.lblCustMobNo = New System.Windows.Forms.Label()
        Me.lblCustAddress = New System.Windows.Forms.Label()
        Me.lblCustLastName = New System.Windows.Forms.Label()
        Me.lblCustFirstName = New System.Windows.Forms.Label()
        Me.lblCustID = New System.Windows.Forms.Label()
        Me.lblPrescriptionID = New System.Windows.Forms.Label()
        Me.gdView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtDue = New System.Windows.Forms.TextBox()
        Me.txtCTotal = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblTotalDue = New System.Windows.Forms.Label()
        Me.lblTotalClaimableAmt = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtPrecId = New System.Windows.Forms.TextBox()
        Me.txtCusId = New System.Windows.Forms.TextBox()
        Me.txtCusFN = New System.Windows.Forms.TextBox()
        Me.txtCusLN = New System.Windows.Forms.TextBox()
        Me.txtCusAdd = New System.Windows.Forms.TextBox()
        Me.txtCusMN = New System.Windows.Forms.TextBox()
        Me.txtPrecDate = New System.Windows.Forms.TextBox()
        Me.txtRefil = New System.Windows.Forms.TextBox()
        Me.txtInsName = New System.Windows.Forms.TextBox()
        Me.txtInsPlan = New System.Windows.Forms.TextBox()
        Me.PrintForm = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.lblWelName = New System.Windows.Forms.Label()
        CType(Me.gdView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblInsurancePln
        '
        Me.lblInsurancePln.AutoSize = True
        Me.lblInsurancePln.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsurancePln.Location = New System.Drawing.Point(611, 169)
        Me.lblInsurancePln.Name = "lblInsurancePln"
        Me.lblInsurancePln.Size = New System.Drawing.Size(122, 18)
        Me.lblInsurancePln.TabIndex = 19
        Me.lblInsurancePln.Text = "InsurancePlan :"
        '
        'lblInsuranceCmpyName
        '
        Me.lblInsuranceCmpyName.AutoSize = True
        Me.lblInsuranceCmpyName.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsuranceCmpyName.Location = New System.Drawing.Point(611, 128)
        Me.lblInsuranceCmpyName.Name = "lblInsuranceCmpyName"
        Me.lblInsuranceCmpyName.Size = New System.Drawing.Size(218, 18)
        Me.lblInsuranceCmpyName.TabIndex = 18
        Me.lblInsuranceCmpyName.Text = "Insurance Company Name :"
        '
        'lblRefill
        '
        Me.lblRefill.AutoSize = True
        Me.lblRefill.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRefill.Location = New System.Drawing.Point(611, 91)
        Me.lblRefill.Name = "lblRefill"
        Me.lblRefill.Size = New System.Drawing.Size(53, 18)
        Me.lblRefill.TabIndex = 17
        Me.lblRefill.Text = "Refill :"
        '
        'lblPrescriptionDate
        '
        Me.lblPrescriptionDate.AutoSize = True
        Me.lblPrescriptionDate.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrescriptionDate.Location = New System.Drawing.Point(611, 47)
        Me.lblPrescriptionDate.Name = "lblPrescriptionDate"
        Me.lblPrescriptionDate.Size = New System.Drawing.Size(146, 18)
        Me.lblPrescriptionDate.TabIndex = 16
        Me.lblPrescriptionDate.Text = "Prescription Date :"
        '
        'lblCustMobNo
        '
        Me.lblCustMobNo.AutoSize = True
        Me.lblCustMobNo.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustMobNo.Location = New System.Drawing.Point(198, 255)
        Me.lblCustMobNo.Name = "lblCustMobNo"
        Me.lblCustMobNo.Size = New System.Drawing.Size(131, 18)
        Me.lblCustMobNo.TabIndex = 15
        Me.lblCustMobNo.Text = "MobileNumber : "
        '
        'lblCustAddress
        '
        Me.lblCustAddress.AutoSize = True
        Me.lblCustAddress.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustAddress.Location = New System.Drawing.Point(198, 213)
        Me.lblCustAddress.Name = "lblCustAddress"
        Me.lblCustAddress.Size = New System.Drawing.Size(79, 18)
        Me.lblCustAddress.TabIndex = 14
        Me.lblCustAddress.Text = "Address :"
        '
        'lblCustLastName
        '
        Me.lblCustLastName.AutoSize = True
        Me.lblCustLastName.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustLastName.Location = New System.Drawing.Point(198, 169)
        Me.lblCustLastName.Name = "lblCustLastName"
        Me.lblCustLastName.Size = New System.Drawing.Size(174, 18)
        Me.lblCustLastName.TabIndex = 13
        Me.lblCustLastName.Text = "Customer LastName :"
        '
        'lblCustFirstName
        '
        Me.lblCustFirstName.AutoSize = True
        Me.lblCustFirstName.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustFirstName.Location = New System.Drawing.Point(198, 128)
        Me.lblCustFirstName.Name = "lblCustFirstName"
        Me.lblCustFirstName.Size = New System.Drawing.Size(175, 18)
        Me.lblCustFirstName.TabIndex = 12
        Me.lblCustFirstName.Text = "Customer FirstName :"
        '
        'lblCustID
        '
        Me.lblCustID.AutoSize = True
        Me.lblCustID.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustID.Location = New System.Drawing.Point(198, 91)
        Me.lblCustID.Name = "lblCustID"
        Me.lblCustID.Size = New System.Drawing.Size(115, 18)
        Me.lblCustID.TabIndex = 11
        Me.lblCustID.Text = "Customer ID :"
        '
        'lblPrescriptionID
        '
        Me.lblPrescriptionID.AutoSize = True
        Me.lblPrescriptionID.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrescriptionID.Location = New System.Drawing.Point(198, 47)
        Me.lblPrescriptionID.Name = "lblPrescriptionID"
        Me.lblPrescriptionID.Size = New System.Drawing.Size(127, 18)
        Me.lblPrescriptionID.TabIndex = 10
        Me.lblPrescriptionID.Text = "Prescription ID :"
        '
        'gdView1
        '
        Me.gdView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gdView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.gdView1.Location = New System.Drawing.Point(156, 286)
        Me.gdView1.Name = "gdView1"
        Me.gdView1.Size = New System.Drawing.Size(648, 132)
        Me.gdView1.TabIndex = 20
        Me.gdView1.TabStop = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "Medicine Name"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "QuantityPerUnit"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Cost medicine"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "TotalCost"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Tier"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Total Claimble Amount"
        Me.Column6.Name = "Column6"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtDue)
        Me.Panel2.Controls.Add(Me.txtCTotal)
        Me.Panel2.Controls.Add(Me.txtTotal)
        Me.Panel2.Controls.Add(Me.lblTotalDue)
        Me.Panel2.Controls.Add(Me.lblTotalClaimableAmt)
        Me.Panel2.Controls.Add(Me.lblTotalCost)
        Me.Panel2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(76, 434)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(790, 135)
        Me.Panel2.TabIndex = 21
        '
        'txtDue
        '
        Me.txtDue.Location = New System.Drawing.Point(237, 94)
        Me.txtDue.Name = "txtDue"
        Me.txtDue.ReadOnly = True
        Me.txtDue.Size = New System.Drawing.Size(100, 26)
        Me.txtDue.TabIndex = 5
        '
        'txtCTotal
        '
        Me.txtCTotal.Location = New System.Drawing.Point(237, 54)
        Me.txtCTotal.Name = "txtCTotal"
        Me.txtCTotal.ReadOnly = True
        Me.txtCTotal.Size = New System.Drawing.Size(100, 26)
        Me.txtCTotal.TabIndex = 4
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(237, 3)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 26)
        Me.txtTotal.TabIndex = 3
        '
        'lblTotalDue
        '
        Me.lblTotalDue.AutoSize = True
        Me.lblTotalDue.Location = New System.Drawing.Point(14, 93)
        Me.lblTotalDue.Name = "lblTotalDue"
        Me.lblTotalDue.Size = New System.Drawing.Size(84, 18)
        Me.lblTotalDue.TabIndex = 2
        Me.lblTotalDue.Text = "TotalDue :"
        '
        'lblTotalClaimableAmt
        '
        Me.lblTotalClaimableAmt.AutoSize = True
        Me.lblTotalClaimableAmt.Location = New System.Drawing.Point(14, 57)
        Me.lblTotalClaimableAmt.Name = "lblTotalClaimableAmt"
        Me.lblTotalClaimableAmt.Size = New System.Drawing.Size(195, 18)
        Me.lblTotalClaimableAmt.TabIndex = 1
        Me.lblTotalClaimableAmt.Text = "Total Claimable Amount :"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Location = New System.Drawing.Point(14, 15)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(90, 18)
        Me.lblTotalCost.TabIndex = 0
        Me.lblTotalCost.Text = "TotalCost :"
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(630, 585)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(82, 32)
        Me.btnPrint.TabIndex = 24
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(421, 585)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(87, 32)
        Me.btnCancel.TabIndex = 23
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(236, 585)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(89, 32)
        Me.btnSave.TabIndex = 22
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtPrecId
        '
        Me.txtPrecId.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecId.Location = New System.Drawing.Point(408, 39)
        Me.txtPrecId.Name = "txtPrecId"
        Me.txtPrecId.ReadOnly = True
        Me.txtPrecId.Size = New System.Drawing.Size(140, 26)
        Me.txtPrecId.TabIndex = 25
        '
        'txtCusId
        '
        Me.txtCusId.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusId.Location = New System.Drawing.Point(408, 83)
        Me.txtCusId.Name = "txtCusId"
        Me.txtCusId.ReadOnly = True
        Me.txtCusId.Size = New System.Drawing.Size(140, 26)
        Me.txtCusId.TabIndex = 26
        '
        'txtCusFN
        '
        Me.txtCusFN.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusFN.Location = New System.Drawing.Point(408, 125)
        Me.txtCusFN.Name = "txtCusFN"
        Me.txtCusFN.ReadOnly = True
        Me.txtCusFN.Size = New System.Drawing.Size(140, 26)
        Me.txtCusFN.TabIndex = 27
        '
        'txtCusLN
        '
        Me.txtCusLN.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusLN.Location = New System.Drawing.Point(408, 161)
        Me.txtCusLN.Name = "txtCusLN"
        Me.txtCusLN.ReadOnly = True
        Me.txtCusLN.Size = New System.Drawing.Size(140, 26)
        Me.txtCusLN.TabIndex = 28
        '
        'txtCusAdd
        '
        Me.txtCusAdd.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusAdd.Location = New System.Drawing.Point(408, 205)
        Me.txtCusAdd.Name = "txtCusAdd"
        Me.txtCusAdd.ReadOnly = True
        Me.txtCusAdd.Size = New System.Drawing.Size(140, 26)
        Me.txtCusAdd.TabIndex = 29
        '
        'txtCusMN
        '
        Me.txtCusMN.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusMN.Location = New System.Drawing.Point(408, 247)
        Me.txtCusMN.Name = "txtCusMN"
        Me.txtCusMN.ReadOnly = True
        Me.txtCusMN.Size = New System.Drawing.Size(140, 26)
        Me.txtCusMN.TabIndex = 30
        '
        'txtPrecDate
        '
        Me.txtPrecDate.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecDate.Location = New System.Drawing.Point(835, 39)
        Me.txtPrecDate.Name = "txtPrecDate"
        Me.txtPrecDate.ReadOnly = True
        Me.txtPrecDate.Size = New System.Drawing.Size(136, 26)
        Me.txtPrecDate.TabIndex = 31
        '
        'txtRefil
        '
        Me.txtRefil.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefil.Location = New System.Drawing.Point(835, 83)
        Me.txtRefil.Name = "txtRefil"
        Me.txtRefil.ReadOnly = True
        Me.txtRefil.Size = New System.Drawing.Size(136, 26)
        Me.txtRefil.TabIndex = 32
        '
        'txtInsName
        '
        Me.txtInsName.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInsName.Location = New System.Drawing.Point(835, 120)
        Me.txtInsName.Name = "txtInsName"
        Me.txtInsName.ReadOnly = True
        Me.txtInsName.Size = New System.Drawing.Size(136, 26)
        Me.txtInsName.TabIndex = 33
        '
        'txtInsPlan
        '
        Me.txtInsPlan.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInsPlan.Location = New System.Drawing.Point(835, 161)
        Me.txtInsPlan.Name = "txtInsPlan"
        Me.txtInsPlan.ReadOnly = True
        Me.txtInsPlan.Size = New System.Drawing.Size(136, 26)
        Me.txtInsPlan.TabIndex = 34
        '
        'PrintForm
        '
        Me.PrintForm.DocumentName = "document"
        Me.PrintForm.Form = Me
        Me.PrintForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.PrintForm.PrinterSettings = CType(resources.GetObject("PrintForm.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm.PrintFileName = Nothing
        '
        'lblWelName
        '
        Me.lblWelName.AutoSize = True
        Me.lblWelName.Location = New System.Drawing.Point(850, 13)
        Me.lblWelName.Name = "lblWelName"
        Me.lblWelName.Size = New System.Drawing.Size(0, 13)
        Me.lblWelName.TabIndex = 35
        '
        'Billing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1022, 633)
        Me.Controls.Add(Me.lblWelName)
        Me.Controls.Add(Me.txtInsPlan)
        Me.Controls.Add(Me.txtInsName)
        Me.Controls.Add(Me.txtRefil)
        Me.Controls.Add(Me.txtPrecDate)
        Me.Controls.Add(Me.txtCusMN)
        Me.Controls.Add(Me.txtCusAdd)
        Me.Controls.Add(Me.txtCusLN)
        Me.Controls.Add(Me.txtCusFN)
        Me.Controls.Add(Me.txtCusId)
        Me.Controls.Add(Me.txtPrecId)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.gdView1)
        Me.Controls.Add(Me.lblInsurancePln)
        Me.Controls.Add(Me.lblInsuranceCmpyName)
        Me.Controls.Add(Me.lblRefill)
        Me.Controls.Add(Me.lblPrescriptionDate)
        Me.Controls.Add(Me.lblCustMobNo)
        Me.Controls.Add(Me.lblCustAddress)
        Me.Controls.Add(Me.lblCustLastName)
        Me.Controls.Add(Me.lblCustFirstName)
        Me.Controls.Add(Me.lblCustID)
        Me.Controls.Add(Me.lblPrescriptionID)
        Me.Name = "Billing"
        Me.Text = "Billing"
        CType(Me.gdView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblInsurancePln As System.Windows.Forms.Label
    Friend WithEvents lblInsuranceCmpyName As System.Windows.Forms.Label
    Friend WithEvents lblRefill As System.Windows.Forms.Label
    Friend WithEvents lblPrescriptionDate As System.Windows.Forms.Label
    Friend WithEvents lblCustMobNo As System.Windows.Forms.Label
    Friend WithEvents lblCustAddress As System.Windows.Forms.Label
    Friend WithEvents lblCustLastName As System.Windows.Forms.Label
    Friend WithEvents lblCustFirstName As System.Windows.Forms.Label
    Friend WithEvents lblCustID As System.Windows.Forms.Label
    Friend WithEvents lblPrescriptionID As System.Windows.Forms.Label
    Friend WithEvents gdView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblTotalDue As System.Windows.Forms.Label
    Friend WithEvents lblTotalClaimableAmt As System.Windows.Forms.Label
    Friend WithEvents lblTotalCost As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtPrecId As System.Windows.Forms.TextBox
    Friend WithEvents txtCusId As System.Windows.Forms.TextBox
    Friend WithEvents txtCusFN As System.Windows.Forms.TextBox
    Friend WithEvents txtCusLN As System.Windows.Forms.TextBox
    Friend WithEvents txtCusAdd As System.Windows.Forms.TextBox
    Friend WithEvents txtCusMN As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecDate As System.Windows.Forms.TextBox
    Friend WithEvents txtRefil As System.Windows.Forms.TextBox
    Friend WithEvents txtInsName As System.Windows.Forms.TextBox
    Friend WithEvents txtInsPlan As System.Windows.Forms.TextBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtDue As System.Windows.Forms.TextBox
    Friend WithEvents txtCTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents PrintForm As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents lblWelName As System.Windows.Forms.Label
End Class
