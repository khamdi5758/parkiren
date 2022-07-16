Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Windows.Forms
Public Class laporan_pkeluar

    Sub munculcombo()
        ComboBox1.Items.Add("...")
        ComboBox1.Items.Add("Mobil")
        ComboBox1.Items.Add("Sepeda Motor")
    End Sub

    Private Sub laporan_pkeluar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        munculcombo()
    End Sub

    Private Sub viewharian_Click(sender As Object, e As EventArgs) Handles viewharian.Click
        Dim cryRpt As New ReportDocument
        cryRpt.Load("D:\Project\Dekstop\parkiren\parkir\p_keluar-harian.rpt")
        crv.SelectionFormula = "{parkir_keluar.tanggal_keluar}=#” & CDate(Format(DateTimePicker1.Value, “yyyy/MM/dd”)) & “#"
        crv.ReportSource = cryRpt
        crv.RefreshReport()
    End Sub

    Private Sub viewbulanan_Click(sender As Object, e As EventArgs) Handles viewbulanan.Click
        Dim cryRpt As New ReportDocument
        cryRpt.Load("D:\Project\Dekstop\parkiren\parkir\p_keluar-bulanan.rpt")
        crv.SelectionFormula = "month({parkir_keluar.tanggal_keluar})=(" & Month(DateTimePicker2.Text) & ") and year({parkir_keluar.tanggal_keluar})=(" & Year(DateTimePicker2.Text) & ")"
        crv.ReportSource = cryRpt
        crv.RefreshReport()
    End Sub

    Private Sub viewperiode_Click(sender As Object, e As EventArgs) Handles viewperiode.Click
        Dim cryRpt As New ReportDocument
        cryRpt.Load("D:\Project\Dekstop\parkiren\parkir\p_keluar-periode.rpt")
        crv.SelectionFormula = "{parkir_keluar.tanggal_keluar}>=#” & CDate(Format(DateTimePicker3.Value, “yyyy/MM/dd”)) & “# and {parkir_keluar.tanggal_keluar}<=#” & CDate(Format(DateTimePicker4.Value, “yyyy/MM/dd”)) & “#"
        crv.ReportSource = cryRpt
        crv.RefreshReport()
    End Sub

    Private Sub viewjenken_Click(sender As Object, e As EventArgs) Handles viewjenken.Click
        Dim cryRpt As New ReportDocument
        cryRpt.Load("D:\Project\Dekstop\parkiren\parkir\p_keluar.rpt")
        crv.SelectionFormula = "{kendaraan.jenis_kendaraan} = '" & ComboBox1.Text & "'  "
        crv.ReportSource = cryRpt
        crv.RefreshReport()
    End Sub
End Class