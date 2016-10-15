<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Change_Password
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRNewPsswd = New System.Windows.Forms.TextBox()
        Me.lblRNewPsswd = New System.Windows.Forms.Label()
        Me.txtNewPsswd = New System.Windows.Forms.TextBox()
        Me.txtOldPsswd = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblNewPsswd = New System.Windows.Forms.Label()
        Me.lblOldPsswd = New System.Windows.Forms.Label()
        Me.txtUsrName = New System.Windows.Forms.TextBox()
        Me.lblUsrName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(356, 261)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(343, 18)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "( * The password must be 8 character long )"
        '
        'txtRNewPsswd
        '
        Me.txtRNewPsswd.AcceptsTab = True
        Me.txtRNewPsswd.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRNewPsswd.Location = New System.Drawing.Point(360, 293)
        Me.txtRNewPsswd.Name = "txtRNewPsswd"
        Me.txtRNewPsswd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRNewPsswd.Size = New System.Drawing.Size(157, 26)
        Me.txtRNewPsswd.TabIndex = 4
        '
        'lblRNewPsswd
        '
        Me.lblRNewPsswd.AutoSize = True
        Me.lblRNewPsswd.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRNewPsswd.Location = New System.Drawing.Point(154, 300)
        Me.lblRNewPsswd.Name = "lblRNewPsswd"
        Me.lblRNewPsswd.Size = New System.Drawing.Size(186, 18)
        Me.lblRNewPsswd.TabIndex = 19
        Me.lblRNewPsswd.Text = "Re-Enter new password"
        '
        'txtNewPsswd
        '
        Me.txtNewPsswd.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPsswd.Location = New System.Drawing.Point(360, 220)
        Me.txtNewPsswd.Name = "txtNewPsswd"
        Me.txtNewPsswd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPsswd.Size = New System.Drawing.Size(157, 26)
        Me.txtNewPsswd.TabIndex = 3
        '
        'txtOldPsswd
        '
        Me.txtOldPsswd.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOldPsswd.Location = New System.Drawing.Point(360, 146)
        Me.txtOldPsswd.Name = "txtOldPsswd"
        Me.txtOldPsswd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtOldPsswd.Size = New System.Drawing.Size(157, 26)
        Me.txtOldPsswd.TabIndex = 2
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(264, 381)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(80, 33)
        Me.btnSubmit.TabIndex = 5
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(415, 381)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(80, 33)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblNewPsswd
        '
        Me.lblNewPsswd.AutoSize = True
        Me.lblNewPsswd.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewPsswd.Location = New System.Drawing.Point(171, 206)
        Me.lblNewPsswd.Name = "lblNewPsswd"
        Me.lblNewPsswd.Size = New System.Drawing.Size(160, 18)
        Me.lblNewPsswd.TabIndex = 14
        Me.lblNewPsswd.Text = "Enter new password"
        '
        'lblOldPsswd
        '
        Me.lblOldPsswd.AutoSize = True
        Me.lblOldPsswd.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOldPsswd.Location = New System.Drawing.Point(177, 146)
        Me.lblOldPsswd.Name = "lblOldPsswd"
        Me.lblOldPsswd.Size = New System.Drawing.Size(151, 18)
        Me.lblOldPsswd.TabIndex = 13
        Me.lblOldPsswd.Text = "Enter old password"
        '
        'txtUsrName
        '
        Me.txtUsrName.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsrName.Location = New System.Drawing.Point(360, 82)
        Me.txtUsrName.Name = "txtUsrName"
        Me.txtUsrName.Size = New System.Drawing.Size(157, 26)
        Me.txtUsrName.TabIndex = 1
        '
        'lblUsrName
        '
        Me.lblUsrName.AutoSize = True
        Me.lblUsrName.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsrName.Location = New System.Drawing.Point(217, 85)
        Me.lblUsrName.Name = "lblUsrName"
        Me.lblUsrName.Size = New System.Drawing.Size(86, 18)
        Me.lblUsrName.TabIndex = 11
        Me.lblUsrName.Text = "UserName"
        '
        'Change_Password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(930, 512)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtRNewPsswd)
        Me.Controls.Add(Me.lblRNewPsswd)
        Me.Controls.Add(Me.txtNewPsswd)
        Me.Controls.Add(Me.txtOldPsswd)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblNewPsswd)
        Me.Controls.Add(Me.lblOldPsswd)
        Me.Controls.Add(Me.txtUsrName)
        Me.Controls.Add(Me.lblUsrName)
        Me.Name = "Change_Password"
        Me.Text = "Change_Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRNewPsswd As System.Windows.Forms.TextBox
    Friend WithEvents lblRNewPsswd As System.Windows.Forms.Label
    Friend WithEvents txtNewPsswd As System.Windows.Forms.TextBox
    Friend WithEvents txtOldPsswd As System.Windows.Forms.TextBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblNewPsswd As System.Windows.Forms.Label
    Friend WithEvents lblOldPsswd As System.Windows.Forms.Label
    Friend WithEvents txtUsrName As System.Windows.Forms.TextBox
    Friend WithEvents lblUsrName As System.Windows.Forms.Label
End Class
