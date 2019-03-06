Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name As String
        Dim price, quantity As Int32
        name = bookName.Text
        Try
            price = Convert.ToInt32(bookPrice.Text)
        Catch ex As Exception
            MessageBox.Show("Only Integers Allowed in Price")
            Exit Sub
        End Try
        Try
            quantity = Convert.ToInt32(bookQuantity.Text)
        Catch ex As Exception
            MessageBox.Show("Only Integers Allowed in Quantity")
            Exit Sub
        End Try
        Dim newBook As SavedOBject = New SavedOBject(name, price, quantity)
        'Dim myFileStream As FileStream = New FileStream("database.txt", FileMode.Append, FileAccess.ReadWrite)
        'Dim myStreamWriter As IO.StreamWriter
        Using myStreamWriter As New StreamWriter("database.txt", FileMode.Append)
            myStreamWriter.WriteLine(newBook.savedData())
            myStreamWriter.Close()
            MessageBox.Show("Successfully Saved!")
        End Using
    End Sub

    Private Sub RetrieveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RetrieveToolStripMenuItem.Click
        Retrieve.Show()
    End Sub
End Class

Class SavedOBject
    Private NameOFBook As String
    Private PriceOfBook As Int32
    Private QuantityOfBook As Int32

    Public Sub New(ByVal nameOfBook As String, ByVal priceOfBook As Int32, ByVal numberOfBooks As Int32)
        BookName = nameOfBook
        Price = priceOfBook
        Quantity = numberOfBooks
    End Sub

    Public Property BookName As String
        Get
            Return Me.NameOFBook
        End Get
        Set(value As String)
            Me.NameOFBook = value
        End Set
    End Property

    Public Property Price As String
        Get
            Return Me.PriceOfBook
        End Get
        Set(value As String)
            Me.PriceOfBook = value
        End Set
    End Property

    Public Property Quantity As Integer
        Get
            Return Me.QuantityOfBook
        End Get
        Set(value As Integer)
            Me.QuantityOfBook = value
        End Set
    End Property

    Public Function savedData()
        Return Me.BookName + "|" + Me.Price.ToString + "|" + Me.Quantity.ToString
    End Function
End Class
