Imports System.Data.SqlClient

Public Class IOR
    Dim cn As New SqlConnection("Data Source=LAPTOP-G9EG0LI8\SQLEXPRESS;Initial Catalog=testdb;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim tbl As New DataTable()
    Dim str As String
    Dim gen As String
    Public digit1 As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Label11.ForeColor = Color.Red

        If (TextBox1.Text = "") Then
            Label11.Text = "enter pan number"
            Exit Sub
        Else
            If (TextBox1.Text.Length = 10) Then

            Else
                Label11.Text = "pan number should be 10 alphanumeric characters long"
                Exit Sub
            End If
        End If

        If (TextBox2.Text = "") Then
            Label11.Text = "enter addhar card number"
            Exit Sub
        Else
            If (TextBox2.Text.Length = 12) Then

            Else
                Label11.Text = "addhar number should be 12 digit long"
                Exit Sub
            End If
        End If

        If (TextBox3.Text = "") Then
            Label11.Text = "enter full name"
            Exit Sub
        End If

        If (RadioButton1.Checked = True) Then
            gen = "male"
        ElseIf (RadioButton2.Checked = True) Then
            gen = "female"
        Else
            Label11.Text = "select gender"
            Exit Sub
        End If

        If (TextBox4.Text = "") Then
            Label11.Text = "enter contact number"
            Exit Sub
        Else
            If (TextBox4.Text.Length = 10) Then

            Else
                Label11.Text = "contact number should be 10 digit long"
                Exit Sub
            End If
        End If

        If (TextBox5.Text = "") Then
            Label11.Text = "enter email id"
            Exit Sub
        End If

        If (TextBox6.Text = "") Then
            Label11.Text = "enter parmanent address"
            Exit Sub
        End If

        If (TextBox7.Text = "") Then
            Label11.Text = "enter primary bank account no"
            Exit Sub
        Else
            If (TextBox7.Text.Length > 18 Or TextBox7.Text.Length < 9) Then
                Label11.Text = "bank account number should be 9 to 18 digit long"
                Exit Sub
            End If
        End If

        If (TextBox8.Text = "") Then
            Label11.Text = "enter ifsc code"
            Exit Sub
        Else
            If (TextBox8.Text.Length = 11) Then

            Else
                Label11.Text = "ifsc code should be 11 alphanumeric charaters long"
                Exit Sub
            End If
        End If

        Dim digit As Integer
        Dim i As Integer
        Dim check As Integer
        Dim ex As String

        i = 0

        Do While (i <= 0)
            Randomize()
            digit = ((9999 * Rnd()) + 1)
            Randomize()
            ex = digit
            digit1 = "IND(1)_" + ex

            str = "select * from individual_info where ind_id='" & digit1 & "'"

            cmd = New SqlCommand(str, cn)
            cn.Open()
            da = New SqlDataAdapter(cmd)
            ds = New DataSet()
            da.Fill(ds)

            tbl = ds.Tables(0)
            check = tbl.Rows.Count()
            cn.Close()

            If check = 0 Then
                i = i + 1
                str = "insert into individual_info values('" + digit1 + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + DateTimePicker1.Text + "','" + gen + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "')"
                cmd = New SqlCommand(str, cn)
                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
            End If
        Loop

        Me.Hide()
        Form11.Show()
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
        Label11.Text = ""
    End Sub

    Private Sub IOR_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class