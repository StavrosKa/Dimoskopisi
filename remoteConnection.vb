Imports System.IO
Public Class remoteConnection
    Public NOSOKOMEIO As String = "VEN"
    Public Sub New(nosok As String)
        NOSOKOMEIO = nosok
    End Sub
    Public Function convertToDataTable(remoteDataString As String) As DataTable
        Dim tmpDataSet As New DataSet
        Dim strReader As New StringReader(remoteDataString)
        tmpDataSet.ReadXml(strReader, XmlReadMode.ReadSchema)
        Return tmpDataSet.Tables(0)
    End Function
    Public Function getData(sqlString As String) As String
        Return returnResults(sqlString, "results")
    End Function
    Public Function returnResults(sqlstring As String, tableName As String) As String
        Dim rmData As New WebReferenceOPSY.opsy
        Return rmData.getDataFromHospitalViaODBC(NOSOKOMEIO, sqlstring, tableName)
    End Function
End Class
