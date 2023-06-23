Public Class Form1
    Private Function HitungVolume(jari As Integer) As Integer
        Dim volume As Integer
        volume = 4 * 22 / 7 * jari * jari
        Return volume
    End Function

    Private Function HitungLuasPermukaan(jari As Integer) As Integer
        Dim luas_permukaan As Integer
        luas_permukaan = (4 / 3) * 22 / 7 * jari * jari * jari
        Return luas_permukaan
    End Function

    Private Sub btnhitung_Click(sender As Object, e As EventArgs) Handles btnhitung.Click
        Dim jari, volume, luaspermukaan

        jari = Val(txtjari.Text)

        volume = HitungVolume(jari)
        luaspermukaan = HitungLuasPermukaan(jari)

        txtvolume.Text = Str(volume)
        txtluaspermukaan.Text = Str(luaspermukaan)

    End Sub

    Private Sub txtjari_TextChanged(sender As Object, e As EventArgs) Handles txtjari.TextChanged

    End Sub
End Class

