Module Module1

    Function Search(ByRef Arr() As Int32, ByVal number As Int32)
        ''''''''''''''''''
        'Linear Searching.
        'Complexity = O(n)
        ''''''''''''''''''
        For i As Int32 = 1 To UBound(Arr)
            If Arr(i).Equals(number) Then
                Return i
            End If
        Next
        Return -1
    End Function

    Sub Main()
        Dim size, number, index As Int32
        Console.WriteLine("Enter the size of the Array: ")
        size = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Enter " + size.ToString() + "numbers")
        Dim array(size) As Int32
        For i As Int32 = 1 To size
            array(i) = Convert.ToInt32(Console.ReadLine())
        Next
        Console.WriteLine("Enter the number to be searched: ")
        number = Convert.ToInt32(Console.ReadLine())
        index = Search(Arr:=array, number:=number)
        Console.WriteLine(index)
        Console.ReadKey()
    End Sub

End Module
