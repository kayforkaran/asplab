Public Class StopWatchForm
    Private timeElapsed As Int64
    Private Sub startPauseButton_Click(sender As Object, e As EventArgs) Handles startPauseButton.Click
        stopWatchTimer.Start()
    End Sub

    Private Sub resetButton_Click(sender As Object, e As EventArgs) Handles resetButton.Click
        stopWatchTimer.Stop()
        stopWatch.Text = "0:0:0:0"
        timeElapsed = 0
    End Sub

    Private Sub StopWatchForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        stopWatch.Text = "0:0:0:0"
        timeElapsed = 0
    End Sub

    Private Sub stopWatchTimer_Tick(sender As Object, e As EventArgs) Handles stopWatchTimer.Tick
        timeElapsed += 1
        Dim seconds As Int64
        Dim centiseconds As Int64
        Dim minutes As Int64
        Dim hours As Int64
        centiseconds = timeElapsed Mod 10
        seconds = (timeElapsed / 10) Mod 60
        minutes = (timeElapsed / 600) Mod 60
        hours = timeElapsed / 36000
        stopWatch.Text = hours.ToString() + ":" +
            minutes.ToString() + ":" +
            seconds.ToString() + ":" +
            centiseconds.ToString()
    End Sub
End Class
