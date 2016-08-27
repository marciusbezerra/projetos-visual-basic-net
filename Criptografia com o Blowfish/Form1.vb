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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Name = "Form1"
        Me.Text = "Form1"

    End Sub

#End Region
    Friend ChaveGerada() As Byte
    Friend SenhaCriptografada() As Byte
    Private cv As DLLBlowfish.Convertedor
    Private bf As DLLBlowfish.Blowfish
    Private fb As DLLBlowfish.FuncoesComBytes
    Private r64 As DLLBlowfish.Radix64

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cv = New DLLBlowfish.Convertedor
            bf = New DLLBlowfish.Blowfish
            fb = New DLLBlowfish.FuncoesComBytes
            r64 = New DLLBlowfish.Radix64
            ChaveGerada = System.Text.Encoding.Default.GetBytes(InputBox("Digita a palavra secreta:"))
            MsgBox(cv.BytesParaHex(ChaveGerada), , "Chave gerada")
            bf.InicializaChave(ChaveGerada)
            Dim Senha As Byte()
            Senha = System.Text.Encoding.Default.GetBytes(InputBox("Digita agora sua senha:"))
            SenhaCriptografada = fb.EncriptarBytes(Senha)
            MsgBox(System.Text.Encoding.Unicode.Default.GetString(SenhaCriptografada), , "Criptografia texto")
            MsgBox(cv.BytesParaHex(SenhaCriptografada), , "Criptografia HEX")
            MsgBox(r64.EncodeBytes64(SenhaCriptografada), , "Criptografia Radix64")
            Senha = fb.DecriptarBytes(SenhaCriptografada)
            MsgBox(System.Text.Encoding.Unicode.Default.GetString(Senha), , "Senha descriptada")
            DLLBlowfish.Creditos.MostraCreditos()
        Finally
            cv = Nothing
            bf = Nothing
            r64 = Nothing
            fb = Nothing
        End Try
    End Sub
End Class
