Public Class Login

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim cn As New SqlClient.SqlConnection
        Dim cmd As New SqlClient.SqlCommand
        Dim SenhaId As String

        Principal.Show()
        Hide()
        Exit Sub

        cn.ConnectionString = My.Settings.LocadoraConnectionString
        Try
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "select senhaid from usuarios where nomeusuario = @nomeusuario"
            cmd.Parameters.AddWithValue("nomeusuario", UsernameTextBox.Text)

            SenhaId = cmd.ExecuteScalar

            If SenhaId = Nothing Then
                Acesso.Text = "Sistema sem administrador: Cadastrar administrador"
                If Acesso.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
                    Exit Sub
                End If
            End If

            If ckGravar.Checked Then
                'My.Settings.usuario = UsernameTextBox.Text
                'My.Settings.Save()
            Else
                'My.Settings.usuario = ""
            End If

            If Util.GetHash(PasswordTextBox.Text).Equals(SenhaId) Then
                Principal.Show()
                Hide()
            Else
                MessageBox.Show("Senha e/ou usuário incorreto.", "Login inválido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                PasswordTextBox.Focus()
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao efetuar conexão." + vbCrLf + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cn.State = ConnectionState.Closed Then
                cn.Close()
            End If
            cn.Dispose()
        End Try
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Login_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Dim cn As New SqlClient.SqlConnection
        Dim cmd As New SqlClient.SqlCommand
        Dim SenhaId As String

        Exit Sub

        cn.ConnectionString = My.Settings.LocadoraConnectionString
        Try
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "select senhaid from usuarios"

            SenhaId = cmd.ExecuteScalar

            If SenhaId = Nothing Then
                Acesso.Text = "Sistema sem administrador: Cadastrar administrador"
                If Acesso.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
                    Me.Close()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao efetuar conexão." + vbCrLf + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cn.State = ConnectionState.Closed Then
                cn.Close()
            End If
            cn.Dispose()
        End Try
        Me.Close()
    End Sub
End Class
