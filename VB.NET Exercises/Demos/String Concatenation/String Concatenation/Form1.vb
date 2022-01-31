Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSplit.Click
        MessageBox.Show(txtString.Text.Substring(0, numSplitIndex.Value))
        MessageBox.Show(txtString.Text.Substring(numSplitIndex.Value))
    End Sub

    Private Sub btnLength_Click(sender As Object, e As EventArgs) Handles btnLength.Click
        MessageBox.Show("The length of the string is: " & CType(txtString.TextLength, String))
    End Sub
End Class
