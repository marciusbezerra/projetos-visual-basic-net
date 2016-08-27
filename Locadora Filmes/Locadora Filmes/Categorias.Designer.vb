<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Categorias
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
        Dim CodigoLabel As System.Windows.Forms.Label
        Dim DescricaoLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Me.CategoriaDataSet = New Locadora_Filmes.CategoriaDataSet
        Me.CategoiaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoiaTableAdapter = New Locadora_Filmes.CategoriaDataSetTableAdapters.CategoiaTableAdapter
        Me.CodigoTextBox = New System.Windows.Forms.TextBox
        Me.DescricaoTextBox = New System.Windows.Forms.TextBox
        Me.EstadoCheckBox = New System.Windows.Forms.CheckBox
        Me.btCriar = New System.Windows.Forms.Button
        Me.btCancelar = New System.Windows.Forms.Button
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CodigoLabel = New System.Windows.Forms.Label
        DescricaoLabel = New System.Windows.Forms.Label
        EstadoLabel = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.CategoriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoiaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Text = "CADASTRO DE CATEGORIAS"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btCancelar)
        Me.GroupBox1.Controls.Add(Me.btCriar)
        Me.GroupBox1.Controls.Add(CodigoLabel)
        Me.GroupBox1.Controls.Add(Me.CodigoTextBox)
        Me.GroupBox1.Controls.Add(DescricaoLabel)
        Me.GroupBox1.Controls.Add(Me.DescricaoTextBox)
        Me.GroupBox1.Controls.Add(EstadoLabel)
        Me.GroupBox1.Controls.Add(Me.EstadoCheckBox)
        Me.GroupBox1.Size = New System.Drawing.Size(375, 148)
        '
        'CodigoLabel
        '
        CodigoLabel.AutoSize = True
        CodigoLabel.Location = New System.Drawing.Point(24, 29)
        CodigoLabel.Name = "CodigoLabel"
        CodigoLabel.Size = New System.Drawing.Size(43, 14)
        CodigoLabel.TabIndex = 0
        CodigoLabel.Text = "Codigo:"
        '
        'DescricaoLabel
        '
        DescricaoLabel.AutoSize = True
        DescricaoLabel.Location = New System.Drawing.Point(24, 55)
        DescricaoLabel.Name = "DescricaoLabel"
        DescricaoLabel.Size = New System.Drawing.Size(59, 14)
        DescricaoLabel.TabIndex = 2
        DescricaoLabel.Text = "Descricao:"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Location = New System.Drawing.Point(24, 83)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(43, 14)
        EstadoLabel.TabIndex = 4
        EstadoLabel.Text = "Estado:"
        '
        'CategoriaDataSet
        '
        Me.CategoriaDataSet.DataSetName = "CategoriaDataSet"
        Me.CategoriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CategoiaBindingSource
        '
        Me.CategoiaBindingSource.DataMember = "Categoia"
        Me.CategoiaBindingSource.DataSource = Me.CategoriaDataSet
        '
        'CategoiaTableAdapter
        '
        Me.CategoiaTableAdapter.ClearBeforeFill = True
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoiaBindingSource, "Codigo", True))
        Me.CodigoTextBox.Enabled = False
        Me.CodigoTextBox.Location = New System.Drawing.Point(89, 26)
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.Size = New System.Drawing.Size(79, 20)
        Me.CodigoTextBox.TabIndex = 1
        Me.CodigoTextBox.TabStop = False
        '
        'DescricaoTextBox
        '
        Me.DescricaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoiaBindingSource, "Descricao", True))
        Me.DescricaoTextBox.Location = New System.Drawing.Point(89, 52)
        Me.DescricaoTextBox.Name = "DescricaoTextBox"
        Me.DescricaoTextBox.Size = New System.Drawing.Size(266, 20)
        Me.DescricaoTextBox.TabIndex = 3
        '
        'EstadoCheckBox
        '
        Me.EstadoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CategoiaBindingSource, "Estado", True))
        Me.EstadoCheckBox.Location = New System.Drawing.Point(89, 78)
        Me.EstadoCheckBox.Name = "EstadoCheckBox"
        Me.EstadoCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.EstadoCheckBox.TabIndex = 5
        '
        'btCriar
        '
        Me.btCriar.Location = New System.Drawing.Point(199, 112)
        Me.btCriar.Name = "btCriar"
        Me.btCriar.Size = New System.Drawing.Size(75, 23)
        Me.btCriar.TabIndex = 6
        Me.btCriar.Text = "Criar"
        Me.btCriar.UseVisualStyleBackColor = True
        '
        'btCancelar
        '
        Me.btCancelar.Location = New System.Drawing.Point(280, 112)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btCancelar.TabIndex = 7
        Me.btCancelar.Text = "Cancelar"
        Me.btCancelar.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Categorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 215)
        Me.Name = "Categorias"
        Me.Text = "Categorias"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CategoriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoiaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CategoriaDataSet As Locadora_Filmes.CategoriaDataSet
    Friend WithEvents CategoiaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoiaTableAdapter As Locadora_Filmes.CategoriaDataSetTableAdapters.CategoiaTableAdapter
    Friend WithEvents CodigoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescricaoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EstadoCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents btCancelar As System.Windows.Forms.Button
    Friend WithEvents btCriar As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
