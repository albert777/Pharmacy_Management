<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Insurance_Information
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
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.txtContactNo = New System.Windows.Forms.TextBox()
        Me.txtInsurancePlan = New System.Windows.Forms.TextBox()
        Me.txtInsuranceID = New System.Windows.Forms.TextBox()
        Me.lblContactNo = New System.Windows.Forms.Label()
        Me.lblInsurancePln = New System.Windows.Forms.Label()
        Me.lblInsuranceCmpyName = New System.Windows.Forms.Label()
        Me.lblInsuranceID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTier3 = New System.Windows.Forms.TextBox()
        Me.txtTier2 = New System.Windows.Forms.TextBox()
        Me.txtTier1 = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtState = New System.Windows.Forms.ComboBox()
        Me.txtComName = New System.Windows.Forms.TextBox()
        Me.txtZipCode = New System.Windows.Forms.TextBox()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.lblZipCode = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(446, 394)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(82, 34)
        Me.btnClear.TabIndex = 47
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(240, 394)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(100, 34)
        Me.btnNext.TabIndex = 46
        Me.btnNext.Text = "Save"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'txtContactNo
        '
        Me.txtContactNo.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNo.Location = New System.Drawing.Point(593, 269)
        Me.txtContactNo.MaxLength = 10
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.Size = New System.Drawing.Size(100, 26)
        Me.txtContactNo.TabIndex = 44
        '
        'txtInsurancePlan
        '
        Me.txtInsurancePlan.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInsurancePlan.Location = New System.Drawing.Point(280, 105)
        Me.txtInsurancePlan.Name = "txtInsurancePlan"
        Me.txtInsurancePlan.Size = New System.Drawing.Size(100, 26)
        Me.txtInsurancePlan.TabIndex = 34
        '
        'txtInsuranceID
        '
        Me.txtInsuranceID.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInsuranceID.Location = New System.Drawing.Point(280, 60)
        Me.txtInsuranceID.Name = "txtInsuranceID"
        Me.txtInsuranceID.Size = New System.Drawing.Size(100, 26)
        Me.txtInsuranceID.TabIndex = 33
        Me.txtInsuranceID.TabStop = False
        '
        'lblContactNo
        '
        Me.lblContactNo.AutoSize = True
        Me.lblContactNo.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactNo.Location = New System.Drawing.Point(461, 277)
        Me.lblContactNo.Name = "lblContactNo"
        Me.lblContactNo.Size = New System.Drawing.Size(126, 18)
        Me.lblContactNo.TabIndex = 35
        Me.lblContactNo.Text = "ContactNumber"
        '
        'lblInsurancePln
        '
        Me.lblInsurancePln.AutoSize = True
        Me.lblInsurancePln.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsurancePln.Location = New System.Drawing.Point(109, 105)
        Me.lblInsurancePln.Name = "lblInsurancePln"
        Me.lblInsurancePln.Size = New System.Drawing.Size(110, 18)
        Me.lblInsurancePln.TabIndex = 25
        Me.lblInsurancePln.Text = "InsurancePlan"
        '
        'lblInsuranceCmpyName
        '
        Me.lblInsuranceCmpyName.AutoSize = True
        Me.lblInsuranceCmpyName.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsuranceCmpyName.Location = New System.Drawing.Point(68, 157)
        Me.lblInsuranceCmpyName.Name = "lblInsuranceCmpyName"
        Me.lblInsuranceCmpyName.Size = New System.Drawing.Size(206, 18)
        Me.lblInsuranceCmpyName.TabIndex = 26
        Me.lblInsuranceCmpyName.Text = "Insurance Company Name"
        '
        'lblInsuranceID
        '
        Me.lblInsuranceID.AutoSize = True
        Me.lblInsuranceID.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsuranceID.Location = New System.Drawing.Point(109, 60)
        Me.lblInsuranceID.Name = "lblInsuranceID"
        Me.lblInsuranceID.Size = New System.Drawing.Size(101, 18)
        Me.lblInsuranceID.TabIndex = 24
        Me.lblInsuranceID.Text = "Insurance ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(461, 317)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 18)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.AcceptsTab = True
        Me.txtEmail.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(593, 317)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 26)
        Me.txtEmail.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(180, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 18)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Tier 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(180, 299)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 18)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Tier 3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(180, 255)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 18)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Tier 2"
        '
        'txtTier3
        '
        Me.txtTier3.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTier3.Location = New System.Drawing.Point(280, 291)
        Me.txtTier3.Name = "txtTier3"
        Me.txtTier3.Size = New System.Drawing.Size(100, 26)
        Me.txtTier3.TabIndex = 38
        '
        'txtTier2
        '
        Me.txtTier2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTier2.Location = New System.Drawing.Point(280, 247)
        Me.txtTier2.Name = "txtTier2"
        Me.txtTier2.Size = New System.Drawing.Size(100, 26)
        Me.txtTier2.TabIndex = 37
        '
        'txtTier1
        '
        Me.txtTier1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTier1.Location = New System.Drawing.Point(280, 205)
        Me.txtTier1.Name = "txtTier1"
        Me.txtTier1.Size = New System.Drawing.Size(100, 26)
        Me.txtTier1.TabIndex = 36
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(593, 57)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(100, 26)
        Me.txtAddress.TabIndex = 39
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(466, 60)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(54, 18)
        Me.lblAddress.TabIndex = 30
        Me.lblAddress.Text = "Street"
        '
        'txtState
        '
        Me.txtState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtState.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtState.FormattingEnabled = True
        Me.txtState.Items.AddRange(New Object() {"AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY"})
        Me.txtState.Location = New System.Drawing.Point(593, 134)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(100, 26)
        Me.txtState.TabIndex = 41
        '
        'txtComName
        '
        Me.txtComName.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComName.Location = New System.Drawing.Point(280, 157)
        Me.txtComName.Name = "txtComName"
        Me.txtComName.Size = New System.Drawing.Size(100, 26)
        Me.txtComName.TabIndex = 35
        '
        'txtZipCode
        '
        Me.txtZipCode.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZipCode.Location = New System.Drawing.Point(593, 227)
        Me.txtZipCode.MaxLength = 5
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.Size = New System.Drawing.Size(100, 26)
        Me.txtZipCode.TabIndex = 43
        '
        'txtCountry
        '
        Me.txtCountry.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCountry.Location = New System.Drawing.Point(593, 182)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(100, 26)
        Me.txtCountry.TabIndex = 42
        '
        'txtCity
        '
        Me.txtCity.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.Location = New System.Drawing.Point(593, 97)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(100, 26)
        Me.txtCity.TabIndex = 40
        '
        'lblZipCode
        '
        Me.lblZipCode.AutoSize = True
        Me.lblZipCode.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZipCode.Location = New System.Drawing.Point(466, 230)
        Me.lblZipCode.Name = "lblZipCode"
        Me.lblZipCode.Size = New System.Drawing.Size(69, 18)
        Me.lblZipCode.TabIndex = 34
        Me.lblZipCode.Text = "ZipCode"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.Location = New System.Drawing.Point(466, 142)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(48, 18)
        Me.lblState.TabIndex = 32
        Me.lblState.Text = "State"
        '
        'lblCountry
        '
        Me.lblCountry.AutoSize = True
        Me.lblCountry.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountry.Location = New System.Drawing.Point(467, 185)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(68, 18)
        Me.lblCountry.TabIndex = 33
        Me.lblCountry.Text = "Country"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCity.Location = New System.Drawing.Point(466, 102)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(37, 18)
        Me.lblCity.TabIndex = 31
        Me.lblCity.Text = "City"
        '
        'Insurance_Information
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(956, 578)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtComName)
        Me.Controls.Add(Me.txtZipCode)
        Me.Controls.Add(Me.txtCountry)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.lblZipCode)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblCountry)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.txtTier1)
        Me.Controls.Add(Me.txtTier2)
        Me.Controls.Add(Me.txtTier3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.txtContactNo)
        Me.Controls.Add(Me.txtInsurancePlan)
        Me.Controls.Add(Me.txtInsuranceID)
        Me.Controls.Add(Me.lblContactNo)
        Me.Controls.Add(Me.lblInsurancePln)
        Me.Controls.Add(Me.lblInsuranceCmpyName)
        Me.Controls.Add(Me.lblInsuranceID)
        Me.Name = "Insurance_Information"
        Me.Text = "Insurance_Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents txtContactNo As System.Windows.Forms.TextBox
    Friend WithEvents txtInsurancePlan As System.Windows.Forms.TextBox
    Friend WithEvents txtInsuranceID As System.Windows.Forms.TextBox
    Friend WithEvents lblContactNo As System.Windows.Forms.Label
    Friend WithEvents lblInsurancePln As System.Windows.Forms.Label
    Friend WithEvents lblInsuranceCmpyName As System.Windows.Forms.Label
    Friend WithEvents lblInsuranceID As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTier3 As System.Windows.Forms.TextBox
    Friend WithEvents txtTier2 As System.Windows.Forms.TextBox
    Friend WithEvents txtTier1 As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents txtState As System.Windows.Forms.ComboBox
    Friend WithEvents txtComName As System.Windows.Forms.TextBox
    Friend WithEvents txtZipCode As System.Windows.Forms.TextBox
    Friend WithEvents txtCountry As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents lblZipCode As System.Windows.Forms.Label
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents lblCountry As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
End Class
