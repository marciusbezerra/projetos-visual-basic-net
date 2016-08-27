Option Strict Off
Option Explicit On
Friend Class frmVB6_ADO
	Inherits System.Windows.Forms.Form
#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
		If m_vb6FormDefInstance Is Nothing Then
			If m_InitializingDefInstance Then
				m_vb6FormDefInstance = Me
			Else
				Try 
					'For the start-up form, the first instance created is the default instance.
					If System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType Is Me.GetType Then
						m_vb6FormDefInstance = Me
					End If
				Catch
				End Try
			End If
		End If
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents MSHFlexGrid1 As AxMSHierarchicalFlexGridLib.AxMSHFlexGrid
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmVB6_ADO))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ToolTip1.Active = True
		Me.Command1 = New System.Windows.Forms.Button
		Me.MSHFlexGrid1 = New AxMSHierarchicalFlexGridLib.AxMSHFlexGrid
		CType(Me.MSHFlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "Aplicação antiga VB6 com ADO"
		Me.ClientSize = New System.Drawing.Size(662, 466)
		Me.Location = New System.Drawing.Point(4, 30)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.MaximizeBox = True
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmVB6_ADO"
		Me.Command1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command1.Text = "&OK"
		Me.Command1.Size = New System.Drawing.Size(137, 25)
		Me.Command1.Location = New System.Drawing.Point(512, 432)
		Me.Command1.TabIndex = 1
		Me.Command1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command1.BackColor = System.Drawing.SystemColors.Control
		Me.Command1.CausesValidation = True
		Me.Command1.Enabled = True
		Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command1.TabStop = True
		Me.Command1.Name = "Command1"
		MSHFlexGrid1.OcxState = CType(resources.GetObject("MSHFlexGrid1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.MSHFlexGrid1.Size = New System.Drawing.Size(641, 417)
		Me.MSHFlexGrid1.Location = New System.Drawing.Point(8, 8)
		Me.MSHFlexGrid1.TabIndex = 0
		Me.MSHFlexGrid1.Name = "MSHFlexGrid1"
		Me.Controls.Add(Command1)
		Me.Controls.Add(MSHFlexGrid1)
		CType(Me.MSHFlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
	End Sub
#End Region 
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmVB6_ADO
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmVB6_ADO
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New frmVB6_ADO()
				m_InitializingDefInstance = False
			End If
			DefInstance = m_vb6FormDefInstance
		End Get
		Set
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region 
	
	Dim Conn As ADODB.Connection
	Dim RC As ADODB.Recordset
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		frmClip.DefInstance.ShowDialog()
	End Sub
	
	Private Sub frmVB6_ADO_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Conn = New ADODB.Connection
		Conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & "c:\Arquivos de programas\Microsoft Office\Office\Samples\Northwind.mdb"
		Conn.Open()
		RC = New ADODB.Recordset
		RC.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		RC.Open("SELECT * FROM Produtos", Conn)
		MSHFlexGrid1.DataSource = RC
	End Sub
	
	'UPGRADE_WARNING: Form event frmVB6_ADO.QueryUnload has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2065"'
	Private Sub frmVB6_ADO_Closing(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
		Dim Cancel As Short = eventArgs.Cancel
		RC.Close()
		Conn.Close()
		'UPGRADE_NOTE: Object RC may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		RC = Nothing
		'UPGRADE_NOTE: Object Conn may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		Conn = Nothing
		eventArgs.Cancel = Cancel
	End Sub
End Class