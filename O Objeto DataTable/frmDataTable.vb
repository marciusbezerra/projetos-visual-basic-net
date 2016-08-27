Public Class frmDataTable
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
    Friend WithEvents dgDataTable As System.Windows.Forms.DataGrid
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dgDataTable = New System.Windows.Forms.DataGrid
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.dgDataTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgDataTable
        '
        Me.dgDataTable.DataMember = ""
        Me.dgDataTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgDataTable.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgDataTable.Location = New System.Drawing.Point(0, 0)
        Me.dgDataTable.Name = "dgDataTable"
        Me.dgDataTable.Size = New System.Drawing.Size(576, 446)
        Me.dgDataTable.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button1.Location = New System.Drawing.Point(0, 422)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(576, 24)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Criar tabela (DataTable)"
        '
        'frmDataTable
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(576, 446)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgDataTable)
        Me.Name = "frmDataTable"
        Me.Text = "VB.NET - Criando dinamicamente um DataTable"
        CType(Me.dgDataTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dt As New DataTable("Temp")
        Dim dc As DataColumn
        Dim dr As DataRow

        dc = New DataColumn
        dc.DataType = System.Type.GetType("System.Int32")
        dc.ColumnName = "Código"
        dc.ReadOnly = True
        dc.Unique = True
        dt.Columns.Add(dc)

        dc = New DataColumn
        dc.DataType = System.Type.GetType("System.String")
        dc.ColumnName = "Nome"
        dc.ReadOnly = False
        dc.Unique = False
        dt.Columns.Add(dc)

        dc = New DataColumn
        dc.DataType = System.Type.GetType("System.String")
        dc.ColumnName = "Endereço"
        dc.ReadOnly = False
        dc.Unique = False
        dt.Columns.Add(dc)

        dr = dt.NewRow
        dr("Código") = 1
        dr("Nome") = "MARCIUS CARNEIRO BEZERRA"
        dr("Endereço") = "RUA CEL MONT ALERN 1500"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("Código") = 2
        dr("Nome") = "MARCELA NASCIMENTO SOUZA"
        dr("Endereço") = "RUA 24 DE MAIO, 340"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("Código") = 3
        dr("Nome") = "CARLOS ANTÔNIA BRAGA"
        dr("Endereço") = "AV. DOS EXPREDISSIONÁRIOS, 1200"
        dt.Rows.Add(dr)

        dt.Rows.Add(New Object() {4, "DANIEL ANTONIETE LIMA", "RUA DOS LOUCOS, 123"})

        Dim ds As DataSet = New DataSet("Lista de pessoas")
        ds.Tables.Add(dt)

        'dgDataTable.SetDataBinding(ds, "Temp")
        dgDataTable.DataSource = ds.Tables("Temp")

    End Sub
End Class
