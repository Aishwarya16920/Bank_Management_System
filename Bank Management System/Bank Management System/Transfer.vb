Imports MySql.Data.MySqlClient
Public Class Transfer
    Dim conn As New MySqlConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim number1, number2 As Integer
        If (TextBox2.Text IsNot "") Then
            number1 = Convert.ToInt32(Label6.Text)
            number2 = Convert.ToInt32(TextBox2.Text)
            If TextBox1.Text = "123" And TextBox3.Text = "169" Then
                If (number2 <= 0) Then
                    MsgBox("Enter a valid Amount", MsgBoxStyle.Critical)
                ElseIf (number2 <= number1) Then
                    Label6.Text = number1 - number2
                    Dim Str1 As String = "UPDATE user SET BankBalance='" + Label6.Text + "' WHERE AccountNumber='" + Label8.Text + "'"
                    Dim Str2 As String = "UPDATE user SET BankBalance= BankBalance +'" + TextBox2.Text + "' WHERE AccountNumber='" + TextBox1.Text + "'"
                    conn.Open()
                    Dim mysc1 As New MySqlCommand(Str1, conn)
                    Dim mysc2 As New MySqlCommand(Str2, conn)
                    mysc1.ExecuteNonQuery()
                    mysc2.ExecuteNonQuery()
                    MsgBox("Transfer Successful", MsgBoxStyle.Information)
                    conn.Close()
                Else
                    MsgBox("Transfer Amount Exceeded", MsgBoxStyle.Critical)
                End If
            ElseIf TextBox1.Text = "435" And TextBox3.Text = "169" Then
                If (number2 <= 0) Then
                    MsgBox("Enter a valid Amount", MsgBoxStyle.Critical)
                ElseIf (number2 <= number1) Then
                    Label6.Text = number1 - number2
                    Dim Str1 As String = "UPDATE user SET BankBalance='" + Label6.Text + "' WHERE AccountNumber='" + Label8.Text + "'"
                    Dim Str2 As String = "UPDATE user SET BankBalance= BankBalance +'" + TextBox2.Text + "' WHERE AccountNumber='" + TextBox1.Text + "'"
                    conn.Open()
                    Dim mysc1 As New MySqlCommand(Str1, conn)
                    Dim mysc2 As New MySqlCommand(Str2, conn)
                    mysc1.ExecuteNonQuery()
                    mysc2.ExecuteNonQuery()
                    MsgBox("Transfer Successful", MsgBoxStyle.Information)
                    conn.Close()
                Else
                    MsgBox("Transfer Amount Exceeded", MsgBoxStyle.Critical)
                End If
            ElseIf TextBox1.Text = "786" And TextBox3.Text = "169" Then
                If (number2 <= 0) Then
                    MsgBox("Enter a valid Amount", MsgBoxStyle.Critical)
                ElseIf (number2 <= number1) Then
                    Label6.Text = number1 - number2
                    Dim Str1 As String = "UPDATE user SET BankBalance='" + Label6.Text + "' WHERE AccountNumber='" + Label8.Text + "'"
                    Dim Str2 As String = "UPDATE user SET BankBalance= BankBalance +'" + TextBox2.Text + "' WHERE AccountNumber='" + TextBox1.Text + "'"
                    conn.Open()
                    Dim mysc1 As New MySqlCommand(Str1, conn)
                    Dim mysc2 As New MySqlCommand(Str2, conn)
                    mysc1.ExecuteNonQuery()
                    mysc2.ExecuteNonQuery()
                    MsgBox("Transfer Successful", MsgBoxStyle.Information)
                    conn.Close()
                Else
                    MsgBox("Transfer Amount Exceeded", MsgBoxStyle.Critical)
                End If
            ElseIf TextBox1.Text = "527" And TextBox3.Text = "169" Then
                If (number2 <= 0) Then
                    MsgBox("Enter a valid Amount", MsgBoxStyle.Critical)
                ElseIf (number2 <= number1) Then
                    Label6.Text = number1 - number2
                    Dim Str1 As String = "UPDATE user SET BankBalance='" + Label6.Text + "' WHERE AccountNumber='" + Label8.Text + "'"
                    Dim Str2 As String = "UPDATE user SET BankBalance= BankBalance +'" + TextBox2.Text + "' WHERE AccountNumber='" + TextBox1.Text + "'"
                    conn.Open()
                    Dim mysc1 As New MySqlCommand(Str1, conn)
                    Dim mysc2 As New MySqlCommand(Str2, conn)
                    mysc1.ExecuteNonQuery()
                    mysc2.ExecuteNonQuery()
                    MsgBox("Transfer Successful", MsgBoxStyle.Information)
                    conn.Close()
                Else
                    MsgBox("Transfer Amount Exceeded", MsgBoxStyle.Critical)
                End If
            ElseIf TextBox1.Text = "972" And TextBox3.Text = "169" Then
                If (number2 <= 0) Then
                    MsgBox("Enter a valid Amount", MsgBoxStyle.Critical)
                ElseIf (number2 <= number1) Then
                    Label6.Text = number1 - number2
                    Dim Str1 As String = "UPDATE user SET BankBalance='" + Label6.Text + "' WHERE AccountNumber='" + Label8.Text + "'"
                    Dim Str2 As String = "UPDATE user SET BankBalance= BankBalance +'" + TextBox2.Text + "' WHERE AccountNumber='" + TextBox1.Text + "'"
                    conn.Open()
                    Dim mysc1 As New MySqlCommand(Str1, conn)
                    Dim mysc2 As New MySqlCommand(Str2, conn)
                    mysc1.ExecuteNonQuery()
                    mysc2.ExecuteNonQuery()
                    MsgBox("Transfer Successful", MsgBoxStyle.Information)
                    conn.Close()
                Else
                    MsgBox("Transfer Amount Exceeded", MsgBoxStyle.Critical)
                End If
            ElseIf TextBox1.Text = "" And TextBox2.Text = "" And TextBox3.Text = "" Then
                If (number2 <= 0) Then
                    MsgBox("Enter a valid Amount", MsgBoxStyle.Critical)
                ElseIf (number2 <= number1) Then
                    Label6.Text = number1 - number2
                    Dim Str1 As String = "UPDATE user SET BankBalance='" + Label6.Text + "' WHERE AccountNumber='" + Label8.Text + "'"
                    Dim Str2 As String = "UPDATE user SET BankBalance= BankBalance +'" + TextBox2.Text + "' WHERE AccountNumber='" + TextBox1.Text + "'"
                    conn.Open()
                    Dim mysc1 As New MySqlCommand(Str1, conn)
                    Dim mysc2 As New MySqlCommand(Str2, conn)
                    mysc1.ExecuteNonQuery()
                    mysc2.ExecuteNonQuery()
                    MsgBox("Transfer Successful", MsgBoxStyle.Information)
                    conn.Close()
                Else
                    MsgBox("Transfer Amount Exceeded", MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("Invalid User Account or Password", MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("Please enter the details", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Transfer1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost;user id=root;password=root;persistsecurityinfo=True;database=bank;allowuservariables=True"
        'TODO: This line of code loads data into the 'BankDataSet.user' table. You can move, or remove it, as needed.
        Me.UserTableAdapter.Fill(Me.BankDataSet.user)
        Dim temp1 As String
        temp1 = UserMP.Label6.Text
        UserBindingSource.Filter = "convert(AccountNumber,'System.String')like '" + temp1 + "'"

        Dim temp2 As String
        temp2 = UserMP.Label6.Text
        UserBindingSource.Filter = "convert(AccountNumber,'System.String')like '" + temp2 + "'"

    End Sub

    Private Sub AccNo_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Pass_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click_1(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class