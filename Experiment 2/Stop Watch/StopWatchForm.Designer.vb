<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StopWatchForm
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
        Me.components = New System.ComponentModel.Container()
        Me.stopWatch = New System.Windows.Forms.Label()
        Me.stopWatchTimer = New System.Windows.Forms.Timer(Me.components)
        Me.startPauseButton = New System.Windows.Forms.Button()
        Me.resetButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'stopWatch
        '
        Me.stopWatch.AutoSize = True
        Me.stopWatch.Location = New System.Drawing.Point(374, 184)
        Me.stopWatch.Name = "stopWatch"
        Me.stopWatch.Size = New System.Drawing.Size(51, 17)
        Me.stopWatch.TabIndex = 0
        Me.stopWatch.Text = "Label1"
        '
        'stopWatchTimer
        '
        '
        'startPauseButton
        '
        Me.startPauseButton.Location = New System.Drawing.Point(292, 256)
        Me.startPauseButton.Name = "startPauseButton"
        Me.startPauseButton.Size = New System.Drawing.Size(75, 23)
        Me.startPauseButton.TabIndex = 1
        Me.startPauseButton.Text = "Start"
        Me.startPauseButton.UseVisualStyleBackColor = True
        '
        'resetButton
        '
        Me.resetButton.Location = New System.Drawing.Point(436, 256)
        Me.resetButton.Name = "resetButton"
        Me.resetButton.Size = New System.Drawing.Size(75, 23)
        Me.resetButton.TabIndex = 2
        Me.resetButton.Text = "Reset"
        Me.resetButton.UseVisualStyleBackColor = True
        '
        'StopWatchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.resetButton)
        Me.Controls.Add(Me.startPauseButton)
        Me.Controls.Add(Me.stopWatch)
        Me.Name = "StopWatchForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents stopWatch As Label
    Friend WithEvents stopWatchTimer As Timer
    Friend WithEvents startPauseButton As Button
    Friend WithEvents resetButton As Button
End Class
