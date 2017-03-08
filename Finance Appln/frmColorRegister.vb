Imports System.Data.SqlClient

Public Class frmColorRegister

    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand
    Dim rs As SqlDataReader

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (TextBox1.Text = "") Then
            MsgBox("Enter Value between 1 - 8", MsgBoxStyle.Critical, "Error")
            TextBox1.Focus()
        ElseIf (TextBox2.Text = "") Then
            MsgBox("Enter Value between 1 - 8", MsgBoxStyle.Critical, "Error")
            TextBox2.Focus()
        ElseIf (TextBox3.Text = "") Then
            MsgBox("Enter Value between 1 - 8", MsgBoxStyle.Critical, "Error")
            TextBox3.Focus()
        ElseIf (TextBox4.Text = "") Then
            MsgBox("Enter Value between 1 - 8", MsgBoxStyle.Critical, "Error")
            TextBox4.Focus()
        ElseIf (TextBox5.Text = "") Then
            MsgBox("Enter Value between 1 - 8", MsgBoxStyle.Critical, "Error")
            TextBox5.Focus()
        ElseIf (TextBox6.Text = "") Then
            MsgBox("Enter Value between 1 - 8", MsgBoxStyle.Critical, "Error")
            TextBox6.Focus()
        ElseIf (TextBox7.Text = "") Then
            MsgBox("Enter Value between 1 - 8", MsgBoxStyle.Critical, "Error")
            TextBox7.Focus()
        ElseIf (TextBox8.Text = "") Then
            MsgBox("Enter Value between 1 - 8", MsgBoxStyle.Critical, "Error")
            TextBox8.Focus()
        Else
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "insert into ColorLogin values('Admin','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "')"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            cn.Close()

            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            TextBox8.Text = ""

            MsgBox("Values saved to Database", MsgBoxStyle.Information, "Done")

        End If
    End Sub

    Private Sub frmColorRegister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Data Source=NIKUL-LAPTOP;Initial Catalog=ColorGrid;Integrated Security=True"
    End Sub
End Class