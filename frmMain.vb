Imports System.Data.OleDb
Public Class frmMain

    'CASHIER ID FUNCTION
    Private Sub cashierID(Optional ByVal q As String = "")
        If con.State = ConnectionState.Closed Then
            OpenCon()
        End If
        Try
            Dim strsql As String
            strsql = "SELECT * FROM tblUsers WHERE Username = '" & frmLogin.txtUsername.Text & "'"
            Dim cmd As New OleDbCommand(strsql, con)
            Dim myReader As OleDbDataReader
            myReader = cmd.ExecuteReader
            myReader.Read()
            txtCashierID.Text = myReader("ID")
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        con.Close()
    End Sub

    'FULLNAME OF CASHIER FUNCTION
    Private Sub cashierName(Optional ByVal q As String = "")
        If con.State = ConnectionState.Closed Then
            OpenCon()
        End If
        Try
            Dim strsql As String
            strsql = "SELECT * FROM tblUsers WHERE Username = '" & frmLogin.txtUsername.Text & "'"
            Dim cmd As New OleDbCommand(strsql, con)
            Dim myReader As OleDbDataReader
            myReader = cmd.ExecuteReader
            myReader.Read()
            lblUsername.Text = myReader("Fullname")
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        con.Close()
    End Sub

    'LOADER OF CASHIER ID AND CASHIER FULLNAME
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call cashierName()
        Call cashierID()
    End Sub

    'BUTTON CUSTOMER
    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        Me.Hide()
        frmCustomer.Show()
    End Sub

    'BUTTON ORDER
    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        Me.Hide()
        frmOrder.Show()
    End Sub

    'BUTTON LOGS
    Private Sub btnLogs_Click(sender As Object, e As EventArgs) Handles btnLogs.Click
        Me.Hide()
        frmLogs.Show()
    End Sub

    'BUTTON LOGOUT
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        frmLogin.txtUsername.Clear()
        frmLogin.txtPassword.Clear()
        Me.Hide()
        Me.Close()
        frmDashboard.Show()
    End Sub

End Class