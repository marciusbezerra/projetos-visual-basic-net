
Public Interface Pessoa
    Property DataDeNascimento() As Date
    Property Nome() As String
    Property Endereco() As String
End Interface

Public Class Notas
    Public Enum NotaFinal
        Nota00 = 0
        Nota01 = 1
        Nota02 = 2
        Nota03 = 3
        Nota04 = 4
        Nota05 = 5
        Nota06 = 6
        Nota07 = 7
        Nota08 = 8
        Nota09 = 9
        Nota10 = 10
    End Enum
End Class


Public Class Aluno
    Implements Pessoa

    Private pNome, pEndereco As String
    Private pDtNasc As Date
    Public NotaAp1 As Notas.NotaFinal
    Public NotaAp2 As Notas.NotaFinal
    Public NotaAp3 As Notas.NotaFinal
    Public Function CalculaMedia() As Notas.NotaFinal
        Return CInt((NotaAp1 + NotaAp2 + NotaAp3) / 3)
    End Function
    Public Sub New()
        MyBase.New()
        NotaAp1 = Notas.NotaFinal.Nota00
        NotaAp2 = Notas.NotaFinal.Nota00
        NotaAp3 = Notas.NotaFinal.Nota00
    End Sub
    Public Sub New(ByVal Nota1 As Notas.NotaFinal, ByVal Nota2 As Notas.NotaFinal, _
        ByVal Nota3 As Notas.NotaFinal)
        NotaAp1 = Nota1
        NotaAp2 = Nota2
        NotaAp3 = Nota3
    End Sub

    Public Property DataDeNascimento() As Date Implements Pessoa.DataDeNascimento
        Get
            Return pDtNasc
        End Get
        Set(ByVal Value As Date)
            pDtNasc = Value
        End Set
    End Property

    Public Property Endereco() As String Implements Pessoa.Endereco
        Get
            Return pEndereco
        End Get
        Set(ByVal Value As String)
            pEndereco = Value
        End Set
    End Property

    Public Property Nome() As String Implements Pessoa.Nome
        Get
            Return pNome
        End Get
        Set(ByVal Value As String)
            pNome = Value
        End Set
    End Property
End Class

Public Class AlunoNaMedia : Inherits Aluno
    Sub New()
        MyBase.New(Notas.NotaFinal.Nota07, Notas.NotaFinal.Nota07, Notas.NotaFinal.Nota07)
    End Sub
    Public Class Testes
        Public Materia As String
    End Class
End Class