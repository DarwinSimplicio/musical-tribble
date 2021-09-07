Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports System.IO
Imports System.Net
Public Class Frm_createGivings
    Dim cls As New clsPrimary
    Private Sub bindBranch()
        Dim dt As New DataTable
        If Not cls._spselect_branch1(dt) Then

            Throw New Exception(cls.errMessage)
        End If

        cbo_branch.DisplayMember = "brname"
        cbo_branch.ValueMember = "nrecno"
        cbo_branch.DataSource = dt

    End Sub
    Private Sub bindBatch()
        Dim dt As New DataTable
        If Not cls._spselect_batch1(dt) Then

            Throw New Exception(cls.errMessage)
        End If

        cbo_batch.DisplayMember = "batcode"
        cbo_batch.ValueMember = "nrecno"
        cbo_batch.DataSource = dt

    End Sub
    Private Sub btnenabling(x As Integer)
        If x = 1 Then '===========DEFAULT
            btnNew.Enabled = True
            btnSave.Enabled = False
            btnCancel.Enabled = False
        ElseIf x = 2 Then '===========ADD NEW
            btnNew.Enabled = False
            btnSave.Enabled = True
            btnCancel.Enabled = True
        ElseIf x = 3 Then '===========EDIT
            btnNew.Enabled = False
            btnSave.Enabled = True
            btnCancel.Enabled = True
        End If
    End Sub

    Private Sub activateForm(xfrm As Boolean)

        Dim cont As Control
        For Each cont In Me.RadPageViewPage2.Controls

            cont.Enabled = xfrm

            If TypeOf cont Is RadTextBoxControl Or TypeOf cont Is RadTextBox Then

                cont.Text = ""
            End If
            If TypeOf cont Is RadDropDownList Then

                cont.Text = ""
            End If

            If TypeOf cont Is RadLabel Then
                If cont.Name = "lblidnum" Then
                    cont.Text = "--"

                End If
                If cont.Name = "lbl_TDay" Then
                    cont.Text = "--"

                End If
            End If
        Next

    End Sub
    Public Sub bindGridGivings()
        Dim dt As New DataTable
        If Not cls._spselect_tgiveHeader1(dt) Then

            Throw New Exception(cls.errMessage)
        End If


        RadGridView1.DataSource = dt
    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        tempNum = xmac & Date.Now.Month & Date.Now.DayOfYear & Date.Now.Year & Date.Now.Hour & Date.Now.Minute & Date.Now.Second & Date.Now.Millisecond
        lblIdnum.Text = tempNum
        addflg = 1
        RadBarcode1.Value = tempNum
        RadPageView1.SelectedPage = RadPageViewPage2
        activateForm(True)
        btnenabling(2)
    End Sub

    Private Sub Frm_createGivings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      
        activateForm(False)
        RadPageView1.SelectedPage = RadPageViewPage1
        bindGridGivings()

        btnenabling(1)
        bindBranch()
        bindBatch()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If dtp_TDate.Text = String.Empty Or lbl_TDay.Text = "--" Then
            MsgBox("Pick a specific date first.", MsgBoxStyle.Exclamation, "Add Givings")
            dtp_TDate.Focus()
            Exit Sub
        End If
        If cbo_batch.Text = String.Empty Then
            MsgBox("Batch must be selected.", MsgBoxStyle.Exclamation, "Add Givings")
            cbo_batch.Focus()
            Exit Sub
        End If
        If txt_desc.Text = String.Empty Then
            MsgBox("Title must not be empty.", MsgBoxStyle.Exclamation, "Add Givings")
            txt_desc.Focus()
            Exit Sub
        End If
        If addflg = 1 Then
            If Not cls._spinsert_tgiveHeader(Me.lblIdnum.Text, Me.dtp_TDate.Text, Me.lbl_TDay.Text, Me.cbo_batch.SelectedValue, Me.cbo_branch.SelectedValue, Me.txt_desc.Text) Then

                Throw New Exception(cls.errMessage)
            End If

        Else
            If lblIdnum.Text = String.Empty Then
                MsgBox("Select record first.", MsgBoxStyle.Exclamation, "Add Givings")
                RadPageView1.SelectedPage = RadPageViewPage1
                Exit Sub
            End If
            If Not cls._spupdate_tgiveHeader(Me.lblIdnum.Text, Me.dtp_TDate.Text, Me.lbl_TDay.Text, Me.cbo_batch.SelectedValue, Me.cbo_branch.SelectedValue, Me.txt_desc.Text) Then

                Throw New Exception(cls.errMessage)
            End If

        End If
        activateForm(False)
        bindGridGivings()
        RadPageView1.SelectedPage = RadPageViewPage1
        btnenabling(1)
    End Sub

    Private Sub RadGridView1_CellClick(sender As Object, e As GridViewCellEventArgs) Handles RadGridView1.CellClick
        If TypeOf e.Column Is Telerik.WinControls.UI.GridViewCommandColumn AndAlso e.RowIndex >= 0 Then
            If Not IsDBNull(Me.RadGridView1.Rows(RadGridView1.CurrentRow.Index).Cells(0).Value) Then
                Dim idnum, cdex, tdate, batch, branch, tday, cdesc As String
                If e.ColumnIndex = 5 Then
                    idnum = IIf(IsDBNull(Me.RadGridView1.Rows(RadGridView1.CurrentRow.Index).Cells("tcode").Value) = True, "", Me.RadGridView1.Rows(RadGridView1.CurrentRow.Index).Cells("tcode").Value)
                    cdex = IIf(IsDBNull(Me.RadGridView1.Rows(RadGridView1.CurrentRow.Index).Cells("cdesc").Value) = True, "", Me.RadGridView1.Rows(RadGridView1.CurrentRow.Index).Cells("cdesc").Value)
                    tempNum = idnum
                    tempName = cdex
                    Dim xfrm As New Frm_addGivings
                    xfrm.Show()
                ElseIf e.ColumnIndex = 6 Then
                    addflg = 0
                    activateForm(True)
                    btnenabling(3)
                    RadPageView1.SelectedPage = RadPageViewPage2
                    idnum = IIf(IsDBNull(Me.RadGridView1.Rows(RadGridView1.CurrentRow.Index).Cells("tcode").Value) = True, "", Me.RadGridView1.Rows(RadGridView1.CurrentRow.Index).Cells("tcode").Value)

                    Dim dt As New DataTable
                    If Not cls._spselect_tgiveHeader2(idnum, dt) Then

                        Throw New Exception(cls.errMessage)
                    End If

                    If dt.Rows.Count > 0 Then
                        tdate = IIf(IsDBNull(dt.Rows(0).Item("tdate").ToString.Trim) = True, "", dt.Rows(0).Item("tdate").ToString.Trim)
                        batch = IIf(IsDBNull(dt.Rows(0).Item("batcode").ToString.Trim) = True, "", dt.Rows(0).Item("batcode").ToString.Trim)
                        branch = IIf(IsDBNull(dt.Rows(0).Item("brname").ToString.Trim) = True, "", dt.Rows(0).Item("brname").ToString.Trim)
                        tday = IIf(IsDBNull(dt.Rows(0).Item("tday").ToString.Trim) = True, "", dt.Rows(0).Item("tday").ToString.Trim)
                        cdesc = IIf(IsDBNull(dt.Rows(0).Item("cdesc").ToString.Trim) = True, "", dt.Rows(0).Item("cdesc").ToString.Trim)

                        RadBarcode1.Value = idnum
                        lblIdnum.Text = idnum
                        txt_desc.Text = cdesc
                        dtp_TDate.Text = tdate
                        lbl_TDay.Text = tday
                        cbo_batch.Text = batch
                        cbo_branch.Text = branch

                    End If
                ElseIf e.ColumnIndex = 7 Then
                    idnum = IIf(IsDBNull(Me.RadGridView1.Rows(RadGridView1.CurrentRow.Index).Cells("tcode").Value) = True, 0, Me.RadGridView1.Rows(RadGridView1.CurrentRow.Index).Cells("tcode").Value)
                    If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo, "Delete Record") = MsgBoxResult.Yes Then
                        If Not cls._spdelete_tgiveHeader(idnum) Then

                            Throw New Exception(cls.errMessage)
                        End If
                        activateForm(False)
                        btnenabling(1)
                        bindGridGivings()
                    End If

                ElseIf e.ColumnIndex = 8 Then
                    idnum = IIf(IsDBNull(Me.RadGridView1.Rows(RadGridView1.CurrentRow.Index).Cells("tcode").Value) = True, 0, Me.RadGridView1.Rows(RadGridView1.CurrentRow.Index).Cells("tcode").Value)
                    Dim dt = New DataTable
                    xdisplay = 1
                    x1 = Nothing
                    x2 = Nothing
                    x3 = Nothing
                    x4 = Nothing

                    x5 = Nothing
                    x6 = Nothing
                    x7 = Nothing
                    x8 = Nothing

                    If Not cls._spselect_daySummary(idnum, dt) Then

                        Throw New Exception(cls.errMessage)
                    End If
                    'If dt.Rows.Count > 0 Then
                    '    Dim sss As String
                    '    sss = IIf(IsDBNull(dt.Rows(0).Item("tdate").ToString.Trim) = True, "", dt.Rows(0).Item("tdate").ToString.Trim)
                    '    MsgBox(sss)
                    'End If

                    xdt = dt
                    reportname = xpath + "rpt_daySummary.rpt"
                    Dim xfrm As New frmreports
                    xfrm.ShowDialog()
                End If

            End If
        End If
    End Sub

 
    Private Sub dtp_TDate_ValueChanged(sender As Object, e As EventArgs) Handles dtp_TDate.ValueChanged
        Dim dy As String
        If dtp_TDate.Value.DayOfWeek = 1 Then
            dy = "Monday"
        ElseIf dtp_TDate.Value.DayOfWeek = 2 Then
            dy = "Tuesday"
        ElseIf dtp_TDate.Value.DayOfWeek = 3 Then
            dy = "Wednesday"
        ElseIf dtp_TDate.Value.DayOfWeek = 4 Then
            dy = "Thursday"
        ElseIf dtp_TDate.Value.DayOfWeek = 5 Then
            dy = "Friday"
        ElseIf dtp_TDate.Value.DayOfWeek = 6 Then
            dy = "Saturday"
        ElseIf dtp_TDate.Value.DayOfWeek = 0 Then
            dy = "Sunday"
        End If
        Me.lbl_TDay.Text = dy
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim xfrm As New Frm_createGivings
        xfrm.Show()
        Me.Close()
    End Sub

    Private Sub RadGridView1_Click(sender As Object, e As EventArgs) Handles RadGridView1.Click

    End Sub
End Class
