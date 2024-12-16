Public Class Form17

    Dim i As Integer = 0

    Private Sub Form17_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Panel2.Visible = True
        Panel3.Visible = True
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        If i = 1 Then
            i = i - 1
            Panel4.Visible = False
            Panel3.Visible = True
        End If
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        If i = 0 Then
            i = i + 1
            Panel4.Visible = True
            Panel3.Visible = False
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
    End Sub
End Class