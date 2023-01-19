Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim a, b, c As Integer
        Try
            a = Convert.ToInt32(TextBox1.Text)
            b = Convert.ToInt32(TextBox2.Text)
            c = a \ b
            Label1.Text = c
        Catch ex1 As DivideByZeroException
            Label1.Text = "try again"
        End Try
        Try
            Label1.Text c = a \ b

        Catch ex As Exception

        End Try
    End Sub
End Class
