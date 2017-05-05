Module _1_4Aritmetica
    Sub main()

        Dim valor As Short = 1250
        Dim valor2 As Integer = 851

        Dim valor3 As Single = 1.8465
        Dim valor4 As Double = 1.9846432131

        Console.WriteLine("Valor short: "& valor ) 
        Console.WriteLine("Valor entero: " & valor2)
        Console.WriteLine("Valor single: " & valor3)
        Console.WriteLine("Valor double: " & valor4)

        Console.WriteLine("Sumar entero short con punto flotante double: " & valor + valor4)
        Console.WriteLine("Restar single con integer: " & valor3 - valor2)
        Console.WriteLine("Sumar entero con entero: " & valor + valor2)
        Console.WriteLine("sumar single y double: " & valor3 + valor4)
        Console.WriteLine("restar double con single: " & valor3 - valor4)
        Console.ReadKey()
    End Sub
End Module
