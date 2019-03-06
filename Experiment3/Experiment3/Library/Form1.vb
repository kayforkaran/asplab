Public Class Form1
    'Private Const V As String = "Summary"
    '
    'Utility Methods
    '
    Private Sub CalculatePoints()
        Dim name As String
        Dim numberOfBooksLocal, points As Int64
        name = studentName.Text
        Dim message, caption As String
        Dim messageBoxButtons As MessageBoxButtons
        numberOfBooksLocal = Convert.ToInt64(numberOfBooks.Text)
        points = 0
        If numberOfBooksLocal > 6 Then
            points += 6 * 10
        Else
            points += numberOfBooksLocal * 10
        End If
        numberOfBooksLocal -= 6
        If numberOfBooksLocal > 0 Then
            points += numberOfBooksLocal * 20
        End If
        message = name + "'s points : " + Convert.ToString(points)
        caption = "Points"
        messageBoxButtons = MessageBoxButtons.OK
        MessageBox.Show(message, caption, messageBoxButtons)
    End Sub

    Private Sub ShowSummary()
        Dim message, caption As String
        Dim messageBoxButtons As MessageBoxButtons
        message = "No Summary required"
        caption = "Summary"
        messageBoxButtons = MessageBoxButtons.OK
        MessageBox.Show(message, caption, messageBoxButtons)
    End Sub

    Private Sub ShowAbout()
        Form2.Show()
    End Sub

    Private Sub ClearForm()
        For Each tb As TextBox In Me.Controls.OfType(Of TextBox)()
            tb.Text = String.Empty
        Next
    End Sub

    Private Sub PointsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PointsToolStripMenuItem.Click
        CalculatePoints()
    End Sub

    Private Sub SummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummaryToolStripMenuItem.Click
        ShowSummary()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        ClearForm()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        ShowAbout()
    End Sub

    Private Sub KeyDownEvent(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        '
        'shortcuts
        '
        If e.Modifiers.Equals(Keys.Control) And e.KeyCode.Equals(Keys.Q) Then
            Application.Exit()
        ElseIf e.Modifiers.Equals(Keys.Control) And e.KeyCode.Equals(Keys.P) Then
            CalculatePoints()
        ElseIf e.Modifiers.Equals(Keys.Control) And e.KeyCode.Equals(Keys.S) Then
            ShowSummary()
        ElseIf e.Modifiers.Equals(Keys.Control) And e.KeyCode.Equals(Keys.C) Then
            ClearForm()
        ElseIf e.Modifiers.Equals(Keys.Control) And e.KeyCode.Equals(Keys.I) Then
            ShowAbout()
        End If
    End Sub

End Class
