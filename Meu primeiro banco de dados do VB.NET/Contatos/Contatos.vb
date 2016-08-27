Imports System.ComponentModel
Imports System.Drawing
Imports System.WinForms


Public Class Form1
    Inherits System.WinForms.Form

    Public Sub New()
        MyBase.New

        Form1 = Me

        'This call is required by the Win Form Designer.
        InitializeComponent()
        MessageBox.Show("Este programa não está completo por não enviar os dados ao servidor e por não possui validações na entrada de dados do usuário.")
        Carrega_DataSet(dsClientes1)
        Exibe_Posicao()
        mnuCancela.Text = "Cancelar &TODAS as operações realizadas desde " & formatdatetime(datetime.Now, Microsoft.VisualBasic.DateFormat.GeneralDate)
        
        'TODO: Add any initialization after the InitializeComponent() call
    End Sub

    'Form overrides dispose to clean up the component list.
    Overrides Public Sub Dispose()
        MyBase.Dispose
        components.Dispose
    End Sub 

#Region " Windows Form Designer generated code "

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.Container
    Private WithEvents mnuCancela As System.WinForms.MenuItem
    Private WithEvents mnuGrava As System.WinForms.MenuItem
    Private WithEvents MenuItem1 As System.WinForms.MenuItem
    Private MainMenu1 As System.WinForms.MainMenu
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    Private WithEvents txtStatus As System.WinForms.TextBox
    Private WithEvents TextBox3 As System.WinForms.TextBox
    Private WithEvents TextBox2 As System.WinForms.TextBox
    Private WithEvents txtNome As System.WinForms.TextBox
    Private WithEvents Label3 As System.WinForms.Label
    Private WithEvents Label2 As System.WinForms.Label
    Private WithEvents Label1 As System.WinForms.Label
    Private WithEvents Button10 As System.WinForms.Button
    Private WithEvents Button9 As System.WinForms.Button
    Private WithEvents Button8 As System.WinForms.Button
    Private WithEvents Button7 As System.WinForms.Button
    Private WithEvents Button6 As System.WinForms.Button
    Private WithEvents Button5 As System.WinForms.Button
    Private WithEvents Button4 As System.WinForms.Button
    
    Private WithEvents Button2 As System.WinForms.Button
    Private WithEvents Button1 As System.WinForms.Button
    Private WithEvents dsClientes1 As Contatos.dsClientes
    Private WithEvents cnAgenda As System.Data.ADO.ADOConnection
    Private WithEvents cmdClientes As System.Data.ADO.ADODataSetCommand
    
    
    
    Dim WithEvents Form1 As System.WinForms.Form

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button8 = New System.WinForms.Button()
        Me.Button9 = New System.WinForms.Button()
        Me.txtStatus = New System.WinForms.TextBox()
        Me.txtNome = New System.WinForms.TextBox()
        Me.mnuGrava = New System.WinForms.MenuItem()
        Me.cmdClientes = New System.Data.ADO.ADODataSetCommand()
        Me.Button7 = New System.WinForms.Button()
        Me.mnuCancela = New System.WinForms.MenuItem()
        Me.Button1 = New System.WinForms.Button()
        Me.Button4 = New System.WinForms.Button()
        Me.Button5 = New System.WinForms.Button()
        Me.Button6 = New System.WinForms.Button()
        Me.MainMenu1 = New System.WinForms.MainMenu()
        Me.MenuItem1 = New System.WinForms.MenuItem()
        Me.TextBox2 = New System.WinForms.TextBox()
        Me.Button2 = New System.WinForms.Button()
        Me.Button10 = New System.WinForms.Button()
        Me.dsClientes1 = New Contatos.dsClientes()
        Me.Label3 = New System.WinForms.Label()
        Me.cnAgenda = New System.Data.ADO.ADOConnection()
        Me.TextBox3 = New System.WinForms.TextBox()
        Me.Label1 = New System.WinForms.Label()
        Me.Label2 = New System.WinForms.Label()
        
        '@design Me.TrayHeight = 90
        '@design Me.TrayLargeIcon = False
        '@design Me.TrayAutoArrange = True
        Button8.Location = New System.Drawing.Point(80, 136)
        Button8.Size = New System.Drawing.Size(32, 24)
        Button8.TabIndex = 7
        Button8.TabStop = False
        Button8.Text = "<"
        
        Button9.Location = New System.Drawing.Point(296, 136)
        Button9.Size = New System.Drawing.Size(32, 24)
        Button9.TabIndex = 8
        Button9.TabStop = False
        Button9.Text = ">>"
        
        '@design txtStatus.Locked = True
        txtStatus.Location = New System.Drawing.Point(112, 136)
        txtStatus.TabIndex = 16
        txtStatus.TabStop = False
        txtStatus.Size = New System.Drawing.Size(152, 20)
        txtStatus.TextAlign = System.WinForms.HorizontalAlignment.Center
        
        txtNome.Location = New System.Drawing.Point(72, 24)
        txtNome.TabIndex = 0
        txtNome.Size = New System.Drawing.Size(264, 20)
        Dim a__1(1) As System.WinForms.ListBinding
        a__1(0) = New System.WinForms.ListBinding("Text", dsClientes1, "Clientes.Nome")
        txtNome.Bindings.All = a__1
        
        mnuGrava.Text = "&Gravar TODAS as alterações para o banco de dados"
        mnuGrava.Index = 0
        
        '@design cmdClientes.SetLocation(New System.Drawing.Point(7, 7))
        Dim a__2(5) As System.Data.ADO.ADOParameter
        a__2(0) = New System.Data.ADO.ADOParameter("Endereco", System.Data.ADO.ADODBType.VarWChar, 510, System.Data.ParameterDirection.Input, False, 255, 255, "Endereco", System.Data.DataRowVersion.Current, Nothing)
        a__2(1) = New System.Data.ADO.ADOParameter("ID", System.Data.ADO.ADODBType.VarWChar, 510, System.Data.ParameterDirection.Input, False, 255, 255, "ID", System.Data.DataRowVersion.Current, Nothing)
        a__2(2) = New System.Data.ADO.ADOParameter("Nome", System.Data.ADO.ADODBType.VarWChar, 510, System.Data.ParameterDirection.Input, False, 255, 255, "Nome", System.Data.DataRowVersion.Current, Nothing)
        a__2(3) = New System.Data.ADO.ADOParameter("Telefone", System.Data.ADO.ADODBType.VarWChar, 510, System.Data.ParameterDirection.Input, False, 255, 255, "Telefone", System.Data.DataRowVersion.Current, Nothing)
        a__2(4) = New System.Data.ADO.ADOParameter("Original_ID", System.Data.ADO.ADODBType.VarWChar, 510, System.Data.ParameterDirection.Input, False, 255, 255, "ID", System.Data.DataRowVersion.Original, Nothing)
        cmdClientes.UpdateCommand = New System.Data.ADO.ADOCommand(cnAgenda, "UPDATE Clientes SET Endereco = ?,  ID = ?,  Nome = ?,  Telefone = ? WHERE (ID = ?) ", System.Data.CommandType.Text, False, a__2, System.Data.UpdateRowSource.Both)
        Dim a__3(1) As System.Data.ADO.ADOParameter
        a__3(0) = New System.Data.ADO.ADOParameter("ID", System.Data.ADO.ADODBType.VarWChar, 510, System.Data.ParameterDirection.Input, False, 255, 255, "ID", System.Data.DataRowVersion.Current, Nothing)
        cmdClientes.DeleteCommand = New System.Data.ADO.ADOCommand(cnAgenda, "DELETE FROM Clientes WHERE (ID = ?) ", System.Data.CommandType.Text, False, a__3, System.Data.UpdateRowSource.Both)
        Dim a__4(4) As System.Data.ADO.ADOParameter
        a__4(0) = New System.Data.ADO.ADOParameter("Endereco", System.Data.ADO.ADODBType.VarWChar, 510, System.Data.ParameterDirection.Input, False, 255, 255, "Endereco", System.Data.DataRowVersion.Current, Nothing)
        a__4(1) = New System.Data.ADO.ADOParameter("ID", System.Data.ADO.ADODBType.VarWChar, 510, System.Data.ParameterDirection.Input, False, 255, 255, "ID", System.Data.DataRowVersion.Current, Nothing)
        a__4(2) = New System.Data.ADO.ADOParameter("Nome", System.Data.ADO.ADODBType.VarWChar, 510, System.Data.ParameterDirection.Input, False, 255, 255, "Nome", System.Data.DataRowVersion.Current, Nothing)
        a__4(3) = New System.Data.ADO.ADOParameter("Telefone", System.Data.ADO.ADODBType.VarWChar, 510, System.Data.ParameterDirection.Input, False, 255, 255, "Telefone", System.Data.DataRowVersion.Current, Nothing)
        cmdClientes.InsertCommand = New System.Data.ADO.ADOCommand(cnAgenda, "INSERT INTO Clientes( Endereco,  ID,  Nome,  Telefone ) VALUES( ?,  ?,  ?,  ? ) ", System.Data.CommandType.Text, False, a__4, System.Data.UpdateRowSource.Both)
        Dim a__5() As System.Data.ADO.ADOParameter
        cmdClientes.SelectCommand = New System.Data.ADO.ADOCommand(cnAgenda, "SELECT Endereco,  ID,  Nome,  Telefone FROM Clientes ", System.Data.CommandType.Text, False, a__5, System.Data.UpdateRowSource.Both)
        Dim a__6(4) As System.Data.Internal.DataColumnMapping
        a__6(0) = New System.Data.Internal.DataColumnMapping("Endereco", "Endereco")
        a__6(1) = New System.Data.Internal.DataColumnMapping("ID", "ID")
        a__6(2) = New System.Data.Internal.DataColumnMapping("Nome", "Nome")
        a__6(3) = New System.Data.Internal.DataColumnMapping("Telefone", "Telefone")
        Dim a__7(1) As System.Data.Internal.DataTableMapping
        a__7(0) = New System.Data.Internal.DataTableMapping("Table", "Clientes", a__6)
        cmdClientes.TableMappings.All = a__7
        
        Button7.Location = New System.Drawing.Point(48, 136)
        Button7.Size = New System.Drawing.Size(32, 24)
        Button7.TabIndex = 6
        Button7.TabStop = False
        Button7.Text = "<<"
        
        mnuCancela.Text = "Cancelar &TODAS... "
        mnuCancela.Index = 1
        
        Button1.Location = New System.Drawing.Point(344, 8)
        Button1.Size = New System.Drawing.Size(72, 24)
        Button1.TabIndex = 3
        Button1.Text = "Incluir"
        
        Button4.Location = New System.Drawing.Point(344, 66)
        Button4.Size = New System.Drawing.Size(72, 24)
        Button4.TabIndex = 5
        Button4.Text = "Cancelar"
        
        Button5.Location = New System.Drawing.Point(344, 95)
        Button5.Size = New System.Drawing.Size(72, 24)
        Button5.TabIndex = 6
        Button5.Text = "Excluir"
        
        Button6.Location = New System.Drawing.Point(344, 136)
        Button6.Size = New System.Drawing.Size(72, 24)
        Button6.TabIndex = 5
        Button6.Text = "Sair"
        
        '@design MainMenu1.SetLocation(New System.Drawing.Point(288, 7))
        Dim a__8(1) As System.WinForms.MenuItem
        a__8(0) = MenuItem1
        MainMenu1.MenuItems.All = a__8
        
        MenuItem1.Text = "&Opções"
        MenuItem1.Index = 0
        Dim a__9(2) As System.WinForms.MenuItem
        a__9(0) = mnuGrava
        a__9(1) = mnuCancela
        MenuItem1.MenuItems.All = a__9
        
        TextBox2.Location = New System.Drawing.Point(72, 56)
        TextBox2.TabIndex = 1
        TextBox2.Size = New System.Drawing.Size(264, 20)
        Dim a__10(1) As System.WinForms.ListBinding
        a__10(0) = New System.WinForms.ListBinding("Text", dsClientes1, "Clientes.Endereco")
        TextBox2.Bindings.All = a__10
        
        Button2.Location = New System.Drawing.Point(344, 37)
        Button2.Size = New System.Drawing.Size(72, 24)
        Button2.TabIndex = 4
        Button2.Text = "Salvar"
        
        Button10.Location = New System.Drawing.Point(264, 136)
        Button10.Size = New System.Drawing.Size(32, 24)
        Button10.TabIndex = 9
        Button10.TabStop = False
        Button10.Text = ">"
        
        '@design dsClientes1.SetLocation(New System.Drawing.Point(193, 7))
        dsClientes1.Prefix = ""
        dsClientes1.DataSetName = "dsClientes"
        dsClientes1.Locale = New System.Globalization.CultureInfo("en-US")
        dsClientes1.Namespace = "http://www.tempuri.org/dsClientes.xsd"
        dsClientes1.Clientes.Prefix = ""
        dsClientes1.Clientes.TableName = "Clientes"
        
        Label3.Location = New System.Drawing.Point(8, 88)
        Label3.Text = "Telefone:"
        Label3.Size = New System.Drawing.Size(50, 13)
        Label3.AutoSize = True
        Label3.TabIndex = 12
        
        '@design cnAgenda.SetLocation(New System.Drawing.Point(105, 7))
        cnAgenda.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\WINDOWS.000\Desktop\Meu primeiro banco de dados do VB.NET\Agenda.mdb;Persist Security Info=False"
        
        TextBox3.Location = New System.Drawing.Point(72, 88)
        TextBox3.TabIndex = 2
        TextBox3.Size = New System.Drawing.Size(264, 20)
        Dim a__11(1) As System.WinForms.ListBinding
        a__11(0) = New System.WinForms.ListBinding("Text", dsClientes1, "Clientes.Telefone")
        TextBox3.Bindings.All = a__11
        
        Label1.Location = New System.Drawing.Point(8, 24)
        Label1.Text = "Nome:"
        Label1.Size = New System.Drawing.Size(36, 13)
        Label1.AutoSize = True
        Label1.TabIndex = 10
        
        Label2.Location = New System.Drawing.Point(8, 56)
        Label2.Text = "Endereco:"
        Label2.Size = New System.Drawing.Size(53, 13)
        Label2.AutoSize = True
        Label2.TabIndex = 11
        Me.Text = "Contatos"
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Menu = MainMenu1
        Me.ClientSize = New System.Drawing.Size(502, 277)
        
        Me.Controls.Add(txtStatus)
        Me.Controls.Add(TextBox3)
        Me.Controls.Add(TextBox2)
        Me.Controls.Add(txtNome)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Button10)
        Me.Controls.Add(Button9)
        Me.Controls.Add(Button8)
        Me.Controls.Add(Button7)
        Me.Controls.Add(Button6)
        Me.Controls.Add(Button5)
        Me.Controls.Add(Button4)
        Me.Controls.Add(Button2)
        Me.Controls.Add(Button1)
    End Sub
    
