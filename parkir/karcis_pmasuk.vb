Imports MySql.Data.MySqlClient
Imports MessagingToolkit.Barcode
Imports System.IO

Public Class karcis_pmasuk

    Sub karcispmasuk()
        Call konek()

        Try
            Using Cmd As New MySqlCommand
                Cmd.Connection = Con
                Cmd.CommandType = CommandType.Text
                Cmd.CommandText = "SELECT * FROM parkir_masuk WHERE id_antrian = '" & lblantrian.Text & "'"
                Dr = Cmd.ExecuteReader
                While Dr.Read
                    waktumasuk.Text = Dr.Item("waktu_masuk")
                End While
            End Using
        Catch ex As Exception
        End Try

    End Sub

    Sub munculbarcode()
        'lblantrian.Text = "984895"
        'lblplat.Text = "L8797JO"
        'lblgolker.Text = "Mobil"
        'waktumasuk.Text = "29012019/08:00"
        Dim generatorbarcode As New BarcodeEncoder
        barcode.Image = generatorbarcode.Encode(BarcodeFormat.Code39, lblantrian.Text)
    End Sub

    Private Sub karcis_pmasuk_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        printkarcismasuk.Print()
        Me.Close()
    End Sub

    Private Sub karcis_pmasuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        karcispmasuk()
        munculbarcode()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage


        Dim tinggi As Integer
        tinggi += 10
        e.Graphics.DrawImage(barcode.Image, 0, 0, barcode.Width, barcode.Height)
        e.Graphics.DrawString(lblantrian.Text, New Drawing.Font("Arial", 8), Brushes.Black, 4, tinggi)
        e.Graphics.DrawString(lblplat.Text, New Drawing.Font("Arial", 8), Brushes.Black, 4, tinggi)
        e.Graphics.DrawString(lblgolker.Text, New Drawing.Font("Arial", 8), Brushes.Black, 4, tinggi)
        e.Graphics.DrawString(waktumasuk.Text, New Drawing.Font("Arial", 8), Brushes.Black, 4, tinggi)



        'Dim linesPerPage As Single = 0
        'Dim yPos As Single = 0
        'Dim count As Integer = 0
        'Dim MarginKiri As Single = e.MarginBounds.Left
        'Dim MarginAtas As Single = e.MarginBounds.Top
        'Dim line As String = Nothing
        'Dim myfont As New Font("arial", 15, FontStyle.Regular)

        'Dim plat As String = ("no plat :" + lblplat.Text)

        'menentukan banyak baris per halaman
        'linesPerPage =
        'e.MarginBounds.Height / myfont.GetHeight(e.Graphics)

        'Dim sr As StringReader = New StringReader(Me.GroupBox1.TabIndex)
        'melakukan iterasi dan cetak tiap baris
        'line = sr.ReadLine

        'While count < linesPerPage
        'kalkulasi baris berikutnya
        'yPos = (MarginAtas + (count * myfont.GetHeight(e.Graphics)))
        'menetapkan halaman teks yang diprint
        'e.Graphics.DrawString(line, myfont, Brushes.Black, MarginKiri, yPos, New StringFormat)
        'count += 1
        'e.Graphics.DrawString(lblgolker.Text, myfont, Brushes.Black, MarginKiri, yPos, New StringFormat)
        'count += 1
        'e.Graphics.DrawString(lblplat.Text, myfont, Brushes.Black, MarginKiri, yPos, New StringFormat)
        'count += 1
        'line = sr.ReadLine()
        'End While
        'memeriksa jika masih ada baris tersisa
        'If Not (line Is Nothing) Then
        'e.HasMorePages = True
        'Else
        'e.HasMorePages = False
        'End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        PrintPreviewDialog1.Show()
    End Sub

End Class