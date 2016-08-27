
Imports System.Drawing

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
    Friend WithEvents lstArquivos As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnConvert As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents OpenFoto As System.Windows.Forms.OpenFileDialog
    Friend WithEvents pb As System.Windows.Forms.ProgressBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lstArquivos = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnConvert = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.pb = New System.Windows.Forms.ProgressBar
        Me.OpenFoto = New System.Windows.Forms.OpenFileDialog
        Me.SuspendLayout()
        '
        'lstArquivos
        '
        Me.lstArquivos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstArquivos.Location = New System.Drawing.Point(8, 24)
        Me.lstArquivos.Name = "lstArquivos"
        Me.lstArquivos.Size = New System.Drawing.Size(464, 225)
        Me.lstArquivos.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(9, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lista de arquivos:"
        '
        'btnConvert
        '
        Me.btnConvert.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConvert.Location = New System.Drawing.Point(488, 224)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(152, 24)
        Me.btnConvert.TabIndex = 3
        Me.btnConvert.Text = "&Converter"
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Location = New System.Drawing.Point(488, 192)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(152, 24)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "&Adicionar..."
        '
        'pb
        '
        Me.pb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pb.Location = New System.Drawing.Point(8, 256)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(632, 16)
        Me.pb.TabIndex = 4
        '
        'OpenFoto
        '
        Me.OpenFoto.Filter = "Bitmaps|*.bmp|Qualquer arquivo|*.*"
        '
        'FormMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(648, 278)
        Me.Controls.Add(Me.pb)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstArquivos)
        Me.Name = "FormMain"
        Me.Text = "Conversor BMP para JPEG"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If OpenFoto.ShowDialog() = DialogResult.OK Then
            lstArquivos.Items.Add(OpenFoto.FileName)
        End If
    End Sub

    Private Sub btnConvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvert.Click
        Dim i As Integer = 0
        If lstArquivos.Items.Count = 0 Then
            MsgBox("Nenhum arquivo selecionado.", MsgBoxStyle.Information, "Selecionar arquivo")
        End If
        pb.Minimum = 0
        pb.Maximum = lstArquivos.Items.Count - 1
        For i = 0 To lstArquivos.Items.Count - 1
            Converter(lstArquivos.Items(i))
            pb.Value = i
        Next
    End Sub

    Private Sub Converter(ByVal Arquivo As String)
        Dim Bmp As New Bitmap(Arquivo)
        Try
            Bmp.Save(Arquivo + ".jpg", Imaging.ImageFormat.Jpeg)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERRO")
        Finally
            Bmp.Dispose()
        End Try
    End Sub
End Class
