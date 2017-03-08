Imports System.Data.SqlClient
Public Class frmAddAsset
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand
    Dim rs As SqlDataReader
    Private Sub frmAddAsset_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Data Source=NIKUL-LAPTOP;Initial Catalog=ColorGrid;Integrated Security=True"
        Auto_Gen()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "select CID from Client_Details"
        rs = cmd.ExecuteReader()
        While (rs.Read())
            ComboBox1.Items.Add(rs.GetValue(0).ToString())
        End While
        rs.Close()
        cmd.Dispose()
        cn.Close()
    End Sub

    Private Sub Auto_Gen()

        Dim cnt, temp As Integer
        Dim id As String
        temp = 0
        cnt = 0
        id = ""
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "select count(*) from Assest"
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
            cmd.CommandText = "select max(AID) from Assest"
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
                id = "A000" + id
            ElseIf (id.Length = 2) Then
                id = "A00" + id
            ElseIf (id.Length = 3) Then
                id = "A0" + id
            ElseIf (id.Length = 4) Then
                id = "A" + id
            End If
            TextBox1.Text = id
        Else
            TextBox1.Text = "A0001"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (TextBox1.Text <> "" And ComboBox1.SelectedIndex <> -1 And ComboBox2.SelectedIndex <> -1 And TextBox2.Text <> "" And TextBox3.Text <> "") Then
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "insert into Assest values('" + TextBox1.Text + "','" + ComboBox1.SelectedItem.ToString() + "','" + ComboBox2.SelectedItem.ToString() + "','" + DateTimePicker1.Value.ToShortDateString() + "','" + DateTimePicker2.Value.ToShortDateString() + "','" + TextBox2.Text + "','" + TextBox3.Text + "')"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            cn.Close()
            MsgBox("Record Saved Successfully", MsgBoxStyle.Information, "Done")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            ComboBox1.SelectedIndex = -1
            ComboBox2.SelectedIndex = -1
            Auto_Gen()
        Else
            MsgBox("Please enter complete details.", MsgBoxStyle.Critical, "Error")
            TextBox2.Focus()
        End If
    End Sub
End Class