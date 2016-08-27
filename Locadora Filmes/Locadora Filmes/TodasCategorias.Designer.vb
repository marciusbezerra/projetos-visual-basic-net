<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TodasCategorias
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
        Me.CategoriaDataSet = New Locadora_Filmes.CategoriaDataSet
        Me.CategoiaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoiaTableAdapter = New Locadora_Filmes.CategoriaDataSetTableAdapters.CategoiaTableAdapter
        Me.CategoiaDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.btFechar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.CategoriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoiaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoiaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Text = "LISTA DE CATEGORIAS"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CategoiaDataGridView)
        Me.GroupBox1.Size = New System.Drawing.Size(653, 324)
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
        'CategoiaDataGridView
        '
        Me.CategoiaDataGridView.AutoGenerateColumns = False
        Me.CategoiaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewCheckBoxColumn1})
        Me.CategoiaDataGridView.DataSource = Me.CategoiaBindingSource
        Me.CategoiaDataGridView.Location = New System.Drawing.Point(16, 27)
        Me.CategoiaDataGridView.Name = "CategoiaDataGridView"
        Me.CategoiaDataGridView.Size = New System.Drawing.Size(615, 285)
        Me.CategoiaDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Codigo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Descricao"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descricao"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 350
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Estado"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Estado"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'btFechar
        '
        Me.btFechar.Location = New System.Drawing.Point(588, 382)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(75, 23)
        Me.btFechar.TabIndex = 2
        Me.btFechar.Text = "Fechar"
        Me.btFechar.UseVisualStyleBackColor = True
        '
        'TodasCategorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 417)
        Me.Controls.Add(Me.btFechar)
        Me.Name = "TodasCategorias"
        Me.Text = "Categorias"
        Me.Controls.SetChildIndex(Me.btFechar, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.CategoriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoiaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoiaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CategoriaDataSet As Locadora_Filmes.CategoriaDataSet
    Friend WithEvents CategoiaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoiaTableAdapter As Locadora_Filmes.CategoriaDataSetTableAdapters.CategoiaTableAdapter
    Friend WithEvents CategoiaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents btFechar As System.Windows.Forms.Button
End Class
