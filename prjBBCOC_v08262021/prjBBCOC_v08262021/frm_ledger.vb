Public Class Frm_ledger
    Dim cls As New clsPrimary
    Private Sub radioBtn()
        If rbtn_person.IsChecked = True Then
            cbo_members.Enabled = True
            bindMembers()
            RadLabel6.Text = "Select Member"
        ElseIf rbtn_group1.IsChecked = True Then
            cbo_members.Enabled = True
            bindMembers()
            RadLabel6.Text = "Select Group"
        ElseIf rbtn_group.IsChecked = True Then
            cbo_members.Enabled = False
        ElseIf rbtn_breakdown.IsChecked = True Then
            cbo_members.Enabled = True
            bindMembers()
            RadLabel6.Text = "Select Member"
        End If
    End Sub
    Private Sub switchBehavior()
        If RadToggleSwitch1.Value = False Then
            lbl_indicator.Text = "Length of Time"
            dtp_from.Enabled = True
            dtp_to.Enabled = True
            RadGridView1.Enabled = False
        Else
            lbl_indicator.Text = "Specific Period"
            dtp_from.Enabled = False
            dtp_to.Enabled = False
            RadGridView1.Enabled = True
        End If
    End Sub
    Private Sub bindMembers()
        Dim dt As New DataTable

        
        If rbtn_group1.IsChecked = True Then
            If Not cls._spselect_group1(dt) Then

                Throw New Exception(cls.errMessage)
            End If

            cbo_members.DisplayMember = "grpdesc"
            cbo_members.ValueMember = "nrecno"
            cbo_members.DataSource = dt
        ElseIf rbtn_person.IsChecked = True Or rbtn_group.IsChecked = True Or rbtn_breakdown.IsChecked = True Then
            If Not cls._spselect_tbl_member1(dt) Then

                Throw New Exception(cls.errMessage)
            End If

            cbo_members.DisplayMember = "fname"
            cbo_members.ValueMember = "idnum"
            cbo_members.DataSource = dt
        End If
        

    End Sub
    Public Sub bindGridGivings()
        Dim dt As New DataTable
        If Not cls._spselect_tgiveHeader1(dt) Then

            Throw New Exception(cls.errMessage)
        End If


        RadGridView1.DataSource = dt
    End Sub
    Private Sub RadToggleSwitch1_ValueChanged(sender As Object, e As EventArgs) Handles RadToggleSwitch1.ValueChanged
        switchBehavior()
    End Sub

    Private Sub Frm_ledger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        switchBehavior()
        bindGridGivings()
        bindMembers()
        radioBtn()
    End Sub

    Private Sub rbtn_person_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles rbtn_person.ToggleStateChanged
        radioBtn()
    End Sub

    Private Sub rbtn_group_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles rbtn_group.ToggleStateChanged
        radioBtn()
    End Sub

    Private Sub rbtn_breakdown_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles rbtn_breakdown.ToggleStateChanged
        radioBtn()
    End Sub
    Private Sub RadRadioButton1_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles rbtn_group1.ToggleStateChanged
        radioBtn()
    End Sub
    Dim cdesc As String
    Private Sub RadGridView1_CellClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles RadGridView1.CellClick
        If Not IsDBNull(Me.RadGridView1.Rows(RadGridView1.CurrentRow.Index).Cells(0).Value) Then
            Dim idnum, fname, grpnum As String
            idnum = IIf(IsDBNull(Me.RadGridView1.Rows(RadGridView1.CurrentRow.Index).Cells("tcode").Value) = True, 0, Me.RadGridView1.Rows(RadGridView1.CurrentRow.Index).Cells("tcode").Value)
            cdesc = IIf(IsDBNull(Me.RadGridView1.Rows(RadGridView1.CurrentRow.Index).Cells("cdesc").Value) = True, 0, Me.RadGridView1.Rows(RadGridView1.CurrentRow.Index).Cells("cdesc").Value)

            lblIdnum.Text = idnum
            RadBarcode1.Value = idnum
        End If

    End Sub

    Private Sub printDoc()
        Dim dt As New DataTable

        xdisplay = 1
        x3 = Nothing
        x4 = Nothing
        x5 = Nothing
        x6 = Nothing
        x7 = Nothing
        x8 = Nothing


        If rbtn_person.IsChecked = True Then
            x1 = cbo_members.Text.ToString.Trim
            If RadToggleSwitch1.Value = False Then 'Length of Time
                x2 = "From : " & dtp_from.Text & " | To : " & dtp_to.Text
                'MsgBox(cbo_members.SelectedValue & dtp_from.Value & dtp_to.Value)
                If Not cls._spselect_ledg1(cbo_members.SelectedValue, dtp_from.Text, dtp_to.Text, dt) Then

                    Throw New Exception(cls.errMessage)
                End If

                xdt = dt

            Else 'specific period
                x2 = cdesc
                If Not cls._spselect_ledg2(cbo_members.SelectedValue, lblIdnum.Text, dt) Then

                    Throw New Exception(cls.errMessage)
                End If

                xdt = dt
            End If
            reportname = xpath + "rpt_ledger1.rpt"
            Dim xfrm As New frmreports
            xfrm.ShowDialog()
        ElseIf rbtn_group1.IsChecked = True Then
            x1 = Nothing
            If RadToggleSwitch1.Value = False Then 'Length of Time
                x2 = "From : " & dtp_from.Text & " | To : " & dtp_to.Text
                If Not cls._spselect_ledg7(cbo_members.SelectedValue, dtp_from.Text, dtp_to.Text, dt) Then

                    Throw New Exception(cls.errMessage)
                End If

                xdt = dt
            Else 'specific period
                x2 = cdesc
                If Not cls._spselect_ledg8(cbo_members.SelectedValue, lblIdnum.Text, dt) Then

                    Throw New Exception(cls.errMessage)
                End If

                xdt = dt
            End If
            reportname = xpath + "rpt_ledger4.rpt"
            Dim xfrm As New frmreports
            xfrm.ShowDialog()
        ElseIf rbtn_group.IsChecked = True Then
            x1 = Nothing
            If RadToggleSwitch1.Value = False Then 'Length of Time
                x2 = "From : " & dtp_from.Text & " | To : " & dtp_to.Text
                If Not cls._spselect_ledg3(dtp_from.Text, dtp_to.Text, dt) Then

                    Throw New Exception(cls.errMessage)
                End If

                xdt = dt
            Else 'specific period
                x2 = cdesc
                If Not cls._spselect_ledg4(lblIdnum.Text, dt) Then

                    Throw New Exception(cls.errMessage)
                End If

                xdt = dt
            End If
            reportname = xpath + "rpt_ledger2.rpt"
            Dim xfrm As New frmreports
            xfrm.ShowDialog()
        ElseIf rbtn_breakdown.IsChecked = True Then
            x1 = cbo_members.Text.ToString.Trim
            If RadToggleSwitch1.Value = False Then 'Length of Time
                x2 = "From : " & dtp_from.Text & " | To : " & dtp_to.Text
                If Not cls._spselect_ledg5(cbo_members.SelectedValue, dtp_from.Text, dtp_to.Text, dt) Then

                    Throw New Exception(cls.errMessage)
                End If

                xdt = dt
            Else 'specific period
                x2 = cdesc
                If Not cls._spselect_ledg6(cbo_members.SelectedValue, lblIdnum.Text, dt) Then

                    Throw New Exception(cls.errMessage)
                End If

                xdt = dt
            End If
            reportname = xpath + "rpt_ledger3.rpt"
            Dim xfrm As New frmreports
            xfrm.ShowDialog()
        End If
    End Sub

 
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        
        If rbtn_group1.Text = String.Empty Then
            If cbo_members.Text = String.Empty Then
                MsgBox("There are no active groups yet.", MsgBoxStyle.Exclamation, "Print Ledger")
                Dim xfrm As New Frm_groupsMain
                xfrm.Show()
                Me.Close()
            End If
        Else
            If cbo_members.Text = String.Empty Then
                MsgBox("There are no active members yet.", MsgBoxStyle.Exclamation, "Print Ledger")
                Dim xfrm As New Frm_member
                xfrm.Show()
                Me.Close()
            End If
        End If
        printDoc()
    End Sub

    Private Sub cbo_members_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles cbo_members.SelectedIndexChanged

    End Sub

   
End Class
