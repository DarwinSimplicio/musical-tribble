<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_givingsMain
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
        Dim GridViewCommandColumn1 As Telerik.WinControls.UI.GridViewCommandColumn = New Telerik.WinControls.UI.GridViewCommandColumn()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_givingsMain))
        Dim GridViewCommandColumn2 As Telerik.WinControls.UI.GridViewCommandColumn = New Telerik.WinControls.UI.GridViewCommandColumn()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.RadGridView1 = New Telerik.WinControls.UI.RadGridView()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.lblIdnum = New Telerik.WinControls.UI.RadLabel()
        Me.btnCancel = New Telerik.WinControls.UI.RadButton()
        Me.btnSave = New Telerik.WinControls.UI.RadButton()
        Me.btnNew = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.txtdesc = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.btn_reOrder = New Telerik.WinControls.UI.RadButton()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.lblIdnum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_reOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGridView1
        '
        Me.RadGridView1.AllowDrop = True
        Me.RadGridView1.Location = New System.Drawing.Point(207, 12)
        '
        '
        '
        Me.RadGridView1.MasterTemplate.AllowAddNewRow = False
        Me.RadGridView1.MasterTemplate.AllowDragToGroup = False
        Me.RadGridView1.MasterTemplate.AllowRowReorder = True
        Me.RadGridView1.MasterTemplate.AllowSearchRow = True
        GridViewTextBoxColumn1.FieldName = "nrecno"
        GridViewTextBoxColumn1.HeaderText = "column1"
        GridViewTextBoxColumn1.IsVisible = False
        GridViewTextBoxColumn1.Name = "nrecno"
        GridViewTextBoxColumn2.FieldName = "cdesc"
        GridViewTextBoxColumn2.HeaderText = "Type of Giving"
        GridViewTextBoxColumn2.Name = "cdesc"
        GridViewTextBoxColumn2.Width = 150
        GridViewCommandColumn1.HeaderText = "EDIT"
        GridViewCommandColumn1.Image = CType(resources.GetObject("GridViewCommandColumn1.Image"), System.Drawing.Image)
        GridViewCommandColumn1.Name = "column1"
        GridViewCommandColumn2.HeaderText = "DEL"
        GridViewCommandColumn2.Image = CType(resources.GetObject("GridViewCommandColumn2.Image"), System.Drawing.Image)
        GridViewCommandColumn2.Name = "column2"
        Me.RadGridView1.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewCommandColumn1, GridViewCommandColumn2})
        Me.RadGridView1.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.RadGridView1.Name = "RadGridView1"
        Me.RadGridView1.ReadOnly = True
        Me.RadGridView1.Size = New System.Drawing.Size(293, 353)
        Me.RadGridView1.TabIndex = 0
        Me.RadGridView1.ThemeName = "Crystal"
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Controls.Add(Me.lblIdnum)
        Me.RadGroupBox1.Controls.Add(Me.btnCancel)
        Me.RadGroupBox1.Controls.Add(Me.btnSave)
        Me.RadGroupBox1.Controls.Add(Me.btnNew)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel2)
        Me.RadGroupBox1.Controls.Add(Me.txtdesc)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel1)
        Me.RadGroupBox1.HeaderMargin = New System.Windows.Forms.Padding(1)
        Me.RadGroupBox1.HeaderText = "GIVINGS"
        Me.RadGroupBox1.Location = New System.Drawing.Point(1, 12)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(200, 353)
        Me.RadGroupBox1.TabIndex = 1
        Me.RadGroupBox1.Text = "GIVINGS"
        Me.RadGroupBox1.ThemeName = "Crystal"
        '
        'lblIdnum
        '
        Me.lblIdnum.Location = New System.Drawing.Point(11, 62)
        Me.lblIdnum.Name = "lblIdnum"
        Me.lblIdnum.Size = New System.Drawing.Size(15, 20)
        Me.lblIdnum.TabIndex = 13
        Me.lblIdnum.Text = "--"
        Me.lblIdnum.ThemeName = "Crystal"
        '
        'btnCancel
        '
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(5, 307)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(190, 36)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.ThemeName = "Crystal"
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(5, 269)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(190, 36)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.ThemeName = "Crystal"
        '
        'btnNew
        '
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.Location = New System.Drawing.Point(5, 232)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(190, 36)
        Me.btnNew.TabIndex = 9
        Me.btnNew.Text = "Add New"
        Me.btnNew.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNew.ThemeName = "Crystal"
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(11, 88)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(94, 20)
        Me.RadLabel2.TabIndex = 8
        Me.RadLabel2.Text = "Type of Giving"
        Me.RadLabel2.ThemeName = "Crystal"
        '
        'txtdesc
        '
        Me.txtdesc.Location = New System.Drawing.Point(10, 114)
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(185, 24)
        Me.txtdesc.TabIndex = 7
        Me.txtdesc.ThemeName = "Crystal"
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(11, 36)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(72, 20)
        Me.RadLabel1.TabIndex = 5
        Me.RadLabel1.Text = "ID Number"
        Me.RadLabel1.ThemeName = "Crystal"
        '
        'btn_reOrder
        '
        Me.btn_reOrder.Image = CType(resources.GetObject("btn_reOrder.Image"), System.Drawing.Image)
        Me.btn_reOrder.Location = New System.Drawing.Point(397, 3)
        Me.btn_reOrder.Name = "btn_reOrder"
        Me.btn_reOrder.Size = New System.Drawing.Size(100, 30)
        Me.btn_reOrder.TabIndex = 14
        Me.btn_reOrder.Text = "Reorder List"
        Me.btn_reOrder.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_reOrder.ThemeName = "Crystal"
        '
        'Frm_givingsMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 377)
        Me.Controls.Add(Me.btn_reOrder)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.Controls.Add(Me.RadGridView1)
        Me.Name = "Frm_givingsMain"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Givings Maintenance"
        Me.ThemeName = "Crystal"
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.lblIdnum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_reOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadGridView1 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtdesc As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblIdnum As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnCancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnNew As Telerik.WinControls.UI.RadButton
    Friend WithEvents btn_reOrder As Telerik.WinControls.UI.RadButton
End Class

