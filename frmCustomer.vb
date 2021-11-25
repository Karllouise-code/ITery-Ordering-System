
Imports System.Data.OleDb
Public Class frmCustomer

    'LOADER FUNCTION
    Private Sub LoadTables(Optional ByVal q As String = "")
        Try
            If con.State = ConnectionState.Closed Then
                OpenCon()
            End If
            query.Connection = con
            query.CommandText = "SELECT * FROM tblOrders"
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

    'SEARCH CUSTOMER ID FUNCTION
    Private Sub RefreshTables(Optional ByVal q As String = "")
        Try
            OpenCon()
            query.Connection = con
            query.CommandText = "SELECT * FROM tblOrders WHERE Customer_ID = " & txtSearch.Text & ""
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

    'SEARCH REFERENCE NUMBER FUNCTION
    Private Sub searchRef(Optional ByVal q As String = "")
        Try
            OpenCon()
            query.Connection = con
            query.CommandText = "SELECT * FROM tblOrders WHERE Order_Ref_No = '" & txtSearch.Text & "'"
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
            query.CommandText = "SELECT * FROM tblOrders WHERE Customer_Name = '" & txtSearch.Text & "'"
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
            query.CommandText = "SELECT * FROM tblOrders WHERE Order_Date = '" & txtSearch.Text & "'"
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

    'LOADER
    Private Sub frmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtOrderdate.Text = Today
        txtOrdertime.Text = TimeOfDay
        Call LoadTables()
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

    'BUTTON INSERT
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        If con.State = ConnectionState.Closed Then
            OpenCon()
        End If
        If txtCustomername.Text = "" Or txtCustomerphone.Text = "" Or txtOrderdate.Text = "" Or txtOrdertime.Text = "" Then
            MessageBox.Show("Please input empty fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtSearch.Text <> Nothing Then
            MessageBox.Show("Search Field has Value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                txtOrderdate.Text = Today
                txtOrdertime.Text = TimeOfDay
                query.Connection = con
                query.CommandText = "INSERT INTO tblOrders(Customer_Name, Customer_Phone, Order_Date, Order_Time) VALUES('" & txtCustomername.Text & "', '" & txtCustomerphone.Text & "', '" & txtOrderdate.Text & "', '" & txtOrdertime.Text & "')"
                query.ExecuteNonQuery()
                MessageBox.Show("Successfully Inserted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtCustomername.Clear()
                txtCustomerphone.Clear()
                txtOrderdate.Clear()
                txtOrdertime.Clear()
                con.Close()
                Call LoadTables()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
            con.Close()
            Call LoadTables()
        End If
    End Sub

    'BUTTON UPDATE
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If con.State = ConnectionState.Closed Then
            OpenCon()
        End If

        Try
            If txtSearch.Text = "" Or txtCustomername.Text = "" Or txtCustomerphone.Text = "" Or txtOrderdate.Text = "" Or txtOrdertime.Text = "" Then
                MessageBox.Show("Please input empty fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                'CHECK IF CUSTOMERID IS EXIST ON DATABASE
                Using cmd As New OleDbCommand("SELECT COUNT(*) FROM tblOrders WHERE [Customer_ID] = @Customer_ID", con)
                    cmd.Parameters.AddWithValue("@Customer_ID", OleDbType.VarChar).Value = txtSearch.Text.Trim
                    Dim count = Convert.ToInt32(cmd.ExecuteScalar())
                    If count > 0 Then
                        query.Connection = con
                        query.CommandText = "UPDATE tblOrders SET Customer_Name = '" & txtCustomername.Text & "', Customer_Phone = '" & txtCustomerphone.Text & "', Order_Date = '" & txtOrderdate.Text & "', Order_Time = '" & txtOrdertime.Text & "' WHERE Customer_ID = " & txtSearch.Text & ""
                        query.ExecuteNonQuery()
                        MessageBox.Show("Update Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtSearch.Clear()
                        txtCustomername.Clear()
                        txtCustomerphone.Clear()
                        txtOrderdate.Clear()
                        txtOrdertime.Clear()
                        con.Close()
                        Call LoadTables()
                        Exit Sub
                    Else
                        MessageBox.Show("Customer ID is not Registered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        con.Close()
        Call LoadTables()
    End Sub

    'BUTTON DELETE
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If con.State = ConnectionState.Closed Then
            OpenCon()
        End If

        If txtSearch.Text = "" Then
            MessageBox.Show("Please input a Customer ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                ''CHECK IF CUSTOMERID IS EXIST ON DATABASE
                Using cmd As New OleDbCommand("SELECT COUNT(*) FROM tblOrders WHERE [Customer_ID] = @Customer_ID", con)
                    cmd.Parameters.AddWithValue("@Customer_ID", OleDbType.VarChar).Value = txtSearch.Text.Trim
                    Dim count = Convert.ToInt32(cmd.ExecuteScalar())
                    If count > 0 Then
                        query.Connection = con
                        query.CommandText = "DELETE * FROM tblOrders WHERE Customer_ID = " & txtSearch.Text & ""
                        query.ExecuteNonQuery()
                        MessageBox.Show("Record Deleted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtSearch.Clear()
                        con.Close()
                        Call LoadTables()
                        Exit Sub
                    Else
                        MessageBox.Show("Customer ID is not Registered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
            con.Close()
            Call LoadTables()
        End If
    End Sub

    'BUTTON SEARCH
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
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

    'TEXT CHANGE ORDER DATE/TIME WHEN TYPING ON TXTCUSTOMER NAME
    Private Sub txtCustomername_TextChanged(sender As Object, e As EventArgs) Handles txtCustomername.TextChanged
        txtOrderdate.Text = Today
        txtOrdertime.Text = TimeOfDay
    End Sub

    'TEXT CHANGE ORDER DATE/TIME WHEN TYPING ON TXTCUSTOMER NAME
    Private Sub txtCustomerphone_TextChanged(sender As Object, e As EventArgs) Handles txtCustomerphone.TextChanged
        txtOrderdate.Text = Today
        txtOrdertime.Text = TimeOfDay
    End Sub

    'BUTTON ORDER INSTEAD
    Private Sub btnOrderIns_Click(sender As Object, e As EventArgs) Handles btnOrderIns.Click
        Me.Hide()
        frmOrder.Show()
    End Sub
End Class