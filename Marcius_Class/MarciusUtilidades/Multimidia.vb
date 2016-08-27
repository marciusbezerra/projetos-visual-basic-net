Public Class Multimidia

    Public Enum AFPCDAbrirFechar
        Abrir
        Fechar
    End Enum

    Shared Sub AbrirFecharPortaDoCD(ByVal AbrirFechar As AFPCDAbrirFechar)
        Dim Retorno As java.lang.StringBuffer
        Dim Comando As String
        If AbrirFechar = AFPCDAbrirFechar.Abrir Then
            Comando = "set CDAudio door open"
        Else
            Comando = "set CDAudio door closed"
        End If
        com.ms.win32.Winmm.mciSendString(Comando, Retorno, 127, 0)
    End Sub
End Class