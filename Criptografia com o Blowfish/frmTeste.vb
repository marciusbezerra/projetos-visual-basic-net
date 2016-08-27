Public Class frmTeste
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPalavraSecreta As System.Windows.Forms.TextBox
    Friend Tela(3) As System.Windows.Forms.Panel
    Friend WithEvents optHex As System.Windows.Forms.RadioButton
    Friend WithEvents optAlfa As System.Windows.Forms.RadioButton
    'Friend WithEvents Tela2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtChaveGerada As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTexto As System.Windows.Forms.TextBox
    Friend WithEvents txtHex As System.Windows.Forms.TextBox
    Friend WithEvents txtRadix64 As System.Windows.Forms.TextBox
    Friend WithEvents btnFuncao As System.Windows.Forms.Button
    'Friend WithEvents Tela3 As System.Windows.Forms.Panel
    'Friend WithEvents Tela4 As System.Windows.Forms.Panel
    Friend WithEvents txtSenhaDescriptada As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Tela(0) = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnFuncao = New System.Windows.Forms.Button
        Me.txtPalavraSecreta = New System.Windows.Forms.TextBox
        Me.optHex = New System.Windows.Forms.RadioButton
        Me.optAlfa = New System.Windows.Forms.RadioButton
        Me.Tela(1) = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtChaveGerada = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtSenha = New System.Windows.Forms.TextBox
        Me.Tela(2) = New System.Windows.Forms.Panel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtTexto = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtHex = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtRadix64 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Tela(3) = New System.Windows.Forms.Panel
        Me.txtSenhaDescriptada = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Tela(0).SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Tela(1).SuspendLayout()
        Me.Tela(2).SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Tela(3).SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Tela(3))
        Me.Panel1.Controls.Add(Me.Tela(2))
        Me.Panel1.Controls.Add(Me.Tela(1))
        Me.Panel1.Controls.Add(Me.Tela(0))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(472, 309)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.btnFuncao)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 277)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(472, 32)
        Me.Panel2.TabIndex = 1
        '
        'Tela1
        '
        Me.Tela(0).Controls.Add(Me.txtPalavraSecreta)
        Me.Tela(0).Controls.Add(Me.GroupBox1)
        Me.Tela(0).Controls.Add(Me.Label1)
        Me.Tela(0).Location = New System.Drawing.Point(8, 8)
        Me.Tela(0).Name = "Tela1"
        Me.Tela(0).Size = New System.Drawing.Size(456, 264)
        Me.Tela(0).TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Digite a palavra secreta:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optAlfa)
        Me.GroupBox1.Controls.Add(Me.optHex)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(440, 88)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Criar chave do tipo:"
        '
        'btnFuncao
        '
        Me.btnFuncao.Location = New System.Drawing.Point(312, 2)
        Me.btnFuncao.Name = "btnFuncao"
        Me.btnFuncao.Size = New System.Drawing.Size(152, 24)
        Me.btnFuncao.TabIndex = 0
        Me.btnFuncao.Text = "&Criar chave >>"
        '
        'txtPalavraSecreta
        '
        Me.txtPalavraSecreta.Location = New System.Drawing.Point(8, 32)
        Me.txtPalavraSecreta.MaxLength = 50
        Me.txtPalavraSecreta.Name = "txtPalavraSecreta"
        Me.txtPalavraSecreta.Size = New System.Drawing.Size(440, 20)
        Me.txtPalavraSecreta.TabIndex = 0
        Me.txtPalavraSecreta.Text = ""
        '
        'optHex
        '
        Me.optHex.Checked = True
        Me.optHex.Location = New System.Drawing.Point(32, 29)
        Me.optHex.Name = "optHex"
        Me.optHex.Size = New System.Drawing.Size(120, 16)
        Me.optHex.TabIndex = 0
        Me.optHex.TabStop = True
        Me.optHex.Text = "Hexadecimal"
        '
        'optAlfa
        '
        Me.optAlfa.Location = New System.Drawing.Point(32, 45)
        Me.optAlfa.Name = "optAlfa"
        Me.optAlfa.Size = New System.Drawing.Size(96, 24)
        Me.optAlfa.TabIndex = 1
        Me.optAlfa.Text = "Alfanumérica"
        '
        'Tela2
        '
        Me.Tela(1).Controls.Add(Me.txtSenha)
        Me.Tela(1).Controls.Add(Me.Label3)
        Me.Tela(1).Controls.Add(Me.txtChaveGerada)
        Me.Tela(1).Controls.Add(Me.Label2)
        Me.Tela(1).Location = New System.Drawing.Point(8, 7)
        Me.Tela(1).Visible = False
        Me.Tela(1).Name = "Tela2"
        Me.Tela(1).Size = New System.Drawing.Size(456, 264)
        Me.Tela(1).TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Chave gerada:"
        '
        'txtChaveGerada
        '
        Me.txtChaveGerada.BackColor = System.Drawing.SystemColors.Control
        Me.txtChaveGerada.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChaveGerada.Location = New System.Drawing.Point(8, 32)
        Me.txtChaveGerada.Name = "txtChaveGerada"
        Me.txtChaveGerada.ReadOnly = True
        Me.txtChaveGerada.Size = New System.Drawing.Size(432, 24)
        Me.txtChaveGerada.TabIndex = 1
        Me.txtChaveGerada.TabStop = False
        Me.txtChaveGerada.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Agora digite sua senha:"
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(8, 120)
        Me.txtSenha.MaxLength = 50
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.Size = New System.Drawing.Size(432, 20)
        Me.txtSenha.TabIndex = 3
        Me.txtSenha.Text = ""
        '
        'Tela3
        '
        Me.Tela(2).Controls.Add(Me.GroupBox2)
        Me.Tela(2).Location = New System.Drawing.Point(8, 7)
        Me.Tela(2).Visible = False
        Me.Tela(2).Name = "Tela3"
        Me.Tela(2).Size = New System.Drawing.Size(456, 264)
        Me.Tela(2).TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtRadix64)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtHex)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtTexto)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(440, 232)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sua senha criptografada:"
        '
        'txtTexto
        '
        Me.txtTexto.BackColor = System.Drawing.SystemColors.Control
        Me.txtTexto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTexto.Location = New System.Drawing.Point(8, 40)
        Me.txtTexto.Name = "txtTexto"
        Me.txtTexto.ReadOnly = True
        Me.txtTexto.Size = New System.Drawing.Size(424, 24)
        Me.txtTexto.TabIndex = 3
        Me.txtTexto.TabStop = False
        Me.txtTexto.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Em texto:"
        '
        'txtHex
        '
        Me.txtHex.BackColor = System.Drawing.SystemColors.Control
        Me.txtHex.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHex.Location = New System.Drawing.Point(8, 88)
        Me.txtHex.Name = "txtHex"
        Me.txtHex.ReadOnly = True
        Me.txtHex.Size = New System.Drawing.Size(424, 24)
        Me.txtHex.TabIndex = 5
        Me.txtHex.TabStop = False
        Me.txtHex.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Em hexadecimal:"
        '
        'txtRadix64
        '
        Me.txtRadix64.BackColor = System.Drawing.SystemColors.Control
        Me.txtRadix64.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRadix64.Location = New System.Drawing.Point(8, 136)
        Me.txtRadix64.Name = "txtRadix64"
        Me.txtRadix64.ReadOnly = True
        Me.txtRadix64.Size = New System.Drawing.Size(424, 24)
        Me.txtRadix64.TabIndex = 7
        Me.txtRadix64.TabStop = False
        Me.txtRadix64.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Em Radix64:"
        '
        'Tela4
        '
        Me.Tela(3).Controls.Add(Me.txtSenhaDescriptada)
        Me.Tela(3).Controls.Add(Me.Label9)
        Me.Tela(3).Location = New System.Drawing.Point(8, 7)
        Me.Tela(3).Visible = False
        Me.Tela(3).Name = "Tela4"
        Me.Tela(3).Size = New System.Drawing.Size(456, 264)
        Me.Tela(3).TabIndex = 3
        '
        'txtSenhaDescriptada
        '
        Me.txtSenhaDescriptada.BackColor = System.Drawing.SystemColors.Control
        Me.txtSenhaDescriptada.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenhaDescriptada.Location = New System.Drawing.Point(8, 88)
        Me.txtSenhaDescriptada.Name = "txtSenhaDescriptada"
        Me.txtSenhaDescriptada.ReadOnly = True
        Me.txtSenhaDescriptada.Size = New System.Drawing.Size(440, 24)
        Me.txtSenhaDescriptada.TabIndex = 5
        Me.txtSenhaDescriptada.TabStop = False
        Me.txtSenhaDescriptada.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 16)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "A senha que digitou foi:"
        '
        'frmTeste
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(472, 309)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmTeste"
        Me.Text = "frmTeste"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Tela(0).ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Tela(1).ResumeLayout(False)
        Me.Tela(2).ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.Tela(3).ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Friend ChaveGerada() As Byte
    Friend SenhaCriptografada() As Byte
    Private cv As DLLBlowfish.Convertedor
    Private bf As DLLBlowfish.Blowfish
    Private fb As DLLBlowfish.FuncoesComBytes
    Private r64 As DLLBlowfish.Radix64

    Private Sub MostraTela(ByVal Num As Integer)
        Dim i As Integer
        Num -= 1
        For i = 0 To Tela.Length - 1
            Tela(i).Visible = False
        Next
        Tela(Num).Visible = True
    End Sub

    Private Sub btnFuncao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFuncao.Click
        Try
            cv = New DLLBlowfish.Convertedor
            bf = New DLLBlowfish.Blowfish
            fb = New DLLBlowfish.FuncoesComBytes
            r64 = New DLLBlowfish.Radix64

            Select Case btnFuncao.Text
                Case "&Criar chave >>"
                    If optHex.Checked Then
                        ChaveGerada = cv.HexParaBytes(txtPalavraSecreta.Text)
                    Else
                        ChaveGerada = System.Text.Encoding.Default.GetBytes(txtPalavraSecreta.Text)
                    End If
                    MostraTela(2)
                    txtChaveGerada.Text = cv.BytesParaHex(ChaveGerada)
                    bf.InicializaChave(ChaveGerada)
                    btnFuncao.Text = "C&riptografar senha >>"
                    txtSenha.Focus()
                Case "C&riptografar senha >>"
                    Dim Senha As Byte()
                    Senha = System.Text.Encoding.Default.GetBytes(txtSenha.Text)
                    SenhaCriptografada = fb.EncriptarBytes(Senha)
                    MostraTela(3)
                    txtTexto.Text = System.Text.Encoding.Unicode.Default.GetString(SenhaCriptografada)
                    txtHex.Text = cv.BytesParaHex(SenhaCriptografada)
                    txtRadix64.Text = r64.EncodeBytes64(SenhaCriptografada)
                    btnFuncao.Text = "&Descriptografar senha >>"
                Case "&Descriptografar senha >>"
                    Dim Senha As Byte()
                    Senha = fb.DecriptarBytes(SenhaCriptografada)
                    MostraTela(4)
                    txtSenhaDescriptada.Text = _
                        System.Text.Encoding.Unicode.Default.GetString(Senha)
                    btnFuncao.Text = "&Finalizar"
                Case "&Finalizar"
                    If MsgBox("Deseja iniciar outra criptografia com Blowfish?", _
                        MsgBoxStyle.Question Or MsgBoxStyle.YesNo, Text) = MsgBoxResult.Yes Then
                        MostraTela(1)
                        btnFuncao.Text = "&Criar chave >>"
                    Else
                        DLLBlowfish.Creditos.MostraCreditos()
                        Close()
                    End If
            End Select
        Finally
            cv = Nothing
            bf = Nothing
            r64 = Nothing
            fb = Nothing
        End Try

    End Sub

    Private Sub frmTeste_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Text = "DLL Blowfish de criptografia (Teste)"
    End Sub

