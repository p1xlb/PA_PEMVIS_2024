Public Class AdminDash
    Private Sub ManajemenInventarisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManajemenInventarisToolStripMenuItem.Click
        InventoryManager.Show()
    End Sub

    Private Sub ListPersetujuanToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ListPersetujuanToolStripMenuItem.Click
        Approval.Show()
    End Sub

    Private Sub ListPenyewaanBerjalanToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ListPenyewaanBerjalanToolStripMenuItem.Click
        FinishRent.Show()
    End Sub

    Private Sub ListRiwayatPenyewaanToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ListRiwayatPenyewaanToolStripMenuItem.Click
        RentHistory.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Form1.Clear()
        Form1.Show()
        Me.Close()
    End Sub
End Class