Public Class Login

    Private Sub btnSubmit_Click(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click

        Dim connect As New ConnectToDB
        Dim usrName As String = txtUsrName.Text.ToString
        Dim passwrd As String = txtPasswd.Text.ToString
        Dim flag As Boolean = True
        Dim errorMsg As String = ""

        If String.IsNullOrWhiteSpace(usrName) Then
            flag = False
            errorMsg = "Enter the UserName" & vbNewLine & errorMsg
        End If

        If String.IsNullOrWhiteSpace(passwrd) Then
            flag = False
            errorMsg = "Enter the password" & vbNewLine & errorMsg
        End If

        If flag Then
            Dim query As String = "select Role,FirstName,LastName from employee where UserName='" + usrName + "' and Password='" + passwrd + "'"
            connect.Connect()
            Dim result As Odbc.OdbcDataReader = connect.ExecuteQuery(query)
            result.Read()
            Try
                Dim temp As String = result("LastName") & "," & result("FirstName") & ""

                Dim role As String = result("Role")
                If role.ToLower.Equals("manager") Then
                    Home_Page.lblWelName.Text = "Welcome Manager (" & temp & ")"
                    Billing.lblWelName.Text = "Welcome Manager (" & temp & ")"
                    Home_Page.Show()
                    Me.Hide()
                Else
                    Home_Page.lblWelName.Text = "Welcome Employee (" & temp & ")"
                    Billing.lblWelName.Text = "Welcome Employee (" & temp & ")"
                    Home_Page.Show()
                    Me.Hide()
                    Home_Page.Panel4.Hide()
                    Home_Page.btnNewMed.Visible = False
                    Home_Page.btnNewIns.Visible = False
                    Home_Page.Label4.Hide()
                End If
            Catch ex As Exception
                txtPasswd.Clear()
                txtUsrName.Clear()
                MessageBox.Show("UserName or Password is incorrect", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            connect.DisConnect()
        Else
            If String.IsNullOrWhiteSpace(errorMsg) = False Then
                MessageBox.Show(errorMsg, " Required Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPasswd.Clear()
        txtUsrName.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
