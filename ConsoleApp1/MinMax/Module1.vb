Module Module1

    Function Min(ByVal a As Int32, ByVal b As Int32)
        Return If(a > b, b, a)
    End Function

    Function Max(ByVal a As Int32, ByVal b As Int32)
        Return If(a > b, a, b)
    End Function

    Function GetMinInArr(ByVal arr() As Int32)
        Dim minimum As Int32 = Int32.MaxValue
        For i As Int32 = 1 To UBound(arr)
            minimum = Min(minimum, arr(i))
        Next
        Return minimum
    End Function

    Function GetMaxInArr(ByVal arr() As Int32)
        Dim maximum As Int32 = Int32.MinValue
        For i As Int32 = 1 To UBound(arr)
            maximum = Max(maximum, arr(i))
        Next
        Return maximum
    End Function

    Sub Main()
        Dim size, minimum, maximum As Int32
        Console.WriteLine("Enter the size of the Array: ")
        size = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Enter " + size.ToString() + "numbers")
        Dim array(size) As Int32
        For i As Int32 = 1 To size
            array(i) = Convert.ToInt32(Console.ReadLine())
        Next
        minimum = GetMinInArr(arr:=array)
        maximum = GetMaxInArr(arr:=array)
        Console.WriteLine("Minimum = " + minimum.ToString() + " and Maximum = " + maximum.ToString())
        Console.ReadKey()
    End Sub

End Module
