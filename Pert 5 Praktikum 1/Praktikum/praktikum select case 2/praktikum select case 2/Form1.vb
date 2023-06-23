Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Select Case txtpabrik.Text
            Case "TMMIN" : txtketerangan.Text = "Toyota Motor Manufacturing Indonesia"

            Case "AHM" : txtketerangan.Text = "Astra Honda Motor"

            Case "ADM" : txtketerangan.Text = "Astea Daihatsu Motor"

            Case "HMMI" : txtketerangan.Text = "Hyundai Motor Manufacturing Indonesia"

            Case Else : txtketerangan.Text = "Pabrik Belum Terdaftar"
        End Select
    End Sub

    Private Sub txtpabrik_TextChanged(sender As Object, e As EventArgs) Handles txtpabrik.TextChanged

    End Sub
End Class