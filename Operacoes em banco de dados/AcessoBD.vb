Public Class AcessoBD
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
    Friend WithEvents daDados As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents SelecionaAutor As System.Data.OleDb.OleDbCommand
    Friend WithEvents InsereAutor As System.Data.OleDb.OleDbCommand
    Friend WithEvents AtualizaAutor As System.Data.OleDb.OleDbCommand
    Friend WithEvents DeletaAutor As System.Data.OleDb.OleDbCommand
    Friend WithEvents cnBanco As System.Data.OleDb.OleDbConnection
    Friend WithEvents dsAutores As Operacoes_em_banco_de_dados.Autores
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents llPri As System.Windows.Forms.LinkLabel
    Friend WithEvents llAnt As System.Windows.Forms.LinkLabel
    Friend WithEvents llPro As System.Windows.Forms.LinkLabel
    Friend WithEvents llUlt As System.Windows.Forms.LinkLabel
    Friend WithEvents txtCod As System.Windows.Forms.TextBox
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents txtDtNc As System.Windows.Forms.TextBox
    Friend WithEvents btnCad As System.Windows.Forms.Button
    Friend WithEvents btnExc As System.Windows.Forms.Button
    Friend WithEvents lblContador As System.Windows.Forms.Label
    Friend WithEvents btnCan As System.Windows.Forms.Button
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.daDados = New System.Data.OleDb.OleDbDataAdapter
        Me.DeletaAutor = New System.Data.OleDb.OleDbCommand
        Me.cnBanco = New System.Data.OleDb.OleDbConnection
        Me.InsereAutor = New System.Data.OleDb.OleDbCommand
        Me.SelecionaAutor = New System.Data.OleDb.OleDbCommand
        Me.AtualizaAutor = New System.Data.OleDb.OleDbCommand
        Me.dsAutores = New Operacoes_em_banco_de_dados.Autores
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblContador = New System.Windows.Forms.Label
        Me.txtDtNc = New System.Windows.Forms.TextBox
        Me.txtNom = New System.Windows.Forms.TextBox
        Me.txtCod = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnCad = New System.Windows.Forms.Button
        Me.btnExc = New System.Windows.Forms.Button
        Me.btnCan = New System.Windows.Forms.Button
        Me.llPri = New System.Windows.Forms.LinkLabel
        Me.llAnt = New System.Windows.Forms.LinkLabel
        Me.llPro = New System.Windows.Forms.LinkLabel
        Me.llUlt = New System.Windows.Forms.LinkLabel
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        CType(Me.dsAutores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'daDados
        '
        Me.daDados.DeleteCommand = Me.DeletaAutor
        Me.daDados.InsertCommand = Me.InsereAutor
        Me.daDados.SelectCommand = Me.SelecionaAutor
        Me.daDados.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Authors", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Au_ID", "Au_ID"), New System.Data.Common.DataColumnMapping("Author", "Author"), New System.Data.Common.DataColumnMapping("Year Born", "Year Born")})})
        Me.daDados.UpdateCommand = Me.AtualizaAutor
        '
        'DeletaAutor
        '
        Me.DeletaAutor.CommandText = "DELETE FROM Authors WHERE (Au_ID = ?) AND (Author = ? OR ? IS NULL AND Author IS " & _
        "NULL) AND ([Year Born] = ? OR ? IS NULL AND [Year Born] IS NULL)"
        Me.DeletaAutor.Connection = Me.cnBanco
        Me.DeletaAutor.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Au_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Au_ID", System.Data.DataRowVersion.Original, Nothing))
        Me.DeletaAutor.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Author", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Author", System.Data.DataRowVersion.Original, Nothing))
        Me.DeletaAutor.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Author1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Author", System.Data.DataRowVersion.Original, Nothing))
        Me.DeletaAutor.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Year_Born", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Year Born", System.Data.DataRowVersion.Original, Nothing))
        Me.DeletaAutor.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Year_Born1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Year Born", System.Data.DataRowVersion.Original, Nothing))
        '
        'cnBanco
        '
        Me.cnBanco.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" & _
        "ocking Mode=0;Data Source=""C:\Arquivos de programas\Microsoft Visual Studio\VB98" & _
        "\BIBLIO.MDB"";Jet OLEDB:Engine Type=4;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLED" & _
        "B:System database=;Jet OLEDB:SFP=False;persist security info=False;Extended Prop" & _
        "erties=;Mode=Share Deny None;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Create S" & _
        "ystem Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Comp" & _
        "act Without Replica Repair=False;User ID=Admin;Jet OLEDB:Global Bulk Transaction" & _
        "s=1"
        '
        'InsereAutor
        '
        Me.InsereAutor.CommandText = "INSERT INTO Authors(Author, [Year Born]) VALUES (?, ?)"
        Me.InsereAutor.Connection = Me.cnBanco
        Me.InsereAutor.Parameters.Add(New System.Data.OleDb.OleDbParameter("Author", System.Data.OleDb.OleDbType.VarWChar, 50, "Author"))
        Me.InsereAutor.Parameters.Add(New System.Data.OleDb.OleDbParameter("Year_Born", System.Data.OleDb.OleDbType.SmallInt, 0, "Year Born"))
        '
        'SelecionaAutor
        '
        Me.SelecionaAutor.CommandText = "SELECT Au_ID, Author, [Year Born] FROM Authors"
        Me.SelecionaAutor.Connection = Me.cnBanco
        '
        'AtualizaAutor
        '
        Me.AtualizaAutor.CommandText = "UPDATE Authors SET Author = ?, [Year Born] = ? WHERE (Au_ID = ?) AND (Author = ? " & _
        "OR ? IS NULL AND Author IS NULL) AND ([Year Born] = ? OR ? IS NULL AND [Year Bor" & _
        "n] IS NULL)"
        Me.AtualizaAutor.Connection = Me.cnBanco
        Me.AtualizaAutor.Parameters.Add(New System.Data.OleDb.OleDbParameter("Author", System.Data.OleDb.OleDbType.VarWChar, 50, "Author"))
        Me.AtualizaAutor.Parameters.Add(New System.Data.OleDb.OleDbParameter("Year_Born", System.Data.OleDb.OleDbType.SmallInt, 0, "Year Born"))
        Me.AtualizaAutor.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Au_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Au_ID", System.Data.DataRowVersion.Original, Nothing))
        Me.AtualizaAutor.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Author", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Author", System.Data.DataRowVersion.Original, Nothing))
        Me.AtualizaAutor.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Author1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Author", System.Data.DataRowVersion.Original, Nothing))
        Me.AtualizaAutor.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Year_Born", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Year Born", System.Data.DataRowVersion.Original, Nothing))
        Me.AtualizaAutor.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Year_Born1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Year Born", System.Data.DataRowVersion.Original, Nothing))
        '
        'dsAutores
        '
        Me.dsAutores.DataSetName = "Autores"
        Me.dsAutores.Locale = New System.Globalization.CultureInfo("pt-BR")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblContador)
        Me.GroupBox1.Controls.Add(Me.txtDtNc)
        Me.GroupBox1.Controls.Add(Me.txtNom)
        Me.GroupBox1.Controls.Add(Me.txtCod)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(355, 101)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informações sobre autores"
        '
        'lblContador
        '
        Me.lblContador.Location = New System.Drawing.Point(205, 79)
        Me.lblContador.Name = "lblContador"
        Me.lblContador.Size = New System.Drawing.Size(140, 15)
        Me.lblContador.TabIndex = 6
        Me.lblContador.Text = "Nenhum registro"
        Me.lblContador.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDtNc
        '
        Me.txtDtNc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dsAutores, "Authors.Year Born"))
        Me.txtDtNc.Location = New System.Drawing.Point(64, 72)
        Me.txtDtNc.Name = "txtDtNc"
        Me.txtDtNc.Size = New System.Drawing.Size(128, 20)
        Me.txtDtNc.TabIndex = 5
        Me.txtDtNc.Text = ""
        '
        'txtNom
        '
        Me.txtNom.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dsAutores, "Authors.Author"))
        Me.txtNom.Location = New System.Drawing.Point(64, 48)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(280, 20)
        Me.txtNom.TabIndex = 4
        Me.txtNom.Text = ""
        '
        'txtCod
        '
        Me.txtCod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dsAutores, "Authors.Au_ID"))
        Me.txtCod.Location = New System.Drawing.Point(64, 24)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(128, 20)
        Me.txtCod.TabIndex = 3
        Me.txtCod.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Dt. Nasc.:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nome:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código:"
        '
        'btnCad
        '
        Me.btnCad.Location = New System.Drawing.Point(103, 114)
        Me.btnCad.Name = "btnCad"
        Me.btnCad.Size = New System.Drawing.Size(72, 24)
        Me.btnCad.TabIndex = 5
        Me.btnCad.Text = "&Cadastrar"
        '
        'btnExc
        '
        Me.btnExc.Location = New System.Drawing.Point(183, 114)
        Me.btnExc.Name = "btnExc"
        Me.btnExc.Size = New System.Drawing.Size(72, 24)
        Me.btnExc.TabIndex = 6
        Me.btnExc.Text = "&Excluir"
        '
        'btnCan
        '
        Me.btnCan.Location = New System.Drawing.Point(263, 114)
        Me.btnCan.Name = "btnCan"
        Me.btnCan.Size = New System.Drawing.Size(72, 24)
        Me.btnCan.TabIndex = 8
        Me.btnCan.Text = "C&ancelar"
        '
        'llPri
        '
        Me.llPri.AutoSize = True
        Me.llPri.Location = New System.Drawing.Point(13, 117)
        Me.llPri.Name = "llPri"
        Me.llPri.Size = New System.Drawing.Size(17, 16)
        Me.llPri.TabIndex = 9
        Me.llPri.TabStop = True
        Me.llPri.Text = "<<"
        '
        'llAnt
        '
        Me.llAnt.AutoSize = True
        Me.llAnt.Location = New System.Drawing.Point(38, 117)
        Me.llAnt.Name = "llAnt"
        Me.llAnt.Size = New System.Drawing.Size(11, 16)
        Me.llAnt.TabIndex = 10
        Me.llAnt.TabStop = True
        Me.llAnt.Text = "<"
        '
        'llPro
        '
        Me.llPro.AutoSize = True
        Me.llPro.Location = New System.Drawing.Point(57, 117)
        Me.llPro.Name = "llPro"
        Me.llPro.Size = New System.Drawing.Size(11, 16)
        Me.llPro.TabIndex = 11
        Me.llPro.TabStop = True
        Me.llPro.Text = ">"
        '
        'llUlt
        '
        Me.llUlt.AutoSize = True
        Me.llUlt.Location = New System.Drawing.Point(76, 117)
        Me.llUlt.Name = "llUlt"
        Me.llUlt.Size = New System.Drawing.Size(17, 16)
        Me.llUlt.TabIndex = 12
        Me.llUlt.TabStop = True
        Me.llUlt.Text = ">>"
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem5})
        Me.MenuItem1.Text = "Arquivo"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "&Gravar todas as modificações"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 1
        Me.MenuItem3.Text = "&Cancelar todas as modificações"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 2
        Me.MenuItem4.Text = "-"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 3
        Me.MenuItem5.Text = "Sair"
        '
        'AcessoBD
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(371, 148)
        Me.Controls.Add(Me.llUlt)
        Me.Controls.Add(Me.llPro)
        Me.Controls.Add(Me.llAnt)
        Me.Controls.Add(Me.llPri)
        Me.Controls.Add(Me.btnCan)
        Me.Controls.Add(Me.btnExc)
        Me.Controls.Add(Me.btnCad)
        Me.Controls.Add(Me.GroupBox1)
        Me.Menu = Me.MainMenu1
        Me.Name = "AcessoBD"
        Me.Text = "Acesso a bancode dados Access (ADO)"
        CType(Me.dsAutores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub MostraDados()
        Dim Posicao, Contador As Integer
        Contador = BindingContext(dsAutores, "Authors").Count
        If Contador > 0 Then
            Posicao = BindingContext(dsAutores, "Authors").Position + 1
            lblContador.Text = "Registro: " & Format(Posicao, "##,###,##0") & " / " & _
                Format(Contador, "##,###,##0")
        Else
            lblContador.Text = "Nenhum registro"
        End If
    End Sub

    Private Sub AcessoBD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dsAutores.Clear()
        daDados.Fill(dsAutores)
        MostraDados()
    End Sub

    Private Sub llPri_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llPri.LinkClicked
        BindingContext(dsAutores, "Authors").Position = 0
        MostraDados()
    End Sub

    Private Sub llAnt_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llAnt.LinkClicked
        BindingContext(dsAutores, "Authors").Position -= 1
        MostraDados()
    End Sub

    Private Sub llPro_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llPro.LinkClicked
        BindingContext(dsAutores, "Authors").Position += 1
        MostraDados()
    End Sub

    Private Sub llUlt_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llUlt.LinkClicked
        BindingContext(dsAutores, "Authors").Position = BindingContext(dsAutores, "Authors").Count - 1
        MostraDados()
    End Sub

    Private Sub btnExc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExc.Click
        If MsgBox("Deseja excluir o registro atual?", MsgBoxStyle.YesNo _
            Or MsgBoxStyle.Question Or MsgBoxStyle.DefaultButton2, Text) = MsgBoxResult.Yes Then
            If BindingContext(dsAutores, "Authors").Count > 0 Then
                BindingContext(dsAutores, "Authors").RemoveAt( _
                    BindingContext(dsAutores, "Authors").Position)
                MostraDados()
            Else
                MsgBox("Arquivo vazio.", MsgBoxStyle.Information, Text)
            End If
        End If
    End Sub

    Private Sub btnCad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCad.Click
        Try
            BindingContext(dsAutores, "Authors").EndCurrentEdit()
            BindingContext(dsAutores, "Authors").AddNew()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Text)
        Finally
            txtCod.Focus()
        End Try
    End Sub

    Private Sub btnCan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCan.Click
        If MsgBox("Cancelar?", MsgBoxStyle.YesNo _
            Or MsgBoxStyle.Question Or MsgBoxStyle.DefaultButton2, _
            Text) = MsgBoxResult.Yes Then
            BindingContext(dsAutores, "Authors").CancelCurrentEdit()
            MostraDados()
        End If
    End Sub

    Private Sub GroupBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GroupBox1.KeyDown
        If e.KeyCode = Keys.Escape Then btnCad_Click(sender, e)
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        If MessageBox.Show("Cancelar todas as modificações ainda não salvas?", _
            Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
            MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            Try
                dsAutores.RejectChanges()
                MostraDados()
            Catch ex As Exception
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Try
            dsAutores.AcceptChanges()
            MostraDados()
            MsgBox("Dados foram gravados com sucesso!", MsgBoxStyle.Information, Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Text)
        End Try
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        Close()
    End Sub

End Class
