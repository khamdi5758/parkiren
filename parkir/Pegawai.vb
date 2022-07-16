Imports System.IO
Imports System.Collections
Imports MySql.Data.MySqlClient

Public Class Pegawai
    Private PathFile As String
    Dim sourcepath As String
    Dim DestPath As String
    Dim hapusfile As String

    Private Shared Sub CopyDirectory(ByVal sourcePath As String, ByVal destPath As String)
        If System.IO.File.Exists(sourcePath) = True Then

            System.IO.File.Copy(sourcePath, destPath)
            'msgBox("File Copied")

        End If
    End Sub

    Sub copyfoto()
        sourcepath = PathFile
        DestPath = Application.StartupPath + "\gambar\" + System.IO.Path.GetFileName(OpenFileDialog1.FileName)
        File.Copy(sourcepath, DestPath)
    End Sub

    Sub tampilpegawai()
        Call konek()
        Da = New MySqlDataAdapter("SELECT * FROM pegawai ", Con)
        Ds = New DataSet
        Da.Fill(Ds, "pegawai")
        viewpegawai.DataSource = Ds.Tables("pegawai")
        viewpegawai.ReadOnly = True
    End Sub

    Sub pilihjabatan()
        jabatan.Items.Add("Petugas Pos")
        jabatan.Items.Add("Admin")
    End Sub

    Sub jenkel()
        jenkelam.Items.Add("Laki-laki")
        jenkelam.Items.Add("Perempuan")
    End Sub

    Sub polos()
        txtidpeg.Text = ""
        txtnampeg.Text = ""
        jenkelam.Text = ""
        txtttlpeg.Text = ""
        txtuserpeg.Text = ""
        txtpaspeg.Text = ""
        jabatan.Text = ""
        txtcaripeg.Text = ""
        pilih.Text = "....."

    End Sub

    Private Sub Pegawai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilpegawai()
        pilihjabatan()
        jenkel()
        polos()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Call konek()
        Dim edit As String = "UPDATE pegawai SET idpegawai= '" & txtidpeg.Text & "',namapegawai='" & txtnampeg.Text & "',username='" & txtuserpeg.Text & "' ,password='" & txtpaspeg.Text & "' ,jabatan='" & jabatan.Text & "' WHERE id-pegawai='" & txtidpeg.Text & "'"
        Cmd = New MySqlCommand(edit, Con)
        Cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil diUpdate")
        Call tampilpegawai()
        Call polos()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Call caripegawai()
        If txtidpeg.Text = "" Then
            MsgBox("Silahkan Pilih Data yang akan di hapus dengan Masukan idpegawai dan ENTER")
        Else
            File.Delete(hapusfile)
            If jabatan.Text = "Admin" Then
                Call konek()
                Try
                    Using Cmd
                        Cmd = New MySqlCommand
                        Cmd.CommandText = "delete_pegawaiadmin"
                        Cmd.CommandType = CommandType.StoredProcedure
                        Cmd.Connection = Con
                        With Cmd
                            .Parameters.Clear()
                            .Parameters.AddWithValue("idpegawai", txtidpeg.Text)
                            .ExecuteNonQuery()
                        End With
                    End Using
                    MessageBox.Show("Data sudah dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                Call konek()
                Try
                    Using Cmd
                        Cmd = New MySqlCommand
                        Cmd.CommandText = "delete_pegawaijagapos"
                        Cmd.CommandType = CommandType.StoredProcedure
                        Cmd.Connection = Con
                        With Cmd
                            .Parameters.Clear()
                            .Parameters.AddWithValue("idpegawai", txtidpeg.Text)
                            .ExecuteNonQuery()
                        End With
                    End Using
                    MessageBox.Show("Data sudah dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

        End If
        Call polos()
        Call tampilpegawai()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles pilih.Click
        On Error Resume Next
        OpenFileDialog1.Filter = "JPG Files(*.jpg)|*.jpg|
                                  JPEG Files(*.jpeg)|*.jpeg|
                                  PNG Files(*.png)|*.png|"
        OpenFileDialog1.FileName = ""

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            'PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            'PictureBox1.Image = New Bitmap(OpenFileDialog1.FileName)
            pilih.Enabled = True
            PathFile = OpenFileDialog1.FileName
            pilih.Text = PathFile.Substring(PathFile.LastIndexOf("\") + 1)
            'PictureBox1.Image = Image.FromFile(TextBox2.Text)
        End If
    End Sub


    Private Sub btninput_Click(sender As Object, e As EventArgs) Handles btninput.Click
        copyfoto()
        If jabatan.Text = "Admin" Then

            Call konek()
            Try
                Using Cmd
                    Cmd = New MySqlCommand
                    Cmd.CommandText = "input_pegawaiadmin"
                    Cmd.CommandType = CommandType.StoredProcedure
                    Cmd.Connection = Con

                    With Cmd
                        .Parameters.Clear()
                        .Parameters.AddWithValue("idpegawai", txtidpeg.Text)
                        .Parameters.AddWithValue("namapegawai", txtnampeg.Text)
                        .Parameters.AddWithValue("jenkel", jenkelam.Text)
                        .Parameters.AddWithValue("ttl", txtttlpeg.Text)
                        .Parameters.AddWithValue("jabatan", jabatan.Text)
                        .Parameters.AddWithValue("foto", DestPath)
                        .Parameters.AddWithValue("username", txtuserpeg.Text)
                        .Parameters.AddWithValue("password", computeHash(txtpaspeg.Text))

                        .ExecuteNonQuery()
                    End With
                End Using
                MessageBox.Show("Data sudah disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Call konek()
            Try
                Using Cmd
                    Cmd = New MySqlCommand
                    Cmd.CommandText = "input_pegawaijagapos"
                    Cmd.CommandType = CommandType.StoredProcedure
                    Cmd.Connection = Con

                    With Cmd
                        .Parameters.Clear()
                        .Parameters.AddWithValue("idpegawai", txtidpeg.Text)
                        .Parameters.AddWithValue("namapegawai", txtnampeg.Text)
                        .Parameters.AddWithValue("jenkel", jenkelam.Text)
                        .Parameters.AddWithValue("ttl", txtttlpeg.Text)
                        .Parameters.AddWithValue("jabatan", jabatan.Text)
                        .Parameters.AddWithValue("foto", DestPath)
                        .Parameters.AddWithValue("username", txtuserpeg.Text)
                        .Parameters.AddWithValue("password", computeHash(txtpaspeg.Text))

                        .ExecuteNonQuery()
                    End With
                End Using
                MessageBox.Show("Data sudah disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        Call polos()
        Call tampilpegawai()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub viewpegawai_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles viewpegawai.CellContentClick

        Dim i As Integer
        i = viewpegawai.SelectedCells(0).RowIndex
        txtidpeg.Text = viewpegawai.Rows(i).Cells(0).Value.ToString()
        txtnampeg.Text = viewpegawai.Rows(i).Cells(1).Value.ToString()
        jenkelam.Text = viewpegawai.Rows(i).Cells(2).Value.ToString()
        txtttlpeg.Text = viewpegawai.Rows(i).Cells(3).Value.ToString()
        jabatan.Text = viewpegawai.Rows(i).Cells(4).Value.ToString()

    End Sub

    Sub caripegawai()
        Call konek()
        Cmd = New MySqlCommand("SELECT * FROM pegawai where id_pegawai='" & txtidpeg.Text & "'", Con)
        Dr = Cmd.ExecuteReader
        Dr.Read()
        hapusfile = Dr.Item("foto")
    End Sub

    Private Sub txtcaripeg_TextChanged(sender As Object, e As EventArgs) Handles txtcaripeg.TextChanged
        caripegawai()

    End Sub
End Class