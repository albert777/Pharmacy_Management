Public Class Inventory_Report

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        Me.PrintForm1.PrinterSettings.DefaultPageSettings.Landscape = True
        PrintForm1.Print()
        Me.Close()
    End Sub

    Private Sub Inventory_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim connect As New ConnectToDB
        Dim query As String
        Dim result As Odbc.OdbcDataReader

        connect.Connect()
        query = "select * from medicine_inventory"
        result = connect.ExecuteQuery(query)
        Dim count As Integer = 0

        While result.Read

            dgView.Rows.Add("", "", "", "", "", "", "", "")
            dgView.Rows(count).Cells(0).Value = result("Medicine_Inventory_ID")
            dgView.Rows(count).Cells(1).Value = result("Medicine_Name")
            dgView.Rows(count).Cells(2).Value = result("UnitPrice")
            dgView.Rows(count).Cells(3).Value = result("Tier")
            dgView.Rows(count).Cells(4).Value = result("UnitsInStock")
            dgView.Rows(count).Cells(5).Value = result("UnitsOnStock")
            dgView.Rows(count).Cells(6).Value = result("ReorderLevel")

            count = count + 1
        End While
        connect.DisConnect()
    End Sub
End Class