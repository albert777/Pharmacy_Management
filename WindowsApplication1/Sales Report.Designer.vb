<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sales_Report
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sales_Report))
        Me.btnReport = New System.Windows.Forms.Button()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.txtMonth = New System.Windows.Forms.TextBox()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.dgView = New System.Windows.Forms.DataGridView()
        Me.pId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emp_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.firstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.startDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.endDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.medName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.claim = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.due = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.LblSum = New System.Windows.Forms.Label()
        Me.TxtSum = New System.Windows.Forms.TextBox()
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnReport
        '
        Me.btnReport.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.Location = New System.Drawing.Point(231, 43)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(162, 35)
        Me.btnReport.TabIndex = 6
        Me.btnReport.Text = "Generate Report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonth.Location = New System.Drawing.Point(26, 43)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(55, 18)
        Me.lblMonth.TabIndex = 1
        Me.lblMonth.Text = "Month"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.Location = New System.Drawing.Point(26, 73)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(40, 18)
        Me.lblYear.TabIndex = 2
        Me.lblYear.Text = "Year"
        '
        'txtYear
        '
        Me.txtYear.AcceptsTab = True
        Me.txtYear.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYear.Location = New System.Drawing.Point(81, 66)
        Me.txtYear.MaxLength = 4
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(100, 26)
        Me.txtYear.TabIndex = 5
        '
        'txtMonth
        '
        Me.txtMonth.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonth.Location = New System.Drawing.Point(81, 36)
        Me.txtMonth.MaxLength = 2
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Size = New System.Drawing.Size(100, 26)
        Me.txtMonth.TabIndex = 4
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'dgView
        '
        Me.dgView.AllowUserToDeleteRows = False
        Me.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.pId, Me.date1, Me.emp_Id, Me.firstName, Me.lastName, Me.startDate, Me.endDate, Me.medName, Me.quantity, Me.cost, Me.claim, Me.due})
        Me.dgView.Location = New System.Drawing.Point(12, 115)
        Me.dgView.Name = "dgView"
        Me.dgView.ReadOnly = True
        Me.dgView.Size = New System.Drawing.Size(1062, 150)
        Me.dgView.TabIndex = 5
        Me.dgView.TabStop = False
        '
        'pId
        '
        Me.pId.HeaderText = "Prescription ID"
        Me.pId.Name = "pId"
        Me.pId.ReadOnly = True
        '
        'date1
        '
        Me.date1.HeaderText = "Prescription Date"
        Me.date1.Name = "date1"
        Me.date1.ReadOnly = True
        '
        'emp_Id
        '
        Me.emp_Id.HeaderText = "Employee ID"
        Me.emp_Id.Name = "emp_Id"
        Me.emp_Id.ReadOnly = True
        '
        'firstName
        '
        Me.firstName.HeaderText = "Customer FirstName"
        Me.firstName.Name = "firstName"
        Me.firstName.ReadOnly = True
        '
        'lastName
        '
        Me.lastName.HeaderText = "Customer LastName"
        Me.lastName.Name = "lastName"
        Me.lastName.ReadOnly = True
        '
        'startDate
        '
        Me.startDate.HeaderText = "Insurance Start Date"
        Me.startDate.Name = "startDate"
        Me.startDate.ReadOnly = True
        '
        'endDate
        '
        Me.endDate.HeaderText = "Insurance End Date"
        Me.endDate.Name = "endDate"
        Me.endDate.ReadOnly = True
        '
        'medName
        '
        Me.medName.HeaderText = "Medicine Name"
        Me.medName.Name = "medName"
        Me.medName.ReadOnly = True
        '
        'quantity
        '
        Me.quantity.HeaderText = "Quantity"
        Me.quantity.Name = "quantity"
        Me.quantity.ReadOnly = True
        '
        'cost
        '
        Me.cost.HeaderText = "Total Cost"
        Me.cost.Name = "cost"
        Me.cost.ReadOnly = True
        '
        'claim
        '
        Me.claim.HeaderText = "Total Claimable Amount"
        Me.claim.Name = "claim"
        Me.claim.ReadOnly = True
        '
        'due
        '
        Me.due.HeaderText = "Total Due"
        Me.due.Name = "due"
        Me.due.ReadOnly = True
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(410, 43)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(161, 35)
        Me.btnPrint.TabIndex = 7
        Me.btnPrint.Text = "Print the report"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'LblSum
        '
        Me.LblSum.AutoSize = True
        Me.LblSum.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSum.Location = New System.Drawing.Point(687, 298)
        Me.LblSum.Name = "LblSum"
        Me.LblSum.Size = New System.Drawing.Size(148, 18)
        Me.LblSum.TabIndex = 8
        Me.LblSum.Text = "Sum Of Total Sales"
        '
        'TxtSum
        '
        Me.TxtSum.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSum.Location = New System.Drawing.Point(858, 295)
        Me.TxtSum.Name = "TxtSum"
        Me.TxtSum.Size = New System.Drawing.Size(100, 26)
        Me.TxtSum.TabIndex = 9
        '
        'Sales_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1086, 381)
        Me.Controls.Add(Me.TxtSum)
        Me.Controls.Add(Me.LblSum)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.dgView)
        Me.Controls.Add(Me.txtMonth)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.btnReport)
        Me.Name = "Sales_Report"
        Me.Text = "Sales_Report"
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnReport As System.Windows.Forms.Button
    Friend WithEvents lblMonth As System.Windows.Forms.Label
    Friend WithEvents lblYear As System.Windows.Forms.Label
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents txtMonth As System.Windows.Forms.TextBox
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents dgView As System.Windows.Forms.DataGridView
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents pId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents date1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents emp_Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents firstName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lastName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents startDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents endDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents medName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents claim As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents due As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtSum As System.Windows.Forms.TextBox
    Friend WithEvents LblSum As System.Windows.Forms.Label
End Class
