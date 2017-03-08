Public Class frmMain

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewToolStripMenuItem.Click
        frmViewClients.MdiParent = Me
        frmViewClients.Show()
    End Sub

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        frmAddClient.MdiParent = Me
        frmAddClient.Show()
    End Sub

    Private Sub AddToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem1.Click
        frmAddLia.MdiParent = Me
        frmAddLia.Show()
    End Sub

    Private Sub AddToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem2.Click
        frmAddAsset.MdiParent = Me
        frmAddAsset.Show()
    End Sub

    Private Sub ViewToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewToolStripMenuItem1.Click
        frmViewLia.MdiParent = Me
        frmViewLia.Show()
    End Sub

    Private Sub ViewToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewToolStripMenuItem2.Click
        frmViewAsset.MdiParent = Me
        frmViewAsset.Show()
    End Sub

    Private Sub CalcToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalcToolStripMenuItem.Click
        System.Diagnostics.Process.Start("calc.exe")
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateToolStripMenuItem.Click
        frmUDClients.MdiParent = Me
        frmUDClients.TextBox2.ReadOnly = False
        frmUDClients.TextBox3.ReadOnly = False
        frmUDClients.TextBox4.ReadOnly = False
        frmUDClients.TextBox5.ReadOnly = False
        frmUDClients.TextBox6.ReadOnly = False
        frmUDClients.TextBox7.ReadOnly = False
        frmUDClients.Button1.Visible = True
        frmUDClients.Button2.Visible = False
        frmUDClients.Text = "Update Clients Details"
        frmUDClients.Show()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        frmUDClients.MdiParent = Me
        frmUDClients.TextBox2.ReadOnly = True
        frmUDClients.TextBox3.ReadOnly = True
        frmUDClients.TextBox4.ReadOnly = True
        frmUDClients.TextBox5.ReadOnly = True
        frmUDClients.TextBox6.ReadOnly = True
        frmUDClients.TextBox7.ReadOnly = True
        frmUDClients.Button1.Visible = False
        frmUDClients.Button2.Visible = True
        frmUDClients.Text = "Delete Clients Details"
        frmUDClients.Show()
    End Sub

    Private Sub DeleteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem1.Click
        frmDeleteLia.MdiParent = Me
        frmDeleteLia.Show()
    End Sub

    Private Sub DeleteToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem2.Click
        frmDeleteAsset.MdiParent = Me
        frmDeleteAsset.Show()
    End Sub
End Class