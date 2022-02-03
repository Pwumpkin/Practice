Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dblMyWallet As Double = 100.5 * Math.PI
        MessageBox.Show(dblMyWallet.ToString)
        Dim formatted As String = String.Format("{0:n9}", dblMyWallet)
        MessageBox.Show(formatted)
    End Sub
End Class
