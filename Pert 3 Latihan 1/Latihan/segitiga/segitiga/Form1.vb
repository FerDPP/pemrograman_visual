Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim alas, tinggi, sisi1, sisi2, sisi3, luas, keliling As Integer

        alas = Val(txtalas.Text)
        tinggi = Val(txttinggi.Text)
        sisi1 = Val(txtsisi1.Text)
        sisi2 = Val(txtsisi2.Text)
        sisi3 = Val(txtsisi3.Text)

        luas = 0.5 * alas * tinggi
        keliling = sisi1 + sisi2 + sisi3

        txtluas.Text = Str(luas)
        txtkeliling.Text = Str(keliling)

    End Sub
End Class
