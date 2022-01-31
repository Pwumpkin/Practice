Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dblArea As Double

        dblArea = CalculateAreaFromRadius(100)

        MessageBox.Show(dblArea)
    End Sub

    Private Function CalculateAreaFromRadius(ByVal radius As Double) As Double
        'Declare variables
        Dim dblResult As Double

        'Squre the radius
        dblResult = radius * radius

        'Multiply the radius by PI
        dblResult *= Math.PI

        Return dblResult
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dblArea As Double

        dblArea = CalculateAreaFromRadius(100)

        MessageBox.Show(dblArea)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim dblArea As Double

        dblArea = CalculateAreaFromRadius(100)

        MessageBox.Show(dblArea)
    End Sub
End Class
