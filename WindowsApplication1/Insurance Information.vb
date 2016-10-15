Public Class Insurance_Information

    Private Sub Insurance_Information_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim connect As New ConnectToDB
        Dim query As String = "select count(*) as count from insurance"

        connect.Connect()
        Dim reult As Odbc.OdbcDataReader = connect.ExecuteQuery(query)
        reult.Read()
        txtInsuranceID.Text = Integer.Parse(reult("count")) + 1
        txtInsuranceID.ReadOnly = True

        txtCountry.Text = "USA"
        txtCountry.ReadOnly = True

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtAddress.Clear()
        txtCity.Clear()
        txtComName.Clear()
        txtContactNo.Clear()
        txtEmail.Clear()
        txtInsurancePlan.Clear()
        txtState.Text = ""
        txtZipCode.Clear()

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        Dim connect As New ConnectToDB
        Dim flag As Boolean = True
        Dim errorMsg As String = ""

        If String.IsNullOrWhiteSpace(txtAddress.Text.ToString) Then
            flag = False
            errorMsg = "Enter Insurance company address" & vbNewLine & errorMsg
        End If

        If String.IsNullOrWhiteSpace(txtCity.Text.ToString) Then
            flag = False
            errorMsg = "Enter Insurance company city" & vbNewLine & errorMsg
        End If

        If String.IsNullOrWhiteSpace(txtComName.Text.ToString) Then
            flag = False
            errorMsg = "Enter Insurance company Name" & vbNewLine & errorMsg
        End If

        If String.IsNullOrWhiteSpace(txtContactNo.Text.ToString) Then
            flag = False
            errorMsg = "Enter Insurance company Contact number" & vbNewLine & errorMsg
        ElseIf txtContactNo.Text.Length <> 10 Then
            flag = False
            MessageBox.Show("Contact number should contain 10 digits", " Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                Double.Parse(txtContactNo.Text.ToString)
            Catch ex As Exception
                flag = False
                MessageBox.Show("Telephone number should contain numbers", " Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If

        If String.IsNullOrWhiteSpace(txtEmail.Text.ToString) Then
            flag = False
            errorMsg = "Enter Insurance company Email Id" & vbNewLine & errorMsg
        ElseIf txtEmail.Text.Contains("@") = False Then
            flag = False
            MessageBox.Show("Insurance company Email id is not valid", " Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtEmail.Text.Contains(".") = False Then
            flag = False
            MessageBox.Show("Insurance company Email id is not valid", " Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtEmail.Text.ToString.Length < 10 Then
            flag = False
            MessageBox.Show("Insurance company Email id is not valid", " Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        If String.IsNullOrWhiteSpace(txtInsurancePlan.Text.ToString) Then
            flag = False
            errorMsg = "Enter Insurance Plan" & vbNewLine & errorMsg
        End If

        If String.IsNullOrWhiteSpace(txtState.Text.ToString) Then
            flag = False
            errorMsg = "Enter Insurance company State" & vbNewLine & errorMsg
        End If

        If String.IsNullOrWhiteSpace(txtZipCode.Text.ToString) Then
            flag = False
            errorMsg = "Enter Insurance company Zipcode" & vbNewLine & errorMsg
        Else
            Try
                Integer.Parse(txtZipCode.Text.ToString)
            Catch ex As Exception
                flag = False
                MessageBox.Show("Zip code should contain numbers", " Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If

        If String.IsNullOrWhiteSpace(txtTier1.Text.ToString) Then
            flag = False
            errorMsg = "Enter Tier 1 value" & vbNewLine & errorMsg
        Else
            Try
                Integer.Parse(txtTier1.Text.ToString)
            Catch ex As Exception
                flag = False
                MessageBox.Show("Tier 1 should contain percentage value", " Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If

        If String.IsNullOrWhiteSpace(txtTier2.Text.ToString) Then
            flag = False
            errorMsg = "Enter Tier 2 value" & vbNewLine & errorMsg
        Else
            Try
                Integer.Parse(txtTier2.Text.ToString)
            Catch ex As Exception
                flag = False
                MessageBox.Show("Tier 2 should contain percentage value", " Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If

        If String.IsNullOrWhiteSpace(txtTier3.Text.ToString) Then
            flag = False
            errorMsg = "Enter Tier 3 Value" & vbNewLine & errorMsg
        Else
            Try
                Integer.Parse(txtTier3.Text.ToString)
            Catch ex As Exception
                flag = False
                MessageBox.Show("Tier 3 should contain percentage value", " Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If

        If flag Then
            connect.Connect()
            Dim query As String = "insert into insurance values (" & txtInsuranceID.Text.ToString & ",'" & txtComName.Text.ToString & "','" & txtInsurancePlan.Text.ToString & "','" & txtAddress.Text.ToString & "','" & txtCity.Text.ToString & "','" & txtState.Text.ToString & "','" & txtZipCode.Text.ToString & "','" & txtEmail.Text.ToString & "'," & txtContactNo.Text.ToString & ")"
            Dim value As Integer = connect.ExecuteQuery(query)
            Dim result As Odbc.OdbcDataReader

            If value <> 1 Then
                MessageBox.Show("Values not inserted in the DB", " Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            query = "select Insurance_Details_ID from insurance_details order by Insurance_Details_ID desc limit 1;"
            result = connect.ExecuteQuery(query)
            result.Read()

            Dim id As Integer = Integer.Parse(result("Insurance_Details_ID"))

            query = "insert into insurance_details values (" & id + 1 & "," & txtInsuranceID.Text & ",'1','" & txtTier1.Text.ToString & "')"
            value = connect.ExecuteQuery(query)

            If value <> 1 Then
                MessageBox.Show("Values not inserted in the DB", " Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            query = "insert into insurance_details values (" & id + 2 & "," & txtInsuranceID.Text & ",'2','" & txtTier2.Text.ToString & "')"
            value = connect.ExecuteQuery(query)

            If value <> 1 Then
                MessageBox.Show("Values not inserted in the DB", " Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            query = "insert into insurance_details values (" & id + 3 & "," & txtInsuranceID.Text & ",'3','" & txtTier3.Text.ToString & "')"
            value = connect.ExecuteQuery(query)

            If value <> 1 Then
                MessageBox.Show("Values not inserted in the DB", " Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            connect.DisConnect()

            Me.Close()
        Else
            If String.IsNullOrWhiteSpace(errorMsg) = False Then
                MessageBox.Show(errorMsg, " Required Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub lblContactNo_Click(sender As System.Object, e As System.EventArgs) Handles lblContactNo.Click

    End Sub

    Private Sub txtCountry_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCountry.TextChanged

    End Sub
End Class
