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
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(8, 8)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(640, 304)
        Me.DataGrid1.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(8, 320)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(640, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "D:\Servicos\Para o CD RW\DBs\Musicas.mdb"
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(8, 344)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(640, 24)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Preencher o DataSet com o OleDbDataAdapter"
        '
        'Button2
        '
        Me.Button2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(8, 376)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(640, 24)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Preencher o DataSet com dois OleDbDataAdapter (com DataRelation)"
        '
        'Button3
        '
        Me.Button3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(8, 408)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(640, 24)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Preencher o DataSet com dois DataTables e apenas um OleDbDataAdapter"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(656, 438)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGrid1)
        Me.Name = "Form1"
        Me.Text = "Usando o DataSet"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim strConn As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & TextBox1.Text
        Dim Conn As OleDbConnection
        Dim Cmd As OleDbCommand
        Dim Adaptador As OleDbDataAdapter
        Dim dsMusicas As DataSet
        Conn = New OleDbConnection(strConn)
        Dim SQL As String = "SELECT * FROM MUSICAS ORDER BY FAIXA"
        Cmd = New OleDbCommand(SQL, Conn)
        Adaptador = New OleDbDataAdapter(Cmd)
        dsMusicas = New DataSet("Coleção de músicas")
        'Conn.Open() 'Não é necessário
        Adaptador.Fill(dsMusicas, "Musicas")
        'Conn.Close()
        DataGrid1.DataSource = dsMusicas
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim strConn As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & TextBox1.Text
        Dim Conn As OleDbConnection
        Dim Cmd As OleDbCommand
        Dim ds As DataSet
        Dim Relacao As DataRelation
        Dim sqlMusicas As String = "SELECT * FROM MUSICAS ORDER BY FAIXA"
        Dim sqlEstilos As String = "SELECT * FROM ESTILOS ORDER BY ESTILO"
        Dim daEstilos, daMusicas As OleDbDataAdapter
        Conn = New OleDbConnection(strConn)
        daMusicas = New OleDbDataAdapter(sqlMusicas, Conn)
        daEstilos = New OleDbDataAdapter(sqlEstilos, Conn)
        ds = New DataSet("Coleção de estilos e músicas")
        daMusicas.Fill(ds, "Musicas")
        daEstilos.Fill(ds, "Estilos")
        Relacao = ds.Relations.Add("EstilosMusicas", _
            ds.Tables("Estilos").Columns("Codigo"), _
            ds.Tables("Musicas").Columns("CodEtilo"))
        DataGrid1.DataSource = ds
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim strConn As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & TextBox1.Text
        Dim Conn As OleDbConnection
        Dim SQL As String = "SELECT * FROM MUSICAS ORDER BY FAIXA"
        Dim Cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim ds As DataSet
        Conn = New OleDbConnection(strConn)
        Cmd = New OleDbCommand(SQL, Conn)
        da = New OleDbDataAdapter(Cmd)
        ds = New DataSet("Coleção de músicas e estilos")
        da.Fill(ds, "Musicas")
        Cmd.CommandText = "SELECT * FROM ESTILOS ORDER BY ESTILO"
        da.Fill(ds, "Estilos")
        DataGrid1.DataSource = ds
    End Sub
End Class
