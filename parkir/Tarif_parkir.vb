Imports MySql.Data.MySqlClient
Public Class Tarif_parkir
    Sub tarifparkir()
        Call konek()
        Da = New MySqlDataAdapter("select * From tarif_kendar", Con)
        Dt = New DataTable
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "tarif_kendar")
        Dt = Ds.Tables("tarif_kendar")
        DataGridView1.DataSource = Dt
        Cb = New MySqlCommandBuilder(Da)
    End Sub

    Private Sub Tarif_parkir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tarifparkir()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Da.Update(Dt)
    End Sub
End Class