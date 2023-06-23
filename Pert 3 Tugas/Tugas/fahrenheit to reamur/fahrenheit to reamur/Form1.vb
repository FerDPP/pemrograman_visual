Public Class Form1
    Private Function KonversiFahrenheittoReamur(f As Integer) As Integer
        Dim r As Integer
        r = (4 / 9) * (f - 32)
        Return r
    End Function
    Private Sub btnkonversi_Click(sender As Object, e As EventArgs) Handles btnkonversi.Click
        Dim f, r As Integer

        f = Val(txtfahre.Text)

        r = KonversiFahrenheittoReamur(f)
        txtreamur.Text = Str(r)
    End Sub

    Private Sub txtfahre_TextChanged(sender As Object, e As EventArgs) Handles txtfahre.TextChanged

    End Sub
End Class
