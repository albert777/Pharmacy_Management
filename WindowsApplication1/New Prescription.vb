Public Class New_Prescription

    Private Sub btnNext_Click(sender As System.Object, e As System.EventArgs) Handles btnNext.Click


        Dim flag As Boolean = True
        Dim connect As New ConnectToDB
        Dim query As String
        Dim result As Odbc.OdbcDataReader

        If String.IsNullOrWhiteSpace(dgViwe1.Rows(0).Cells(0).Value) Then
            flag = False
            MessageBox.Show("Insert one or more tablet", " Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        If String.IsNullOrWhiteSpace(cbTotalRefillAllowed.Text.ToString) Then
            flag = False
            MessageBox.Show("Select total refil value", "Required Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        If flag Then
            If String.IsNullOrWhiteSpace(New_Customer.txtCustFirstName.Text) = False Then
                Billing.txtPrecId.Text = txtPrescriptionID.Text
                Billing.txtCusId.Text = New_Customer.txtCustID.Text
                Billing.txtCusFN.Text = New_Customer.txtCustFirstName.Text
                Billing.txtCusLN.Text = New_Customer.txtCustLastName.Text
                Billing.txtCusAdd.Text = New_Customer.txtCustAddress.Text
                Billing.txtCusMN.Text = New_Customer.txtCusMo.Text
                Billing.txtPrecDate.Text = Date.Now.ToString("yyyy-MM-dd")
                Billing.txtRefil.Text = ""
                Billing.txtInsName.Text = New_Customer.cbCompName.Text

                If String.IsNullOrWhiteSpace(Insurance_Information.txtInsurancePlan.Text) Then
                    query = "select InsurancePlan as plan from insurance where Insurance_Company_Name='" + New_Customer.cbCompName.Text + "'"
                    connect.Connect()
                    result = connect.ExecuteQuery(query)
                    result.Read()
                    Billing.txtInsPlan.Text = result("plan")
                    connect.DisConnect()
                Else
                    Billing.txtInsPlan.Text = Insurance_Information.txtInsurancePlan.Text
                End If
            End If

            Dim temp1 As Double = 0.0
            Dim temp2 As Double = 0.0
            Dim j As Integer = 0

            connect.Connect()
            For i As Integer = 0 To dgViwe1.Rows.Count - 2

                query = "select UnitsInStock from medicine_inventory where Medicine_Name='" & dgViwe1.Rows(i).Cells(0).Value & "'"
                result = connect.ExecuteQuery(query)
                result.Read()
                Dim up As Integer = Integer.Parse(result("UnitsInStock"))
                Dim temp As Integer = up - Integer.Parse(dgViwe1.Rows(i).Cells(1).Value)

                If temp < 0 Then
                    j = j - 1
                    MessageBox.Show("Medicine [" & dgViwe1.Rows(i).Cells(0).Value & "] is out of stock. " & up & " tablets available", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Billing.gdView1.Rows.Add("", "", "", "", "")
                    Billing.gdView1.Rows(j).Cells(0).Value = dgViwe1.Rows(i).Cells(0).Value
                    Billing.gdView1.Rows(j).Cells(1).Value = dgViwe1.Rows(i).Cells(1).Value

                    query = "select UnitPrice as up,Tier from medicine_inventory where Medicine_Name='" + dgViwe1.Rows(i).Cells(0).Value + "'"
                    result = connect.ExecuteQuery(query)
                    result.Read()

                    Dim upr As Double = Double.Parse(result("up"))
                    Dim tier As Integer = Integer.Parse(result("Tier"))
                    Dim total As Double = upr * Double.Parse(dgViwe1.Rows(i).Cells(1).Value)

                    Billing.gdView1.Rows(j).Cells(2).Value = upr.ToString
                    Billing.gdView1.Rows(j).Cells(3).Value = total.ToString
                    Billing.gdView1.Rows(j).Cells(4).Value = tier.ToString

                    Dim id As String
                    If String.IsNullOrWhiteSpace(New_Customer.txtCustFirstName.Text.ToString) = False Then
                        query = "select Insurance_ID as id from insurance where Insurance_Company_Name='" + New_Customer.cbCompName.Text.ToString + "'"
                        result = connect.ExecuteQuery(query)
                        result.Read()
                        id = result("id")
                    Else
                        id = CustomerId.lblTxt.Text.ToString
                    End If

                    query = "select Percentage_Coverage as per from insurance_details where Insurance_ID=" + id + " and Tier='" + tier.ToString + "'"
                    result = connect.ExecuteQuery(query)
                    result.Read()
                    Dim cTotal As Double = (total * Integer.Parse(result("per"))) / 100

                    Billing.gdView1.Rows(j).Cells(5).Value = cTotal.ToString

                    temp1 = temp1 + Double.Parse(Billing.gdView1.Rows(i).Cells(3).Value)
                    temp2 = temp2 + Double.Parse(Billing.gdView1.Rows(i).Cells(5).Value)
                    j = j + 1
                End If
            Next i

            If j > 0 Then
                query = "select Insurance_End_Date from customer where Customer_ID=" & txtCustID.Text.ToString & ""
                result = connect.ExecuteQuery(query)
                result.Read()

                Dim endDate As Date = Date.Parse(result("Insurance_End_Date"))
                Dim dat As Long = DateDiff(DateInterval.Day, Date.Now, endDate)

                If dat < 0 Then
                    MessageBox.Show("Inurance is expired", " Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    temp2 = 0.0
                End If

                connect.DisConnect()
                Billing.txtTotal.Text = temp1.ToString
                Billing.txtCTotal.Text = temp2.ToString
                Billing.txtDue.Text = (temp1 - temp2).ToString

                Billing.Show()
                CustomerId.Close()
            Else
                dgViwe1.Rows.Clear()
            End If
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        cbMedName1.Text = ""
        txtQpU1.Clear()
        cbTotalRefillAllowed.Text = ""
        dgViwe1.Rows.Clear()
        CustomerId.Close()

    End Sub

    Public Sub addValue(medicine, quantity)
        Me.dgViwe1.Rows.Add(medicine, quantity)
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click

        If String.IsNullOrWhiteSpace(txtQpU1.Text.ToString) Then
            MessageBox.Show("Enter the Quantity", " Required Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf String.IsNullOrWhiteSpace(cbMedName1.Text.ToString) Then
            MessageBox.Show("Select the medicine name", " Required Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf String.IsNullOrWhiteSpace(txtQpU1.Text.ToString) = False Then
            Try
                Integer.Parse(txtQpU1.Text.ToString)
                addValue(cbMedName1.Text.ToString, txtQpU1.Text.ToString)
                cbMedName1.Text = ""
                txtQpU1.Clear()
            Catch ex As Exception
                MessageBox.Show("Quantity should be numbers", " Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If

    End Sub
End Class