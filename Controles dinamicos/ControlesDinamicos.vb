
Imports System.Drawing.Color

Public Class ControlesDinamicos
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        '
        'ControlesDinamicos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Name = "ControlesDinamicos"
        Me.Text = "Form1"

    End Sub

#End Region

    Private txtBox As New TextBox
    Private WithEvents btnAdd As New Button
    Private lstBox As New ListBox
    Private chkBox As New CheckBox
    Private lblCount As New Label

    Private Sub ControlesDinamicos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With Me
            .MaximizeBox = False
            .MinimizeBox = False
            .BackColor = Yellow
            .ForeColor = Black
            .Size = New System.Drawing.Size(300, 265)
            .Text = "Controle dinâmico (em tempo de execução)"
            .FormBorderStyle = FormBorderStyle.FixedDialog
            .StartPosition = FormStartPosition.CenterScreen
        End With
        With Me.txtBox
            .Text = "Teste"
            .Location = New System.Drawing.Point(10, 25)
            .Size = New System.Drawing.Size(70, 20)
        End With
        With btnAdd
            .BackColor = Cyan
            .Text = "Incluir valor"
            .Location = New System.Drawing.Point(90, 25)
            .Size = New System.Drawing.Size(90, 25)
        End With
        With chkBox
            .Text = "Desabilitar"
            .Location = New System.Drawing.Point(90, 25)
            .Size = New System.Drawing.Size(110, 30)
        End With
        With lstBox
            .Items.Add("Ana Maria")
            .Items.Add("Paulo Coelho")
            .Items.Add("Fernando Lima")
            .Items.Add("Janice Raquel")
            .Sorted = True
            .Location = New System.Drawing.Point(10, 55)
            .Size = New System.Drawing.Size(130, 95)
        End With
        With lblCount
            .Text = lstBox.Items.Count.ToString & " item(ns)"
            .Location = New System.Drawing.Point(55, 60)
            .Size = New System.Drawing.Size(65, 15)
        End With

        'Adicionando os controles criados ao form...
        With Controls
            .Add(btnAdd)
            .Add(txtBox)
            .Add(lstBox)
            .Add(chkBox)
            .Add(lblCount)
        End With
    End Sub

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        lstBox.Items.Add(txtBox.Text)
    End Sub
End Class
