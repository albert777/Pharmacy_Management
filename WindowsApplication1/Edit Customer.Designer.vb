<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Customer
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
        Me.txtCusMo = New System.Windows.Forms.TextBox()
        Me.txtCusPh = New System.Windows.Forms.TextBox()
        Me.txtInsED = New System.Windows.Forms.TextBox()
        Me.txtInsSD = New System.Windows.Forms.TextBox()
        Me.cbCompName = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbComName = New System.Windows.Forms.Label()
        Me.txtCustCity = New System.Windows.Forms.TextBox()
        Me.cbCustState = New System.Windows.Forms.ComboBox()
        Me.txtZipCode = New System.Windows.Forms.TextBox()
        Me.txtCustAddress = New System.Windows.Forms.TextBox()
        Me.txtCustLastName = New System.Windows.Forms.TextBox()
        Me.txtCustFirstName = New System.Windows.Forms.TextBox()
        Me.lblCustPhNo = New System.Windows.Forms.Label()
        Me.lblCustCity = New System.Windows.Forms.Label()
        Me.lblZipCode = New System.Windows.Forms.Label()
        Me.CustMobNo = New System.Windows.Forms.Label()
        Me.lblCustState = New System.Windows.Forms.Label()
        Me.lblCustAddress = New System.Windows.Forms.Label()
        Me.lblCustLastName = New System.Windows.Forms.Label()
        Me.lblCustFirstName = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblText = New System.Windows.Forms.Label()
        Me.lblOldIns = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtCusMo
        '
        Me.txtCusMo.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusMo.Location = New System.Drawing.Point(671, 151)
        Me.txtCusMo.MaxLength = 10
        Me.txtCusMo.Name = "txtCusMo"
        Me.txtCusMo.Size = New System.Drawing.Size(100, 26)
        Me.txtCusMo.TabIndex = 76
        '
        'txtCusPh
        '
        Me.txtCusPh.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusPh.Location = New System.Drawing.Point(671, 101)
        Me.txtCusPh.MaxLength = 10
        Me.txtCusPh.Name = "txtCusPh"
        Me.txtCusPh.Size = New System.Drawing.Size(100, 26)
        Me.txtCusPh.TabIndex = 75
        '
        'txtInsED
        '
        Me.txtInsED.AcceptsTab = True
        Me.txtInsED.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInsED.Location = New System.Drawing.Point(671, 248)
        Me.txtInsED.Name = "txtInsED"
        Me.txtInsED.Size = New System.Drawing.Size(100, 26)
        Me.txtInsED.TabIndex = 78
        '
        'txtInsSD
        '
        Me.txtInsSD.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInsSD.Location = New System.Drawing.Point(671, 201)
        Me.txtInsSD.Name = "txtInsSD"
        Me.txtInsSD.Size = New System.Drawing.Size(100, 26)
        Me.txtInsSD.TabIndex = 77
        '
        'cbCompName
        '
        Me.cbCompName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbCompName.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCompName.FormattingEnabled = True
        Me.cbCompName.Location = New System.Drawing.Point(273, 333)
        Me.cbCompName.Name = "cbCompName"
        Me.cbCompName.Size = New System.Drawing.Size(121, 26)
        Me.cbCompName.TabIndex = 74
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(446, 256)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 18)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Insurance End Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(446, 209)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 18)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Insurance Start Date"
        '
        'lbComName
        '
        Me.lbComName.AutoSize = True
        Me.lbComName.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbComName.Location = New System.Drawing.Point(61, 341)
        Me.lbComName.Name = "lbComName"
        Me.lbComName.Size = New System.Drawing.Size(206, 18)
        Me.lbComName.TabIndex = 7
        Me.lbComName.Text = "Insurance Company Name"
        '
        'txtCustCity
        '
        Me.txtCustCity.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustCity.Location = New System.Drawing.Point(274, 193)
        Me.txtCustCity.Name = "txtCustCity"
        Me.txtCustCity.Size = New System.Drawing.Size(100, 26)
        Me.txtCustCity.TabIndex = 71
        '
        'cbCustState
        '
        Me.cbCustState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbCustState.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCustState.FormattingEnabled = True
        Me.cbCustState.Items.AddRange(New Object() {"AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY"})
        Me.cbCustState.Location = New System.Drawing.Point(274, 237)
        Me.cbCustState.Name = "cbCustState"
        Me.cbCustState.Size = New System.Drawing.Size(100, 26)
        Me.cbCustState.TabIndex = 72
        '
        'txtZipCode
        '
        Me.txtZipCode.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZipCode.Location = New System.Drawing.Point(274, 286)
        Me.txtZipCode.MaxLength = 5
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.Size = New System.Drawing.Size(100, 26)
        Me.txtZipCode.TabIndex = 73
        '
        'txtCustAddress
        '
        Me.txtCustAddress.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustAddress.Location = New System.Drawing.Point(274, 146)
        Me.txtCustAddress.Name = "txtCustAddress"
        Me.txtCustAddress.Size = New System.Drawing.Size(100, 26)
        Me.txtCustAddress.TabIndex = 70
        '
        'txtCustLastName
        '
        Me.txtCustLastName.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustLastName.Location = New System.Drawing.Point(274, 101)
        Me.txtCustLastName.Name = "txtCustLastName"
        Me.txtCustLastName.Size = New System.Drawing.Size(100, 26)
        Me.txtCustLastName.TabIndex = 69
        '
        'txtCustFirstName
        '
        Me.txtCustFirstName.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustFirstName.Location = New System.Drawing.Point(274, 50)
        Me.txtCustFirstName.Name = "txtCustFirstName"
        Me.txtCustFirstName.Size = New System.Drawing.Size(100, 26)
        Me.txtCustFirstName.TabIndex = 68
        '
        'lblCustPhNo
        '
        Me.lblCustPhNo.AutoSize = True
        Me.lblCustPhNo.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustPhNo.Location = New System.Drawing.Point(446, 101)
        Me.lblCustPhNo.Name = "lblCustPhNo"
        Me.lblCustPhNo.Size = New System.Drawing.Size(118, 18)
        Me.lblCustPhNo.TabIndex = 8
        Me.lblCustPhNo.Text = "Phone Number"
        '
        'lblCustCity
        '
        Me.lblCustCity.AutoSize = True
        Me.lblCustCity.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustCity.Location = New System.Drawing.Point(175, 193)
        Me.lblCustCity.Name = "lblCustCity"
        Me.lblCustCity.Size = New System.Drawing.Size(42, 18)
        Me.lblCustCity.TabIndex = 4
        Me.lblCustCity.Text = " City"
        '
        'lblZipCode
        '
        Me.lblZipCode.AutoSize = True
        Me.lblZipCode.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZipCode.Location = New System.Drawing.Point(154, 286)
        Me.lblZipCode.Name = "lblZipCode"
        Me.lblZipCode.Size = New System.Drawing.Size(69, 18)
        Me.lblZipCode.TabIndex = 6
        Me.lblZipCode.Text = "ZipCode"
        '
        'CustMobNo
        '
        Me.CustMobNo.AutoSize = True
        Me.CustMobNo.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustMobNo.Location = New System.Drawing.Point(446, 154)
        Me.CustMobNo.Name = "CustMobNo"
        Me.CustMobNo.Size = New System.Drawing.Size(119, 18)
        Me.CustMobNo.TabIndex = 9
        Me.CustMobNo.Text = "Mobile Number"
        '
        'lblCustState
        '
        Me.lblCustState.AutoSize = True
        Me.lblCustState.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustState.Location = New System.Drawing.Point(175, 237)
        Me.lblCustState.Name = "lblCustState"
        Me.lblCustState.Size = New System.Drawing.Size(48, 18)
        Me.lblCustState.TabIndex = 5
        Me.lblCustState.Text = "State"
        '
        'lblCustAddress
        '
        Me.lblCustAddress.AutoSize = True
        Me.lblCustAddress.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustAddress.Location = New System.Drawing.Point(164, 151)
        Me.lblCustAddress.Name = "lblCustAddress"
        Me.lblCustAddress.Size = New System.Drawing.Size(59, 18)
        Me.lblCustAddress.TabIndex = 3
        Me.lblCustAddress.Text = " Street"
        '
        'lblCustLastName
        '
        Me.lblCustLastName.AutoSize = True
        Me.lblCustLastName.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustLastName.Location = New System.Drawing.Point(61, 101)
        Me.lblCustLastName.Name = "lblCustLastName"
        Me.lblCustLastName.Size = New System.Drawing.Size(162, 18)
        Me.lblCustLastName.TabIndex = 2
        Me.lblCustLastName.Text = "Customer LastName"
        '
        'lblCustFirstName
        '
        Me.lblCustFirstName.AutoSize = True
        Me.lblCustFirstName.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustFirstName.Location = New System.Drawing.Point(62, 50)
        Me.lblCustFirstName.Name = "lblCustFirstName"
        Me.lblCustFirstName.Size = New System.Drawing.Size(163, 18)
        Me.lblCustFirstName.TabIndex = 1
        Me.lblCustFirstName.Text = "Customer FirstName"
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(382, 392)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(106, 36)
        Me.btnUpdate.TabIndex = 84
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'lblText
        '
        Me.lblText.AutoSize = True
        Me.lblText.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.Location = New System.Drawing.Point(402, 327)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(0, 18)
        Me.lblText.TabIndex = 85
        Me.lblText.Visible = False
        '
        'lblOldIns
        '
        Me.lblOldIns.AutoSize = True
        Me.lblOldIns.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOldIns.Location = New System.Drawing.Point(432, 305)
        Me.lblOldIns.Name = "lblOldIns"
        Me.lblOldIns.Size = New System.Drawing.Size(0, 18)
        Me.lblOldIns.TabIndex = 86
        Me.lblOldIns.Visible = False
        '
        'Edit_Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(886, 473)
        Me.Controls.Add(Me.lblOldIns)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtCusMo)
        Me.Controls.Add(Me.txtCusPh)
        Me.Controls.Add(Me.txtInsED)
        Me.Controls.Add(Me.txtInsSD)
        Me.Controls.Add(Me.cbCompName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbComName)
        Me.Controls.Add(Me.txtCustCity)
        Me.Controls.Add(Me.cbCustState)
        Me.Controls.Add(Me.txtZipCode)
        Me.Controls.Add(Me.txtCustAddress)
        Me.Controls.Add(Me.txtCustLastName)
        Me.Controls.Add(Me.txtCustFirstName)
        Me.Controls.Add(Me.lblCustPhNo)
        Me.Controls.Add(Me.lblCustCity)
        Me.Controls.Add(Me.lblZipCode)
        Me.Controls.Add(Me.CustMobNo)
        Me.Controls.Add(Me.lblCustState)
        Me.Controls.Add(Me.lblCustAddress)
        Me.Controls.Add(Me.lblCustLastName)
        Me.Controls.Add(Me.lblCustFirstName)
        Me.Name = "Edit_Customer"
        Me.Text = "Edit_Customer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCusMo As System.Windows.Forms.TextBox
    Friend WithEvents txtCusPh As System.Windows.Forms.TextBox
    Friend WithEvents txtInsED As System.Windows.Forms.TextBox
    Friend WithEvents txtInsSD As System.Windows.Forms.TextBox
    Friend WithEvents cbCompName As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbComName As System.Windows.Forms.Label
    Friend WithEvents txtCustCity As System.Windows.Forms.TextBox
    Friend WithEvents cbCustState As System.Windows.Forms.ComboBox
    Friend WithEvents txtZipCode As System.Windows.Forms.TextBox
    Friend WithEvents txtCustAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtCustLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtCustFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblCustPhNo As System.Windows.Forms.Label
    Friend WithEvents lblCustCity As System.Windows.Forms.Label
    Friend WithEvents lblZipCode As System.Windows.Forms.Label
    Friend WithEvents CustMobNo As System.Windows.Forms.Label
    Friend WithEvents lblCustState As System.Windows.Forms.Label
    Friend WithEvents lblCustAddress As System.Windows.Forms.Label
    Friend WithEvents lblCustLastName As System.Windows.Forms.Label
    Friend WithEvents lblCustFirstName As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents lblOldIns As System.Windows.Forms.Label
End Class
