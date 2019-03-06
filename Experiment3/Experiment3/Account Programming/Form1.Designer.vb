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
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EdtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnitedStatesCtrlUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CanadaCtrlCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JapanCtrlJToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MexicoCtrlMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TitleCtrlTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CountryNameCtrlOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgrammerCtrlRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutCtrlIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EdtToolStripMenuItem, Me.DisplayToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.ExitToolStripMenuItem.Text = "Exit (Ctrl + Q)"
        '
        'EdtToolStripMenuItem
        '
        Me.EdtToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UnitedStatesCtrlUToolStripMenuItem, Me.CanadaCtrlCToolStripMenuItem, Me.JapanCtrlJToolStripMenuItem, Me.MexicoCtrlMToolStripMenuItem})
        Me.EdtToolStripMenuItem.Name = "EdtToolStripMenuItem"
        Me.EdtToolStripMenuItem.Size = New System.Drawing.Size(47, 24)
        Me.EdtToolStripMenuItem.Text = "Edit"
        '
        'UnitedStatesCtrlUToolStripMenuItem
        '
        Me.UnitedStatesCtrlUToolStripMenuItem.CheckOnClick = True
        Me.UnitedStatesCtrlUToolStripMenuItem.Name = "UnitedStatesCtrlUToolStripMenuItem"
        Me.UnitedStatesCtrlUToolStripMenuItem.Size = New System.Drawing.Size(237, 26)
        Me.UnitedStatesCtrlUToolStripMenuItem.Text = "United States (Ctrl + U)"
        '
        'CanadaCtrlCToolStripMenuItem
        '
        Me.CanadaCtrlCToolStripMenuItem.CheckOnClick = True
        Me.CanadaCtrlCToolStripMenuItem.Name = "CanadaCtrlCToolStripMenuItem"
        Me.CanadaCtrlCToolStripMenuItem.Size = New System.Drawing.Size(237, 26)
        Me.CanadaCtrlCToolStripMenuItem.Text = "Canada (Ctrl + C)"
        '
        'JapanCtrlJToolStripMenuItem
        '
        Me.JapanCtrlJToolStripMenuItem.CheckOnClick = True
        Me.JapanCtrlJToolStripMenuItem.Name = "JapanCtrlJToolStripMenuItem"
        Me.JapanCtrlJToolStripMenuItem.Size = New System.Drawing.Size(237, 26)
        Me.JapanCtrlJToolStripMenuItem.Text = "Japan (Ctrl + J)"
        '
        'MexicoCtrlMToolStripMenuItem
        '
        Me.MexicoCtrlMToolStripMenuItem.CheckOnClick = True
        Me.MexicoCtrlMToolStripMenuItem.Name = "MexicoCtrlMToolStripMenuItem"
        Me.MexicoCtrlMToolStripMenuItem.Size = New System.Drawing.Size(237, 26)
        Me.MexicoCtrlMToolStripMenuItem.Text = "Mexico (Ctrl +M)"
        '
        'DisplayToolStripMenuItem
        '
        Me.DisplayToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TitleCtrlTToolStripMenuItem, Me.CountryNameCtrlOToolStripMenuItem, Me.ProgrammerCtrlRToolStripMenuItem})
        Me.DisplayToolStripMenuItem.Name = "DisplayToolStripMenuItem"
        Me.DisplayToolStripMenuItem.Size = New System.Drawing.Size(70, 24)
        Me.DisplayToolStripMenuItem.Text = "Display"
        '
        'TitleCtrlTToolStripMenuItem
        '
        Me.TitleCtrlTToolStripMenuItem.CheckOnClick = True
        Me.TitleCtrlTToolStripMenuItem.Name = "TitleCtrlTToolStripMenuItem"
        Me.TitleCtrlTToolStripMenuItem.Size = New System.Drawing.Size(245, 26)
        Me.TitleCtrlTToolStripMenuItem.Text = "Title (Ctrl + T)"
        '
        'CountryNameCtrlOToolStripMenuItem
        '
        Me.CountryNameCtrlOToolStripMenuItem.CheckOnClick = True
        Me.CountryNameCtrlOToolStripMenuItem.Name = "CountryNameCtrlOToolStripMenuItem"
        Me.CountryNameCtrlOToolStripMenuItem.Size = New System.Drawing.Size(245, 26)
        Me.CountryNameCtrlOToolStripMenuItem.Text = "Country Name (Ctrl + O)"
        '
        'ProgrammerCtrlRToolStripMenuItem
        '
        Me.ProgrammerCtrlRToolStripMenuItem.CheckOnClick = True
        Me.ProgrammerCtrlRToolStripMenuItem.Name = "ProgrammerCtrlRToolStripMenuItem"
        Me.ProgrammerCtrlRToolStripMenuItem.Size = New System.Drawing.Size(245, 26)
        Me.ProgrammerCtrlRToolStripMenuItem.Text = "Programmer (Ctrl + R)"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutCtrlIToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutCtrlIToolStripMenuItem
        '
        Me.AboutCtrlIToolStripMenuItem.Name = "AboutCtrlIToolStripMenuItem"
        Me.AboutCtrlIToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.AboutCtrlIToolStripMenuItem.Text = "About (Ctrl + I)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EdtToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnitedStatesCtrlUToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CanadaCtrlCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JapanCtrlJToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MexicoCtrlMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TitleCtrlTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CountryNameCtrlOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProgrammerCtrlRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutCtrlIToolStripMenuItem As ToolStripMenuItem
End Class
