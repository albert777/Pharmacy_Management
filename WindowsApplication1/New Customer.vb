Public Class New_Customer

    Private Sub btnNext_Click(sender As System.Object, e As System.EventArgs) Handles btnNext.Click

        Dim flag As Boolean = True
        Dim errorMsg As String = ""

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

        If String.IsNullOrWhiteSpace(txtCustDOB.Text.ToString) Then
            flag = False
            errorMsg = "Select Customer Date of Birth" & vbNewLine & errorMsg
        End If

        If String.IsNullOrWhiteSpace(txtInsSD.Text.ToString) Then
            flag = False
            errorMsg = "Select Insurance start date(yyyy-mm-dd)" & vbNewLine & errorMsg
        End If

        If String.IsNullOrWhiteSpace(txtInsED.Text.ToString) Then
            flag = False
            errorMsg = "Select Insurance End date(yyyy-mm-dd)" & vbNewLine & errorMsg
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
            connect.Connect()

            query = "select Insurance_ID as id from insurance where Insurance_Company_Name='" + cbCompName.Text.ToString + "'"
            Dim output As Odbc.OdbcDataReader = connect.ExecuteQuery(query)
            output.Read()
            Dim temp As String = output("id")

            query = "insert into customer values (" & Integer.Parse(txtCustID.Text.ToString) & "," & Integer.Parse(temp) & ",'" & txtCustFirstName.Text.ToString & "','" & txtCustLastName.Text.ToString & "','" & txtCustDOB.Text.ToString & "','" & txtCustAddress.Text.ToString & "','" & txtCustCity.Text.ToString & "','" & cbCustState.Text.ToString & "'," & txtZipCode.Text.ToString & "," & txtCusMo.Text.ToString & "," & txtCusPh.Text.ToString & ",'" & txtInsSD.Text.ToString & "','" & txtInsED.Text.ToString & "')"

            Dim value As Integer = connect.ExecuteQuery(query)
            If value <> 1 Then
                MessageBox.Show("Issue while inserting values to DB", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            query = "select Prescription_ID from prescription order by Prescription_ID asc"
            Dim result As Odbc.OdbcDataReader = connect.ExecuteQuery(query)
            Dim count As Integer
            While result.Read()
                count = Integer.Parse(result("Prescription_ID"))
            End While
            count = count + 1
            New_Prescription.txtPrescriptionID.Text = count
            New_Prescription.txtPrescriptionID.ReadOnly = True

            New_Prescription.txtCustID.Text = txtCustID.Text.ToString
            New_Prescription.txtCustID.ReadOnly = True

            New_Prescription.txtCustFirstName.Text = txtCustFirstName.Text
            New_Prescription.txtCustFirstName.ReadOnly = True

            New_Prescription.txtCustLastName.Text = txtCustLastName.Text
            New_Prescription.txtCustLastName.ReadOnly = True

            query = "select Medicine_Name as name from medicine_inventory"
            result = connect.ExecuteQuery(query)
            Dim names As String = ""
            While result.Read
                names = result("name") + "," + names
            End While
            connect.DisConnect()

            Dim temp1 As Array = names.Split(",")
            New_Prescription.cbMedName1.Items.AddRange(temp1)

            New_Prescription.Show()
        Else
            If String.IsNullOrWhiteSpace(errorMsg) = False Then
                MessageBox.Show(errorMsg, " Required Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtCustAddress.Clear()
        txtCustFirstName.Clear()
        txtCustLastName.Clear()
        txtCusMo.Clear()
        txtCusPh.Clear()
        txtZipCode.Clear()
        txtCustCity.Clear()
        cbCustState.Text = ""
        cbCompName.Text = ""
        txtCustDOB.Clear()
        txtInsSD.Clear()
        txtInsED.Clear()

    End Sub

    Private Sub New_Customer_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

        dt1.Value = Format(Date.Now, "yyyy-MM-dd")
        dt1.MaxDate = Format(Date.Now, "yyyy-MM-dd")

        dt2.Value = Format(Date.Now, "yyyy-MM-dd")

        dt3.Value = Format(Date.Now, "yyyy-MM-dd")

        Dim connect As New ConnectToDB
        Dim query As String
        Dim result As Odbc.OdbcDataReader
        
        connect.Connect()
        query = "select Customer_ID from customer order by Customer_ID asc"
        result = connect.ExecuteQuery(query)
        Dim count As Integer
        While result.Read()
            count = Integer.Parse(result("Customer_ID"))
        End While
        count = count + 1
        txtCustID.Text = count.ToString
        txtCustID.ReadOnly = True

        query = "select Insurance_Company_Name as name from insurance"
        result = connect.ExecuteQuery(query)
        Dim value As String = ""
        While result.Read
            value = result("name") + "," + value
        End While
        Dim temp As Array = value.Split(",")
        cbCompName.Items.AddRange(temp)
        connect.DisConnect()

    End Sub

    Private Sub dt1_ValueChanged(sender As Object, e As EventArgs) Handles dt1.Leave
        txtCustDOB.Text = Format(dt1.Value, "yyyy-MM-dd")
    End Sub

    Private Sub dt2_ValueChanged(sender As Object, e As EventArgs) Handles dt2.Leave
        txtInsSD.Text = Format(dt1.Value, "yyyy-MM-dd")
    End Sub

    Private Sub dt3_ValueChanged(sender As Object, e As EventArgs) Handles dt3.Leave
        txtInsED.Text = Format(dt1.Value, "yyyy-MM-dd")
    End Sub
End Class