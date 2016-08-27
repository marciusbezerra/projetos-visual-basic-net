
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
    Friend WithEvents grdAutores As System.Windows.Forms.DataGrid
    Friend WithEvents grdTitulos As System.Windows.Forms.DataGrid
    Friend WithEvents btnAutores As System.Windows.Forms.Button
    Friend WithEvents btnTitulos As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.grdAutores = New System.Windows.Forms.DataGrid
        Me.grdTitulos = New System.Windows.Forms.DataGrid
        Me.btnAutores = New System.Windows.Forms.Button
        Me.btnTitulos = New System.Windows.Forms.Button
        CType(Me.grdAutores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdTitulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdAutores
        '
        Me.grdAutores.CaptionText = "LISTAGEM DE AUTORES"
        Me.grdAutores.DataMember = ""
        Me.grdAutores.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdAutores.Location = New System.Drawing.Point(16, 16)
        Me.grdAutores.Name = "grdAutores"
        Me.grdAutores.Size = New System.Drawing.Size(352, 384)
        Me.grdAutores.TabIndex = 0
        '
        'grdTitulos
        '
        Me.grdTitulos.CaptionText = "LISTAGEM DE TÍTULOS"
        Me.grdTitulos.DataMember = ""
        Me.grdTitulos.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdTitulos.Location = New System.Drawing.Point(376, 16)
        Me.grdTitulos.Name = "grdTitulos"
        Me.grdTitulos.Size = New System.Drawing.Size(352, 384)
        Me.grdTitulos.TabIndex = 1
        '
        'btnAutores
        '
        Me.btnAutores.Location = New System.Drawing.Point(80, 416)
        Me.btnAutores.Name = "btnAutores"
        Me.btnAutores.Size = New System.Drawing.Size(200, 24)
        Me.btnAutores.TabIndex = 2
        Me.btnAutores.Text = "&Autores"
        '
        'btnTitulos
        '
        Me.btnTitulos.Location = New System.Drawing.Point(472, 416)
        Me.btnTitulos.Name = "btnTitulos"
        Me.btnTitulos.Size = New System.Drawing.Size(200, 24)
        Me.btnTitulos.TabIndex = 3
        Me.btnTitulos.Text = "&Titulos"
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(744, 462)
        Me.Controls.Add(Me.btnTitulos)
        Me.Controls.Add(Me.btnAutores)
        Me.Controls.Add(Me.grdTitulos)
        Me.Controls.Add(Me.grdAutores)
        Me.Name = "frmMain"
        Me.Text = "VB.NET - Usando vários Table em um DataSet"
        CType(Me.grdAutores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdTitulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim strConn As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
        "c:\aArquivos de programas\Microsoft Visual Studio\VB98\BIBLIO.MDB"
    Dim SQL1 As String = "SELECT * FROM Authors"
    Dim SQL2 As String = "SELECT * FROM Titles"
    Dim da1 As New OleDbDataAdapter(SQL1, strConn)
    Dim da2 As New OleDbDataAdapter(SQL2, strConn)
    Dim ds As New DataSet

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAutores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAutores.Click
        da1.Fill(ds, "Autores")
        grdAutores.DataSource = ds.Tables("Autores")
    End Sub

    Private Sub btnTitulos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTitulos.Click
        da2.Fill(ds, "Títulos")
        grdTitulos.DataSource = ds
        grdTitulos.DataMember = "Títulos"
    End Sub
End Class
