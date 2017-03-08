Imports System.Data.SqlClient
Public Class frmLogin

    Dim cn As New SqlConnection ' Connect DOT NET with SQL SERVER
    Dim cmd As New SqlCommand ' EXECUTE QUERY
    Dim rs As SqlDataReader 'Fetch Data in Select Query

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Data Source=NIKUL-LAPTOP;Initial Catalog=ColorGrid;Integrated Security=True"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (TextBox1.Text <> "" And TextBox2.Text <> "") Then
            Dim cnt As Integer = 0
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "select count(*) from Admin_Login where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'"
            rs = cmd.ExecuteReader
            While (rs.Read())
                cnt = CInt(rs.GetValue(0).ToString())
            End While
            rs.Close()
            cmd.Dispose()
            cn.Close()
            If (cnt > 0) Then
                frmMain.Show()
                Me.Hide()
            Else
                MsgBox("Invalid Username / Password", MsgBoxStyle.Critical, "Error")
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox1.Focus()
            End If
        Else
            MsgBox("Please enter Username / Password", MsgBoxStyle.Critical, "Error")
            TextBox1.Focus()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        frmColorRegister.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        frmColorLogin.Show()
    End Sub
End Class
