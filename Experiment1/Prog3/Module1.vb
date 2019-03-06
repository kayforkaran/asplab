Module Module1
    ' pallindrome
    Sub Main()
        Dim input As String
        Dim first As Integer
        Dim last As Integer
        Dim pal As Boolean = True
        input = Console.ReadLine()
        first = 0
        last = input.Length - 1
        While first < last
            If input(first) <> input(last) Then
                pal = False
                Exit While
            End If
            first = first + 1
            last = last - 1
        End While
        If pal Then
            Console.WriteLine(input + " is a pallindrome.")
        Else
            Console.WriteLine(input + " is not a pallindrome.")
        End If
        Console.ReadKey()

    End Sub

End Module
