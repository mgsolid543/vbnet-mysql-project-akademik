Public Class FormUtama

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        End
    End Sub

    Private Sub RuanganToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RuanganToolStripMenuItem.Click
        Dim FormRuangan = New FormRuangan
        FormRuangan.MdiParent = Me
        FormRuangan.Show()
    End Sub
End Class
