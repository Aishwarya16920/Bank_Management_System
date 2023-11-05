Public Class UserMP
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BankDataSet.user' table. You can move, or remove it, as needed.
        Me.UserTableAdapter1.Fill(Me.BankDataSet.user)
        Dim temp As String
        temp = UserLI.TextBox1.Text
        UserBindingSource6.Filter = "convert(AccountNumber,'System.String')like '" + temp + "'"

    End Sub

    Private Sub TabPage4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Transfer.Show()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label4_Click_1(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class