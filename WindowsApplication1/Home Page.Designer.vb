<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home_Page
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnVendor = New System.Windows.Forms.Button()
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.btnSales = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnNewMed = New System.Windows.Forms.Button()
        Me.btnNewPrescription = New System.Windows.Forms.Button()
        Me.btnNewCustomers = New System.Windows.Forms.Button()
        Me.btnNewIns = New System.Windows.Forms.Button()
        Me.btnChngPasswd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lbltxt1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCusId = New System.Windows.Forms.TextBox()
        Me.txtPrecId = New System.Windows.Forms.TextBox()
        Me.dgcusDetail = New System.Windows.Forms.DataGridView()
        Me.customer_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Insurance_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.First_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Last_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Insurance_Start_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Inurance_Last_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mobile_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgInsDetail = New System.Windows.Forms.DataGridView()
        Me.ins_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ins_com_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ins_Plan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ins_Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Insurance_mobile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgMedDetail = New System.Windows.Forms.DataGridView()
        Me.medicine_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.medicine_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cost_Per_Unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total_Claim_Cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Due_Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSearchCust = New System.Windows.Forms.Button()
        Me.btnSearchPrescrip = New System.Windows.Forms.Button()
        Me.btnRefil = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblWelName = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgcusDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgInsDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgMedDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnChngPasswd)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(218, 545)
        Me.Panel1.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(15, 339)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Reports"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.btnVendor)
        Me.Panel4.Controls.Add(Me.btnInventory)
        Me.Panel4.Controls.Add(Me.btnSales)
        Me.Panel4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.ForeColor = System.Drawing.Color.Black
        Me.Panel4.Location = New System.Drawing.Point(18, 369)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(186, 163)
        Me.Panel4.TabIndex = 5
        '
        'btnVendor
        '
        Me.btnVendor.Location = New System.Drawing.Point(7, 119)
        Me.btnVendor.Name = "btnVendor"
        Me.btnVendor.Size = New System.Drawing.Size(164, 30)
        Me.btnVendor.TabIndex = 6
        Me.btnVendor.Text = "Vendor"
        Me.btnVendor.UseVisualStyleBackColor = True
        '
        'btnInventory
        '
        Me.btnInventory.Location = New System.Drawing.Point(7, 71)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(164, 32)
        Me.btnInventory.TabIndex = 5
        Me.btnInventory.Text = "Inventory"
        Me.btnInventory.UseVisualStyleBackColor = True
        '
        'btnSales
        '
        Me.btnSales.Location = New System.Drawing.Point(7, 24)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.Size = New System.Drawing.Size(164, 27)
        Me.btnSales.TabIndex = 4
        Me.btnSales.Text = "Sales"
        Me.btnSales.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "New"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnNewMed)
        Me.Panel2.Controls.Add(Me.btnNewPrescription)
        Me.Panel2.Controls.Add(Me.btnNewCustomers)
        Me.Panel2.Controls.Add(Me.btnNewIns)
        Me.Panel2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(18, 115)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(186, 205)
        Me.Panel2.TabIndex = 2
        '
        'btnNewMed
        '
        Me.btnNewMed.Location = New System.Drawing.Point(3, 164)
        Me.btnNewMed.Name = "btnNewMed"
        Me.btnNewMed.Size = New System.Drawing.Size(168, 30)
        Me.btnNewMed.TabIndex = 10
        Me.btnNewMed.Text = "New Medicine"
        Me.btnNewMed.UseVisualStyleBackColor = True
        '
        'btnNewPrescription
        '
        Me.btnNewPrescription.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewPrescription.Location = New System.Drawing.Point(3, 111)
        Me.btnNewPrescription.Name = "btnNewPrescription"
        Me.btnNewPrescription.Size = New System.Drawing.Size(168, 34)
        Me.btnNewPrescription.TabIndex = 3
        Me.btnNewPrescription.Text = "Customer Details"
        Me.btnNewPrescription.UseVisualStyleBackColor = True
        '
        'btnNewCustomers
        '
        Me.btnNewCustomers.Location = New System.Drawing.Point(3, 16)
        Me.btnNewCustomers.Name = "btnNewCustomers"
        Me.btnNewCustomers.Size = New System.Drawing.Size(168, 30)
        Me.btnNewCustomers.TabIndex = 2
        Me.btnNewCustomers.Text = "New Customer"
        Me.btnNewCustomers.UseVisualStyleBackColor = True
        '
        'btnNewIns
        '
        Me.btnNewIns.Location = New System.Drawing.Point(3, 65)
        Me.btnNewIns.Name = "btnNewIns"
        Me.btnNewIns.Size = New System.Drawing.Size(168, 30)
        Me.btnNewIns.TabIndex = 9
        Me.btnNewIns.Text = "Insurance Company"
        Me.btnNewIns.UseVisualStyleBackColor = True
        '
        'btnChngPasswd
        '
        Me.btnChngPasswd.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChngPasswd.ForeColor = System.Drawing.Color.Black
        Me.btnChngPasswd.Location = New System.Drawing.Point(15, 38)
        Me.btnChngPasswd.Name = "btnChngPasswd"
        Me.btnChngPasswd.Size = New System.Drawing.Size(175, 29)
        Me.btnChngPasswd.TabIndex = 1
        Me.btnChngPasswd.Text = "Change Password"
        Me.btnChngPasswd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(10, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Account"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(988, 31)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 31)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Logout"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lbltxt1
        '
        Me.lbltxt1.AutoSize = True
        Me.lbltxt1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltxt1.Location = New System.Drawing.Point(352, 44)
        Me.lbltxt1.Name = "lbltxt1"
        Me.lbltxt1.Size = New System.Drawing.Size(103, 18)
        Me.lbltxt1.TabIndex = 5
        Me.lbltxt1.Text = "Customer ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(352, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 18)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Prescription ID"
        '
        'txtCusId
        '
        Me.txtCusId.AcceptsTab = True
        Me.txtCusId.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusId.Location = New System.Drawing.Point(493, 42)
        Me.txtCusId.Name = "txtCusId"
        Me.txtCusId.Size = New System.Drawing.Size(100, 26)
        Me.txtCusId.TabIndex = 7
        '
        'txtPrecId
        '
        Me.txtPrecId.AcceptsTab = True
        Me.txtPrecId.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecId.Location = New System.Drawing.Point(493, 79)
        Me.txtPrecId.Name = "txtPrecId"
        Me.txtPrecId.Size = New System.Drawing.Size(100, 26)
        Me.txtPrecId.TabIndex = 9
        '
        'dgcusDetail
        '
        Me.dgcusDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgcusDetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.customer_Id, Me.Insurance_Id, Me.First_Name, Me.Last_Name, Me.Address, Me.Insurance_Start_Date, Me.Inurance_Last_Date, Me.mobile_number})
        Me.dgcusDetail.Location = New System.Drawing.Point(234, 116)
        Me.dgcusDetail.Name = "dgcusDetail"
        Me.dgcusDetail.Size = New System.Drawing.Size(831, 79)
        Me.dgcusDetail.TabIndex = 9
        Me.dgcusDetail.TabStop = False
        '
        'customer_Id
        '
        Me.customer_Id.HeaderText = "Customer ID"
        Me.customer_Id.Name = "customer_Id"
        '
        'Insurance_Id
        '
        Me.Insurance_Id.HeaderText = "Insurance ID"
        Me.Insurance_Id.Name = "Insurance_Id"
        '
        'First_Name
        '
        Me.First_Name.HeaderText = "First Name"
        Me.First_Name.Name = "First_Name"
        '
        'Last_Name
        '
        Me.Last_Name.HeaderText = "Last Name"
        Me.Last_Name.Name = "Last_Name"
        '
        'Address
        '
        Me.Address.HeaderText = "Address"
        Me.Address.Name = "Address"
        '
        'Insurance_Start_Date
        '
        Me.Insurance_Start_Date.HeaderText = "Insurance Start Date"
        Me.Insurance_Start_Date.Name = "Insurance_Start_Date"
        '
        'Inurance_Last_Date
        '
        Me.Inurance_Last_Date.HeaderText = "Insurance End Date"
        Me.Inurance_Last_Date.Name = "Inurance_Last_Date"
        '
        'mobile_number
        '
        Me.mobile_number.HeaderText = "Mobile Number"
        Me.mobile_number.Name = "mobile_number"
        '
        'dgInsDetail
        '
        Me.dgInsDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgInsDetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ins_id, Me.Ins_com_Name, Me.Ins_Plan, Me.ins_Address, Me.Insurance_mobile})
        Me.dgInsDetail.Location = New System.Drawing.Point(234, 220)
        Me.dgInsDetail.Name = "dgInsDetail"
        Me.dgInsDetail.Size = New System.Drawing.Size(545, 74)
        Me.dgInsDetail.TabIndex = 10
        Me.dgInsDetail.TabStop = False
        '
        'ins_id
        '
        Me.ins_id.HeaderText = "Insurance ID"
        Me.ins_id.Name = "ins_id"
        '
        'Ins_com_Name
        '
        Me.Ins_com_Name.HeaderText = "Insurance Company Name"
        Me.Ins_com_Name.Name = "Ins_com_Name"
        '
        'Ins_Plan
        '
        Me.Ins_Plan.HeaderText = "Insurance Plan"
        Me.Ins_Plan.Name = "Ins_Plan"
        '
        'ins_Address
        '
        Me.ins_Address.HeaderText = "Insurance Company Address"
        Me.ins_Address.Name = "ins_Address"
        '
        'Insurance_mobile
        '
        Me.Insurance_mobile.HeaderText = "Insurance Contact Number"
        Me.Insurance_mobile.Name = "Insurance_mobile"
        '
        'dgMedDetail
        '
        Me.dgMedDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMedDetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.medicine_id, Me.medicine_name, Me.quantity, Me.tier, Me.Cost_Per_Unit, Me.Total, Me.Total_Claim_Cost, Me.Due_Amount})
        Me.dgMedDetail.Location = New System.Drawing.Point(234, 324)
        Me.dgMedDetail.Name = "dgMedDetail"
        Me.dgMedDetail.Size = New System.Drawing.Size(831, 150)
        Me.dgMedDetail.TabIndex = 11
        Me.dgMedDetail.TabStop = False
        '
        'medicine_id
        '
        Me.medicine_id.HeaderText = "Medicine ID"
        Me.medicine_id.Name = "medicine_id"
        '
        'medicine_name
        '
        Me.medicine_name.HeaderText = "Medicine Name"
        Me.medicine_name.Name = "medicine_name"
        '
        'quantity
        '
        Me.quantity.HeaderText = "Quantity"
        Me.quantity.Name = "quantity"
        '
        'tier
        '
        Me.tier.HeaderText = "Tier"
        Me.tier.Name = "tier"
        '
        'Cost_Per_Unit
        '
        Me.Cost_Per_Unit.HeaderText = "Cost Per Unit"
        Me.Cost_Per_Unit.Name = "Cost_Per_Unit"
        '
        'Total
        '
        Me.Total.HeaderText = "Medicine Cost"
        Me.Total.Name = "Total"
        '
        'Total_Claim_Cost
        '
        Me.Total_Claim_Cost.HeaderText = "Claim Medicine Cost"
        Me.Total_Claim_Cost.Name = "Total_Claim_Cost"
        '
        'Due_Amount
        '
        Me.Due_Amount.HeaderText = "Due Amount"
        Me.Due_Amount.Name = "Due_Amount"
        '
        'btnSearchCust
        '
        Me.btnSearchCust.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchCust.Location = New System.Drawing.Point(662, 41)
        Me.btnSearchCust.Name = "btnSearchCust"
        Me.btnSearchCust.Size = New System.Drawing.Size(117, 27)
        Me.btnSearchCust.TabIndex = 8
        Me.btnSearchCust.Text = "Search Customer"
        Me.btnSearchCust.UseVisualStyleBackColor = True
        '
        'btnSearchPrescrip
        '
        Me.btnSearchPrescrip.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchPrescrip.Location = New System.Drawing.Point(662, 75)
        Me.btnSearchPrescrip.Name = "btnSearchPrescrip"
        Me.btnSearchPrescrip.Size = New System.Drawing.Size(117, 30)
        Me.btnSearchPrescrip.TabIndex = 10
        Me.btnSearchPrescrip.Text = "Search Prescription"
        Me.btnSearchPrescrip.UseVisualStyleBackColor = True
        '
        'btnRefil
        '
        Me.btnRefil.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefil.Location = New System.Drawing.Point(662, 494)
        Me.btnRefil.Name = "btnRefil"
        Me.btnRefil.Size = New System.Drawing.Size(133, 39)
        Me.btnRefil.TabIndex = 12
        Me.btnRefil.Text = "Proceed to Refil"
        Me.btnRefil.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(493, 497)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(79, 36)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblWelName
        '
        Me.lblWelName.AutoSize = True
        Me.lblWelName.Location = New System.Drawing.Point(878, 9)
        Me.lblWelName.Name = "lblWelName"
        Me.lblWelName.Size = New System.Drawing.Size(0, 13)
        Me.lblWelName.TabIndex = 14
        '
        'Home_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1077, 545)
        Me.Controls.Add(Me.lblWelName)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnRefil)
        Me.Controls.Add(Me.btnSearchPrescrip)
        Me.Controls.Add(Me.dgMedDetail)
        Me.Controls.Add(Me.btnSearchCust)
        Me.Controls.Add(Me.dgInsDetail)
        Me.Controls.Add(Me.dgcusDetail)
        Me.Controls.Add(Me.txtPrecId)
        Me.Controls.Add(Me.txtCusId)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbltxt1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Home_Page"
        Me.Text = "Home_Page"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgcusDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgInsDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgMedDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnVendor As System.Windows.Forms.Button
    Friend WithEvents btnInventory As System.Windows.Forms.Button
    Friend WithEvents btnSales As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnNewPrescription As System.Windows.Forms.Button
    Friend WithEvents btnNewCustomers As System.Windows.Forms.Button
    Friend WithEvents btnChngPasswd As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lbltxt1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCusId As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecId As System.Windows.Forms.TextBox
    Friend WithEvents dgcusDetail As System.Windows.Forms.DataGridView
    Friend WithEvents dgInsDetail As System.Windows.Forms.DataGridView
    Friend WithEvents dgMedDetail As System.Windows.Forms.DataGridView
    Friend WithEvents btnSearchCust As System.Windows.Forms.Button
    Friend WithEvents btnSearchPrescrip As System.Windows.Forms.Button
    Friend WithEvents btnRefil As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblWelName As System.Windows.Forms.Label
    Friend WithEvents btnNewIns As System.Windows.Forms.Button
    Friend WithEvents btnNewMed As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents customer_Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Insurance_Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents First_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Last_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Insurance_Start_Date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Inurance_Last_Date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mobile_number As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ins_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ins_com_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ins_Plan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ins_Address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Insurance_mobile As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents medicine_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents medicine_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cost_Per_Unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total_Claim_Cost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Due_Amount As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
