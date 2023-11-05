Public Class ManagerLI
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "101" And TextBox2.Text = "169" Then
            ManagerMP.Show()
        ElseIf TextBox1.Text = "102" And TextBox2.Text = "169" Then
            ManagerMP.Show()
        ElseIf TextBox1.Text = "103" And TextBox2.Text = "169" Then
            ManagerMP.Show()
        ElseIf TextBox1.Text = "104" And TextBox2.Text = "169" Then
            ManagerMP.Show()
        ElseIf TextBox1.Text = "105" And TextBox2.Text = "169" Then
            ManagerMP.Show()
        Else
            MsgBox("Invalid Manager Id or Password", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub ManagerLI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class