Public Class Vendor

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Me.PrintForm1.PrinterSettings.DefaultPageSettings.Landscape = True
        PrintForm1.Print()
        Me.Close()
    End Sub

    Private Sub Vendor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim connect As New ConnectToDB
        Dim query As String
        Dim result As Odbc.OdbcDataReader

        connect.Connect()
        query = "select v.Vendor_ID,v.Vendor_CompanyName,v.Vendor_ContactName,v.Vendor_PhoneNumber,mi.Medicine_Name,vm.Vendor_PricePerUnit,vm.Required_Shipping_Days from vendor v join vendor_medicine_quotation vm on v.Vendor_ID=vm.Vendor_ID join medicine_inventory mi on vm.Medicine_Inventory_ID=mi.Medicine_Inventory_ID"
        result = connect.ExecuteQuery(query)
        Dim count As Integer = 0

        While result.Read

            dgView1.Rows.Add("", "", "", "", "", "", "")
            dgView1.Rows(count).Cells(0).Value = result("Vendor_ID")
            dgView1.Rows(count).Cells(1).Value = result("Vendor_CompanyName")
            dgView1.Rows(count).Cells(2).Value = result("Vendor_ContactName")
            dgView1.Rows(count).Cells(3).Value = result("Vendor_PhoneNumber")
            dgView1.Rows(count).Cells(4).Value = result("Medicine_Name")
            dgView1.Rows(count).Cells(5).Value = result("Vendor_PricePerUnit")
            dgView1.Rows(count).Cells(6).Value = result("Required_Shipping_Days")

            count = count + 1
        End While
        connect.DisConnect()
    End Sub
End Class