Imports MySql.Data.MySqlClient

Module koneksi
    Public Con As New MySqlConnection
    Public Cmd As New MySqlCommand
    Public Da As New MySqlDataAdapter
    Public Cb As New MySqlCommandBuilder
    Public Dr As MySqlDataReader
    Public Dt As New DataTable
    Public Ds As New DataSet
    Dim kondab As String

    Sub konek()
        kondab = "server=localhost; uid=root; password=; Database=db_parkir;"
        Con = New MySqlConnection(kondab)
        If Con.State = ConnectionState.Closed Then
            Con.Open()
        End If
    End Sub

    Public Function computeHash(ByVal textToHash As String) As String
        '//dibawah ini adalah sebuah fungsi untuk mengenkripsi text dengan metode MD5
        Dim MD5 As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim Bytes() As Byte = MD5.ComputeHash(System.Text.Encoding.ASCII.GetBytes(textToHash))
        Dim s As String = Nothing
        For Each by As Byte In Bytes
            s += by.ToString("x2")
        Next
        Return s
    End Function


End Module