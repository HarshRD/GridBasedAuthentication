Imports System.Data.SqlClient
Public Class frmUDClients

    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand
    Dim rs As SqlDataReader

    Private Sub frmUDClients_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Data Source=NIKUL-LAPTOP;Initial Catalog=ColorGrid;Integrated Security=True"
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

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If (ComboBox1.SelectedIndex <> -1) Then
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "select * from Client_Details where CID='" + ComboBox1.SelectedItem.ToString() + "'"
            rs = cmd.ExecuteReader()
            While (rs.Read())
                TextBox2.Text = rs.GetValue(1).ToString()
                TextBox3.Text = rs.GetValue(2).ToString()
                TextBox4.Text = rs.GetValue(3).ToString()
                TextBox5.Text = rs.GetValue(4).ToString()
                TextBox6.Text = rs.GetValue(5).ToString()
                TextBox7.Text = rs.GetValue(6).ToString()
            End While
            rs.Close()
            cmd.Dispose()
            cn.Close()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" And TextBox6.Text <> "" And TextBox7.Text <> "" And ComboBox1.SelectedIndex <> -1) Then
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "update Client_Details set CName='" + TextBox2.Text + "',CAddress='" + TextBox3.Text + "',CMobile='" + TextBox4.Text + "',CEmail='" + TextBox5.Text + "',CBusiness='" + TextBox6.Text + "',CComments='" + TextBox7.Text + "' where CID='" + ComboBox1.SelectedItem.ToString() + "'"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            cn.Close()
            MsgBox("Record Updated Successfully", MsgBoxStyle.Information, "Done")
        Else
            MsgBox("Please enter complete details.", MsgBoxStyle.Critical, "Error")
            TextBox2.Focus()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If (ComboBox1.SelectedIndex <> -1) Then
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "delete from Client_Details where CID='" + ComboBox1.SelectedItem.ToString() + "'"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            cn.Close()
            MsgBox("Record Deleted Successfully", MsgBoxStyle.Information, "Done")
            ComboBox1.SelectedIndex = -1
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
        Else
            MsgBox("Please select ID to delete.", MsgBoxStyle.Critical, "Error")
            ComboBox1.Focus()
        End If
    End Sub

End Class