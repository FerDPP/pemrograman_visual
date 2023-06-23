Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reload()
    End Sub

    Private Sub Reload()
        oMahasiswa.getAllData(DataGridView1)
    End Sub

    Private Sub txtNIM_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNIM.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            oMahasiswa.Carimahasiswa(txtNIM.Text)
            If (mahasiswa_baru = False) Then
                TampilMahasiswa()
            Else
                MessageBox.Show("Data tidak ditemukan")
                mahasiswa_baru = True
            End If
        End If
    End Sub

    Private Sub TampilMahasiswa()
        txtNIM.Text = oMahasiswa.nim
        txtNama.Text = oMahasiswa.nama
        txtJK.Text = oMahasiswa.jk
        txtProdi.Text = oMahasiswa.prodi
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ClearEntry()
    End Sub

    Private Sub ClearEntry()
        txtNIM.Clear()
        txtNama.Clear()
        txtJK.Clear()
        txtProdi.Clear()
        txtNIM.Focus()
    End Sub

    Private Sub SimpanDatamahasiswa()
        oMahasiswa.nim = txtNIM.Text
        oMahasiswa.nama = txtNama.Text
        oMahasiswa.jk = txtJK.Text
        oMahasiswa.prodi = txtProdi.Text
        oMahasiswa.Simpan()
        Reload()
        If (oMahasiswa.InsertState = True) Then
            MessageBox.Show("Data berhasil disimpan.")
        ElseIf (oMahasiswa.UpdateState = True) Then
            MessageBox.Show("Data berhasil diperbarui.")
        Else
            MessageBox.Show("Data gagal disimpan.")
        End If
        ClearEntry()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If (txtNIM.Text <> "" And txtNama.Text <> "") Then
            SimpanDatamahasiswa()
            ClearEntry()
            Reload()
        Else
            MessageBox.Show("nim dan nama tidak boleh kosong!")
        End If
    End Sub
End Class
