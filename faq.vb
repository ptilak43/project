Public Class faq

    Private Sub HomeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeToolStripMenuItem.Click
        home.Show()
        guide.Hide()
        Me.Hide()
        Info.Hide()
    End Sub

    Private Sub GuideToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuideToolStripMenuItem.Click
        home.Hide()
        guide.Show()
        Me.Hide()
        Info.Hide()
    End Sub

    Private Sub FQToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FQToolStripMenuItem.Click
        home.Hide()
        guide.Hide()
        Me.Show()
        Info.Hide()
    End Sub

    Private Sub InfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InfoToolStripMenuItem.Click
        home.Hide()
        guide.Hide()
        Me.Hide()
        Info.Show()
    End Sub
End Class