Imports MySql.Data.MySqlClient
Public Class cobalogin

    Sub munculcombo()
        ComboBox1.Items.Add("admin")
        ComboBox1.Items.Add("petugas pos")
    End Sub
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If ComboBox1.Text = "admin" Then
            Call konek()
            Cmd = New MySqlCommand("SELECT * FROM pegawai_admin WHERE username = '" & UsernameTextBox.Text & "' AND password = '" & computeHash(PasswordTextBox.Text) & "'", Con)
            Dr = Cmd.ExecuteReader
            Dr.Read()
            If Not Dr.HasRows Then
                MsgBox("user anda tidak terdaftar")
                Exit Sub
            Else
                Me.Visible = False
                Home.Show()
                Home.userToolStripMenuItem.Text = Dr.Item("username")
                prof_pegawai.nopeg.Text = Dr.Item("id_pegawai")

            End If
        Else
            Call konek()
            Cmd = New MySqlCommand("SELECT * FROM pegawai_jagapos WHERE username = '" & UsernameTextBox.Text & "' AND password = '" & computeHash(PasswordTextBox.Text) & "'", Con)
            Dr = Cmd.ExecuteReader
            Dr.Read()
            If Not Dr.HasRows Then
                MsgBox("user anda tidak terdaftar")
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
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        DateTimePicker1.CustomFormat = "MMMM yyyy"
        DateTimePicker1.ShowUpDown = True
    End Sub


    Private Sub cobalogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        munculcombo()

        If ComboBox1.Text = "admin" Then
            DateTimePicker1.CustomFormat = "MMMM yyyy"
            DateTimePicker1.ShowUpDown = True
        ElseIf ComboBox1.Text = "petugas pos" Then
            DateTimePicker1.CustomFormat = "dd MMMM yyyy"
            DateTimePicker1.ShowUpDown = False
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DateTimePicker1.CustomFormat = "dd MMMM yyyy"
        DateTimePicker1.ShowUpDown = False
    End Sub
End Class
