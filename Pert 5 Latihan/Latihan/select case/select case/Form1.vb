Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Select Case txtkodejabatan.Text
            Case "MGR" : txtketerangan.Text = "Manager"

            Case "SKR" : txtketerangan.Text = "Sekretaris"

            Case "BDH" : txtketerangan.Text = "Bendahara"

            Case Else : txtketerangan.Text = "Staff"
        End Select
    End Sub

    Private Sub txtkodejabatan_TextChanged(sender As Object, e As EventArgs) Handles txtkodejabatan.TextChanged

    End Sub
End Class