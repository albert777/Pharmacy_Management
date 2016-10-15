Public Class New_Medicine

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtName.Clear()
        txtInStock.Clear()
        txtPrice.Clear()
        txtReorder.Clear()
        cbTier.Text = ""

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim connect As New ConnectToDB
        Dim errorMsg As String = ""
        Dim value As Integer
        Dim query As String
        Dim flag As Boolean = True

        If String.IsNullOrWhiteSpace(txtName.Text.ToString) Then
            flag = False
            errorMsg = "Enter Medicine name" & vbNewLine & errorMsg
        End If

        If String.IsNullOrWhiteSpace(txtInStock.Text.ToString) Then
            flag = False
            errorMsg = "Enter how many medicine in Stock" & vbNewLine & errorMsg
        Else
            Try
                Double.Parse(txtInStock.Text.ToString)
            Catch ex As Exception
                flag = False
                MessageBox.Show("In Stock value should contain digits", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If

        If String.IsNullOrWhiteSpace(txtPrice.Text.ToString) Then
            flag = False
            errorMsg = "Enter the Price of the medicine" & vbNewLine & errorMsg
        Else
            Try
                Double.Parse(txtPrice.Text.ToString)
            Catch ex As Exception
                flag = False
                MessageBox.Show("Price of the medicine should contain digits", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If

        If String.IsNullOrWhiteSpace(txtReorder.Text.ToString) Then
            flag = False
            errorMsg = "Enter the Reorder Level of the medicine" & vbNewLine & errorMsg
        Else
            Try
                Double.Parse(txtReorder.Text.ToString)
            Catch ex As Exception
                flag = False
                MessageBox.Show("Reorder level should contain digits", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If

        If String.IsNullOrWhiteSpace(cbTier.Text.ToString) Then
            flag = False
            errorMsg = "Select the Tier type" & vbNewLine & errorMsg
        End If

        If flag Then
            connect.Connect()

            query = "insert into medicine_inventory values (" & txtId.Text.ToString & ",'" & txtName.Text.ToString & "'," & txtPrice.Text.ToString & ",'" & cbTier.Text.ToString & "'," & txtInStock.Text.ToString & "," & txtReorder.Text.ToString & ")"
            value = connect.ExecuteQuery(query)

            If value <> 1 Then
                MessageBox.Show("Issue while inserting values to DB", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            connect.DisConnect()
            Me.Controls.Clear()
            InitializeComponent()
            New_Medicine_Load(e, e)

        Else
            If String.IsNullOrWhiteSpace(errorMsg) = False Then
                MessageBox.Show(errorMsg, " Required Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If

    End Sub

    Private Sub New_Medicine_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim connect As New ConnectToDB
        Dim query As String
        Dim result As Odbc.OdbcDataReader

        connect.Connect()
        query = "select Medicine_Inventory_ID from medicine_inventory order by Medicine_Inventory_ID desc limit 1"
        result = connect.ExecuteQuery(query)
        result.Read()
        txtId.Text = Integer.Parse(result("Medicine_Inventory_ID")) + 1
        connect.DisConnect()

    End Sub
End Class