Public Class Acesso

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cn As New SqlClient.SqlConnection
        Dim cmd As New SqlClient.SqlCommand
        Dim t As SqlClient.SqlTransaction

        Dim reg As Integer

        cn.ConnectionString = My.Settings.LocadoraConnectionString

        If txtUsuario.Text.Trim = "" Then
            MessageBox.Show("Informe o usuário")
            txtUsuario.Focus()
            Exit Sub
        End If

        If txtSenha1.Text.Trim = "" Then
            MessageBox.Show("Informe a senha")
            txtSenha1.Focus()
            Exit Sub
        End If

        If txtSenha2.Text.Trim = "" Then
            MessageBox.Show("Confirme a senha")
            txtSenha2.Focus()
            Exit Sub
        End If

        If Not txtSenha1.Text.Trim.Equals(txtSenha2.Text.Trim) Then
            MessageBox.Show("Senha não confere")
            txtSenha2.Focus()
            Exit Sub
        End If

        Try
            cn.Open()

            t = cn.BeginTransaction()
            cmd.Transaction = t
            cmd.Connection = cn
            cmd.CommandText = "insert into usuarios (nomeusuario,senhaid) values (@nom,@sen)"
            cmd.Parameters.AddWithValue("nom", txtUsuario.Text.Trim)
            cmd.Parameters.AddWithValue("sen", Util.GetHash(txtSenha1.Text.Trim))

            reg = cmd.ExecuteNonQuery()

            t.Commit()

            MessageBox.Show(reg.ToString + " registro de usuário incluído no sistema")

        Catch ex As SqlClient.SqlException
            MessageBox.Show("Erro ao efetuar conexão." + vbCrLf + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cn.Close()
            cn.Dispose()
        End Try

    End Sub

    Private Sub Acesso_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub Acesso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class