End Class

'OBSERVEÇÃO IMPORTANTE!
'SE ESTE FORM FOR ABERTO EM MODO DESING TODA A INFORMAÇÃO ACIMA MUDARÁ
'ESTE FORM NÃO PODE SER ABERTO EM MODO DESIGN POIS TEM CONTROLES ARRAY CRIADOS EM CÓDIGO
'PARA SEGURANÇA, O CÓDIGO ABAIXO É O VERDADEIRO, BASTANDO COLÁ-LO SOBRE O QUE O DESIGN
'POR VENTURA TENHA MODIFICADO.

'Public Class frmTeste
'    Inherits System.Windows.Forms.Form

'#Region " Windows Form Designer generated code "

'    Public Sub New()
'        MyBase.New()

'        'This call is required by the Windows Form Designer.
'        InitializeComponent()

'        'Add any initialization after the InitializeComponent() call

'    End Sub

'    'Form overrides dispose to clean up the component list.
'    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
'        If disposing Then
'            If Not (components Is Nothing) Then
'                components.Dispose()
'            End If
'        End If
'        MyBase.Dispose(disposing)
'    End Sub

'    'Required by the Windows Form Designer
'    Private components As System.ComponentModel.IContainer

'    'NOTE: The following procedure is required by the Windows Form Designer
'    'It can be modified using the Windows Form Designer.  
'    'Do not modify it using the code editor.
'    Friend WithEvents Panel1 As System.Windows.Forms.Panel
'    Friend WithEvents Panel2 As System.Windows.Forms.Panel
'    Friend WithEvents Label1 As System.Windows.Forms.Label
'    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
'    Friend WithEvents txtPalavraSecreta As System.Windows.Forms.TextBox
'    Friend Tela(3) As System.Windows.Forms.Panel
'    Friend WithEvents optHex As System.Windows.Forms.RadioButton
'    Friend WithEvents optAlfa As System.Windows.Forms.RadioButton
'    'Friend WithEvents Tela2 As System.Windows.Forms.Panel
'    Friend WithEvents Label2 As System.Windows.Forms.Label
'    Friend WithEvents txtChaveGerada As System.Windows.Forms.TextBox
'    Friend WithEvents Label3 As System.Windows.Forms.Label
'    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
'    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
'    Friend WithEvents Label4 As System.Windows.Forms.Label
'    Friend WithEvents Label5 As System.Windows.Forms.Label
'    Friend WithEvents Label6 As System.Windows.Forms.Label
'    Friend WithEvents txtTexto As System.Windows.Forms.TextBox
'    Friend WithEvents txtHex As System.Windows.Forms.TextBox
'    Friend WithEvents txtRadix64 As System.Windows.Forms.TextBox
'    Friend WithEvents btnFuncao As System.Windows.Forms.Button
'    'Friend WithEvents Tela3 As System.Windows.Forms.Panel
'    'Friend WithEvents Tela4 As System.Windows.Forms.Panel
'    Friend WithEvents txtSenhaDescriptada As System.Windows.Forms.TextBox
'    Friend WithEvents Label9 As System.Windows.Forms.Label
'    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
'        Me.Panel1 = New System.Windows.Forms.Panel
'        Me.Panel2 = New System.Windows.Forms.Panel
'        Me.Tela(0) = New System.Windows.Forms.Panel
'        Me.Label1 = New System.Windows.Forms.Label
'        Me.GroupBox1 = New System.Windows.Forms.GroupBox
'        Me.btnFuncao = New System.Windows.Forms.Button
'        Me.txtPalavraSecreta = New System.Windows.Forms.TextBox
'        Me.optHex = New System.Windows.Forms.RadioButton
'        Me.optAlfa = New System.Windows.Forms.RadioButton
'        Me.Tela(1) = New System.Windows.Forms.Panel
'        Me.Label2 = New System.Windows.Forms.Label
'        Me.txtChaveGerada = New System.Windows.Forms.TextBox
'        Me.Label3 = New System.Windows.Forms.Label
'        Me.txtSenha = New System.Windows.Forms.TextBox
'        Me.Tela(2) = New System.Windows.Forms.Panel
'        Me.GroupBox2 = New System.Windows.Forms.GroupBox
'        Me.txtTexto = New System.Windows.Forms.TextBox
'        Me.Label4 = New System.Windows.Forms.Label
'        Me.txtHex = New System.Windows.Forms.TextBox
'        Me.Label5 = New System.Windows.Forms.Label
'        Me.txtRadix64 = New System.Windows.Forms.TextBox
'        Me.Label6 = New System.Windows.Forms.Label
'        Me.Tela(3) = New System.Windows.Forms.Panel
'        Me.txtSenhaDescriptada = New System.Windows.Forms.TextBox
'        Me.Label9 = New System.Windows.Forms.Label
'        Me.Panel1.SuspendLayout()
'        Me.Panel2.SuspendLayout()
'        Me.Tela(0).SuspendLayout()
'        Me.GroupBox1.SuspendLayout()
'        Me.Tela(1).SuspendLayout()
'        Me.Tela(2).SuspendLayout()
'        Me.GroupBox2.SuspendLayout()
'        Me.Tela(3).SuspendLayout()
'        Me.SuspendLayout()
'        '
'        'Panel1
'        '
'        Me.Panel1.Controls.Add(Me.Tela(3))
'        Me.Panel1.Controls.Add(Me.Tela(2))
'        Me.Panel1.Controls.Add(Me.Tela(1))
'        Me.Panel1.Controls.Add(Me.Tela(0))
'        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
'        Me.Panel1.Location = New System.Drawing.Point(0, 0)
'        Me.Panel1.Name = "Panel1"
'        Me.Panel1.Size = New System.Drawing.Size(472, 309)
'        Me.Panel1.TabIndex = 0
'        '
'        'Panel2
'        '
'        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
'        Me.Panel2.Controls.Add(Me.btnFuncao)
'        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
'        Me.Panel2.Location = New System.Drawing.Point(0, 277)
'        Me.Panel2.Name = "Panel2"
'        Me.Panel2.Size = New System.Drawing.Size(472, 32)
'        Me.Panel2.TabIndex = 1
'        '
'        'Tela1
'        '
'        Me.Tela(0).Controls.Add(Me.txtPalavraSecreta)
'        Me.Tela(0).Controls.Add(Me.GroupBox1)
'        Me.Tela(0).Controls.Add(Me.Label1)
'        Me.Tela(0).Location = New System.Drawing.Point(8, 8)
'        Me.Tela(0).Name = "Tela1"
'        Me.Tela(0).Size = New System.Drawing.Size(456, 264)
'        Me.Tela(0).TabIndex = 0
'        '
'        'Label1
'        '
'        Me.Label1.AutoSize = True
'        Me.Label1.Location = New System.Drawing.Point(8, 16)
'        Me.Label1.Name = "Label1"
'        Me.Label1.Size = New System.Drawing.Size(126, 16)
'        Me.Label1.TabIndex = 2
'        Me.Label1.Text = "Digite a palavra secreta:"
'        '
'        'GroupBox1
'        '
'        Me.GroupBox1.Controls.Add(Me.optAlfa)
'        Me.GroupBox1.Controls.Add(Me.optHex)
'        Me.GroupBox1.Location = New System.Drawing.Point(8, 72)
'        Me.GroupBox1.Name = "GroupBox1"
'        Me.GroupBox1.Size = New System.Drawing.Size(440, 88)
'        Me.GroupBox1.TabIndex = 1
'        Me.GroupBox1.TabStop = False
'        Me.GroupBox1.Text = "Criar chave do tipo:"
'        '
'        'btnFuncao
'        '
'        Me.btnFuncao.Location = New System.Drawing.Point(312, 2)
'        Me.btnFuncao.Name = "btnFuncao"
'        Me.btnFuncao.Size = New System.Drawing.Size(152, 24)
'        Me.btnFuncao.TabIndex = 0
'        Me.btnFuncao.Text = "&Criar chave >>"
'        '
'        'txtPalavraSecreta
'        '
'        Me.txtPalavraSecreta.Location = New System.Drawing.Point(8, 32)
'        Me.txtPalavraSecreta.MaxLength = 50
'        Me.txtPalavraSecreta.Name = "txtPalavraSecreta"
'        Me.txtPalavraSecreta.Size = New System.Drawing.Size(440, 20)
'        Me.txtPalavraSecreta.TabIndex = 0
'        Me.txtPalavraSecreta.Text = ""
'        '
'        'optHex
'        '
'        Me.optHex.Checked = True
'        Me.optHex.Location = New System.Drawing.Point(32, 29)
'        Me.optHex.Name = "optHex"
'        Me.optHex.Size = New System.Drawing.Size(120, 16)
'        Me.optHex.TabIndex = 0
'        Me.optHex.TabStop = True
'        Me.optHex.Text = "Hexadecimal"
'        '
'        'optAlfa
'        '
'        Me.optAlfa.Location = New System.Drawing.Point(32, 45)
'        Me.optAlfa.Name = "optAlfa"
'        Me.optAlfa.Size = New System.Drawing.Size(96, 24)
'        Me.optAlfa.TabIndex = 1
'        Me.optAlfa.Text = "Alfanumérica"
'        '
'        'Tela2
'        '
'        Me.Tela(1).Controls.Add(Me.txtSenha)
'        Me.Tela(1).Controls.Add(Me.Label3)
'        Me.Tela(1).Controls.Add(Me.txtChaveGerada)
'        Me.Tela(1).Controls.Add(Me.Label2)
'        Me.Tela(1).Location = New System.Drawing.Point(8, 7)
'        Me.Tela(1).Visible = False
'        Me.Tela(1).Name = "Tela2"
'        Me.Tela(1).Size = New System.Drawing.Size(456, 264)
'        Me.Tela(1).TabIndex = 1
'        '
'        'Label2
'        '
'        Me.Label2.AutoSize = True
'        Me.Label2.Location = New System.Drawing.Point(8, 16)
'        Me.Label2.Name = "Label2"
'        Me.Label2.Size = New System.Drawing.Size(78, 16)
'        Me.Label2.TabIndex = 0
'        Me.Label2.Text = "Chave gerada:"
'        '
'        'txtChaveGerada
'        '
'        Me.txtChaveGerada.BackColor = System.Drawing.SystemColors.Control
'        Me.txtChaveGerada.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
'        Me.txtChaveGerada.Location = New System.Drawing.Point(8, 32)
'        Me.txtChaveGerada.Name = "txtChaveGerada"
'        Me.txtChaveGerada.ReadOnly = True
'        Me.txtChaveGerada.Size = New System.Drawing.Size(432, 24)
'        Me.txtChaveGerada.TabIndex = 1
'        Me.txtChaveGerada.TabStop = False
'        Me.txtChaveGerada.Text = ""
'        '
'        'Label3
'        '
'        Me.Label3.AutoSize = True
'        Me.Label3.Location = New System.Drawing.Point(8, 104)
'        Me.Label3.Name = "Label3"
'        Me.Label3.Size = New System.Drawing.Size(123, 16)
'        Me.Label3.TabIndex = 2
'        Me.Label3.Text = "Agora digite sua senha:"
'        '
'        'txtSenha
'        '
'        Me.txtSenha.Location = New System.Drawing.Point(8, 120)
'        Me.txtSenha.MaxLength = 50
'        Me.txtSenha.Name = "txtSenha"
'        Me.txtSenha.Size = New System.Drawing.Size(432, 20)
'        Me.txtSenha.TabIndex = 3
'        Me.txtSenha.Text = ""
'        '
'        'Tela3
'        '
'        Me.Tela(2).Controls.Add(Me.GroupBox2)
'        Me.Tela(2).Location = New System.Drawing.Point(8, 7)
'        Me.Tela(2).Visible = False
'        Me.Tela(2).Name = "Tela3"
'        Me.Tela(2).Size = New System.Drawing.Size(456, 264)
'        Me.Tela(2).TabIndex = 2
'        '
'        'GroupBox2
'        '
'        Me.GroupBox2.Controls.Add(Me.txtRadix64)
'        Me.GroupBox2.Controls.Add(Me.Label6)
'        Me.GroupBox2.Controls.Add(Me.txtHex)
'        Me.GroupBox2.Controls.Add(Me.Label5)
'        Me.GroupBox2.Controls.Add(Me.txtTexto)
'        Me.GroupBox2.Controls.Add(Me.Label4)
'        Me.GroupBox2.Location = New System.Drawing.Point(8, 8)
'        Me.GroupBox2.Name = "GroupBox2"
'        Me.GroupBox2.Size = New System.Drawing.Size(440, 232)
'        Me.GroupBox2.TabIndex = 2
'        Me.GroupBox2.TabStop = False
'        Me.GroupBox2.Text = "Sua senha criptografada:"
'        '
'        'txtTexto
'        '
'        Me.txtTexto.BackColor = System.Drawing.SystemColors.Control
'        Me.txtTexto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
'        Me.txtTexto.Location = New System.Drawing.Point(8, 40)
'        Me.txtTexto.Name = "txtTexto"
'        Me.txtTexto.ReadOnly = True
'        Me.txtTexto.Size = New System.Drawing.Size(424, 24)
'        Me.txtTexto.TabIndex = 3
'        Me.txtTexto.TabStop = False
'        Me.txtTexto.Text = ""
'        '
'        'Label4
'        '
'        Me.Label4.AutoSize = True
'        Me.Label4.Location = New System.Drawing.Point(8, 24)
'        Me.Label4.Name = "Label4"
'        Me.Label4.Size = New System.Drawing.Size(52, 16)
'        Me.Label4.TabIndex = 2
'        Me.Label4.Text = "Em texto:"
'        '
'        'txtHex
'        '
'        Me.txtHex.BackColor = System.Drawing.SystemColors.Control
'        Me.txtHex.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
'        Me.txtHex.Location = New System.Drawing.Point(8, 88)
'        Me.txtHex.Name = "txtHex"
'        Me.txtHex.ReadOnly = True
'        Me.txtHex.Size = New System.Drawing.Size(424, 24)
'        Me.txtHex.TabIndex = 5
'        Me.txtHex.TabStop = False
'        Me.txtHex.Text = ""
'        '
'        'Label5
'        '
'        Me.Label5.AutoSize = True
'        Me.Label5.Location = New System.Drawing.Point(8, 72)
'        Me.Label5.Name = "Label5"
'        Me.Label5.Size = New System.Drawing.Size(91, 16)
'        Me.Label5.TabIndex = 4
'        Me.Label5.Text = "Em hexadecimal:"
'        '
'        'txtRadix64
'        '
'        Me.txtRadix64.BackColor = System.Drawing.SystemColors.Control
'        Me.txtRadix64.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
'        Me.txtRadix64.Location = New System.Drawing.Point(8, 136)
'        Me.txtRadix64.Name = "txtRadix64"
'        Me.txtRadix64.ReadOnly = True
'        Me.txtRadix64.Size = New System.Drawing.Size(424, 24)
'        Me.txtRadix64.TabIndex = 7
'        Me.txtRadix64.TabStop = False
'        Me.txtRadix64.Text = ""
'        '
'        'Label6
'        '
'        Me.Label6.AutoSize = True
'        Me.Label6.Location = New System.Drawing.Point(8, 120)
'        Me.Label6.Name = "Label6"
'        Me.Label6.Size = New System.Drawing.Size(69, 16)
'        Me.Label6.TabIndex = 6
'        Me.Label6.Text = "Em Radix64:"
'        '
'        'Tela4
'        '
'        Me.Tela(3).Controls.Add(Me.txtSenhaDescriptada)
'        Me.Tela(3).Controls.Add(Me.Label9)
'        Me.Tela(3).Location = New System.Drawing.Point(8, 7)
'        Me.Tela(3).Visible = False
'        Me.Tela(3).Name = "Tela4"
'        Me.Tela(3).Size = New System.Drawing.Size(456, 264)
'        Me.Tela(3).TabIndex = 3
'        '
'        'txtSenhaDescriptada
'        '
'        Me.txtSenhaDescriptada.BackColor = System.Drawing.SystemColors.Control
'        Me.txtSenhaDescriptada.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
'        Me.txtSenhaDescriptada.Location = New System.Drawing.Point(8, 88)
'        Me.txtSenhaDescriptada.Name = "txtSenhaDescriptada"
'        Me.txtSenhaDescriptada.ReadOnly = True
'        Me.txtSenhaDescriptada.Size = New System.Drawing.Size(440, 24)
'        Me.txtSenhaDescriptada.TabIndex = 5
'        Me.txtSenhaDescriptada.TabStop = False
'        Me.txtSenhaDescriptada.Text = ""
'        '
'        'Label9
'        '
'        Me.Label9.AutoSize = True
'        Me.Label9.Location = New System.Drawing.Point(8, 72)
'        Me.Label9.Name = "Label9"
'        Me.Label9.Size = New System.Drawing.Size(122, 16)
'        Me.Label9.TabIndex = 4
'        Me.Label9.Text = "A senha que digitou foi:"
'        '
'        'frmTeste
'        '
'        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
'        Me.ClientSize = New System.Drawing.Size(472, 309)
'        Me.Controls.Add(Me.Panel2)
'        Me.Controls.Add(Me.Panel1)
'        Me.Name = "frmTeste"
'        Me.Text = "frmTeste"
'        Me.Panel1.ResumeLayout(False)
'        Me.Panel2.ResumeLayout(False)
'        Me.Tela(0).ResumeLayout(False)
'        Me.GroupBox1.ResumeLayout(False)
'        Me.Tela(1).ResumeLayout(False)
'        Me.Tela(2).ResumeLayout(False)
'        Me.GroupBox2.ResumeLayout(False)
'        Me.Tela(3).ResumeLayout(False)
'        Me.ResumeLayout(False)

