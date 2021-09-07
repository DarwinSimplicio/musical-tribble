Public Class Frm_main



    Private Sub Frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadLabelElement2.Text = xuser
        RadLabelElement4.Text = xmac


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim sss As String

        sss = System.DateTime.Now.ToLongTimeString()

        RadLabelElement5.Text = DateTime.Parse(sss).ToString("hh:mm:ss tt")
    End Sub

    Private Sub CommandBarSeparator1_Click(sender As Object, e As EventArgs) Handles CommandBarSeparator1.Click

    End Sub

    Private Sub RadMenuItem1_Click(sender As Object, e As EventArgs) Handles RadMenuItem1.Click
        Dim xfrm As New Frm_member
        xfrm.Show()
    End Sub

    Private Sub RadMenuItem6_Click(sender As Object, e As EventArgs) Handles RadMenuItem6.Click
        Dim xfrm As New Frm_groupsMain
        xfrm.Show()
    End Sub

    Private Sub RadMenuItem7_Click(sender As Object, e As EventArgs) Handles RadMenuItem7.Click
        Dim xfrm As New Frm_givingsMain
        xfrm.Show()
    End Sub

    Private Sub RadMenuItem11_Click(sender As Object, e As EventArgs) Handles RadMenuItem11.Click
        Dim xfrm As New Frm_batchMain
        xfrm.Show()
    End Sub


    Private Sub RadMenuItem12_Click(sender As Object, e As EventArgs) Handles RadMenuItem12.Click
        Dim xfrm As New Frm_branchMain
        xfrm.Show()
    End Sub

    Private Sub RadMenuItem10_Click(sender As Object, e As EventArgs) Handles RadMenuItem10.Click
        Dim xfrm As New Frm_createGivings
        xfrm.Show()
    End Sub

    Private Sub RadMenuItem3_Click(sender As Object, e As EventArgs) Handles RadMenuItem3.Click
        Dim xfrm As New Frm_ledger
        xfrm.Show()
    End Sub

    Private Sub RadMenuItem8_Click(sender As Object, e As EventArgs) Handles RadMenuItem8.Click
        Dim xfrm As New Frm_login
        xfrm.Show()
        Me.Close()
    End Sub
    Private Sub closeprj()

        'Do Until Process.GetProcessesByName("prjTactical").count < 1
        For Each p As Process In Process.GetProcessesByName("prjPaySys28042021_v02")
            p.Kill()
            p.Close()

        Next

    End Sub
    Private Sub RadMenuItem9_Click(sender As Object, e As EventArgs) Handles RadMenuItem9.Click
        Me.Close()
        Application.Exit()
        closeprj()
    End Sub
End Class
