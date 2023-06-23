Public Class Form1
    Private Function KonversiCelciustoFahrenheit(c As Integer) As Integer
        Dim f As Integer
        f = (9 / 5 * c) + 32
        Return f
    End Function

    Private Sub btnkonversi_Click(sender As Object, e As EventArgs) Handles btnkonversi.Click
        Dim c, f As Integer
        c = Val(txtcelcius.Text)

        f = KonversiCelciustoFahrenheit(c)
        txtfahre.Text = Str(f)

    End Sub

    Private Sub txtcelcius_TextChanged(sender As Object, e As EventArgs) Handles txtcelcius.TextChanged

    End Sub
End Class
