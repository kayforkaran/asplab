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
        Me.components = New System.ComponentModel.Container()
        Me.StartStop = New System.Windows.Forms.Button()
        Me.MessageBox = New System.Windows.Forms.TextBox()
        Me.Reset = New System.Windows.Forms.Button()
        Me.ElapsedTime = New System.Windows.Forms.Label()
        Me.MyTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'StartStop
        '
        Me.StartStop.Location = New System.Drawing.Point(459, 169)
        Me.StartStop.Name = "StartStop"
        Me.StartStop.Size = New System.Drawing.Size(132, 51)
        Me.StartStop.TabIndex = 0
        Me.StartStop.Text = "Start"
        Me.StartStop.UseVisualStyleBackColor = True
        '
        'MessageBox
        '
        Me.MessageBox.Location = New System.Drawing.Point(66, 43)
        Me.MessageBox.Name = "MessageBox"
        Me.MessageBox.Size = New System.Drawing.Size(328, 22)
        Me.MessageBox.TabIndex = 1
        '
        'Reset
        '
        Me.Reset.Location = New System.Drawing.Point(635, 169)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(121, 51)
        Me.Reset.TabIndex = 2
        Me.Reset.Text = "Reset"
        Me.Reset.UseVisualStyleBackColor = True
        '
        'ElapsedTime
        '
        Me.ElapsedTime.AutoSize = True
        Me.ElapsedTime.Location = New System.Drawing.Point(604, 95)
        Me.ElapsedTime.Name = "ElapsedTime"
        Me.ElapsedTime.Size = New System.Drawing.Size(16, 17)
        Me.ElapsedTime.TabIndex = 3
        Me.ElapsedTime.Text = "0"
        '
        'MyTimer
        '
        Me.MyTimer.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ElapsedTime)
        Me.Controls.Add(Me.Reset)
        Me.Controls.Add(Me.MessageBox)
        Me.Controls.Add(Me.StartStop)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StartStop As Button
    Friend WithEvents MessageBox As TextBox
    Friend WithEvents Reset As Button
    Friend WithEvents ElapsedTime As Label
    Friend WithEvents MyTimer As Timer
End Class
