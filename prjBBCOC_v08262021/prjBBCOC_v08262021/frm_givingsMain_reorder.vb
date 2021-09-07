﻿Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports System.ComponentModel

Public Class Frm_givingsMain_reorder
    Dim cls As New clsPrimary
    'Sub New()
    '    InitializeComponent()
    '    Dim items As BindingList(Of Item) = New BindingList(Of Item)()
    '    For i As Integer = 0 To 5 - 1
    '        items.Add(New Item(i, "Item" & i))
    '    Next
    '    Me.RadGridView1.DataSource = items
    '    Me.RadGridView1.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
    '    Dim gridBehavior As BaseGridBehavior = TryCast(Me.RadGridView1.GridBehavior, BaseGridBehavior)
    '    gridBehavior.UnregisterBehavior(GetType(GridViewDataRowInfo))
    '    gridBehavior.RegisterBehavior(GetType(GridViewDataRowInfo), New CustomGridDataRowBehavior())
    '    Dim svc As RadDragDropService = Me.RadGridView1.GridViewElement.GetService(Of RadDragDropService)()
    '    AddHandler svc.PreviewDragStart, AddressOf svc_PreviewDragStart
    '    AddHandler svc.PreviewDragDrop, AddressOf svc_PreviewDragDrop
    '    AddHandler svc.PreviewDragOver, AddressOf svc_PreviewDragOver
    'End Sub
    'Private Sub svc_PreviewDragStart(ByVal sender As Object, ByVal e As PreviewDragStartEventArgs)
    '    e.CanStart = True
    'End Sub
    'Private Sub svc_PreviewDragOver(ByVal sender As Object, ByVal e As RadDragOverEventArgs)
    '    If TypeOf e.DragInstance Is GridDataRowElement Then
    '        e.CanDrop = TypeOf e.HitTarget Is GridDataRowElement OrElse TypeOf e.HitTarget Is GridTableElement OrElse TypeOf e.HitTarget Is GridSummaryRowElement
    '    End If
    'End Sub
    'Private Sub svc_PreviewDragDrop(ByVal sender As Object, ByVal e As RadDropEventArgs)
    '    Dim rowElement As GridDataRowElement = TryCast(e.DragInstance, GridDataRowElement)
    '    If rowElement Is Nothing Then
    '        Return
    '    End If
    '    e.Handled = True
    '    Dim dropTarget As RadItem = TryCast(e.HitTarget, RadItem)
    '    Dim targetGrid As RadGridView = TryCast(dropTarget.ElementTree.Control, RadGridView)
    '    If targetGrid Is Nothing Then
    '        Return
    '    End If
    '    Dim dragGrid = TryCast(rowElement.ElementTree.Control, RadGridView)
    '    If targetGrid.Equals(dragGrid) Then
    '        e.Handled = True
    '        Dim dropTargetRow As GridDataRowElement = TryCast(dropTarget, GridDataRowElement)
    '        Dim index As Integer = If(dropTargetRow IsNot Nothing, Me.GetTargetRowIndex(dropTargetRow, e.DropLocation), targetGrid.RowCount)
    '        Dim rowToDrag As GridViewRowInfo = dragGrid.SelectedRows(0)
    '        Me.MoveRows(dragGrid, rowToDrag, index)
    '    End If
    'End Sub
    'Private Function GetTargetRowIndex(ByVal row As GridDataRowElement, ByVal dropLocation As Point) As Integer
    '    Dim halfHeight As Integer = row.Size.Height / 2
    '    Dim index As Integer = row.RowInfo.Index
    '    If dropLocation.Y > halfHeight Then
    '        index += 1
    '    End If
    '    Return index
    'End Function
    'Private Sub MoveRows(ByVal dragGrid As RadGridView, ByVal dragRow As GridViewRowInfo, ByVal index As Integer)
    '    dragGrid.BeginUpdate()
    '    Dim row As GridViewRowInfo = dragRow
    '    If TypeOf row Is GridViewSummaryRowInfo Then
    '        Return
    '    End If
    '    If dragGrid.DataSource IsNot Nothing AndAlso GetType(System.Collections.IList).IsAssignableFrom(dragGrid.DataSource.[GetType]()) Then
    '        Dim sourceCollection = CType(dragGrid.DataSource, System.Collections.IList)
    '        If row.Index < index Then
    '            index -= 1
    '        End If
    '        sourceCollection.Remove(row.DataBoundItem)
    '        sourceCollection.Insert(index, row.DataBoundItem)
    '    Else
    '        Throw New ApplicationException("Unhandled Scenario")
    '    End If
    '    dragGrid.EndUpdate(True)
    'End Sub
    'Public Class CustomGridDataRowBehavior
    '    Inherits GridDataRowBehavior
    '    Protected Overrides Function OnMouseDownLeft(ByVal e As MouseEventArgs) As Boolean
    '        Dim row As GridDataRowElement = TryCast(Me.GetRowAtPoint(e.Location), GridDataRowElement)
    '        If row IsNot Nothing Then
    '            Dim svc As RadGridViewDragDropService = Me.GridViewElement.GetService(Of RadGridViewDragDropService)()
    '            svc.AllowAutoScrollColumnsWhileDragging = False
    '            svc.AllowAutoScrollRowsWhileDragging = False
    '            svc.Start(row)
    '        End If
    '        Return MyBase.OnMouseDownLeft(e)
    '    End Function
    'End Class
    'Public Class Item
    '    Public Sub New(ByVal id As Integer, ByVal name As String)
    '        Me.Id = id
    '        Me.Name = name
    '    End Sub
    '    Public Property Id As Integer
    '    Public Property Name As String
    'End Class
    Private Sub bindGridMember()
        Dim dt As New DataTable
        If Not cls._spselect_givings1(dt) Then

            Throw New Exception(cls.errMessage)
        End If


        RadGridView1.DataSource = dt

    End Sub
    Private Sub Frm_givingsMain_reorder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
        bindGridMember()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim nrecno, xcnt, ordPos As Integer
        xcnt = RadGridView1.Rows.Count
        For i = 0 To xcnt - 1
            Try
                nrecno = IIf(IsDBNull(Me.RadGridView1.Rows(i).Cells("nrecno").Value) = True, 0, Me.RadGridView1.Rows(i).Cells("nrecno").Value)
                ordPos = IIf(IsDBNull(Me.RadGridView1.Rows(i).Cells("ordPos").Value) = True, 0, Me.RadGridView1.Rows(i).Cells("ordPos").Value)

                If Not cls._spupdate_givings1(nrecno, ordPos) Then

                    Throw New Exception(cls.errMessage)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next
        MsgBox("Reorder complete.", MsgBoxStyle.Information, "Reorder List")

        Dim xfrm As New Frm_givingsMain
        xfrm.Show()
        Me.Close()
    End Sub

    Private Sub RadGridView1_Click(sender As Object, e As EventArgs) Handles RadGridView1.Click

    End Sub


    Private Sub RadGridView1_DragEnter(sender As Object, e As DragEventArgs) Handles RadGridView1.DragEnter

    End Sub
End Class
