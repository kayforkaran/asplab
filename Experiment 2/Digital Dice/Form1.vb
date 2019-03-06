Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dice.Text = ""
    End Sub

    Private Sub throwDice_Click(sender As Object, e As EventArgs) Handles throwDice.Click
        Dim randomizer As Random
        randomizer = New Random()
        dice.Text = randomizer.Next(1, 7)
    End Sub
End Class
