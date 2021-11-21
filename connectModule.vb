Imports System.Data.OleDb
Module connectModule
    Public con As New OleDbConnection
    Public query As New OleDbCommand
    Public adapter As New OleDb.OleDbDataAdapter(query)
    Public dt As New DataTable
    Public myReader As OleDbDataReader

    Sub OpenCon()
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\karll\source\repos\PRC2-Midterms\bin\Debug\orderingSystemDb.mdb;"
        con.Open()
    End Sub

End Module
