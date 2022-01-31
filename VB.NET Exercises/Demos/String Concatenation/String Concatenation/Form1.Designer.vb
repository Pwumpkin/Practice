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
        Me.lblString = New System.Windows.Forms.Label()
        Me.btnSplit = New System.Windows.Forms.Button()
        Me.btnLength = New System.Windows.Forms.Button()
        Me.numSplitIndex = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.numSplitIndex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtString
        '
        Me.txtString.Location = New System.Drawing.Point(19, 46)
        Me.txtString.Name = "txtString"
        Me.txtString.Size = New System.Drawing.Size(215, 22)
        Me.txtString.TabIndex = 1
        '
        'lblString
        '
        Me.lblString.AutoSize = True
        Me.lblString.Location = New System.Drawing.Point(16, 26)
        Me.lblString.Name = "lblString"
        Me.lblString.Size = New System.Drawing.Size(100, 17)
        Me.lblString.TabIndex = 2
        Me.lblString.Text = "Split this string"
        '
        'btnSplit
        '
        Me.btnSplit.Location = New System.Drawing.Point(19, 85)
        Me.btnSplit.Name = "btnSplit"
        Me.btnSplit.Size = New System.Drawing.Size(215, 35)
        Me.btnSplit.TabIndex = 4
        Me.btnSplit.Text = "&Split"
        Me.btnSplit.UseVisualStyleBackColor = True
        '
        'btnLength
        '
        Me.btnLength.Location = New System.Drawing.Point(240, 85)
        Me.btnLength.Name = "btnLength"
        Me.btnLength.Size = New System.Drawing.Size(113, 35)
        Me.btnLength.TabIndex = 6
        Me.btnLength.Text = "Length"
        Me.btnLength.UseVisualStyleBackColor = True
        '
        'numSplitIndex
        '
        Me.numSplitIndex.Location = New System.Drawing.Point(240, 46)
        Me.numSplitIndex.Name = "numSplitIndex"
        Me.numSplitIndex.Size = New System.Drawing.Size(120, 22)
        Me.numSplitIndex.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(237, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Index(to split at)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 213)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.numSplitIndex)
        Me.Controls.Add(Me.btnLength)
        Me.Controls.Add(Me.btnSplit)
        Me.Controls.Add(Me.lblString)
        Me.Controls.Add(Me.txtString)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.numSplitIndex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtString As TextBox
    Friend WithEvents lblString As Label
    Friend WithEvents btnSplit As Button
    Friend WithEvents btnLength As Button
    Friend WithEvents numSplitIndex As NumericUpDown
    Friend WithEvents Label1 As Label
End Class
