Public Class frmLogs

    Private Sub LoadTables(Optional ByVal q As String = "")
        Try
            If con.State = ConnectionState.Closed Then
                OpenCon()
            End If
            query.Connection = con
            query.CommandText = "SELECT * FROM tblLogs"
            adapter.SelectCommand = query
            dt.Clear()
            adapter.Fill(dt)
            DataGridView1.DataSource = dt
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        con.Close()
    End Sub
    Private Sub frmLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadTables()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        frmMain.Show()
    End Sub
End Class