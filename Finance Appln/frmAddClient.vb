Imports System.Data.SqlClient
Public Class frmAddClient

    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand
    Dim rs As SqlDataReader

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" And TextBox6.Text <> "" And TextBox7.Text <> "") Then
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "insert into Client_Details values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "')"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            cn.Close()
            MsgBox("Record Saved Successfully", MsgBoxStyle.Information, "Done")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            Auto_Gen()
        Else
            MsgBox("Please enter complete details.", MsgBoxStyle.Critical, "Error")
            TextBox2.Focus()
        End If
    End Sub

    Private Sub frmAddClient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Data Source=NIKUL-LAPTOP;Initial Catalog=ColorGrid;Integrated Security=True"
        Auto_Gen()
    End Sub

    Private Sub Auto_Gen()

        Dim cnt, temp As Integer
        Dim id As String
        temp = 0
        cnt = 0
        id = ""
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "select count(*) from Client_Details"
        rs = cmd.ExecuteReader()
        While (rs.Read())
            cnt = CInt(rs.GetValue(0).ToString())
        End While
        rs.Close()
        cmd.Dispose()
        cn.Close()
        If (cnt > 0) Then

            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "select max(CID) from Client_Details"
            rs = cmd.ExecuteReader()
            While (rs.Read())

                id = rs.GetValue(0).ToString()
            End While
            rs.Close()
            cmd.Dispose()
            cn.Close()
            temp = CInt(id.Substring(1, 4))
            temp = temp + 1
            id = ""
            id = temp.ToString()
            If (id.Length = 1) Then
                id = "C000" + id
            ElseIf (id.Length = 2) Then
                id = "C00" + id
            ElseIf (id.Length = 3) Then
                id = "C0" + id
            ElseIf (id.Length = 4) Then
                id = "C" + id
            End If
            TextBox1.Text = id
        Else
            TextBox1.Text = "C0001"
        End If
        TextBox2.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox2.Focus()
    End Sub
End Class