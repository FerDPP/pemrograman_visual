Public Class Form1
    Private Function HitungVolume(sisi As Integer) As Integer
        Dim volume As Integer
        volume = Math.Pow(sisi, 3)
        Return volume
    End Function

    Private Function HitungLuasPermukaan(sisi As Integer) As Integer
        Dim luas_permukaan As Integer
        luas_permukaan = 6 * Math.Pow(sisi, 2)
        Return luas_permukaan
    End Function

    Private Sub btnhitung_Click(sender As Object, e As EventArgs) Handles btnhitung.Click
        Dim sisi, volume, luaspermukaan

        sisi = Val(txtsisi.Text)

        volume = HitungVolume(sisi)
        luaspermukaan = HitungLuasPermukaan(sisi)

        txtvolume.Text = Str(volume)
        txtluaspermukaan.Text = Str(luaspermukaan)

    End Sub
End Class

