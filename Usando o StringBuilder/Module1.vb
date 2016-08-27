Module Module1

    Sub Main()
        Dim sb As New System.Text.StringBuilder("USANDO O STRINGBUILDER")
        Console.WriteLine(sb)
        Console.WriteLine()
        sb = Nothing
        sb = New System.Text.StringBuilder("dingdong")
        Console.Write("Capacidade padrao (que é multiplicada quando necessário): ")
        Console.WriteLine(sb.Capacity.ToString)
        Console.WriteLine(sb)
        sb.Chars(0) = "P"c
        sb.Chars(4) = "P"c
        Console.WriteLine(sb)
        sb.Chars(0) = "K"c
        sb.Chars(4) = "K"c
        Console.WriteLine(sb)
        sb = Nothing
        sb = New System.Text.StringBuilder(200)
        Dim N As Integer
        For N = 1 To 100
            sb.Append(N)
            If N < 100 Then sb.Append(", ")
        Next
        sb.Insert(0, "LISTA DE NUMEROS NATURAIS DE 1 A 100: ")
        Console.Write(sb) : Console.ReadLine()
    End Sub

End Module
