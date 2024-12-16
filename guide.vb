Public Class guide

 
    Private Sub HomeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeToolStripMenuItem.Click
        home.Show()
        Me.Hide()
        faq.Hide()
        Info.Hide()
    End Sub

    Private Sub GuideToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuideToolStripMenuItem.Click
        home.Hide()
        Me.Show()
        faq.Hide()
        Info.Hide()
    End Sub

    Private Sub FQToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FQToolStripMenuItem.Click
        home.Hide()
        Me.Hide()
        faq.Show()
        Info.Hide()
    End Sub

    Private Sub InfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InfoToolStripMenuItem.Click
        home.Hide()
        Me.Hide()
        faq.Hide()
        Info.Show()
    End Sub
End Class