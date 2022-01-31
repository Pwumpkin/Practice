<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IntegerCalculations
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnTestMath = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnTestMath
        '
        Me.btnTestMath.Location = New System.Drawing.Point(82, 115)
        Me.btnTestMath.Name = "btnTestMath"
        Me.btnTestMath.Size = New System.Drawing.Size(157, 35)
        Me.btnTestMath.TabIndex = 0
        Me.btnTestMath.Text = "Math Operators Test"
        Me.btnTestMath.UseVisualStyleBackColor = True
        '
        'IntegerCalculations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 303)
        Me.Controls.Add(Me.btnTestMath)
        Me.Name = "IntegerCalculations"
        Me.Text = "Integer Math"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnTestMath As Button
End Class
