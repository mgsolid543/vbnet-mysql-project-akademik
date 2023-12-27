Imports MySql.Data.MySqlClient
Namespace AksesData
    Public Class KoneksiDB
        Dim conn As New MySqlConnection("server=localhost;userid=root;database=dbakademik;pooling=false;ConnectionTimeOut=5")
        Public Function open() As MySqlConnection
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If
            Return conn
        End Function
        Public Function close() As MySqlConnection
            conn.Close()
            Return conn
        End Function
    End Class
End Namespace
