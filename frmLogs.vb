Public Class frmLogs

    'LOAD TABLE FUNCTION
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

    'Search ID FUNCTION
    Private Sub RefreshTables(Optional ByVal q As String = "")
        Try
            OpenCon()
            query.Connection = con
            query.CommandText = "SELECT * FROM tblOrders WHERE ID = " & txtSearch.Text & ""
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

    'SEARCH CUSTOMER NAME FUNCTION
    Private Sub searchName(Optional ByVal q As String = "")
        Try
            OpenCon()
            query.Connection = con
            query.CommandText = "SELECT * FROM tblLogs WHERE Customer_Name = '" & txtSearch.Text & "'"
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

    'SEARCH ORDER DATE FUNCTIONS
    Private Sub searchDate(Optional ByVal q As String = "")
        Try
            OpenCon()
            query.Connection = con
            query.CommandText = "SELECT * FROM tblLogs WHERE Order_Date = '" & txtSearch.Text & "'"
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

    'BUTTON FIND
    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Try
            If txtSearch.Text = "" Then
                MessageBox.Show("Please input value on Search Field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Integer.TryParse(txtSearch.Text, vbNull) Then
                Call RefreshTables()
            ElseIf txtSearch.Text.IndexOf("/") = -1 And txtSearch.Text.IndexOf(".") = -1 Then
                Call searchName()
            ElseIf txtSearch.Text.IndexOf("/") Then
                Call searchDate()
                ' ElseIf txtSearch.Text.IndexOf(".") Then
                '   Call searchRef()
            End If
            txtSearch.Clear()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        con.Close()
    End Sub

    'BUTTON LOAD
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Call LoadTables()
    End Sub

    'BUTTON BACK
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        frmMain.Show()
    End Sub

End Class