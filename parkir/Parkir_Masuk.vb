Imports MySql.Data.MySqlClient
Public Class Parkir_Masuk

    Sub jeniskendaraan()
        txtjenken.Items.Add("Mobil")
        txtjenken.Items.Add("Sepeda Motor")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbltanggalmasuk.Text = Format(Now, "yyyy-MM-dd")
        lblwaktumasuk.Text = Format(Now, "HH:mm:ss")
    End Sub

    Sub antom()
        Try
            Call konek()
            Cmd = New MySqlCommand("select * from parkir_masuk order by id_antrian desc", Con)
            Dim urutan As String
            Dim hitung As Long
            Dr = Cmd.ExecuteReader
            Dr.Read()

            If Not Dr.HasRows Then
                urutan = Format(Date.Now, "ddMMyy") + "001"
            Else
                hitung = Microsoft.VisualBasic.Right(Dr.GetString(0), 9) + 1
                urutan = Format(Date.Now, "ddMMyy") + Microsoft.VisualBasic.Right("000" & hitung, 3)
            End If
            txtantrimasuk.Text = urutan
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Sub tampilparkirin()
        Call konek()
        Da = New MySqlDataAdapter("SELECT * FROM parkir_masuk order by id_antrian desc", Con)
        Ds = New DataSet
        Da.Fill(Ds, "parkir_masuk")
        DataGridView1.DataSource = Ds.Tables("parkir_masuk")
        DataGridView1.ReadOnly = True

        'mengatur datagrid view
        DataGridView1.Columns(0).Width = 93
        DataGridView1.Columns(1).Width = 187


    End Sub

    Sub clear()
        'txtantrimasuk.Text = ""
        txtplat.Text = ""
        txtjenken.Text = ""
    End Sub


    Private Sub btninput_Click(sender As Object, e As EventArgs) Handles btninput.Click
        Call konek()
        Try

            Using Cmd
                Cmd = New MySqlCommand
                Cmd.CommandText = "input_parkirmasuk"
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.Connection = Con

                With Cmd
                    .Parameters.Clear()
                    .Parameters.AddWithValue("idantrian", txtantrimasuk.Text)
                    .Parameters.AddWithValue("noplat", txtplat.Text)
                    .Parameters.AddWithValue("jenker", txtjenken.Text)
                    .Parameters.AddWithValue("tanggalmasuk", lbltanggalmasuk.Text)
                    .Parameters.AddWithValue("waktumasuk", lblwaktumasuk.Text)
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Data sudah disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tampilparkirin()
                karcis_pmasuk.lblantrian.Text = txtantrimasuk.Text
                karcis_pmasuk.lblplat.Text = txtplat.Text
                karcis_pmasuk.lblgolker.Text = txtjenken.Text
                antom()
                clear()
                karcis_pmasuk.Show()
            End Using

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Btnreset_Click(sender As Object, e As EventArgs) Handles Btnreset.Click
        clear()
    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        tampilparkirin()
        clear()
    End Sub

    Private Sub Parkir_Masuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilparkirin()
        antom()
        jeniskendaraan()
        clear()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtjenken.Enabled = False
        Else
            txtjenken.Enabled = True
        End If

    End Sub

End Class