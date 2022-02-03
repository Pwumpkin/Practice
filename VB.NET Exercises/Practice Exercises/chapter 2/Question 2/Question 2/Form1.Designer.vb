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
        Me.txtString = New System.Windows.Forms.TextBox()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtString
        '
        Me.txtString.Location = New System.Drawing.Point(12, 12)
        Me.txtString.Name = "txtString"
        Me.txtString.Size = New System.Drawing.Size(293, 22)
        Me.txtString.TabIndex = 0
        '
        'btnInfo
        '
        Me.btnInfo.Location = New System.Drawing.Point(12, 40)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(293, 23)
        Me.btnInfo.TabIndex = 1
        Me.btnInfo.Text = "Get &Information"
        Me.btnInfo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 98)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.txtString)
        Me.Name = "Form1"
        Me.Text = "Get String Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtString As TextBox
    Friend WithEvents btnInfo As Button
End Class
