﻿Imports System.Data.OleDb
Public Class frmLogin
    ' Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    query.Connection = con
    '   OpenCon()
    'End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        frmDashboard.Show()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If con.State = ConnectionState.Closed Then
            OpenCon()
        End If
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Please Enter Empty Fields")
        Else
            Using login As New OleDbCommand("SELECT COUNT(*) FROM tblUsers WHERE [Username] = @Username AND [Password] = @Password", con)
                login.Parameters.AddWithValue("@Username", OleDbType.VarChar).Value = txtUsername.Text.Trim
                login.Parameters.AddWithValue("@Password", OleDbType.VarChar).Value = txtPassword.Text.Trim

                Dim loginCount = Convert.ToInt32(login.ExecuteScalar())
                If loginCount > 0 Then
                    Me.Hide()
                    MessageBox.Show("Login Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmMain.Show()
                    Exit Sub
                Else
                    MessageBox.Show("Invalid Credentials :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtUsername.Clear()
                    txtPassword.Clear()
                End If
            End Using
            con.Close()
        End If
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Me.Hide()
        frmRegister.Show()
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub
End Class