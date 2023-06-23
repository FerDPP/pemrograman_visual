Public Class Form1
    Private Function HitungVolume(jari As Integer, tinggi As Integer) As Integer
        Dim volume As Integer
        volume = (22 / 7) * jari * jari * tinggi
        Return volume
    End Function

    Private Function HitungLuasPermukaan(jari As Integer, tinggi As Integer) As Integer
        Dim luas_permukaan As Integer
        luas_permukaan = 2 * (22 / 7) * jari * (jari + tinggi)
        Return luas_permukaan
    End Function

    Private Sub btnhitung_Click(sender As Object, e As EventArgs) Handles btnhitung.Click
        Dim jari, tinggi, volume, luaspermukaan

        jari = Val(txtjari.Text)
        tinggi = Val(txttinggi.Text)

        volume = HitungVolume(jari, tinggi)
        luaspermukaan = HitungLuasPermukaan(jari, tinggi)

        txtvolume.Text = Str(volume)
        txtluaspermukaan.Text = Str(luaspermukaan)

    End Sub
End Class

