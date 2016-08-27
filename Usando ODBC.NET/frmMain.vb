
Imports System.Data.Odbc

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
    Friend WithEvents btnListar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstMusicas As System.Windows.Forms.ListBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnListar = New System.Windows.Forms.Button
        Me.lstMusicas = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnListar
        '
        Me.btnListar.Location = New System.Drawing.Point(128, 344)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(128, 24)
        Me.btnListar.TabIndex = 0
        Me.btnListar.Text = "&Listar"
        '
        'lstMusicas
        '
        Me.lstMusicas.Location = New System.Drawing.Point(8, 40)
        Me.lstMusicas.Name = "lstMusicas"
        Me.lstMusicas.Size = New System.Drawing.Size(376, 290)
        Me.lstMusicas.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Músicas:"
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(392, 382)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstMusicas)
        Me.Controls.Add(Me.btnListar)
        Me.Name = "frmMain"
        Me.Text = "VB.NET - Usando ODBC.NET"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
        Dim dr As OdbcDataReader
        Dim SQL As String = "SELECT Codigo, Faixa FROM Musicas ORDER BY Faixa"
        Dim Conn As OdbcConnection
        Dim Cmd As OdbcCommand

        Conn = New OdbcConnection("Driver={Microsoft Access Driver (*.mdb)};" & _
            "DBQ=d:\Servicos\Para o CD RW\DBs\Musicas.mdb;UID=;PWD=")
        Cmd = New OdbcCommand(SQL, Conn)
        Try
            Conn.Open()
            dr = Cmd.ExecuteReader
            While dr.Read
                lstMusicas.Items.Add(CType(dr("Faixa"), String).ToUpper)
            End While
        Catch ex As OdbcException
            MsgBox("É necessário ter o banco 'd:\Servicos\Para o CD RW\DBs\Musicas.mdb'" & _
                " no HD.", MsgBoxStyle.Critical, Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Text)
        Finally
            dr.Close()
            Conn.Close()
            Conn.Dispose()
            Conn = Nothing
        End Try
    End Sub
End Class
