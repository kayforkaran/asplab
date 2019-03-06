Public Class Form1

    Dim started As Boolean = False
    Dim counter As Integer = 0
    Private Sub StartStop_Click(sender As Object, e As EventArgs) Handles StartStop.Click
        If started = False Then
            started = True
            StartStop.Text = "Stop"
            MyTimer.Start()
        Else
            started = False
            StartStop.Text = "Start"
            MyTimer.Stop()
        End If
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        started = False
        MessageBox.ResetText()
        ElapsedTime.Text = "0"
        StartStop.Text = "Start"
        counter = 0
    End Sub

    Private Sub MyTimerTick(sender As Object, e As EventArgs) Handles MyTimer.Tick
        If started Then
            counter += 1
            ' System.Diagnostics.Debug.WriteLine("<<<<Timer tick event fired>>>> with counter = " + Convert.ToString(counter))
            ElapsedTime.Text = Convert.ToString(counter)
        End If
    End Sub

End Class
