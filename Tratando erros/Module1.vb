Module Module1

    Sub Main()
        Dim i As Integer = 2147483647, j As Integer = 0, k As Integer = 0
        Try
            i += 1
            k = (i / j)
        Catch ex As DivideByZeroException
            Console.WriteLine("Erro: divisão por zero.")
        Catch ex As OverflowException
            Console.WriteLine("Erro: Overflow")
        Catch ex As Exception
            Console.WriteLine("Ocorreu um erro na operação." & _
                vbCrLf & ex.message)
        Finally
            Console.ReadLine()
        End Try
    End Sub

End Module
