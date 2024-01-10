Public Class FormUtama

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        End
    End Sub

    Private Sub RuanganToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RuanganToolStripMenuItem.Click
        Dim FormRuangan = New FormRuangan
        FormRuangan.MdiParent = Me
        FormRuangan.Show()
    End Sub

    Private Sub MahasiswaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MahasiswaToolStripMenuItem.Click
        Dim FormMahasiswa = New FormMahasiswa
        FormMahasiswa.MdiParent = Me
        FormMahasiswa.Show()
    End Sub

    Private Sub DosenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DosenToolStripMenuItem.Click
        Dim FormDosen = New FormDosen
        FormDosen.MdiParent = Me
        FormDosen.Show()
    End Sub
End Class
