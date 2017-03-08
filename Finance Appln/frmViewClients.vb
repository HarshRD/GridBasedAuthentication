Imports System.Data.SqlClient
Public Class frmViewClients

    Dim cn As New SqlConnection
    Dim ds As New DataSet1

    Private Sub frmViewClients_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Data Source=NIKUL-LAPTOP;Initial Catalog=ColorGrid;Integrated Security=True"
        cn.Open()
        Dim adp As New SqlDataAdapter("select * from Client_Details", cn)
        ds.Tables("Client_Details").Clear()
        adp.Fill(ds.Tables("Client_Details"))
        DataGridView1.DataSource = ds.Tables("Client_Details")
        adp.Dispose()
        cn.Close()
    End Sub
End Class