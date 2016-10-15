Public Class Billing

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim connect As New ConnectToDB
        Dim query As String
        Dim value As Integer

        connect.Connect()

        If String.IsNullOrWhiteSpace(New_Prescription.txtCustID.Text.ToString) = False Then
            query = "insert into prescription value (" & New_Prescription.txtPrescriptionID.Text.ToString & "," & New_Prescription.txtCustID.Text.ToString & "," & New_Prescription.cbTotalRefillAllowed.Text.ToString & ")"
            value = connect.ExecuteQuery(query)
            If value <> 1 Then
                MessageBox.Show("DB insertion failed", " Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

        query = "select Prescription_Detai_ID from prescription_detail order by Prescription_Detai_ID asc"
        Dim result As Odbc.OdbcDataReader = connect.ExecuteQuery(query)
        Dim temp As String = ""
        Dim precId As Integer
        While result.Read
            temp = result("Prescription_Detai_ID")
        End While

        precId = Integer.Parse(temp) + 1

        query = "select EmployeeID as id from employee where UserName='" & Login.txtUsrName.Text.ToString & "'"
        result = connect.ExecuteQuery(query)
        result.Read()
        Dim id As String = result("id")

        query = "insert into prescription_detail values (" & precId & "," & txtPrecId.Text.ToString & "," & id & ",'" & txtPrecDate.Text.ToString & "'," & txtTotal.Text.ToString & "," & txtCTotal.Text.ToString & "," & txtDue.Text.ToString & ",'Y')"
        value = connect.ExecuteQuery(query)
        If value <> 1 Then
            MessageBox.Show("DB insertion failed", " Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        query = "select Prescription_Medicine_ID from prescription_medicine order by Prescription_Medicine_ID asc"
        result = connect.ExecuteQuery(query)

        Dim count As Integer
        Dim temp1 As Integer = 0
        While result.Read
            count = Integer.Parse(result("Prescription_Medicine_ID"))
        End While
        count = count + 1

        For i As Integer = 0 To gdView1.Rows.Count - 2

            query = "select Medicine_Inventory_ID as id from medicine_inventory where Medicine_Name='" & gdView1.Rows(i).Cells(0).Value.ToString & "'"
            result = connect.ExecuteQuery(query)
            result.Read()
            Dim mId As String = result("id")

            query = "insert into prescription_medicine values (" & count + temp1 & "," & mId & "," & precId & "," & gdView1.Rows(i).Cells(1).Value & "," & gdView1.Rows(i).Cells(3).Value & "," & gdView1.Rows(i).Cells(5).Value & ")"
            value = connect.ExecuteQuery(query)
            If value <> 1 Then
                MessageBox.Show("DB insertion failed", " Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            query = "update medicine_inventory set UnitsInStock=UnitsInStock-" & gdView1.Rows(i).Cells(1).Value.ToString & " where Medicine_Name='" & gdView1.Rows(i).Cells(0).Value.ToString & "'"
            value = connect.ExecuteQuery(query)
            If value <> 1 Then
                MessageBox.Show("DB insertion failed", " Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            temp1 = temp1 + 1
        Next i

        connect.DisConnect()

        MessageBox.Show("Proceed to Print the bill", " Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        Me.PrintForm.PrinterSettings.DefaultPageSettings.Landscape = True
        PrintForm.Print()

        Home_Page.dgcusDetail.Rows.Clear()
        Home_Page.dgInsDetail.Rows.Clear()
        Home_Page.dgMedDetail.Rows.Clear()
        Home_Page.txtCusId.Clear()
        Home_Page.txtPrecId.Clear()
        Home_Page.txtCusId.ReadOnly = False
        Home_Page.txtPrecId.ReadOnly = False

        Me.Close()
        CustomerId.Close()
        New_Customer.Close()
        New_Prescription.Close()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Home_Page.dgcusDetail.Rows.Clear()
        Home_Page.dgInsDetail.Rows.Clear()
        Home_Page.dgMedDetail.Rows.Clear()
        Home_Page.txtCusId.Clear()
        Home_Page.txtPrecId.Clear()
        Home_Page.txtCusId.ReadOnly = False
        Home_Page.txtPrecId.ReadOnly = False

        Me.Close()
        CustomerId.Close()
        New_Customer.Close()
        New_Prescription.Close()

    End Sub

    
End Class