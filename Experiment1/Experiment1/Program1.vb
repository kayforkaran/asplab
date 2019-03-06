Module Program1

    Sub Main()
        Dim pennies As Double
        Dim nickels As Double
        Dim dimes As Double
        Dim quarters As Double
        Dim p As String
        Console.WriteLine("Enter the number of pennies")
        p = Console.ReadLine()
        pennies = Convert.ToDouble(p)
        Console.WriteLine("Enter the number of nickels")
        p = Console.ReadLine()
        nickels = Convert.ToDouble(p)
        Console.WriteLine("Enter the number of dimes")
        p = Console.ReadLine()
        dimes = Convert.ToDouble(p)
        Console.WriteLine("Enter the number of quarters")
        p = Console.ReadLine()
        quarters = Convert.ToDouble(p)
        Console.WriteLine("The Total Amount in the piggy bank is: " + Convert.ToString((pennies / 100) + (nickels / 20) + (dimes / 10) + (quarters / 4)))
        Console.ReadKey()
    End Sub

End Module
