
Imports System.IO

Public Class frmListView
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
    Friend WithEvents btnCriarListView As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnCriarListView = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnCriarListView
        '
        Me.btnCriarListView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCriarListView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCriarListView.Location = New System.Drawing.Point(8, 200)
        Me.btnCriarListView.Name = "btnCriarListView"
        Me.btnCriarListView.Size = New System.Drawing.Size(568, 32)
        Me.btnCriarListView.TabIndex = 0
        Me.btnCriarListView.Text = "&Criar ListView em tempo de execução"
        '
        'frmListView
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(584, 238)
        Me.Controls.Add(Me.btnCriarListView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "frmListView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VB.NET - ListView em tempo de execução"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnCriarListView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCriarListView.Click
        CriaLista()
    End Sub

    Private Sub CriaLista()
        Dim lv As New ListView
        lv.Bounds = New Rectangle(New Point(10, 10), _
            New Size(btnCriarListView.Size.Width, 180))
        lv.View = View.Details
        lv.LabelEdit = True
        lv.AllowColumnReorder = True
        lv.CheckBoxes = True
        lv.FullRowSelect = True
        lv.GridLines = True
        lv.Sorting = SortOrder.Ascending
        lv.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or _
            AnchorStyles.Top Or AnchorStyles.Right
        lv.BorderStyle = BorderStyle.FixedSingle
        Dim it As New ListViewItem(("Marcius Carneiro Bezerra").ToUpper, 1)
        it.Checked = True
        it.SubItems.Add("698.700.633-33")
        it.SubItems.Add(("Pleno").ToUpper)
        it.SubItems.Add(("Programador de Computador").ToUpper)
        it.Font = New Font(Font.Name, it.Font.Size, _
            FontStyle.Bold, it.Font.Unit, it.Font.GdiCharSet)
        Dim it1 As New ListViewItem(("Marcela Lima Olivier").ToUpper, 1)
        it1.SubItems.Add("456.835.786-78")
        it1.SubItems.Add(("Senior").ToUpper)
        it1.SubItems.Add(("Programador de Computador").ToUpper)
        Dim it2 As New ListViewItem(("Paulo Augusto Barreto").ToUpper, 2)
        it2.SubItems.Add("407.968.493-02")
        it2.SubItems.Add(("Senior").ToUpper)
        it2.SubItems.Add(("Analista de Sistemas").ToUpper)
        Dim it3 As New ListViewItem(("Francisco Brandão Junior").ToUpper, 2)
        it3.Checked = True
        it3.SubItems.Add("387.503.216-75")
        it3.SubItems.Add(("Pleno").ToUpper)
        it3.SubItems.Add(("Analista de Sistemas").ToUpper)
        Dim it4 As New ListViewItem(("Bia Mariana Rocha").ToUpper, 0)
        it4.SubItems.Add("369.760.437-89")
        it4.SubItems.Add(("Junior").ToUpper)
        it4.SubItems.Add(("Analista de Sistemas").ToUpper)
        Dim it5 As New ListViewItem(("Nádia Braga dos Santos").ToUpper, -1)
        it5.Checked = True
        it5.SubItems.Add("566.785.433-57")
        it5.SubItems.Add(("Estagiário").ToUpper)
        it5.SubItems.Add(("Programador de Computador").ToUpper)

        lv.Columns.Add("Nome do funcionário", -2, HorizontalAlignment.Left)
        lv.Columns.Add("C.P.F.", -2, HorizontalAlignment.Center)
        lv.Columns.Add("Status", -2, HorizontalAlignment.Center)
        lv.Columns.Add("Cargo", -2, HorizontalAlignment.Left)

        Dim ImagensPequenas As New ImageList
        Dim ImagensGrandes As New ImageList

        Dim f1 As String = "C:\Arquivos de programas\Microsoft Visual Studio .NET 2003\Common7\Graphics\icons\Elements\MOON01.ICO"
        Dim f2 As String = "C:\Arquivos de programas\Microsoft Visual Studio .NET 2003\Common7\Graphics\icons\Elements\MOON03.ICO"
        Dim f3 As String = "C:\Arquivos de programas\Microsoft Visual Studio .NET 2003\Common7\Graphics\icons\Elements\MOON05.ICO"

        'If File.Exists(f1) Then
        Try
            ImagensGrandes.Images.Add(Bitmap.FromFile(f1))
            ImagensPequenas.Images.Add(Bitmap.FromFile(f1))
            ImagensGrandes.Images.Add(Bitmap.FromFile(f2))
            ImagensPequenas.Images.Add(Bitmap.FromFile(f2))
            ImagensGrandes.Images.Add(Bitmap.FromFile(f3))
            ImagensPequenas.Images.Add(Bitmap.FromFile(f3))
            lv.SmallImageList = ImagensPequenas
            lv.LargeImageList = ImagensGrandes
        Catch ex As FileNotFoundException
            MsgBox("Você não tem o Visual Studio .NET 2003 instalado em " & _
                """C:\Arquivos de programas\"", o ListView vai ficar sem imagens", _
                MsgBoxStyle.Information, Text)
        End Try
        'End If

        lv.Items.AddRange(New ListViewItem() {it, it1, it2, it3, it4, it5})
        Me.Controls.Add(lv)
        Me.FormBorderStyle = FormBorderStyle.Sizable
        Me.MaximizeBox = True
        Me.btnCriarListView.Enabled = False
    End Sub
End Class
