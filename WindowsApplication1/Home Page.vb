Public Class Home_Page

    Dim totalRefil As Integer

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnChngPasswd.Click
        Change_Password.Show()
    End Sub

    Private Sub btnNewCustomers_Click(sender As System.Object, e As System.EventArgs) Handles btnNewCustomers.Click
        New_Customer.Show()
    End Sub

    Private Sub btnNewPrescription_Click(sender As System.Object, e As System.EventArgs) Handles btnNewPrescription.Click
        CustomerId.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        Login.txtUsrName.Clear()
        Login.txtPasswd.Clear()
        Login.Show()

    End Sub
    Private Sub dgcusDetail_load(sender As System.Object, e As System.EventArgs) Handles dgcusDetail.CellFormatting

        With dgcusDetail.ColumnHeadersDefaultCellStyle
            .Font = New Font(dgcusDetail.Font, FontStyle.Bold)

        End With
        With dgcusDetail.Columns
            dgcusDetail.DefaultCellStyle.Font = New Font("Verdana", 10)
        End With
        With dgInsDetail.Columns
            dgInsDetail.DefaultCellStyle.Font = New Font("Verdana", 10)
        End With
        With dgMedDetail.Columns
            dgMedDetail.DefaultCellStyle.Font = New Font("Verdana", 10)
        End With
    End Sub

    Private Sub btnSearchCust_Click(sender As Object, e As EventArgs) Handles btnSearchCust.Click

        txtCusId.ReadOnly = True
        txtPrecId.ReadOnly = True

        Dim flag As Boolean = True

        dgMedDetail.Rows.Clear()

        Dim connect As New ConnectToDB
        Dim query As String
        Dim result As Odbc.OdbcDataReader
        If String.IsNullOrWhiteSpace(txtCusId.Text.ToString) Then
            flag = False
            MessageBox.Show("Enter the customer id on right hand side of the form", "Required Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                Integer.Parse(txtCusId.Text.ToString)
            Catch ex As Exception
                flag = False
                MessageBox.Show("Customer Id should contain digits", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        If flag Then

            connect.Connect()
            query = "select * from customer where Customer_ID=" & txtCusId.Text.ToString & ""
            result = connect.ExecuteQuery(query)
            result.Read()

            Try
                dgcusDetail.Rows(0).Cells(0).Value = result("Customer_ID")
                dgcusDetail.Rows(0).Cells(1).Value = result("Insurance_ID")
                dgcusDetail.Rows(0).Cells(2).Value = result("Customer_FirstName")
                dgcusDetail.Rows(0).Cells(3).Value = result("Customer_LastName")
                dgcusDetail.Rows(0).Cells(4).Value = result("Customer_Address")
                dgcusDetail.Rows(0).Cells(5).Value = result("Insurance_Start_Date")
                dgcusDetail.Rows(0).Cells(6).Value = result("Insurance_End_Date")
                dgcusDetail.Rows(0).Cells(7).Value = result("Customer_MobileNumber")
            Catch ex As Exception
                flag = False
                MessageBox.Show("Customer id not valid", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            If flag Then
                Try
                    query = "select * from insurance where Insurance_ID=" & dgcusDetail.Rows(0).Cells(1).Value & ""
                    result = connect.ExecuteQuery(query)
                    result.Read()

                    dgInsDetail.Rows(0).Cells(0).Value = result("Insurance_ID")
                    dgInsDetail.Rows(0).Cells(1).Value = result("Insurance_Company_Name")
                    dgInsDetail.Rows(0).Cells(2).Value = result("InsurancePlan")
                    dgInsDetail.Rows(0).Cells(3).Value = result("Address")
                    dgInsDetail.Rows(0).Cells(4).Value = result("ContactNumber")
                Catch ex As Exception
                    MessageBox.Show("Insurance Details could not be found", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

                Try
                    query = "select * from prescription where Customer_ID=" & txtCusId.Text.ToString & " order by Prescription_ID asc"
                    result = connect.ExecuteQuery(query)
                    While result.Read()
                        txtPrecId.Text = result("Prescription_ID")
                        totalRefil = Integer.Parse(result("Total_Refill_Allowed"))
                    End While

                    query = "select Prescription_Detai_ID from prescription_detail where Prescription_ID=" & txtPrecId.Text.ToString & ""
                    result = connect.ExecuteQuery(query)
                    result.Read()
                    Dim preDetId As String = result("Prescription_Detai_ID")

                    query = "select * from prescription_medicine where Prescription_Detail_ID=" & preDetId & ""
                    result = connect.ExecuteQuery(query)
                    Dim i As Integer = 0

                    While result.Read
                        dgMedDetail.Rows.Add("", "", "", "", "", "", "", "")

                        query = "select * from medicine_inventory where Medicine_Inventory_ID=" & result("Medician_Inventory_ID") & ""
                        Dim output As Odbc.OdbcDataReader = connect.ExecuteQuery(query)
                        output.Read()
                        dgMedDetail.Rows(i).Cells(0).Value = output("Medicine_Inventory_ID")
                        dgMedDetail.Rows(i).Cells(1).Value = output("Medicine_Name")
                        dgMedDetail.Rows(i).Cells(2).Value = result("QuantityPerUnit")
                        dgMedDetail.Rows(i).Cells(3).Value = output("Tier")
                        dgMedDetail.Rows(i).Cells(4).Value = output("UnitPrice")
                        dgMedDetail.Rows(i).Cells(5).Value = result("CostMedicine")
                        dgMedDetail.Rows(i).Cells(6).Value = result("ClaimMedicine")
                        dgMedDetail.Rows(i).Cells(7).Value = Double.Parse(dgMedDetail.Rows(i).Cells(5).Value) - Double.Parse(dgMedDetail.Rows(i).Cells(6).Value)

                        i = i + 1
                    End While
                Catch ex As Exception
                    MessageBox.Show("Prescription could not be found", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
            connect.DisConnect()
        End If
    End Sub

    Private Sub btnSearchPrescrip_Click(sender As Object, e As EventArgs) Handles btnSearchPrescrip.Click

        txtCusId.ReadOnly = True
        txtPrecId.ReadOnly = True

        Dim flag As Boolean = True

        dgMedDetail.Rows.Clear()

        Dim connect As New ConnectToDB
        Dim query As String
        Dim result As Odbc.OdbcDataReader

        If String.IsNullOrWhiteSpace(txtPrecId.Text.ToString) Then
            flag = False
            MessageBox.Show("Enter the Prescription id on right hand side of the form", "Required Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                Integer.Parse(txtPrecId.Text.ToString)
            Catch ex As Exception
                flag = False
                MessageBox.Show("prescription Id should contain digits", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        If flag Then
            connect.Connect()
            Dim count As Integer = 0

            query = "select * from prescription where Prescription_ID=" & txtPrecId.Text.ToString & " order by Prescription_ID asc"
            result = connect.ExecuteQuery(query)
            While result.Read()
                txtCusId.Text = result("Customer_ID")
                totalRefil = Double.Parse(result("Total_Refill_Allowed"))
                count = count + 1
            End While

            If count > 0 Then

                query = "select * from customer where Customer_ID=" & txtCusId.Text.ToString & ""
                result = connect.ExecuteQuery(query)
                result.Read()
                dgcusDetail.Rows(0).Cells(0).Value = result("Customer_ID")
                dgcusDetail.Rows(0).Cells(1).Value = result("Insurance_ID")
                dgcusDetail.Rows(0).Cells(2).Value = result("Customer_FirstName")
                dgcusDetail.Rows(0).Cells(3).Value = result("Customer_LastName")
                dgcusDetail.Rows(0).Cells(4).Value = result("Customer_Address")
                dgcusDetail.Rows(0).Cells(5).Value = result("Insurance_Start_Date")
                dgcusDetail.Rows(0).Cells(6).Value = result("Insurance_End_Date")
                dgcusDetail.Rows(0).Cells(7).Value = result("Customer_MobileNumber")

                query = "select * from insurance where Insurance_ID=" & dgcusDetail.Rows(0).Cells(1).Value & ""
                result = connect.ExecuteQuery(query)
                result.Read()

                dgInsDetail.Rows(0).Cells(0).Value = result("Insurance_ID")
                dgInsDetail.Rows(0).Cells(1).Value = result("Insurance_Company_Name")
                dgInsDetail.Rows(0).Cells(2).Value = result("InsurancePlan")
                dgInsDetail.Rows(0).Cells(3).Value = result("Address")
                dgInsDetail.Rows(0).Cells(4).Value = result("ContactNumber")

                query = "select Prescription_Detai_ID from prescription_detail where Prescription_ID=" & txtPrecId.Text.ToString & ""
                result = connect.ExecuteQuery(query)
                result.Read()
                Dim preDetId As String = result("Prescription_Detai_ID")

                query = "select * from prescription_medicine where Prescription_Detail_ID=" & preDetId & ""
                result = connect.ExecuteQuery(query)
                Dim i As Integer = 0

                While result.Read
                    dgMedDetail.Rows.Add("", "", "", "", "", "", "", "")

                    query = "select * from medicine_inventory where Medicine_Inventory_ID=" & result("Medician_Inventory_ID") & ""
                    Dim output As Odbc.OdbcDataReader = connect.ExecuteQuery(query)
                    output.Read()
                    dgMedDetail.Rows(i).Cells(0).Value = output("Medicine_Inventory_ID")
                    dgMedDetail.Rows(i).Cells(1).Value = output("Medicine_Name")
                    dgMedDetail.Rows(i).Cells(2).Value = result("QuantityPerUnit")
                    dgMedDetail.Rows(i).Cells(3).Value = output("Tier")
                    dgMedDetail.Rows(i).Cells(4).Value = output("UnitPrice")
                    dgMedDetail.Rows(i).Cells(5).Value = result("CostMedicine")
                    dgMedDetail.Rows(i).Cells(6).Value = result("ClaimMedicine")
                    dgMedDetail.Rows(i).Cells(7).Value = Double.Parse(dgMedDetail.Rows(i).Cells(5).Value) - Double.Parse(dgMedDetail.Rows(i).Cells(6).Value)

                    i = i + 1
                End While
            Else
                MessageBox.Show("Precription id not valid", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub

    Private Sub btnRefil_Click(sender As Object, e As EventArgs) Handles btnRefil.Click

        Dim connect As New ConnectToDB
        Dim query As String
        Dim result As Odbc.OdbcDataReader

        Dim flag As Boolean = True

        If String.IsNullOrWhiteSpace(txtCusId.Text.ToString) = False Then
            If String.IsNullOrWhiteSpace(txtPrecId.Text.ToString) Then
                flag = False
            End If
        Else
            flag = False
        End If

        If flag Then
            connect.Connect()
            query = "select count(*) as count from prescription_detail where Prescription_ID=" & txtPrecId.Text.ToString & ";"
            result = connect.ExecuteQuery(query)
            result.Read()
            Dim refil As Integer = Integer.Parse(result("count"))

            If refil < totalRefil Then

                Billing.txtPrecId.Text = txtPrecId.Text.ToString
                Billing.txtPrecDate.Text = Date.Now.ToString("yyyy-MM-dd")
                Billing.txtCusId.Text = txtCusId.Text.ToString
                Billing.txtCusFN.Text = dgcusDetail.Rows(0).Cells(2).Value
                Billing.txtCusLN.Text = dgcusDetail.Rows(0).Cells(3).Value
                Billing.txtCusAdd.Text = dgcusDetail.Rows(0).Cells(4).Value
                Billing.txtCusMN.Text = dgcusDetail.Rows(0).Cells(7).Value
                Billing.txtInsName.Text = dgInsDetail.Rows(0).Cells(1).Value
                Billing.txtInsPlan.Text = dgInsDetail.Rows(0).Cells(2).Value
                Billing.txtRefil.Text = refil.ToString

                Dim cstTotal As Double = 0.0
                Dim cTotal As Double = 0.0
                Dim due As Double = 0.0
                Dim j As Integer = 0

                For i As Integer = 0 To dgMedDetail.Rows.Count - 2
                    query = "select UnitsInStock from medicine_inventory where Medicine_Name='" & dgMedDetail.Rows(i).Cells(1).Value & "'"
                    result = connect.ExecuteQuery(query)
                    result.Read()
                    Dim up As Integer = Integer.Parse(result("UnitsInStock"))
                    Dim temp As Integer = up - Integer.Parse(dgMedDetail.Rows(i).Cells(2).Value)

                    If temp < 0 Then
                        j = j - 1
                        MessageBox.Show("Medicine [" & dgMedDetail.Rows(i).Cells(1).Value & "] is out of stock. " & up & " tablets available", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        Billing.gdView1.Rows.Add("", "", "", "", "")
                        Billing.gdView1.Rows(j).Cells(0).Value = dgMedDetail.Rows(i).Cells(1).Value
                        Billing.gdView1.Rows(j).Cells(1).Value = dgMedDetail.Rows(i).Cells(2).Value
                        Billing.gdView1.Rows(j).Cells(2).Value = dgMedDetail.Rows(i).Cells(4).Value
                        Billing.gdView1.Rows(j).Cells(3).Value = dgMedDetail.Rows(i).Cells(5).Value
                        cstTotal = cstTotal + Double.Parse(dgMedDetail.Rows(i).Cells(5).Value)
                        Billing.gdView1.Rows(j).Cells(4).Value = dgMedDetail.Rows(i).Cells(3).Value
                        Billing.gdView1.Rows(j).Cells(5).Value = dgMedDetail.Rows(i).Cells(6).Value
                        cTotal = cTotal + Double.Parse(dgMedDetail.Rows(i).Cells(6).Value)
                    End If
                    j = j + 1
                Next i

                Billing.txtTotal.Text = cstTotal.ToString

                Dim endDate As Date = Date.Parse(dgcusDetail.Rows(0).Cells(6).Value.ToString)
                Dim dat As Long = DateDiff(DateInterval.Day, Date.Now, endDate)

                If dat < 0 Then
                    MessageBox.Show("Inurance is expired", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cTotal = 0.0
                End If

                due = cstTotal - cTotal
                Billing.txtCTotal.Text = cTotal
                Billing.txtDue.Text = due

                If j = 0 Then
                    MessageBox.Show("Medicine out of stock. Can't proceed to billing", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    Billing.Show()
                End If
            Else
                MessageBox.Show("Out of refils. Please register new prescription", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Enter the Cutomer id or prescription id", "Required Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        dgcusDetail.Rows.Clear()
        dgInsDetail.Rows.Clear()
        dgMedDetail.Rows.Clear()
        txtCusId.Clear()
        txtPrecId.Clear()
        txtCusId.ReadOnly = False
        txtPrecId.ReadOnly = False

    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        Sales_Report.Show()
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        Inventory_Report.Show()
    End Sub

    Private Sub btnVendor_Click(sender As Object, e As EventArgs) Handles btnVendor.Click
        Vendor.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnNewIns.Click
        Insurance_Information.Show()
    End Sub

    Private Sub btnNewMed_Click(sender As Object, e As EventArgs) Handles btnNewMed.Click
        New_Medicine.Show()
    End Sub

    Private Sub Home_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show(lblWelName.Text.ToString & vbNewLine & "Have a nice day")
    End Sub
End Class