'    End Sub

'#End Region

'    Private Chave As Byte()
'    Private CripEmTexto As Byte()

'    Private Sub MostraTela(ByVal Num As Integer)
'        Dim i As Integer
'        Num -= 1
'        For i = 0 To Tela.Length - 1
'            Tela(i).Visible = False
'        Next
'        Tela(Num).Visible = True
'    End Sub

'    Private Sub btnFuncao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFuncao.Click
'        Select Case btnFuncao.Text
'            Case "&Criar chave >>"
'                If optHex.Checked Then
'                    Chave = cv_BytesFromHex(txtPalavraSecreta.Text)
'                Else
'                    Chave = System.Text.Encoding.Default.GetBytes(txtPalavraSecreta.Text)
'                End If
'                MostraTela(2)
'                txtChaveGerada.Text = cv_HexFromBytes(Chave)
'                blf_KeyInit(Chave)
'                btnFuncao.Text = "C&riptografar senha >>"
'                txtSenha.Focus()
'            Case "C&riptografar senha >>"
'                Dim ChaveGerada As Byte()
'                ChaveGerada = System.Text.Encoding.Default.GetBytes(txtChaveGerada.Text)
'                CripEmTexto = blf_BytesEnc(ChaveGerada)
'                MostraTela(3)
'                txtTexto.Text = System.Text.Encoding.Unicode.Default.GetString(CripEmTexto)
'                txtHex.Text = cv_HexFromBytes(CripEmTexto)
'                txtRadix64.Text = EncodeBytes64(CripEmTexto)
'                btnFuncao.Text = "&Descriptografar senha >>"
'            Case "&Descriptografar senha >>"
'                Dim ChaveGerada As Byte()
'                ChaveGerada = blf_BytesDec(CripEmTexto)
'                MostraTela(4)
'                txtSenhaDescriptada.Text = _
'                    System.Text.Encoding.Unicode.Default.GetString(ChaveGerada)
'                btnFuncao.Text = "&Finalizar"
'            Case "&Finalizar"
'                If MsgBox("Deseja iniciar outra criptografia com Blowfish?", _
'                    MsgBoxStyle.Question Or MsgBoxStyle.YesNo, Text) = MsgBoxResult.Yes Then
'                    MostraTela(1)
'                Else
'                    Close()
'                End If
'        End Select
'    End Sub
'End Class