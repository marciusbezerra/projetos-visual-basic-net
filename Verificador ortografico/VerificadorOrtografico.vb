Imports System.IO
Public Class FormEditor
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
    Friend WithEvents mnuMain As System.Windows.Forms.MainMenu
    Friend WithEvents mnuArquivo As System.Windows.Forms.MenuItem
    Friend WithEvents mnuNovo As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAbrir As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSalvar As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSair As System.Windows.Forms.MenuItem
    Friend WithEvents mnuOpcoes As System.Windows.Forms.MenuItem
    Friend WithEvents mnuVerificarOrtografia As System.Windows.Forms.MenuItem
    Friend WithEvents rtbEditor As System.Windows.Forms.RichTextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.mnuMain = New System.Windows.Forms.MainMenu
        Me.mnuArquivo = New System.Windows.Forms.MenuItem
        Me.mnuNovo = New System.Windows.Forms.MenuItem
        Me.mnuAbrir = New System.Windows.Forms.MenuItem
        Me.mnuSalvar = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.mnuSair = New System.Windows.Forms.MenuItem
        Me.mnuOpcoes = New System.Windows.Forms.MenuItem
        Me.mnuVerificarOrtografia = New System.Windows.Forms.MenuItem
        Me.rtbEditor = New System.Windows.Forms.RichTextBox
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuArquivo, Me.mnuOpcoes})
        '
        'mnuArquivo
        '
        Me.mnuArquivo.Index = 0
        Me.mnuArquivo.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuNovo, Me.mnuAbrir, Me.mnuSalvar, Me.MenuItem5, Me.mnuSair})
        Me.mnuArquivo.Text = "Arquivo"
        '
        'mnuNovo
        '
        Me.mnuNovo.Index = 0
        Me.mnuNovo.Text = "Novo"
        '
        'mnuAbrir
        '
        Me.mnuAbrir.Index = 1
        Me.mnuAbrir.Text = "Abrir"
        '
        'mnuSalvar
        '
        Me.mnuSalvar.Index = 2
        Me.mnuSalvar.Text = "Salvar"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 3
        Me.MenuItem5.Text = "-"
        '
        'mnuSair
        '
        Me.mnuSair.Index = 4
        Me.mnuSair.Text = "Sair"
        '
        'mnuOpcoes
        '
        Me.mnuOpcoes.Index = 1
        Me.mnuOpcoes.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuVerificarOrtografia})
        Me.mnuOpcoes.Text = "Opções"
        '
        'mnuVerificarOrtografia
        '
        Me.mnuVerificarOrtografia.Index = 0
        Me.mnuVerificarOrtografia.Text = "Verificar ortografia"
        '
        'rtbEditor
        '
        Me.rtbEditor.Location = New System.Drawing.Point(8, 8)
        Me.rtbEditor.Name = "rtbEditor"
        Me.rtbEditor.Size = New System.Drawing.Size(488, 368)
        Me.rtbEditor.TabIndex = 0
        Me.rtbEditor.Text = ""
        '
        'FormEditor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(504, 406)
        Me.Controls.Add(Me.rtbEditor)
        Me.KeyPreview = True
        Me.Menu = Me.mnuMain
        Me.Name = "FormEditor"
        Me.Text = "Editor com verificação ortogrática"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Stb As StatusBar
    Private p1, p2, p3 As StatusBarPanel
    Private Declare Function GetKeyState Lib "user32.dll" Alias "GetKeyState" (ByVal nVirtKey As Long) As Integer

    Private Sub CriaStatusBar()
        Stb = New StatusBar
        p1 = New StatusBarPanel
        p2 = New StatusBarPanel
        p3 = New StatusBarPanel
        With p1
            .BorderStyle = StatusBarPanelBorderStyle.Sunken
            .Text = "Novo arquivo"
            .Alignment = HorizontalAlignment.Left
            .AutoSize = StatusBarPanelAutoSize.Spring
        End With
        With p2
            .BorderStyle = StatusBarPanelBorderStyle.Sunken
            .Alignment = HorizontalAlignment.Center
            If GetKeyState(Keys.CapsLock) = 1 Then
                .Text = "CAPSLOCK"
            Else
                .Text = "caplock"
            End If
            .AutoSize = StatusBarPanelAutoSize.Contents
        End With
        With p3
            .BorderStyle = StatusBarPanelBorderStyle.Raised
            .Text = System.DateTime.Today.ToLongDateString
            .AutoSize = StatusBarPanelAutoSize.Contents
        End With
        Stb.Panels.Add(p1)
        Stb.Panels.Add(p2)
        Stb.Panels.Add(p3)
        Stb.ShowPanels = True
        Me.Controls.Add(Stb)
    End Sub

    Private Sub FormEditor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CriaStatusBar()
    End Sub

    Private Sub FormEditor_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        With rtbEditor
            .Top = 3
            .Left = 3
            .Width = Me.Width - 15
            .Height = Me.Height - 80
        End With
    End Sub

    Private Sub mnuNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNovo.Click
        rtbEditor.Clear()
    End Sub

    Private Sub mnuSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSalvar.Click
        With SaveFileDialog1
            .Title = "Informe um novo para o arquivo"
            .Filter = "Atquivo RTF (*.rtf)|*.rtf"
            .AddExtension = True
            .OverwritePrompt = True
        End With
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim FStream As FileStream
            FStream = New FileStream(SaveFileDialog1.FileName, FileMode.Create)
            Try
                rtbEditor.SaveFile(FStream, RichTextBoxStreamType.RichText)
            Finally
                FStream.Close()
                FStream = Nothing
            End Try
        End If
    End Sub

    Private Sub mnuAbrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAbrir.Click
        With OpenFileDialog1
            .Title = "Selecione um arquivo para abrir"
            .Filter = "Arquivo RTF (*.rtf)|*.rtf"
            .AddExtension = True
        End With
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Dim FStream As FileStream
            FStream = New FileStream(OpenFileDialog1.FileName, FileMode.Open)
            Try
                rtbEditor.LoadFile(FStream, RichTextBoxStreamType.RichText)
            Finally
                FStream.Close()
                FStream = Nothing
            End Try
        End If
    End Sub

    Private Sub FormEditor_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyValue = Keys.CapsLock Then
            If GetKeyState(Keys.CapsLock) = 1 Then
                p2.Text = "CAPSLOCK"
            Else
                p2.Text = "capslock"
            End If
        End If
    End Sub

    Private Sub mnuVerificarOrtografia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuVerificarOrtografia.Click
        Dim objWord As Word.ApplicationClass
        MessageBox.Show("Esta função ainda não está terminada." & vbCrLf & _
            "A parte de verificação de ortografia não retorna o texto rtf formatado", Text)
        If objWord Is Nothing Then
            objWord = New Word.ApplicationClass
        End If
        Try
            objWord.Documents.Add()
            objWord.Selection.TypeText(rtbEditor.Text)
            objWord.Documents.Item(objWord.Documents.Count).CheckSpelling()
            objWord.Documents.Item(objWord.Documents.Count).Content.TextRetrievalMode.ViewType = Word.WdViewType.wdMasterView
            rtbEditor.Text = objWord.Documents.Item(objWord.Documents.Count).Content.Text
            objWord.Documents.Close(Word.WdSaveOptions.wdDoNotSaveChanges)
        Finally
            objWord.Quit()
            objWord = Nothing
        End Try
    End Sub

    Private Sub mnuSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSair.Click
        Close()
    End Sub
End Class
