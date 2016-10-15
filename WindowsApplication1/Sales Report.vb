Public Class Sales_Report

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click

        Dim flag As Boolean = True
        Dim connect As New ConnectToDB
        Dim query As String
        Dim query2 As String
        Dim result As Odbc.OdbcDataReader

        dgView.Rows.Clear()

        If String.IsNullOrWhiteSpace(txtMonth.Text.ToString) = False Then
            Try
                Dim temp As Integer = Integer.Parse(txtMonth.Text.ToString)
                If temp > 12 Or temp < 1 Then
                    MessageBox.Show("Month should be 1 to 12", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                flag = False
                MessageBox.Show("Month should contain 1 or 2 digits", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If

        If String.IsNullOrWhiteSpace(txtYear.Text.ToString) Then
            flag = False
            MessageBox.Show("Enter Year to generate report", " Required Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf txtYear.Text.Length <> 4 Then
            flag = False
            MessageBox.Show("Year should be yyyy format", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                Integer.Parse(txtYear.Text.ToString)
            Catch ex As Exception
                flag = False
                MessageBox.Show("Year should contain 4 digits", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If

        If flag Then

            connect.Connect()
            If String.IsNullOrWhiteSpace(txtMonth.Text.ToString) = False Then
                query = "select p.Prescription_ID,pd.Prescription_Date,pd.Employee_ID,c.Customer_FirstName,c.Customer_LastName,c.Insurance_Start_Date,c.Insurance_End_Date,mi.Medicine_Name,pm.QuantityPerUnit,pm.CostMedicine as Totalcost,pm.ClaimMedicine as claimedamount,(pm.CostMedicine-pm.ClaimMedicine) as Totaldue from customer c join prescription p on c.Customer_ID=p.Customer_ID join prescription_detail pd on p.Prescription_ID=pd.Prescription_ID join prescription_medicine pm on pd.Prescription_Detai_ID=pm.Prescription_Detail_ID join medicine_inventory mi on pm.Medician_Inventory_ID=mi.Medicine_Inventory_ID where Month(pd.Prescription_Date) =" & txtMonth.Text.ToString & " and year(pd.Prescription_Date)=" & txtYear.Text.ToString & " order by p.Prescription_ID asc"
                query2 = "select Sum(pm.CostMedicine) as Sum from customer c join prescription p on c.Customer_ID=p.Customer_ID join prescription_detail pd on p.Prescription_ID=pd.Prescription_ID join prescription_medicine pm on pd.Prescription_Detai_ID=pm.Prescription_Detail_ID join medicine_inventory mi on pm.Medician_Inventory_ID=mi.Medicine_Inventory_ID where Month(pd.Prescription_Date) =" & txtMonth.Text.ToString & " and year(pd.Prescription_Date)=" & txtYear.Text.ToString & " order by p.Prescription_ID asc"
            Else
                query = "select p.Prescription_ID,pd.Prescription_Date,pd.Employee_ID,c.Customer_FirstName,c.Customer_LastName,c.Insurance_Start_Date,c.Insurance_End_Date,mi.Medicine_Name,pm.QuantityPerUnit,pm.CostMedicine as Totalcost,pm.ClaimMedicine as claimedamount,(pm.CostMedicine-pm.ClaimMedicine) as Totaldue from customer c join prescription p on c.Customer_ID=p.Customer_ID join prescription_detail pd on p.Prescription_ID=pd.Prescription_ID join prescription_medicine pm on pd.Prescription_Detai_ID=pm.Prescription_Detail_ID join medicine_inventory mi on pm.Medician_Inventory_ID=mi.Medicine_Inventory_ID where year(pd.Prescription_Date)=" & txtYear.Text.ToString & " order by p.Prescription_ID asc"
                query2 = "select Sum(pm.CostMedicine) as Sum from customer c join prescription p on c.Customer_ID=p.Customer_ID join prescription_detail pd on p.Prescription_ID=pd.Prescription_ID join prescription_medicine pm on pd.Prescription_Detai_ID=pm.Prescription_Detail_ID join medicine_inventory mi on pm.Medician_Inventory_ID=mi.Medicine_Inventory_ID where  year(pd.Prescription_Date)=" & txtYear.Text.ToString & " order by p.Prescription_ID asc"
            End If
            result = connect.ExecuteQuery(query)
            Dim count As Integer = 0

            While result.Read
                dgView.Rows.Add("", "", "", "", "", "", "", "", "", "", "", "")
                dgView.Rows(count).Cells(0).Value = result("Prescription_ID")
                dgView.Rows(count).Cells(1).Value = result("Prescription_Date")
                dgView.Rows(count).Cells(2).Value = result("Employee_ID")
                dgView.Rows(count).Cells(3).Value = result("Customer_FirstName")
                dgView.Rows(count).Cells(4).Value = result("Customer_LastName")
                dgView.Rows(count).Cells(5).Value = result("Insurance_Start_Date")
                dgView.Rows(count).Cells(6).Value = result("Insurance_End_Date")
                dgView.Rows(count).Cells(7).Value = result("Medicine_Name")
                dgView.Rows(count).Cells(8).Value = result("QuantityPerUnit")
                dgView.Rows(count).Cells(9).Value = result("TotalCost")
                dgView.Rows(count).Cells(10).Value = result("claimedamount")
                dgView.Rows(count).Cells(11).Value = result("TotalDue")
                count = count + 1
            End While


            If count = 0 Then
                MessageBox.Show("No data available for the given month and year", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            result = connect.ExecuteQuery(query2)
            result.Read()
            Try
                TxtSum.Text = result("Sum")
                TxtSum.ReadOnly = True

            Catch ex As Exception

            End Try
           

            connect.DisConnect()

        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        Dim flag As Boolean = True

        If String.IsNullOrWhiteSpace(dgView.Rows(0).Cells(0).Value) Then
            flag = False
            MessageBox.Show("Report is empty", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        If flag Then
            Me.PrintForm1.PrinterSettings.DefaultPageSettings.Landscape = True
            PrintForm1.Print()
            Me.Close()
        End If
        
    End Sub
End Class
