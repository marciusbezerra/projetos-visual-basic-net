
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized

    End Sub

#End Region

    Private WithEvents ds As DataSet
    Private WithEvents dg As DataGrid

    Private Sub InicializaObjetos()
        dg = New DataGrid
        dg.Dock = DockStyle.Fill
        dg.CaptionText = "Relacionamento Fornecedores/Produtos"
        Text = "VB.NET - Usando relacionamentos dinâmicos com um DataSet"

        'Para enfeitar
        Dim st As New StatusBar

        Controls.Add(st)
        Controls.Add(dg)
        Conectar()
        'dg.SetDataBinding(ds, "Fornecedores")
        dg.DataSource = ds.Tables("Fornecedores")
    End Sub

    Private Sub Conectar()
        Try
            Dim strConn As String = "Provider=Microsoft.Jet.OLEDB.4.0;" & _
                "Data Source=c:\Arquivos de programas\Microsoft Office\Office\Samples\Northwind.mdb"
            Dim Conn As New OleDbConnection(strConn)
            'CÓDIGO ADICIONAL DO MACORATTI *****
            'Dim daFornecedores As OleDbDataAdapter = New OleDbDataAdapter

            'daFornecedores.TableMappings.Add("Table", "Fornecedores")
            'Conn.Open()
            'Dim CmdFornecedores As OleDbCommand = New OleDbCommand("SELECT * FROM Fornecedores", Conn)
            'CmdFornecedores.CommandType = CommandType.Text
            'daFornecedores.SelectCommand = CmdFornecedores
            'ds = New DataSet("Fornecedores")

            'Dim daProdutos As OleDbDataAdapter = New OleDbDataAdapter

            'daProdutos.TableMappings.Add("Table", "Produtos")
            'Dim CmdProdutos As OleDbCommand = New OleDbCommand("SELECT * FROM Produtos", Conn)
            'daProdutos.SelectCommand = CmdProdutos
            'daProdutos.Fill(ds)
            '***********************************

            'MEU CÓDIGO SIMPLIFICADO ***********
            Dim daFornecedores As New OleDbDataAdapter("SELECT * FROM Fornecedores", Conn)
            Dim daProdutos As New OleDbDataAdapter("SELECT * FROM Produtos", Conn)
            ds = New DataSet
            Conn.Open()
            daFornecedores.Fill(ds, "Fornecedores")
            daProdutos.Fill(ds, "Produtos")
            '***********************************
            Conn.Close()
            Dim Relacao As DataRelation
            Dim dc1 As DataColumn
            Dim dc2 As DataColumn
            dc1 = ds.Tables("Fornecedores").Columns("CódigoDoFornecedor")
            dc2 = ds.Tables("Produtos").Columns("CódigoDoFornecedor")
            Relacao = New DataRelation("Produtos do fornecedor", dc1, dc2)
            ds.Relations.Add(Relacao)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Text)
        End Try
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InicializaObjetos()
    End Sub
End Class
