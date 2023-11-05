Public Class CashierLI
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "201" And TextBox2.Text = "169" Then
            CashierMP.Show()
        ElseIf TextBox1.Text = "202" And TextBox2.Text = "169" Then
            CashierMP.Show()
        ElseIf TextBox1.Text = "203" And TextBox2.Text = "169" Then
            CashierMP.Show()
        ElseIf TextBox1.Text = "204" And TextBox2.Text = "169" Then
            CashierMP.Show()
        ElseIf TextBox1.Text = "205" And TextBox2.Text = "169" Then
            CashierMP.Show()
        Else
            MsgBox("Invalid Cashier Id or Password", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub CashierLI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class