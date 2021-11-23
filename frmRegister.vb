Imports System.Data.OleDb

Public Class frmRegister

    'BUTTON REGISTER
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If con.State = ConnectionState.Closed Then
            OpenCon()
        End If

        If txtFullName.Text = "" Or txtUserName.Text = "" Or txtPassword.Text = "" Or txtConfirmPassword.Text = "" Then
            MessageBox.Show("Please Enter Empty Fields")
        Else
            'Validation on database if the account is already registerd
            Using cmd As New OleDbCommand("SELECT COUNT(*) FROM tblUsers WHERE [Username] = @Username", con)
                cmd.Parameters.AddWithValue("@Username", OleDbType.VarChar).Value = txtUserName.Text.Trim
                Dim count = Convert.ToInt32(cmd.ExecuteScalar())
                If count > 0 Then
                    MessageBox.Show("Whoops! Username has already taken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End Using

            'If Username is available
            Using create As New OleDbCommand("INSERT INTO tblUsers([Fullname], [Username], [Password]) VALUES(@Fullname, @Username, @Password)", con)
                If txtPassword.Text = txtConfirmPassword.Text Then
                    create.Parameters.AddWithValue("@Fullname", OleDbType.VarChar).Value = txtFullName.Text.Trim
                    create.Parameters.AddWithValue("@Username", OleDbType.VarChar).Value = txtUserName.Text.Trim
                    create.Parameters.AddWithValue("@Password", OleDbType.VarChar).Value = txtPassword.Text.Trim

                    If create.ExecuteNonQuery Then
                        MessageBox.Show("Account Created", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtFullName.Clear()
                        txtUserName.Clear()
                        txtPassword.Clear()
                        txtConfirmPassword.Clear()
                    End If
                Else
                    MessageBox.Show("Password Mismatch!")
                End If
            End Using
            con.Close()
        End If
    End Sub

    'BUTTON LOGIN INSTEAD
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Me.Hide()
        frmLogin.Show()
    End Sub

    'BUTTON CANCEL
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        frmDashboard.Show()
    End Sub

End Class
