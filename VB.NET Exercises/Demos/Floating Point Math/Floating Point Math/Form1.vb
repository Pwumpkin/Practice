Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOperators.Click
        'Declare variable
        Dim dblNumber As Double

        'Set number, multiply numbers, and display results
        dblNumber = 45.34
        dblNumber *= 4.333
        MessageBox.Show("Multiplication test. " & dblNumber.ToString, "Floating Points")

        'Set Number, divide numbers, and display results
        dblNumber = 12
        dblNumber /= 7
        MessageBox.Show("Division test. " & dblNumber.ToString, "Floating Points")

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnOtherValues_Click(sender As Object, e As EventArgs) Handles btnOtherValues.Click
        MessageBox.Show(" 5 / 0 is " & CType(5 / 0, Double))
        MessageBox.Show(" 0 / 0 is " & CType(0 / 0, Double))
        MessageBox.Show("-5 / 0 is " & CType(-5 / 0, Double))
    End Sub
End Class
