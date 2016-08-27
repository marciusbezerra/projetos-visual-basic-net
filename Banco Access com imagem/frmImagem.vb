Public Class frmImagem
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
    Friend WithEvents txtArquivo As System.Windows.Forms.TextBox
    Friend WithEvents llAbrirArquivo As System.Windows.Forms.LinkLabel
    Friend WithEvents btnInsere As System.Windows.Forms.Button
    Friend WithEvents OD As System.Windows.Forms.OpenFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtArquivo = New System.Windows.Forms.TextBox
        Me.llAbrirArquivo = New System.Windows.Forms.LinkLabel
        Me.btnInsere = New System.Windows.Forms.Button
        Me.OD = New System.Windows.Forms.OpenFileDialog
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome do arquivo:"
        '
        'txtArquivo
        '
        Me.txtArquivo.Location = New System.Drawing.Point(8, 32)
        Me.txtArquivo.Name = "txtArquivo"
        Me.txtArquivo.Size = New System.Drawing.Size(416, 20)
        Me.txtArquivo.TabIndex = 1
        Me.txtArquivo.Text = ""
        '
        'llAbrirArquivo
        '
        Me.llAbrirArquivo.AutoSize = True
        Me.llAbrirArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.llAbrirArquivo.Location = New System.Drawing.Point(432, 32)
        Me.llAbrirArquivo.Name = "llAbrirArquivo"
        Me.llAbrirArquivo.Size = New System.Drawing.Size(14, 16)
        Me.llAbrirArquivo.TabIndex = 2
        Me.llAbrirArquivo.TabStop = True
        Me.llAbrirArquivo.Text = "..."
        '
        'btnInsere
        '
        Me.btnInsere.Location = New System.Drawing.Point(272, 64)
        Me.btnInsere.Name = "btnInsere"
        Me.btnInsere.Size = New System.Drawing.Size(152, 24)
        Me.btnInsere.TabIndex = 3
        Me.btnInsere.Text = "&Incluir imagem"
        '
        'OD
        '
        Me.OD.Filter = "Arquivos de imagem (*.bmp;*.jpg;*.gif)|*.bmp;*.jpg;*.gif|Qualquer arquivo (*.*)|*" & _
        ".*"
        '
        'frmImagem
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(472, 102)
        Me.Controls.Add(Me.btnInsere)
        Me.Controls.Add(Me.llAbrirArquivo)
        Me.Controls.Add(Me.txtArquivo)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmImagem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VB.NET - Inserindo imagens no banco Access"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnInsere_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsere.Click
        Dim ArqImagem As System.IO.FileStream
        'Dim LeitorImagem As System.IO.StreamReader
        Dim Conn As System.Data.OleDb.OleDbConnection
        Dim Cmd As System.Data.OleDb.OleDbCommand
        If Not System.IO.File.Exists(txtArquivo.Text.Trim) Then
            MsgBox("O nome do arquivo não foi fornecido ou o mesmo não foi localizado.", _
                MsgBoxStyle.Information)
            Exit Sub
        End If
        btnInsere.Enabled = False
        Try
            ArqImagem = New System.IO.FileStream(txtArquivo.Text.Trim, IO.FileMode.Open, _
                IO.FileAccess.Read, IO.FileShare.Read)
        Catch ex As Exception
            MsgBox("Não foi possível abrir """ & txtArquivo.Text.Trim & vbCrLf & vbCrLf & _
                ex.Message, MsgBoxStyle.Critical)
            btnInsere.Enabled = True
            Exit Sub
        End Try
        'LeitorImagem = New System.IO.StreamReader(ArqImagem)
        Try
            Dim strConn As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                Application.StartupPath & "\..\DB\Imagens.mdb"
            Dim SQL As String = "INSERT INTO Imagens(Imagem,Tamanho) values(?,?)"
            Conn = New System.Data.OleDb.OleDbConnection(strConn)
            Cmd = New System.Data.OleDb.OleDbCommand(SQL, Conn)
            Dim VetorBytes(ArqImagem.Length - 1) As Byte
            ArqImagem.Read(VetorBytes, 0, ArqImagem.Length)
            Cmd.Parameters.Add("@Imagem", OleDb.OleDbType.Binary, _
                ArqImagem.Length).Value = VetorBytes
            Cmd.Parameters.Add("@Tamanho", OleDb.OleDbType.Integer).Value = ArqImagem.Length
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message, MsgBoxStyle.Critical)
            btnInsere.Enabled = True
            Exit Sub
        End Try
        Try
            Conn.Open()
            Cmd.ExecuteNonQuery()
            MsgBox("Imagem incluída com sucesso.", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Não foi possível se conectar." & vbCrLf & vbCrLf & _
                ex.Message)
            Exit Sub
        Finally
            btnInsere.Enabled = True
            Conn.Close()
        End Try
    End Sub

    Private Sub llAbrirArquivo_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llAbrirArquivo.LinkClicked
        If OD.ShowDialog = DialogResult.OK Then
            txtArquivo.Text = OD.FileName
        End If
    End Sub
End Class
