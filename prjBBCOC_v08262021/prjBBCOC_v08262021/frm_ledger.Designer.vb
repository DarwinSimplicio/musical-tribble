<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ledger
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
        Dim QrCode2 As Telerik.WinControls.UI.Barcode.Symbology.QRCode = New Telerik.WinControls.UI.Barcode.Symbology.QRCode()
        Dim GridViewTextBoxColumn6 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn7 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn8 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn9 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn10 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ledger))
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.rbtn_group1 = New Telerik.WinControls.UI.RadRadioButton()
        Me.lblIdnum = New Telerik.WinControls.UI.RadLabel()
        Me.RadBarcode1 = New Telerik.WinControls.UI.RadBarcode()
        Me.lbl_indicator = New Telerik.WinControls.UI.RadLabel()
        Me.RadToggleSwitch1 = New Telerik.WinControls.UI.RadToggleSwitch()
        Me.rbtn_breakdown = New Telerik.WinControls.UI.RadRadioButton()
        Me.rbtn_group = New Telerik.WinControls.UI.RadRadioButton()
        Me.rbtn_person = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
        Me.dtp_to = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.dtp_from = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.cbo_members = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.RadGridView1 = New Telerik.WinControls.UI.RadGridView()
        Me.btnPrint = New Telerik.WinControls.UI.RadButton()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.rbtn_group1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblIdnum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadBarcode1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl_indicator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadToggleSwitch1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbtn_breakdown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbtn_group, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbtn_person, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox2.SuspendLayout()
        CType(Me.dtp_to, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtp_from, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbo_members, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Controls.Add(Me.rbtn_group1)
        Me.RadGroupBox1.Controls.Add(Me.lblIdnum)
        Me.RadGroupBox1.Controls.Add(Me.RadBarcode1)
        Me.RadGroupBox1.Controls.Add(Me.lbl_indicator)
        Me.RadGroupBox1.Controls.Add(Me.RadToggleSwitch1)
        Me.RadGroupBox1.Controls.Add(Me.rbtn_breakdown)
        Me.RadGroupBox1.Controls.Add(Me.rbtn_group)
        Me.RadGroupBox1.Controls.Add(Me.rbtn_person)
        Me.RadGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
        Me.RadGroupBox1.HeaderMargin = New System.Windows.Forms.Padding(1)
        Me.RadGroupBox1.HeaderText = "Report Specification"
        Me.RadGroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(279, 188)
        Me.RadGroupBox1.TabIndex = 0
        Me.RadGroupBox1.Text = "Report Specification"
        Me.RadGroupBox1.ThemeName = "Crystal"
        '
        'rbtn_group1
        '
        Me.rbtn_group1.Location = New System.Drawing.Point(26, 69)
        Me.rbtn_group1.Name = "rbtn_group1"
        Me.rbtn_group1.Size = New System.Drawing.Size(93, 22)
        Me.rbtn_group1.TabIndex = 1
        Me.rbtn_group1.TabStop = False
        Me.rbtn_group1.Text = "Per Group"
        Me.rbtn_group1.ThemeName = "Crystal"
        '
        'lblIdnum
        '
        Me.lblIdnum.Font = New System.Drawing.Font("Calibri", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdnum.Location = New System.Drawing.Point(165, 125)
        Me.lblIdnum.Name = "lblIdnum"
        Me.lblIdnum.Size = New System.Drawing.Size(10, 13)
        Me.lblIdnum.TabIndex = 19
        Me.lblIdnum.Text = "--"
        Me.lblIdnum.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.lblIdnum.ThemeName = "Crystal"
        '
        'RadBarcode1
        '
        Me.RadBarcode1.Location = New System.Drawing.Point(169, 33)
        Me.RadBarcode1.Name = "RadBarcode1"
        Me.RadBarcode1.Size = New System.Drawing.Size(105, 89)
        QrCode2.Version = 1
        Me.RadBarcode1.Symbology = QrCode2
        Me.RadBarcode1.TabIndex = 20
        Me.RadBarcode1.Text = "RadBarcode1"
        Me.RadBarcode1.Value = "12345"
        '
        'lbl_indicator
        '
        Me.lbl_indicator.Location = New System.Drawing.Point(92, 153)
        Me.lbl_indicator.Name = "lbl_indicator"
        Me.lbl_indicator.Size = New System.Drawing.Size(15, 20)
        Me.lbl_indicator.TabIndex = 3
        Me.lbl_indicator.Text = "--"
        Me.lbl_indicator.ThemeName = "Crystal"
        '
        'RadToggleSwitch1
        '
        Me.RadToggleSwitch1.Location = New System.Drawing.Point(26, 153)
        Me.RadToggleSwitch1.Name = "RadToggleSwitch1"
        Me.RadToggleSwitch1.Size = New System.Drawing.Size(50, 20)
        Me.RadToggleSwitch1.TabIndex = 4
        Me.RadToggleSwitch1.ThemeName = "Crystal"
        Me.RadToggleSwitch1.Value = False
        '
        'rbtn_breakdown
        '
        Me.rbtn_breakdown.Location = New System.Drawing.Point(26, 125)
        Me.rbtn_breakdown.Name = "rbtn_breakdown"
        Me.rbtn_breakdown.Size = New System.Drawing.Size(94, 22)
        Me.rbtn_breakdown.TabIndex = 3
        Me.rbtn_breakdown.TabStop = False
        Me.rbtn_breakdown.Text = "Breakdown"
        Me.rbtn_breakdown.ThemeName = "Crystal"
        '
        'rbtn_group
        '
        Me.rbtn_group.Location = New System.Drawing.Point(26, 97)
        Me.rbtn_group.Name = "rbtn_group"
        Me.rbtn_group.Size = New System.Drawing.Size(84, 22)
        Me.rbtn_group.TabIndex = 2
        Me.rbtn_group.TabStop = False
        Me.rbtn_group.Text = "Summary"
        Me.rbtn_group.ThemeName = "Crystal"
        '
        'rbtn_person
        '
        Me.rbtn_person.CheckState = System.Windows.Forms.CheckState.Checked
        Me.rbtn_person.Location = New System.Drawing.Point(26, 44)
        Me.rbtn_person.Name = "rbtn_person"
        Me.rbtn_person.Size = New System.Drawing.Size(93, 22)
        Me.rbtn_person.TabIndex = 0
        Me.rbtn_person.TabStop = False
        Me.rbtn_person.Text = "Per Person"
        Me.rbtn_person.ThemeName = "Crystal"
        Me.rbtn_person.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.Controls.Add(Me.dtp_to)
        Me.RadGroupBox2.Controls.Add(Me.dtp_from)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel2)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel1)
        Me.RadGroupBox2.Controls.Add(Me.cbo_members)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel6)
        Me.RadGroupBox2.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
        Me.RadGroupBox2.HeaderMargin = New System.Windows.Forms.Padding(1)
        Me.RadGroupBox2.HeaderText = "Selector"
        Me.RadGroupBox2.Location = New System.Drawing.Point(12, 206)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        Me.RadGroupBox2.Size = New System.Drawing.Size(279, 162)
        Me.RadGroupBox2.TabIndex = 1
        Me.RadGroupBox2.Text = "Selector"
        Me.RadGroupBox2.ThemeName = "Crystal"
        '
        'dtp_to
        '
        Me.dtp_to.CalendarSize = New System.Drawing.Size(290, 320)
        Me.dtp_to.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_to.Location = New System.Drawing.Point(148, 117)
        Me.dtp_to.Name = "dtp_to"
        Me.dtp_to.Size = New System.Drawing.Size(120, 24)
        Me.dtp_to.TabIndex = 2
        Me.dtp_to.TabStop = False
        Me.dtp_to.Text = "9/1/2021"
        Me.dtp_to.ThemeName = "Crystal"
        Me.dtp_to.Value = New Date(2021, 9, 1, 1, 19, 52, 932)
        '
        'dtp_from
        '
        Me.dtp_from.CalendarSize = New System.Drawing.Size(290, 320)
        Me.dtp_from.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_from.Location = New System.Drawing.Point(8, 117)
        Me.dtp_from.Name = "dtp_from"
        Me.dtp_from.Size = New System.Drawing.Size(120, 24)
        Me.dtp_from.TabIndex = 1
        Me.dtp_from.TabStop = False
        Me.dtp_from.Text = "9/1/2021"
        Me.dtp_from.ThemeName = "Crystal"
        Me.dtp_from.Value = New Date(2021, 9, 1, 1, 19, 52, 932)
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(148, 91)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(23, 20)
        Me.RadLabel2.TabIndex = 28
        Me.RadLabel2.Text = "To"
        Me.RadLabel2.ThemeName = "Crystal"
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(8, 91)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(39, 20)
        Me.RadLabel1.TabIndex = 27
        Me.RadLabel1.Text = "From"
        Me.RadLabel1.ThemeName = "Crystal"
        '
        'cbo_members
        '
        Me.cbo_members.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbo_members.Location = New System.Drawing.Point(8, 61)
        Me.cbo_members.Name = "cbo_members"
        Me.cbo_members.NullText = "--Select Member--"
        Me.cbo_members.Size = New System.Drawing.Size(260, 24)
        Me.cbo_members.TabIndex = 0
        Me.cbo_members.ThemeName = "Crystal"
        '
        'RadLabel6
        '
        Me.RadLabel6.Location = New System.Drawing.Point(8, 35)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(99, 20)
        Me.RadLabel6.TabIndex = 25
        Me.RadLabel6.Text = "Select Member"
        Me.RadLabel6.ThemeName = "Crystal"
        '
        'RadGridView1
        '
        Me.RadGridView1.Location = New System.Drawing.Point(297, 12)
        '
        '
        '
        Me.RadGridView1.MasterTemplate.AllowAddNewRow = False
        Me.RadGridView1.MasterTemplate.AllowDragToGroup = False
        GridViewTextBoxColumn6.FieldName = "tcode"
        GridViewTextBoxColumn6.HeaderText = "tcode"
        GridViewTextBoxColumn6.IsVisible = False
        GridViewTextBoxColumn6.Name = "tcode"
        GridViewTextBoxColumn7.FieldName = "cdesc"
        GridViewTextBoxColumn7.HeaderText = "DESCRIPTION"
        GridViewTextBoxColumn7.Name = "cdesc"
        GridViewTextBoxColumn7.Width = 250
        GridViewTextBoxColumn7.WrapText = True
        GridViewTextBoxColumn8.FieldName = "tdate"
        GridViewTextBoxColumn8.HeaderText = "TRANS. DATE"
        GridViewTextBoxColumn8.Name = "tdate"
        GridViewTextBoxColumn8.Width = 100
        GridViewTextBoxColumn9.FieldName = "batcode"
        GridViewTextBoxColumn9.HeaderText = "BATCH"
        GridViewTextBoxColumn9.Name = "batcode"
        GridViewTextBoxColumn9.Width = 80
        GridViewTextBoxColumn10.FieldName = "brname"
        GridViewTextBoxColumn10.HeaderText = "BRANCH"
        GridViewTextBoxColumn10.Name = "brname"
        GridViewTextBoxColumn10.Width = 150
        Me.RadGridView1.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn6, GridViewTextBoxColumn7, GridViewTextBoxColumn8, GridViewTextBoxColumn9, GridViewTextBoxColumn10})
        Me.RadGridView1.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.RadGridView1.Name = "RadGridView1"
        Me.RadGridView1.ReadOnly = True
        Me.RadGridView1.Size = New System.Drawing.Size(354, 403)
        Me.RadGridView1.TabIndex = 0
        Me.RadGridView1.ThemeName = "Crystal"
        '
        'btnPrint
        '
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.Location = New System.Drawing.Point(181, 374)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(110, 41)
        Me.btnPrint.TabIndex = 1
        Me.btnPrint.Text = "PRINT"
        Me.btnPrint.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint.ThemeName = "Crystal"
        '
        'Frm_ledger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 468)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.RadGridView1)
        Me.Controls.Add(Me.RadGroupBox2)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.Name = "Frm_ledger"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ledger/Report"
        Me.ThemeName = "Crystal"
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.rbtn_group1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblIdnum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadBarcode1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl_indicator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadToggleSwitch1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbtn_breakdown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbtn_group, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbtn_person, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox2.ResumeLayout(False)
        Me.RadGroupBox2.PerformLayout()
        CType(Me.dtp_to, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtp_from, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbo_members, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPrint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents lbl_indicator As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadToggleSwitch1 As Telerik.WinControls.UI.RadToggleSwitch
    Friend WithEvents rbtn_breakdown As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents rbtn_group As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents rbtn_person As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dtp_to As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents dtp_from As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents cbo_members As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadGridView1 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents btnPrint As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadBarcode1 As Telerik.WinControls.UI.RadBarcode
    Friend WithEvents lblIdnum As Telerik.WinControls.UI.RadLabel
    Friend WithEvents rbtn_group1 As Telerik.WinControls.UI.RadRadioButton
End Class

