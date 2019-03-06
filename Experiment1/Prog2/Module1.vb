Module Module1

    Sub Main()
        Dim ounces As Int32
        Dim pounds As Int32
        Dim rate As Double = 0.15
        Dim cost As Double
        Dim p As String
        p = Console.ReadLine()
        ounces = Convert.ToInt32(p)
        p = Console.ReadLine()
        pounds = Convert.ToInt32(p)
        cost = (ounces + pounds * 16) * 0.15
        Console.Write("Total Cost is " + Convert.ToString(cost))
        Console.ReadKey()
    End Sub

End Module
