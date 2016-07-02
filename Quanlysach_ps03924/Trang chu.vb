Public Class Trang_chu
    Private Sub KháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KháchHàngToolStripMenuItem.Click
        Quanlykhachhang.ShowDialog()
    End Sub

    Private Sub LoạiSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoạiSáchToolStripMenuItem.Click
        Theloai.ShowDialog()
    End Sub
End Class