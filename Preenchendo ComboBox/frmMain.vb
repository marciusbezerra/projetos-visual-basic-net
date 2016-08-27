
Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class frmMain
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mnuMain As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents btnVetor As System.Windows.Forms.Button
    Friend WithEvents btnLista As System.Windows.Forms.Button
    Friend WithEvents btnListaAvancada As System.Windows.Forms.Button
    Friend WithEvents btnDataSet As System.Windows.Forms.Button
    Friend WithEvents btnDataView As System.Windows.Forms.Button
    Friend WithEvents cmbLista As System.Windows.Forms.ComboBox
    Friend WithEvents grpOrigem As System.Windows.Forms.GroupBox
    Friend WithEvents grpAssociado As System.Windows.Forms.GroupBox
    Friend WithEvents lblOrigem As System.Windows.Forms.Label
    Friend WithEvents lblAssociado As System.Windows.Forms.Label
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmbLista = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnVetor = New System.Windows.Forms.Button
        Me.btnLista = New System.Windows.Forms.Button
        Me.btnListaAvancada = New System.Windows.Forms.Button
        Me.btnDataSet = New System.Windows.Forms.Button
        Me.btnDataView = New System.Windows.Forms.Button
        Me.grpOrigem = New System.Windows.Forms.GroupBox
        Me.grpAssociado = New System.Windows.Forms.GroupBox
        Me.mnuMain = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.lblOrigem = New System.Windows.Forms.Label
        Me.lblAssociado = New System.Windows.Forms.Label
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.grpOrigem.SuspendLayout()
        Me.grpAssociado.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbLista
        '
        Me.cmbLista.Location = New System.Drawing.Point(16, 24)
        Me.cmbLista.Name = "cmbLista"
        Me.cmbLista.Size = New System.Drawing.Size(168, 21)
        Me.cmbLista.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(352, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Preenchendo ComboBox usando um dos seguintes métodos:"
        '
        'btnVetor
        '
        Me.btnVetor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVetor.Location = New System.Drawing.Point(16, 104)
        Me.btnVetor.Name = "btnVetor"
        Me.btnVetor.Size = New System.Drawing.Size(152, 24)
        Me.btnVetor.TabIndex = 2
        Me.btnVetor.Text = "&Vetor"
        '
        'btnLista
        '
        Me.btnLista.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLista.Location = New System.Drawing.Point(16, 136)
        Me.btnLista.Name = "btnLista"
        Me.btnLista.Size = New System.Drawing.Size(152, 24)
        Me.btnLista.TabIndex = 3
        Me.btnLista.Text = "&Lista"
        '
        'btnListaAvancada
        '
        Me.btnListaAvancada.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnListaAvancada.Location = New System.Drawing.Point(16, 168)
        Me.btnListaAvancada.Name = "btnListaAvancada"
        Me.btnListaAvancada.Size = New System.Drawing.Size(152, 24)
        Me.btnListaAvancada.TabIndex = 4
        Me.btnListaAvancada.Text = "Lista &avançada"
        '
        'btnDataSet
        '
        Me.btnDataSet.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDataSet.Location = New System.Drawing.Point(16, 200)
        Me.btnDataSet.Name = "btnDataSet"
        Me.btnDataSet.Size = New System.Drawing.Size(152, 24)
        Me.btnDataSet.TabIndex = 5
        Me.btnDataSet.Text = "&DataSet"
        '
        'btnDataView
        '
        Me.btnDataView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDataView.Location = New System.Drawing.Point(16, 232)
        Me.btnDataView.Name = "btnDataView"
        Me.btnDataView.Size = New System.Drawing.Size(152, 24)
        Me.btnDataView.TabIndex = 6
        Me.btnDataView.Text = "Da&taView"
        '
        'grpOrigem
        '
        Me.grpOrigem.Controls.Add(Me.lblOrigem)
        Me.grpOrigem.Location = New System.Drawing.Point(200, 112)
        Me.grpOrigem.Name = "grpOrigem"
        Me.grpOrigem.Size = New System.Drawing.Size(232, 48)
        Me.grpOrigem.TabIndex = 7
        Me.grpOrigem.TabStop = False
        Me.grpOrigem.Text = "Origem dos dados"
        '
        'grpAssociado
        '
        Me.grpAssociado.Controls.Add(Me.lblAssociado)
        Me.grpAssociado.Location = New System.Drawing.Point(200, 168)
        Me.grpAssociado.Name = "grpAssociado"
        Me.grpAssociado.Size = New System.Drawing.Size(232, 48)
        Me.grpAssociado.TabIndex = 8
        Me.grpAssociado.TabStop = False
        Me.grpAssociado.Text = "Valor associado"
        '
        'mnuMain
        '
        Me.mnuMain.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2})
        Me.MenuItem1.Text = "&Arquivo"
        '
        'lblOrigem
        '
        Me.lblOrigem.Location = New System.Drawing.Point(8, 16)
        Me.lblOrigem.Name = "lblOrigem"
        Me.lblOrigem.Size = New System.Drawing.Size(216, 24)
        Me.lblOrigem.TabIndex = 10
        '
        'lblAssociado
        '
        Me.lblAssociado.Location = New System.Drawing.Point(8, 16)
        Me.lblAssociado.Name = "lblAssociado"
        Me.lblAssociado.Size = New System.Drawing.Size(216, 24)
        Me.lblAssociado.TabIndex = 0
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "Sai&r"
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(448, 273)
        Me.Controls.Add(Me.grpAssociado)
        Me.Controls.Add(Me.grpOrigem)
        Me.Controls.Add(Me.btnDataView)
        Me.Controls.Add(Me.btnDataSet)
        Me.Controls.Add(Me.btnListaAvancada)
        Me.Controls.Add(Me.btnLista)
        Me.Controls.Add(Me.btnVetor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbLista)
        Me.Menu = Me.mnuMain
        Me.Name = "frmMain"
        Me.Text = "VB.NET - Preenchendo uma ComboBox"
        Me.grpOrigem.ResumeLayout(False)
        Me.grpAssociado.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Const SQL_CONEXAO_STRING As String = "Server=localhost;" & _
        "Database=Northwind;Integrated Security=SSPI"
    Private Const MSDE_CONEXAO_STRING As String = "Server=(local)\NetSDK;" & _
        "Database=Northwind;Integrated Security=SSPI"
    Private Const OLEDB_CONEXAO_STRING As String = "Provider=Microsoft.Jet.OLEDB.4.0;" & _
        "Data Source=""c:\Arquivos de programas\Microsoft Office\Office\Samples\Northwind.mdb"""
    Private Const TEXTO_TITULO As String = "Vincular dados a ComboBox"
    Private Const ORDEM_PADRAO As String = "NomeDoProduto ASC"
    Private Const ESTILO_MSG As MsgBoxStyle = _
        CType(MsgBoxStyle.Information Or MsgBoxStyle.OKOnly, MsgBoxStyle)
    Private Const NOME_TABELA_PRODUTOS As String = "Produtos"

    Private dsProdutos As New DataSet(NOME_TABELA_PRODUTOS)
    Dim dvProdutos As DataView

    Protected Structure Regioes
        Private NomeRegiao As String
        Private CodigoRegiao As Integer
        Public Sub New(ByVal Nome As String, ByVal Codigo As String)
            NomeRegiao = Nome
            CodigoRegiao = Codigo
        End Sub
        Public ReadOnly Property PegaNome() As String
            Get
                Return NomeRegiao
            End Get
        End Property
        Public ReadOnly Property PegaCodigo() As Integer
            Get
                Return CodigoRegiao
            End Get
        End Property
    End Structure

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim strConexao As String = OLEDB_CONEXAO_STRING
        Dim frmStatusMensagem As New frmStatus
        frmStatusMensagem.Show("Efetuando a conexão ao banco de dados...")
        Dim EstaConectando As Boolean = True
        While EstaConectando
            Try
                Dim Conn As New OleDbConnection(strConexao)
                Dim daProdutos As New OleDbDataAdapter("SELECT * FROM " & _
                    NOME_TABELA_PRODUTOS, Conn)
                'daProdutos.FillSchema(dsProdutos, SchemaType.Mapped)
                daProdutos.Fill(dsProdutos, NOME_TABELA_PRODUTOS)
                dvProdutos = New DataView(dsProdutos.Tables(NOME_TABELA_PRODUTOS), _
                    "", ORDEM_PADRAO, DataViewRowState.OriginalRows)
                EstaConectando = False
            Catch ex As Exception
                If strConexao = SQL_CONEXAO_STRING Then
                    strConexao = MSDE_CONEXAO_STRING
                    frmStatusMensagem.Show("Tentando conectar ao MSDE...")
                Else
                    frmStatusMensagem.Close()
                    MsgBox("Para rodar este exemplo você precisa ter " & _
                    "o MSDE com o banco de dados Northwind instalado.", _
                    ESTILO_MSG, TEXTO_TITULO)
                    EstaConectando = False
                End If
            End Try
        End While
        frmStatusMensagem.Close()
        grpAssociado.Visible = False
    End Sub

    Private Sub btnVetor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVetor.Click
        Dim Meses() As String = {"Janeiro", "Fevereiro", "Março", "Abril", _
        "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", _
        "Novembro", "Dezembro"}
        cmbLista.DataSource = Meses
        cmbLista.SelectedIndex = 0
        grpAssociado.Visible = False
        lblOrigem.Text = "Vetor"
    End Sub

    Private Sub btnLista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLista.Click
        Dim Mulheres As New ArrayList
        With Mulheres
            .Add("Paula")
            .Add("Juliana")
            .Add("Nádia")
            .Add("Marcela")
            .Add("Sabrina")
        End With
        cmbLista.DataSource = Mulheres
        cmbLista.SelectedIndex = 0
        grpAssociado.Visible = False
        lblOrigem.Text = "Lista de vetores"
    End Sub

    Private Sub btnListaAvancada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListaAvancada.Click
        Dim MinhaRegiao As New ArrayList
        With MinhaRegiao
            .Add(New Regioes("Centro", 1))
            .Add(New Regioes("Sul", 2))
            .Add(New Regioes("Oeste", 3))
            .Add(New Regioes("Norte", 4))
        End With
        With cmbLista
            .DataSource = MinhaRegiao
            .DisplayMember = "PegaNome"
            .ValueMember = "PegaCodigo"
            .SelectedIndex = 0
        End With
        lblAssociado.Text = CType(cmbLista.SelectedValue, String)
        grpAssociado.Visible = True
        lblOrigem.Text = "Lista de vetores avançada"
    End Sub

    Private Sub btnDataSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDataSet.Click
        With cmbLista
            .DataSource = dsProdutos.Tables(NOME_TABELA_PRODUTOS)
            .DisplayMember = "NomeDoProduto"
            .ValueMember = "CódigoDoProduto"
            .SelectedIndex = 0
        End With
        lblAssociado.Text = CType(cmbLista.SelectedValue, String)
        grpAssociado.Visible = True
        lblOrigem.Text = "DataSet"
    End Sub

    Private Sub btnDataView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDataView.Click
        With cmbLista
            .DataSource = dvProdutos
            .DisplayMember = "NomeDoProduto"
            .ValueMember = "CódigoDoProduto"
            .SelectedIndex = 0
        End With
        lblAssociado.Text = CType(cmbLista.SelectedValue, String)
        grpAssociado.Visible = True
        lblOrigem.Text = "DataView"
    End Sub

    Private Sub cmbLista_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLista.SelectedIndexChanged
        If grpAssociado.Visible Then
            lblAssociado.Text = CType(cmbLista.SelectedValue, String)
        End If
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Close()
    End Sub
End Class
