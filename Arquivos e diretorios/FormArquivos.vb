
Imports System.IO

Public Class FormArquivos
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCamNome As System.Windows.Forms.TextBox
    Friend WithEvents btnCriaDir As System.Windows.Forms.Button
    Friend WithEvents btnExcluiDir As System.Windows.Forms.Button
    Friend WithEvents btnExibeCon As System.Windows.Forms.Button
    Friend WithEvents btnMostraAtt As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents lstArqs As System.Windows.Forms.ListBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCamNome = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnCriaDir = New System.Windows.Forms.Button
        Me.btnExcluiDir = New System.Windows.Forms.Button
        Me.btnExibeCon = New System.Windows.Forms.Button
        Me.btnMostraAtt = New System.Windows.Forms.Button
        Me.btnSair = New System.Windows.Forms.Button
        Me.lstArqs = New System.Windows.Forms.ListBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Caminho e nome:"
        '
        'txtCamNome
        '
        Me.txtCamNome.Location = New System.Drawing.Point(96, 24)
        Me.txtCamNome.Name = "txtCamNome"
        Me.txtCamNome.Size = New System.Drawing.Size(304, 20)
        Me.txtCamNome.TabIndex = 1
        Me.txtCamNome.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstArqs)
        Me.GroupBox1.Controls.Add(Me.btnMostraAtt)
        Me.GroupBox1.Controls.Add(Me.btnExibeCon)
        Me.GroupBox1.Controls.Add(Me.btnExcluiDir)
        Me.GroupBox1.Controls.Add(Me.btnCriaDir)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(392, 176)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "VB.NET - Operações com arquivos"
        '
        'btnCriaDir
        '
        Me.btnCriaDir.Location = New System.Drawing.Point(8, 32)
        Me.btnCriaDir.Name = "btnCriaDir"
        Me.btnCriaDir.Size = New System.Drawing.Size(104, 24)
        Me.btnCriaDir.TabIndex = 0
        Me.btnCriaDir.Text = "&Criar diretório"
        '
        'btnExcluiDir
        '
        Me.btnExcluiDir.Location = New System.Drawing.Point(8, 66)
        Me.btnExcluiDir.Name = "btnExcluiDir"
        Me.btnExcluiDir.Size = New System.Drawing.Size(104, 24)
        Me.btnExcluiDir.TabIndex = 1
        Me.btnExcluiDir.Text = "&Excluir diretório"
        '
        'btnExibeCon
        '
        Me.btnExibeCon.Location = New System.Drawing.Point(8, 100)
        Me.btnExibeCon.Name = "btnExibeCon"
        Me.btnExibeCon.Size = New System.Drawing.Size(104, 24)
        Me.btnExibeCon.TabIndex = 2
        Me.btnExibeCon.Text = "E&xibe conteúdo"
        '
        'btnMostraAtt
        '
        Me.btnMostraAtt.Location = New System.Drawing.Point(8, 134)
        Me.btnMostraAtt.Name = "btnMostraAtt"
        Me.btnMostraAtt.Size = New System.Drawing.Size(104, 24)
        Me.btnMostraAtt.TabIndex = 3
        Me.btnMostraAtt.Text = "&Mostrar atributos"
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(304, 240)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(96, 24)
        Me.btnSair.TabIndex = 3
        Me.btnSair.Text = "&Sair"
        '
        'lstArqs
        '
        Me.lstArqs.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstArqs.ItemHeight = 14
        Me.lstArqs.Location = New System.Drawing.Point(120, 24)
        Me.lstArqs.Name = "lstArqs"
        Me.lstArqs.Size = New System.Drawing.Size(264, 144)
        Me.lstArqs.TabIndex = 4
        '
        'FormArquivos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(408, 270)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtCamNome)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormArquivos"
        Me.Text = "VB.NET - Operações com arquivos"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnCriaDir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCriaDir.Click
        If txtCamNome.Text.Trim <> "" Then
            Try
                Directory.CreateDirectory(txtCamNome.Text.Trim)
                MsgBox("O diretório """ & txtCamNome.Text.Trim & """ foi criado!", _
                    MsgBoxStyle.Information, Text)
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                txtCamNome.Focus()
            End Try
        Else
                MsgBox("Informe o caminho do diretório a ser criado.", MsgBoxStyle.Information, Text)
        End If
    End Sub

    Private Sub btnExcluiDir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluiDir.Click
        If txtCamNome.Text.Trim <> "" Then
            If Directory.Exists(txtCamNome.Text.Trim) Then
                Try
                    Directory.Delete(txtCamNome.Text.Trim)
                    MsgBox("O diretório """ & txtCamNome.Text.Trim & """ foi excluído.", _
                        MsgBoxStyle.Information, Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    txtCamNome.Focus()
                End Try
            Else
                MsgBox("O diretório informado não foi encontrado.", _
                    MsgBoxStyle.Information, Text)
            End If
        Else
            MsgBox("Informe o diretório a ser excluído.", _
                MsgBoxStyle.Information, Text)
            txtCamNome.Focus()
        End If
    End Sub

    Private Sub btnExibeCon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExibeCon.Click
        Dim NomeArq, SubDir As String
        If txtCamNome.Text.Trim <> "" Then
            Dim Msg, Titulo, Valor, objValor As String
            Try
                Msg = "Informe a extensão do arquivo (*.exe, por exemplo)"
                Titulo = "Listar arquivos"
                Valor = "*.exe"
                objValor = InputBox(Msg, Titulo, Valor, 200, 200)
                lstArqs.Items.Clear()
                lstArqs.Items.Add(New String(txtCamNome.Text.Trim))
                For Each NomeArq In Directory.GetFiles(txtCamNome.Text.Trim, objValor)
                    lstArqs.Items.Add(New String(NomeArq))
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
                MsgBox("Informe o caminho a ser listado.", _
                    MsgBoxStyle.Information, Text)
        End If
    End Sub

    Private Sub btnMostraAtt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostraAtt.Click
        Dim NomeArq As String
        If txtCamNome.Text.Trim <> "" Then
            If File.Exists(txtCamNome.Text.Trim) Then
                Try
                    Dim InfoArq As FileVersionInfo = _
                        FileVersionInfo.GetVersionInfo(txtCamNome.Text.Trim)
                    With lstArqs
                        .Items.Clear()
                        .Items.Add(New String(txtCamNome.Text.Trim))
                        .Items.Add(New String("Data de criação.: " & File.GetCreationTime(txtCamNome.Text.Trim)))
                        .Items.Add(New String("Último acesso...: " & File.GetLastAccessTime(txtCamNome.Text.Trim)))
                        .Items.Add(New String("Última alteração: " & File.GetLastWriteTime(txtCamNome.Text.Trim)))
                        .Items.Add(New String("Nome da empresa.: " & InfoArq.CompanyName.Trim))
                        .Items.Add(New String("Versão..........: " & InfoArq.FileVersion.Trim))
                        .Items.Add(New String("Descrição.......: " & InfoArq.FileDescription))
                    End With
                Catch ex As Exception
                    MsgBox(ex.Message)
                    txtCamNome.Focus()
                End Try
            Else
                    MsgBox("O arquivo informado não foi encontrado.", _
                        MsgBoxStyle.Information, Text)
                    txtCamNome.Focus()
            End If
        Else
            MsgBox("Informe o arquivo a ser analisado.", _
                MsgBoxStyle.Information, Text)
            txtCamNome.Focus()
        End If
    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        If MsgBox("Deseja realmente sair?", _
            MsgBoxStyle.Question Or MsgBoxStyle.YesNo, Text) = MsgBoxResult.Yes Then End
    End Sub
End Class
