Imports System.Data.SqlClient

Public Class Form15
    Dim cn As New SqlConnection("Data Source=LAPTOP-G9EG0LI8\SQLEXPRESS;Initial Catalog=testdb;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim tbl As New DataTable()
    Dim str As String
    Dim i As Integer = 0
    Dim tti As Double = 0
    Dim haes As Double = 0
    Dim pt As Double = 0
    Dim td As Double = 0
    Dim check As Double

    Private Sub Form15_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim stcgt As Double
        Dim ltcgt As Double
        Dim inter As Double

        Label32.ForeColor = Color.Red

        If TextBox9.Text = "" Then
            Label32.Text = "please enter revenue"
            Exit Sub
        End If

        If TextBox1.Text = "" And TextBox2.Text = "" And TextBox3.Text = "" And TextBox4.Text = "" And TextBox10.Text = "" Then
            Label32.Text = "please enter any type of income."
            Exit Sub
        End If

        stcgt = (Val(TextBox2.Text) * 0.2)
        inter = (Val(TextBox10.Text) - 125000)

        If (inter > 0) Then
            ltcgt = (inter * 0.125)
        Else
            ltcgt = 0
        End If

        tti = Val(TextBox2.Text) + Val(TextBox3.Text) + Val(TextBox4.Text)

        If tti = 0 Then
            pt = 0
            haes = 0
            GoTo phase1
        End If

        If Val(TextBox7.Text) < 400 Then
            pt = pt + (tti * 0.25)
            GoTo phase1
        ElseIf Val(TextBox7.Text) > 400 Then
            pt = pt + (tti * 0.3)
            GoTo phase1
        Else
            pt = 0
            GoTo phase1
        End If

phase1:

        pt = pt + stcgt + ltcgt
        tti = Val(TextBox1.Text) + Val(TextBox2.Text) + Val(TextBox10.Text) + Val(TextBox3.Text) + Val(TextBox4.Text)

        haes = pt * 0.04
        TextBox5.Text = tti
        TextBox6.Text = haes
        TextBox7.Text = pt + haes
        TextBox8.Text = td

        If TextBox1.Text = "" Then
            TextBox1.Text = 0
        End If
        If TextBox2.Text = "" Then
            TextBox2.Text = 0
        End If
        If TextBox3.Text = "" Then
            TextBox3.Text = 0
        End If
        If TextBox4.Text = "" Then
            TextBox4.Text = 0
        End If
        If TextBox10.Text = "" Then
            TextBox10.Text = 0
        End If
        If Val(TextBox6.Text) < 0 Then
            TextBox6.Text = 0
        End If
        If Val(TextBox7.Text) < 0 Then
            TextBox7.Text = 0
        End If
        If Val(TextBox5.Text) < 0 Then
            TextBox8.Text = 0
        End If
        If Val(TextBox8.Text) < 0 Then
            TextBox9.Text = 0
        End If

        tti = 0
        pt = 0
        haes = 0

        Label32.Text = "your tax has been calculated."
        Label32.ForeColor = Color.Green

        Button7.Visible = True
        Button1.Visible = False
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        Label32.Text = ""
        Button1.Visible = True
        Button7.Visible = False
    End Sub
End Class