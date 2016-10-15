<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class New_Prescription
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(New_Prescription))
        Me.cbTotalRefillAllowed = New System.Windows.Forms.ComboBox()
        Me.txtQpU1 = New System.Windows.Forms.TextBox()
        Me.txtCustLastName = New System.Windows.Forms.TextBox()
        Me.txtCustFirstName = New System.Windows.Forms.TextBox()
        Me.txtCustID = New System.Windows.Forms.TextBox()
        Me.txtPrescriptionID = New System.Windows.Forms.TextBox()
        Me.lblTotalRefillAllowed = New System.Windows.Forms.Label()
        Me.lblQpU1 = New System.Windows.Forms.Label()
        Me.lblCustLastNme = New System.Windows.Forms.Label()
        Me.lblCustFirstNme = New System.Windows.Forms.Label()
        Me.lblCustID = New System.Windows.Forms.Label()
        Me.lblPrescriptionID = New System.Windows.Forms.Label()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.cbMedName1 = New System.Windows.Forms.ComboBox()
        Me.dgViwe1 = New System.Windows.Forms.DataGridView()
        Me.Medicine_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblMedNme1 = New System.Windows.Forms.Label()
        CType(Me.dgViwe1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbTotalRefillAllowed
        '
        Me.cbTotalRefillAllowed.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbTotalRefillAllowed.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTotalRefillAllowed.FormattingEnabled = True
        Me.cbTotalRefillAllowed.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7"})
        Me.cbTotalRefillAllowed.Location = New System.Drawing.Point(615, 189)
        Me.cbTotalRefillAllowed.Margin = New System.Windows.Forms.Padding(4)
        Me.cbTotalRefillAllowed.Name = "cbTotalRefillAllowed"
        Me.cbTotalRefillAllowed.Size = New System.Drawing.Size(116, 26)
        Me.cbTotalRefillAllowed.TabIndex = 1
        '
        'txtQpU1
        '
        Me.txtQpU1.AcceptsTab = True
        Me.txtQpU1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQpU1.Location = New System.Drawing.Point(615, 369)
        Me.txtQpU1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQpU1.Name = "txtQpU1"
        Me.txtQpU1.Size = New System.Drawing.Size(140, 26)
        Me.txtQpU1.TabIndex = 3
        '
        'txtCustLastName
        '
        Me.txtCustLastName.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustLastName.Location = New System.Drawing.Point(615, 118)
        Me.txtCustLastName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCustLastName.Name = "txtCustLastName"
        Me.txtCustLastName.Size = New System.Drawing.Size(116, 26)
        Me.txtCustLastName.TabIndex = 59
        '
        'txtCustFirstName
        '
        Me.txtCustFirstName.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustFirstName.Location = New System.Drawing.Point(615, 54)
        Me.txtCustFirstName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCustFirstName.Name = "txtCustFirstName"
        Me.txtCustFirstName.Size = New System.Drawing.Size(116, 26)
        Me.txtCustFirstName.TabIndex = 58
        '
        'txtCustID
        '
        Me.txtCustID.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustID.Location = New System.Drawing.Point(214, 122)
        Me.txtCustID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCustID.Name = "txtCustID"
        Me.txtCustID.Size = New System.Drawing.Size(116, 26)
        Me.txtCustID.TabIndex = 53
        '
        'txtPrescriptionID
        '
        Me.txtPrescriptionID.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrescriptionID.Location = New System.Drawing.Point(214, 58)
        Me.txtPrescriptionID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrescriptionID.Name = "txtPrescriptionID"
        Me.txtPrescriptionID.Size = New System.Drawing.Size(116, 26)
        Me.txtPrescriptionID.TabIndex = 52
        '
        'lblTotalRefillAllowed
        '
        Me.lblTotalRefillAllowed.AutoSize = True
        Me.lblTotalRefillAllowed.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalRefillAllowed.Location = New System.Drawing.Point(414, 185)
        Me.lblTotalRefillAllowed.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalRefillAllowed.Name = "lblTotalRefillAllowed"
        Me.lblTotalRefillAllowed.Size = New System.Drawing.Size(143, 18)
        Me.lblTotalRefillAllowed.TabIndex = 51
        Me.lblTotalRefillAllowed.Text = "Total Refill Allowed"
        '
        'lblQpU1
        '
        Me.lblQpU1.AutoSize = True
        Me.lblQpU1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQpU1.Location = New System.Drawing.Point(409, 377)
        Me.lblQpU1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQpU1.Name = "lblQpU1"
        Me.lblQpU1.Size = New System.Drawing.Size(124, 18)
        Me.lblQpU1.TabIndex = 45
        Me.lblQpU1.Text = "QuantityPerUnit"
        '
        'lblCustLastNme
        '
        Me.lblCustLastNme.AutoSize = True
        Me.lblCustLastNme.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustLastNme.Location = New System.Drawing.Point(409, 118)
        Me.lblCustLastNme.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCustLastNme.Name = "lblCustLastNme"
        Me.lblCustLastNme.Size = New System.Drawing.Size(162, 18)
        Me.lblCustLastNme.TabIndex = 44
        Me.lblCustLastNme.Text = "Customer LastName"
        '
        'lblCustFirstNme
        '
        Me.lblCustFirstNme.AutoSize = True
        Me.lblCustFirstNme.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustFirstNme.Location = New System.Drawing.Point(410, 58)
        Me.lblCustFirstNme.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCustFirstNme.Name = "lblCustFirstNme"
        Me.lblCustFirstNme.Size = New System.Drawing.Size(163, 18)
        Me.lblCustFirstNme.TabIndex = 43
        Me.lblCustFirstNme.Text = "Customer FirstName"
        '
        'lblCustID
        '
        Me.lblCustID.AutoSize = True
        Me.lblCustID.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustID.Location = New System.Drawing.Point(57, 126)
        Me.lblCustID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCustID.Name = "lblCustID"
        Me.lblCustID.Size = New System.Drawing.Size(103, 18)
        Me.lblCustID.TabIndex = 39
        Me.lblCustID.Text = "Customer ID"
        '
        'lblPrescriptionID
        '
        Me.lblPrescriptionID.AutoSize = True
        Me.lblPrescriptionID.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrescriptionID.Location = New System.Drawing.Point(45, 58)
        Me.lblPrescriptionID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrescriptionID.Name = "lblPrescriptionID"
        Me.lblPrescriptionID.Size = New System.Drawing.Size(115, 18)
        Me.lblPrescriptionID.TabIndex = 38
        Me.lblPrescriptionID.Text = "Prescription ID"
        '
        'btnAddNew
        '
        Me.btnAddNew.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNew.Location = New System.Drawing.Point(643, 432)
        Me.btnAddNew.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(88, 26)
        Me.btnAddNew.TabIndex = 4
        Me.btnAddNew.Text = "Add New Row"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(326, 495)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(88, 26)
        Me.btnNext.TabIndex = 5
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(521, 495)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(88, 26)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'cbMedName1
        '
        Me.cbMedName1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbMedName1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMedName1.FormattingEnabled = True
        Me.cbMedName1.Location = New System.Drawing.Point(615, 291)
        Me.cbMedName1.Margin = New System.Windows.Forms.Padding(4)
        Me.cbMedName1.Name = "cbMedName1"
        Me.cbMedName1.Size = New System.Drawing.Size(140, 26)
        Me.cbMedName1.TabIndex = 2
        '
        'dgViwe1
        '
        Me.dgViwe1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgViwe1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Medicine_name, Me.Quantity})
        Me.dgViwe1.Location = New System.Drawing.Point(48, 294)
        Me.dgViwe1.Margin = New System.Windows.Forms.Padding(4)
        Me.dgViwe1.Name = "dgViwe1"
        Me.dgViwe1.Size = New System.Drawing.Size(280, 146)
        Me.dgViwe1.TabIndex = 76
        '
        'Medicine_name
        '
        Me.Medicine_name.HeaderText = "Medicine Name"
        Me.Medicine_name.Name = "Medicine_name"
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        '
        'lblMedNme1
        '
        Me.lblMedNme1.AutoSize = True
        Me.lblMedNme1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedNme1.Location = New System.Drawing.Point(417, 294)
        Me.lblMedNme1.Name = "lblMedNme1"
        Me.lblMedNme1.Size = New System.Drawing.Size(135, 18)
        Me.lblMedNme1.TabIndex = 77
        Me.lblMedNme1.Text = "Medicine Name 1"
        '
        'New_Prescription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1193, 606)
        Me.Controls.Add(Me.lblMedNme1)
        Me.Controls.Add(Me.dgViwe1)
        Me.Controls.Add(Me.cbMedName1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.cbTotalRefillAllowed)
        Me.Controls.Add(Me.txtQpU1)
        Me.Controls.Add(Me.txtCustLastName)
        Me.Controls.Add(Me.txtCustFirstName)
        Me.Controls.Add(Me.txtCustID)
        Me.Controls.Add(Me.txtPrescriptionID)
        Me.Controls.Add(Me.lblTotalRefillAllowed)
        Me.Controls.Add(Me.lblQpU1)
        Me.Controls.Add(Me.lblCustLastNme)
        Me.Controls.Add(Me.lblCustFirstNme)
        Me.Controls.Add(Me.lblCustID)
        Me.Controls.Add(Me.lblPrescriptionID)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "New_Prescription"
        Me.Text = "New_Prescription"
        CType(Me.dgViwe1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbTotalRefillAllowed As System.Windows.Forms.ComboBox
    Friend WithEvents txtQpU1 As System.Windows.Forms.TextBox
    Friend WithEvents txtCustLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtCustFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtCustID As System.Windows.Forms.TextBox
    Friend WithEvents txtPrescriptionID As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalRefillAllowed As System.Windows.Forms.Label
    Friend WithEvents lblQpU1 As System.Windows.Forms.Label
    Friend WithEvents lblCustLastNme As System.Windows.Forms.Label
    Friend WithEvents lblCustFirstNme As System.Windows.Forms.Label
    Friend WithEvents lblCustID As System.Windows.Forms.Label
    Friend WithEvents lblPrescriptionID As System.Windows.Forms.Label
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents cbMedName1 As System.Windows.Forms.ComboBox
    Friend WithEvents dgViwe1 As System.Windows.Forms.DataGridView
    Friend WithEvents Medicine_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblMedNme1 As System.Windows.Forms.Label
End Class
