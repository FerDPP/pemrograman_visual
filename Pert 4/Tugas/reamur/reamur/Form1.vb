Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim R, C, F, K As Decimal
        R = CDec(txtReamur.Text)
        C = ToCelcius(R)
        F = Tofahrenheit(R)
        K = ToKelvin(R)

        txtCelcius.Text = Str(C)
        txtFahrenheit.Text = Str(F)
        txtKelvin.Text = Str(K)
    End Sub

    Private Function ToCelcius(suhu As Decimal) As Decimal
        Dim C As Decimal
        C = (5 / 4) * suhu
        Return C
    End Function

    Private Function ToFahrenheit(suhu As Decimal) As Decimal
        Dim F As Decimal
        F = (9 / 4) * suhu + 32
        Return F
    End Function

    Private Function ToKelvin(suhu As Decimal) As Decimal
        Dim K As Decimal
        K = (5 / 4 * suhu) + 273
        Return K
    End Function

End Class
