Public Class TodasCategorias

    Private Sub CategoiaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CategoiaBindingSource.EndEdit()
        Me.CategoiaTableAdapter.Update(Me.CategoriaDataSet.Categoia)

    End Sub

    Private Sub TodasCategorias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CategoriaDataSet.Categoia' table. You can move, or remove it, as needed.
        Me.CategoiaTableAdapter.Fill(Me.CategoriaDataSet.Categoia)

    End Sub

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
    End Sub
End Class