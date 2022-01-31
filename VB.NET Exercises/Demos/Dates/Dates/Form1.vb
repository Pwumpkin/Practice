Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dteResults As Date
        dteResults = Now
        MessageBox.Show(dteResults)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dteResults As Date
        dteResults = Now
        MessageBox.Show(dteResults.ToShortDateString)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim dteResults As Date
        dteResults = Now
        MessageBox.Show(dteResults.ToLongDateString)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim dteResults As Date
        dteResults = Now
        MessageBox.Show(dteResults.ToShortTimeString)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim dteResults As Date
        dteResults = Now
        MessageBox.Show(dteResults.ToLongTimeString)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim dteResults As Date
        MessageBox.Show(dteResults.ToString("dddd"))
        MessageBox.Show(dteResults.ToString("MMMM"))
        MessageBox.Show(dteResults.ToString("dd"))
        MessageBox.Show(dteResults.ToString("mmmm"))
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim dteResults As Date
        dteResults = #1/10/2015 9:00:00 AM#
        MessageBox.Show(dteResults)
        MessageBox.Show(dteResults.ToShortDateString)
        MessageBox.Show(dteResults.ToLongDateString)
        MessageBox.Show(dteResults.Month)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim dteResults As Date = Now
        MessageBox.Show(dteResults.ToLongDateString & dteResults.ToLongTimeString)

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim dteResults As Date = Now
        dteResults = dteResults.AddDays(22)
        dteResults = dteResults.AddYears(-2)
        dteResults = dteResults.AddHours(2)
        MessageBox.Show(dteResults.ToLongDateString)
    End Sub
End Class
