Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class Form1
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(8, 392)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(584, 32)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Preenchar com DataRelation entre diferentes fontes de dados (OleDb e SqlClient)"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(8, 8)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(584, 376)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGrid1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(576, 350)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Visão em DataTable"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TextBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(576, 350)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Visão em texto"
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(0, 0)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(576, 350)
        Me.DataGrid1.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(576, 350)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "TextBox1"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(600, 430)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Relacionamento entre diferentes bancos"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Const STR_CONN_SQL As String = "Data Source=localhost;User ID=sa;Password=manager;Initial Catalog=NorthwindCS"
    Private Const STR_CONN_ACCESS As String = "Provider=Microsoft.Jet.OLEDB.4.0;User ID=Admin;Data Source=C:\Arquivos de programas\Microsoft Office\Office\Samples\Northwind.mdb;Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False"

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim connAcess As OleDbConnection = New OleDbConnection(STR_CONN_ACCESS)
        Dim connSQL As SqlConnection = New SqlConnection(STR_CONN_SQL)
        Dim ds As DataSet = New DataSet("Relação entre bancos")
        Dim daClientes As SqlDataAdapter
        Dim daPedidos As OleDbDataAdapter
        Dim Relacao As DataRelation
        daPedidos = New OleDbDataAdapter("SELECT * FROM Pedidos ORDER BY DataDeEnvio", connAcess)
        daClientes = New SqlDataAdapter("SELECT * FROM Customers ORDER BY CompanyName", connSQL)
        daClientes.Fill(ds, "Clientes")
        daPedidos.Fill(ds, "Pedidos")
        Relacao = ds.Relations.Add("Pedidos do cliente", _
            ds.Tables("Clientes").Columns("CustomerID"), _
            ds.Tables("Pedidos").Columns("CódigoDoCliente"))
        DataGrid1.DataSource = ds
        Dim cliRow, pedRow As DataRow
        TextBox1.Clear()
        For Each cliRow In ds.Tables("Clientes").Rows
            TextBox1.Text &= cliRow("CompanyName").ToString().ToUpper & " - " & cliRow("ContactName").ToString().ToUpper & vbCrLf
            For Each pedRow In cliRow.GetChildRows(Relacao)
                TextBox1.Text &= vbTab & pedRow("DataDoPedido").ToString.ToUpper & " " & _
                                        pedRow("DataDeEnvio").ToString.ToUpper & " " & _
                                        pedRow("NomeDoDestinatário").ToString.ToUpper & " " & _
                                        pedRow("CidadeDeDestino").ToString.ToUpper & vbCrLf
            Next
        Next
    End Sub

    Private Sub DataGrid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DataGrid1.Navigate

    End Sub
End Class
