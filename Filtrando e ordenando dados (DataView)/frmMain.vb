
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
    Friend WithEvents btnTitulos As System.Windows.Forms.Button
    Friend WithEvents btnAutores As System.Windows.Forms.Button
    Friend WithEvents grdTitulos As System.Windows.Forms.DataGrid
    Friend WithEvents grdAutores As System.Windows.Forms.DataGrid
    Friend WithEvents btnFiltrar As System.Windows.Forms.Button
    Friend WithEvents btnOrdenar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnTitulos = New System.Windows.Forms.Button
        Me.btnAutores = New System.Windows.Forms.Button
        Me.grdTitulos = New System.Windows.Forms.DataGrid
        Me.grdAutores = New System.Windows.Forms.DataGrid
        Me.btnFiltrar = New System.Windows.Forms.Button
        Me.btnOrdenar = New System.Windows.Forms.Button
        CType(Me.grdTitulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdAutores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTitulos
        '
        Me.btnTitulos.Location = New System.Drawing.Point(368, 400)
        Me.btnTitulos.Name = "btnTitulos"
        Me.btnTitulos.Size = New System.Drawing.Size(200, 24)
        Me.btnTitulos.TabIndex = 7
        Me.btnTitulos.Text = "&Titulos"
        '
        'btnAutores
        '
        Me.btnAutores.Location = New System.Drawing.Point(8, 400)
        Me.btnAutores.Name = "btnAutores"
        Me.btnAutores.Size = New System.Drawing.Size(200, 24)
        Me.btnAutores.TabIndex = 6
        Me.btnAutores.Text = "&Autores"
        '
        'grdTitulos
        '
        Me.grdTitulos.CaptionText = "LISTAGEM DE TÍTULOS"
        Me.grdTitulos.DataMember = ""
        Me.grdTitulos.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdTitulos.Location = New System.Drawing.Point(368, 8)
        Me.grdTitulos.Name = "grdTitulos"
        Me.grdTitulos.Size = New System.Drawing.Size(352, 384)
        Me.grdTitulos.TabIndex = 5
        '
        'grdAutores
        '
        Me.grdAutores.CaptionText = "LISTAGEM DE AUTORES"
        Me.grdAutores.DataMember = ""
        Me.grdAutores.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdAutores.Location = New System.Drawing.Point(8, 8)
        Me.grdAutores.Name = "grdAutores"
        Me.grdAutores.Size = New System.Drawing.Size(352, 384)
        Me.grdAutores.TabIndex = 4
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Location = New System.Drawing.Point(216, 400)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(144, 24)
        Me.btnFiltrar.TabIndex = 8
        Me.btnFiltrar.Text = "&Filtrar dados"
        '
        'btnOrdenar
        '
        Me.btnOrdenar.Location = New System.Drawing.Point(576, 400)
        Me.btnOrdenar.Name = "btnOrdenar"
        Me.btnOrdenar.Size = New System.Drawing.Size(144, 24)
        Me.btnOrdenar.TabIndex = 9
        Me.btnOrdenar.Text = "&Ordenar"
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(728, 438)
        Me.Controls.Add(Me.btnOrdenar)
        Me.Controls.Add(Me.btnFiltrar)
        Me.Controls.Add(Me.btnTitulos)
        Me.Controls.Add(Me.btnAutores)
        Me.Controls.Add(Me.grdTitulos)
        Me.Controls.Add(Me.grdAutores)
        Me.Name = "frmMain"
        Me.Text = "VB.NET - Filtrando e ordenando dados com o DataView"
        CType(Me.grdTitulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdAutores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim strConn As String = "Provider=Microsoft.Jet.OLEDB.4.0;" & _
        "Data Source=c:\Arquivos de programas\Microsoft Visual Studio\VB98\BIBLIO.MDB"
    Dim SQL1 As String = "SELECT * FROM Authors"
    Dim SQL2 As String = "SELECT * FROM Titles"
    Dim da1 As New OleDbDataAdapter(SQL1, strConn)
    Dim da2 As New OleDbDataAdapter(SQL2, strConn)
    Dim ds As New DataSet

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAutores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAutores.Click
        If ds.Tables.IndexOf("Autores") <> -1 Then
            ds.Tables.Remove("Autores")
        End If
        da1.Fill(ds, "Autores")
        grdAutores.DataSource = ds.Tables("Autores").DefaultView
    End Sub

    Private Sub btnTitulos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTitulos.Click
        If ds.Tables.IndexOf("Títulos") <> -1 Then
            ds.Tables.Remove("Títulos")
        End If
        da2.Fill(ds, "Títulos")
        grdTitulos.DataSource = ds
        grdTitulos.DataMember = "Títulos"
    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click
        Dim dv As DataView = New DataView(ds.Tables("Autores"))
        dv.RowFilter = "au_id <= 15"
        grdAutores.DataSource = dv
    End Sub

    Private Sub btnOrdenar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrdenar.Click
        Dim dv As New DataView(ds.Tables("Títulos"))
        dv.Sort = "Title"
        grdTitulos.DataSource = dv
    End Sub
End Class