#End Region
    
    Protected Sub dsClientes1_PropertyChanged(ByVal sender As Object, ByVal e As System.ComponentModel.PropertyChangedEventArgs)
        
    End Sub
    
    Protected Sub Button6_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        If MessageBox.Show("Finalizar o sistema?", Me.Text, MessageBox.OKCancel) = DialogResult.OK Then Me.Finalize()
    End Sub
    
    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.BindingManager(dsClientes1, "Clientes").EndCurrentEdit()
        Exibe_Posicao()
        '    mnuGrava_Click(sender, e)
    End Sub
    
    Protected Sub mnuGrava_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        If MessageBox.Show("Gravar todas as alterações para o servidor?", Me.Text, MessageBox.OKCancel + MessageBox.IconQuestion) = DialogResult.OK Then
            Try
                Me.dsClientes1.AcceptChanges()
                Me.dsClientes1.Merge(dsClientes1, True)
                Exibe_Posicao()
                mnuCancela.Text = "Cancelar &TODAS as operações realizadas desde " & formatdatetime(datetime.Now, Microsoft.VisualBasic.DateFormat.GeneralDate)
            Catch eErro As System.Exception
                MessageBox.Show("Operação não realizada. " & eErro.Message, "Erro " & eErro.ToString, MessageBox.IconError)
            End Try
        End If
    End Sub
    
    Protected Sub mnuCancela_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        If MessageBox.Show("Tem certeza que deseja cancelar as alterações?", Me.Text, MessageBox.OKCancel + MessageBox.IconQuestion + MessageBox.DefaultButton2) = DialogResult.OK Then
            Me.dsClientes1.RejectChanges()
            Exibe_Posicao()
            mnuCancela.Text = "Cancelar &TODAS as operações realizadas desde " & formatdatetime(datetime.Now, Microsoft.VisualBasic.DateFormat.GeneralDate)
        End If
    End Sub
    
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            Me.BindingManager(dsClientes1, "Clientes").CancelCurrentEdit()
            Me.BindingManager(dsClientes1, "Clientes").AddNew()
            Me.txtStatus.Text = "* Novo Registro *"
        Catch eErro As System.Exception
            MessageBox.Show(eerro.Message, eErro.ToString, MessageBox.IconError)
        Finally
            txtNome.Focus()
        End Try
    End Sub
    
    Protected Sub Button5_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        If Me.BindingManager(dsClientes1, "Clientes").Count > 0 Then
            If MessageBox.Show("Deseja excluir o registro '" & Me.txtNome.text & "'?", Me.Text, MessageBox.OKCancel + MessageBox.DefaultButton2 + MessageBox.IconQuestion) = DialogResult.OK Then
                Me.BindingManager(dsClientes1, "Clientes").RemoveAt(Me.BindingManager(dsClientes1, "Clientes").Position)
                Exibe_Posicao()
            End If
        Else
            MsgBox("Não existem registros para serem excluídos.", MsgBoxStyle.Information, Me.Text)
        End If
    End Sub
    
    Protected Sub Button8_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            Me.BindingManager(dsClientes1, "Clientes").Position -= 1
            Exibe_Posicao()
        Catch Erro As System.Exception
            Button7_Click(sender, e)
        End Try
    End Sub
    
    Protected Sub Button9_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.BindingManager(dsClientes1, "Clientes").Position = _
            Me.BindingManager(dsClientes1, "Clientes").Count - 1
        Exibe_Posicao()
    End Sub
    
    Protected Sub Button7_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.BindingManager(dsClientes1, "Clientes").Position = 0
        Exibe_Posicao()
    End Sub
    
    Protected Sub pnlMaster_Paint(ByVal sender As Object, ByVal e As System.WinForms.PaintEventArgs)
        
    End Sub
    
    Protected Sub Form1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        
    End Sub
    
    Public Sub Carrega_DataSet(ByVal dataset As Contatos.dsClientes)
        
        Me.cnAgenda.Open()
        dataset.EnforceConstraints = False
        Try
            Me.cmdClientes.FillDataSet(dataset)
        Catch cErro As System.Exception
            MsgBox(cErro.Message, , "Erro... " & cErro.ToString)
        Finally
            dataset.EnforceConstraints = True
            Me.cnAgenda.Close()
        End Try
    End Sub
    
    Public Sub Exibe_Posicao()
        Dim iContador, iPosicao As Integer
        iContador = Me.BindingManager(dsClientes1, "Clientes").Count
        If iContador = 0 Then
            txtStatus.Text = "(Nenhum registro)"
        Else
            iPosicao = Me.BindingManager(dsClientes1, "Clientes").Position + 1
            txtStatus.Text = "Registro " & iPosicao.ToString & " de " & iContador.ToString
        End If
    End Sub
    
    Protected Sub Label3_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        
    End Sub
    
    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        
    End Sub
    
    Protected Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        If MessageBox.Show("Confirma o cancelamento da operação?", Me.Text, MessageBox.OKCancel + MessageBox.defaultbutton2 + MessageBox.iconquestion) = DialogResult.OK Then
            Me.BindingManager(dsClientes1, "Clientes").CancelCurrentEdit()
            Exibe_Posicao()
        End If
    End Sub
    
    Public Sub Form1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Form1.Enter
        
    End Sub
    
    
    Public Sub Button10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button10.Click
        Try
            Me.BindingManager(dsClientes1, "Clientes").Position += 1
            Exibe_Posicao()
        Catch Erro As System.Exception
            Button9_Click(sender, e)
        End Try
    End Sub
    Public Sub dsClientes1_MergeFailed(ByVal sender As Object, ByVal e As System.Data.MergeFailedEventArgs) Handles dsClientes1.MergeFailed
        
    End Sub
End Class
