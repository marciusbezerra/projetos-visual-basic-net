Option Explicit On 
Option Strict On

Public MustInherit Class Funcionario
    Public Event EventoErro(ByVal Nome As String)

    Private fCodigo As String
    Private fSobreNome As String
    Private fNome As String
    Private fEndereco As String
    Private fStatus As Integer
    Private fIdade As Integer

    Public Property Codigo() As String
        Get
            Return fCodigo
        End Get
        Set(ByVal Value As String)
            If Value.Length < 11 Then
                RaiseEvent EventoErro("codigo")
            Else
                fCodigo = Value
            End If
        End Set
    End Property

    Public Property SobreNome() As String
        Get
            Return fSobreNome
        End Get
        Set(ByVal Value As String)
            fSobreNome = Value
        End Set
    End Property

    Public Property Nome() As String
        Get
            Return fNome
        End Get
        Set(ByVal Value As String)
            fNome = Value
        End Set
    End Property

    Public Property Idade() As Integer
        Get
            Return fIdade
        End Get
        Set(ByVal Value As Integer)
            fIdade = Value
        End Set
    End Property

    Public Property Status() As Integer
        Get
            Return fStatus
        End Get
        Set(ByVal Value As Integer)
            If Value > 5 Or Value < 1 Then
                RaiseEvent EventoErro("status")
            Else
                fStatus = Value
            End If
        End Set
    End Property

    Public MustOverride Function CalculaSalario() As Double
End Class
