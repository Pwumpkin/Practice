Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Create a variable called intNumber and store in it the value 27
        Dim intNumber As Integer = 17
        'Add 1 to the value of the variable called intNumber and store the new value in the same variable
        intNumber += 1
        'Display the value of the variable called intNumber to the user
        MessageBox.Show("The value of " + NameOf(intNumber) +
                        " is now " + intNumber.ToString + ".")
    End Sub
End Class
