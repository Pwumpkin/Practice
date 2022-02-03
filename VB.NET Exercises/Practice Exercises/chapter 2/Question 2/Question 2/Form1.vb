Public Class Form1
    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        Dim input As String = txtString.Text
        MessageBox.Show(CType(input.Length, String))
        MessageBox.Show(input.Substring(0, CType(input.Length / 2, Integer)))
        MessageBox.Show(input.Substring(CType(input.Length / 2, Integer)))
    End Sub
End Class
