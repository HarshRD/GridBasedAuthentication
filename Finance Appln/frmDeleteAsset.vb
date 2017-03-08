Imports System.Data.SqlClient
Public Class frmDeleteAsset
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand
    Dim rs As SqlDataReader
    Dim ds As New DataSet1
    Private Sub frmDeleteAsset_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Data Source=NIKUL-LAPTOP;Initial Catalog=ColorGrid;Integrated Security=True"
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "select AID from Assest"
        rs = cmd.ExecuteReader()
        While (rs.Read())
            ComboBox1.Items.Add(rs.GetValue(0).ToString())
        End While
        rs.Close()
        cmd.Dispose()
        cn.Close()
        cn.Open()
        Dim adp As New SqlDataAdapter("select * from Assest", cn)
        ds.Tables("Assest").Clear()
        adp.Fill(ds.Tables("Assest"))
        DataGridView1.DataSource = ds.Tables("Assest")
        adp.Dispose()
        cn.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If (ComboBox1.SelectedIndex <> -1) Then
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "select * from Assest where AID='" + ComboBox1.SelectedItem.ToString() + "'"
            rs = cmd.ExecuteReader()
            While (rs.Read())
                TextBox1.Text = rs.GetValue(1).ToString()
                TextBox2.Text = rs.GetValue(2).ToString()
                TextBox3.Text = rs.GetValue(3).ToString()
                TextBox4.Text = rs.GetValue(4).ToString()
                TextBox5.Text = rs.GetValue(5).ToString()
                TextBox6.Text = rs.GetValue(6).ToString()
            End While
            rs.Close()
            cmd.Dispose()
            cn.Close()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ans As DialogResult
        ans = MsgBox("Do you wish to Delete Selected Record ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm")
        If (ans = Windows.Forms.DialogResult.Yes) Then
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "delete from Assest where AID='" + ComboBox1.SelectedItem.ToString() + "'"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            cn.Close()

            cn.Open()
            Dim adp As New SqlDataAdapter("select * from Assest", cn)
            ds.Tables("Assest").Clear()
            adp.Fill(ds.Tables("Assest"))
            DataGridView1.DataSource = ds.Tables("Assest")
            adp.Dispose()
            cn.Close()

            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""

            ComboBox1.Items.Remove(ComboBox1.SelectedItem)

            MsgBox("Record Deleted Successfully", MsgBoxStyle.Information, "Done")
        End If
    End Sub
End Class