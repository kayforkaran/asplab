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
        Me.dice = New System.Windows.Forms.Label()
        Me.throwDice = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'dice
        '
        Me.dice.AutoSize = True
        Me.dice.Location = New System.Drawing.Point(358, 107)
        Me.dice.Name = "dice"
        Me.dice.Size = New System.Drawing.Size(51, 17)
        Me.dice.TabIndex = 0
        Me.dice.Text = "Label1"
        '
        'throwDice
        '
        Me.throwDice.Location = New System.Drawing.Point(347, 165)
        Me.throwDice.Name = "throwDice"
        Me.throwDice.Size = New System.Drawing.Size(75, 23)
        Me.throwDice.TabIndex = 1
        Me.throwDice.Text = "Throw"
        Me.throwDice.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.throwDice)
        Me.Controls.Add(Me.dice)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dice As Label
    Friend WithEvents throwDice As Button
End Class
