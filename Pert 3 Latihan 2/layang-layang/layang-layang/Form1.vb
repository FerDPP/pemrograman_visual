Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim d1, d2, sipan, sipen, luas, keliling As Integer

        d1 = Val(txtdiagonal1.Text)
        d2 = Val(txtdiagonal2.Text)
        sipan = Val(txtsipan.Text)
        sipen = Val(txtsipen.Text)

        luas = 0.5 * (d1 * d2)
        keliling = 2 * (sipan * sipen)

        txtluas.Text = Str(luas)
        txtkeliling.Text = Str(keliling)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
