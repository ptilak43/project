Imports System.Data.SqlClient

Public Class Form13
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

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim stcgt As Double
        Dim ltcgt As Double
        Dim inter As Double

        If TextBox1.Text = "" And TextBox2.Text = "" And TextBox3.Text = "" And TextBox4.Text = "" And TextBox5.Text = "" And TextBox10.Text = "" Then
            Label32.Text = "please enter any type of income."
            Label32.ForeColor = Color.Red
            Exit Sub
        End If

        stcgt = (Val(TextBox2.Text) * 0.2)
        inter = (Val(TextBox10.Text) - 125000)

        If (inter > 0) Then
            ltcgt = (inter * 0.125)
        Else
            ltcgt = 0
        End If

        tti = Val(TextBox1.Text) + Val(TextBox3.Text) + Val(TextBox4.Text) + Val(TextBox5.Text)

        If tti = 0 Then
            pt = 0
            haes = 0
            GoTo phase1
        End If

        If tti <= 300000 Then
            pt = 0
            haes = 0
            GoTo phase1
        End If
        check = 0

        check = tti - 300000
        If check <= 400000 Then
            pt = pt + (check * 0.05)
            GoTo phase1
        Else
            pt = pt + (400000 * 0.05)
        End If
        check = 0

        check = tti - 700000
        If check <= 300000 Then
            pt = pt + (check * 0.1)
            GoTo phase1
        Else
            pt = pt + (300000 * 0.1)
        End If
        check = 0

        check = tti - 1000000
        If check <= 200000 Then
            pt = pt + (check * 0.15)
            GoTo phase1
        Else
            pt = pt + (200000 * 0.15)
        End If
        check = 0

        check = tti - 1200000
        If check <= 300000 Then
            pt = pt + (check * 0.2)
            GoTo phase1
        Else
            pt = pt + (300000 * 0.2)
        End If
        check = 0

        check = tti - 1500000
        If check > 0 Then
            pt = pt + (check * 0.3)
            GoTo phase1
        End If
        check = 0

phase1:

        pt = pt + stcgt + ltcgt
        tti = Val(TextBox1.Text) + Val(TextBox2.Text) + Val(TextBox10.Text) + Val(TextBox3.Text) + Val(TextBox4.Text) + Val(TextBox5.Text)

        haes = pt * 0.04
        TextBox6.Text = tti
        TextBox7.Text = haes
        TextBox8.Text = pt + haes
        TextBox9.Text = td

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
        If TextBox5.Text = "" Then
            TextBox5.Text = 0
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
        If Val(TextBox8.Text) < 0 Then
            TextBox8.Text = 0
        End If
        If Val(TextBox9.Text) < 0 Then
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

    Private Sub Form13_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Try
            Dim cg As Double
            Dim id As String = INR.digit1
            cg = (Val(TextBox2.Text) + Val(TextBox10.Text))
            Dim cg1 As String = cg

            str = "insert into individual_tax_info values('" + id + "','" + TextBox1.Text + "','" + cg1 + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "')"
            cmd = New SqlCommand(str, cn)

            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If

            cmd.ExecuteNonQuery()
            cn.Close()

            Form14.Show()
            Me.Hide()

        Catch a As SqlException
            Label32.Text = a.Message
            Label32.ForeColor = Color.Red
        End Try
    End Sub
End Class