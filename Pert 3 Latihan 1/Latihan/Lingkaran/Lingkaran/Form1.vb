Public Class Form1
    Private Sub btnhitung_Click(sender As Object, e As EventArgs) Handles btnhitung.Click
        Dim jari, luas, keliling As Integer

        jari = Val(txtjari.Text)

        luas = 22 / 7 * (jari * jari)
        keliling = 2 * 22 / 7 * jari

        txtluas.Text = Str(luas)
        txtkeliling.Text = Str(keliling)

    End Sub
End Class
