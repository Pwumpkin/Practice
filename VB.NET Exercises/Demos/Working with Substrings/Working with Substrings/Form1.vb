Public Class Form1
    Private Sub btnSubstring_Click(sender As Object, e As EventArgs) Handles btnSubstring.Click
        Dim intSubstringLength As Integer = 3
        MessageBox.Show(txtString.Text.Substring(intSubstringLength * 0, intSubstringLength))
        MessageBox.Show(txtString.Text.Substring(intSubstringLength * 1, intSubstringLength))

        MessageBox.Show(txtString.Text.Substring(2 * intSubstringLength))
    End Sub

    Private Sub btnLength_Click(sender As Object, e As EventArgs) Handles btnLength.Click
        MessageBox.Show(txtString.Text.Length)
    End Sub
End Class
