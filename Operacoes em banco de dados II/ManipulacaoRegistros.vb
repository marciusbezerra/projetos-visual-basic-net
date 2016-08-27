

Public Class ManipulacaoRegistros
    Private m_ControleContexto As ContainerControl
    Private m_Conexao As OleDb.OleDbConnection
    Private m_da As OleDb.OleDbDataAdapter
    Private m_ds As DataSet
    Private m_NomeTabela As String

    Public Event MoveuRegistro(ByVal PosicaoAtual As Integer, ByVal NumeroDeRegistros As Integer, _
    ByVal InicioDaTabela As Boolean, ByVal FimDaTabela As Boolean, ByVal StringPosicaoAtual As String)
    Public Event TabelaModificada()
    Public Event ValidaExclusao(ByVal Tabela As DataTable, ByVal BContexto As BindingManagerBase, ByRef Pode As Boolean)

    Public Property ControleContexto() As ContainerControl
        Get
            Return m_ControleContexto
        End Get
        Set(ByVal Value As ContainerControl)
            m_ControleContexto = Value
        End Set
    End Property

    Public Property Conexao() As OleDb.OleDbConnection
        Get
            Return m_Conexao
        End Get
        Set(ByVal Value As OleDb.OleDbConnection)
            m_Conexao = Value
        End Set
    End Property

    Public Property da() As OleDb.OleDbDataAdapter
        Get
            Return m_da
        End Get
        Set(ByVal Value As OleDb.OleDbDataAdapter)
            m_da = Value
        End Set
    End Property

    Public Property ds() As DataSet
        Get
            Return m_ds
        End Get
        Set(ByVal Value As DataSet)
            m_ds = Value
        End Set
    End Property

    Public Property NomeTabela() As String
        Get
            Return m_NomeTabela
        End Get
        Set(ByVal Value As String)
            m_NomeTabela = Value.Trim
        End Set
    End Property

    Public ReadOnly Property PosicaoAtual() As Integer
        Get
            Dim Cont, Pos As Integer
            Cont = Me.NumeroDeRegistros
            If Cont = 0 Then
                Return 0
            Else
                Return m_ControleContexto.BindingContext(m_ds, m_NomeTabela).Position + 1
            End If
        End Get
    End Property

    Public ReadOnly Property NumeroDeRegistros() As Integer
        Get
            Return m_ControleContexto.BindingContext(m_ds, m_NomeTabela).Count
        End Get
    End Property

    Public ReadOnly Property StringPosicaoAtual() As String
        Get
            If Me.TabelaVazia Then
                Return "(Nenhum registro)"
            Else
                Return "Registro " & Format(Me.PosicaoAtual, "##,###,###,##0") & " de " & _
                    Format(Me.NumeroDeRegistros, "##,###,###,##0")
            End If
        End Get
    End Property

    Public ReadOnly Property TabelaVazia() As Boolean
        Get
            Return (NumeroDeRegistros = 0)
        End Get
    End Property

    Public ReadOnly Property InicioDaTabela() As Boolean
        Get
            Return (Me.PosicaoAtual <= 1)
        End Get
    End Property

    Public ReadOnly Property FimDaTabela() As Boolean
        Get
            Return (Me.PosicaoAtual = Me.NumeroDeRegistros)
        End Get
    End Property

    Public Sub CarregaDados()
        m_Conexao.Open()
        m_ds.EnforceConstraints = False
        Try
            If m_NomeTabela = "" Then
                m_da.Fill(m_ds)
            Else
                m_da.Fill(m_ds, m_NomeTabela)
            End If
            RaiseEvent MoveuRegistro(Me.PosicaoAtual, Me.NumeroDeRegistros, Me.InicioDaTabela, _
                Me.FimDaTabela, Me.StringPosicaoAtual)
        Finally
            m_ds.EnforceConstraints = True
            m_Conexao.Close()
        End Try
    End Sub

    Public Sub Primeiro()
        m_ControleContexto.BindingContext(m_ds, m_NomeTabela).Position = 0
        RaiseEvent MoveuRegistro(Me.PosicaoAtual, Me.NumeroDeRegistros, Me.InicioDaTabela, _
            Me.FimDaTabela, Me.StringPosicaoAtual)
    End Sub

    Public Sub Anterior()
        m_ControleContexto.BindingContext(m_ds, m_NomeTabela).Position -= 1
        RaiseEvent MoveuRegistro(Me.PosicaoAtual, Me.NumeroDeRegistros, Me.InicioDaTabela, _
            Me.FimDaTabela, Me.StringPosicaoAtual)
    End Sub

    Public Sub Proximo()
        m_ControleContexto.BindingContext(m_ds, m_NomeTabela).Position += 1
        RaiseEvent MoveuRegistro(Me.PosicaoAtual, Me.NumeroDeRegistros, Me.InicioDaTabela, _
            Me.FimDaTabela, Me.StringPosicaoAtual)
    End Sub

    Public Sub Ultimo()
        m_ControleContexto.BindingContext(m_ds, m_NomeTabela).Position = _
            Me.NumeroDeRegistros - 1
        RaiseEvent MoveuRegistro(Me.PosicaoAtual, Me.NumeroDeRegistros, Me.InicioDaTabela, _
            Me.FimDaTabela, Me.StringPosicaoAtual)
    End Sub

    Public Sub Remover()
        Dim Pode As Boolean
        Dim Tabela As BindingManagerBase
        If Me.NumeroDeRegistros > 0 Then
            Pode = True
            Tabela = m_ControleContexto.BindingContext(m_ds, m_NomeTabela)
            RaiseEvent ValidaExclusao(m_ds.Tables(m_NomeTabela), Tabela, Pode)
            If Pode Then
                Tabela.RemoveAt(Tabela.Position)
                RaiseEvent TabelaModificada()
                RaiseEvent MoveuRegistro(Me.PosicaoAtual, Me.NumeroDeRegistros, _
                    Me.InicioDaTabela, Me.FimDaTabela, Me.StringPosicaoAtual)
            End If
        End If
    End Sub

    Public Sub Adicionar()
        m_ControleContexto.BindingContext(m_ds, m_NomeTabela).EndCurrentEdit()
        m_ControleContexto.BindingContext(m_ds, m_NomeTabela).AddNew()
    End Sub

    Public Sub Cancelar()
        m_ControleContexto.BindingContext(m_ds, m_NomeTabela).CancelCurrentEdit()
        RaiseEvent MoveuRegistro(Me.PosicaoAtual, Me.NumeroDeRegistros, _
            Me.InicioDaTabela, Me.FimDaTabela, Me.StringPosicaoAtual)
    End Sub

    Public Sub RejeitarTodasAsModificacoes()
        m_ds.RejectChanges()
        RaiseEvent MoveuRegistro(Me.PosicaoAtual, Me.NumeroDeRegistros, _
            Me.InicioDaTabela, Me.FimDaTabela, Me.StringPosicaoAtual)
    End Sub

    Public Function AplicarTodasAsModificoes() As Integer
        Dim dsAlterados As DataSet = New DataSet
        m_ControleContexto.BindingContext(m_ds, m_NomeTabela).EndCurrentEdit()
        dsAlterados = m_ds.GetChanges
        If Not dsAlterados Is Nothing Then
            Conexao.Open()
            Try
                Dim dsModificados As DataSet
                Dim dsAdicionados As DataSet
                Dim dsDeletados As DataSet
                Dim RegistrosAfetados As Integer = 0
                dsModificados = dsAlterados.GetChanges(DataRowState.Modified)
                dsAdicionados = dsAlterados.GetChanges(DataRowState.Added)
                dsDeletados = dsAlterados.GetChanges(DataRowState.Deleted)
                If Not dsModificados Is Nothing Then
                    RegistrosAfetados = m_da.Update(dsModificados)
                End If
                If Not dsAdicionados Is Nothing Then
                    RegistrosAfetados += m_da.Update(dsAdicionados)
                End If
                If Not dsDeletados Is Nothing Then
                    RegistrosAfetados += m_da.Update(dsDeletados)
                End If
                m_ds.Merge(dsAlterados)
                m_ds.AcceptChanges()
                RaiseEvent MoveuRegistro(Me.PosicaoAtual, Me.NumeroDeRegistros, _
                    Me.InicioDaTabela, Me.FimDaTabela, Me.StringPosicaoAtual)
                Return RegistrosAfetados
            Finally
                Conexao.Close()
            End Try
        End If
    End Function
End Class
