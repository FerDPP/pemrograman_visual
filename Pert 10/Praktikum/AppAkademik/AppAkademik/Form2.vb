Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reload()
    End Sub

    Private Sub Reload()
        oMatakuliah.getAllData(DataGridView1)
    End Sub

    Private Sub txtKdmk_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKdmk.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            oMatakuliah.Carimatakuliah(txtKdmk.Text)
            If (matakuliah_baru = False) Then
                TampilMatakuliah()
            Else
                MessageBox.Show("Data tidak ditemukan")
                matakuliah_baru = True
            End If
        End If
    End Sub

    Private Sub TampilMatakuliah()
        txtKdmk.Text = oMatakuliah.kodemk
        txtNmk.Text = oMatakuliah.namamk
        txtSks.Text = oMatakuliah.sks
        txtProdi.Text = oMatakuliah.prodi
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ClearEntry()
    End Sub

    Private Sub ClearEntry()
        txtKdmk.Clear()
        txtNmk.Clear()
        txtSks.Clear()
        txtProdi.Clear()
        txtKdmk.Focus()
    End Sub

    Private Sub SimpanDatamatakuliah()
        oMatakuliah.kodemk = txtKdmk.Text
        oMatakuliah.namamk = txtNmk.Text
        oMatakuliah.sks = txtSks.Text
        oMatakuliah.prodi = txtProdi.Text
        oMatakuliah.Simpan()
        Reload()
        If (oMatakuliah.InsertState = True) Then
            MessageBox.Show("Data berhasil disimpan.")
        ElseIf (oMatakuliah.UpdateState = True) Then
            MessageBox.Show("Data berhasil diperbarui.")
        Else
            MessageBox.Show("Data gagal disimpan.")
        End If
        ClearEntry()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If (txtKdmk.Text <> "" And txtNmk.Text <> "") Then
            SimpanDatamatakuliah()
            ClearEntry()
            Reload()
        Else
            MessageBox.Show("Kode Matakuliah dan Nama Matakuliah tidak boleh kosong!")
        End If
    End Sub
    Private Sub Hapus()
        If (matakuliah_baru = False And txtKdmk.Text <> "") Then
            oMatakuliah.Hapus(txtKdmk.Text)
            ClearEntry()
            Reload()
        End If
    End Sub
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim jawab As Integer
        jawab = MessageBox.Show("Apakah Data akan dihapus", "Confirm", MessageBoxButtons.YesNo)
        If (jawab = vbYes) Then
            Hapus()
        Else
            MessageBox.Show("Data Batal dihapus")
        End If
    End Sub

    Private Sub txtKdmk_TextChanged(sender As Object, e As EventArgs) Handles txtKdmk.TextChanged

    End Sub
End Class
