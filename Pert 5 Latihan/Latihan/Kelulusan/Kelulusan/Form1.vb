Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (Val(txtnilaiakhir.Text) >= 60) Then
            txtketerangan.Text = "Anda Lulus"
        Else
            txtketerangan.Text = "Anda tidak Lulus, Silahkan mengulang tahun depan"
        End If
    End Sub
End Class
