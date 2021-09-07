Public Class Frm_addGivings
    Dim cls As New clsPrimary
    Private Sub bindMembers()
        Dim dt As New DataTable

        If Not cls._spselect_tbl_member1(dt) Then

            Throw New Exception(cls.errMessage)
        End If

        cbo_members.DisplayMember = "fname"
        cbo_members.ValueMember = "idnum"
        cbo_members.DataSource = dt

    End Sub
    Private Sub bindGridGiving()
        Dim dt As New DataTable
        If Not cls._spselect_tbl_tgiveData2(lblIdnum.Text, lbl_idnum.Text, dt) Then

            Throw New Exception(cls.errMessage)
        End If


        RadGridView1.DataSource = dt

    End Sub
    Private Sub totalCompute()
        Dim gives As Decimal
        For index As Integer = 0 To RadGridView1.RowCount - 1
            gives += Convert.ToDecimal(RadGridView1.Rows(index).Cells(2).Value)

            'if you have the other column to get the result you  could add a new one like these above (just change Cells(2) to the one you added)
        Next
        Me.totAmt.Text = gives
    End Sub
    Private Sub Frm_addGivings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblIdnum.Text = tempNum
        RadBarcode1.Value = tempNum
        Me.Text = tempName
        bindMembers()

        totalCompute()


        
    End Sub

    Private Sub cbo_members_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles cbo_members.SelectedIndexChanged
        Dim dt As New DataTable
        If Not cbo_members.Text = String.Empty Then
            If Not cls._spselect_tbl_member2(cbo_members.SelectedValue, dt) Then

                Throw New Exception(cls.errMessage)
            End If
        End If
        
        Dim idnum, grpdesc As String
        If dt.Rows.Count > 0 Then
            idnum = IIf(IsDBNull(dt.Rows(0).Item("idnum").ToString.Trim) = True, "", dt.Rows(0).Item("idnum").ToString.Trim)
            grpdesc = IIf(IsDBNull(dt.Rows(0).Item("grpdesc").ToString.Trim) = True, "", dt.Rows(0).Item("grpdesc").ToString.Trim)

            lbl_idnum.Text = idnum
            lbl_grpdesc.Text = grpdesc
            bindGridGiving()
            totalCompute()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim amt As Decimal
        Dim nrecno, xcnt As Integer

        xcnt = RadGridView1.Rows.Count
        If Not cls._spdelete_tgiveData(tempNum, Me.lbl_idnum.Text) Then

            Throw New Exception(cls.errMessage)
        End If

        For i = 0 To xcnt - 1
            Try
                nrecno = IIf(IsDBNull(Me.RadGridView1.Rows(i).Cells("nrecno").Value) = True, "", Me.RadGridView1.Rows(i).Cells("nrecno").Value)
                amt = IIf(IsDBNull(Me.RadGridView1.Rows(i).Cells("amount").Value) = True, "", Me.RadGridView1.Rows(i).Cells("amount").Value)

                If Not amt = 0 Then
                    cls._spinsert_tgiveData(tempNum, lbl_idnum.Text, nrecno, amt)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next
        MsgBox("Record Saved.", MsgBoxStyle.Information, "Add Givings")
        bindGridGiving()
    End Sub

    Private Sub RadGridView1_CellValueChanged(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles RadGridView1.CellValueChanged
        If RadGridView1.Rows.Count > 0 Then 'e.RowIndex > -1 Then
            With Me.RadGridView1.Rows(e.RowIndex)
                Dim gives As Decimal
                '5-7
                '4-5
                If Not IsDBNull(.Cells(2).Value) = True Then
                    For index As Integer = 0 To RadGridView1.RowCount - 1
                        gives += Convert.ToDecimal(RadGridView1.Rows(index).Cells(2).Value)

                        'if you have the other column to get the result you  could add a new one like these above (just change Cells(2) to the one you added)
                    Next
                    Me.totAmt.Text = gives
                End If


            End With
        End If
    End Sub

    Private Sub RadGridView1_Click(sender As Object, e As EventArgs) Handles RadGridView1.Click

    End Sub
End Class
