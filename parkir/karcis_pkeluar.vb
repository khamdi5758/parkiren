Imports MessagingToolkit.Barcode
Public Class karcis_pkeluar

    Private Sub karcis_pkeluar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        printparkirkeluar.Print()
        Me.Close()
    End Sub

    Sub munculbarcode()
        Dim generatorbarcode As New BarcodeEncoder
        barcode.Image = generatorbarcode.Encode(BarcodeFormat.Code39, lblantrian.Text)
    End Sub

    Private Sub karcis_pkeluar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        munculbarcode()
    End Sub
End Class