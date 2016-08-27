<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Filme
    Inherits Modelo

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
        Me.components = New System.ComponentModel.Container
        Dim CodigoFilmeLabel As System.Windows.Forms.Label
        Dim TituloLabel As System.Windows.Forms.Label
        Dim EstoqueLabel As System.Windows.Forms.Label
        Dim GeneroLabel As System.Windows.Forms.Label
        Dim MidiaLabel As System.Windows.Forms.Label
        Dim ClassificacaoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Filme))
        Me.FilmeDataSet = New Locadora_Filmes.FilmeDataSet
        Me.FilmeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FilmeTableAdapter = New Locadora_Filmes.FilmeDataSetTableAdapters.FilmeTableAdapter
        Me.FilmeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.CodigoFilmeTextBox = New System.Windows.Forms.TextBox
        Me.TituloTextBox = New System.Windows.Forms.TextBox
        Me.EstoqueNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.GeneroComboBox = New System.Windows.Forms.ComboBox
        Me.MidiaComboBox = New System.Windows.Forms.ComboBox
        Me.ClassificacaoComboBox = New System.Windows.Forms.ComboBox
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.FilmeBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        CodigoFilmeLabel = New System.Windows.Forms.Label
        TituloLabel = New System.Windows.Forms.Label
        EstoqueLabel = New System.Windows.Forms.Label
        GeneroLabel = New System.Windows.Forms.Label
        MidiaLabel = New System.Windows.Forms.Label
        ClassificacaoLabel = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.FilmeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FilmeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FilmeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FilmeBindingNavigator.SuspendLayout()
        CType(Me.EstoqueNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Text = "CADASTRO DE FILMES"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(CodigoFilmeLabel)
        Me.GroupBox1.Controls.Add(Me.CodigoFilmeTextBox)
        Me.GroupBox1.Controls.Add(TituloLabel)
        Me.GroupBox1.Controls.Add(Me.TituloTextBox)
        Me.GroupBox1.Controls.Add(EstoqueLabel)
        Me.GroupBox1.Controls.Add(Me.EstoqueNumericUpDown)
        Me.GroupBox1.Controls.Add(GeneroLabel)
        Me.GroupBox1.Controls.Add(Me.GeneroComboBox)
        Me.GroupBox1.Controls.Add(MidiaLabel)
        Me.GroupBox1.Controls.Add(Me.MidiaComboBox)
        Me.GroupBox1.Controls.Add(ClassificacaoLabel)
        Me.GroupBox1.Controls.Add(Me.ClassificacaoComboBox)
        Me.GroupBox1.Size = New System.Drawing.Size(653, 434)
        '
        'FilmeDataSet
        '
        Me.FilmeDataSet.DataSetName = "FilmeDataSet"
        Me.FilmeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FilmeBindingSource
        '
        Me.FilmeBindingSource.DataMember = "Filme"
        Me.FilmeBindingSource.DataSource = Me.FilmeDataSet
        '
        'FilmeTableAdapter
        '
        Me.FilmeTableAdapter.ClearBeforeFill = True
        '
        'FilmeBindingNavigator
        '
        Me.FilmeBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.FilmeBindingNavigator.BindingSource = Me.FilmeBindingSource
        Me.FilmeBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.FilmeBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.FilmeBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FilmeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.FilmeBindingNavigatorSaveItem})
        Me.FilmeBindingNavigator.Location = New System.Drawing.Point(0, 489)
        Me.FilmeBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.FilmeBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.FilmeBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FilmeBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FilmeBindingNavigator.Name = "FilmeBindingNavigator"
        Me.FilmeBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FilmeBindingNavigator.Size = New System.Drawing.Size(675, 25)
        Me.FilmeBindingNavigator.TabIndex = 2
        Me.FilmeBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'CodigoFilmeLabel
        '
        CodigoFilmeLabel.AutoSize = True
        CodigoFilmeLabel.Location = New System.Drawing.Point(25, 21)
        CodigoFilmeLabel.Name = "CodigoFilmeLabel"
        CodigoFilmeLabel.Size = New System.Drawing.Size(70, 14)
        CodigoFilmeLabel.TabIndex = 0
        CodigoFilmeLabel.Text = "Codigo Filme:"
        '
        'CodigoFilmeTextBox
        '
        Me.CodigoFilmeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FilmeBindingSource, "CodigoFilme", True))
        Me.CodigoFilmeTextBox.Location = New System.Drawing.Point(106, 18)
        Me.CodigoFilmeTextBox.Name = "CodigoFilmeTextBox"
        Me.CodigoFilmeTextBox.Size = New System.Drawing.Size(74, 20)
        Me.CodigoFilmeTextBox.TabIndex = 1
        '
        'TituloLabel
        '
        TituloLabel.AutoSize = True
        TituloLabel.Location = New System.Drawing.Point(25, 47)
        TituloLabel.Name = "TituloLabel"
        TituloLabel.Size = New System.Drawing.Size(35, 14)
        TituloLabel.TabIndex = 2
        TituloLabel.Text = "Titulo:"
        '
        'TituloTextBox
        '
        Me.TituloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FilmeBindingSource, "Titulo", True))
        Me.TituloTextBox.Location = New System.Drawing.Point(106, 44)
        Me.TituloTextBox.Name = "TituloTextBox"
        Me.TituloTextBox.Size = New System.Drawing.Size(371, 20)
        Me.TituloTextBox.TabIndex = 3
        '
        'EstoqueLabel
        '
        EstoqueLabel.AutoSize = True
        EstoqueLabel.Location = New System.Drawing.Point(25, 70)
        EstoqueLabel.Name = "EstoqueLabel"
        EstoqueLabel.Size = New System.Drawing.Size(49, 14)
        EstoqueLabel.TabIndex = 4
        EstoqueLabel.Text = "Estoque:"
        '
        'EstoqueNumericUpDown
        '
        Me.EstoqueNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FilmeBindingSource, "Estoque", True))
        Me.EstoqueNumericUpDown.Location = New System.Drawing.Point(106, 70)
        Me.EstoqueNumericUpDown.Name = "EstoqueNumericUpDown"
        Me.EstoqueNumericUpDown.Size = New System.Drawing.Size(74, 20)
        Me.EstoqueNumericUpDown.TabIndex = 5
        '
        'GeneroLabel
        '
        GeneroLabel.AutoSize = True
        GeneroLabel.Location = New System.Drawing.Point(25, 99)
        GeneroLabel.Name = "GeneroLabel"
        GeneroLabel.Size = New System.Drawing.Size(46, 14)
        GeneroLabel.TabIndex = 6
        GeneroLabel.Text = "Genero:"
        '
        'GeneroComboBox
        '
        Me.GeneroComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FilmeBindingSource, "Genero", True))
        Me.GeneroComboBox.FormattingEnabled = True
        Me.GeneroComboBox.Location = New System.Drawing.Point(106, 96)
        Me.GeneroComboBox.Name = "GeneroComboBox"
        Me.GeneroComboBox.Size = New System.Drawing.Size(157, 22)
        Me.GeneroComboBox.TabIndex = 7
        '
        'MidiaLabel
        '
        MidiaLabel.AutoSize = True
        MidiaLabel.Location = New System.Drawing.Point(25, 127)
        MidiaLabel.Name = "MidiaLabel"
        MidiaLabel.Size = New System.Drawing.Size(34, 14)
        MidiaLabel.TabIndex = 8
        MidiaLabel.Text = "Midia:"
        '
        'MidiaComboBox
        '
        Me.MidiaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FilmeBindingSource, "Midia", True))
        Me.MidiaComboBox.FormattingEnabled = True
        Me.MidiaComboBox.Location = New System.Drawing.Point(106, 124)
        Me.MidiaComboBox.Name = "MidiaComboBox"
        Me.MidiaComboBox.Size = New System.Drawing.Size(157, 22)
        Me.MidiaComboBox.TabIndex = 9
        '
        'ClassificacaoLabel
        '
        ClassificacaoLabel.AutoSize = True
        ClassificacaoLabel.Location = New System.Drawing.Point(25, 155)
        ClassificacaoLabel.Name = "ClassificacaoLabel"
        ClassificacaoLabel.Size = New System.Drawing.Size(75, 14)
        ClassificacaoLabel.TabIndex = 10
        ClassificacaoLabel.Text = "Classificacao:"
        '
        'ClassificacaoComboBox
        '
        Me.ClassificacaoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FilmeBindingSource, "Classificacao", True))
        Me.ClassificacaoComboBox.FormattingEnabled = True
        Me.ClassificacaoComboBox.Location = New System.Drawing.Point(106, 152)
        Me.ClassificacaoComboBox.Name = "ClassificacaoComboBox"
        Me.ClassificacaoComboBox.Size = New System.Drawing.Size(157, 22)
        Me.ClassificacaoComboBox.TabIndex = 11
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'FilmeBindingNavigatorSaveItem
        '
        Me.FilmeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FilmeBindingNavigatorSaveItem.Image = CType(resources.GetObject("FilmeBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FilmeBindingNavigatorSaveItem.Name = "FilmeBindingNavigatorSaveItem"
        Me.FilmeBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.FilmeBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Filme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 514)
        Me.Controls.Add(Me.FilmeBindingNavigator)
        Me.Name = "Filme"
        Me.Text = "Filmes"
        Me.Controls.SetChildIndex(Me.FilmeBindingNavigator, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.FilmeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FilmeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FilmeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FilmeBindingNavigator.ResumeLayout(False)
        Me.FilmeBindingNavigator.PerformLayout()
        CType(Me.EstoqueNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FilmeDataSet As Locadora_Filmes.FilmeDataSet
    Friend WithEvents FilmeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FilmeTableAdapter As Locadora_Filmes.FilmeDataSetTableAdapters.FilmeTableAdapter
    Friend WithEvents FilmeBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FilmeBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CodigoFilmeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TituloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EstoqueNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents GeneroComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MidiaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ClassificacaoComboBox As System.Windows.Forms.ComboBox
End Class
