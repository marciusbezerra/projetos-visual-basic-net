Public Class frmSegundo
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
    Friend WithEvents btnChama As System.Windows.Forms.Button
    Friend WithEvents txtTexto As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnChama = New System.Windows.Forms.Button
        Me.txtTexto = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'btnChama
        '
        Me.btnChama.Location = New System.Drawing.Point(34, 133)
        Me.btnChama.Name = "btnChama"
        Me.btnChama.Size = New System.Drawing.Size(224, 32)
        Me.btnChama.TabIndex = 3
        Me.btnChama.Text = "&Fecha primeiro Form"
        '
        'txtTexto
        '
        Me.txtTexto.Location = New System.Drawing.Point(34, 101)
        Me.txtTexto.Name = "txtTexto"
        Me.txtTexto.Size = New System.Drawing.Size(224, 20)
        Me.txtTexto.TabIndex = 2
        Me.txtTexto.Text = ""
        '
        'frmSegundo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.btnChama)
        Me.Controls.Add(Me.txtTexto)
        Me.Name = "frmSegundo"
        Me.Text = "Segundo Form"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnChama_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChama.Click
        fPrimeiro.Hide()
    End Sub
End Class
