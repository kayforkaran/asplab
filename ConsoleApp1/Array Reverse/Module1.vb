Module Module1

    Sub Swap(ByRef a As Int32, ByRef b As Int32)
        Dim temp As Int32
        temp = a
        a = b
        b = temp
    End Sub

    Sub Reverse(ByRef Arr() As Int32)
        Dim i, j As Int32
        i = LBound(Arr) + 1
        j = UBound(Arr)
        Console.WriteLine(i.ToString() + " " + j.ToString())
        While i < j
            Swap(Arr(i), Arr(j))
            i += 1
            j -= 1
        End While
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
        Reverse(Arr:=array)
        For i As Int32 = 1 To size
            Console.WriteLine(array(i).ToString)
        Next
        Console.ReadKey()
    End Sub

End Module
