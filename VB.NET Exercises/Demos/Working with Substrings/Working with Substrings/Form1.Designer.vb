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
        Me.btnSubstring = New System.Windows.Forms.Button()
        Me.txtString = New System.Windows.Forms.TextBox()
        Me.lblInput = New System.Windows.Forms.Label()
        Me.btnLength = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSubstring
        '
        Me.btnSubstring.Location = New System.Drawing.Point(15, 82)
        Me.btnSubstring.Name = "btnSubstring"
        Me.btnSubstring.Size = New System.Drawing.Size(204, 34)
        Me.btnSubstring.TabIndex = 0
        Me.btnSubstring.Text = "Substrings of length 3"
        Me.btnSubstring.UseVisualStyleBackColor = True
        '
        'txtString
        '
        Me.txtString.Location = New System.Drawing.Point(15, 54)
        Me.txtString.Name = "txtString"
        Me.txtString.Size = New System.Drawing.Size(309, 22)
        Me.txtString.TabIndex = 1
        '
        'lblInput
        '
        Me.lblInput.AutoSize = True
        Me.lblInput.Location = New System.Drawing.Point(12, 34)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(113, 17)
        Me.lblInput.TabIndex = 2
        Me.lblInput.Text = "Enter your string"
        '
        'btnLength
        '
        Me.btnLength.Location = New System.Drawing.Point(225, 82)
        Me.btnLength.Name = "btnLength"
        Me.btnLength.Size = New System.Drawing.Size(99, 34)
        Me.btnLength.TabIndex = 4
        Me.btnLength.Text = "Length"
        Me.btnLength.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 165)
        Me.Controls.Add(Me.btnLength)
        Me.Controls.Add(Me.lblInput)
        Me.Controls.Add(Me.txtString)
        Me.Controls.Add(Me.btnSubstring)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSubstring As Button
    Friend WithEvents txtString As TextBox
    Friend WithEvents lblInput As Label
    Friend WithEvents btnLength As Button
End Class
