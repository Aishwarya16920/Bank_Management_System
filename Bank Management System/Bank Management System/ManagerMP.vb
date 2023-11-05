Imports MySql.Data.MySqlClient
Public Class ManagerMP
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BankDataSet.manager' table. You can move, or remove it, as needed.
        Me.ManagerTableAdapter1.Fill(Me.BankDataSet.manager)
        Dim temp As String
        temp = ManagerLI.TextBox1.Text
        ManagerBindingSource5.Filter = "convert(ManagerID,'System.String')like '" + temp + "'"


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Add.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) 

    End Sub
End Class