Imports MySql.Data.MySqlClient
Public Class Add
    Dim conn As New MySqlConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim Str As String = "INSERT INTO user VALUES ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')"
            conn.Open()
            Dim mysc As New MySqlCommand(Str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("Data successfully added", MsgBoxStyle.Information)
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost;user id=root;password=root;persistsecurityinfo=True;database=bank;allowuservariables=True"
        'TODO: This line of code loads data into the 'BankDataSet.user' table. You can move, or remove it, as needed.
        Me.UserTableAdapter1.Fill(Me.BankDataSet.user)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim Str As String = "DELETE FROM user where Name='" + TextBox1.Text + "'"
            conn.Open()
            Dim mysc As New MySqlCommand(Str, conn)
            mysc.ExecuteNonQuery()
            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                DataGridView1.Rows.Remove(row)
            Next
            MsgBox("Account Deleted", MsgBoxStyle.Information)
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("Changes Saved", MsgBoxStyle.Information)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = String.Empty
        TextBox2.Text = String.Empty
        TextBox3.Text = String.Empty
        TextBox4.Text = String.Empty

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class