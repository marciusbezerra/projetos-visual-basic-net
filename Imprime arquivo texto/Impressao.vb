
Imports System.Drawing.Printing
Imports System.IO
Imports System.Windows.Forms

Module Impressao

    Private WithEvents docImprime As PrintDocument
    Private ArquivoFonte As StreamReader
    Private TamFonte As System.Drawing.Font

    Public Sub Main()

        Try
            Dim DocAbrir As New OpenFileDialog
            DocAbrir.Filter = "Arquivos de texto|*.txt|Qualquer arquivo|*.*"
            If DocAbrir.ShowDialog = DialogResult.OK Then
                ArquivoFonte = New StreamReader(DocAbrir.FileName)
                docImprime = New PrintDocument
                TamFonte = New System.Drawing.Font("Verdana", 10, Drawing.FontStyle.Bold)
                docImprime.DocumentName = "VB.NET - Teste de impressão"
                Dim ppdVisualiza As PrintPreviewDialog = New PrintPreviewDialog
                ppdVisualiza.Document = docImprime
                ppdVisualiza.ShowDialog()
                'docImprime.Print()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If Not (ArquivoFonte Is Nothing) Then ArquivoFonte.Close()
        End Try
    End Sub

    Private Sub docImprime_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles docImprime.PrintPage
        Dim PosicaoVertical As Single = 0, Contador As Single = 0
        Dim Linha As String = ""
        While Not (Linha Is Nothing)
            Linha = ArquivoFonte.ReadLine
            PosicaoVertical = e.MarginBounds.Top + Contador * TamFonte.GetHeight(e.Graphics)
            e.Graphics.DrawString(Linha, TamFonte, System.Drawing.Brushes.BlueViolet, _
                e.MarginBounds.Left, PosicaoVertical)
            Contador += 1
        End While
    End Sub
End Module
