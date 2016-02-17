Imports System.Data.SqlClient
Public Class localDBconnection
    Private con As SqlConnection

    Public Function getData(sqlString As String) As DataTable
        Dim adp1 As New System.Data.SqlClient.SqlDataAdapter(sqlString, con)
        Dim dt1 As New System.Data.DataTable
        'On Error Resume Next
        adp1.Fill(dt1)
        adp1.Dispose()
        Return dt1
    End Function

    Public Sub updateData(sqlString As String)
        Dim UpdtCommand As New SqlCommand(sqlString, con)
        UpdtCommand.ExecuteNonQuery()
        UpdtCommand.Dispose()
    End Sub

    Public Sub TerminateLocalDBConnection()
        con.Close()
        con.Dispose()
    End Sub
    Public Sub New()
        Dim conn As New SqlConnection
        conn.ConnectionString = ConfigurationManager.ConnectionStrings("dimoskopisiDBServices").ConnectionString
        conn.Open()
        con = conn
    End Sub
    Public Function returnIDAfterInsert(sqlStr As String) As String
        Dim command As SqlCommand = con.CreateCommand()
        command.Connection = con
        command.CommandText = sqlStr & vbCrLf & "SELECT SCOPE_IDENTITY() As TheId"
        Dim tId As Integer = CInt(command.ExecuteScalar)
        Return tId
    End Function
End Class
