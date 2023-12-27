Imports MySql.Data.MySqlClient
Namespace AksesData
    Public Class DataControl
        Private myconnection As New AksesData.KoneksiDB
        Public Function GetDataSet(ByVal SQL As String) As DataSet
            Dim adapter As New MySqlDataAdapter(SQL, myconnection.open)
            Dim mydata As New DataSet
            adapter.Fill(mydata, "Data")
            Return mydata
        End Function
    End Class
End Namespace

