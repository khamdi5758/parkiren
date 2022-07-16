Public Class Home

    Public idpegawai As String

    Private Sub OperatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OperatorToolStripMenuItem.Click
        Pegawai.MdiParent = Me
        Pegawai.Show()
    End Sub

    Private Sub TarifParkirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TarifParkirToolStripMenuItem.Click
        Tarif_parkir.MdiParent = Me
        Tarif_parkir.Show()
    End Sub

    Private Sub ParkirMasukToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ParkirMasukToolStripMenuItem2.Click
        Parkir_Masuk.MdiParent = Me
        Parkir_Masuk.Show()
    End Sub

    Private Sub ParkirKeluarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ParkirKeluarToolStripMenuItem1.Click
        Parkir_Keluar.MdiParent = Me
        Parkir_Keluar.Show()
    End Sub

    Private Sub ProfilAndaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfilAndaToolStripMenuItem.Click
        prof_pegawai.MdiParent = Me
        prof_pegawai.Show()
    End Sub

    Private Sub ProfilInstansiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfilInstansiToolStripMenuItem.Click
        prof_peru.MdiParent = Me
        prof_peru.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem1.Click
        Me.Close()
        signin.Show()

    End Sub

    Private Sub ParkirMasukToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ParkirMasukToolStripMenuItem1.Click
        laporan_pmasuk.Show()
    End Sub

    Private Sub ParkirKeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParkirKeluarToolStripMenuItem.Click
        laporan_pkeluar.Show()
    End Sub
End Class
