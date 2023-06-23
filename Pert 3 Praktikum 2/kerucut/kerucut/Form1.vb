Public Class Form1
    Private Function HitungVolume(jari As Integer, tinggi As Integer) As Integer
        Dim volume As Integer
        volume = 1 / 3 * Math.PI * Math.Pow(jari, 2) * tinggi

        Return volume
    End Function

    Private Function HitungLuasPermukaan(jari As Integer, tinggi As Integer) As Integer
        Dim luas_permukaan As Integer
        luas_permukaan = Math.PI * jari * (jari + (Math.Sqrt((Math.Pow(jari, 2) + Math.Pow(tinggi, 2)))))
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

    Private Sub txttinggi_TextChanged(sender As Object, e As EventArgs) Handles txttinggi.TextChanged

    End Sub
End Class

