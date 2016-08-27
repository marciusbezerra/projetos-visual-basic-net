Public Class frmPrimeiro
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
    Friend WithEvents txtTexto As System.Windows.Forms.TextBox
    Friend WithEvents btnChama As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtTexto = New System.Windows.Forms.TextBox
        Me.btnChama = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtTexto
        '
        Me.txtTexto.Location = New System.Drawing.Point(32, 72)
        Me.txtTexto.Name = "txtTexto"
        Me.txtTexto.Size = New System.Drawing.Size(224, 20)
        Me.txtTexto.TabIndex = 0
        Me.txtTexto.Text = ""
        '
        'btnChama
        '
        Me.btnChama.Location = New System.Drawing.Point(32, 104)
        Me.btnChama.Name = "btnChama"
        Me.btnChama.Size = New System.Drawing.Size(224, 32)
        Me.btnChama.TabIndex = 1
        Me.btnChama.Text = "&Segundo Form"
        '
        'frmPrimeiro
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.btnChama)
        Me.Controls.Add(Me.txtTexto)
        Me.Name = "frmPrimeiro"
        Me.Text = "Primeiro Form"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnChama_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChama.Click
        Dim fSeg As New frmSegundo
        fSeg.txtTexto.Text = txtTexto.Text
        fSeg.ShowDialog()
    End Sub
End Class
