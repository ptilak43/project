Public Class home


    Private Sub HomeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeToolStripMenuItem.Click
        Me.Show()
        guide.Hide()
        faq.Hide()
        Info.Hide()

    End Sub

    Private Sub GuideToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuideToolStripMenuItem.Click
        Me.Hide()
        guide.Show()
        faq.Hide()
        info.Hide()
    End Sub

    Private Sub FQToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FQToolStripMenuItem.Click
        Me.Hide()
        guide.Hide()
        faq.Show()
        Info.Hide()
    End Sub

    Private Sub InfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InfoToolStripMenuItem.Click
        Me.Hide()
        guide.Hide()
        faq.Hide()
        Info.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        IOR.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        INR.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        COR.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        CNR.Show()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Me.Hide()
        login.Show()
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Close()
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Button5.Visible = False
        Button6.Visible = False
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        GroupBox3.Visible = False
        GroupBox4.Visible = False
        MenuStrip1.Visible = False
        Panel1.Visible = False
        Panel2.Visible = False

    End Sub
End Class