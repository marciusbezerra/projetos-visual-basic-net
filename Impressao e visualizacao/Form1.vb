Public Class FormImprime
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
    Friend WithEvents btnVisualizar As System.Windows.Forms.Button
    Friend WithEvents ppdVisualiza As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents docDocumento As System.Drawing.Printing.PrintDocument
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormImprime))
        Me.ppdVisualiza = New System.Windows.Forms.PrintPreviewDialog
        Me.docDocumento = New System.Drawing.Printing.PrintDocument
        Me.btnVisualizar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'ppdVisualiza
        '
        Me.ppdVisualiza.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.ppdVisualiza.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.ppdVisualiza.ClientSize = New System.Drawing.Size(400, 300)
        Me.ppdVisualiza.Document = Me.docDocumento
        Me.ppdVisualiza.Enabled = True
        Me.ppdVisualiza.Icon = CType(resources.GetObject("ppdVisualiza.Icon"), System.Drawing.Icon)
        Me.ppdVisualiza.Location = New System.Drawing.Point(44, 58)
        Me.ppdVisualiza.MinimumSize = New System.Drawing.Size(375, 250)
        Me.ppdVisualiza.Name = "ppdVisualiza"
        Me.ppdVisualiza.TransparencyKey = System.Drawing.Color.Empty
        Me.ppdVisualiza.Visible = False
        '
        'docDocumento
        '
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Location = New System.Drawing.Point(176, 96)
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Size = New System.Drawing.Size(200, 48)
        Me.btnVisualizar.TabIndex = 0
        Me.btnVisualizar.Text = "&Visualizar"
        '
        'FormImprime
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(560, 262)
        Me.Controls.Add(Me.btnVisualizar)
        Me.Name = "FormImprime"
        Me.Text = "VB.NET - Impressão e visualização"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub docDocumento_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles docDocumento.PrintPage
        Dim g As Graphics = e.Graphics
        Dim Mensagem As String = "Olá, meu nome é: "
        Mensagem += " - " & System.Environment.UserName
        Dim FontMensagem As New Font("Verdana", 22, FontStyle.Bold, GraphicsUnit.Point)
        g.DrawString(Mensagem, FontMensagem, Brushes.Blue, 100, 100)
    End Sub

    Private Sub btnVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizar.Click
        ppdVisualiza.ShowDialog()
    End Sub
End Class
