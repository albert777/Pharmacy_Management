<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventory_Report
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventory_Report))
        Me.dgView = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.in_stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.out_Stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.level = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgView
        '
        Me.dgView.AllowUserToDeleteRows = False
        Me.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.name1, Me.price, Me.tier, Me.in_stock, Me.out_Stock, Me.level})
        Me.dgView.Location = New System.Drawing.Point(12, 12)
        Me.dgView.Name = "dgView"
        Me.dgView.ReadOnly = True
        Me.dgView.Size = New System.Drawing.Size(845, 174)
        Me.dgView.TabIndex = 0
        '
        'id
        '
        Me.id.HeaderText = "Medicine Inventory ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'name1
        '
        Me.name1.HeaderText = "Medicine Name"
        Me.name1.Name = "name1"
        Me.name1.ReadOnly = True
        '
        'price
        '
        Me.price.HeaderText = "Unit Price"
        Me.price.Name = "price"
        Me.price.ReadOnly = True
        '
        'tier
        '
        Me.tier.HeaderText = "Tier"
        Me.tier.Name = "tier"
        Me.tier.ReadOnly = True
        '
        'in_stock
        '
        Me.in_stock.HeaderText = "Units In Stock"
        Me.in_stock.Name = "in_stock"
        Me.in_stock.ReadOnly = True
        '
        'out_Stock
        '
        Me.out_Stock.HeaderText = "Units On Stock"
        Me.out_Stock.Name = "out_Stock"
        Me.out_Stock.ReadOnly = True
        '
        'level
        '
        Me.level.HeaderText = "Reorder Level"
        Me.level.Name = "level"
        Me.level.ReadOnly = True
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(585, 192)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(158, 39)
        Me.btnPrint.TabIndex = 1
        Me.btnPrint.Text = "Print the report"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Inventory_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(766, 242)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.dgView)
        Me.Name = "Inventory_Report"
        Me.Text = "Inventory_Report"
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgView As System.Windows.Forms.DataGridView
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents in_stock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents out_Stock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents level As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
