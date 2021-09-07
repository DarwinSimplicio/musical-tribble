<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_addGivings
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
        Dim QrCode1 As Telerik.WinControls.UI.Barcode.Symbology.QRCode = New Telerik.WinControls.UI.Barcode.Symbology.QRCode()
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewDecimalColumn1 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim ExpressionFormattingObject1 As Telerik.WinControls.UI.ExpressionFormattingObject = New Telerik.WinControls.UI.ExpressionFormattingObject()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_addGivings))
        Me.lblIdnum = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.cbo_members = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.RadBarcode1 = New Telerik.WinControls.UI.RadBarcode()
        Me.RadGridView1 = New Telerik.WinControls.UI.RadGridView()
        Me.btnSave = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.lbl_idnum = New Telerik.WinControls.UI.RadLabel()
        Me.lbl_grpdesc = New Telerik.WinControls.UI.RadLabel()
        Me.totAmt = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.RadGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
        CType(Me.lblIdnum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.cbo_members, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadBarcode1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl_idnum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl_grpdesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.totAmt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox2.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblIdnum
        '
        Me.lblIdnum.Location = New System.Drawing.Point(5, 60)
        Me.lblIdnum.Name = "lblIdnum"
        Me.lblIdnum.Size = New System.Drawing.Size(15, 20)
        Me.lblIdnum.TabIndex = 17
        Me.lblIdnum.Text = "--"
        Me.lblIdnum.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.lblIdnum.ThemeName = "Crystal"
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(5, 34)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadLabel1.Size = New System.Drawing.Size(72, 20)
        Me.RadLabel1.TabIndex = 16
        Me.RadLabel1.Text = "ID Number"
        Me.RadLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight
        Me.RadLabel1.ThemeName = "Crystal"
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Controls.Add(Me.cbo_members)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel6)
        Me.RadGroupBox1.Controls.Add(Me.RadBarcode1)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel1)
        Me.RadGroupBox1.Controls.Add(Me.lblIdnum)
        Me.RadGroupBox1.HeaderMargin = New System.Windows.Forms.Padding(1)
        Me.RadGroupBox1.HeaderText = "General Info"
        Me.RadGroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(354, 145)
        Me.RadGroupBox1.TabIndex = 18
        Me.RadGroupBox1.Text = "General Info"
        Me.RadGroupBox1.ThemeName = "Crystal"
        '
        'cbo_members
        '
        Me.cbo_members.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbo_members.Location = New System.Drawing.Point(5, 112)
        Me.cbo_members.Name = "cbo_members"
        Me.cbo_members.NullText = "--Select Member--"
        Me.cbo_members.Size = New System.Drawing.Size(211, 24)
        Me.cbo_members.TabIndex = 24
        Me.cbo_members.ThemeName = "Crystal"
        '
        'RadLabel6
        '
        Me.RadLabel6.Location = New System.Drawing.Point(5, 86)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(99, 20)
        Me.RadLabel6.TabIndex = 23
        Me.RadLabel6.Text = "Select Member"
        Me.RadLabel6.ThemeName = "Crystal"
        '
        'RadBarcode1
        '
        Me.RadBarcode1.Location = New System.Drawing.Point(222, 21)
        Me.RadBarcode1.Name = "RadBarcode1"
        Me.RadBarcode1.Size = New System.Drawing.Size(127, 115)
        QrCode1.Version = 1
        Me.RadBarcode1.Symbology = QrCode1
        Me.RadBarcode1.TabIndex = 18
        Me.RadBarcode1.Text = "RadBarcode1"
        Me.RadBarcode1.Value = "12345"
        '
        'RadGridView1
        '
        Me.RadGridView1.EnableKeyMap = True
        Me.RadGridView1.EnterKeyMode = Telerik.WinControls.UI.RadGridViewEnterKeyMode.EnterMovesToNextRow
        Me.RadGridView1.Location = New System.Drawing.Point(372, 12)
        '
        '
        '
        Me.RadGridView1.MasterTemplate.AllowAddNewRow = False
        Me.RadGridView1.MasterTemplate.AllowDragToGroup = False
        Me.RadGridView1.MasterTemplate.AllowSearchRow = True
        GridViewTextBoxColumn1.FieldName = "nrecno"
        GridViewTextBoxColumn1.HeaderText = "column1"
        GridViewTextBoxColumn1.IsVisible = False
        GridViewTextBoxColumn1.Name = "nrecno"
        GridViewTextBoxColumn2.FieldName = "cdesc"
        GridViewTextBoxColumn2.HeaderText = "GIVINGS"
        GridViewTextBoxColumn2.Name = "cdesc"
        GridViewTextBoxColumn2.ReadOnly = True
        GridViewTextBoxColumn2.Width = 150
        GridViewTextBoxColumn2.WrapText = True
        ExpressionFormattingObject1.CellBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        ExpressionFormattingObject1.CellForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        ExpressionFormattingObject1.Expression = "amount>0"
        ExpressionFormattingObject1.Name = "NewCondition"
        ExpressionFormattingObject1.RowBackColor = System.Drawing.Color.Empty
        ExpressionFormattingObject1.RowForeColor = System.Drawing.Color.Empty
        GridViewDecimalColumn1.ConditionalFormattingObjectList.Add(ExpressionFormattingObject1)
        GridViewDecimalColumn1.EnableExpressionEditor = True
        GridViewDecimalColumn1.Expression = ""
        GridViewDecimalColumn1.FieldName = "amount"
        GridViewDecimalColumn1.HeaderText = "Amount"
        GridViewDecimalColumn1.Name = "amount"
        GridViewDecimalColumn1.ShowUpDownButtons = False
        GridViewDecimalColumn1.ThousandsSeparator = True
        GridViewDecimalColumn1.Width = 100
        Me.RadGridView1.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewDecimalColumn1})
        Me.RadGridView1.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.RadGridView1.Name = "RadGridView1"
        Me.RadGridView1.Size = New System.Drawing.Size(297, 376)
        Me.RadGridView1.TabIndex = 19
        Me.RadGridView1.ThemeName = "Crystal"
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(247, 352)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(119, 36)
        Me.btnSave.TabIndex = 20
        Me.btnSave.Text = "Save Table"
        Me.btnSave.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.ThemeName = "Crystal"
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(30, 44)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(74, 20)
        Me.RadLabel2.TabIndex = 24
        Me.RadLabel2.Text = "Member ID"
        Me.RadLabel2.ThemeName = "Crystal"
        '
        'RadLabel3
        '
        Me.RadLabel3.Location = New System.Drawing.Point(30, 102)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(98, 20)
        Me.RadLabel3.TabIndex = 25
        Me.RadLabel3.Text = "Member Group"
        Me.RadLabel3.ThemeName = "Crystal"
        '
        'lbl_idnum
        '
        Me.lbl_idnum.Location = New System.Drawing.Point(41, 70)
        Me.lbl_idnum.Name = "lbl_idnum"
        Me.lbl_idnum.Size = New System.Drawing.Size(15, 20)
        Me.lbl_idnum.TabIndex = 26
        Me.lbl_idnum.Text = "--"
        Me.lbl_idnum.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.lbl_idnum.ThemeName = "Crystal"
        '
        'lbl_grpdesc
        '
        Me.lbl_grpdesc.Location = New System.Drawing.Point(41, 128)
        Me.lbl_grpdesc.Name = "lbl_grpdesc"
        Me.lbl_grpdesc.Size = New System.Drawing.Size(15, 20)
        Me.lbl_grpdesc.TabIndex = 27
        Me.lbl_grpdesc.Text = "--"
        Me.lbl_grpdesc.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.lbl_grpdesc.ThemeName = "Crystal"
        '
        'totAmt
        '
        Me.totAmt.Location = New System.Drawing.Point(258, 70)
        Me.totAmt.Name = "totAmt"
        Me.totAmt.Size = New System.Drawing.Size(15, 20)
        Me.totAmt.TabIndex = 29
        Me.totAmt.Text = "--"
        Me.totAmt.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.totAmt.ThemeName = "Crystal"
        '
        'RadLabel5
        '
        Me.RadLabel5.Location = New System.Drawing.Point(247, 44)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(90, 20)
        Me.RadLabel5.TabIndex = 28
        Me.RadLabel5.Text = "Total Amount"
        Me.RadLabel5.ThemeName = "Crystal"
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.Controls.Add(Me.RadLabel2)
        Me.RadGroupBox2.Controls.Add(Me.totAmt)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel3)
        Me.RadGroupBox2.Controls.Add(Me.lbl_grpdesc)
        Me.RadGroupBox2.Controls.Add(Me.lbl_idnum)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel5)
        Me.RadGroupBox2.HeaderMargin = New System.Windows.Forms.Padding(1)
        Me.RadGroupBox2.HeaderText = "Member's Info"
        Me.RadGroupBox2.Location = New System.Drawing.Point(12, 163)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        Me.RadGroupBox2.Size = New System.Drawing.Size(349, 183)
        Me.RadGroupBox2.TabIndex = 30
        Me.RadGroupBox2.Text = "Member's Info"
        Me.RadGroupBox2.ThemeName = "Crystal"
        '
        'Frm_addGivings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 400)
        Me.Controls.Add(Me.RadGroupBox2)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.RadGridView1)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.Name = "Frm_addGivings"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ""
        Me.ThemeName = "Crystal"
        CType(Me.lblIdnum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.cbo_members, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadBarcode1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl_idnum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl_grpdesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.totAmt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox2.ResumeLayout(False)
        Me.RadGroupBox2.PerformLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblIdnum As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadBarcode1 As Telerik.WinControls.UI.RadBarcode
    Friend WithEvents cbo_members As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadGridView1 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents btnSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lbl_idnum As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lbl_grpdesc As Telerik.WinControls.UI.RadLabel
    Friend WithEvents totAmt As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
End Class

