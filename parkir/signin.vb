Imports MySql.Data.MySqlClient
Public Class signin
    Sub tampilprofperu()
        Call konek()
        Try
            Using Cmd As New MySqlCommand
                Cmd.Connection = Con
                Cmd.CommandType = CommandType.Text
                Cmd.CommandText = "SELECT logo FROM profperusahaan WHERE id_perusahaan = 1 "
                Dr = Cmd.ExecuteReader
                While Dr.Read
                    Dim photo As Byte() = Dr.Item("logo")
                    If photo.Length = 0 Then
                        PictureBox1.Image = Nothing
                    Else
                        PictureBox1.Image = Image.FromStream(New IO.MemoryStream(photo))
                    End If
                End While
            End Using
        Catch ex As Exception
        End Try
    End Sub

    Sub bersih()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub



    Private Sub btnloginppos_Click(sender As Object, e As EventArgs) Handles btnloginppos.Click
        Call konek()
        Cmd = New MySqlCommand("SELECT * FROM pegawai_jagapos WHERE username = '" & TextBox1.Text & "' AND password = '" & computeHash(TextBox2.Text) & "'", Con)
        Dr = Cmd.ExecuteReader
        Dr.Read()
        If Not Dr.HasRows Then
            MsgBox("login gagal")
            Exit Sub
        Else
            Me.Visible = False
            Home.Show()
            'memunculkan menu untuk petugas pos
            Home.LaporanToolStripMenuItem.Visible = False
            Home.LaporanToolStripMenuItem.Visible = False
            Home.MasterToolStripMenuItem.Visible = False
            'menampilkan profil pegawai
            Home.userToolStripMenuItem.Text = Dr.Item("username")
            prof_pegawai.nopeg.Text = Dr.Item("id_pegawai")

        End If
        Call bersih()
    End Sub

    Private Sub btnloginadmin_Click(sender As Object, e As EventArgs) Handles btnloginadmin.Click
        Call konek()
        Cmd = New MySqlCommand("SELECT * FROM pegawai_admin WHERE username = '" & TextBox3.Text & "' AND password = '" & computeHash(TextBox4.Text) & "'", Con)
        Dr = Cmd.ExecuteReader
        Dr.Read()
        If Not Dr.HasRows Then
            MsgBox("login gagal")
            Exit Sub
        Else
            Me.Visible = False
            Home.Show()
            Home.userToolStripMenuItem.Text = Dr.Item("username")
            prof_pegawai.nopeg.Text = Dr.Item("id_pegawai")

        End If

        Call bersih()
    End Sub

    Private Sub signin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bersih()
    End Sub
End Class