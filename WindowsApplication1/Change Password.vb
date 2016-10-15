Public Class Change_Password

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Dim usrName As String = txtUsrName.Text.ToString
        Dim oldPasswrd As String = txtOldPsswd.Text.ToString
        Dim newPasswrd As String = txtNewPsswd.Text.ToString
        Dim rNewPasswrd As String = txtRNewPsswd.Text.ToString
        Dim flag As Boolean = True

        If String.IsNullOrWhiteSpace(usrName) Then
            flag = False
            MessageBox.Show("Enter User Name", "Required Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        If String.IsNullOrWhiteSpace(oldPasswrd) Then
            flag = False
            MessageBox.Show("Enter Old Password", "Required Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        If String.IsNullOrWhiteSpace(newPasswrd) Then
            flag = False
            MessageBox.Show("Enter New Password", "Required Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If oldPasswrd.Equals(newPasswrd) Then
                flag = False
                txtNewPsswd.Clear()
                txtRNewPsswd.Clear()
                MessageBox.Show("Old Password and New Password is same", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

        If String.IsNullOrWhiteSpace(rNewPasswrd) Then
            flag = False
            MessageBox.Show("Enter Re-Password", "Required Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If newPasswrd <> rNewPasswrd Then
                flag = False
                txtNewPsswd.Clear()
                txtRNewPsswd.Clear()
                MessageBox.Show("New Password and Re-Enter Password is not same", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf newPasswrd.Length < 8 Then
                flag = False
                txtNewPsswd.Clear()
                txtRNewPsswd.Clear()
                newPasswrd = ""
                rNewPasswrd = ""
                MessageBox.Show("New Password should have more than 8 characters", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

        If flag Then
            Dim query As String = "update employee set Password='" + newPasswrd + "' where UserName='" + usrName + "' and Password='" + oldPasswrd + "'"

            Dim connect As New ConnectToDB
            connect.Connect()

            Dim output As Integer = connect.ExecuteQuery(query)

            If output <> 1 Then
                flag = False
                MessageBox.Show("UserName or the old Password doesn't match. Please try again", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            connect.DisConnect()

            If flag Then
                Home_Page.Show()
                Me.Close()
            Else
                txtNewPsswd.Clear()
                txtOldPsswd.Clear()
                txtRNewPsswd.Clear()
                txtUsrName.Clear()
            End If
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNewPsswd.Clear()
        txtOldPsswd.Clear()
        txtRNewPsswd.Clear()
        txtUsrName.Clear()
    End Sub
End Class