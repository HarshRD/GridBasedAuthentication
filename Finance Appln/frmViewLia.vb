Imports System.Data.SqlClient
Public Class frmViewLia
    Dim cn As New SqlConnection
    Dim ds As New DataSet1
    Private Sub frmViewLia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Data Source=NIKUL-LAPTOP;Initial Catalog=ColorGrid;Integrated Security=True"
        cn.Open()
        Dim adp As New SqlDataAdapter("select * from Liablities", cn)
        ds.Tables("Liablities").Clear()
        adp.Fill(ds.Tables("Liablities"))
        DataGridView1.DataSource = ds.Tables("Liablities")
        adp.Dispose()
        cn.Close()
    End Sub
End Class