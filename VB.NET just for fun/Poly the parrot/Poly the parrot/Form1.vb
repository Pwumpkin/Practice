Public Class Form1
    Private Sub btnSay_Click(sender As Object, e As EventArgs) Handles btnSay.Click
        MessageBox.Show("Poly says: '" & txtMessage.Text + "!'", "Poly's response")
    End Sub
End Class
