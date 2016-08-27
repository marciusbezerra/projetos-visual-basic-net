
Imports System.Globalization

Public Class frmCulturas
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnPreencheCulturas As System.Windows.Forms.Button
    Friend WithEvents btnTraduz As System.Windows.Forms.Button
    Friend WithEvents cmbSemana As System.Windows.Forms.ComboBox
    Friend WithEvents lstCulturas As System.Windows.Forms.ListBox
    Friend WithEvents lblSemana As System.Windows.Forms.Label
    Friend WithEvents lblMes As System.Windows.Forms.Label
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnPreencheCulturas = New System.Windows.Forms.Button
        Me.btnTraduz = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblSemana = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblMes = New System.Windows.Forms.Label
        Me.lstCulturas = New System.Windows.Forms.ListBox
        Me.cmbSemana = New System.Windows.Forms.ComboBox
        Me.TrackBar1 = New System.Windows.Forms.TrackBar
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPreencheCulturas
        '
        Me.btnPreencheCulturas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPreencheCulturas.Location = New System.Drawing.Point(16, 40)
        Me.btnPreencheCulturas.Name = "btnPreencheCulturas"
        Me.btnPreencheCulturas.Size = New System.Drawing.Size(248, 24)
        Me.btnPreencheCulturas.TabIndex = 0
        Me.btnPreencheCulturas.Text = "&Preencher lista com culturas intaladas"
        '
        'btnTraduz
        '
        Me.btnTraduz.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTraduz.Location = New System.Drawing.Point(272, 136)
        Me.btnTraduz.Name = "btnTraduz"
        Me.btnTraduz.Size = New System.Drawing.Size(224, 24)
        Me.btnTraduz.TabIndex = 1
        Me.btnTraduz.Text = "&Traduzir para a cultura selecionada"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(272, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Selecione um dia da semana:"
        '
        'lblSemana
        '
        Me.lblSemana.BackColor = System.Drawing.Color.BurlyWood
        Me.lblSemana.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblSemana.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSemana.ForeColor = System.Drawing.Color.Yellow
        Me.lblSemana.Location = New System.Drawing.Point(272, 184)
        Me.lblSemana.Name = "lblSemana"
        Me.lblSemana.Size = New System.Drawing.Size(224, 32)
        Me.lblSemana.TabIndex = 3
        Me.lblSemana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(272, 248)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tradução do mês atual:"
        '
        'lblMes
        '
        Me.lblMes.BackColor = System.Drawing.Color.MediumTurquoise
        Me.lblMes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMes.ForeColor = System.Drawing.Color.Yellow
        Me.lblMes.Location = New System.Drawing.Point(272, 264)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(224, 32)
        Me.lblMes.TabIndex = 5
        Me.lblMes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstCulturas
        '
        Me.lstCulturas.Location = New System.Drawing.Point(16, 72)
        Me.lstCulturas.Name = "lstCulturas"
        Me.lstCulturas.Size = New System.Drawing.Size(248, 225)
        Me.lstCulturas.TabIndex = 6
        '
        'cmbSemana
        '
        Me.cmbSemana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSemana.Location = New System.Drawing.Point(272, 104)
        Me.cmbSemana.Name = "cmbSemana"
        Me.cmbSemana.Size = New System.Drawing.Size(224, 21)
        Me.cmbSemana.TabIndex = 7
        '
        'TrackBar1
        '
        Me.TrackBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TrackBar1.Location = New System.Drawing.Point(0, 329)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Minimum = 40
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(512, 45)
        Me.TrackBar1.TabIndex = 8
        Me.TrackBar1.Value = 90
        '
        'frmCulturas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(512, 374)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.cmbSemana)
        Me.Controls.Add(Me.lstCulturas)
        Me.Controls.Add(Me.lblMes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblSemana)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnTraduz)
        Me.Controls.Add(Me.btnPreencheCulturas)
        Me.MaximizeBox = False
        Me.Name = "frmCulturas"
        Me.Opacity = 0.9
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VB.NET - Dias da semana e mêses em várias culturas (línguas)"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim DiasSemana() As String = {"Domingo", "Segunda-Feira", "Terça-Feira", _
            "Quarta-Feira", "Quinta-Feira", "Sexta-Feira", "Sábado"}
        cmbSemana.DataSource = DiasSemana
        cmbSemana.SelectedIndex = 0
        btnPreencheCulturas_Click(sender, e)
    End Sub

    Private Sub btnPreencheCulturas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreencheCulturas.Click
        Dim cis() As CultureInfo = CultureInfo.GetCultures(CultureTypes.InstalledWin32Cultures)
        Dim ci As CultureInfo
        lstCulturas.Items.Clear()
        For Each ci In cis
            lstCulturas.Items.Add(ci.Name & " - " & ci.EnglishName)
        Next
        If lstCulturas.Items.Count > 0 Then lstCulturas.SelectedIndex = 0
    End Sub

    Private Sub btnTraduz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTraduz.Click
        Dim Cultura As String
        Cultura = lstCulturas.SelectedItem
        Cultura = Cultura.Substring(0, 5)
        Dim ci As New CultureInfo(Cultura)
        Dim dt As DateTimeFormatInfo = ci.DateTimeFormat
        Select Case cmbSemana.SelectedIndex
            Case 0
                lblSemana.Text = dt.GetDayName(DayOfWeek.Sunday)
                lblMes.Text = dt.GetMonthName(Now.Month)
            Case 1
                lblSemana.Text = dt.GetDayName(DayOfWeek.Monday)
                lblMes.Text = dt.GetMonthName(Now.Month)
            Case 2
                lblSemana.Text = dt.GetDayName(DayOfWeek.Thursday)
                lblMes.Text = dt.GetMonthName(Now.Month)
            Case 3
                lblSemana.Text = dt.GetDayName(DayOfWeek.Wednesday)
                lblMes.Text = dt.GetMonthName(Now.Month)
            Case 4
                lblSemana.Text = dt.GetDayName(DayOfWeek.Thursday)
                lblMes.Text = dt.GetMonthName(Now.Month)
            Case 5
                lblSemana.Text = dt.GetDayName(DayOfWeek.Friday)
                lblMes.Text = dt.GetMonthName(Now.Month)
            Case 6
                lblSemana.Text = dt.GetDayName(DayOfWeek.Saturday)
                lblMes.Text = dt.GetMonthName(Now.Month)
        End Select
    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
        Opacity = TrackBar1.Value / 100
    End Sub
End Class
