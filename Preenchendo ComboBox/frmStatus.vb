Public Class frmStatus
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
    Friend WithEvents lblMensagem As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblMensagem = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblMensagem
        '
        Me.lblMensagem.Location = New System.Drawing.Point(8, 32)
        Me.lblMensagem.Name = "lblMensagem"
        Me.lblMensagem.Size = New System.Drawing.Size(216, 24)
        Me.lblMensagem.TabIndex = 0
        Me.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmStatus
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(232, 94)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblMensagem)
        Me.Name = "frmStatus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Status"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Overloads Sub Show(ByVal Mensagem As String)
        lblMensagem.Text = Mensagem
        Show()
        Application.DoEvents()
    End Sub
End Class
