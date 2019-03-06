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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionTypeDeposit = New System.Windows.Forms.RadioButton()
        Me.TransactionTypeCheque = New System.Windows.Forms.RadioButton()
        Me.TransactionTypeServiceCharge = New System.Windows.Forms.RadioButton()
        Me.TransactionTypeLabel = New System.Windows.Forms.Label()
        Me.AmountLabel = New System.Windows.Forms.Label()
        Me.Amount = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BalanceLabel = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransactionToolStripMenuItem, Me.SummaryToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(44, 24)
        Me.ToolStripMenuItem1.Text = "File"
        '
        'TransactionToolStripMenuItem
        '
        Me.TransactionToolStripMenuItem.Name = "TransactionToolStripMenuItem"
        Me.TransactionToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.TransactionToolStripMenuItem.Text = "Transaction"
        '
        'SummaryToolStripMenuItem
        '
        Me.SummaryToolStripMenuItem.Name = "SummaryToolStripMenuItem"
        Me.SummaryToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.SummaryToolStripMenuItem.Text = "Summary"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(47, 24)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'TransactionTypeDeposit
        '
        Me.TransactionTypeDeposit.AutoSize = True
        Me.TransactionTypeDeposit.Location = New System.Drawing.Point(6, 16)
        Me.TransactionTypeDeposit.Name = "TransactionTypeDeposit"
        Me.TransactionTypeDeposit.Size = New System.Drawing.Size(77, 21)
        Me.TransactionTypeDeposit.TabIndex = 1
        Me.TransactionTypeDeposit.TabStop = True
        Me.TransactionTypeDeposit.Text = "Deposit"
        Me.TransactionTypeDeposit.UseVisualStyleBackColor = True
        '
        'TransactionTypeCheque
        '
        Me.TransactionTypeCheque.AutoSize = True
        Me.TransactionTypeCheque.Location = New System.Drawing.Point(102, 18)
        Me.TransactionTypeCheque.Name = "TransactionTypeCheque"
        Me.TransactionTypeCheque.Size = New System.Drawing.Size(68, 21)
        Me.TransactionTypeCheque.TabIndex = 2
        Me.TransactionTypeCheque.TabStop = True
        Me.TransactionTypeCheque.Text = "Check"
        Me.TransactionTypeCheque.UseVisualStyleBackColor = True
        '
        'TransactionTypeServiceCharge
        '
        Me.TransactionTypeServiceCharge.AutoSize = True
        Me.TransactionTypeServiceCharge.Location = New System.Drawing.Point(190, 18)
        Me.TransactionTypeServiceCharge.Name = "TransactionTypeServiceCharge"
        Me.TransactionTypeServiceCharge.Size = New System.Drawing.Size(126, 21)
        Me.TransactionTypeServiceCharge.TabIndex = 3
        Me.TransactionTypeServiceCharge.TabStop = True
        Me.TransactionTypeServiceCharge.Text = "Service Charge"
        Me.TransactionTypeServiceCharge.UseVisualStyleBackColor = True
        '
        'TransactionTypeLabel
        '
        Me.TransactionTypeLabel.AutoSize = True
        Me.TransactionTypeLabel.Location = New System.Drawing.Point(27, 91)
        Me.TransactionTypeLabel.Name = "TransactionTypeLabel"
        Me.TransactionTypeLabel.Size = New System.Drawing.Size(127, 17)
        Me.TransactionTypeLabel.TabIndex = 4
        Me.TransactionTypeLabel.Text = "Transaction Type :"
        '
        'AmountLabel
        '
        Me.AmountLabel.AutoSize = True
        Me.AmountLabel.Location = New System.Drawing.Point(27, 186)
        Me.AmountLabel.Name = "AmountLabel"
        Me.AmountLabel.Size = New System.Drawing.Size(56, 17)
        Me.AmountLabel.TabIndex = 5
        Me.AmountLabel.Text = "Amount"
        '
        'Amount
        '
        Me.Amount.Location = New System.Drawing.Point(180, 186)
        Me.Amount.Name = "Amount"
        Me.Amount.Size = New System.Drawing.Size(181, 22)
        Me.Amount.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TransactionTypeDeposit)
        Me.GroupBox1.Controls.Add(Me.TransactionTypeCheque)
        Me.GroupBox1.Controls.Add(Me.TransactionTypeServiceCharge)
        Me.GroupBox1.Location = New System.Drawing.Point(160, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(333, 50)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'BalanceLabel
        '
        Me.BalanceLabel.AutoSize = True
        Me.BalanceLabel.Location = New System.Drawing.Point(177, 277)
        Me.BalanceLabel.Name = "BalanceLabel"
        Me.BalanceLabel.Size = New System.Drawing.Size(0, 17)
        Me.BalanceLabel.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(30, 274)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 28)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "CalcuateBalance"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BalanceLabel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Amount)
        Me.Controls.Add(Me.AmountLabel)
        Me.Controls.Add(Me.TransactionTypeLabel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TransactionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SummaryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransactionTypeDeposit As RadioButton
    Friend WithEvents TransactionTypeCheque As RadioButton
    Friend WithEvents TransactionTypeServiceCharge As RadioButton
    Friend WithEvents TransactionTypeLabel As Label
    Friend WithEvents AmountLabel As Label
    Friend WithEvents Amount As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BalanceLabel As Label
    Friend WithEvents Button1 As Button
End Class
