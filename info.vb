Public Class Info

    Private Sub HomeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeToolStripMenuItem.Click
        home.Show()
        guide.Hide()
        faq.Hide()
        Me.Hide()
    End Sub

    Private Sub GuideToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuideToolStripMenuItem.Click
        home.Hide()
        guide.Show()
        faq.Hide()
        Me.Hide()
    End Sub

    Private Sub FQToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FQToolStripMenuItem.Click
        Me.Hide()
        guide.Hide()
        faq.Show()
        Me.Hide()
    End Sub

    Private Sub InfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InfoToolStripMenuItem.Click
        Me.Hide()
        guide.Hide()
        faq.Hide()
        Me.Show()
    End Sub
End Class