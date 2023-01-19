Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x, As Integer
        Dim i
        If x Then
            For i = 1 To Fix(Len(TextBox1.Text) / 2)
            If Mid(TextBox1.Text, i, 1) = Mid(TextBox1, (Len(TextBox1) - i) + 1, 1) Then
                If i = Fix(Len(TextBox1.Text) / 2) Then
                    Label1("true")
                End If
            Else
                Label1("false")
                Exit For
            End If
        Next


    End Sub
End Class
