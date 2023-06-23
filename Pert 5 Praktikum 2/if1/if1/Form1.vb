Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (Val(txtusia.Text) >= 40) Then
            txtketerangan.Text = "Orang tua"

        ElseIf (txtusia.Text >= 30) Then
            txtketerangan.Text = "Bujangan"

        ElseIf (txtusia.Text >= 20) Then
            txtketerangan.Text = "Pemuda"

        ElseIf (txtusia.Text >= 10) Then
            txtketerangan.Text = "Remaja"

        Else
            txtketerangan.Text = "Bayi"
        End If
    End Sub
End Class