Imports MySql.Data.MySqlClient
Public Class prof_pegawai

    Sub profilpegawai()
        Call konek()
        Dim pegawai As String = ("SELECT * FROM pegawai WHERE id_pegawai = '" & nopeg.Text & "'")
        Cmd = New MySqlCommand(pegawai, Con)
        Dim Dr As MySqlDataReader
        Dr = Cmd.ExecuteReader
        Dr.Read()
        If Dr.HasRows Then
            nama.Text = Dr.Item("nama_pegawai")
            jenkel.Text = Dr.Item("jen_kel")
            ttl.Text = Dr.Item("TTL")
            jabatan.Text = Dr.Item("jabatan")
            'Dim fotopeg As Byte() = Dr.Item("foto")
            fotpegawai.Image = Image.FromFile(Dr.Item("foto"))
            fotpegawai.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub profpegawai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        profilpegawai()
    End Sub
End Class