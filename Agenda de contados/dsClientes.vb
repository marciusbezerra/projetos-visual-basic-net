﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version: 1.1.4322.2032
'
'     Changes to this file may cause incorrect behavior and will be lost if 
'     the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.Data
Imports System.Runtime.Serialization
Imports System.Xml


<Serializable(),  _
 System.ComponentModel.DesignerCategoryAttribute("code"),  _
 System.Diagnostics.DebuggerStepThrough(),  _
 System.ComponentModel.ToolboxItem(true)>  _
Public Class dsClientes
    Inherits DataSet
    
    Private tableClientes As ClientesDataTable
    
    Public Sub New()
        MyBase.New
        Me.InitClass
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
        MyBase.New
        Dim strSchema As String = CType(info.GetValue("XmlSchema", GetType(System.String)),String)
        If (Not (strSchema) Is Nothing) Then
            Dim ds As DataSet = New DataSet
            ds.ReadXmlSchema(New XmlTextReader(New System.IO.StringReader(strSchema)))
            If (Not (ds.Tables("Clientes")) Is Nothing) Then
                Me.Tables.Add(New ClientesDataTable(ds.Tables("Clientes")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.InitClass
        End If
        Me.GetSerializationData(info, context)
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property Clientes As ClientesDataTable
        Get
            Return Me.tableClientes
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As dsClientes = CType(MyBase.Clone,dsClientes)
        cln.InitVars
        Return cln
    End Function
    
    Protected Overrides Function ShouldSerializeTables() As Boolean
        Return false
    End Function
    
    Protected Overrides Function ShouldSerializeRelations() As Boolean
        Return false
    End Function
    
    Protected Overrides Sub ReadXmlSerializable(ByVal reader As XmlReader)
        Me.Reset
        Dim ds As DataSet = New DataSet
        ds.ReadXml(reader)
        If (Not (ds.Tables("Clientes")) Is Nothing) Then
            Me.Tables.Add(New ClientesDataTable(ds.Tables("Clientes")))
        End If
        Me.DataSetName = ds.DataSetName
        Me.Prefix = ds.Prefix
        Me.Namespace = ds.Namespace
        Me.Locale = ds.Locale
        Me.CaseSensitive = ds.CaseSensitive
        Me.EnforceConstraints = ds.EnforceConstraints
        Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
        Me.InitVars
    End Sub
    
    Protected Overrides Function GetSchemaSerializable() As System.Xml.Schema.XmlSchema
        Dim stream As System.IO.MemoryStream = New System.IO.MemoryStream
        Me.WriteXmlSchema(New XmlTextWriter(stream, Nothing))
        stream.Position = 0
        Return System.Xml.Schema.XmlSchema.Read(New XmlTextReader(stream), Nothing)
    End Function
    
    Friend Sub InitVars()
        Me.tableClientes = CType(Me.Tables("Clientes"),ClientesDataTable)
        If (Not (Me.tableClientes) Is Nothing) Then
            Me.tableClientes.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "dsClientes"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/dsClientes.xsd"
        Me.Locale = New System.Globalization.CultureInfo("pt-BR")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableClientes = New ClientesDataTable
        Me.Tables.Add(Me.tableClientes)
    End Sub
    
    Private Function ShouldSerializeClientes() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub ClientesRowChangeEventHandler(ByVal sender As Object, ByVal e As ClientesRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class ClientesDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnEndereco As DataColumn
        
        Private columnID As DataColumn
        
        Private columnNome As DataColumn
        
        Private columnTelefone As DataColumn
        
        Friend Sub New()
            MyBase.New("Clientes")
            Me.InitClass
        End Sub
        
        Friend Sub New(ByVal table As DataTable)
            MyBase.New(table.TableName)
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
            Me.DisplayExpression = table.DisplayExpression
        End Sub
        
        <System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        Friend ReadOnly Property EnderecoColumn As DataColumn
            Get
                Return Me.columnEndereco
            End Get
        End Property
        
        Friend ReadOnly Property IDColumn As DataColumn
            Get
                Return Me.columnID
            End Get
        End Property
        
        Friend ReadOnly Property NomeColumn As DataColumn
            Get
                Return Me.columnNome
            End Get
        End Property
        
        Friend ReadOnly Property TelefoneColumn As DataColumn
            Get
                Return Me.columnTelefone
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As ClientesRow
            Get
                Return CType(Me.Rows(index),ClientesRow)
            End Get
        End Property
        
        Public Event ClientesRowChanged As ClientesRowChangeEventHandler
        
        Public Event ClientesRowChanging As ClientesRowChangeEventHandler
        
        Public Event ClientesRowDeleted As ClientesRowChangeEventHandler
        
        Public Event ClientesRowDeleting As ClientesRowChangeEventHandler
        
        Public Overloads Sub AddClientesRow(ByVal row As ClientesRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddClientesRow(ByVal Endereco As String, ByVal ID As Integer, ByVal Nome As String, ByVal Telefone As String) As ClientesRow
            Dim rowClientesRow As ClientesRow = CType(Me.NewRow,ClientesRow)
            rowClientesRow.ItemArray = New Object() {Endereco, ID, Nome, Telefone}
            Me.Rows.Add(rowClientesRow)
            Return rowClientesRow
        End Function
        
        Public Function FindByID(ByVal ID As Integer) As ClientesRow
            Return CType(Me.Rows.Find(New Object() {ID}),ClientesRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As ClientesDataTable = CType(MyBase.Clone,ClientesDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New ClientesDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnEndereco = Me.Columns("Endereco")
            Me.columnID = Me.Columns("ID")
            Me.columnNome = Me.Columns("Nome")
            Me.columnTelefone = Me.Columns("Telefone")
        End Sub
        
        Private Sub InitClass()
            Me.columnEndereco = New DataColumn("Endereco", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnEndereco)
            Me.columnID = New DataColumn("ID", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnID)
            Me.columnNome = New DataColumn("Nome", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnNome)
            Me.columnTelefone = New DataColumn("Telefone", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnTelefone)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnID}, true))
            Me.columnID.AllowDBNull = false
            Me.columnID.Unique = true
        End Sub
        
        Public Function NewClientesRow() As ClientesRow
            Return CType(Me.NewRow,ClientesRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New ClientesRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(ClientesRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.ClientesRowChangedEvent) Is Nothing) Then
                RaiseEvent ClientesRowChanged(Me, New ClientesRowChangeEvent(CType(e.Row,ClientesRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.ClientesRowChangingEvent) Is Nothing) Then
                RaiseEvent ClientesRowChanging(Me, New ClientesRowChangeEvent(CType(e.Row,ClientesRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.ClientesRowDeletedEvent) Is Nothing) Then
                RaiseEvent ClientesRowDeleted(Me, New ClientesRowChangeEvent(CType(e.Row,ClientesRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.ClientesRowDeletingEvent) Is Nothing) Then
                RaiseEvent ClientesRowDeleting(Me, New ClientesRowChangeEvent(CType(e.Row,ClientesRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveClientesRow(ByVal row As ClientesRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class ClientesRow
        Inherits DataRow
        
        Private tableClientes As ClientesDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableClientes = CType(Me.Table,ClientesDataTable)
        End Sub
        
        Public Property Endereco As String
            Get
                Try 
                    Return CType(Me(Me.tableClientes.EnderecoColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableClientes.EnderecoColumn) = value
            End Set
        End Property
        
        Public Property ID As Integer
            Get
                Return CType(Me(Me.tableClientes.IDColumn),Integer)
            End Get
            Set
                Me(Me.tableClientes.IDColumn) = value
            End Set
        End Property
        
        Public Property Nome As String
            Get
                Try 
                    Return CType(Me(Me.tableClientes.NomeColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableClientes.NomeColumn) = value
            End Set
        End Property
        
        Public Property Telefone As String
            Get
                Try 
                    Return CType(Me(Me.tableClientes.TelefoneColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableClientes.TelefoneColumn) = value
            End Set
        End Property
        
        Public Function IsEnderecoNull() As Boolean
            Return Me.IsNull(Me.tableClientes.EnderecoColumn)
        End Function
        
        Public Sub SetEnderecoNull()
            Me(Me.tableClientes.EnderecoColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsNomeNull() As Boolean
            Return Me.IsNull(Me.tableClientes.NomeColumn)
        End Function
        
        Public Sub SetNomeNull()
            Me(Me.tableClientes.NomeColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsTelefoneNull() As Boolean
            Return Me.IsNull(Me.tableClientes.TelefoneColumn)
        End Function
        
        Public Sub SetTelefoneNull()
            Me(Me.tableClientes.TelefoneColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class ClientesRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As ClientesRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As ClientesRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As ClientesRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        Public ReadOnly Property Action As DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
End Class
