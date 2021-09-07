<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_createGivings
    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewDateTimeColumn1 As Telerik.WinControls.UI.GridViewDateTimeColumn = New Telerik.WinControls.UI.GridViewDateTimeColumn()
        Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewCommandColumn1 As Telerik.WinControls.UI.GridViewCommandColumn = New Telerik.WinControls.UI.GridViewCommandColumn()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_createGivings))
        Dim GridViewCommandColumn2 As Telerik.WinControls.UI.GridViewCommandColumn = New Telerik.WinControls.UI.GridViewCommandColumn()
        Dim GridViewCommandColumn3 As Telerik.WinControls.UI.GridViewCommandColumn = New Telerik.WinControls.UI.GridViewCommandColumn()
        Dim GridViewCommandColumn4 As Telerik.WinControls.UI.GridViewCommandColumn = New Telerik.WinControls.UI.GridViewCommandColumn()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim QrCode1 As Telerik.WinControls.UI.Barcode.Symbology.QRCode = New Telerik.WinControls.UI.Barcode.Symbology.QRCode()
        Me.RadPageView1 = New Telerik.WinControls.UI.RadPageView()
        Me.RadPageViewPage1 = New Telerik.WinControls.UI.RadPageViewPage()
        Me.RadGridView1 = New Telerik.WinControls.UI.RadGridView()
        Me.RadPageViewPage2 = New Telerik.WinControls.UI.RadPageViewPage()
        Me.RadBarcode1 = New Telerik.WinControls.UI.RadBarcode()
        Me.RadLabel7 = New Telerik.WinControls.UI.RadLabel()
        Me.txt_desc = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.cbo_branch = New Telerik.WinControls.UI.RadDropDownList()
        Me.cbo_batch = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.lbl_TDay = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.dtp_TDate = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.lblIdnum = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.btnCancel = New Telerik.WinControls.UI.RadButton()
        Me.btnSave = New Telerik.WinControls.UI.RadButton()
        Me.btnNew = New Telerik.WinControls.UI.RadButton()
        CType(Me.RadPageView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPageView1.SuspendLayout()
        Me.RadPageViewPage1.SuspendLayout()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPageViewPage2.SuspendLayout()
        CType(Me.RadBarcode1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_desc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbo_branch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbo_batch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl_TDay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtp_TDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblIdnum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadPageView1
        '
        Me.RadPageView1.Controls.Add(Me.RadPageViewPage1)
        Me.RadPageView1.Controls.Add(Me.RadPageViewPage2)
        Me.RadPageView1.Location = New System.Drawing.Point(0, 12)
        Me.RadPageView1.Name = "RadPageView1"
        Me.RadPageView1.SelectedPage = Me.RadPageViewPage1
        Me.RadPageView1.Size = New System.Drawing.Size(720, 315)
        Me.RadPageView1.TabIndex = 0
        Me.RadPageView1.ThemeName = "Crystal"
        CType(Me.RadPageView1.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).StripButtons = Telerik.WinControls.UI.StripViewButtons.None
        '
        'RadPageViewPage1
        '
        Me.RadPageViewPage1.Controls.Add(Me.RadGridView1)
        Me.RadPageViewPage1.ItemSize = New System.Drawing.SizeF(37.0!, 28.0!)
        Me.RadPageViewPage1.Location = New System.Drawing.Point(6, 33)
        Me.RadPageViewPage1.Name = "RadPageViewPage1"
        Me.RadPageViewPage1.Size = New System.Drawing.Size(708, 275)
        Me.RadPageViewPage1.Text = "List"
        '
        'RadGridView1
        '
        Me.RadGridView1.Location = New System.Drawing.Point(0, 3)
        '
        '
        '
        Me.RadGridView1.MasterTemplate.AllowAddNewRow = False
        Me.RadGridView1.MasterTemplate.AllowDragToGroup = False
        GridViewTextBoxColumn1.FieldName = "tcode"
        GridViewTextBoxColumn1.HeaderText = "column1"
        GridViewTextBoxColumn1.IsVisible = False
        GridViewTextBoxColumn1.Name = "tcode"
        GridViewTextBoxColumn2.FieldName = "cdesc"
        GridViewTextBoxColumn2.HeaderText = "Description"
        GridViewTextBoxColumn2.Name = "cdesc"
        GridViewTextBoxColumn2.Width = 230
        GridViewTextBoxColumn2.WrapText = True
        GridViewDateTimeColumn1.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.ShortDate
        GridViewDateTimeColumn1.FieldName = "tdate"
        GridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        GridViewDateTimeColumn1.HeaderText = "Transaction Date"
        GridViewDateTimeColumn1.Name = "tdate"
        GridViewDateTimeColumn1.Width = 100
        GridViewDateTimeColumn1.WrapText = True
        GridViewTextBoxColumn3.FieldName = "tday"
        GridViewTextBoxColumn3.HeaderText = "Day"
        GridViewTextBoxColumn3.Name = "tday"
        GridViewTextBoxColumn3.Width = 80
        GridViewTextBoxColumn4.FieldName = "batcode"
        GridViewTextBoxColumn4.HeaderText = "Batch"
        GridViewTextBoxColumn4.Name = "batcode"
        GridViewTextBoxColumn4.Width = 80
        GridViewCommandColumn1.HeaderText = "ADD"
        GridViewCommandColumn1.Image = CType(resources.GetObject("GridViewCommandColumn1.Image"), System.Drawing.Image)
        GridViewCommandColumn1.Name = "column3"
        GridViewCommandColumn1.StretchVertically = False
        GridViewCommandColumn2.HeaderText = "EDIT"
        GridViewCommandColumn2.Image = CType(resources.GetObject("GridViewCommandColumn2.Image"), System.Drawing.Image)
        GridViewCommandColumn2.Name = "column1"
        GridViewCommandColumn2.StretchVertically = False
        GridViewCommandColumn3.HeaderText = "DEL"
        GridViewCommandColumn3.Image = CType(resources.GetObject("GridViewCommandColumn3.Image"), System.Drawing.Image)
        GridViewCommandColumn3.Name = "column2"
        GridViewCommandColumn3.StretchVertically = False
        GridViewCommandColumn4.HeaderText = "PRINT"
        GridViewCommandColumn4.Image = CType(resources.GetObject("GridViewCommandColumn4.Image"), System.Drawing.Image)
        GridViewCommandColumn4.Name = "column4"
        Me.RadGridView1.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewDateTimeColumn1, GridViewTextBoxColumn3, GridViewTextBoxColumn4, GridViewCommandColumn1, GridViewCommandColumn2, GridViewCommandColumn3, GridViewCommandColumn4})
        Me.RadGridView1.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.RadGridView1.Name = "RadGridView1"
        Me.RadGridView1.ReadOnly = True
        Me.RadGridView1.Size = New System.Drawing.Size(711, 272)
        Me.RadGridView1.TabIndex = 0
        Me.RadGridView1.ThemeName = "Crystal"
        '
        'RadPageViewPage2
        '
        Me.RadPageViewPage2.Controls.Add(Me.RadBarcode1)
        Me.RadPageViewPage2.Controls.Add(Me.RadLabel7)
        Me.RadPageViewPage2.Controls.Add(Me.txt_desc)
        Me.RadPageViewPage2.Controls.Add(Me.cbo_branch)
        Me.RadPageViewPage2.Controls.Add(Me.cbo_batch)
        Me.RadPageViewPage2.Controls.Add(Me.RadLabel6)
        Me.RadPageViewPage2.Controls.Add(Me.RadLabel5)
        Me.RadPageViewPage2.Controls.Add(Me.lbl_TDay)
        Me.RadPageViewPage2.Controls.Add(Me.RadLabel4)
        Me.RadPageViewPage2.Controls.Add(Me.dtp_TDate)
        Me.RadPageViewPage2.Controls.Add(Me.RadLabel2)
        Me.RadPageViewPage2.Controls.Add(Me.lblIdnum)
        Me.RadPageViewPage2.Controls.Add(Me.RadLabel1)
        Me.RadPageViewPage2.ItemSize = New System.Drawing.SizeF(57.0!, 28.0!)
        Me.RadPageViewPage2.Location = New System.Drawing.Point(6, 33)
        Me.RadPageViewPage2.Name = "RadPageViewPage2"
        Me.RadPageViewPage2.Size = New System.Drawing.Size(708, 275)
        Me.RadPageViewPage2.Text = "Details"
        '
        'RadBarcode1
        '
        Me.RadBarcode1.Location = New System.Drawing.Point(574, 3)
        Me.RadBarcode1.Name = "RadBarcode1"
        Me.RadBarcode1.Size = New System.Drawing.Size(126, 118)
        QrCode1.Version = 1
        Me.RadBarcode1.Symbology = QrCode1
        Me.RadBarcode1.TabIndex = 25
        Me.RadBarcode1.Text = "RadBarcode1"
        Me.RadBarcode1.Value = "12345"
        '
        'RadLabel7
        '
        Me.RadLabel7.Location = New System.Drawing.Point(357, 120)
        Me.RadLabel7.Name = "RadLabel7"
        Me.RadLabel7.Size = New System.Drawing.Size(151, 20)
        Me.RadLabel7.TabIndex = 24
        Me.RadLabel7.Text = "Title/Notes/Description"
        Me.RadLabel7.ThemeName = "Crystal"
        '
        'txt_desc
        '
        Me.txt_desc.Location = New System.Drawing.Point(357, 146)
        Me.txt_desc.Multiline = True
        Me.txt_desc.Name = "txt_desc"
        Me.txt_desc.Size = New System.Drawing.Size(322, 90)
        Me.txt_desc.TabIndex = 23
        Me.txt_desc.ThemeName = "Crystal"
        '
        'cbo_branch
        '
        Me.cbo_branch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbo_branch.Location = New System.Drawing.Point(148, 209)
        Me.cbo_branch.Name = "cbo_branch"
        Me.cbo_branch.NullText = "--Select Branch--"
        Me.cbo_branch.Size = New System.Drawing.Size(189, 24)
        Me.cbo_branch.TabIndex = 22
        Me.cbo_branch.ThemeName = "Crystal"
        '
        'cbo_batch
        '
        Me.cbo_batch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbo_batch.Location = New System.Drawing.Point(6, 209)
        Me.cbo_batch.Name = "cbo_batch"
        Me.cbo_batch.NullText = "--Select Batch--"
        Me.cbo_batch.Size = New System.Drawing.Size(125, 24)
        Me.cbo_batch.TabIndex = 20
        Me.cbo_batch.ThemeName = "Crystal"
        '
        'RadLabel6
        '
        Me.RadLabel6.Location = New System.Drawing.Point(148, 183)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(50, 20)
        Me.RadLabel6.TabIndex = 21
        Me.RadLabel6.Text = "Branch"
        Me.RadLabel6.ThemeName = "Crystal"
        '
        'RadLabel5
        '
        Me.RadLabel5.Location = New System.Drawing.Point(6, 183)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(42, 20)
        Me.RadLabel5.TabIndex = 19
        Me.RadLabel5.Text = "Batch"
        Me.RadLabel5.ThemeName = "Crystal"
        '
        'lbl_TDay
        '
        Me.lbl_TDay.Location = New System.Drawing.Point(6, 120)
        Me.lbl_TDay.Name = "lbl_TDay"
        Me.lbl_TDay.Size = New System.Drawing.Size(15, 20)
        Me.lbl_TDay.TabIndex = 18
        Me.lbl_TDay.Text = "--"
        Me.lbl_TDay.ThemeName = "Crystal"
        '
        'RadLabel4
        '
        Me.RadLabel4.Location = New System.Drawing.Point(6, 94)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(30, 20)
        Me.RadLabel4.TabIndex = 17
        Me.RadLabel4.Text = "Day"
        Me.RadLabel4.ThemeName = "Crystal"
        '
        'dtp_TDate
        '
        Me.dtp_TDate.CalendarSize = New System.Drawing.Size(290, 320)
        Me.dtp_TDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_TDate.Location = New System.Drawing.Point(6, 52)
        Me.dtp_TDate.Name = "dtp_TDate"
        Me.dtp_TDate.Size = New System.Drawing.Size(149, 24)
        Me.dtp_TDate.TabIndex = 16
        Me.dtp_TDate.TabStop = False
        Me.dtp_TDate.Text = "8/31/2021"
        Me.dtp_TDate.ThemeName = "Crystal"
        Me.dtp_TDate.Value = New Date(2021, 8, 31, 0, 58, 39, 953)
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(6, 26)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(111, 20)
        Me.RadLabel2.TabIndex = 15
        Me.RadLabel2.Text = "Transaction Date"
        Me.RadLabel2.ThemeName = "Crystal"
        '
        'lblIdnum
        '
        Me.lblIdnum.Location = New System.Drawing.Point(357, 52)
        Me.lblIdnum.Name = "lblIdnum"
        Me.lblIdnum.Size = New System.Drawing.Size(15, 20)
        Me.lblIdnum.TabIndex = 15
        Me.lblIdnum.Text = "--"
        Me.lblIdnum.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.lblIdnum.ThemeName = "Crystal"
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(357, 26)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadLabel1.Size = New System.Drawing.Size(72, 20)
        Me.RadLabel1.TabIndex = 14
        Me.RadLabel1.Text = "ID Number"
        Me.RadLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight
        Me.RadLabel1.ThemeName = "Crystal"
        '
        'btnCancel
        '
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(621, 333)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 36)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.ThemeName = "Crystal"
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(520, 333)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(96, 36)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.ThemeName = "Crystal"
        '
        'btnNew
        '
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.Location = New System.Drawing.Point(418, 333)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(96, 36)
        Me.btnNew.TabIndex = 4
        Me.btnNew.Text = "Add New"
        Me.btnNew.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNew.ThemeName = "Crystal"
        '
        'Frm_createGivings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 377)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.RadPageView1)
        Me.Name = "Frm_createGivings"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create Givings"
        Me.ThemeName = "Crystal"
        CType(Me.RadPageView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPageView1.ResumeLayout(False)
        Me.RadPageViewPage1.ResumeLayout(False)
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPageViewPage2.ResumeLayout(False)
        Me.RadPageViewPage2.PerformLayout()
        CType(Me.RadBarcode1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_desc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbo_branch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbo_batch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl_TDay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtp_TDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblIdnum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadPageView1 As Telerik.WinControls.UI.RadPageView
    Friend WithEvents RadPageViewPage1 As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents RadPageViewPage2 As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents btnCancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnNew As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadGridView1 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents lblIdnum As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lbl_TDay As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dtp_TDate As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents cbo_branch As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents cbo_batch As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadBarcode1 As Telerik.WinControls.UI.RadBarcode
    Friend WithEvents RadLabel7 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txt_desc As Telerik.WinControls.UI.RadTextBoxControl
End Class

