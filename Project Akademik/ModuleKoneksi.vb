Imports MySql.Data.MySqlClient

Module ModuleKoneksi
    Public Koneksi As MySqlConnection
    Public RD As MySqlDataReader
    Public strcon As String
    Public ds As New DataSet
    Public olecn As New MySqlConnection
    Public DA As New MySqlDataAdapter
    Public dataset As New MySqlCommand

    Dim muser As New MySqlCommand

    Public Sub bukaDB()
        Koneksi = New MySqlConnection
        Koneksi.ConnectionString = "server=localhost;userid=root;password=;database=dbakademik"
        Koneksi.Open()
    End Sub

    Public Sub StatusKoneksi()
        Koneksi.Close()
        Koneksi.Open()
    End Sub
End Module