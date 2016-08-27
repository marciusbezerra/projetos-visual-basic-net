VERSION 5.00
Object = "{0ECD9B60-23AA-11D0-B351-00A0C9055D8E}#6.0#0"; "MSHFLXGD.OCX"
Begin VB.Form frmVB6_ADO 
   Caption         =   "Aplicação antiga VB6 com ADO"
   ClientHeight    =   6990
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   9930
   LinkTopic       =   "Form1"
   ScaleHeight     =   6990
   ScaleWidth      =   9930
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command1 
      Caption         =   "&OK"
      Height          =   375
      Left            =   7680
      TabIndex        =   1
      Top             =   6480
      Width           =   2055
   End
   Begin MSHierarchicalFlexGridLib.MSHFlexGrid MSHFlexGrid1 
      Height          =   6255
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   9615
      _ExtentX        =   16960
      _ExtentY        =   11033
      _Version        =   393216
      FixedCols       =   0
      _NumberOfBands  =   1
      _Band(0).Cols   =   2
   End
End
Attribute VB_Name = "frmVB6_ADO"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Dim Conn As ADODB.Connection
Dim RC As ADODB.Recordset

Private Sub Command1_Click()
    frmClip.Show vbModal
End Sub

Private Sub Form_Load()
    Set Conn = New ADODB.Connection
    Conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
        "c:\Arquivos de programas\Microsoft Office\Office\Samples\Northwind.mdb"
    Conn.Open
    Set RC = New ADODB.Recordset
    RC.CursorLocation = adUseClient
    RC.Open "SELECT * FROM Produtos", Conn
    Set MSHFlexGrid1.DataSource = RC
End Sub

Private Sub Form_QueryUnload(Cancel As Integer, UnloadMode As Integer)
    RC.Close
    Conn.Close
    Set RC = Nothing
    Set Conn = Nothing
End Sub
