<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.CadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MovimentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DevoluçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SobreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FilmesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FornecedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FuncionáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AcessoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IncluirCategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TodasAsCategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroToolStripMenuItem, Me.MovimentoToolStripMenuItem, Me.DevoluçãoToolStripMenuItem, Me.SobreToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(686, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CadastroToolStripMenuItem
        '
        Me.CadastroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.FilmesToolStripMenuItem, Me.CategoriasToolStripMenuItem, Me.FornecedoresToolStripMenuItem, Me.FuncionáriosToolStripMenuItem, Me.AcessoToolStripMenuItem})
        Me.CadastroToolStripMenuItem.Name = "CadastroToolStripMenuItem"
        Me.CadastroToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.CadastroToolStripMenuItem.Text = "Cadastro"
        '
        'MovimentoToolStripMenuItem
        '
        Me.MovimentoToolStripMenuItem.Name = "MovimentoToolStripMenuItem"
        Me.MovimentoToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.MovimentoToolStripMenuItem.Text = "Movimento"
        '
        'DevoluçãoToolStripMenuItem
        '
        Me.DevoluçãoToolStripMenuItem.Name = "DevoluçãoToolStripMenuItem"
        Me.DevoluçãoToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.DevoluçãoToolStripMenuItem.Text = "Devolução"
        '
        'SobreToolStripMenuItem
        '
        Me.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem"
        Me.SobreToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.SobreToolStripMenuItem.Text = "Sobre"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 413)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(686, 57)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(313, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(295, 41)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MCB LOCADORA"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Locadora_Filmes.My.Resources.Resources.WizModernSmallImage
        Me.PictureBox1.Location = New System.Drawing.Point(614, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 49)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Image = Global.Locadora_Filmes.My.Resources.Resources.CUP
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'FilmesToolStripMenuItem
        '
        Me.FilmesToolStripMenuItem.Image = Global.Locadora_Filmes.My.Resources.Resources.CAMCORD
        Me.FilmesToolStripMenuItem.Name = "FilmesToolStripMenuItem"
        Me.FilmesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FilmesToolStripMenuItem.Text = "Filmes"
        '
        'CategoriasToolStripMenuItem
        '
        Me.CategoriasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IncluirCategoriasToolStripMenuItem, Me.TodasAsCategoriasToolStripMenuItem})
        Me.CategoriasToolStripMenuItem.Image = Global.Locadora_Filmes.My.Resources.Resources.CARD
        Me.CategoriasToolStripMenuItem.Name = "CategoriasToolStripMenuItem"
        Me.CategoriasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CategoriasToolStripMenuItem.Text = "Categorias"
        '
        'FornecedoresToolStripMenuItem
        '
        Me.FornecedoresToolStripMenuItem.Image = Global.Locadora_Filmes.My.Resources.Resources.CLUB
        Me.FornecedoresToolStripMenuItem.Name = "FornecedoresToolStripMenuItem"
        Me.FornecedoresToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FornecedoresToolStripMenuItem.Text = "Fornecedores"
        '
        'FuncionáriosToolStripMenuItem
        '
        Me.FuncionáriosToolStripMenuItem.Image = Global.Locadora_Filmes.My.Resources.Resources.ENVELOPE
        Me.FuncionáriosToolStripMenuItem.Name = "FuncionáriosToolStripMenuItem"
        Me.FuncionáriosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FuncionáriosToolStripMenuItem.Text = "Funcionários"
        '
        'AcessoToolStripMenuItem
        '
        Me.AcessoToolStripMenuItem.Image = Global.Locadora_Filmes.My.Resources.Resources.DIAMOND
        Me.AcessoToolStripMenuItem.Name = "AcessoToolStripMenuItem"
        Me.AcessoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AcessoToolStripMenuItem.Text = "Acesso"
        '
        'IncluirCategoriasToolStripMenuItem
        '
        Me.IncluirCategoriasToolStripMenuItem.Name = "IncluirCategoriasToolStripMenuItem"
        Me.IncluirCategoriasToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.IncluirCategoriasToolStripMenuItem.Text = "Incluir categorias"
        '
        'TodasAsCategoriasToolStripMenuItem
        '
        Me.TodasAsCategoriasToolStripMenuItem.Name = "TodasAsCategoriasToolStripMenuItem"
        Me.TodasAsCategoriasToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.TodasAsCategoriasToolStripMenuItem.Text = "Todas as categorias"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 473)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.HelpButton = True
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Principal"
        Me.Text = "MCB Locadora"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CadastroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FilmesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CategoriasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FornecedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FuncionáriosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcessoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MovimentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DevoluçãoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SobreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents IncluirCategoriasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TodasAsCategoriasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
