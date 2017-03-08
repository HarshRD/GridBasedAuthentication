Imports System.Data.SqlClient
Public Class frmViewAsset
    Dim cn As New SqlConnection
    Dim ds As New DataSet1
    Private Sub frmViewAsset_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Data Source=NIKUL-LAPTOP;Initial Catalog=ColorGrid;Integrated Security=True"
        cn.Open()
        Dim adp As New SqlDataAdapter("select * from Assest", cn)
        'ds.Tables("Assest").Clear()
        adp.Fill(ds.Tables("Assest"))
        DataGridView1.DataSource = ds.Tables("Assest")
        adp.Dispose()
        cn.Close()
    End Sub
End Class