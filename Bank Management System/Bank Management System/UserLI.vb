Public Class UserLI
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        UserMP.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) 
        Home.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "123" And TextBox2.Text = "169" Then
            UserMP.Show()
        ElseIf TextBox1.Text = "435" And TextBox2.Text = "169" Then
            UserMP.Show()
        ElseIf TextBox1.Text = "786" And TextBox2.Text = "169" Then
            UserMP.Show()
        ElseIf TextBox1.Text = "527" And TextBox2.Text = "169" Then
            UserMP.Show()
        ElseIf TextBox1.Text = "972" And TextBox2.Text = "169" Then
            UserMP.Show()
        Else
            MsgBox("Invalid User Id or Password", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub UserLI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class