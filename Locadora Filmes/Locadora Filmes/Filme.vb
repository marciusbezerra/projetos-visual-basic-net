Public Class Filme

    Private Sub FilmeBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilmeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FilmeBindingSource.EndEdit()
        Me.FilmeTableAdapter.Update(Me.FilmeDataSet.Filme)

    End Sub

    Private Sub Filme_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FilmeDataSet.Filme' table. You can move, or remove it, as needed.
        Me.FilmeTableAdapter.Fill(Me.FilmeDataSet.Filme)

    End Sub
End Class