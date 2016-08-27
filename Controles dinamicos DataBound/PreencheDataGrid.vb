
Imports System.Data
Imports System.Data.OleDb
Imports System.Windows.Forms

Module PreencheDataGrid
    Public Sub Main()
        Dim Conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
            """c:\Arquivos de programas\Microsoft Office\Office\Samples\Northwind.mdb""")
        Dim da As New OleDbDataAdapter
        Dim ds As New DataSet("ds")
        Dim Grid As New DataGrid
        Dim frm As New Form
        Try
            da.SelectCommand = New OleDbCommand("SELECT * FROM Clientes", Conn)
            da.FillSchema(ds, SchemaType.Mapped)
            da.Fill(ds)
            Grid.Dock = DockStyle.Fill
            Grid.DataSource = ds
            Grid.DataMember = "Table"
            frm.Controls.Add(Grid)
            frm.Text = "Preenchendo um DataGrid"
            frm.WindowState = FormWindowState.Maximized 
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub
End Module
