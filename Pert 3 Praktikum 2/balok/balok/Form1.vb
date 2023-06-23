Public Class Form1
    Private Function HitungVolume(panjang As Integer, lebar As Integer, tinggi As Integer) As Integer
        Dim volume As Integer
        volume = panjang * lebar * tinggi
        Return volume
    End Function

    Private Function HitungLuasPermukaan(panjang As Integer, lebar As Integer, tinggi As Integer) As Integer
        Dim luas_permukaan As Integer
        luas_permukaan = 2 * (panjang * lebar + lebar * tinggi + panjang * tinggi)
        Return luas_permukaan
    End Function

    Private Sub btnhitung_Click(sender As Object, e As EventArgs) Handles btnhitung.Click
        Dim panjang, lebar, tinggi, volume, luaspermukaan

        panjang = Val(txtpanjang.Text)
        lebar = Val(txtlebar.Text)
        tinggi = Val(txttinggi.Text)

        volume = HitungVolume(panjang, lebar, tinggi)
        luaspermukaan = HitungLuasPermukaan(panjang, lebar, tinggi)

        txtvolume.Text = Str(volume)
        txtluaspermukaan.Text = Str(luaspermukaan)

    End Sub

    Private Sub txtpanjang_TextChanged(sender As Object, e As EventArgs) Handles txtpanjang.TextChanged

    End Sub
End Class
