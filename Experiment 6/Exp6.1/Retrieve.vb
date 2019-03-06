Imports System.IO
Public Class Retrieve
    Private FILE_NAME As String = "database.txt"
    Private peekPoint As Int32 = 0
    Private Sub Retrieve_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If System.IO.File.Exists(FILE_NAME) = True Then
            Using myStreamReader As New StreamReader(FILE_NAME)
                Dim line As String
                Dim separator As Char = "|"
                line = myStreamReader.ReadLine()
                Dim arr() As String
                arr = line.Split(separator)
                Label4.Text = arr(0)
                Label5.Text = arr(1)
                Label6.Text = arr(2)
                Label1.Text = myStreamReader.Peek()
            End Using
        Else
            MessageBox.Show("File Does Not Exist")
        End If
    End Sub
End Class