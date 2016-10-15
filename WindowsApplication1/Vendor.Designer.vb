<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vendor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Vendor))
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.dgView1 = New System.Windows.Forms.DataGridView()
        Me.vId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.person = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.priceUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.shipping_Days = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(529, 188)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(204, 33)
        Me.btnPrint.TabIndex = 0
        Me.btnPrint.Text = "Print the report"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'dgView1
        '
        Me.dgView1.AllowUserToDeleteRows = False
        Me.dgView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.vId, Me.cName, Me.person, Me.pNumber, Me.mName, Me.priceUnit, Me.shipping_Days})
        Me.dgView1.Location = New System.Drawing.Point(12, 21)
        Me.dgView1.Name = "dgView1"
        Me.dgView1.ReadOnly = True
        Me.dgView1.Size = New System.Drawing.Size(744, 150)
        Me.dgView1.TabIndex = 1
        '
        'vId
        '
        Me.vId.HeaderText = "Vendor ID"
        Me.vId.Name = "vId"
        Me.vId.ReadOnly = True
        '
        'cName
        '
        Me.cName.HeaderText = "Vendor Company Name"
        Me.cName.Name = "cName"
        Me.cName.ReadOnly = True
        '
        'person
        '
        Me.person.HeaderText = "Vendor Contact Name"
        Me.person.Name = "person"
        Me.person.ReadOnly = True
        '
        'pNumber
        '
        Me.pNumber.HeaderText = "Vendor Phone Number"
        Me.pNumber.Name = "pNumber"
        Me.pNumber.ReadOnly = True
        '
        'mName
        '
        Me.mName.HeaderText = "Medicine Name"
        Me.mName.Name = "mName"
        Me.mName.ReadOnly = True
        '
        'priceUnit
        '
        Me.priceUnit.HeaderText = "Vendor Price Per Unit"
        Me.priceUnit.Name = "priceUnit"
        Me.priceUnit.ReadOnly = True
        '
        'shipping_Days
        '
        Me.shipping_Days.HeaderText = "Required Shipping Days"
        Me.shipping_Days.Name = "shipping_Days"
        Me.shipping_Days.ReadOnly = True
        '
        'Vendor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(782, 276)
        Me.Controls.Add(Me.dgView1)
        Me.Controls.Add(Me.btnPrint)
        Me.Name = "Vendor"
        Me.Text = "Vendor"
        CType(Me.dgView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents dgView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents vId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents person As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents priceUnit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents shipping_Days As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
