
Imports System.Threading

Public Class MuliTarefa
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
    Friend WithEvents btnIniPrinc As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnIniPrinc = New System.Windows.Forms.Button
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.SuspendLayout()
        '
        'btnIniPrinc
        '
        Me.btnIniPrinc.Location = New System.Drawing.Point(64, 40)
        Me.btnIniPrinc.Name = "btnIniPrinc"
        Me.btnIniPrinc.Size = New System.Drawing.Size(264, 32)
        Me.btnIniPrinc.TabIndex = 0
        Me.btnIniPrinc.Text = "&Iniciar thread principal"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(8, 120)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(424, 32)
        Me.ProgressBar1.TabIndex = 1
        '
        'MuliTarefa
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 158)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnIniPrinc)
        Me.Name = "MuliTarefa"
        Me.Text = "Usando MuliTarefa no VB .NET"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Trd As Thread

    Private Sub Tarefa()
        Dim Passo As Integer
        Dim NovoValor As Integer
        Dim Rnd As New Random
        Do
            Passo = ProgressBar1.Step * Rnd.Next(-1, 10)
            NovoValor = ProgressBar1.Step + Passo
            If NovoValor > ProgressBar1.Maximum Then
                NovoValor = ProgressBar1.Maximum
            ElseIf NovoValor < ProgressBar1.Minimum Then
                NovoValor = ProgressBar1.Minimum
            End If
            ProgressBar1.Value = NovoValor
            Trd.Sleep(100)
        Loop
    End Sub

    Private Sub MuliTarefa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Trd = New Thread(AddressOf Tarefa)
        Trd.IsBackground = True
        Trd.Start()
    End Sub

    Private Sub btnIniPrinc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIniPrinc.Click
        MsgBox("Esta é a tarefa principal, a que está rodando a ProgressBar é a de background")
    End Sub
End Class
