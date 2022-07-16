Imports MySql.Data.MySqlClient
Public Class Parkir_Keluar
    Public hh, hj, hm, hd, lp As Double
    Public bp, dn, total As Integer
    Public wm, wk, ak As String

    Sub tabcontrol()
        For Each tc In {TabControl1}
            With tc
                .SuspendLayout()
                .SizeMode = TabSizeMode.Fixed
                .ItemSize = New Size(0, 1)
                .Appearance = TabAppearance.Buttons
                .ResumeLayout()
            End With
        Next
    End Sub

    Sub bersitrans()
        txtantrikeluar.Text = ""
        txtantrikelua.Text = ""
        txtnoplat.Text = ""
        txtjenker.Text = ""
        lblwaktumasuk2.Text = "-"
        lblwaktukeluar2.Text = "-"
        lbltotal.Text = "-"
    End Sub

    Sub tampilparkirout()
        Call konek()
        Da = New MySqlDataAdapter("SELECT * from kendaraan ORDER BY id_antrian DESC", Con)
        Ds = New DataSet
        Da.Fill(Ds, "kendaraan")
        DataGridView1.DataSource = Ds.Tables("kendaraan")
        DataGridView1.ReadOnly = True

        'mengatur datagrid view
        ' mengatur lebar
        DataGridView1.Columns(0).Width = 265%
        DataGridView1.Columns(1).Width = 264%
        DataGridView1.Columns(2).Width = 264%
    End Sub

    Sub tampilpoutbayar()
        Call konek()
        Cmd = New MySqlCommand("SELECT kendaraan.id_antrian, kendaraan.no_plat, kendaraan.jenis_kendaraan, parkir_masuk.tanggal_masuk, parkir_masuk.waktu_masuk, parkir_keluar.tanggal_keluar, parkir_keluar.waktu_keluar FROM kendaraan INNER join parkir_masuk INNER JOIN parkir_keluar on kendaraan.id_antrian = parkir_masuk.id_antrian AND kendaraan.id_antrian=parkir_keluar.id_antrian WHERE parkir_keluar.id_antrian = '" & txtantrikeluar.Text & "'", Con)
        Dr = Cmd.ExecuteReader
        Dr.Read()
        If Not Dr.HasRows Then
            MsgBox("no antrian tidak Ada, Silahkan coba lagi!")
            txtantrikeluar.Focus()
        Else
            txtantrikelua.Text = Dr.Item("id_antrian")
            txtnoplat.Text = Dr.Item("no_plat")
            txtjenker.Text = Dr.Item("jenis_kendaraan")
            lblwaktumasuk2.Text = Dr.Item("tanggal_masuk") + Dr.Item("waktu_masuk")
            lblwaktukeluar2.Text = Dr.Item("tanggal_keluar") + Dr.Item("waktu_keluar")
            txtantrikeluar.Focus()
        End If
        lamaparkir()
        biayaparkir()
    End Sub

    Sub lamaparkir()
        Dim waktuawal As DateTime = DateTime.Parse(lblwaktumasuk2.Text)
        Dim waktuakhir As DateTime = DateTime.Parse(lblwaktukeluar2.Text)

        hh = (waktuakhir - waktuawal).Days
        hj = (waktuakhir - waktuawal).Hours
        hm = (waktuakhir - waktuawal).Minutes
        hd = (waktuakhir - waktuawal).Seconds

        lp = (hh * 86400) + (hj * 3600) + (hm * 60) + hd
        'wk = (hh * 24) + (hj)
        wk = hh
        'lbllamaparkir.Text = lp

    End Sub

    Sub biayaparkir()
        lamaparkir()
        Dim tn, tv As Integer
        Call konek()
        Cmd = New MySqlCommand("SELECT tarif_normal, tarif_variabel FROM tarif_kendar WHERE jenis_kendaraan = '" & txtjenker.Text & "'", Con)
        Dr = Cmd.ExecuteReader
        Dr.Read()

        tn = Dr.Item("tarif_normal")
        tv = Dr.Item("tarif_variabel")

        If lp <= 10800 Then
            bp = tn
        Else
            If lp >= 10800 Then
                bp = tn + (hj * tv)
                If lp >= 86400 Then
                    bp = tn + (hd * tv)
                End If
            End If

        End If

        lbltotal.Text = bp
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.SelectedCells(0).RowIndex
        txtantrikeluar.Text = DataGridView1.Rows(i).Cells(2).Value.ToString()
        carikendar.Text = DataGridView1.Rows(i).Cells(2).Value.ToString()
    End Sub

    Private Sub PKeluar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tabcontrol()
        tampilparkirout()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbltanggalkeluar.Text = Format(Now, "yyyy-MM-dd")
        lblwaktukeluar.Text = Format(Now, "HH:mm:ss")
    End Sub


    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        TabControl1.SelectedTab = TabPage2
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Call konek()
        'Dim simpantp As String = "INSERT INTO transaksi_parkir(id_antrian, no_plat, jenis_kendaraan, masuk_pada, keluar_pada, Total_tarif) VALUES ('" & txtantrikeluar.Text & "','" & txtnoplat.Text & "','" & txtjenker.Text & "','" & DateTime.Parse(lblwaktumasuk2.Text) & "','" & DateTime.Parse(lblwaktukeluar2.Text) & "','" & lbltotal.Text & "')"
        'Cmd = New MySqlCommand(simpantp, Con)
        'Cmd.ExecuteNonQuery()
        MsgBox("lama parkir anda : " + wk)

        karcis_pkeluar.lblantrian.Text = txtantrikeluar.Text
        karcis_pkeluar.lblplat.Text = txtnoplat.Text
        karcis_pkeluar.lblgolker.Text = txtjenker.Text
        karcis_pkeluar.waktumasuk.Text = lblwaktumasuk2.Text
        karcis_pkeluar.waktukeluar.Text = lblwaktukeluar2.Text
        karcis_pkeluar.lbltotal.Text = lbltotal.Text
        karcis_pkeluar.Show()
        bersitrans()


    End Sub

    Private Sub btninput_Click(sender As Object, e As EventArgs) Handles btninput.Click
        Call konek()
        Dim simpanpout As String = "INSERT INTO `parkir_keluar`(`id_antrian`, `tanggal_keluar`,`waktu_keluar`) VALUES ('" & txtantrikeluar.Text & "','" & lbltanggalkeluar.Text & "','" & lblwaktukeluar.Text & "')"
        Cmd = New MySqlCommand(simpanpout, Con)
        Cmd.ExecuteNonQuery()
        MsgBox("Input data berhasil")
        TabControl1.SelectedTab = TabPage3
        Call tampilpoutbayar()
    End Sub

    Private Sub karcishilang_CheckedChanged(sender As Object, e As EventArgs) Handles karcishilang.CheckedChanged
        If karcishilang.Checked = True Then
            dn = 10000
            total = bp + dn
        Else
            total = bp
        End If

        lbltotal.Text = total
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub carikendar_TextChanged(sender As Object, e As EventArgs) Handles carikendar.TextChanged
        Call konek()
        Cmd = New MySqlCommand("SELECT * from kendaraan where id_antrian LIKE '%" & carikendar.Text & "%' or no_plat LIKE '%" & carikendar.Text & "%' ", Con)
        Da = New MySqlDataAdapter(Cmd)
        Ds = New DataSet
        Da.Fill(Ds, "kendaraan")
        Dr = Cmd.ExecuteReader
        Dr.Read()

        'txtantrikeluar.Text = Dr.Item("id_antrian")

        DataGridView1.DataSource = Ds
        DataGridView1.DataMember = "kendaraan"


        'mengatur datagrid view
        ' mengatur lebar
        DataGridView1.Columns(0).Width = 265%
        DataGridView1.Columns(1).Width = 264%
        DataGridView1.Columns(2).Width = 264%


    End Sub

    Private Sub carikendar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles carikendar.KeyDown
        Call carikendar_TextChanged(sender, e)
        If e.KeyCode = Keys.Enter Then
            txtantrikeluar.Text = Dr.Item("id_antrian")
            Call btnnext_Click(sender, e)
        End If
    End Sub

    Private Sub Parkir_Keluar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If Me.carikendar.Focused = False Then
            carikendar.Focus()
            carikendar.Text = e.KeyChar.ToString
            carikendar.SelectionStart = carikendar.Text.Length
            e.Handled = True
        End If
    End Sub

End Class