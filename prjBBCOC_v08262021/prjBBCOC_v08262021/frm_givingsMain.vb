Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports System.IO
Imports System.Net

Imports System.ComponentModel
Public Class Frm_givingsMain
    Dim cls As New clsPrimary


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
    Public Sub bindGridMember()
        Dim dt As New DataTable
        If Not cls._spselect_givings1(dt) Then

            Throw New Exception(cls.errMessage)
        End If


        RadGridView1.DataSource = dt

    End Sub
    Private Sub activateForm(xfrm As Boolean)

        Dim cont As Control
        For Each cont In Me.RadGroupBox1.Controls

            cont.Enabled = xfrm

            If TypeOf cont Is RadTextBoxControl Or TypeOf cont Is RadTextBox Then

                cont.Text = ""
            End If
            If TypeOf cont Is RadLabel Then
                If cont.Name = "lblidnum" Then
                    cont.Text = "--"

                End If
            End If
        Next

    End Sub

    Private Sub Frm_groupsMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim customService As New CustomDragDropService(RadGridView1.GridViewElement)
        RadGridView1.GridViewElement.RegisterService(customService)
        activateForm(False)

        bindGridMember()

        btnenabling(1)


    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        addflg = 1
        activateForm(True)

        btnenabling(2)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtdesc.Text = String.Empty Then
            MsgBox("Giving name must not be empty.", MsgBoxStyle.Exclamation, "Add Group")
            txtdesc.Focus()
            Exit Sub
        End If
        If addflg = 1 Then
            If Not cls._spinsert_givings(Me.txtdesc.Text) Then

                Throw New Exception(cls.errMessage)
            End If

        Else
            If lblIdnum.Text = String.Empty Then
                MsgBox("Select record first.", MsgBoxStyle.Exclamation, "Add Group")
                Exit Sub
            End If
            If Not cls._spupdate_givings(lblIdnum.Text, Me.txtdesc.Text) Then

                Throw New Exception(cls.errMessage)
            End If

        End If
        activateForm(False)
        bindGridMember()

        btnenabling(1)
    End Sub

    Private Sub RadGridView1_CellClick(sender As Object, e As GridViewCellEventArgs) Handles RadGridView1.CellClick
        If TypeOf e.Column Is Telerik.WinControls.UI.GridViewCommandColumn AndAlso e.RowIndex >= 0 Then
            If Not IsDBNull(Me.RadGridView1.Rows(RadGridView1.CurrentRow.Index).Cells(0).Value) Then
                Dim idnum, cdesc As String
                If e.ColumnIndex = 2 Then



                    addflg = 0
                    activateForm(True)
                    btnenabling(3)

                    idnum = IIf(IsDBNull(Me.RadGridView1.Rows(RadGridView1.CurrentRow.Index).Cells("nrecno").Value) = True, 0, Me.RadGridView1.Rows(RadGridView1.CurrentRow.Index).Cells("nrecno").Value)

                    Dim dt As New DataTable
                    If Not cls._spselect_givings2(idnum, dt) Then

                        Throw New Exception(cls.errMessage)
                    End If

                    If dt.Rows.Count > 0 Then
                        cdesc = IIf(IsDBNull(dt.Rows(0).Item("cdesc").ToString.Trim) = True, "", dt.Rows(0).Item("cdesc").ToString.Trim)


                        lblIdnum.Text = idnum
                        txtdesc.Text = cdesc

                    End If
                ElseIf e.ColumnIndex = 3 Then
                    idnum = IIf(IsDBNull(Me.RadGridView1.Rows(RadGridView1.CurrentRow.Index).Cells("nrecno").Value) = True, 0, Me.RadGridView1.Rows(RadGridView1.CurrentRow.Index).Cells("nrecno").Value)
                    If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo, "Delete Record") = MsgBoxResult.Yes Then
                        If Not cls._spdelete_givings(idnum) Then

                            Throw New Exception(cls.errMessage)
                        End If
                        activateForm(False)
                        btnenabling(1)
                        bindGridMember()

                    End If

                End If
            End If
        End If
    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim xfrm As New Frm_givingsMain
        xfrm.Show()
        Me.Close()
    End Sub

    Private Sub RadGridView1_Click(sender As Object, e As EventArgs) Handles RadGridView1.Click

    End Sub

 
    Private Sub btn_reOrder_Click(sender As Object, e As EventArgs) Handles btn_reOrder.Click
        Dim xfrm As New Frm_givingsMain_reorder
        xfrm.Show()
        Me.Close()
    End Sub
End Class
