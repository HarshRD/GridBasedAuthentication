Public Class frmColorLogin
    
    Private Sub frmColorLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        Dim col1 As New DataColumn("Col1")
        Dim col2 As New DataColumn("Col2")
        Dim col3 As New DataColumn("Col3")
        Dim col4 As New DataColumn("Col4")
        Dim col5 As New DataColumn("Col5")
        Dim col6 As New DataColumn("Col6")
        Dim col7 As New DataColumn("Col7")
        Dim col8 As New DataColumn("Col8")
        dt.Columns.Add(col1)
        dt.Columns.Add(col2)
        dt.Columns.Add(col3)
        dt.Columns.Add(col4)
        dt.Columns.Add(col5)
        dt.Columns.Add(col6)
        dt.Columns.Add(col7)
        dt.Columns.Add(col8)
        Dim dr As DataRow
        Dim Generator As System.Random = New System.Random()
        Dim i As Integer
        For i = 1 To 8 Step 1
            dr = dt.NewRow
            dr(0) = Generator.Next(1, 9)
            dr(1) = Generator.Next(1, 9)
            dr(2) = Generator.Next(1, 9)
            dr(3) = Generator.Next(1, 9)
            dr(4) = Generator.Next(1, 9)
            dr(5) = Generator.Next(1, 9)
            dr(6) = Generator.Next(1, 9)
            dr(7) = Generator.Next(1, 9)
            dt.Rows.Add(dr)
        Next i
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        DataGridView1.DataSource = ds.Tables(0)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
End Class