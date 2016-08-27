Imports System.Net
Imports System.IO
Imports System.Text
Public Class FormMain
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
    Friend WithEvents txtMensagem As System.Windows.Forms.TextBox
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
    Friend WithEvents stb As System.Windows.Forms.StatusBar
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents txtDDD As System.Windows.Forms.TextBox
    Friend WithEvents txtNumCel As System.Windows.Forms.TextBox
    Friend WithEvents txtAss As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents panStatus As System.Windows.Forms.StatusBarPanel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormMain))
        Me.txtMensagem = New System.Windows.Forms.TextBox
        Me.btnEnviar = New System.Windows.Forms.Button
        Me.stb = New System.Windows.Forms.StatusBar
        Me.panStatus = New System.Windows.Forms.StatusBarPanel
        Me.btnFechar = New System.Windows.Forms.Button
        Me.txtDDD = New System.Windows.Forms.TextBox
        Me.txtNumCel = New System.Windows.Forms.TextBox
        Me.txtAss = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        CType(Me.panStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMensagem
        '
        Me.txtMensagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMensagem.Location = New System.Drawing.Point(8, 64)
        Me.txtMensagem.MaxLength = 1200
        Me.txtMensagem.Multiline = True
        Me.txtMensagem.Name = "txtMensagem"
        Me.txtMensagem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMensagem.Size = New System.Drawing.Size(240, 200)
        Me.txtMensagem.TabIndex = 2
        Me.txtMensagem.Text = ""
        '
        'btnEnviar
        '
        Me.btnEnviar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnviar.Location = New System.Drawing.Point(48, 320)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(96, 24)
        Me.btnEnviar.TabIndex = 4
        Me.btnEnviar.Text = "&Enviar"
        '
        'stb
        '
        Me.stb.Location = New System.Drawing.Point(0, 384)
        Me.stb.Name = "stb"
        Me.stb.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.panStatus})
        Me.stb.ShowPanels = True
        Me.stb.Size = New System.Drawing.Size(256, 22)
        Me.stb.TabIndex = 7
        '
        'panStatus
        '
        Me.panStatus.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.panStatus.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.panStatus.Width = 240
        '
        'btnFechar
        '
        Me.btnFechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFechar.Location = New System.Drawing.Point(152, 320)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(96, 24)
        Me.btnFechar.TabIndex = 5
        Me.btnFechar.Text = "&Fechar"
        '
        'txtDDD
        '
        Me.txtDDD.Location = New System.Drawing.Point(8, 24)
        Me.txtDDD.MaxLength = 2
        Me.txtDDD.Name = "txtDDD"
        Me.txtDDD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDDD.Size = New System.Drawing.Size(32, 20)
        Me.txtDDD.TabIndex = 0
        Me.txtDDD.Text = ""
        '
        'txtNumCel
        '
        Me.txtNumCel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumCel.Location = New System.Drawing.Point(48, 24)
        Me.txtNumCel.MaxLength = 8
        Me.txtNumCel.Name = "txtNumCel"
        Me.txtNumCel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNumCel.Size = New System.Drawing.Size(200, 20)
        Me.txtNumCel.TabIndex = 1
        Me.txtNumCel.Text = ""
        '
        'txtAss
        '
        Me.txtAss.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAss.Location = New System.Drawing.Point(8, 288)
        Me.txtAss.MaxLength = 15
        Me.txtAss.Name = "txtAss"
        Me.txtAss.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAss.Size = New System.Drawing.Size(240, 20)
        Me.txtAss.TabIndex = 3
        Me.txtAss.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "DDD:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Número:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Mensagem:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 272)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Assinatura:"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel1.LinkArea = New System.Windows.Forms.LinkArea(4, 27)
        Me.LinkLabel1.Location = New System.Drawing.Point(8, 358)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(240, 16)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Por marciusbezerra@yahoo.com.br em .NET"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(256, 406)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAss)
        Me.Controls.Add(Me.txtNumCel)
        Me.Controls.Add(Me.txtDDD)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.stb)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.txtMensagem)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(264, 440)
        Me.Name = "FormMain"
        Me.Text = "SMS Oi"
        CType(Me.panStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


#Region "AS TECLAS RECONHECIDAS PELO VISUAL STUDIO .NET"
    'IsControl
    '================================================================
    'Chr(1) 
    'Chr(2)
    'Chr(3)
    'Chr(4)
    'Chr(5)
    'Chr(6)
    'Chr(7)
    'Chr(8)
    'Chr(9)
    'Chr(10)
    'Chr(11)
    'Chr(12)
    'Chr(13)
    'Chr(14)
    'Chr(15)
    'Chr(16)
    'Chr(17)
    'Chr(18)
    'Chr(19)
    'Chr(20)
    'Chr(21)
    'Chr(22)
    'Chr(23)
    'Chr(24)
    'Chr(25)
    'Chr(26)
    'Chr(27)
    'Chr(28)
    'Chr(29)
    'Chr(30)
    'Chr(31)
    'Chr(127)
    'Chr(129)
    'Chr(141)
    'Chr(143)
    'Chr(144)
    'Chr(157)

    'IsWhiteSpace
    '================================================================
    'Chr(9)
    'Chr(10)
    'Chr(11)
    'Chr(12)
    'Chr(13)
    'Chr(32)
    'Chr(160)

    'IsSeparator
    '================================================================
    'Chr(32)
    'Chr(160)

    'IsPunctuation
    '================================================================
    '! " # % & ' ( ) * , - . / : ; ? @ [ \ ] _ { } ‚ „ … † ‡ ‰ ‹ ‘ ’ 
    '“ ” • – — › ¡ « ­ · » ¿ 

    'IsSymbol
    '================================================================
    '$ + < = > ^ ` | ~ € ˆ ˜ ™ ¢ £ ¤ ¥ ¦ § ¨ © ¬ ® ¯ ° ± ´ ¶ ¸ × ÷ 

    'IsNumber
    '================================================================
    '² ³ ¹ ¼ ½ ¾ 

    'IsDigit
    '================================================================
    '0 a 9

    'IsLetter
    '================================================================
    'A a Z, a a z
    'ƒ Š Œ Ž š œ ž Ÿ ª µ º À Á Â Ã Ä Å Æ Ç È É Ê Ë Ì Í Î Ï Ð Ñ Ò Ó Ô 
    'Õ Ö Ø Ù Ú Û Ü Ý Þ ß à á â ã ä å æ ç è é ê ë ì í î ï ð ñ ò ó ô õ 
    'ö ø ù ú û ü ý þ ÿ 

    'IsLetterOrDigit
    '================================================================
    'Is_Digit & Is_Letter
#End Region


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtMensagem_TextChanged(sender, e)
    End Sub

    Private Function EnviaRequest(ByRef WebRequest As HttpWebRequest, _
        ByRef WebResponse As HttpWebResponse, _
        ByVal Metodo As String, ByVal URL As String, _
        ByVal Accept As String, ByVal Referer As String, ByVal AcceptLanguage As String, _
        ByVal AcceptEncoding As String, ByVal UserAgent As String, _
        ByVal KeepAlive As Boolean, ByRef ResponseStream As StreamReader, ByRef Cookie As String) As HttpStatusCode
        WebRequest = CType(WebRequest.Create(URL), HttpWebRequest)
        WebRequest.Accept = Accept
        WebRequest.Referer = Referer
        WebRequest.Headers.Clear()
        WebRequest.Headers.Add("Accept-Language", AcceptLanguage)
        WebRequest.Headers.Add("Accept-Encoding", AcceptEncoding)
        WebRequest.Headers.Add("Cookie", Cookie)
        WebRequest.UserAgent = UserAgent
        WebRequest.KeepAlive = KeepAlive
        WebRequest.Method = Metodo
        WebResponse = CType(WebRequest.GetResponse, HttpWebResponse)
        Dim Enc As Encoding = Encoding.GetEncoding(860)
        ResponseStream = New StreamReader(WebResponse.GetResponseStream, Enc)
        If Not WebResponse.Headers("Set-Cookie") Is Nothing Then
            Cookie = WebResponse.Headers("Set-Cookie").Trim
        End If
        Return WebResponse.StatusCode
    End Function

    Private Function EnviaMsgOi(ByVal DDD As String, ByVal NumCelular As String, _
        ByVal Mensagem As String, ByVal Assinatura As String, _
        ByVal TamCaracteres As String, ByVal MostraMensagemFinal As Boolean) As Boolean
        Dim Cookie As String = ""
        Dim wrq As HttpWebRequest
        Dim wrp As HttpWebResponse
        btnEnviar.Enabled = False
        Try
            EnviaRequest(wrq, wrp, "GET", _
                "http://www.oiloja.com.br/portal2/site/home/login.jsp?corbase=rox", _
                "image/gif, image/x-xbitmap, image/jpeg, image/pjpeg, application/x-shockwave-flash, application/vnd.ms-excel, application/msword, */*", _
                "http://www.oiloja.com.br/portal2/site/home/index.jsp", _
                "pt-br", _
                "gzip, deflate", _
                "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; .NET CLR 1.1.4322)", _
                True, Nothing, Cookie)
            Try
                panStatus.Text = wrp.StatusDescription
            Finally
                wrp.Close()
            End Try

            EnviaRequest(wrq, wrp, "GET", _
                "http://www.oiloja.com.br/portal2/site/oipessoal/imgauth/digitimg.jsp", _
                "*/*", _
                "", _
                "pt-br", _
                "gzip, deflate", _
                "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; .NET CLR 1.1.4322)", _
                True, Nothing, Cookie)
            Try
                panStatus.Text = wrp.StatusDescription
            Finally
                wrp.Close()
            End Try
            Dim St As StreamReader
            EnviaRequest(wrq, wrp, "GET", _
                "http://www.oiloja.com.br/imagemsms", _
                "*/*", _
                "http://www.oiloja.com.br/portal2/site/oipessoal/imgauth/digitimg.jsp", _
                "pt-br", _
                "gzip, deflate", _
                "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; .NET CLR 1.1.4322)", _
                True, St, Cookie)
            Dim fImg As FormImg
            fImg = New FormImg
            Try
                Try
                    fImg.lblImg.Image = Image.FromStream(St.BaseStream)
                Finally
                    St.Close()
                    wrp.Close()
                End Try
                If fImg.ShowDialog = DialogResult.OK Then
                    Dim img As String = fImg.txtImg.Text.Trim
                    Dim Res As HttpStatusCode

                    Res = EnviaRequest(wrq, wrp, "GET", _
                        "http://www.oiloja.com.br/portal2/site/oipessoal/send_sms.jsp?imgcod=" & img & "&urlfrom=..%2Fhome%2Findex2.jsp%3Fcorbase%3Drox&ddd=" & DDD & "&numero=" & NumCelular & "&texto=" & Mensagem & "&ass=" & Assinatura & "&lentxt=" & TamCaracteres, _
                        "image/gif, image/x-xbitmap, image/jpeg, image/pjpeg, application/x-shockwave-flash, application/vnd.ms-excel, application/msword, */*", _
                        "http://www.oiloja.com.br/portal2/site/home/index2.jsp?corbase=rox", _
                        "pt-br", _
                        "gzip, deflate", _
                        "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; .NET CLR 1.1.4322)", _
                        True, Nothing, Cookie)
                    panStatus.Text = wrp.StatusDescription
                    If Res = HttpStatusCode.Found Or Res = HttpStatusCode.Moved Or Res = HttpStatusCode.MovedPermanently Then
                        Dim Locacao As String = "http://www.oiloja.com.br/portal2/site/oipessoal/send_sms.jsp?imgcod=" & img & "&urlfrom=..%2Fhome%2Findex2.jsp%3Fcorbase%3Drox&ddd=" & DDD & "&numero=" & NumCelular & "&texto=" & Mensagem & "&ass=" & Assinatura & "&lentxt=" & TamCaracteres
                        If Not wrp.Headers("Location") Is Nothing Then
                            Locacao = wrp.Headers("Location").Trim
                        End If
                        wrp.Close()
                        EnviaRequest(wrq, wrp, "GET", Locacao, _
                            "image/gif, image/x-xbitmap, image/jpeg, image/pjpeg, application/x-shockwave-flash, application/vnd.ms-excel, application/msword, */*", _
                            "http://www.oiloja.com.br/portal2/site/home/index2.jsp?corbase=rox", _
                            "pt-br", _
                            "gzip, deflate", _
                            "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; .NET CLR 1.1.4322)", _
                            True, Nothing, Cookie)
                        panStatus.Text = wrp.StatusDescription
                    End If
                    wrp.Close()
                    If MostraMensagemFinal Then
                        MsgBox("Mensagem(ns) encaminha para envio", MsgBoxStyle.Information, Text)
                    End If
                    Return True
                Else
                    Return False
                End If
            Finally
                fImg = Nothing
            End Try
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Text)
            Return False
        Finally
            btnEnviar.Enabled = True
            wrp = Nothing
            wrq = Nothing
        End Try
    End Function

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviar.Click
        If txtDDD.Text.Trim = "" Or txtNumCel.Text.Trim = "" Or _
            txtMensagem.Text.Trim = "" Or txtAss.Text.Trim = "" Then
            MsgBox("O DDD, o número do celular, a mensagem e a assinatura são campos obrigatórios", MsgBoxStyle.Critical, Text)
        Else
            Dim nm, cr, mx As Integer
            CalcularNumMsgs(nm, cr, mx)
            If nm > 1 Then
                Dim i As Integer
                For i = 1 To nm - 1
                    If Not EnviaMsgOi(txtDDD.Text.Trim, txtNumCel.Text.Trim, _
                        Mid(txtMensagem.Text.Trim, i * mx, mx) & "...", txtAss.Text.Trim, _
                        "0", False) Then
                        Exit Sub
                    End If
                Next
                EnviaMsgOi(txtDDD.Text.Trim, txtNumCel.Text.Trim, _
                    Mid(txtMensagem.Text.Trim, i * nm), txtAss.Text.Trim, _
                    cr, True)
            Else
                EnviaMsgOi(txtDDD.Text.Trim, txtNumCel.Text.Trim, _
                    txtMensagem.Text.Trim, txtAss.Text.Trim, _
                    cr, True)
            End If
        End If
    End Sub

    Private Sub CalcularNumMsgs(ByRef NumMsgs As Integer, ByRef CarRest As Integer, ByRef MaxUma As Integer)
        MaxUma = 151 - (txtAss.Text.Length + 3)
        NumMsgs = (txtMensagem.Text.Trim.Length \ MaxUma) + 1
        CarRest = (MaxUma * NumMsgs) - txtMensagem.Text.Length
    End Sub

    Private Sub txtMensagem_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMensagem.TextChanged
        Dim nm As Integer
        Dim cr As Integer
        CalcularNumMsgs(nm, cr, Nothing)
        panStatus.Text = nm.ToString & " mensagem(ns) / " & cr.ToString & " caractere(s) restantes"
    End Sub

    Private Sub txtAss_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAss.TextChanged
        txtMensagem_TextChanged(sender, e)
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        e.Link.Visited = True
        System.Diagnostics.Process.Start("mailto:marciusbezerra@yahoo.com.br")
    End Sub

    Private Sub txtDDD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDDD.TextChanged
        If txtDDD.SelectionStart = txtDDD.MaxLength Then txtNumCel.Focus()
    End Sub

    Private Sub txtNumCel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumCel.TextChanged
        If txtNumCel.SelectionStart = txtNumCel.MaxLength Then txtMensagem.Focus()
    End Sub

    Private Sub txtDDD_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDDD.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumCel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumCel.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtMensagem_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMensagem.KeyPress
        Select Case e.KeyChar
            Case Chr(9)
                e.Handled = True
                SendKeys.Send(" ")
            Case "#", "&", "%", "@", "_", "‚", "„", "…", "†", "‡", "‰", _
                "‹", "‘", "’", """", """", "•", "–", "—", "›", "¡", "«", "­", _
                "·", "»", "¿", "$", "+", "^", "`", "|", "~", "€", "ˆ", "˜", _
                "™", "¢", "£", "¤", "¥", "¦", "§", "¨", "©", "¬", "®", "¯", _
                "°", "±", "´", "¶", "¸", "×", "÷", "ƒ", "Š", "Œ", "Ž", "š", _
                "œ", "ž", "Ÿ", "µ", "Ð", "Ý", "Þ", "ß", "æ", "ð", "ý", "þ", "ÿ"
                e.Handled = True
            Case "ª", "º"
                e.Handled = True
                SendKeys.Send("o.")
            Case "À", "Á", "Â", "Ã", "Ä", "Å", "à", "á", "â", "ã", "ä", "å"
                e.Handled = True
                EnviaTecla("A", Char.IsUpper(e.KeyChar))
            Case "È", "É", "Ê", "Ë", "è", "é", "ê", "ë", "Æ"
                e.Handled = True
                EnviaTecla("E", Char.IsUpper(e.KeyChar))
            Case "ì", "í", "î", "ï", "Ì", "Í", "Î", "Ï"
                e.Handled = True
                EnviaTecla("I", Char.IsUpper(e.KeyChar))
            Case "Ò", "Ó", "Ô", "Õ", "Ö", "ò", "ó", "ô", "õ", "ö"
                e.Handled = True
                EnviaTecla("O", Char.IsUpper(e.KeyChar))
            Case "Ù", "Ú", "Û", "Ü", "ù", "ú", "û", "ü"
                e.Handled = True
                EnviaTecla("U", Char.IsUpper(e.KeyChar))
            Case "Ø", "ø"
                e.Handled = True
                EnviaTecla("0", Char.IsUpper(e.KeyChar))
            Case "Ç", "ç"
                e.Handled = True
                EnviaTecla("C", Char.IsUpper(e.KeyChar))
            Case "Ñ", "ñ"
                e.Handled = True
                EnviaTecla("NAO", Char.IsUpper(e.KeyChar))
            Case Else
                If Char.IsNumber(e.KeyChar) And Not Char.IsDigit(e.KeyChar) Then
                    e.Handled = True
                End If
        End Select
    End Sub

    Private Sub EnviaTecla(ByVal Letra As String, ByVal CaixaAlta As Boolean)
        If CaixaAlta Then
            SendKeys.Send(Letra.ToUpper)
        Else
            SendKeys.Send(Letra.ToLower)
        End If
    End Sub

    Private Sub txtAss_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAss.KeyPress
        Select Case e.KeyChar
            Case "A" To "z", "a" To "z"
                e.Handled = False
            Case Else
                If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
                    e.Handled = True
                End If
        End Select
    End Sub
End Class
