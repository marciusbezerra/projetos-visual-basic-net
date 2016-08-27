Module Formatos

    Sub Main()
        Dim Hoje As Date = Today
        Dim Agora As Date = Now
        Console.WriteLine("Hoje é dia: " & Agora.ToString)
        Agora = Agora.AddDays(2)
        Console.WriteLine("Somando-se 2 dias: " & Agora.ToString)
        Agora = Agora.AddMonths(2)
        Console.WriteLine("Somando-se 2 mêses: " & Agora.ToString)
        Dim ProxMes As Date = DateAdd(DateInterval.Month, 3, Hoje)
        Console.WriteLine("Hoje + 3 meses (DateAdd): " & ProxMes.ToString)
        Dim ProxAno As Date = DateAdd(DateInterval.Year, 1, Hoje)
        Console.WriteLine("Hoje + 1 ano (DateAdd): " & ProxAno.ToString)
        'Calcular a idade:
        Dim Idade As Long
        Dim Nasc As Date = #11/30/1975#
        Idade = DateDiff(DateInterval.Year, Nasc, Today)
        If DateSerial(Year(Today), Month(Nasc), Day(Nasc)) > Today Then
            Idade -= 1
        End If
        Console.WriteLine("Cálculo da idade: " & Idade.ToString)

        Dim DataAtual As DateTime = DateTime.Now
        Console.WriteLine("Este exemplo baseia-se em: " & Format(DataAtual, "General Date"))
        Console.WriteLine("-- Função de formatação --")
        Console.WriteLine("Data completa: " & FormatDateTime(DataAtual, DateFormat.GeneralDate))
        Console.WriteLine("Long Date....: " & FormatDateTime(DataAtual, DateFormat.LongDate))
        Console.WriteLine("Short Date...: " & FormatDateTime(DataAtual, DateFormat.ShortDate))
        Console.WriteLine("Long Time....: " & FormatDateTime(DataAtual, DateFormat.LongTime))
        Console.WriteLine("Short Time...: " & FormatDateTime(DataAtual, DateFormat.ShortTime))
        Console.WriteLine("-- Formatos de dias --")
        Console.WriteLine("d...: " & Format(DataAtual, "d"))
        Console.WriteLine("dd..: " & Format(DataAtual, "dd"))
        Console.WriteLine("ddd.: " & Format(DataAtual, "ddd"))
        Console.WriteLine("dddd: " & Format(DataAtual, "dddd"))
        Console.WriteLine("-- Formatos de meses --")
        Console.WriteLine("M...: " & Format(DataAtual, "M"))
        Console.WriteLine("MM..: " & Format(DataAtual, "MM"))
        Console.WriteLine("MMM.: " & Format(DataAtual, "MMM"))
        Console.WriteLine("MMMM: " & Format(DataAtual, "MMMM"))
        Console.WriteLine("-- Formatos de anos --")
        Console.WriteLine("y...: " & Format(DataAtual, "y"))
        Console.WriteLine("yy..: " & Format(DataAtual, "yy"))
        Console.WriteLine("yyyy: " & Format(DataAtual, "yyyy"))
        Console.WriteLine("-- Formatos de horas --")
        Console.WriteLine("hh..: " & Format(DataAtual, "hh"))
        Console.WriteLine("HH..: " & Format(DataAtual, "HH"))
        Console.WriteLine("-- Formatos de minutos --")
        Console.WriteLine("mm..: " & Format(DataAtual, "mm"))
        Console.WriteLine("-- Formatos de segundos --")
        Console.WriteLine("ss..: " & Format(DataAtual, "ss"))
        Console.WriteLine("-- Formatos personalizados --")
        Console.WriteLine("dd/MM/yyyy.......: " & Format(DataAtual, "dd/MM/yyyy"))
        Console.WriteLine("MM/dd/yyyy.......: " & Format(DataAtual, "MM/dd/yyyy"))
        Console.WriteLine("dd/MM............: " & Format(DataAtual, "dd/MM"))
        Console.WriteLine("dd ddd/MMM/yyyy..: " & Format(DataAtual, "dd ddd/MMM/yyyy"))
        Console.WriteLine("dd dddd/MMMM/yyyy: " & Format(DataAtual, "dd dddd/MMMM/yyyy"))
        Console.WriteLine("dddd dd/MMM/yyyy.: " & Format(DataAtual, "dddd dd/MMM/yyyy"))
        Console.WriteLine("-- FormatNumber --")
        Dim NumeroDouble As Double = 2500.87
        Console.WriteLine("NumeroDouble.........................: " & NumeroDouble.ToString)
        Console.WriteLine("FormatNumber(NumeroDouble, 0)........: " & FormatNumber(NumeroDouble, 0))
        Console.WriteLine("FormatNumber(NumeroDouble, 2)........: " & FormatNumber(NumeroDouble, 2))
        Console.WriteLine("FormatNumber(NumeroDouble, 3)........: " & FormatNumber(NumeroDouble, 3))
        Console.WriteLine("FormatNumber(NumeroDouble - 10000, 2): " & FormatNumber(NumeroDouble - 10000, 2))
        Console.WriteLine("-- FormatPercent --")
        Dim NumeroDecimal As Decimal = 0.25
        Console.WriteLine("NumeroDecimal: " & NumeroDecimal.ToString)
        Console.WriteLine("FormatPercent(NumeroDecimal, 2): " & FormatPercent(NumeroDecimal, 2))
        Console.WriteLine("FormatPercent(NumeroDecimal, 3): " & FormatPercent(NumeroDecimal, 3))
        NumeroDecimal = 10
        Console.WriteLine("NumeroDecimal: " & NumeroDecimal.ToString)
        Console.WriteLine("FormatPercent(NumeroDecimal, 2): " & FormatPercent(NumeroDecimal, 2))
        Console.WriteLine("FormatPercent(NumeroDecimal, 3): " & FormatPercent(NumeroDecimal, 3))
        Console.WriteLine("-- FormatCurrency --")
        NumeroDouble = 4800.9
        Console.WriteLine("NumeroDouble: " & NumeroDouble.ToString)
        Console.WriteLine("FormatCurrency(NumeroDouble, 2): " & FormatCurrency(NumeroDouble, 2))
        Console.WriteLine("FormatCurrency(NumeroDouble, 3): " & FormatCurrency(NumeroDouble, 3))
        NumeroDouble = -3000
        Console.WriteLine("NumeroDouble: " & NumeroDouble.ToString)
        Console.WriteLine("FormatCurrency(NumeroDouble, 2): " & FormatCurrency(NumeroDouble, 2))
        Console.WriteLine("FormatCurrency(NumeroDouble, 3): " & FormatCurrency(NumeroDouble, 3))
        Console.WriteLine("-- Format --")
        NumeroDouble = 2500.87
        Console.WriteLine("NumeroDouble: " & NumeroDouble.ToString)
        Console.WriteLine("Format(NumeroDouble, ""g""): " & Format(NumeroDouble, "g"))
        Console.WriteLine("Format(NumeroDouble, ""c""): " & Format(NumeroDouble, "c"))
        Console.WriteLine("Format(NumeroDouble, ""f""): " & Format(NumeroDouble, "f"))
        Console.WriteLine("Format(NumeroDouble, ""n""): " & Format(NumeroDouble, "n"))
        Console.WriteLine("-- Formatos genéricos com casas decimais --")
        Console.WriteLine("Format(NumeroDouble, ""g5""): " & Format(NumeroDouble, "g5"))
        Console.WriteLine("Format(NumeroDouble, ""c4""): " & Format(NumeroDouble, "c4"))
        Console.WriteLine("Format(NumeroDouble, ""f3""): " & Format(NumeroDouble, "f3"))
        Console.WriteLine("Format(NumeroDouble, ""n3""): " & Format(NumeroDouble, "n3"))
        Console.WriteLine("-- Sim/Não --")
        Dim Valor As Integer = 0
        Console.WriteLine("Valor: " & Valor.ToString)
        Console.WriteLine("Format(Valor, ""Yes/No"")........: " & Format(Valor, "Yes/No"))
        Console.WriteLine("Format(Valor + 1, ""Yes/No"")....: " & Format(Valor + 1, "Yes/No"))
        Console.WriteLine("-- Verdadeiro / Falso --")
        Console.WriteLine("Format(Valor, ""True/False"")....: " & Format(Valor, "True/False"))
        Console.WriteLine("Format(Valor - 1, ""True/False""): " & Format(Valor - 1, "True/False"))
        Console.WriteLine("-- Formatos com strings --")
        Dim t, s As String
        t = "Valor {0} à vista..........: "
        s = String.Format(t, 4500)
        Console.WriteLine(t & s)
        t = "Valor {0:c} à vista........: "
        s = String.Format(t, 4500)
        Console.WriteLine(t & s)
        t = "Valor {0:c} à vista e {1:c}: "
        s = String.Format(t, 4500, 7800)
        Console.WriteLine(t & s)
        Console.WriteLine("-- Formatos personalizados --")
        NumeroDouble = 6670.83
        Console.WriteLine("NumeroDouble: " & NumeroDouble.ToString)
        Console.WriteLine("Format(NumeroDouble, ""##,##0.00"")...: " & Format(NumeroDouble, "##,##0.00"))
        Console.WriteLine("Format(NumeroDouble, ""000###0.0000""): " & Format(NumeroDouble, "000###0.0000"))
        Console.WriteLine("Format(4, ""0.00%"")..................: " & Format(4, "0.00%"))
        Console.ReadLine()
    End Sub

End Module
