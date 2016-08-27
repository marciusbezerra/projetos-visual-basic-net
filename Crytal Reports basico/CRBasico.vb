
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.OleDb

Public Class CRBasico
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
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Nothing
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(720, 494)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'CRBasico
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(720, 494)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "CRBasico"
        Me.Text = "CRYSTAL REPORTS BÁSICO"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub CRBasico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Conn As OleDbConnection
        Dim da As OleDbDataAdapter
        Dim ds As DataSet
        Dim Rel As CrysBasico
        Try
            Conn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;" & _
                "Data Source=""" & Application.StartupPath & "\Northwind.mdb""")
            da = New OleDbDataAdapter("SELECT CódigoDoCliente, NomeDaEmpresa, " & _
                "NomeDoContato FROM Clientes ORDER BY NomeDaEmpresa", Conn)
            ds = New DataSet("Clientes")
            Rel = New CrysBasico
            Conn.Open()
            da.Fill(ds, "Clientes")
            Rel.SetDataSource(ds.Tables(0))
            Me.CrystalReportViewer1.ReportSource = Rel
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Text)
        Finally
            Conn.Close()
            Conn = Nothing
        End Try
    End Sub
End Class
