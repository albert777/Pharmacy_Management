<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class New_Customer
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
        Me.cbCustState = New System.Windows.Forms.ComboBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtCustID = New System.Windows.Forms.TextBox()
        Me.txtZipCode = New System.Windows.Forms.TextBox()
        Me.txtCustAddress = New System.Windows.Forms.TextBox()
        Me.txtCustLastName = New System.Windows.Forms.TextBox()
        Me.txtCustFirstName = New System.Windows.Forms.TextBox()
        Me.lblCustPhNo = New System.Windows.Forms.Label()
        Me.lblCustCity = New System.Windows.Forms.Label()
        Me.lblCustDOB = New System.Windows.Forms.Label()
        Me.lblCustID = New System.Windows.Forms.Label()
        Me.lblZipCode = New System.Windows.Forms.Label()
        Me.CustMobNo = New System.Windows.Forms.Label()
        Me.lblCustState = New System.Windows.Forms.Label()
        Me.lblCustAddress = New System.Windows.Forms.Label()
        Me.lblCustLastName = New System.Windows.Forms.Label()
        Me.lblCustFirstName = New System.Windows.Forms.Label()
        Me.txtCustCity = New System.Windows.Forms.TextBox()
        Me.lbComName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbCompName = New System.Windows.Forms.ComboBox()
        Me.txtCustDOB = New System.Windows.Forms.TextBox()
        Me.txtInsSD = New System.Windows.Forms.TextBox()
        Me.txtInsED = New System.Windows.Forms.TextBox()
        Me.txtCusPh = New System.Windows.Forms.TextBox()
        Me.txtCusMo = New System.Windows.Forms.TextBox()
        Me.dt1 = New System.Windows.Forms.DateTimePicker()
        Me.dt2 = New System.Windows.Forms.DateTimePicker()
        Me.dt3 = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'cbCustState
        '
        Me.cbCustState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbCustState.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCustState.FormattingEnabled = True
        Me.cbCustState.Items.AddRange(New Object() {"AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY"})
        Me.cbCustState.Location = New System.Drawing.Point(228, 240)
        Me.cbCustState.Name = "cbCustState"
        Me.cbCustState.Size = New System.Drawing.Size(121, 26)
        Me.cbCustState.TabIndex = 43
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(380, 425)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(89, 33)
        Me.btnClear.TabIndex = 53
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(207, 425)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(87, 33)
        Me.btnNext.TabIndex = 52
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(320, 33)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(133, 18)
        Me.Label16.TabIndex = 48
        Me.Label16.Text = "NEW CUSTOMER"
        '
        'txtCustID
        '
        Me.txtCustID.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustID.Location = New System.Drawing.Point(617, 76)
        Me.txtCustID.Name = "txtCustID"
        Me.txtCustID.Size = New System.Drawing.Size(119, 26)
        Me.txtCustID.TabIndex = 46
        Me.txtCustID.TabStop = False
        '
        'txtZipCode
        '
        Me.txtZipCode.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZipCode.Location = New System.Drawing.Point(227, 290)
        Me.txtZipCode.MaxLength = 5
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.Size = New System.Drawing.Size(121, 26)
        Me.txtZipCode.TabIndex = 44
        '
        'txtCustAddress
        '
        Me.txtCustAddress.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustAddress.Location = New System.Drawing.Point(228, 185)
        Me.txtCustAddress.Name = "txtCustAddress"
        Me.txtCustAddress.Size = New System.Drawing.Size(121, 26)
        Me.txtCustAddress.TabIndex = 42
        '
        'txtCustLastName
        '
        Me.txtCustLastName.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustLastName.Location = New System.Drawing.Point(228, 131)
        Me.txtCustLastName.Name = "txtCustLastName"
        Me.txtCustLastName.Size = New System.Drawing.Size(121, 26)
        Me.txtCustLastName.TabIndex = 41
        '
        'txtCustFirstName
        '
        Me.txtCustFirstName.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustFirstName.Location = New System.Drawing.Point(228, 80)
        Me.txtCustFirstName.Name = "txtCustFirstName"
        Me.txtCustFirstName.Size = New System.Drawing.Size(121, 26)
        Me.txtCustFirstName.TabIndex = 40
        '
        'lblCustPhNo
        '
        Me.lblCustPhNo.AutoSize = True
        Me.lblCustPhNo.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustPhNo.Location = New System.Drawing.Point(392, 233)
        Me.lblCustPhNo.Name = "lblCustPhNo"
        Me.lblCustPhNo.Size = New System.Drawing.Size(118, 18)
        Me.lblCustPhNo.TabIndex = 39
        Me.lblCustPhNo.Text = " PhoneNumber"
        '
        'lblCustCity
        '
        Me.lblCustCity.AutoSize = True
        Me.lblCustCity.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustCity.Location = New System.Drawing.Point(391, 180)
        Me.lblCustCity.Name = "lblCustCity"
        Me.lblCustCity.Size = New System.Drawing.Size(42, 18)
        Me.lblCustCity.TabIndex = 38
        Me.lblCustCity.Text = " City"
        '
        'lblCustDOB
        '
        Me.lblCustDOB.AutoSize = True
        Me.lblCustDOB.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustDOB.Location = New System.Drawing.Point(391, 127)
        Me.lblCustDOB.Name = "lblCustDOB"
        Me.lblCustDOB.Size = New System.Drawing.Size(104, 18)
        Me.lblCustDOB.TabIndex = 37
        Me.lblCustDOB.Text = "Date Of Birth"
        '
        'lblCustID
        '
        Me.lblCustID.AutoSize = True
        Me.lblCustID.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustID.Location = New System.Drawing.Point(391, 80)
        Me.lblCustID.Name = "lblCustID"
        Me.lblCustID.Size = New System.Drawing.Size(103, 18)
        Me.lblCustID.TabIndex = 36
        Me.lblCustID.Text = "Customer ID"
        '
        'lblZipCode
        '
        Me.lblZipCode.AutoSize = True
        Me.lblZipCode.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZipCode.Location = New System.Drawing.Point(16, 295)
        Me.lblZipCode.Name = "lblZipCode"
        Me.lblZipCode.Size = New System.Drawing.Size(69, 18)
        Me.lblZipCode.TabIndex = 35
        Me.lblZipCode.Text = "ZipCode"
        '
        'CustMobNo
        '
        Me.CustMobNo.AutoSize = True
        Me.CustMobNo.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustMobNo.Location = New System.Drawing.Point(391, 287)
        Me.CustMobNo.Name = "CustMobNo"
        Me.CustMobNo.Size = New System.Drawing.Size(119, 18)
        Me.CustMobNo.TabIndex = 34
        Me.CustMobNo.Text = " MobileNumber"
        '
        'lblCustState
        '
        Me.lblCustState.AutoSize = True
        Me.lblCustState.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustState.Location = New System.Drawing.Point(16, 240)
        Me.lblCustState.Name = "lblCustState"
        Me.lblCustState.Size = New System.Drawing.Size(53, 18)
        Me.lblCustState.TabIndex = 33
        Me.lblCustState.Text = " State"
        '
        'lblCustAddress
        '
        Me.lblCustAddress.AutoSize = True
        Me.lblCustAddress.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustAddress.Location = New System.Drawing.Point(16, 188)
        Me.lblCustAddress.Name = "lblCustAddress"
        Me.lblCustAddress.Size = New System.Drawing.Size(59, 18)
        Me.lblCustAddress.TabIndex = 32
        Me.lblCustAddress.Text = " Street"
        '
        'lblCustLastName
        '
        Me.lblCustLastName.AutoSize = True
        Me.lblCustLastName.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustLastName.Location = New System.Drawing.Point(15, 127)
        Me.lblCustLastName.Name = "lblCustLastName"
        Me.lblCustLastName.Size = New System.Drawing.Size(162, 18)
        Me.lblCustLastName.TabIndex = 31
        Me.lblCustLastName.Text = "Customer LastName"
        '
        'lblCustFirstName
        '
        Me.lblCustFirstName.AutoSize = True
        Me.lblCustFirstName.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustFirstName.Location = New System.Drawing.Point(16, 76)
        Me.lblCustFirstName.Name = "lblCustFirstName"
        Me.lblCustFirstName.Size = New System.Drawing.Size(163, 18)
        Me.lblCustFirstName.TabIndex = 30
        Me.lblCustFirstName.Text = "Customer FirstName"
        '
        'txtCustCity
        '
        Me.txtCustCity.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustCity.Location = New System.Drawing.Point(617, 180)
        Me.txtCustCity.Name = "txtCustCity"
        Me.txtCustCity.Size = New System.Drawing.Size(119, 26)
        Me.txtCustCity.TabIndex = 47
        '
        'lbComName
        '
        Me.lbComName.AutoSize = True
        Me.lbComName.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbComName.Location = New System.Drawing.Point(12, 334)
        Me.lbComName.Name = "lbComName"
        Me.lbComName.Size = New System.Drawing.Size(206, 18)
        Me.lbComName.TabIndex = 55
        Me.lbComName.Text = "Insurance Company Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(391, 331)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 18)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Insurance Start Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(391, 376)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 18)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Insurance End Date"
        '
        'cbCompName
        '
        Me.cbCompName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbCompName.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCompName.FormattingEnabled = True
        Me.cbCompName.Location = New System.Drawing.Point(228, 331)
        Me.cbCompName.Name = "cbCompName"
        Me.cbCompName.Size = New System.Drawing.Size(121, 26)
        Me.cbCompName.TabIndex = 45
        '
        'txtCustDOB
        '
        Me.txtCustDOB.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustDOB.Location = New System.Drawing.Point(617, 127)
        Me.txtCustDOB.Name = "txtCustDOB"
        Me.txtCustDOB.Size = New System.Drawing.Size(119, 26)
        Me.txtCustDOB.TabIndex = 46
        Me.txtCustDOB.Visible = False
        '
        'txtInsSD
        '
        Me.txtInsSD.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInsSD.Location = New System.Drawing.Point(617, 334)
        Me.txtInsSD.Name = "txtInsSD"
        Me.txtInsSD.Size = New System.Drawing.Size(119, 26)
        Me.txtInsSD.TabIndex = 50
        Me.txtInsSD.Visible = False
        '
        'txtInsED
        '
        Me.txtInsED.AcceptsTab = True
        Me.txtInsED.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInsED.Location = New System.Drawing.Point(617, 385)
        Me.txtInsED.Name = "txtInsED"
        Me.txtInsED.Size = New System.Drawing.Size(119, 26)
        Me.txtInsED.TabIndex = 51
        Me.txtInsED.Visible = False
        '
        'txtCusPh
        '
        Me.txtCusPh.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusPh.Location = New System.Drawing.Point(617, 233)
        Me.txtCusPh.MaxLength = 10
        Me.txtCusPh.Name = "txtCusPh"
        Me.txtCusPh.Size = New System.Drawing.Size(119, 26)
        Me.txtCusPh.TabIndex = 48
        '
        'txtCusMo
        '
        Me.txtCusMo.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusMo.Location = New System.Drawing.Point(617, 287)
        Me.txtCusMo.MaxLength = 10
        Me.txtCusMo.Name = "txtCusMo"
        Me.txtCusMo.Size = New System.Drawing.Size(119, 26)
        Me.txtCusMo.TabIndex = 49
        '
        'dt1
        '
        Me.dt1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt1.Location = New System.Drawing.Point(617, 127)
        Me.dt1.MaxDate = New Date(2016, 4, 11, 0, 0, 0, 0)
        Me.dt1.Name = "dt1"
        Me.dt1.Size = New System.Drawing.Size(119, 20)
        Me.dt1.TabIndex = 58
        Me.dt1.Value = New Date(2016, 4, 11, 0, 0, 0, 0)
        '
        'dt2
        '
        Me.dt2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt2.Location = New System.Drawing.Point(617, 335)
        Me.dt2.Name = "dt2"
        Me.dt2.Size = New System.Drawing.Size(119, 20)
        Me.dt2.TabIndex = 59
        Me.dt2.Value = New Date(2016, 4, 11, 0, 0, 0, 0)
        '
        'dt3
        '
        Me.dt3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt3.Location = New System.Drawing.Point(617, 385)
        Me.dt3.Name = "dt3"
        Me.dt3.Size = New System.Drawing.Size(119, 20)
        Me.dt3.TabIndex = 60
        Me.dt3.Value = New Date(2016, 4, 11, 0, 0, 0, 0)
        '
        'New_Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(844, 495)
        Me.Controls.Add(Me.dt3)
        Me.Controls.Add(Me.dt2)
        Me.Controls.Add(Me.dt1)
        Me.Controls.Add(Me.txtCusMo)
        Me.Controls.Add(Me.txtCusPh)
        Me.Controls.Add(Me.txtInsED)
        Me.Controls.Add(Me.txtInsSD)
        Me.Controls.Add(Me.txtCustDOB)
        Me.Controls.Add(Me.cbCompName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbComName)
        Me.Controls.Add(Me.txtCustCity)
        Me.Controls.Add(Me.cbCustState)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtCustID)
        Me.Controls.Add(Me.txtZipCode)
        Me.Controls.Add(Me.txtCustAddress)
        Me.Controls.Add(Me.txtCustLastName)
        Me.Controls.Add(Me.txtCustFirstName)
        Me.Controls.Add(Me.lblCustPhNo)
        Me.Controls.Add(Me.lblCustCity)
        Me.Controls.Add(Me.lblCustDOB)
        Me.Controls.Add(Me.lblCustID)
        Me.Controls.Add(Me.lblZipCode)
        Me.Controls.Add(Me.CustMobNo)
        Me.Controls.Add(Me.lblCustState)
        Me.Controls.Add(Me.lblCustAddress)
        Me.Controls.Add(Me.lblCustLastName)
        Me.Controls.Add(Me.lblCustFirstName)
        Me.Name = "New_Customer"
        Me.Text = "New_Customer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbCustState As System.Windows.Forms.ComboBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtCustID As System.Windows.Forms.TextBox
    Friend WithEvents txtZipCode As System.Windows.Forms.TextBox
    Friend WithEvents txtCustAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtCustLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtCustFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblCustPhNo As System.Windows.Forms.Label
    Friend WithEvents lblCustCity As System.Windows.Forms.Label
    Friend WithEvents lblCustDOB As System.Windows.Forms.Label
    Friend WithEvents lblCustID As System.Windows.Forms.Label
    Friend WithEvents lblZipCode As System.Windows.Forms.Label
    Friend WithEvents CustMobNo As System.Windows.Forms.Label
    Friend WithEvents lblCustState As System.Windows.Forms.Label
    Friend WithEvents lblCustAddress As System.Windows.Forms.Label
    Friend WithEvents lblCustLastName As System.Windows.Forms.Label
    Friend WithEvents lblCustFirstName As System.Windows.Forms.Label
    Friend WithEvents txtCustCity As System.Windows.Forms.TextBox
    Friend WithEvents lbComName As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbCompName As System.Windows.Forms.ComboBox
    Friend WithEvents txtCustDOB As System.Windows.Forms.TextBox
    Friend WithEvents txtInsSD As System.Windows.Forms.TextBox
    Friend WithEvents txtInsED As System.Windows.Forms.TextBox
    Friend WithEvents txtCusPh As System.Windows.Forms.TextBox
    Friend WithEvents txtCusMo As System.Windows.Forms.TextBox
    Friend WithEvents dt1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dt2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dt3 As System.Windows.Forms.DateTimePicker
End Class
