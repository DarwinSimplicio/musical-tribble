Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports System.IO
Imports System.Net
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports Microsoft.Office.Core
Imports Excel = Microsoft.Office.Interop.Excel
Imports ExcelAutoFormat = Microsoft.Office.Interop.Excel.XlRangeAutoFormat
Imports Microsoft.Office.Interop

Imports System.Xml.XPath
Imports System.Data
Imports System.Xml
Public Class Frm_member
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
    Private Sub bindGrp()
        Dim dt As New DataTable
        If Not cls._spselect_tbl_group1(dt) Then

            Throw New Exception(cls.errMessage)
        End If

        cbo_grpnum.DisplayMember = "grpdesc"
        cbo_grpnum.ValueMember = "nrecno"
        cbo_grpnum.DataSource = dt

    End Sub
    Private Sub bindStat()
        Dim dt As New DataTable
        If Not cls._spselect_stat(dt) Then

            Throw New Exception(cls.errMessage)
        End If

        cbo_memStat.DisplayMember = "cdesc"
        cbo_memStat.ValueMember = "nrecno"
        cbo_memStat.DataSource = dt

    End Sub
    Private Sub bindGridMember()
        Dim dt As New DataTable
        If Not cls._spselect_tbl_member1(dt) Then

            Throw New Exception(cls.errMessage)
        End If

        
        RadGridView1.DataSource = dt
        recCnt.Text = dt.Rows.Count
    End Sub
    Private Sub activateForm(xfrm As Boolean)

        Dim cont As Control
        For Each cont In Me.RadPageViewPage2.Controls

            cont.Enabled = xfrm

            If TypeOf cont Is RadTextBoxControl Or TypeOf cont Is RadTextBox Then

                cont.Text = ""
            End If
        Next

    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        addflg = 1
        activateForm(True)
        RadPageView1.SelectedPage = RadPageViewPage2
        btnenabling(2)
    End Sub

    Private Sub Frm_member_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AllowDrop = True
        activateForm(False)
        bindGrp()
        bindStat()
        bindGridMember()
        RadPageView1.SelectedPage = RadPageViewPage1
        btnenabling(1)


    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txt_fname.Text = String.Empty Then
            MsgBox("Full name must not be empty.", MsgBoxStyle.Exclamation, "Add Member")
            txt_fname.Focus()
            Exit Sub
        End If
        If cbo_grpnum.Text = String.Empty Then
            MsgBox("Group must be selected.", MsgBoxStyle.Exclamation, "Add Member")
            cbo_grpnum.Focus()
            Exit Sub
        End If
        If cbo_memStat.Text = String.Empty Then
            MsgBox("Status must be selected.", MsgBoxStyle.Exclamation, "Add Member")
            cbo_memStat.Focus()
            Exit Sub
        End If
        If addflg = 1 Then
            Dim dt As New DataTable
            Dim existCnt As Integer
            If Not cls._spselect_membersIsExists(txt_fname.Text.ToString.Trim, dt) Then

                Throw New Exception(cls.errMessage)
            End If
            If dt.Rows.Count > 0 Then
                existCnt = IIf(IsDBNull(dt.Rows(0).Item("cnt")) = True, 0, dt.Rows(0).Item("cnt"))
                If existCnt > 0 Then
                    MsgBox("DUBLE ENTRY : Member " & txt_fname.Text.ToString.Trim & " is already exist.", MsgBoxStyle.Critical, "Add Member")
                End If
                Exit Sub
            End If
           
            If Not cls._spinsert_tbl_member(Me.txt_fname.Text, Me.cbo_grpnum.SelectedValue, Me.cbo_memStat.SelectedValue) Then

                Throw New Exception(cls.errMessage)
            End If

        Else
            If txt_idno.Text = String.Empty Then
                MsgBox("Select record first.", MsgBoxStyle.Exclamation, "Add Member")
                RadPageView1.SelectedPage = RadPageViewPage1
                Exit Sub
            End If
            If Not cls._spupdate_tbl_member(txt_idno.Text, Me.txt_fname.Text, Me.cbo_grpnum.SelectedValue, cbo_memStat.SelectedIndex) Then

                Throw New Exception(cls.errMessage)
            End If

        End If
        activateForm(False)
        bindGridMember()
        RadPageView1.SelectedPage = RadPageViewPage1
        btnenabling(1)
    End Sub

    Private Sub RadGridView1_CellClick(sender As Object, e As GridViewCellEventArgs) Handles RadGridView1.CellClick

        If TypeOf e.Column Is Telerik.WinControls.UI.GridViewCommandColumn AndAlso e.RowIndex >= 0 Then
            If Not IsDBNull(Me.RadGridView1.Rows(RadGridView1.CurrentRow.Index).Cells(0).Value) Then
                Dim idnum, fname, grpnum, stat As String
                If e.ColumnIndex = 3 Then



                    addflg = 0
                    activateForm(True)
                    btnenabling(3)
                    RadPageView1.SelectedPage = RadPageViewPage2

                    idnum = IIf(IsDBNull(Me.RadGridView1.Rows(RadGridView1.CurrentRow.Index).Cells("idnum").Value) = True, 0, Me.RadGridView1.Rows(RadGridView1.CurrentRow.Index).Cells("idnum").Value)
                    Dim dt As New DataTable
                    If Not cls._spselect_tbl_member2(idnum, dt) Then

                        Throw New Exception(cls.errMessage)
                    End If

                    If dt.Rows.Count > 0 Then
                        fname = IIf(IsDBNull(dt.Rows(0).Item("fname").ToString.Trim) = True, "", dt.Rows(0).Item("fname").ToString.Trim)
                        grpnum = IIf(IsDBNull(dt.Rows(0).Item("grpdesc").ToString.Trim) = True, "", dt.Rows(0).Item("grpdesc").ToString.Trim)
                        stat = IIf(IsDBNull(dt.Rows(0).Item("cdesc").ToString.Trim) = True, "", dt.Rows(0).Item("cdesc").ToString.Trim)

                        txt_idno.Text = idnum
                        txt_fname.Text = fname
                        cbo_grpnum.Text = grpnum
                        cbo_memStat.Text = stat
                    End If
                ElseIf e.ColumnIndex = 4 Then
                    idnum = IIf(IsDBNull(Me.RadGridView1.Rows(RadGridView1.CurrentRow.Index).Cells("idnum").Value) = True, 0, Me.RadGridView1.Rows(RadGridView1.CurrentRow.Index).Cells("idnum").Value)
                    If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo, "Delete Record") = MsgBoxResult.Yes Then
                        If Not cls._spdelete_tbl_member(idnum) Then

                            Throw New Exception(cls.errMessage)
                        End If
                        activateForm(False)
                        btnenabling(1)
                        bindGridMember()
                        RadPageView1.SelectedPage = RadPageViewPage1
                    End If

                End If
            End If
        End If
    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim xfrm As New Frm_member
        xfrm.Show()
        Me.Close()
    End Sub



  

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        Dim OpenFileDialog As New OpenFileDialog

        OpenFileDialog1.FileName = ""
        OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        OpenFileDialog1.Filter = "All Files (*.*)|*.*|Excel files (*.xlsx)|*.xlsx|CSV Files (*.csv)|*.csv|XLS Files (*.xls)|*xls"

        If (OpenFileDialog1.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            RadGridView2.Columns.Clear()
            Dim fi As New FileInfo(OpenFileDialog1.FileName)
            Dim FileName As String = OpenFileDialog1.FileName


            txtPath.Text = fi.FullName

            uploadExelFile()

        End If


    End Sub
    Private Sub uploadExelFile()
        Dim conn As OleDbConnection
        Dim dtr As OleDbDataReader
        Dim dta As OleDbDataAdapter
        Dim cmd As OleDbCommand
        Dim dts As DataSet
        Dim excel As String

        
        excel = txtPath.Text
        If Path.GetExtension(excel) = ".xlsx" Or Path.GetExtension(excel) = ".xls" Or Path.GetExtension(excel) = ".csv" Then
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excel + ";Extended Properties=Excel 12.0;")
            dta = New OleDbDataAdapter("Select [FULL NAME], [GROUP], [STAT] From [Sheet1$]", conn)

            dts = New DataSet
            dta.Fill(dts, "[Sheet1$]")
            RadGridView2.DataSource = dts
            RadGridView2.DataMember = "[Sheet1$]"
            conn.Close()



            lblCnt.Text = RadGridView2.RowCount
            RadGridView2.Focus()
        Else
            MsgBox("Uploading Error : Invalid Filetype.", MsgBoxStyle.Critical, "Bulk Adding of Members")
            Exit Sub
        End If
        
    End Sub

    Private Sub RadPanel1_DragDrop(sender As Object, e As DragEventArgs) Handles RadPanel1.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files
            txtPath.Text = path
            If Not txtPath.Text = String.Empty Then
                RadGridView2.Columns.Clear()
                uploadExelFile()
            End If
        Next
    End Sub

    Private Sub RadPanel1_DragEnter(sender As Object, e As DragEventArgs) Handles RadPanel1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

   
    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        Dim dt As New DataTable
        xdisplay = 1
        x1 = Nothing
        x2 = Nothing
        x3 = Nothing
        x4 = Nothing

        x5 = Nothing
        x6 = Nothing
        x7 = Nothing
        x8 = Nothing
        If Not cls._spselect_rptmembers(dt) Then

            Throw New Exception(cls.errMessage)
        End If
        xdt = dt
        reportname = xpath + "rpt_members.rpt"
        Dim xfrm As New frmreports
        xfrm.ShowDialog()
    End Sub

    Private Sub RadGridView1_Click(sender As Object, e As EventArgs) Handles RadGridView1.Click

    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        BackgroundWorker1.RunWorkerAsync()
        
    End Sub
    Private Sub SetProgressbar(ByVal val As Integer, ByVal progressba As RadProgressBar)
        If progressba.InvokeRequired Then
            progressba.Invoke(New SetProgressbarInvoker(AddressOf SetProgressbar), val, progressba)
        Else
            progressba.Value1 = 0
            progressba.Maximum = val
        End If
    End Sub

    Private Delegate Sub SetProgressbarInvoker(ByVal val As Integer, ByVal progressba As RadProgressBar)
    Private Sub addProgress(ByVal val As Integer, ByVal progressba As RadProgressBar)
        If progressba.InvokeRequired Then
            progressba.Invoke(New addProgressInvoker(AddressOf addProgress), val, progressba)
        Else
            progressba.Value1 += val
        End If
    End Sub
    Private Delegate Sub addProgressInvoker(ByVal val As Integer, ByVal progressba As RadProgressBar)
    Private Sub setGrpbox(ByVal vis As Boolean, ByVal grpbox As RadGroupBox)
        If grpbox.InvokeRequired Then
            grpbox.Invoke(New setGrpboxInvoker(AddressOf setGrpbox), vis, grpbox)
        Else
            grpbox.Visible = vis
        End If

    End Sub
    Private Delegate Sub setGrpboxInvoker(ByVal vis As Boolean, ByVal grpbox As RadGroupBox)
    Private Sub setLabelTxt(ByVal text As String, ByVal lbl As RadProgressBar)
        If lbl.InvokeRequired Then
            lbl.Invoke(New setLabelTxtInvoker(AddressOf setLabelTxt), text, lbl)
        Else
            lbl.Text = text
        End If
    End Sub
    Private Delegate Sub setLabelTxtInvoker(ByVal text As String, ByVal lbl As RadProgressBar)
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim cntrow, grpnum, counted, stat, existCnt As Integer
        Dim fname As String
        cntrow = RadGridView2.RowCount
        counted = 0
        If cntrow > 0 Then
            setGrpbox(True, gb_waiting)
            SetProgressbar(cntrow, RadProgressBar1) 'Sets ProgressBar maximum to number of files
            setLabelTxt("Insert (0/" + cntrow.ToString.Trim + ")", RadProgressBar1) 'displays the amount of copied files
            For i = 0 To cntrow - 1
                fname = IIf(IsDBNull(Me.RadGridView2.Rows(i).Cells(0).Value) = True, "", Me.RadGridView2.Rows(i).Cells(0).Value)
                grpnum = IIf(IsDBNull(Me.RadGridView2.Rows(i).Cells(1).Value) = True, 0, Me.RadGridView2.Rows(i).Cells(1).Value)
                stat = IIf(IsDBNull(Me.RadGridView2.Rows(i).Cells(2).Value) = True, 0, Me.RadGridView2.Rows(i).Cells(2).Value)
                If fname = String.Empty Then
                    MsgBox("Full name must not be empty.", MsgBoxStyle.Exclamation, "Add Member")

                    GoTo skippingPoint
                End If
               
                Dim dt As New DataTable
                If Not cls._spselect_membersIsExists(fname, dt) Then

                    Throw New Exception(cls.errMessage)
                End If
                If dt.Rows.Count > 0 Then
                    existCnt = IIf(IsDBNull(dt.Rows(0).Item("cnt")) = True, 0, dt.Rows(0).Item("cnt"))
                    If existCnt > 0 Then
                        MsgBox("DUBLE ENTRY : Member " & fname & " is already exist.", MsgBoxStyle.Critical, "Add Member")
                    End If
                    GoTo skippingPoint
                End If
                If Not cls._spinsert_tbl_member(fname, grpnum, stat) Then

                    Throw New Exception(cls.errMessage)
                End If

skippingPoint:
                addProgress(1, RadProgressBar1)
                counted += 1
                setLabelTxt("Insert (" + counted.ToString.Trim + "/" + cntrow.ToString.Trim + ")", RadProgressBar1)
            Next
            setGrpbox(False, gb_waiting)
          
        End If
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        activateForm(False)
        RadGridView2.Columns.Clear()
        lblCnt.Text = ""
        txtPath.Text = ""
        bindGridMember()
        RadPageView1.SelectedPage = RadPageViewPage1
        btnenabling(1)
    End Sub
End Class
