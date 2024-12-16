Imports System.Data.SqlClient
Public Class signup

    Private Sub back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back.Click
        login.Show()
        Me.Hide()

    End Sub

    Private Sub signup_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles signup_btn.Click

        Label6.ForeColor = Color.Red

        If (TextBox1.Text = "") Then
            Label6.Text = "enter user name."
            Exit Sub
        End If

        If (TextBox2.Text = "") Then
            Label6.Text = "enter password"
            Exit Sub
        End If

        If (TextBox3.Text = "") Then
            Label6.Text = "enter confirm password"
            Exit Sub
        End If

        If (TextBox2.Text = TextBox3.Text) Then
            If (TextBox2.TextLength >= 8) Then
                Try
                    Dim con As New SqlConnection
                    Dim cmd As New SqlCommand
                    con.ConnectionString = "Data Source=LAPTOP-G9EG0LI8\SQLEXPRESS;Initial Catalog=testdb;Integrated Security=True;Pooling=False"
                    con.Open()
                    cmd = con.CreateCommand()
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "insert into login values('" + TextBox1.Text + "','" + TextBox2.Text + "')"
                    cmd.ExecuteNonQuery()
                    Label6.Text = "sign up successfull."
                    Label6.ForeColor = Color.Green
                Catch ex As SqlException
                    Label6.Text = "This User Name Is Already Exist."
                    Label6.ForeColor = System.Drawing.Color.Red
                End Try
            Else
                Label6.ForeColor = System.Drawing.Color.Red
                Label6.Text = "Password Length Should be 8 Charater."
            End If
        Else
            Label6.ForeColor = System.Drawing.Color.Red
            Label6.Text = "Password Does Not Match."
        End If
    End Sub

    Private Sub signup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        Label6.Text = ""
    End Sub
End Class