Public Class Form1

    Private currentLocalDateTime As DateTime
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        currentLocalDateTime = DateTime.Now
        clock.Text = currentLocalDateTime.ToLongTimeString
        clockTimer.Start()
    End Sub

    Private Sub clockTimerTick(sender As Object, e As EventArgs) Handles clockTimer.Tick
        clock.Text = DateTime.Now.ToLongTimeString
    End Sub
End Class
