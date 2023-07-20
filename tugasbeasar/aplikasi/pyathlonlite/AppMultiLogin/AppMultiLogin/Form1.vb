Public Class Form1
    Private Sub DJasaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DJasaToolStripMenuItem.Click
        DJasaForm.ShowDialog()
    End Sub

    Private Sub DPelangganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DPelangganToolStripMenuItem.Click
        DPelangganForm.ShowDialog()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MatikanSemuaMenu()

    End Sub

    Private Sub MatikanSemuaMenu()
        MenuAdminBar.Visible = False
        MenuDosenBar.Visible = False
        LoginBar.Visible = True
        LogoutBar.Visible = False
    End Sub

    Private Sub LoginBar_Click(sender As Object, e As EventArgs) Handles LoginBar.Click
        LoginForm.ShowDialog()

    End Sub

    Private Sub LogoutBar_Click(sender As Object, e As EventArgs) Handles LogoutBar.Click
        MatikanSemuaMenu()

    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'Jika user login adalah Admin
        If (admin_role = True) Then
            MenuAdminBar.Visible = True
            MenuDosenBar.Visible = False
            LoginBar.Visible = False
            LogoutBar.Visible = True
        End If

        'Jika user login adalah Dosen
        If (dosen_role = True) Then
            MenuAdminBar.Visible = False
            MenuDosenBar.Visible = True
            LoginBar.Visible = False
            LogoutBar.Visible = True
        End If
    End Sub

    Private Sub ExitBar_Click(sender As Object, e As EventArgs) Handles ExitBar.Click
        End
    End Sub

    Private Sub MenuDosenBar_Click(sender As Object, e As EventArgs)

    End Sub
End Class
