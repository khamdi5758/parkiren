Imports CrystalDecisions.CrystalReports.Engine

Public Class laporan_transaksi

    Sub jenisreport()
        reportvalue.Items.Add("harian")
        reportvalue.Items.Add("bulanan")

        ComboBox2.Items.Add("harian")
        ComboBox2.Items.Add("bulanan")

        ComboBox1.Items.Add("Mobil")
        ComboBox1.Items.Add("Sepeda Motor")
    End Sub

    Sub kondisi()

    End Sub

    Private Sub laporan_transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        jenisreport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If reportvalue.Text = "bulanan" Then
            Dim cryRpt As New ReportDocument
            cryRpt.Load("D:\Project\Dekstop\parkiren\parkir\laporan_transaksi-bulananmasuk.rpt")
            crv.SelectionFormula = "month({parkir_masuk.tanggal_masuk})=(" & Month(DateTimePicker1.Text) & ") and year({parkir_masuk.tanggal_masuk})=(" & Year(DateTimePicker1.Text) & ")"
            crv.ReportSource = cryRpt
            crv.RefreshReport()
        ElseIf reportvalue.Text = "harian" Then
            Dim cryRpt As New ReportDocument
            cryRpt.Load("D:\Project\Dekstop\parkiren\parkir\laporan_transaksi-harianmasuk.rpt")
            crv.SelectionFormula = "{parkir_masuk.tanggal_masuk}=#” & CDate(Format(DateTimePicker1.Value, “yyyy/MM/dd”)) & “#"
            crv.ReportSource = cryRpt
            crv.RefreshReport()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ComboBox2.Text = "bulanan" Then
            Dim cryRpt As New ReportDocument
            cryRpt.Load("D:\Project\Dekstop\parkiren\parkir\laporan_transaksi-bulanankeluar.rpt")
            crv.SelectionFormula = "month({parkir_keluar.tanggal_keluar})=(" & Month(DateTimePicker4.Text) & ") and year({parkir_keluar.tanggal_keluar})=(" & Year(DateTimePicker4.Text) & ")"
            crv.ReportSource = cryRpt
            crv.RefreshReport()
        ElseIf ComboBox2.Text = "harian" Then
            Dim cryRpt As New ReportDocument
            cryRpt.Load("D:\Project\Dekstop\parkiren\parkir\laporan_transaksi-hariankeluar.rpt")
            crv.SelectionFormula = "{parkir_keluar.tanggal_keluar}=#” & CDate(Format(DateTimePicker4.Value, “yyyy/MM/dd”)) & “#"
            crv.ReportSource = cryRpt
            crv.RefreshReport()
        End If
    End Sub

    Private Sub viewjenken_Click(sender As Object, e As EventArgs) Handles viewjenken.Click
        Dim cryRpt As New ReportDocument
        cryRpt.Load("D:\Project\Dekstop\parkiren\parkir\laporan_transaksi.rpt")
        crv.SelectionFormula = "{kendaraan.jenis_kendaraan} = '" & ComboBox1.Text & "'  "
        crv.ReportSource = cryRpt
        crv.RefreshReport()
    End Sub
End Class