<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnOperators = New System.Windows.Forms.Button()
        Me.btnOtherValues = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnOperators
        '
        Me.btnOperators.Location = New System.Drawing.Point(77, 12)
        Me.btnOperators.Name = "btnOperators"
        Me.btnOperators.Size = New System.Drawing.Size(164, 23)
        Me.btnOperators.TabIndex = 0
        Me.btnOperators.Text = "Common Operations"
        Me.btnOperators.UseVisualStyleBackColor = True
        '
        'btnOtherValues
        '
        Me.btnOtherValues.Location = New System.Drawing.Point(77, 41)
        Me.btnOtherValues.Name = "btnOtherValues"
        Me.btnOtherValues.Size = New System.Drawing.Size(164, 23)
        Me.btnOtherValues.TabIndex = 1
        Me.btnOtherValues.Text = "Other Values" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnOtherValues.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 91)
        Me.Controls.Add(Me.btnOtherValues)
        Me.Controls.Add(Me.btnOperators)
        Me.Name = "Form1"
        Me.Text = "Operating on Doubles"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnOperators As Button
    Friend WithEvents btnOtherValues As Button
End Class
