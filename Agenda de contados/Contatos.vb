Public Class Contatos
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
    Friend WithEvents daClientes As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents SelecionarClientes As System.Data.OleDb.OleDbCommand
    Friend WithEvents InserirClientes As System.Data.OleDb.OleDbCommand
    Friend WithEvents AtualizarClientes As System.Data.OleDb.OleDbCommand
    Friend WithEvents ExcluirClientes As System.Data.OleDb.OleDbCommand
    Friend WithEvents cnAgenda As System.Data.OleDb.OleDbConnection
    Friend WithEvents DsClientes1 As Agenda_de_contados.dsClientes
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents txtEndereco As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefone As System.Windows.Forms.TextBox
    Friend WithEvents txtRegistro As System.Windows.Forms.TextBox
    Friend WithEvents btnIncluir As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents btnPrimeiro As System.Windows.Forms.Button
    Friend WithEvents btnAnterior As System.Windows.Forms.Button
    Friend WithEvents btnProximo As System.Windows.Forms.Button
    Friend WithEvents bltUltimo As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.daClientes = New System.Data.OleDb.OleDbDataAdapter
        Me.SelecionarClientes = New System.Data.OleDb.OleDbCommand
        Me.InserirClientes = New System.Data.OleDb.OleDbCommand
        Me.AtualizarClientes = New System.Data.OleDb.OleDbCommand
        Me.ExcluirClientes = New System.Data.OleDb.OleDbCommand
        Me.cnAgenda = New System.Data.OleDb.OleDbConnection
        Me.DsClientes1 = New Agenda_de_contados.dsClientes
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNome = New System.Windows.Forms.TextBox
        Me.txtEndereco = New System.Windows.Forms.TextBox
        Me.txtTelefone = New System.Windows.Forms.TextBox
        Me.txtRegistro = New System.Windows.Forms.TextBox
        Me.btnIncluir = New System.Windows.Forms.Button
        Me.btnSalvar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnExcluir = New System.Windows.Forms.Button
        Me.btnFechar = New System.Windows.Forms.Button
        Me.btnPrimeiro = New System.Windows.Forms.Button
        Me.btnAnterior = New System.Windows.Forms.Button
        Me.btnProximo = New System.Windows.Forms.Button
        Me.bltUltimo = New System.Windows.Forms.Button
        CType(Me.DsClientes1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'daClientes
        '
        Me.daClientes.DeleteCommand = Me.ExcluirClientes
        Me.daClientes.InsertCommand = Me.InserirClientes
        Me.daClientes.SelectCommand = Me.SelecionarClientes
        Me.daClientes.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Clientes", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Endereco", "Endereco"), New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("Nome", "Nome"), New System.Data.Common.DataColumnMapping("Telefone", "Telefone")})})
        Me.daClientes.UpdateCommand = Me.AtualizarClientes
        '
        'SelecionarClientes
        '
        Me.SelecionarClientes.CommandText = "SELECT Endereco, ID, Nome, Telefone FROM Clientes"
        Me.SelecionarClientes.Connection = Me.cnAgenda
        '
        'InserirClientes
        '
        Me.InserirClientes.CommandText = "INSERT INTO Clientes(Endereco, ID, Nome, Telefone) VALUES (?, ?, ?, ?)"
        Me.InserirClientes.Connection = Me.cnAgenda
        Me.InserirClientes.Parameters.Add(New System.Data.OleDb.OleDbParameter("Endereco", System.Data.OleDb.OleDbType.VarWChar, 50, "Endereco"))
        Me.InserirClientes.Parameters.Add(New System.Data.OleDb.OleDbParameter("ID", System.Data.OleDb.OleDbType.Integer, 0, "ID"))
        Me.InserirClientes.Parameters.Add(New System.Data.OleDb.OleDbParameter("Nome", System.Data.OleDb.OleDbType.VarWChar, 50, "Nome"))
        Me.InserirClientes.Parameters.Add(New System.Data.OleDb.OleDbParameter("Telefone", System.Data.OleDb.OleDbType.VarWChar, 20, "Telefone"))
        '
        'AtualizarClientes
        '
        Me.AtualizarClientes.CommandText = "UPDATE Clientes SET Endereco = ?, ID = ?, Nome = ?, Telefone = ? WHERE (ID = ?) A" & _
        "ND (Endereco = ? OR ? IS NULL AND Endereco IS NULL) AND (Nome = ? OR ? IS NULL A" & _
        "ND Nome IS NULL) AND (Telefone = ? OR ? IS NULL AND Telefone IS NULL)"
        Me.AtualizarClientes.Connection = Me.cnAgenda
        Me.AtualizarClientes.Parameters.Add(New System.Data.OleDb.OleDbParameter("Endereco", System.Data.OleDb.OleDbType.VarWChar, 50, "Endereco"))
        Me.AtualizarClientes.Parameters.Add(New System.Data.OleDb.OleDbParameter("ID", System.Data.OleDb.OleDbType.Integer, 0, "ID"))
        Me.AtualizarClientes.Parameters.Add(New System.Data.OleDb.OleDbParameter("Nome", System.Data.OleDb.OleDbType.VarWChar, 50, "Nome"))
        Me.AtualizarClientes.Parameters.Add(New System.Data.OleDb.OleDbParameter("Telefone", System.Data.OleDb.OleDbType.VarWChar, 20, "Telefone"))
        Me.AtualizarClientes.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
        Me.AtualizarClientes.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Endereco", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Endereco", System.Data.DataRowVersion.Original, Nothing))
        Me.AtualizarClientes.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Endereco1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Endereco", System.Data.DataRowVersion.Original, Nothing))
        Me.AtualizarClientes.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Nome", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nome", System.Data.DataRowVersion.Original, Nothing))
        Me.AtualizarClientes.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Nome1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nome", System.Data.DataRowVersion.Original, Nothing))
        Me.AtualizarClientes.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Telefone", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefone", System.Data.DataRowVersion.Original, Nothing))
        Me.AtualizarClientes.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Telefone1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefone", System.Data.DataRowVersion.Original, Nothing))
        '
        'ExcluirClientes
        '
        Me.ExcluirClientes.CommandText = "DELETE FROM Clientes WHERE (ID = ?) AND (Endereco = ? OR ? IS NULL AND Endereco I" & _
        "S NULL) AND (Nome = ? OR ? IS NULL AND Nome IS NULL) AND (Telefone = ? OR ? IS N" & _
        "ULL AND Telefone IS NULL)"
        Me.ExcluirClientes.Connection = Me.cnAgenda
        Me.ExcluirClientes.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
        Me.ExcluirClientes.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Endereco", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Endereco", System.Data.DataRowVersion.Original, Nothing))
        Me.ExcluirClientes.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Endereco1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Endereco", System.Data.DataRowVersion.Original, Nothing))
        Me.ExcluirClientes.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Nome", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nome", System.Data.DataRowVersion.Original, Nothing))
        Me.ExcluirClientes.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Nome1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nome", System.Data.DataRowVersion.Original, Nothing))
        Me.ExcluirClientes.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Telefone", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefone", System.Data.DataRowVersion.Original, Nothing))
        Me.ExcluirClientes.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Telefone1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefone", System.Data.DataRowVersion.Original, Nothing))
        '
        'cnAgenda
        '
        Me.cnAgenda.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" & _
        "ocking Mode=1;Data Source=""" & Application.StartupPath & "\..\DB\Agenda.mdb"";Jet OLEDB:Engine Type=5;Provider=""Microsoft.Jet.OLE" & _
        "DB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;persist security info=Fal" & _
        "se;Extended Properties=;Mode=Share Deny None;Jet OLEDB:Encrypt Database=False;Je" & _
        "t OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=Fals" & _
        "e;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Global " & _
        "Bulk Transactions=1"
        '
        'DsClientes1
        '
        Me.DsClientes1.DataSetName = "dsClientes"
        Me.DsClientes1.Locale = New System.Globalization.CultureInfo("pt-BR")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Endereço:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Telefone:"
        '
        'txtNome
        '
        Me.txtNome.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsClientes1, "Clientes.Nome"))
        Me.txtNome.Location = New System.Drawing.Point(64, 16)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(256, 20)
        Me.txtNome.TabIndex = 3
        Me.txtNome.Text = ""
        '
        'txtEndereco
        '
        Me.txtEndereco.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsClientes1, "Clientes.Endereco"))
        Me.txtEndereco.Location = New System.Drawing.Point(64, 40)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(256, 20)
        Me.txtEndereco.TabIndex = 4
        Me.txtEndereco.Text = ""
        '
        'txtTelefone
        '
        Me.txtTelefone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsClientes1, "Clientes.Telefone"))
        Me.txtTelefone.Location = New System.Drawing.Point(64, 64)
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(208, 20)
        Me.txtTelefone.TabIndex = 5
        Me.txtTelefone.Text = ""
        '
        'txtRegistro
        '
        Me.txtRegistro.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsClientes1, "Clientes.ID"))
        Me.txtRegistro.Location = New System.Drawing.Point(104, 112)
        Me.txtRegistro.Name = "txtRegistro"
        Me.txtRegistro.Size = New System.Drawing.Size(120, 20)
        Me.txtRegistro.TabIndex = 6
        Me.txtRegistro.Text = ""
        '
        'btnIncluir
        '
        Me.btnIncluir.Location = New System.Drawing.Point(336, 8)
        Me.btnIncluir.Name = "btnIncluir"
        Me.btnIncluir.Size = New System.Drawing.Size(88, 24)
        Me.btnIncluir.TabIndex = 7
        Me.btnIncluir.Text = "&Incluir"
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(336, 34)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(88, 24)
        Me.btnSalvar.TabIndex = 8
        Me.btnSalvar.Text = "&Salvar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(336, 60)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(88, 24)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "&Cancelar"
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(336, 86)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(88, 24)
        Me.btnExcluir.TabIndex = 10
        Me.btnExcluir.Text = "&Excluir"
        '
        'btnFechar
        '
        Me.btnFechar.Location = New System.Drawing.Point(336, 120)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(88, 24)
        Me.btnFechar.TabIndex = 11
        Me.btnFechar.Text = "&Fechar"
        '
        'btnPrimeiro
        '
        Me.btnPrimeiro.Location = New System.Drawing.Point(33, 112)
        Me.btnPrimeiro.Name = "btnPrimeiro"
        Me.btnPrimeiro.Size = New System.Drawing.Size(32, 24)
        Me.btnPrimeiro.TabIndex = 12
        Me.btnPrimeiro.Text = "<<"
        '
        'btnAnterior
        '
        Me.btnAnterior.Location = New System.Drawing.Point(67, 112)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(32, 24)
        Me.btnAnterior.TabIndex = 13
        Me.btnAnterior.Text = "<"
        '
        'btnProximo
        '
        Me.btnProximo.Location = New System.Drawing.Point(232, 112)
        Me.btnProximo.Name = "btnProximo"
        Me.btnProximo.Size = New System.Drawing.Size(32, 24)
        Me.btnProximo.TabIndex = 14
        Me.btnProximo.Text = ">"
        '
        'bltUltimo
        '
        Me.bltUltimo.Location = New System.Drawing.Point(265, 112)
        Me.bltUltimo.Name = "bltUltimo"
        Me.bltUltimo.Size = New System.Drawing.Size(32, 24)
        Me.bltUltimo.TabIndex = 15
        Me.bltUltimo.Text = ">>"
        '
        'Contatos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(432, 150)
        Me.Controls.Add(Me.bltUltimo)
        Me.Controls.Add(Me.btnProximo)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.btnPrimeiro)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnIncluir)
        Me.Controls.Add(Me.txtRegistro)
        Me.Controls.Add(Me.txtTelefone)
        Me.Controls.Add(Me.txtEndereco)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Contatos"
        Me.Text = "Contatos"
        CType(Me.DsClientes1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub CarregaDataSet(ByVal DataSet As dsClientes)
        cnAgenda.Open()
        DataSet.EnforceConstraints = False
        Try
            daClientes.Fill(DataSet)
        Catch ex As Exception
            Throw ex
        Finally
            DataSet.EnforceConstraints = True
            cnAgenda.Close()
        End Try
    End Sub

    Private Sub ExibePosicao()
        Dim Contador As Integer
        Dim Posicao As Integer
        Contador = BindingContext(DsClientes1, "Clientes").Count
        If Contador = 0 Then
            txtRegistro.Text = "(Nenhum registro)"
        Else
            Posicao = BindingContext(DsClientes1, "Clientes").Position + 1
            txtRegistro.Text = "Registro " & Posicao.ToString & " de " & Contador.ToString
        End If
    End Sub

    Private Sub Contatos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MsgBox(Application.StartupPath)
        CarregaDataSet(DsClientes1)
        ExibePosicao()
    End Sub
End Class
