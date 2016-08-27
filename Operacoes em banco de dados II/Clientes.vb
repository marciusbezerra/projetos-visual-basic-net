Public Class Clientes
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
    Friend WithEvents cnNorthwind As System.Data.OleDb.OleDbConnection
    Friend WithEvents daClientes As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents FillClientes As System.Data.OleDb.OleDbCommand
    Friend WithEvents InsertCliente As System.Data.OleDb.OleDbCommand
    Friend WithEvents UpdateCliente As System.Data.OleDb.OleDbCommand
    Friend WithEvents DeleteCliente As System.Data.OleDb.OleDbCommand
    Friend WithEvents dsCadClientes As Operacoes_em_banco_de_dados_II.dsClientes
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtNomeEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents txtNomeContato As System.Windows.Forms.TextBox
    Friend WithEvents txtCargoContato As System.Windows.Forms.TextBox
    Friend WithEvents txtEndereco As System.Windows.Forms.TextBox
    Friend WithEvents txtCidade As System.Windows.Forms.TextBox
    Friend WithEvents txtRegiao As System.Windows.Forms.TextBox
    Friend WithEvents txtCEP As System.Windows.Forms.TextBox
    Friend WithEvents txtPais As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefone As System.Windows.Forms.TextBox
    Friend WithEvents txtFax As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnPrimeiro As System.Windows.Forms.Button
    Friend WithEvents btnAnterior As System.Windows.Forms.Button
    Friend WithEvents lblPosicaoAtual As System.Windows.Forms.Label
    Friend WithEvents btnProximo As System.Windows.Forms.Button
    Friend WithEvents btnUltimo As System.Windows.Forms.Button
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnCancelarTodos As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Clientes))
        Me.daClientes = New System.Data.OleDb.OleDbDataAdapter
        Me.DeleteCliente = New System.Data.OleDb.OleDbCommand
        Me.cnNorthwind = New System.Data.OleDb.OleDbConnection
        Me.InsertCliente = New System.Data.OleDb.OleDbCommand
        Me.FillClientes = New System.Data.OleDb.OleDbCommand
        Me.UpdateCliente = New System.Data.OleDb.OleDbCommand
        Me.dsCadClientes = New Operacoes_em_banco_de_dados_II.dsClientes
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.txtNomeEmpresa = New System.Windows.Forms.TextBox
        Me.txtNomeContato = New System.Windows.Forms.TextBox
        Me.txtCargoContato = New System.Windows.Forms.TextBox
        Me.txtEndereco = New System.Windows.Forms.TextBox
        Me.txtCidade = New System.Windows.Forms.TextBox
        Me.txtRegiao = New System.Windows.Forms.TextBox
        Me.txtCEP = New System.Windows.Forms.TextBox
        Me.txtPais = New System.Windows.Forms.TextBox
        Me.txtTelefone = New System.Windows.Forms.TextBox
        Me.txtFax = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.btnPrimeiro = New System.Windows.Forms.Button
        Me.btnAnterior = New System.Windows.Forms.Button
        Me.lblPosicaoAtual = New System.Windows.Forms.Label
        Me.btnProximo = New System.Windows.Forms.Button
        Me.btnUltimo = New System.Windows.Forms.Button
        Me.btnNovo = New System.Windows.Forms.Button
        Me.btnSalvar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnCancelarTodos = New System.Windows.Forms.Button
        Me.btnExcluir = New System.Windows.Forms.Button
        Me.btnFechar = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        CType(Me.dsCadClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'daClientes
        '
        Me.daClientes.DeleteCommand = Me.DeleteCliente
        Me.daClientes.InsertCommand = Me.InsertCliente
        Me.daClientes.SelectCommand = Me.FillClientes
        Me.daClientes.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Clientes", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CargoDoContato", "CargoDoContato"), New System.Data.Common.DataColumnMapping("CEP", "CEP"), New System.Data.Common.DataColumnMapping("Cidade", "Cidade"), New System.Data.Common.DataColumnMapping("CódigoDoCliente", "CódigoDoCliente"), New System.Data.Common.DataColumnMapping("Endereço", "Endereço"), New System.Data.Common.DataColumnMapping("Fax", "Fax"), New System.Data.Common.DataColumnMapping("NomeDaEmpresa", "NomeDaEmpresa"), New System.Data.Common.DataColumnMapping("NomeDoContato", "NomeDoContato"), New System.Data.Common.DataColumnMapping("País", "País"), New System.Data.Common.DataColumnMapping("Região", "Região"), New System.Data.Common.DataColumnMapping("Telefone", "Telefone")})})
        Me.daClientes.UpdateCommand = Me.UpdateCliente
        '
        'DeleteCliente
        '
        Me.DeleteCliente.CommandText = "DELETE FROM Clientes WHERE (CódigoDoCliente = ?) AND (CEP = ? OR ? IS NULL AND CE" & _
        "P IS NULL) AND (CargoDoContato = ? OR ? IS NULL AND CargoDoContato IS NULL) AND " & _
        "(Cidade = ? OR ? IS NULL AND Cidade IS NULL) AND (Endereço = ? OR ? IS NULL AND " & _
        "Endereço IS NULL) AND (Fax = ? OR ? IS NULL AND Fax IS NULL) AND (NomeDaEmpresa " & _
        "= ?) AND (NomeDoContato = ? OR ? IS NULL AND NomeDoContato IS NULL) AND (País = " & _
        "? OR ? IS NULL AND País IS NULL) AND (Região = ? OR ? IS NULL AND Região IS NULL" & _
        ") AND (Telefone = ? OR ? IS NULL AND Telefone IS NULL)"
        Me.DeleteCliente.Connection = Me.cnNorthwind
        Me.DeleteCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CódigoDoCliente", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CódigoDoCliente", System.Data.DataRowVersion.Original, Nothing))
        Me.DeleteCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CEP", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CEP", System.Data.DataRowVersion.Original, Nothing))
        Me.DeleteCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CEP1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CEP", System.Data.DataRowVersion.Original, Nothing))
        Me.DeleteCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CargoDoContato", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CargoDoContato", System.Data.DataRowVersion.Original, Nothing))
        Me.DeleteCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CargoDoContato1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CargoDoContato", System.Data.DataRowVersion.Original, Nothing))
        Me.DeleteCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Cidade", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cidade", System.Data.DataRowVersion.Original, Nothing))
        Me.DeleteCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Cidade1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cidade", System.Data.DataRowVersion.Original, Nothing))
        Me.DeleteCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Endereço", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Endereço", System.Data.DataRowVersion.Original, Nothing))
        Me.DeleteCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Endereço1", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Endereço", System.Data.DataRowVersion.Original, Nothing))
        Me.DeleteCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Fax", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fax", System.Data.DataRowVersion.Original, Nothing))
        Me.DeleteCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Fax1", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fax", System.Data.DataRowVersion.Original, Nothing))
        Me.DeleteCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NomeDaEmpresa", System.Data.OleDb.OleDbType.VarWChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NomeDaEmpresa", System.Data.DataRowVersion.Original, Nothing))
        Me.DeleteCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NomeDoContato", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NomeDoContato", System.Data.DataRowVersion.Original, Nothing))
        Me.DeleteCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NomeDoContato1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NomeDoContato", System.Data.DataRowVersion.Original, Nothing))
        Me.DeleteCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_País", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "País", System.Data.DataRowVersion.Original, Nothing))
        Me.DeleteCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_País1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "País", System.Data.DataRowVersion.Original, Nothing))
        Me.DeleteCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Região", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Região", System.Data.DataRowVersion.Original, Nothing))
        Me.DeleteCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Região1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Região", System.Data.DataRowVersion.Original, Nothing))
        Me.DeleteCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Telefone", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefone", System.Data.DataRowVersion.Original, Nothing))
        Me.DeleteCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Telefone1", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefone", System.Data.DataRowVersion.Original, Nothing))
        '
        'cnNorthwind
        '
        Me.cnNorthwind.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" & _
        "ocking Mode=1;Data Source="""";Jet OLEDB:Engine Type=5;Provider=""Microsoft.Jet.OLE" & _
        "DB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;persist security info=Fal" & _
        "se;Extended Properties=;Mode=Share Deny None;Jet OLEDB:Encrypt Database=False;Je" & _
        "t OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=Fals" & _
        "e;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Global " & _
        "Bulk Transactions=1"
        '
        'InsertCliente
        '
        Me.InsertCliente.CommandText = "INSERT INTO Clientes(CargoDoContato, CEP, Cidade, CódigoDoCliente, Endereço, Fax," & _
        " NomeDaEmpresa, NomeDoContato, País, Região, Telefone) VALUES (?, ?, ?, ?, ?, ?," & _
        " ?, ?, ?, ?, ?)"
        Me.InsertCliente.Connection = Me.cnNorthwind
        Me.InsertCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("CargoDoContato", System.Data.OleDb.OleDbType.VarWChar, 30, "CargoDoContato"))
        Me.InsertCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("CEP", System.Data.OleDb.OleDbType.VarWChar, 10, "CEP"))
        Me.InsertCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("Cidade", System.Data.OleDb.OleDbType.VarWChar, 15, "Cidade"))
        Me.InsertCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("CódigoDoCliente", System.Data.OleDb.OleDbType.VarWChar, 5, "CódigoDoCliente"))
        Me.InsertCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("Endereço", System.Data.OleDb.OleDbType.VarWChar, 60, "Endereço"))
        Me.InsertCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("Fax", System.Data.OleDb.OleDbType.VarWChar, 24, "Fax"))
        Me.InsertCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("NomeDaEmpresa", System.Data.OleDb.OleDbType.VarWChar, 40, "NomeDaEmpresa"))
        Me.InsertCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("NomeDoContato", System.Data.OleDb.OleDbType.VarWChar, 30, "NomeDoContato"))
        Me.InsertCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("País", System.Data.OleDb.OleDbType.VarWChar, 15, "País"))
        Me.InsertCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("Região", System.Data.OleDb.OleDbType.VarWChar, 15, "Região"))
        Me.InsertCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("Telefone", System.Data.OleDb.OleDbType.VarWChar, 24, "Telefone"))
        '
        'FillClientes
        '
        Me.FillClientes.CommandText = "SELECT CargoDoContato, CEP, Cidade, CódigoDoCliente, Endereço, Fax, NomeDaEmpresa" & _
        ", NomeDoContato, País, Região, Telefone FROM Clientes"
        Me.FillClientes.Connection = Me.cnNorthwind
        '
        'UpdateCliente
        '
        Me.UpdateCliente.CommandText = "UPDATE Clientes SET CargoDoContato = ?, CEP = ?, Cidade = ?, CódigoDoCliente = ?," & _
        " Endereço = ?, Fax = ?, NomeDaEmpresa = ?, NomeDoContato = ?, País = ?, Região =" & _
        " ?, Telefone = ? WHERE (CódigoDoCliente = ?) AND (CEP = ? OR ? IS NULL AND CEP I" & _
        "S NULL) AND (CargoDoContato = ? OR ? IS NULL AND CargoDoContato IS NULL) AND (Ci" & _
        "dade = ? OR ? IS NULL AND Cidade IS NULL) AND (Endereço = ? OR ? IS NULL AND End" & _
        "ereço IS NULL) AND (Fax = ? OR ? IS NULL AND Fax IS NULL) AND (NomeDaEmpresa = ?" & _
        ") AND (NomeDoContato = ? OR ? IS NULL AND NomeDoContato IS NULL) AND (País = ? O" & _
        "R ? IS NULL AND País IS NULL) AND (Região = ? OR ? IS NULL AND Região IS NULL) A" & _
        "ND (Telefone = ? OR ? IS NULL AND Telefone IS NULL)"
        Me.UpdateCliente.Connection = Me.cnNorthwind
        Me.UpdateCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("CargoDoContato", System.Data.OleDb.OleDbType.VarWChar, 30, "CargoDoContato"))
        Me.UpdateCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("CEP", System.Data.OleDb.OleDbType.VarWChar, 10, "CEP"))
        Me.UpdateCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("Cidade", System.Data.OleDb.OleDbType.VarWChar, 15, "Cidade"))
        Me.UpdateCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("CódigoDoCliente", System.Data.OleDb.OleDbType.VarWChar, 5, "CódigoDoCliente"))
        Me.UpdateCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("Endereço", System.Data.OleDb.OleDbType.VarWChar, 60, "Endereço"))
        Me.UpdateCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("Fax", System.Data.OleDb.OleDbType.VarWChar, 24, "Fax"))
        Me.UpdateCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("NomeDaEmpresa", System.Data.OleDb.OleDbType.VarWChar, 40, "NomeDaEmpresa"))
        Me.UpdateCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("NomeDoContato", System.Data.OleDb.OleDbType.VarWChar, 30, "NomeDoContato"))
        Me.UpdateCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("País", System.Data.OleDb.OleDbType.VarWChar, 15, "País"))
        Me.UpdateCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("Região", System.Data.OleDb.OleDbType.VarWChar, 15, "Região"))
        Me.UpdateCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("Telefone", System.Data.OleDb.OleDbType.VarWChar, 24, "Telefone"))
        Me.UpdateCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CódigoDoCliente", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CódigoDoCliente", System.Data.DataRowVersion.Original, Nothing))
        Me.UpdateCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CEP", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CEP", System.Data.DataRowVersion.Original, Nothing))
        Me.UpdateCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CEP1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CEP", System.Data.DataRowVersion.Original, Nothing))
        Me.UpdateCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CargoDoContato", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CargoDoContato", System.Data.DataRowVersion.Original, Nothing))
        Me.UpdateCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CargoDoContato1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CargoDoContato", System.Data.DataRowVersion.Original, Nothing))
        Me.UpdateCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Cidade", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cidade", System.Data.DataRowVersion.Original, Nothing))
        Me.UpdateCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Cidade1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cidade", System.Data.DataRowVersion.Original, Nothing))
        Me.UpdateCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Endereço", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Endereço", System.Data.DataRowVersion.Original, Nothing))
        Me.UpdateCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Endereço1", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Endereço", System.Data.DataRowVersion.Original, Nothing))
        Me.UpdateCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Fax", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fax", System.Data.DataRowVersion.Original, Nothing))
        Me.UpdateCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Fax1", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fax", System.Data.DataRowVersion.Original, Nothing))
        Me.UpdateCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NomeDaEmpresa", System.Data.OleDb.OleDbType.VarWChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NomeDaEmpresa", System.Data.DataRowVersion.Original, Nothing))
        Me.UpdateCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NomeDoContato", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NomeDoContato", System.Data.DataRowVersion.Original, Nothing))
        Me.UpdateCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NomeDoContato1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NomeDoContato", System.Data.DataRowVersion.Original, Nothing))
        Me.UpdateCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_País", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "País", System.Data.DataRowVersion.Original, Nothing))
        Me.UpdateCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_País1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "País", System.Data.DataRowVersion.Original, Nothing))
        Me.UpdateCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Região", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Região", System.Data.DataRowVersion.Original, Nothing))
        Me.UpdateCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Região1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Região", System.Data.DataRowVersion.Original, Nothing))
        Me.UpdateCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Telefone", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefone", System.Data.DataRowVersion.Original, Nothing))
        Me.UpdateCliente.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Telefone1", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefone", System.Data.DataRowVersion.Original, Nothing))
        '
        'dsCadClientes
        '
        Me.dsCadClientes.DataSetName = "dsClientes"
        Me.dsCadClientes.Locale = New System.Globalization.CultureInfo("pt-BR")
        '
        'txtCodigo
        '
        Me.txtCodigo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dsCadClientes, "Clientes.CódigoDoCliente"))
        Me.txtCodigo.Location = New System.Drawing.Point(116, 98)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.TabIndex = 0
        Me.txtCodigo.Text = ""
        '
        'txtNomeEmpresa
        '
        Me.txtNomeEmpresa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNomeEmpresa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dsCadClientes, "Clientes.NomeDaEmpresa"))
        Me.txtNomeEmpresa.Location = New System.Drawing.Point(116, 122)
        Me.txtNomeEmpresa.Name = "txtNomeEmpresa"
        Me.txtNomeEmpresa.Size = New System.Drawing.Size(317, 20)
        Me.txtNomeEmpresa.TabIndex = 1
        Me.txtNomeEmpresa.Text = ""
        '
        'txtNomeContato
        '
        Me.txtNomeContato.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNomeContato.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dsCadClientes, "Clientes.NomeDoContato"))
        Me.txtNomeContato.Location = New System.Drawing.Point(116, 146)
        Me.txtNomeContato.Name = "txtNomeContato"
        Me.txtNomeContato.Size = New System.Drawing.Size(317, 20)
        Me.txtNomeContato.TabIndex = 2
        Me.txtNomeContato.Text = ""
        '
        'txtCargoContato
        '
        Me.txtCargoContato.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCargoContato.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dsCadClientes, "Clientes.CargoDoContato"))
        Me.txtCargoContato.Location = New System.Drawing.Point(116, 170)
        Me.txtCargoContato.Name = "txtCargoContato"
        Me.txtCargoContato.Size = New System.Drawing.Size(317, 20)
        Me.txtCargoContato.TabIndex = 3
        Me.txtCargoContato.Text = ""
        '
        'txtEndereco
        '
        Me.txtEndereco.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEndereco.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dsCadClientes, "Clientes.Endereço"))
        Me.txtEndereco.Location = New System.Drawing.Point(116, 194)
        Me.txtEndereco.Multiline = True
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtEndereco.Size = New System.Drawing.Size(317, 34)
        Me.txtEndereco.TabIndex = 4
        Me.txtEndereco.Text = ""
        '
        'txtCidade
        '
        Me.txtCidade.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCidade.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dsCadClientes, "Clientes.Cidade"))
        Me.txtCidade.Location = New System.Drawing.Point(116, 232)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(202, 20)
        Me.txtCidade.TabIndex = 5
        Me.txtCidade.Text = ""
        '
        'txtRegiao
        '
        Me.txtRegiao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRegiao.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dsCadClientes, "Clientes.Região"))
        Me.txtRegiao.Location = New System.Drawing.Point(116, 256)
        Me.txtRegiao.Name = "txtRegiao"
        Me.txtRegiao.Size = New System.Drawing.Size(202, 20)
        Me.txtRegiao.TabIndex = 6
        Me.txtRegiao.Text = ""
        '
        'txtCEP
        '
        Me.txtCEP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCEP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dsCadClientes, "Clientes.CEP"))
        Me.txtCEP.Location = New System.Drawing.Point(116, 280)
        Me.txtCEP.Name = "txtCEP"
        Me.txtCEP.TabIndex = 7
        Me.txtCEP.Text = ""
        '
        'txtPais
        '
        Me.txtPais.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPais.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dsCadClientes, "Clientes.País"))
        Me.txtPais.Location = New System.Drawing.Point(116, 304)
        Me.txtPais.Name = "txtPais"
        Me.txtPais.Size = New System.Drawing.Size(202, 20)
        Me.txtPais.TabIndex = 8
        Me.txtPais.Text = ""
        '
        'txtTelefone
        '
        Me.txtTelefone.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTelefone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dsCadClientes, "Clientes.Telefone"))
        Me.txtTelefone.Location = New System.Drawing.Point(116, 328)
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(202, 20)
        Me.txtTelefone.TabIndex = 9
        Me.txtTelefone.Text = ""
        '
        'txtFax
        '
        Me.txtFax.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFax.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dsCadClientes, "Clientes.Fax"))
        Me.txtFax.Location = New System.Drawing.Point(116, 352)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(202, 20)
        Me.txtFax.TabIndex = 10
        Me.txtFax.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 16)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Código:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Nome da empresa:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 16)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Nome do contato:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 16)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Cargo do contato:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(53, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Endereço:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(66, 240)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 16)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Cidade:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(66, 264)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 16)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Região:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(78, 288)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 16)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "CEP:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(80, 312)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 16)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "País:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(58, 336)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 16)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Telefone:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(83, 360)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 16)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Fax:"
        '
        'btnPrimeiro
        '
        Me.btnPrimeiro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrimeiro.Location = New System.Drawing.Point(331, 352)
        Me.btnPrimeiro.Name = "btnPrimeiro"
        Me.btnPrimeiro.Size = New System.Drawing.Size(32, 23)
        Me.btnPrimeiro.TabIndex = 11
        Me.btnPrimeiro.Text = "<<"
        '
        'btnAnterior
        '
        Me.btnAnterior.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAnterior.Location = New System.Drawing.Point(363, 352)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(32, 23)
        Me.btnAnterior.TabIndex = 12
        Me.btnAnterior.Text = "<"
        '
        'lblPosicaoAtual
        '
        Me.lblPosicaoAtual.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPosicaoAtual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPosicaoAtual.Location = New System.Drawing.Point(395, 352)
        Me.lblPosicaoAtual.Name = "lblPosicaoAtual"
        Me.lblPosicaoAtual.Size = New System.Drawing.Size(107, 23)
        Me.lblPosicaoAtual.TabIndex = 34
        Me.lblPosicaoAtual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnProximo
        '
        Me.btnProximo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProximo.Location = New System.Drawing.Point(502, 352)
        Me.btnProximo.Name = "btnProximo"
        Me.btnProximo.Size = New System.Drawing.Size(32, 23)
        Me.btnProximo.TabIndex = 13
        Me.btnProximo.Text = ">"
        '
        'btnUltimo
        '
        Me.btnUltimo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUltimo.Location = New System.Drawing.Point(534, 352)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(32, 23)
        Me.btnUltimo.TabIndex = 14
        Me.btnUltimo.Text = ">>"
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.Location = New System.Drawing.Point(448, 100)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(118, 24)
        Me.btnNovo.TabIndex = 15
        Me.btnNovo.Text = "&Novo registro"
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Location = New System.Drawing.Point(448, 128)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(118, 24)
        Me.btnSalvar.TabIndex = 16
        Me.btnSalvar.Text = "&Salvar alterações"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Location = New System.Drawing.Point(448, 156)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(118, 24)
        Me.btnCancelar.TabIndex = 17
        Me.btnCancelar.Text = "&Cancelar"
        '
        'btnCancelarTodos
        '
        Me.btnCancelarTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelarTodos.Location = New System.Drawing.Point(448, 184)
        Me.btnCancelarTodos.Name = "btnCancelarTodos"
        Me.btnCancelarTodos.Size = New System.Drawing.Size(118, 24)
        Me.btnCancelarTodos.TabIndex = 18
        Me.btnCancelarTodos.Text = "Cancelar &todos"
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluir.Location = New System.Drawing.Point(448, 212)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(118, 24)
        Me.btnExcluir.TabIndex = 19
        Me.btnExcluir.Text = "&Excluir registro"
        '
        'btnFechar
        '
        Me.btnFechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFechar.Location = New System.Drawing.Point(448, 240)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(118, 24)
        Me.btnFechar.TabIndex = 20
        Me.btnFechar.Text = "&Fechar"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(21, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(86, 86)
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Black", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(137, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(281, 42)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "M.a.r.c.i.u.s. Ltda."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(137, 50)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(213, 27)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Cadastro de clientes"
        '
        'Clientes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(581, 387)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnCancelarTodos)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.btnUltimo)
        Me.Controls.Add(Me.btnProximo)
        Me.Controls.Add(Me.lblPosicaoAtual)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.btnPrimeiro)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFax)
        Me.Controls.Add(Me.txtTelefone)
        Me.Controls.Add(Me.txtPais)
        Me.Controls.Add(Me.txtCEP)
        Me.Controls.Add(Me.txtRegiao)
        Me.Controls.Add(Me.txtCidade)
        Me.Controls.Add(Me.txtEndereco)
        Me.Controls.Add(Me.txtCargoContato)
        Me.Controls.Add(Me.txtNomeContato)
        Me.Controls.Add(Me.txtNomeEmpresa)
        Me.Controls.Add(Me.txtCodigo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Clientes"
        Me.Text = ":: Clientes Northwind ::"
        CType(Me.dsCadClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private WithEvents Cl As ManipulacaoRegistros
    Private Sub Clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim od As OpenFileDialog
        od = New OpenFileDialog
        od.Filter = "Banco de dados Northwind (em português)|Northwind.mdb|Qualquer arquivo (*.*)|*.*"
        If od.ShowDialog = DialogResult.OK Then
            Me.cnNorthwind.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" & _
            "ocking Mode=1;Data Source=""" & od.FileName & """;Jet OLEDB:Engine Type=5;Provider=""Microsoft.Jet.OLEDB.4.0"";Je" & _
            "t OLEDB:System database=;Jet OLEDB:SFP=False;persist security info=False;Extende" & _
            "d Properties=;Mode=Share Deny None;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Cr" & _
            "eate System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLED" & _
            "B:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Global Bulk Trans" & _
            "actions=1"
            Cl = New ManipulacaoRegistros
            With Cl
                Try
                    .ControleContexto = Me
                    .Conexao = cnNorthwind
                    .da = daClientes
                    .ds = dsCadClientes
                    .NomeTabela = "Clientes"
                    .CarregaDados()
                Catch Erro As Exception
                    MsgBox(Erro.Message, MsgBoxStyle.Critical, Text)
                End Try
            End With
        Else
            Me.Close()
        End If
    End Sub

    Private Sub Cl_MoveuRegistro(ByVal PosicaoAtual As Integer, ByVal NumeroDeRegistros As Integer, ByVal InicioDaTabela As Boolean, ByVal FimDaTabela As Boolean, ByVal StringPosicaoAtual As String) Handles Cl.MoveuRegistro
        lblPosicaoAtual.Text = StringPosicaoAtual
        btnPrimeiro.Enabled = Not InicioDaTabela
        btnAnterior.Enabled = Not InicioDaTabela
        btnProximo.Enabled = Not FimDaTabela
        btnUltimo.Enabled = Not FimDaTabela
    End Sub

    Private Sub btnPrimeiro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrimeiro.Click
        Cl.Primeiro()
    End Sub

    Private Sub btnAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnterior.Click
        Cl.Anterior()
    End Sub

    Private Sub btnProximo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProximo.Click
        Cl.Proximo()
    End Sub

    Private Sub btnUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUltimo.Click
        Cl.Ultimo()
    End Sub

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Cl.Remover()
    End Sub

    Private Sub Cl_ValidaExclusao(ByVal Tabela As System.Data.DataTable, ByVal BContexto As System.Windows.Forms.BindingManagerBase, ByRef Pode As Boolean) Handles Cl.ValidaExclusao
        Pode = (MsgBox("Confirma a exclusão do registro '" & _
            txtNomeEmpresa.Text & "'?", _
            MsgBoxStyle.YesNo, Text) = MsgBoxResult.Yes)
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Try
            Cl.AplicarTodasAsModificoes()
        Catch Erro As Exception
            MsgBox(Erro.Message, MsgBoxStyle.Critical, Text)
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Cl.Cancelar()
    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        Cl.Adicionar()
    End Sub

    Private Sub btnCancelarTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarTodos.Click
        Cl.RejeitarTodasAsModificacoes()
    End Sub
End Class
