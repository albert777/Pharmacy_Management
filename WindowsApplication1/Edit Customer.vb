Public Class Edit_Customer

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim flag As Boolean = True
        Dim errorMsg As String = ""

        Dim id As String = lblText.Text

        If String.IsNullOrWhiteSpace(txtCustAddress.Text.ToString) Then
            flag = False
            errorMsg = "Enter Customer Address" & vbNewLine & errorMsg
        End If

        If String.IsNullOrWhiteSpace(txtCustFirstName.Text.ToString) Then
            flag = False
            errorMsg = "Enter Customer First Name" & vbNewLine & errorMsg
        End If

        If String.IsNullOrWhiteSpace(txtCustLastName.Text.ToString) Then
            flag = False
            errorMsg = "Enter Customer Last Name" & vbNewLine & errorMsg
        End If

        If String.IsNullOrWhiteSpace(txtCusMo.Text.ToString) Then
            flag = False
            errorMsg = "Enter Customer Mobile Number" & vbNewLine & errorMsg
        ElseIf txtCusMo.Text.ToString.Length <> 10 Then
            flag = False
            MessageBox.Show("Phone number should contain 10 digits", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                Double.Parse(txtCusMo.Text.ToString)
            Catch ex As Exception
                flag = False
                MessageBox.Show("Mobile number should contain numbers", " Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If

        If String.IsNullOrWhiteSpace(txtCusPh.Text.ToString) Then
            flag = False
            errorMsg = "Enter Customer Telephone number" & vbNewLine & errorMsg
        ElseIf txtCusPh.Text.ToString.Length <> 10 Then
            flag = False
            MessageBox.Show("Phone number should contain 10 digits", " Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                Double.Parse(txtCusPh.Text.ToString)
            Catch ex As Exception
                flag = False
                MessageBox.Show("Telephone number should contain numbers", " Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If

        If String.IsNullOrWhiteSpace(txtZipCode.Text.ToString) Then
            flag = False
            errorMsg = "Enter Zip code" & vbNewLine & errorMsg
        ElseIf txtZipCode.Text.ToString.Length <> 5 Then
            flag = False
            MessageBox.Show("Zipcode should contain 5 digits", " Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                Double.Parse(txtZipCode.Text.ToString)
            Catch ex As Exception
                flag = False
                MessageBox.Show("Zip code should contain numbers", " Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If

        If String.IsNullOrWhiteSpace(txtCustCity.Text.ToString) Then
            flag = False
            errorMsg = "Enter Customer City" & vbNewLine & errorMsg
        End If

        If String.IsNullOrWhiteSpace(cbCustState.Text.ToString) Then
            flag = False
            errorMsg = "Select Customer State" & vbNewLine & errorMsg
        End If

        If String.IsNullOrWhiteSpace(cbCompName.Text.ToString) Then
            flag = False
            errorMsg = "Select Insurance Company name" & vbNewLine & errorMsg
        End If

        If String.IsNullOrWhiteSpace(txtInsSD.Text.ToString) Then
            flag = False
            errorMsg = "Enter Insurance start date(yyyy-mm-dd)" & vbNewLine & errorMsg
        Else
            Dim match As Boolean = txtInsSD.Text.ToString Like "####-##-##"
            If match = False Then
                flag = False
                MessageBox.Show("Inurance Start Date should be yyyy-mm-dd format", " Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

        If String.IsNullOrWhiteSpace(txtInsED.Text.ToString) Then
            flag = False
            errorMsg = "Enter Insurance End date(yyyy-mm-dd)" & vbNewLine & errorMsg
        Else
            Dim match As Boolean = txtInsED.Text.ToString Like "####-##-##"
            If match = False Then
                flag = False
                MessageBox.Show("Insurance End date should be yyyy-mm-dd format", " Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

        If flag Then


            If String.IsNullOrWhiteSpace(txtInsSD.Text.ToString) = False And String.IsNullOrWhiteSpace(txtInsED.Text.ToString) = False Then

                Dim diff As Long = DateDiff(DateInterval.Day, Date.Parse(txtInsSD.Text.ToString), Date.Parse(txtInsED.Text.ToString))

                If diff < 0 Then
                    flag = False
                    MessageBox.Show("Enter the Insrance End date greater than the Start Date", " Important Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If

        If flag Then

            Dim connect As New ConnectToDB
            Dim query As String
            Dim result As Integer

            connect.Connect()

            If Not lblOldIns.Equals(cbCompName.Text) Then
                query = "select Insurance_ID as id from insurance where Insurance_Company_Name='" + cbCompName.Text.ToString + "'"
                Dim output As Odbc.OdbcDataReader = connect.ExecuteQuery(query)
                output.Read()
                id = output("id")
            End If

            query = "update customer set Customer_FirstName='" & txtCustFirstName.Text & "',Customer_LastName='" & txtCustLastName.Text & "',Customer_Address='" & txtCustAddress.Text & "',Customer_City='" & txtCustCity.Text & "',Customer_State='" & cbCustState.Text & "',customer_Zipcode=" & txtZipCode.Text & ",Customer_MobileNumber=" & txtCusMo.Text & ",Customer_HomeNumber=" & txtCusPh.Text & ",Insurance_Start_Date='" & txtInsSD.Text & "',Insurance_End_Date='" & txtInsED.Text & "',Insurance_ID=" & id & " where Customer_ID=" & CustomerId.txtCustId.Text & ""
            result = connect.ExecuteQuery(query)

            If result <> 1 Then
                MessageBox.Show("Issue while inserting values to DB", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            connect.DisConnect()
            Me.Close()
            CustomerId.Close()

        Else
            If String.IsNullOrWhiteSpace(errorMsg) = False Then
                MessageBox.Show(errorMsg, " Required Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub Edit_Customer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class