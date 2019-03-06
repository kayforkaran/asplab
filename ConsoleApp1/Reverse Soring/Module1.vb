Module Module1

    Sub SortRev(ByRef Arr() As Int32)
        ''''''''''''''''
        'selection sort.
        'Complexity=O(n)
        ''''''''''''''''
        Dim temp, temp2 As Int32
        For i As Int32 = 1 To UBound(Arr)
            temp = i
            For j As Int32 = i To UBound(Arr)
                If Arr(j) > Arr(temp) Then
                    temp = j
                End If
            Next
            temp2 = Arr(i)
            Arr(i) = Arr(temp)
            Arr(temp) = temp2
        Next
    End Sub

    Sub Main()
        Dim size As Int32
        Console.WriteLine("Enter the size of the Array: ")
        size = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Enter " + size.ToString() + "numbers")
        Dim array(size) As Int32
        For i As Int32 = 1 To size
            array(i) = Convert.ToInt32(Console.ReadLine())
        Next
        SortRev(Arr:=array)
        For i As Int32 = 1 To size
            Console.WriteLine(array(i).ToString)
        Next
        Console.ReadKey()
    End Sub

End Module
