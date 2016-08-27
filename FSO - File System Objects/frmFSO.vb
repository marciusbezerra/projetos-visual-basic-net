Public Class frmFSO
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
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtOrigem As System.Windows.Forms.TextBox
    Friend WithEvents txtDestino As System.Windows.Forms.TextBox
    Friend WithEvents lnkOrigem As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkDestino As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkCopia As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkPegaInfo As System.Windows.Forms.LinkLabel
    Friend WithEvents driDisco As Microsoft.VisualBasic.Compatibility.VB6.DriveListBox
    Friend WithEvents txtTexto As System.Windows.Forms.TextBox
    Friend WithEvents lnkCriarArquivo As System.Windows.Forms.LinkLabel
    Friend WithEvents SFD As System.Windows.Forms.SaveFileDialog
    Friend WithEvents FD As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents lblInfoDisco As System.Windows.Forms.Label
    Friend WithEvents lblNomeVolume As System.Windows.Forms.Label
    Friend WithEvents lblTipoDrive As System.Windows.Forms.Label
    Friend WithEvents lblNumeroSerie As System.Windows.Forms.Label
    Friend WithEvents lblTamTotal As System.Windows.Forms.Label
    Friend WithEvents lblArquivo As System.Windows.Forms.Label
    Friend WithEvents lnkSalvar As System.Windows.Forms.LinkLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtOrigem = New System.Windows.Forms.TextBox
        Me.txtDestino = New System.Windows.Forms.TextBox
        Me.lnkOrigem = New System.Windows.Forms.LinkLabel
        Me.lnkDestino = New System.Windows.Forms.LinkLabel
        Me.lnkCopia = New System.Windows.Forms.LinkLabel
        Me.lblInfoDisco = New System.Windows.Forms.Label
        Me.lblNomeVolume = New System.Windows.Forms.Label
        Me.lblTipoDrive = New System.Windows.Forms.Label
        Me.lblNumeroSerie = New System.Windows.Forms.Label
        Me.lblTamTotal = New System.Windows.Forms.Label
        Me.lnkPegaInfo = New System.Windows.Forms.LinkLabel
        Me.driDisco = New Microsoft.VisualBasic.Compatibility.VB6.DriveListBox
        Me.txtTexto = New System.Windows.Forms.TextBox
        Me.lnkCriarArquivo = New System.Windows.Forms.LinkLabel
        Me.SFD = New System.Windows.Forms.SaveFileDialog
        Me.FD = New System.Windows.Forms.FolderBrowserDialog
        Me.lblArquivo = New System.Windows.Forms.Label
        Me.lnkSalvar = New System.Windows.Forms.LinkLabel
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(24, 32)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(448, 272)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lnkCopia)
        Me.TabPage1.Controls.Add(Me.lnkDestino)
        Me.TabPage1.Controls.Add(Me.lnkOrigem)
        Me.TabPage1.Controls.Add(Me.txtDestino)
        Me.TabPage1.Controls.Add(Me.txtOrigem)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(440, 246)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Copiando arquivos e pastas"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.driDisco)
        Me.TabPage2.Controls.Add(Me.lnkPegaInfo)
        Me.TabPage2.Controls.Add(Me.lblTamTotal)
        Me.TabPage2.Controls.Add(Me.lblNumeroSerie)
        Me.TabPage2.Controls.Add(Me.lblTipoDrive)
        Me.TabPage2.Controls.Add(Me.lblNomeVolume)
        Me.TabPage2.Controls.Add(Me.lblInfoDisco)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(440, 246)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Informações do disco"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.lnkSalvar)
        Me.TabPage3.Controls.Add(Me.lblArquivo)
        Me.TabPage3.Controls.Add(Me.lnkCriarArquivo)
        Me.TabPage3.Controls.Add(Me.txtTexto)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(440, 246)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Lendo e gravando arquivos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pasta de origem:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Pasta de destino:"
        '
        'txtOrigem
        '
        Me.txtOrigem.Location = New System.Drawing.Point(24, 40)
        Me.txtOrigem.Name = "txtOrigem"
        Me.txtOrigem.Size = New System.Drawing.Size(320, 20)
        Me.txtOrigem.TabIndex = 1
        Me.txtOrigem.Text = ""
        '
        'txtDestino
        '
        Me.txtDestino.Location = New System.Drawing.Point(24, 96)
        Me.txtDestino.Name = "txtDestino"
        Me.txtDestino.Size = New System.Drawing.Size(320, 20)
        Me.txtDestino.TabIndex = 5
        Me.txtDestino.Text = ""
        '
        'lnkOrigem
        '
        Me.lnkOrigem.AutoSize = True
        Me.lnkOrigem.Location = New System.Drawing.Point(352, 40)
        Me.lnkOrigem.Name = "lnkOrigem"
        Me.lnkOrigem.Size = New System.Drawing.Size(14, 16)
        Me.lnkOrigem.TabIndex = 2
        Me.lnkOrigem.TabStop = True
        Me.lnkOrigem.Text = "..."
        '
        'lnkDestino
        '
        Me.lnkDestino.AutoSize = True
        Me.lnkDestino.Location = New System.Drawing.Point(352, 96)
        Me.lnkDestino.Name = "lnkDestino"
        Me.lnkDestino.Size = New System.Drawing.Size(14, 16)
        Me.lnkDestino.TabIndex = 6
        Me.lnkDestino.TabStop = True
        Me.lnkDestino.Text = "..."
        '
        'lnkCopia
        '
        Me.lnkCopia.AutoSize = True
        Me.lnkCopia.Location = New System.Drawing.Point(168, 160)
        Me.lnkCopia.Name = "lnkCopia"
        Me.lnkCopia.Size = New System.Drawing.Size(198, 16)
        Me.lnkCopia.TabIndex = 0
        Me.lnkCopia.TabStop = True
        Me.lnkCopia.Text = "Realizar a cópia dos arquivos e pastas"
        '
        'lblInfoDisco
        '
        Me.lblInfoDisco.AutoSize = True
        Me.lblInfoDisco.Location = New System.Drawing.Point(32, 24)
        Me.lblInfoDisco.Name = "lblInfoDisco"
        Me.lblInfoDisco.Size = New System.Drawing.Size(112, 16)
        Me.lblInfoDisco.TabIndex = 0
        Me.lblInfoDisco.Text = "Informações do disco"
        '
        'lblNomeVolume
        '
        Me.lblNomeVolume.AutoSize = True
        Me.lblNomeVolume.Location = New System.Drawing.Point(32, 56)
        Me.lblNomeVolume.Name = "lblNomeVolume"
        Me.lblNomeVolume.Size = New System.Drawing.Size(93, 16)
        Me.lblNomeVolume.TabIndex = 1
        Me.lblNomeVolume.Text = "Nome do volume:"
        '
        'lblTipoDrive
        '
        Me.lblTipoDrive.AutoSize = True
        Me.lblTipoDrive.Location = New System.Drawing.Point(32, 80)
        Me.lblTipoDrive.Name = "lblTipoDrive"
        Me.lblTipoDrive.Size = New System.Drawing.Size(73, 16)
        Me.lblTipoDrive.TabIndex = 2
        Me.lblTipoDrive.Text = "Tipo de drive:"
        '
        'lblNumeroSerie
        '
        Me.lblNumeroSerie.AutoSize = True
        Me.lblNumeroSerie.Location = New System.Drawing.Point(32, 104)
        Me.lblNumeroSerie.Name = "lblNumeroSerie"
        Me.lblNumeroSerie.Size = New System.Drawing.Size(91, 16)
        Me.lblNumeroSerie.TabIndex = 3
        Me.lblNumeroSerie.Text = "Número de série:"
        '
        'lblTamTotal
        '
        Me.lblTamTotal.AutoSize = True
        Me.lblTamTotal.Location = New System.Drawing.Point(32, 128)
        Me.lblTamTotal.Name = "lblTamTotal"
        Me.lblTamTotal.Size = New System.Drawing.Size(80, 16)
        Me.lblTamTotal.TabIndex = 4
        Me.lblTamTotal.Text = "Tamanho total:"
        '
        'lnkPegaInfo
        '
        Me.lnkPegaInfo.AutoSize = True
        Me.lnkPegaInfo.Location = New System.Drawing.Point(200, 184)
        Me.lnkPegaInfo.Name = "lnkPegaInfo"
        Me.lnkPegaInfo.Size = New System.Drawing.Size(144, 16)
        Me.lnkPegaInfo.TabIndex = 5
        Me.lnkPegaInfo.TabStop = True
        Me.lnkPegaInfo.Text = "Pegar informações do disco"
        '
        'driDisco
        '
        Me.driDisco.Location = New System.Drawing.Point(40, 184)
        Me.driDisco.Name = "driDisco"
        Me.driDisco.Size = New System.Drawing.Size(136, 21)
        Me.driDisco.TabIndex = 6
        '
        'txtTexto
        '
        Me.txtTexto.Location = New System.Drawing.Point(16, 32)
        Me.txtTexto.Multiline = True
        Me.txtTexto.Name = "txtTexto"
        Me.txtTexto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTexto.Size = New System.Drawing.Size(408, 176)
        Me.txtTexto.TabIndex = 0
        Me.txtTexto.Text = ""
        '
        'lnkCriarArquivo
        '
        Me.lnkCriarArquivo.AutoSize = True
        Me.lnkCriarArquivo.Location = New System.Drawing.Point(16, 216)
        Me.lnkCriarArquivo.Name = "lnkCriarArquivo"
        Me.lnkCriarArquivo.Size = New System.Drawing.Size(131, 16)
        Me.lnkCriarArquivo.TabIndex = 1
        Me.lnkCriarArquivo.TabStop = True
        Me.lnkCriarArquivo.Text = "Criar um arquivo de texto"
        '
        'SFD
        '
        Me.SFD.Filter = "Arquivos de texto (*.txt)|*.txt"
        Me.SFD.Title = "Onde salvar?"
        '
        'lblArquivo
        '
        Me.lblArquivo.Location = New System.Drawing.Point(16, 8)
        Me.lblArquivo.Name = "lblArquivo"
        Me.lblArquivo.Size = New System.Drawing.Size(408, 16)
        Me.lblArquivo.TabIndex = 2
        '
        'lnkSalvar
        '
        Me.lnkSalvar.AutoSize = True
        Me.lnkSalvar.Enabled = False
        Me.lnkSalvar.Location = New System.Drawing.Point(288, 216)
        Me.lnkSalvar.Name = "lnkSalvar"
        Me.lnkSalvar.Size = New System.Drawing.Size(139, 16)
        Me.lnkSalvar.TabIndex = 3
        Me.lnkSalvar.TabStop = True
        Me.lnkSalvar.Text = "Salvar texto para o arquivo"
        '
        'frmFSO
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(504, 373)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmFSO"
        Me.Text = "FSO - File System Objects"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub lnkOrigem_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkOrigem.LinkClicked
        If FD.ShowDialog = DialogResult.OK Then
            txtOrigem.Text = FD.SelectedPath
        End If
    End Sub

    Private Sub lnkDestino_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkDestino.LinkClicked
        If FD.ShowDialog = DialogResult.OK Then
            txtDestino.Text = FD.SelectedPath
        End If
    End Sub

    Private Sub lnkCopia_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkCopia.LinkClicked
        Dim FSO As Scripting.FileSystemObject
        Try
            FSO = New Scripting.FileSystemObject
            If Not FSO.FolderExists(txtDestino.Text) Then
                If MsgBox(txtDestino.Text & " não existe, deseja criar?", _
                    MsgBoxStyle.YesNo, Text) = MsgBoxResult.No Then Exit Try
                FSO.CreateFolder(txtDestino.Text)
            End If
            FSO.CopyFolder(txtOrigem.Text, txtDestino.Text)
            MsgBox("Arquivo(s) copiado(s)", MsgBoxStyle.Information, Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Text)
        Finally
            FSO = Nothing
        End Try
    End Sub

    Private Sub lnkPegaInfo_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkPegaInfo.LinkClicked
        Dim FSO As Scripting.FileSystemObject
        Dim fsoDrive As Scripting.Drive
        Try
            FSO = New Scripting.FileSystemObject
            fsoDrive = FSO.GetDrive(Strings.Left(driDisco.Drive, 2))
            With fsoDrive
                If .IsReady Then
                    lblInfoDisco.Text = "Informações do disco " & .DriveLetter & ":"
                    lblNomeVolume.Text = "Nome do volume: " & .VolumeName
                    lblTipoDrive.Text = "Tipo de drive: " & .DriveType.ToString
                    lblNumeroSerie.Text = "Número de série: " & .SerialNumber.ToString
                    lblTamTotal.Text = "Tamanho total: " & _
                        FormatNumber(CDbl(.TotalSize) / 1024 / 1024, 2) & " MB"
                Else
                    MsgBox("Insira um disco no drive " & driDisco.Drive & _
                        ", e tente novamente.", MsgBoxStyle.Information, Text)
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Text)
        Finally
            fsoDrive = Nothing
            FSO = Nothing
        End Try
    End Sub

    Private Sub lnkCriarArquivo_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkCriarArquivo.LinkClicked
        Dim f As Scripting.TextStream
        Dim FSO As Scripting.FileSystemObject
        Try
            If SFD.ShowDialog = DialogResult.OK Then
                FSO = New Scripting.FileSystemObject
                f = FSO.CreateTextFile(SFD.FileName)
                f.Close()
                lnkSalvar.Enabled = True
                lblArquivo.Text = SFD.FileName
                lnkCriarArquivo.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Text)
        Finally
            f = Nothing
            FSO = Nothing
        End Try
    End Sub

    Private Sub lnkSalvar_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkSalvar.LinkClicked
        Dim f As Scripting.TextStream
        Dim FSO As Scripting.FileSystemObject
        Try
            FSO = New Scripting.FileSystemObject
            f = FSO.OpenTextFile(lblArquivo.Text, _
                Scripting.IOMode.ForWriting, False, Scripting.Tristate.TristateFalse)
            f.Write(txtTexto.Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Text)
        Finally
            If Not IsNothing(f) Then
                f.Close()
                f = Nothing
            End If
            FSO = Nothing
        End Try
    End Sub
End Class
