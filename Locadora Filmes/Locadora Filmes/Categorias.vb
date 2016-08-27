Public Class Categorias


    Private Sub Categorias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CategoiaBindingSource.AddNew()
    End Sub

    Private Sub btCriar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCriar.Click
        If Me.Validate Then
            Me.CategoiaBindingSource.EndEdit()
            Me.CategoiaTableAdapter.Update(Me.CategoriaDataSet.Categoia)
        Else
            MessageBox.Show(Me, "Erro")
        End If
        Me.Close()
    End Sub

    Private Sub DescricaoTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles DescricaoTextBox.Validating
        If Me.DescricaoTextBox.Text.Trim.Length = 0 Then
            e.Cancel = True
            ErrorProvider1.SetError(sender, "Informe a descrição da categoria")
        Else
            ErrorProvider1.SetError(sender, Nothing)
        End If
    End Sub

    Private Sub btCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancelar.Click
        Me.Close()
    End Sub

    Private Sub Categorias_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.CategoiaBindingSource.CancelEdit()
    End Sub
End Class