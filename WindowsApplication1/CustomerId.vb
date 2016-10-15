Public Class CustomerId

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim flag As Boolean = True
        Dim query As String = ""

        If String.IsNullOrWhiteSpace(txtCustId.Text.ToString) Then
            If String.IsNullOrWhiteSpace(txtFstName.Text.ToString) Or String.IsNullOrWhiteSpace(txtLstName.Text.ToString) Or String.IsNullOrWhiteSpace(txtdob.Text.ToString) Then
                flag = False
                MessageBox.Show("Enter Customer ID or Enter First name,Last name, DOB", "Required Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim match As Boolean = txtdob.Text.ToString Like "####-##-##"
                If match = False Then
                    flag = False
                    MessageBox.Show("Date of birth should be yyyy-mm-dd format", " Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Else
            Try
                Integer.Parse(txtCustId.Text.ToString)
            Catch ex As Exception
                flag = False
                MessageBox.Show("Cutomer Id should contain numbers", " Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtCustId.Clear()
            End Try
        End If

        If flag Then
            Try

                If String.IsNullOrWhiteSpace(txtCustId.Text.ToString) = False Then
                    query = "select * from customer where Customer_ID=" & txtCustId.Text.ToString
                Else
                    query = "select * from customer where Customer_FirstName like '" & txtFstName.Text.ToString & "' and Customer_LastName like '" & txtLstName.Text.ToString & "' and Customer_DOB like '" & txtdob.Text.ToString & "'"
                End If

                Dim connect As New ConnectToDB
                connect.Connect()

                Dim result As Odbc.OdbcDataReader = connect.ExecuteQuery(query)
                result.Read()

                txtCustId.Text = result("Customer_ID")
                New_Prescription.txtCustID.Text = result("Customer_ID")
                Billing.txtCusId.Text = result("Customer_ID")
                New_Prescription.txtCustID.ReadOnly = True

                New_Prescription.txtCustFirstName.Text = result("Customer_FirstName")
                Billing.txtCusFN.Text = result("Customer_FirstName")
                New_Prescription.txtCustFirstName.ReadOnly = True

                New_Prescription.txtCustLastName.Text = result("Customer_LastName")
                Billing.txtCusLN.Text = result("Customer_LastName")
                New_Prescription.txtCustLastName.ReadOnly = True

                Billing.txtCusAdd.Text = result("Customer_Address")
                Billing.txtCusMN.Text = result("Customer_MobileNumber")
                lblTxt.Text = result("Insurance_ID")
                Billing.txtPrecDate.Text = Date.Now.ToString("yyyy-MM-dd")

                query = "select Prescription_ID from prescription order by Prescription_ID asc"
                result = connect.ExecuteQuery(query)
                Dim count As Integer
                While result.Read()
                    count = Integer.Parse(result("Prescription_ID"))
                End While
                count = count + 1

                New_Prescription.txtPrescriptionID.Text = count
                Billing.txtPrecId.Text = count
                New_Prescription.txtPrescriptionID.ReadOnly = True

                query = "select Medicine_Name as name from medicine_inventory"
                result = connect.ExecuteQuery(query)
                Dim names As String = ""
                While result.Read
                    names = result("name") + "," + names
                End While

                query = "select Insurance_Company_Name as name, InsurancePlan as plan from insurance where Insurance_ID = " + lblTxt.Text.ToString + ""
                result = connect.ExecuteQuery(query)
                result.Read()
                Billing.txtInsName.Text = result("name")
                Billing.txtInsPlan.Text = result("plan")
                connect.DisConnect()

                Dim temp1 As Array = names.Split(",")
                New_Prescription.cbMedName1.Items.AddRange(temp1)

                Me.Hide()
                New_Prescription.Show()
            Catch ex As Exception
                MessageBox.Show("Customer detail is not available in DB", " Important Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtCustId.Clear()
                txtdob.Clear()
                txtFstName.Clear()
                txtLstName.Clear()
            End Try
        End If

    End Sub

    Private Sub btnEditCus_Click(sender As Object, e As EventArgs) Handles btnEditCus.Click

        Dim flag As Boolean = True
        Dim connect As New ConnectToDB
        Dim query As String
        Dim result As Odbc.OdbcDataReader

        If String.IsNullOrWhiteSpace(txtCustId.Text.ToString) Then
            If String.IsNullOrWhiteSpace(txtFstName.Text.ToString) Or String.IsNullOrWhiteSpace(txtLstName.Text.ToString) Or String.IsNullOrWhiteSpace(txtdob.Text.ToString) Then
                flag = False
                MessageBox.Show("Enter Customer ID or Enter First name,Last name, DOB", "Required Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim match As Boolean = txtdob.Text.ToString Like "####-##-##"
                If match = False Then
                    flag = False
                    MessageBox.Show("Date of birth should be yyyy-mm-dd format", " Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Else
            Try
                Integer.Parse(txtCustId.Text.ToString)
            Catch ex As Exception
                flag = False
                MessageBox.Show("Cutomer Id should contain numbers", " Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtCustId.Clear()
            End Try
        End If

        If flag Then

            If String.IsNullOrWhiteSpace(txtCustId.Text.ToString) = False Then
                query = "select * from customer where Customer_ID=" & txtCustId.Text.ToString
            Else
                query = "select * from customer where Customer_FirstName like '" & txtFstName.Text.ToString & "' and Customer_LastName like '" & txtLstName.Text.ToString & "' and Customer_DOB like '" & txtdob.Text.ToString & "'"
            End If

            connect.Connect()
            result = connect.ExecuteQuery(query)
            result.Read()

            Try
                Edit_Customer.txtCustFirstName.Text = result("Customer_FirstName")
                Edit_Customer.txtCustLastName.Text = result("Customer_LastName")
                Edit_Customer.txtCusMo.Text = result("Customer_MobileNumber")
                Edit_Customer.txtCusPh.Text = result("Customer_HomeNumber")
                Edit_Customer.txtCustAddress.Text = result("Customer_Address")
                Edit_Customer.txtCustCity.Text = result("Customer_City")

                Edit_Customer.txtInsED.Text = result("Insurance_End_Date")
                Dim tempArray As Array = Edit_Customer.txtInsED.Text.Split("/")
                If tempArray(0).ToString.Length = 1 Then
                    tempArray(0) = "0" & tempArray(0)
                End If
                Edit_Customer.txtInsED.Text = tempArray(2) & "-" & tempArray(0) & "-" & tempArray(1)

                Edit_Customer.txtInsSD.Text = result("Insurance_Start_Date")
                tempArray = Edit_Customer.txtInsSD.Text.Split("/")
                If tempArray(0).ToString.Length = 1 Then
                    tempArray(0) = "0" & tempArray(0)
                End If
                Edit_Customer.txtInsSD.Text = tempArray(2) & "-" & tempArray(0) & "-" & tempArray(1)

                Edit_Customer.txtZipCode.Text = result("customer_Zipcode")
                Edit_Customer.cbCustState.Text = result("Customer_State")
                Dim id As String = result("Insurance_ID")
                Edit_Customer.lblText.Text = id

                query = "select Insurance_Company_Name as name from insurance"
                result = connect.ExecuteQuery(query)
                Dim value As String = ""
                While result.Read
                    value = result("name") + "," + value
                End While
                Dim temp As Array = value.Split(",")
                Edit_Customer.cbCompName.Items.AddRange(temp)

                query = "select Insurance_Company_Name as name from insurance where Insurance_ID=" & id & ""
                result = connect.ExecuteQuery(query)
                result.Read()
                Edit_Customer.cbCompName.Text = result("name")
                Edit_Customer.lblOldIns.Text = result("name")

                Edit_Customer.Show()

            Catch ex As Exception
                MessageBox.Show("Customer detail is not available in DB", " Important Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtCustId.Clear()
                txtdob.Clear()
                txtFstName.Clear()
                txtLstName.Clear()
            End Try
            connect.DisConnect()
        End If
    End Sub

    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker1.Leave
        txtdob.Text = Format(DateTimePicker1.Value, "yyyy-MM-dd")
    End Sub
End Class