VERSION 5.00
Begin VB.Form frmClip 
   Caption         =   "VB6 - Clippboard"
   ClientHeight    =   1350
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   4680
   LinkTopic       =   "Form1"
   ScaleHeight     =   1350
   ScaleWidth      =   4680
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command2 
      Caption         =   "C&olar"
      Height          =   375
      Left            =   2280
      TabIndex        =   2
      Top             =   840
      Width           =   1335
   End
   Begin VB.CommandButton Command1 
      Caption         =   "&Copiar"
      Height          =   375
      Left            =   840
      TabIndex        =   1
      Top             =   840
      Width           =   1335
   End
   Begin VB.TextBox Text1 
      Height          =   330
      Left            =   240
      TabIndex        =   0
      Text            =   "Minha primeira aplicação migrada para VB.NET"
      Top             =   240
      Width           =   4215
   End
End
Attribute VB_Name = "frmClip"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Command1_Click()
    Clipboard.SetText Text1.SelText
End Sub

Private Sub Command2_Click()
    On Error GoTo Erro
    Text1.SelText = Clipboard.GetText
    Exit Sub
Erro:
    MsgBox Err.Description
End Sub
