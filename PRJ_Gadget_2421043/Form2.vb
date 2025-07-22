Public Class FMenu
    Inherits System.Windows.Forms.Form
    Private Sub ManajemenUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManajemenUserToolStripMenuItem.Click
        Fuser.Show()
        Me.Hide()
    End Sub

    Private Sub GantiPaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GantiPaToolStripMenuItem.Click
        Fgantipassword.Show()
        Me.Hide()
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ProdukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdukToolStripMenuItem.Click
        FProduk.Show()
        Me.Hide()
    End Sub

    Private Sub PelangganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PelangganToolStripMenuItem.Click
        FPelanggan.Show()
        Me.Hide()
    End Sub

    Private Sub PenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItem.Click
        FJual.Show()
        Me.Hide()
    End Sub
End Class