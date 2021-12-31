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
        Me.btnSay = New System.Windows.Forms.Button()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnSay
        '
        Me.btnSay.Location = New System.Drawing.Point(15, 56)
        Me.btnSay.Name = "btnSay"
        Me.btnSay.Size = New System.Drawing.Size(75, 23)
        Me.btnSay.TabIndex = 0
        Me.btnSay.Text = "Talk"
        Me.btnSay.UseVisualStyleBackColor = True
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Location = New System.Drawing.Point(12, 9)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(195, 16)
        Me.lblPrompt.TabIndex = 1
        Me.lblPrompt.Text = "Say someting to Poly the parrot!"
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(15, 28)
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(100, 22)
        Me.txtMessage.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(291, 136)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.btnSay)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSay As Button
    Friend WithEvents lblPrompt As Label
    Friend WithEvents txtMessage As TextBox
End Class
