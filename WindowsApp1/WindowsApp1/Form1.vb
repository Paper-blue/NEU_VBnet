Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = "wdnmd"
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        Me.Close()
    End Sub
End Class
