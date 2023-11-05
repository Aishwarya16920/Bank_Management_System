Imports MySql.Data.MySqlClient
Public Class GetInfo
    Dim conn As New MySqlConnection
    Private Sub GetInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost;user id=root;password=root;persistsecurityinfo=True;database=bank;allowuservariables=True"
        'TODO: This line of code loads data into the 'BankDataSet.user' table. You can move, or remove it, as needed.
        Me.UserTableAdapter1.Fill(Me.BankDataSet.user)
        Dim temp As String
        temp = CashierMP.TextBox1.Text
        UserBindingSource5.Filter = "convert(AccountNumber,'System.String')like '" + temp + "'"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim number1, number2 As Integer
        If TextBox1.Text IsNot "" And TextBox2.Text IsNot "" Then
            number1 = Convert.ToInt32(Label7.Text)
            number2 = Convert.ToInt32(TextBox2.Text)
            If (number2 <= 0) Then
                MsgBox("Enter a valid Amount", MsgBoxStyle.Critical)
            ElseIf (number2 <= number1) Then
                Label7.Text = number1 - number2
                Dim Str As String = "UPDATE user SET BankBalance='" + Label7.Text + "' WHERE AccountNumber='" + Label8.Text + "'"
                conn.Open()
                Dim mysc As New MySqlCommand(Str, conn)
                mysc.ExecuteNonQuery()
                MsgBox("Withdraw Successful", MsgBoxStyle.Information)
                conn.Close()
            Else
                MsgBox("Withdraw Amount Exceeded", MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("Please enter the details", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub UserBindingSource5_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text IsNot "" And TextBox2.Text IsNot "" Then
            If (TextBox2.Text <= 0) Then
                MsgBox("Enter a valid Amount", MsgBoxStyle.Critical)
            Else
                Dim number1, number2 As Integer
                number1 = Convert.ToInt32(Label7.Text)
                number2 = Convert.ToInt32(TextBox2.Text)
                Label7.Text = number1 + number2
                Dim Str As String = "UPDATE user SET BankBalance='" + Label7.Text + "' WHERE AccountNumber='" + Label8.Text + "'"
                conn.Open()
                Dim mysc As New MySqlCommand(Str, conn)
                mysc.ExecuteNonQuery()
                MsgBox("Deposit Successful", MsgBoxStyle.Information)
                conn.Close()
            End If
        Else
            MsgBox("Please enter the details", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class