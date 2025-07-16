Public Class FMenu
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
End Class