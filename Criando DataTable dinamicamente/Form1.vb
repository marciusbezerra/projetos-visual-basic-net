Public Class Form1
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
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.Splitter1 = New System.Windows.Forms.Splitter
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGrid1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(0, 0)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(696, 438)
        Me.DataGrid1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox1.Location = New System.Drawing.Point(472, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(224, 438)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Estrutura do banco:"
        '
        'ListBox1
        '
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(3, 16)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(218, 404)
        Me.ListBox1.TabIndex = 0
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Splitter1.Location = New System.Drawing.Point(464, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(8, 438)
        Me.Splitter1.TabIndex = 2
        Me.Splitter1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(696, 438)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGrid1)
        Me.Name = "Form1"
        Me.Text = "Criando DataTable dinamicamente"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private ds As DataSet
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ds = New DataSet("Notas dos alunos")
        Dim Alunos As New DataTable("Alunos")
        ds.Tables.Add(Alunos)
        Alunos.Columns.Add("Codigo", GetType(Integer))
        Alunos.Columns("Codigo").AutoIncrement = True
        Alunos.Columns("Codigo").AutoIncrementSeed = 1
        Alunos.Columns("Codigo").AllowDBNull = False
        Alunos.Columns.Add("Nome", GetType(String))
        Alunos.Columns("Nome").MaxLength = 50
        Alunos.Columns("Nome").AllowDBNull = False
        Alunos.Columns.Add("Sobrenome", GetType(String))
        Alunos.Columns("Sobrenome").MaxLength = 50

        Dim Notas As New DataTable("Notas")
        ds.Tables.Add(Notas)
        With Notas
            Dim Col As DataColumn
            Col = .Columns.Add("Codigo", GetType(Integer))
            Col.AllowDBNull = False
            Col.AutoIncrement = True
            Col.AutoIncrementSeed = 1
            Col = .Columns.Add("CodAluno", GetType(Integer))
            Col.AllowDBNull = False
            .Columns.Add("Nota AP1", GetType(Double))
            .Columns.Add("Nota AP2", GetType(Double))
            .Columns.Add("Nota AP3", GetType(Double))
            .Columns.Add("Nota NAF", GetType(Double))
        End With

        Dim DadosAlunos(2) As Object
        DadosAlunos(1) = "MARCIUS"
        DadosAlunos(2) = "CARNEIRO BEZERRA"
        Alunos.Rows.Add(DadosAlunos)

        Dim DadosNotas As DataRow
        DadosNotas = Notas.NewRow
        DadosNotas("CodAluno") = 1
        DadosNotas("Nota AP1") = 8.5
        DadosNotas("Nota AP2") = 10
        DadosNotas("Nota AP3") = 9
        DadosNotas("Nota NAF") = 0
        Notas.Rows.Add(DadosNotas)

        ds.Relations.Add("Notas do aluno", Alunos.Columns("Codigo"), Notas.Columns("CodAluno"))

        DataGrid1.DataSource = ds
        ListBox1.Items.Clear()
        Dim dt As DataTable
        For Each dt In ds.Tables
            ListBox1.Items.Add(dt.TableName)
            Dim Row As DataRow
            For Each Row In dt.Rows
                ListBox1.Items.Add("  " & Row(1).ToString)
            Next
        Next

        ExibeEstrutura(ds)
    End Sub

    Private Sub ExibeEstrutura(ByVal ds As DataSet)
        Dim dt As DataTable
        Dim dc As DataColumn
        With ListBox1.Items
            .Add(ds.DataSetName & " (DataSet)")
            .Add("=============================")
            .Add("Número de tabelas: " & ds.Tables.Count.ToString)
            For Each dt In ds.Tables
                .Add("")
                .Add("Tabela: " & dt.TableName)
                .Add("")
                .Add("Sua estrutura:")
                For Each dc In dt.Columns
                    .Add("")
                    .Add("Campo: " & dc.ColumnName)
                    .Add("Tipo: " & dc.DataType.ToString)
                    .Add("Permite nulo: " & dc.AllowDBNull.ToString)
                    .Add("Valores únicos: " & dc.Unique.ToString)
                Next
            Next
        End With
    End Sub

End Class

