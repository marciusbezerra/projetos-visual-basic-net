
'Imports System.Security.Cryptography
'Imports com.ms.win32.Advapi32

Public Class frmSenha
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
    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblHash As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSenha = New System.Windows.Forms.TextBox
        Me.btnOk = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblHash = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Digite a senha:"
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(8, 40)
        Me.txtSenha.MaxLength = 10
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(272, 20)
        Me.txtSenha.TabIndex = 1
        Me.txtSenha.Text = ""
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(136, 76)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(144, 24)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "&Ok"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblHash)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(272, 48)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Hash da senha informada"
        '
        'lblHash
        '
        Me.lblHash.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHash.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHash.Location = New System.Drawing.Point(8, 16)
        Me.lblHash.Name = "lblHash"
        Me.lblHash.Size = New System.Drawing.Size(256, 24)
        Me.lblHash.TabIndex = 0
        Me.lblHash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(8, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 40)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Por algum motivo, este projeto não deu certo"
        '
        'frmSenha
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 166)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSenha"
        Me.Text = "Criptografia de senha com Hash"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim hcsp, hHash, Res, TamDado, TamTamDado As Int32
        Dim DadoHash, HexDadoHash As String
        Dim SenhaValida As Boolean
        Dim OperacaoPrincipal As clsFuncionalidade

        hcsp = AdquirirContexto(PROV_RSA_FULL)
        If hcsp = 0 Then GoTo Sair

        hHash = PegaDadoHash(hcsp, txtSenha.Text.Trim)
        If hHash = 0 Then GoTo Sair

        TamTamDado = 4
        Res = CryptGetHashParam(hHash, HP_HASHSIZE, TamDado, TamTamDado, 0)

        DadoHash = StrDup(TamDado, 0)
        Res = CryptGetHashParam(hHash, HP_HASHVAL, DadoHash, TamDado, 0)
        If Res = 0 Then GoTo Sair

        DadoHash = Strings.Left(DadoHash, TamDado)
        HexDadoHash = StringToHex(DadoHash)

        lblHash.Text = HexDadoHash

Sair:
        If hHash <> 0 Then CryptDestroyHash(hHash)
        If hcsp <> 0 Then CryptReleaseContext(hcsp, 0)
    End Sub

    Private Function AdquirirContexto(ByVal PTipo As Int32, _
        Optional ByVal NomeProvedor As String = "VBITSTEST") As Int64
        Dim Res, HandleContexto As Int64

        Res = CryptAcquireContext(HandleContexto, NomeProvedor, _
            MS_DEF_PROV, PTipo, 0)

        If Res = 0 Then
            Res = CryptAcquireContext(HandleContexto, NomeProvedor, MS_DEF_PROV, _
                PTipo, CRYPT_NEWKEYSET)
            If Res = 0 Then
                Err.Raise(Err.LastDllError)
                Exit Function
            End If
        End If
        Return HandleContexto
    End Function

    Private Function PegaDadoHash(ByVal hcsp As Int64, ByVal TextoParaHash As String) As Int32
        Dim hndHash, Res As Int32
        Res = CryptCreateHash(hcsp, CALG_MD5, 0, 0, hndHash)
        If Res = 0 Then Err.Raise(Err.LastDllError)
        Res = CryptHashData(hndHash, TextoParaHash, Len(TextoParaHash), 0)
        If Not Res Then Err.Raise(Err.LastDllError)
        Return hndHash
    End Function

    Private Function StringToHex(ByVal Texto As String) As String
        Dim x As Long
        Dim s, h As String
        For x = 1 To Texto.Length
            h = Hex$(Asc(Mid$(Texto, x, 1)))
            If h.Length = 1 Then h = "0" & h
            s += h
        Next
        Return s
    End Function
End Class
