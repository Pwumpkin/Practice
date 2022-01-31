Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnScope.Click
        DisplaySebastiansName()
    End Sub

    Private Sub DisplaySebastiansName()
        Dim strName As String = "Sebastian Blackwood"
        MessageBox.Show(strName)
    End Sub

    Private Sub DisplayBalthazarsName()
        Dim strName As String = "Balthazar Keech"
        MessageBox.Show(strName)
    End Sub
End Class
