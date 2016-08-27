
Friend Structure Clientes
    Friend Nome As String
    Friend Telefone As String
End Structure

Friend Class ClasseClientes
    Protected Codigo As Integer
    Protected Nome As String
    Protected Telefone As String
    Friend Sub New()

    End Sub
    Friend Sub New(ByVal Codigo As Integer, ByVal Nome As String, _
        ByVal Telefone As String)
        Me.ClienteCodigo = Codigo
        Me.ClienteNome = Nome
        Me.ClienteTelefone = Telefone
    End Sub
    Public Property ClienteCodigo() As Integer
        Get
            ClienteCodigo = Me.Codigo
        End Get
        Set(ByVal Value As Integer)
            If Value < 100 Then
                MsgBox("Valor menor que 100.", MsgBoxStyle.Critical)
            Else
                Me.Codigo = Value
            End If
        End Set
    End Property
    Public Property ClienteNome() As String
        Get
            ClienteNome = Me.Nome
        End Get
        Set(ByVal Value As String)
            Me.Nome = Value
        End Set
    End Property
    Public Property ClienteTelefone() As String
        Get
            ClienteTelefone = Me.Telefone
        End Get
        Set(ByVal Value As String)
            Me.Telefone = Value
        End Set
    End Property
    Public Sub Mostrar()
        Dim Msg As String
        Msg = "Código: " & Codigo.ToString & vbCrLf
        Msg += "Nome: " & Nome & vbCrLf
        Msg += "Telefone: " & Telefone
        MsgBox(Msg, MsgBoxStyle.Information, Me.GetType.ToString)
    End Sub
    Public Shared Sub SubSemNecessidadeDeInstancia()
        MsgBox("Esta Sub não precisou instância.", MsgBoxStyle.Information)
    End Sub
End Class

Friend Class ClienteAssociado
    Inherits ClasseClientes


    Private NumeroDaAssociacao As Integer

    Public Overloads Sub Mostrar()
        Dim Msg As String
        Msg = "Código: " & Codigo.ToString & vbCrLf
        Msg += "Nome: " & Nome & vbCrLf
        Msg += "Telefone: " & Telefone & vbCrLf
        Msg += "Núm. Associação: " & Me.NumeroDaAssociacao.ToString
        MsgBox(Msg, MsgBoxStyle.Information, Me.GetType.ToString)
    End Sub

    Public Property ClienteNumAssociacao() As Integer
        Get
            ClienteNumAssociacao = Me.NumeroDaAssociacao
        End Get
        Set(ByVal Value As Integer)
            Me.NumeroDaAssociacao = Value
        End Set
    End Property

End Class

Module ModuloOOP
    Sub Main()
        Dim Msg As String
        Dim Paulo As Clientes
        Paulo.Nome = "Paulo da silva"
        Paulo.Telefone = "99-99999"
        Msg = "Nome: " & Paulo.Nome & vbCrLf
        Msg += "Telefone: " & Paulo.Telefone
        MsgBox(Msg, MsgBoxStyle.Information)

        Dim aa As New ClasseClientes(1, "Paula da Silva", "12-333333")
        aa.Mostrar()

        Dim bb As New ClasseClientes
        bb.ClienteCodigo = 2
        bb.ClienteNome = "Antônia Lima"
        bb.ClienteTelefone = "88-76777"
        bb.Mostrar()

        Dim CliAssociado As New ClienteAssociado
        With CliAssociado
            .ClienteCodigo = 120
            .ClienteNome = "Marcius Herdado"
            .ClienteNumAssociacao = 10
            .ClienteTelefone = "222-44444"
            .Mostrar()
        End With

        ClasseClientes.SubSemNecessidadeDeInstancia()
    End Sub

End Module
