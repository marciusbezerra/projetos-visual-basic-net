Public Class frmMain
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
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFiguras As System.Windows.Forms.MenuItem
    Friend WithEvents mnuLimpar As System.Windows.Forms.MenuItem
    Friend WithEvents mnuExecutar As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSair As System.Windows.Forms.MenuItem
    Friend WithEvents mnuQuadrado As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRetangulo As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCirculo As System.Windows.Forms.MenuItem
    Friend WithEvents mnuElipse As System.Windows.Forms.MenuItem
    Friend WithEvents tmrDesenho As System.Windows.Forms.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.mnuFiguras = New System.Windows.Forms.MenuItem
        Me.mnuLimpar = New System.Windows.Forms.MenuItem
        Me.mnuExecutar = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.mnuSair = New System.Windows.Forms.MenuItem
        Me.mnuQuadrado = New System.Windows.Forms.MenuItem
        Me.mnuRetangulo = New System.Windows.Forms.MenuItem
        Me.mnuCirculo = New System.Windows.Forms.MenuItem
        Me.mnuElipse = New System.Windows.Forms.MenuItem
        Me.tmrDesenho = New System.Windows.Forms.Timer(Me.components)
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFiguras, Me.mnuLimpar, Me.mnuExecutar, Me.MenuItem5, Me.mnuSair})
        Me.MenuItem1.Text = "&Arquivo"
        '
        'mnuFiguras
        '
        Me.mnuFiguras.Index = 0
        Me.mnuFiguras.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuQuadrado, Me.mnuRetangulo, Me.mnuCirculo, Me.mnuElipse})
        Me.mnuFiguras.Text = "&Figuras"
        '
        'mnuLimpar
        '
        Me.mnuLimpar.Index = 1
        Me.mnuLimpar.Text = "&Limpar"
        '
        'mnuExecutar
        '
        Me.mnuExecutar.Index = 2
        Me.mnuExecutar.Text = "&Executar"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 3
        Me.MenuItem5.Text = "-"
        '
        'mnuSair
        '
        Me.mnuSair.Index = 4
        Me.mnuSair.Text = "&Sair"
        '
        'mnuQuadrado
        '
        Me.mnuQuadrado.Checked = True
        Me.mnuQuadrado.Index = 0
        Me.mnuQuadrado.Text = "&Quadrado"
        '
        'mnuRetangulo
        '
        Me.mnuRetangulo.Index = 1
        Me.mnuRetangulo.Text = "&Retangulo"
        '
        'mnuCirculo
        '
        Me.mnuCirculo.Index = 2
        Me.mnuCirculo.Text = "&Circulo"
        '
        'mnuElipse
        '
        Me.mnuElipse.Index = 3
        Me.mnuElipse.Text = "&Elipse"
        '
        'tmrDesenho
        '
        Me.tmrDesenho.Interval = 300
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(424, 398)
        Me.Menu = Me.MainMenu1
        Me.Name = "frmMain"
        Me.Text = "Drawing - desenhando figuras"

    End Sub

#End Region
    Const QUADRADO As Integer = 1
    Const CIRCULO As Integer = 2
    Const RETANGULO As Integer = 3
    Const ELIPSE As Integer = 4
    Private DesenhaFigura As Integer = QUADRADO
    Private Sub tmrDesenho_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDesenho.Tick
        Dim Vermelho, Verde, Azul As Integer
        Dim x, y, Tamanho As Integer
        Dim LarguraRect As Integer
        Dim g As Graphics
        g = Me.CreateGraphics
        Randomize()
        Vermelho = Int(Rnd() * 256)
        Verde = Int(Rnd() * 256)
        Azul = Int(Rnd() * 256)
        Dim PenaDesenho As New Pen(System.Drawing.Color.FromArgb(Vermelho, Verde, Azul))
        Tamanho = Int(Rnd() * 45) + 5
        x = Int(Rnd() * Me.Width) + 1
        y = Int(Rnd() * Me.Height) + 1
        Select Case DesenhaFigura
            Case QUADRADO
                g.DrawRectangle(PenaDesenho, x, y, Tamanho, Tamanho)
            Case RETANGULO
                LarguraRect = Tamanho / 2
                g.DrawRectangle(PenaDesenho, x, y, LarguraRect, Tamanho)
            Case CIRCULO
                g.DrawEllipse(PenaDesenho, x, y, Tamanho, Tamanho)
            Case ELIPSE
                LarguraRect = Tamanho / 3
                g.DrawEllipse(PenaDesenho, x, y, LarguraRect, Tamanho)
        End Select
    End Sub

    Private Sub mnuQuadrado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQuadrado.Click
        ChecaMenu(CType(sender, MenuItem))
        DesenhaFigura = QUADRADO
    End Sub

    Private Sub ChecaMenu(ByVal Menu As MenuItem)
        Dim mnu As MenuItem
        Dim Mnus(3) As MenuItem
        Mnus(0) = mnuCirculo
        Mnus(1) = mnuElipse
        Mnus(2) = mnuQuadrado
        Mnus(3) = mnuRetangulo
        For Each mnu In Mnus
            If mnu Is Menu Then
                mnu.Checked = True
            Else
                mnu.Checked = False
            End If
        Next
    End Sub

    Private Sub mnuRetangulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRetangulo.Click
        ChecaMenu(CType(sender, MenuItem))
        DesenhaFigura = RETANGULO
    End Sub

    Private Sub mnuCirculo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCirculo.Click
        ChecaMenu(CType(sender, MenuItem))
        DesenhaFigura = CIRCULO
    End Sub

    Private Sub mnuElipse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuElipse.Click
        ChecaMenu(CType(sender, MenuItem))
        DesenhaFigura = ELIPSE
    End Sub

    Private Sub mnuExecutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExecutar.Click
        If mnuExecutar.Text.ToUpper = "&EXECUTAR" Then
            mnuExecutar.Text = "&Parar"
            tmrDesenho.Enabled = True
        Else
            mnuExecutar.Text = "&Executar"
            tmrDesenho.Enabled = False
        End If
    End Sub

    Private Sub mnuLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLimpar.Click
        Me.Refresh()
    End Sub

    Private Sub mnuSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSair.Click
        Me.Close()
    End Sub
End Class
