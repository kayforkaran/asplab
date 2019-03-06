Public Class Form1
    Private balance As Int32
    Private Function Max(a As Int32, b As Int32)
        Return If(a > b, a, b)
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TransactionTypeDeposit.Checked Or TransactionTypeCheque.Checked Then
            balance += Convert.ToInt32(Amount.Text)
        ElseIf TransactionTypeServiceCharge.Checked Then
            balance -= Convert.ToInt32(Amount.Text)
            balance = Max(balance, 0)
        End If
        BalanceLabel.Text = balance.ToString
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        balance = 0
    End Sub
End Class
