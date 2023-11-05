Public Class CashierMP
    Private Sub CashierMP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BankDataSet.cashier' table. You can move, or remove it, as needed.
        Me.CashierTableAdapter1.Fill(Me.BankDataSet.cashier)
        Dim temp As String
        temp = CashierLI.TextBox1.Text
        CashierBindingSource1.Filter = "convert(CashierID,'System.String')like '" + temp + "'"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "123" Then
            GetInfo.Show()
        ElseIf TextBox1.Text = "435" Then
            GetInfo.Show()
        ElseIf TextBox1.Text = "786" Then
            GetInfo.Show()
        ElseIf TextBox1.Text = "527" Then
            GetInfo.Show()
        ElseIf TextBox1.Text = "972" Then
            GetInfo.Show()
        Else
            MsgBox("Invalid Account Number", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class