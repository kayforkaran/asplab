Public Class Form1
    Private totalMoneyPaid As Int64
    Private numberOfEmployees As Int64
    Private totalNumberOfPieces As Int64
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub Form_keyPressDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.Modifiers.Equals(Keys.Control) And e.KeyCode.Equals(Keys.Q)) Then
            Application.Exit()
        ElseIf e.Modifiers.Equals(Keys.Control) And e.KeyCode.Equals(Keys.P) Then
            calculatePay()
        ElseIf e.Modifiers.Equals(Keys.Control) And e.KeyCode.Equals(Keys.S) Then
            showSummary()
        End If
    End Sub

    Private Sub calculatePay()
        Dim pieces As Int64
        Dim rate As Int64
        Dim message, caption As String
        Dim result As DialogResult
        Dim totalPayMessageBoxButtons As MessageBoxButtons
        pieces = Convert.ToInt64(numberOfPieces.Text)
        rate = Convert.ToInt64(payPerPiece.Text)
        message = "The pay for current employee is : " + Convert.ToString(pieces * rate)
        caption = "Total Pay"
        totalPayMessageBoxButtons = MessageBoxButtons.OK
        totalMoneyPaid += pieces * rate
        numberOfEmployees += 1
        totalNumberOfPieces += pieces
        result = MessageBox.Show(message, caption, totalPayMessageBoxButtons)
    End Sub

    Sub showSummary()
        Dim message, caption As String
        Dim result As DialogResult
        Dim totalPayMessageBoxButtons As MessageBoxButtons
        message = "Number of Money Paid = " + totalMoneyPaid.ToString() + vbNewLine +
            "Number of Pieces = " + totalNumberOfPieces.ToString() + vbNewLine +
            "Average Salary of Employees = " + (If(numberOfEmployees > 0, (totalMoneyPaid / numberOfEmployees), 0)).ToString()
        caption = "Summary"
        totalPayMessageBoxButtons = MessageBoxButtons.OK
        result = MessageBox.Show(message, caption, totalPayMessageBoxButtons)
    End Sub

    Private Sub CalculatePayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculatePayToolStripMenuItem.Click
        calculatePay()
    End Sub

    Private Sub SummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummaryToolStripMenuItem.Click
        showSummary()
    End Sub
End Class
