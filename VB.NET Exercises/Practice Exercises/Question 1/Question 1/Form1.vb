Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intFirst As Integer = 12
        Dim intSecond As Integer = 36
        MessageBox.Show("First(" & intFirst.ToString & ")" & " + second(" & intSecond.ToString & ") is  = " & intFirst + intSecond)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim strFirst As String = "Hello "
        Dim strSecond As String = "World"
        Dim strThird As String = Now.ToLongDateString & " " & Now.ToLongTimeString
        MessageBox.Show(strFirst & strSecond & ", today is " & strThird)
    End Sub
End Class
