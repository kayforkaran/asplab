Imports System.Collections.Generics
Module Module1
    ' Finding Largest Number Using Dynamic Array
    Sub Main()
        Dim array As New List(Of Int32)()
        Dim num As Int32
        Dim input As String
        Do
            Console.WriteLine("Populating Array. Enter a Number(Enter -1 to end input)")
            input = Console.ReadLine()
            num = Convert.ToInt32(input)
            If num <> -1 Then
                ' ReDim Preserve Array(0 To UBound(Array) + 1) As Int32
                array.Add(num)
            End If
        Loop Until num = -1
        For Each number As Int32 In array
            If number > num Then
                num = number
            End If
        Next
        Console.WriteLine(Convert.ToString(num) + " is the largest number.")
        Console.ReadKey()

    End Sub

End Module
