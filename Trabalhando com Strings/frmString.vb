Public Class frmString
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
    Friend WithEvents txtPalavras As System.Windows.Forms.TextBox
    Friend WithEvents btnCriarVetor As System.Windows.Forms.Button
    Friend WithEvents lslVetor As System.Windows.Forms.ListBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtPalavras = New System.Windows.Forms.TextBox
        Me.btnCriarVetor = New System.Windows.Forms.Button
        Me.lslVetor = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(336, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Insira palavras separadas por ponto e vírgula:"
        '
        'txtPalavras
        '
        Me.txtPalavras.Location = New System.Drawing.Point(8, 24)
        Me.txtPalavras.Multiline = True
        Me.txtPalavras.Name = "txtPalavras"
        Me.txtPalavras.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPalavras.Size = New System.Drawing.Size(352, 64)
        Me.txtPalavras.TabIndex = 1
        Me.txtPalavras.Text = ""
        '
        'btnCriarVetor
        '
        Me.btnCriarVetor.Location = New System.Drawing.Point(72, 96)
        Me.btnCriarVetor.Name = "btnCriarVetor"
        Me.btnCriarVetor.Size = New System.Drawing.Size(224, 32)
        Me.btnCriarVetor.TabIndex = 2
        Me.btnCriarVetor.Text = "&Criar vetor"
        '
        'lslVetor
        '
        Me.lslVetor.Location = New System.Drawing.Point(8, 136)
        Me.lslVetor.Name = "lslVetor"
        Me.lslVetor.Size = New System.Drawing.Size(352, 95)
        Me.lslVetor.TabIndex = 3
        '
        'frmString
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(368, 246)
        Me.Controls.Add(Me.lslVetor)
        Me.Controls.Add(Me.btnCriarVetor)
        Me.Controls.Add(Me.txtPalavras)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmString"
        Me.Text = "VB.NET - Trabalhando com Strings"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Nome As String = "Marcius Carneiro Bezerra"
        Nome = Nome.Remove(9, 7)
        MsgBox(Nome)
        Dim Tamanho As Integer
        Tamanho = Nome.Length
        MsgBox("A String possui " & Tamanho.ToString & " caractere(s)")
        Dim PrimeroNome, NomeDoMeio, UltimoNome As String
        PrimeroNome = Nome.Substring(0, 7)
        NomeDoMeio = Nome.Substring(8, 1)
        UltimoNome = Nome.Substring(10)
        MsgBox("Primeiro nome: " & PrimeroNome & ", Nome do meio: " & _
            NomeDoMeio & " e último nome: " & UltimoNome)
        Dim Posicao As Integer
        Posicao = Nome.IndexOf("Marcius")
        MsgBox("A posição de Marcius é " & Posicao.ToString)
        Posicao = Nome.IndexOf("C")
        MsgBox("A posição de C é " & Posicao.ToString)
        Posicao = Nome.ToLower.IndexOf("bezerra")
        MsgBox("A posição de Bezerra é " & Posicao.ToString)
        MsgBox(Nome.Replace("C", "C.") & " (com o ponto)")
        MsgBox(Nome.ToUpper())
        MsgBox(Nome.ToLower())
    End Sub

    Private Sub btnCriarVetor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCriarVetor.Click
        Dim Palavras As String = txtPalavras.Text
        Dim Matriz() As String = Palavras.Split(";")
        Dim i As Integer
        For i = 0 To Matriz.GetUpperBound(0)
            lslVetor.Items.Add(Matriz(i).Trim)
        Next
    End Sub
End Class
