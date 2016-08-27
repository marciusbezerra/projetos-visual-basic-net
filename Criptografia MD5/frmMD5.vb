Public Class frmMD5
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblHash As System.Windows.Forms.Label
    Friend WithEvents btnGerarHash As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblHashArquivo As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSenha = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblHash = New System.Windows.Forms.Label
        Me.btnGerarHash = New System.Windows.Forms.Button
        Me.lblHashArquivo = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.ofd = New System.Windows.Forms.OpenFileDialog
        Me.Label3 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Senha:"
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(10, 32)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.Size = New System.Drawing.Size(206, 20)
        Me.txtSenha.TabIndex = 1
        Me.txtSenha.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Hash da senha:"
        '
        'lblHash
        '
        Me.lblHash.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHash.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHash.Location = New System.Drawing.Point(10, 79)
        Me.lblHash.Name = "lblHash"
        Me.lblHash.Size = New System.Drawing.Size(318, 25)
        Me.lblHash.TabIndex = 3
        Me.lblHash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGerarHash
        '
        Me.btnGerarHash.Location = New System.Drawing.Point(200, 120)
        Me.btnGerarHash.Name = "btnGerarHash"
        Me.btnGerarHash.Size = New System.Drawing.Size(128, 32)
        Me.btnGerarHash.TabIndex = 4
        Me.btnGerarHash.Text = "&Gerar hash MD5!"
        '
        'lblHashArquivo
        '
        Me.lblHashArquivo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHashArquivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHashArquivo.Location = New System.Drawing.Point(10, 200)
        Me.lblHashArquivo.Name = "lblHashArquivo"
        Me.lblHashArquivo.Size = New System.Drawing.Size(318, 25)
        Me.lblHashArquivo.TabIndex = 6
        Me.lblHashArquivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Hash do arquivo:"
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(8, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(320, 24)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "A parte de arquivo ainda não deu certo"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMD5
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(336, 273)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblHashArquivo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnGerarHash)
        Me.Controls.Add(Me.lblHash)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMD5"
        Me.Text = "Criptografia MD5"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnGerarHash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGerarHash.Click
        Dim MD5 As ClassMD5
        Dim Titulo As String = Text
        If txtSenha.Text.Trim = String.Empty Then
            MessageBox.Show("É necessário uma senha.", Text)
        Else
            Try

                MD5 = New ClassMD5
                lblHash.Text = MD5.DigestStrToHexStr(txtSenha.Text.Trim)
                If ofd.ShowDialog(Me) = DialogResult.OK Then
                    Text = Titulo & " - Aguarde..."
                    btnGerarHash.Enabled = False
                    Refresh()
                    Cursors.Default.Show()
                    lblHashArquivo.Text = MD5.DigestFileToHexStr(ofd.FileName)
                End If
            Catch Erro As Exception
                MsgBox(Erro.Message, MsgBoxStyle.Critical, Titulo)
            Finally
                btnGerarHash.Enabled = True
                Text = Titulo
                MD5 = Nothing
                Cursors.Default.Show()
            End Try
        End If
    End Sub
End Class
