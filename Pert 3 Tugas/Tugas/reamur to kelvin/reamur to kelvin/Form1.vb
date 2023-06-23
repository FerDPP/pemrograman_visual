Public Class Form1
    Private Function KonversiReamurtoKelvin(r As Integer) As Integer
        Dim k As Integer
        k = (5 / 4 * r) + 273
        Return k
    End Function
    Private Sub btnkonversi_Click(sender As Object, e As EventArgs) Handles btnkonversi.Click
        Dim r, k As Integer
        r = Val(txtreamur.Text)

        k = KonversiReamurtoKelvin(r)
        txtkelvin.Text = Str(k)
    End Sub
End Class
