<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cliente
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
        Dim CodigoClienteLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim EnderecoLabel As System.Windows.Forms.Label
        Dim CidadeLabel As System.Windows.Forms.Label
        Dim BairroLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim CEPLabel As System.Windows.Forms.Label
        Dim TelefoneLabel As System.Windows.Forms.Label
        Dim EMailLabel As System.Windows.Forms.Label
        Dim NacimentoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cliente))
        Me.ClienteDataSet = New Locadora_Filmes.ClienteDataSet
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteTableAdapter = New Locadora_Filmes.ClienteDataSetTableAdapters.ClienteTableAdapter
        Me.ClienteBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ClienteBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.CodigoClienteTextBox = New System.Windows.Forms.TextBox
        Me.NomeTextBox = New System.Windows.Forms.TextBox
        Me.EnderecoTextBox = New System.Windows.Forms.TextBox
        Me.CidadeComboBox = New System.Windows.Forms.ComboBox
        Me.BairroTextBox = New System.Windows.Forms.TextBox
        Me.EstadoTextBox = New System.Windows.Forms.TextBox
        Me.CEPMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.TelefoneMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.EMailTextBox = New System.Windows.Forms.TextBox
        Me.NacimentoDateTimePicker = New System.Windows.Forms.DateTimePicker
        CodigoClienteLabel = New System.Windows.Forms.Label
        NomeLabel = New System.Windows.Forms.Label
        EnderecoLabel = New System.Windows.Forms.Label
        CidadeLabel = New System.Windows.Forms.Label
        BairroLabel = New System.Windows.Forms.Label
        EstadoLabel = New System.Windows.Forms.Label
        CEPLabel = New System.Windows.Forms.Label
        TelefoneLabel = New System.Windows.Forms.Label
        EMailLabel = New System.Windows.Forms.Label
        NacimentoLabel = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.ClienteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClienteBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Text = "CADASTRO DE CLIENTES"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(CodigoClienteLabel)
        Me.GroupBox1.Controls.Add(Me.CodigoClienteTextBox)
        Me.GroupBox1.Controls.Add(NomeLabel)
        Me.GroupBox1.Controls.Add(Me.NomeTextBox)
        Me.GroupBox1.Controls.Add(EnderecoLabel)
        Me.GroupBox1.Controls.Add(Me.EnderecoTextBox)
        Me.GroupBox1.Controls.Add(CidadeLabel)
        Me.GroupBox1.Controls.Add(Me.CidadeComboBox)
        Me.GroupBox1.Controls.Add(BairroLabel)
        Me.GroupBox1.Controls.Add(Me.BairroTextBox)
        Me.GroupBox1.Controls.Add(EstadoLabel)
        Me.GroupBox1.Controls.Add(Me.EstadoTextBox)
        Me.GroupBox1.Controls.Add(CEPLabel)
        Me.GroupBox1.Controls.Add(Me.CEPMaskedTextBox)
        Me.GroupBox1.Controls.Add(TelefoneLabel)
        Me.GroupBox1.Controls.Add(Me.TelefoneMaskedTextBox)
        Me.GroupBox1.Controls.Add(EMailLabel)
        Me.GroupBox1.Controls.Add(Me.EMailTextBox)
        Me.GroupBox1.Controls.Add(NacimentoLabel)
        Me.GroupBox1.Controls.Add(Me.NacimentoDateTimePicker)
        Me.GroupBox1.Size = New System.Drawing.Size(653, 425)
        '
        'CodigoClienteLabel
        '
        CodigoClienteLabel.AutoSize = True
        CodigoClienteLabel.Location = New System.Drawing.Point(29, 21)
        CodigoClienteLabel.Name = "CodigoClienteLabel"
        CodigoClienteLabel.Size = New System.Drawing.Size(78, 14)
        CodigoClienteLabel.TabIndex = 0
        CodigoClienteLabel.Text = "Codigo Cliente:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(29, 47)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(37, 14)
        NomeLabel.TabIndex = 2
        NomeLabel.Text = "Nome:"
        '
        'EnderecoLabel
        '
        EnderecoLabel.AutoSize = True
        EnderecoLabel.Location = New System.Drawing.Point(29, 73)
        EnderecoLabel.Name = "EnderecoLabel"
        EnderecoLabel.Size = New System.Drawing.Size(56, 14)
        EnderecoLabel.TabIndex = 4
        EnderecoLabel.Text = "Endereco:"
        '
        'CidadeLabel
        '
        CidadeLabel.AutoSize = True
        CidadeLabel.Location = New System.Drawing.Point(29, 99)
        CidadeLabel.Name = "CidadeLabel"
        CidadeLabel.Size = New System.Drawing.Size(43, 14)
        CidadeLabel.TabIndex = 6
        CidadeLabel.Text = "Cidade:"
        '
        'BairroLabel
        '
        BairroLabel.AutoSize = True
        BairroLabel.Location = New System.Drawing.Point(29, 127)
        BairroLabel.Name = "BairroLabel"
        BairroLabel.Size = New System.Drawing.Size(39, 14)
        BairroLabel.TabIndex = 8
        BairroLabel.Text = "Bairro:"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Location = New System.Drawing.Point(29, 153)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(43, 14)
        EstadoLabel.TabIndex = 10
        EstadoLabel.Text = "Estado:"
        '
        'CEPLabel
        '
        CEPLabel.AutoSize = True
        CEPLabel.Location = New System.Drawing.Point(29, 179)
        CEPLabel.Name = "CEPLabel"
        CEPLabel.Size = New System.Drawing.Size(29, 14)
        CEPLabel.TabIndex = 12
        CEPLabel.Text = "CEP:"
        '
        'TelefoneLabel
        '
        TelefoneLabel.AutoSize = True
        TelefoneLabel.Location = New System.Drawing.Point(29, 205)
        TelefoneLabel.Name = "TelefoneLabel"
        TelefoneLabel.Size = New System.Drawing.Size(52, 14)
        TelefoneLabel.TabIndex = 14
        TelefoneLabel.Text = "Telefone:"
        '
        'EMailLabel
        '
        EMailLabel.AutoSize = True
        EMailLabel.Location = New System.Drawing.Point(29, 231)
        EMailLabel.Name = "EMailLabel"
        EMailLabel.Size = New System.Drawing.Size(34, 14)
        EMailLabel.TabIndex = 16
        EMailLabel.Text = "EMail:"
        '
        'NacimentoLabel
        '
        NacimentoLabel.AutoSize = True
        NacimentoLabel.Location = New System.Drawing.Point(29, 258)
        NacimentoLabel.Name = "NacimentoLabel"
        NacimentoLabel.Size = New System.Drawing.Size(60, 14)
        NacimentoLabel.TabIndex = 18
        NacimentoLabel.Text = "Nacimento:"
        '
        'ClienteDataSet
        '
        Me.ClienteDataSet.DataSetName = "ClienteDataSet"
        Me.ClienteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "Cliente"
        Me.ClienteBindingSource.DataSource = Me.ClienteDataSet
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'ClienteBindingNavigator
        '
        Me.ClienteBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ClienteBindingNavigator.BindingSource = Me.ClienteBindingSource
        Me.ClienteBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ClienteBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ClienteBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ClienteBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ClienteBindingNavigatorSaveItem})
        Me.ClienteBindingNavigator.Location = New System.Drawing.Point(0, 489)
        Me.ClienteBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ClienteBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ClienteBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ClienteBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ClienteBindingNavigator.Name = "ClienteBindingNavigator"
        Me.ClienteBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ClienteBindingNavigator.Size = New System.Drawing.Size(675, 25)
        Me.ClienteBindingNavigator.TabIndex = 2
        Me.ClienteBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
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
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ClienteBindingNavigatorSaveItem
        '
        Me.ClienteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ClienteBindingNavigatorSaveItem.Image = CType(resources.GetObject("ClienteBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ClienteBindingNavigatorSaveItem.Name = "ClienteBindingNavigatorSaveItem"
        Me.ClienteBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ClienteBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CodigoClienteTextBox
        '
        Me.CodigoClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "CodigoCliente", True))
        Me.CodigoClienteTextBox.Location = New System.Drawing.Point(113, 18)
        Me.CodigoClienteTextBox.Name = "CodigoClienteTextBox"
        Me.CodigoClienteTextBox.Size = New System.Drawing.Size(91, 20)
        Me.CodigoClienteTextBox.TabIndex = 1
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Nome", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(113, 44)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(317, 20)
        Me.NomeTextBox.TabIndex = 3
        '
        'EnderecoTextBox
        '
        Me.EnderecoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Endereco", True))
        Me.EnderecoTextBox.Location = New System.Drawing.Point(113, 70)
        Me.EnderecoTextBox.Name = "EnderecoTextBox"
        Me.EnderecoTextBox.Size = New System.Drawing.Size(317, 20)
        Me.EnderecoTextBox.TabIndex = 5
        '
        'CidadeComboBox
        '
        Me.CidadeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Cidade", True))
        Me.CidadeComboBox.FormattingEnabled = True
        Me.CidadeComboBox.Location = New System.Drawing.Point(113, 96)
        Me.CidadeComboBox.Name = "CidadeComboBox"
        Me.CidadeComboBox.Size = New System.Drawing.Size(144, 22)
        Me.CidadeComboBox.TabIndex = 7
        '
        'BairroTextBox
        '
        Me.BairroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Bairro", True))
        Me.BairroTextBox.Location = New System.Drawing.Point(113, 124)
        Me.BairroTextBox.Name = "BairroTextBox"
        Me.BairroTextBox.Size = New System.Drawing.Size(200, 20)
        Me.BairroTextBox.TabIndex = 9
        '
        'EstadoTextBox
        '
        Me.EstadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Estado", True))
        Me.EstadoTextBox.Location = New System.Drawing.Point(113, 150)
        Me.EstadoTextBox.Name = "EstadoTextBox"
        Me.EstadoTextBox.Size = New System.Drawing.Size(144, 20)
        Me.EstadoTextBox.TabIndex = 11
        '
        'CEPMaskedTextBox
        '
        Me.CEPMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "CEP", True))
        Me.CEPMaskedTextBox.Location = New System.Drawing.Point(113, 176)
        Me.CEPMaskedTextBox.Mask = "00000-000"
        Me.CEPMaskedTextBox.Name = "CEPMaskedTextBox"
        Me.CEPMaskedTextBox.Size = New System.Drawing.Size(144, 20)
        Me.CEPMaskedTextBox.TabIndex = 13
        '
        'TelefoneMaskedTextBox
        '
        Me.TelefoneMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Telefone", True))
        Me.TelefoneMaskedTextBox.Location = New System.Drawing.Point(113, 202)
        Me.TelefoneMaskedTextBox.Mask = "(999) 0000-0000"
        Me.TelefoneMaskedTextBox.Name = "TelefoneMaskedTextBox"
        Me.TelefoneMaskedTextBox.Size = New System.Drawing.Size(144, 20)
        Me.TelefoneMaskedTextBox.TabIndex = 15
        '
        'EMailTextBox
        '
        Me.EMailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "EMail", True))
        Me.EMailTextBox.Location = New System.Drawing.Point(113, 228)
        Me.EMailTextBox.Name = "EMailTextBox"
        Me.EMailTextBox.Size = New System.Drawing.Size(317, 20)
        Me.EMailTextBox.TabIndex = 17
        '
        'NacimentoDateTimePicker
        '
        Me.NacimentoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ClienteBindingSource, "Nacimento", True))
        Me.NacimentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.NacimentoDateTimePicker.Location = New System.Drawing.Point(113, 254)
        Me.NacimentoDateTimePicker.Name = "NacimentoDateTimePicker"
        Me.NacimentoDateTimePicker.Size = New System.Drawing.Size(144, 20)
        Me.NacimentoDateTimePicker.TabIndex = 19
        '
        'Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 514)
        Me.Controls.Add(Me.ClienteBindingNavigator)
        Me.Name = "Cliente"
        Me.Text = "Clientes"
        Me.Controls.SetChildIndex(Me.ClienteBindingNavigator, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ClienteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClienteBindingNavigator.ResumeLayout(False)
        Me.ClienteBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ClienteDataSet As Locadora_Filmes.ClienteDataSet
    Friend WithEvents ClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClienteTableAdapter As Locadora_Filmes.ClienteDataSetTableAdapters.ClienteTableAdapter
    Friend WithEvents ClienteBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ClienteBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CodigoClienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EnderecoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CidadeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BairroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EstadoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CEPMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TelefoneMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents EMailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NacimentoDateTimePicker As System.Windows.Forms.DateTimePicker
End Class
