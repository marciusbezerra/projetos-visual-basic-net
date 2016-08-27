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
    Friend WithEvents txtURL As System.Windows.Forms.TextBox
    Friend WithEvents txtPagina As System.Windows.Forms.TextBox
    Friend WithEvents btnDownload As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtURL = New System.Windows.Forms.TextBox
        Me.txtPagina = New System.Windows.Forms.TextBox
        Me.btnDownload = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtURL
        '
        Me.txtURL.Location = New System.Drawing.Point(16, 24)
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(480, 20)
        Me.txtURL.TabIndex = 0
        Me.txtURL.Text = ""
        '
        'txtPagina
        '
        Me.txtPagina.Location = New System.Drawing.Point(16, 72)
        Me.txtPagina.Multiline = True
        Me.txtPagina.Name = "txtPagina"
        Me.txtPagina.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPagina.Size = New System.Drawing.Size(480, 328)
        Me.txtPagina.TabIndex = 1
        Me.txtPagina.Text = ""
        '
        'btnDownload
        '
        Me.btnDownload.Location = New System.Drawing.Point(368, 408)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(128, 24)
        Me.btnDownload.TabIndex = 2
        Me.btnDownload.Text = "Download"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "URL:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Página:"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(512, 446)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDownload)
        Me.Controls.Add(Me.txtPagina)
        Me.Controls.Add(Me.txtURL)
        Me.Name = "Form1"
        Me.Text = "Download HTTP"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnDownload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDownload.Click
        Dim strPagina As String
        Dim Web As New DownloadURL
        Web.URL = txtURL.Text.Trim
        Web.DownloadURL(strPagina)
        txtPagina.Text = strPagina
        Web = Nothing
    End Sub
End Class
