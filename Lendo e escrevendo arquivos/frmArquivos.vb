Public Class frmArquivos
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
    Friend WithEvents txtArquivo As System.Windows.Forms.TextBox
    Friend WithEvents txtLinhas As System.Windows.Forms.TextBox
    Friend WithEvents txtNovaLinha As System.Windows.Forms.TextBox
    Friend WithEvents btnLer As System.Windows.Forms.Button
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents btnSubstituir As System.Windows.Forms.Button
    Friend WithEvents btnAnexar As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents OD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SD As System.Windows.Forms.SaveFileDialog
    Friend WithEvents lblDica As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtArquivo = New System.Windows.Forms.TextBox
        Me.txtLinhas = New System.Windows.Forms.TextBox
        Me.txtNovaLinha = New System.Windows.Forms.TextBox
        Me.btnLer = New System.Windows.Forms.Button
        Me.btnLimpar = New System.Windows.Forms.Button
        Me.btnSubstituir = New System.Windows.Forms.Button
        Me.btnAnexar = New System.Windows.Forms.Button
        Me.btnSalvar = New System.Windows.Forms.Button
        Me.btnSair = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.OD = New System.Windows.Forms.OpenFileDialog
        Me.SD = New System.Windows.Forms.SaveFileDialog
        Me.lblDica = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtArquivo
        '
        Me.txtArquivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtArquivo.Location = New System.Drawing.Point(16, 24)
        Me.txtArquivo.Name = "txtArquivo"
        Me.txtArquivo.ReadOnly = True
        Me.txtArquivo.Size = New System.Drawing.Size(552, 20)
        Me.txtArquivo.TabIndex = 1
        Me.txtArquivo.TabStop = False
        Me.txtArquivo.Text = ""
        '
        'txtLinhas
        '
        Me.txtLinhas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLinhas.Location = New System.Drawing.Point(16, 64)
        Me.txtLinhas.Multiline = True
        Me.txtLinhas.Name = "txtLinhas"
        Me.txtLinhas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLinhas.Size = New System.Drawing.Size(464, 320)
        Me.txtLinhas.TabIndex = 4
        Me.txtLinhas.Text = ""
        '
        'txtNovaLinha
        '
        Me.txtNovaLinha.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNovaLinha.Location = New System.Drawing.Point(16, 408)
        Me.txtNovaLinha.Name = "txtNovaLinha"
        Me.txtNovaLinha.Size = New System.Drawing.Size(584, 20)
        Me.txtNovaLinha.TabIndex = 11
        Me.txtNovaLinha.Text = ""
        '
        'btnLer
        '
        Me.btnLer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLer.Location = New System.Drawing.Point(576, 24)
        Me.btnLer.Name = "btnLer"
        Me.btnLer.Size = New System.Drawing.Size(24, 24)
        Me.btnLer.TabIndex = 2
        Me.btnLer.Text = "&..."
        '
        'btnLimpar
        '
        Me.btnLimpar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLimpar.Location = New System.Drawing.Point(488, 64)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(112, 24)
        Me.btnLimpar.TabIndex = 5
        Me.btnLimpar.Text = "L&impar"
        '
        'btnSubstituir
        '
        Me.btnSubstituir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSubstituir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSubstituir.Location = New System.Drawing.Point(488, 96)
        Me.btnSubstituir.Name = "btnSubstituir"
        Me.btnSubstituir.Size = New System.Drawing.Size(112, 24)
        Me.btnSubstituir.TabIndex = 6
        Me.btnSubstituir.Text = "&Substituir arquivo"
        '
        'btnAnexar
        '
        Me.btnAnexar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAnexar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAnexar.Location = New System.Drawing.Point(488, 128)
        Me.btnAnexar.Name = "btnAnexar"
        Me.btnAnexar.Size = New System.Drawing.Size(112, 24)
        Me.btnAnexar.TabIndex = 7
        Me.btnAnexar.Text = "&Anexa linha"
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSalvar.Location = New System.Drawing.Point(488, 160)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(112, 24)
        Me.btnSalvar.TabIndex = 8
        Me.btnSalvar.Text = "Sal&var"
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSair.Location = New System.Drawing.Point(488, 360)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(112, 24)
        Me.btnSair.TabIndex = 12
        Me.btnSair.Text = "Sai&r"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Arquivo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Conteúdo:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 392)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Nova linha:"
        '
        'OD
        '
        Me.OD.Filter = "Arquivos de texto (*.txt)|*.txt|Qualquer arquivo (*.*)|*.*"
        '
        'SD
        '
        Me.SD.Filter = "Arquivos de texto (*.txt)|*.txt|Qualquer arquivo|*.*"
        Me.SD.Title = "Substituir o arquivo..."
        '
        'lblDica
        '
        Me.lblDica.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDica.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDica.ForeColor = System.Drawing.Color.IndianRed
        Me.lblDica.Location = New System.Drawing.Point(488, 192)
        Me.lblDica.Name = "lblDica"
        Me.lblDica.Size = New System.Drawing.Size(112, 160)
        Me.lblDica.TabIndex = 13
        Me.lblDica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmArquivos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(616, 438)
        Me.Controls.Add(Me.lblDica)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnAnexar)
        Me.Controls.Add(Me.btnSubstituir)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.btnLer)
        Me.Controls.Add(Me.txtNovaLinha)
        Me.Controls.Add(Me.txtLinhas)
        Me.Controls.Add(Me.txtArquivo)
        Me.Name = "frmArquivos"
        Me.Text = "VB.NET - Acesso a arquivos de texto"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLer.Click
        If OD.ShowDialog() <> DialogResult.OK Then Exit Sub
        Dim Fluxo As System.IO.StreamReader
        Dim Linha As String
        txtArquivo.Text = OD.FileName
        If System.IO.File.Exists(txtArquivo.Text) Then
            Try
                Fluxo = New System.IO.StreamReader(txtArquivo.Text)
                txtLinhas.Clear()
                Linha = Fluxo.ReadLine
                While Not Linha Is Nothing
                    txtLinhas.Text &= Linha & vbCrLf
                    Linha = Fluxo.ReadLine
                End While
            Catch ex As Exception
                MsgBox("Ocorreu um erro: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                Fluxo.Close()
            End Try
        Else
                MsgBox("O arquivo especificado não existe.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpar.Click
        txtLinhas.Clear()
    End Sub

    Private Sub btnSubstituir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubstituir.Click
        If Not SD.ShowDialog = DialogResult.OK Then Exit Sub
        Dim Fluxo As System.IO.StreamWriter
        Dim Linha As String
        If System.IO.File.Exists(SD.FileName) Then
            Try
                Fluxo = New System.IO.StreamWriter(SD.FileName)
                Fluxo.WriteLine(txtLinhas.Text.Trim)
            Catch ex As Exception
                MsgBox("Ocorreu um erro: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                Fluxo.Close()
            End Try
        Else
            MsgBox("O arquivo informado não existe.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnAnexar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnexar.Click
        If txtArquivo.Text.Trim = "" Then
            MsgBox("Selecione primeiro um arquivo.", MsgBoxStyle.Information)
            btnLer_Click(sender, e)
            Exit Sub
        End If
        If txtNovaLinha.Text.Trim = "" Then
            MsgBox("Digite a nova linha primeiro.", MsgBoxStyle.Information)
            txtNovaLinha.Focus()
            Exit Sub
        End If
        Dim Fluxo As System.IO.StreamWriter
        Dim Linha As String
        If System.IO.File.Exists(txtArquivo.Text) Then
            Try
                txtLinhas.Text &= txtNovaLinha.Text.Trim
                Fluxo = New System.IO.StreamWriter(txtArquivo.Text)
                Fluxo.WriteLine(txtLinhas.Text)
            Catch ex As Exception
                MsgBox("Ocorreu um erro: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                Fluxo.Close()
            End Try
        Else
            MsgBox("O arquivo especificado não existe.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        If txtArquivo.Text.Trim <> "" Then
            If Not System.IO.File.Exists(txtArquivo.Text) Then
                MsgBox("O arquivo aberto não existe mais.", MsgBoxStyle.Information)
            Else
                If txtLinhas.Text.Trim <> "" Then
                    Dim Fluxo As System.IO.StreamWriter
                    Try
                        Fluxo = New System.IO.StreamWriter(txtArquivo.Text)
                        Fluxo.WriteLine(txtLinhas.Text.Trim)
                    Catch ex As Exception
                        MsgBox("Ocorreu um erro: " & ex.Message, MsgBoxStyle.Critical)
                    Finally
                        Fluxo.Close()
                    End Try
                End If
            End If
        Else
            Dim SalvarComo As New SaveFileDialog
            SalvarComo.CheckFileExists = False
            SalvarComo.AddExtension = True
            SalvarComo.Filter = "Arquivos de texto (*.txt)|*.txt|Qualquer arquivo|*.*"
            If SalvarComo.ShowDialog = DialogResult.OK Then
                Dim Arquivo As String = SalvarComo.FileName
                Dim Fluxo As System.IO.StreamWriter
                Try
                    Fluxo = New System.IO.StreamWriter(Arquivo)
                    Fluxo.WriteLine(txtLinhas.Text.Trim)
                Catch ex As Exception
                    MsgBox("Ocorreu um erro: " & ex.Message, MsgBoxStyle.Critical)
                Finally
                    fluxo.Close()
                End Try
            End If
        End If
    End Sub

    Private Sub btnLimpar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLimpar.MouseEnter
        lblDica.Text = "Limpa todo o conteúdo do texto ao lado"
    End Sub

    Private Sub btnLimpar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLimpar.MouseLeave
        lblDica.Text = ""
    End Sub

    Private Sub btnSubstituir_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSubstituir.MouseEnter
        lblDica.Text = "Sobrescreve o texto escrito ao lado em um arquivo a ser selecionado"
    End Sub

    Private Sub btnSubstituir_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSubstituir.MouseLeave
        lblDica.Text = ""
    End Sub

    Private Sub btnAnexar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAnexar.MouseEnter
        lblDica.Text = "Adiciona a linha digitada na caixa abaixo ao arquivo aberto"
    End Sub

    Private Sub btnAnexar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAnexar.MouseLeave
        lblDica.Text = ""
    End Sub

    Private Sub btnSalvar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSalvar.MouseEnter
        lblDica.Text = "Salva as alterações feitas"
    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        If MsgBox("Qualquer alteração feita ainda não salva será perdida." & vbCrLf & _
            "Sair?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2) _
            = MsgBoxResult.Yes Then Close()
    End Sub
End Class
