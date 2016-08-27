Module Principal
    Sub Main()
        Dim ObjAluno As New Aluno(Notas.NotaFinal.Nota06, _
            Notas.NotaFinal.Nota08, Notas.NotaFinal.Nota08)
        If ObjAluno.CalculaMedia >= Notas.NotaFinal.Nota07 Then
            MsgBox("Passou")
        Else
            MsgBox("Não passou")
        End If

        Dim ObjAlunoNaMedia As New AlunoNaMedia

        ObjAlunoNaMedia.Nome = "João"
        ObjAlunoNaMedia.DataDeNascimento = #11/30/1975#
        ObjAlunoNaMedia.Endereco = "Rua Número 1"

        If ObjAlunoNaMedia.CalculaMedia >= Notas.NotaFinal.Nota07 Then
            MsgBox("Passou")
        Else
            MsgBox("Não passou")
        End If
    End Sub
End Module
