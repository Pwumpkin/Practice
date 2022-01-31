Public Class IntegerCalculations
    Private Sub btnTestMath_Click(sender As Object, e As EventArgs) Handles btnTestMath.Click
        'Declare variable
        Dim intNumber As Integer

        'Set number, add numbers, and display results
        intNumber = 16
        intNumber = intNumber + 8
        MessageBox.Show("Addition test. " & intNumber.ToString, "Integer Math")

        'Set number, subtract numbers, and display results
        intNumber = 24
        intNumber -= 2
        MessageBox.Show("Subtraction test. " & intNumber.ToString, "Integer Math")


        'Set number, multiply numbers, and display results
        intNumber = 6
        intNumber *= 10
        MessageBox.Show("Multiplication test. " & intNumber.ToString, "Integer Math")

        'Set number, divide numbers, and display results
        intNumber = 12
        intNumber = CType(intNumber / 6, Integer)
        MessageBox.Show("Division test. " & intNumber.ToString, "Integer Math")


    End Sub
End Class
