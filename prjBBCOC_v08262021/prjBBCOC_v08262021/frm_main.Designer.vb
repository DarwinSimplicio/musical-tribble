<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_main))
        Me.RadMenu1 = New Telerik.WinControls.UI.RadMenu()
        Me.RadMenuItem1 = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuItem2 = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuItem10 = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuItem3 = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuItem4 = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuItem5 = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuItem6 = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuItem7 = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuItem11 = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuItem12 = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuSeparatorItem1 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
        Me.RadMenuItem8 = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuItem9 = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip()
        Me.RadLabelElement1 = New Telerik.WinControls.UI.RadLabelElement()
        Me.CommandBarSeparator1 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.RadLabelElement2 = New Telerik.WinControls.UI.RadLabelElement()
        Me.CommandBarSeparator2 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.RadLabelElement3 = New Telerik.WinControls.UI.RadLabelElement()
        Me.CommandBarSeparator3 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.RadLabelElement4 = New Telerik.WinControls.UI.RadLabelElement()
        Me.CommandBarSeparator4 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.RadLabelElement5 = New Telerik.WinControls.UI.RadLabelElement()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.RadMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadMenu1
        '
        Me.RadMenu1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadMenuItem1, Me.RadMenuItem2, Me.RadMenuItem3, Me.RadMenuItem4})
        Me.RadMenu1.Location = New System.Drawing.Point(0, 0)
        Me.RadMenu1.Name = "RadMenu1"
        Me.RadMenu1.Size = New System.Drawing.Size(730, 74)
        Me.RadMenu1.TabIndex = 0
        Me.RadMenu1.ThemeName = "Crystal"
        '
        'RadMenuItem1
        '
        Me.RadMenuItem1.Image = CType(resources.GetObject("RadMenuItem1.Image"), System.Drawing.Image)
        Me.RadMenuItem1.ImageAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.RadMenuItem1.Name = "RadMenuItem1"
        Me.RadMenuItem1.Text = "REGISTER"
        Me.RadMenuItem1.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.RadMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RadMenuItem2
        '
        Me.RadMenuItem2.Image = CType(resources.GetObject("RadMenuItem2.Image"), System.Drawing.Image)
        Me.RadMenuItem2.ImageAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.RadMenuItem2.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadMenuItem10})
        Me.RadMenuItem2.Name = "RadMenuItem2"
        Me.RadMenuItem2.Text = "GIVINGS"
        Me.RadMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RadMenuItem10
        '
        Me.RadMenuItem10.Name = "RadMenuItem10"
        Me.RadMenuItem10.Text = "Create Givings"
        '
        'RadMenuItem3
        '
        Me.RadMenuItem3.Image = CType(resources.GetObject("RadMenuItem3.Image"), System.Drawing.Image)
        Me.RadMenuItem3.ImageAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.RadMenuItem3.Name = "RadMenuItem3"
        Me.RadMenuItem3.Text = "LEDGER"
        Me.RadMenuItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RadMenuItem4
        '
        Me.RadMenuItem4.Image = CType(resources.GetObject("RadMenuItem4.Image"), System.Drawing.Image)
        Me.RadMenuItem4.ImageAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.RadMenuItem4.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadMenuItem5, Me.RadMenuSeparatorItem1, Me.RadMenuItem8, Me.RadMenuItem9})
        Me.RadMenuItem4.Name = "RadMenuItem4"
        Me.RadMenuItem4.Text = "SETTINGS"
        Me.RadMenuItem4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RadMenuItem5
        '
        Me.RadMenuItem5.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadMenuItem6, Me.RadMenuItem7, Me.RadMenuItem11, Me.RadMenuItem12})
        Me.RadMenuItem5.Name = "RadMenuItem5"
        Me.RadMenuItem5.Text = "Maintenance"
        '
        'RadMenuItem6
        '
        Me.RadMenuItem6.Name = "RadMenuItem6"
        Me.RadMenuItem6.Text = "Groups"
        '
        'RadMenuItem7
        '
        Me.RadMenuItem7.Name = "RadMenuItem7"
        Me.RadMenuItem7.Text = "Givings"
        '
        'RadMenuItem11
        '
        Me.RadMenuItem11.Name = "RadMenuItem11"
        Me.RadMenuItem11.Text = "Batch"
        '
        'RadMenuItem12
        '
        Me.RadMenuItem12.Name = "RadMenuItem12"
        Me.RadMenuItem12.Text = "Branch"
        '
        'RadMenuSeparatorItem1
        '
        Me.RadMenuSeparatorItem1.Name = "RadMenuSeparatorItem1"
        Me.RadMenuSeparatorItem1.Text = "RadMenuSeparatorItem1"
        Me.RadMenuSeparatorItem1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadMenuItem8
        '
        Me.RadMenuItem8.Name = "RadMenuItem8"
        Me.RadMenuItem8.Text = "Logout"
        '
        'RadMenuItem9
        '
        Me.RadMenuItem9.Name = "RadMenuItem9"
        Me.RadMenuItem9.Text = "Exit"
        '
        'RadStatusStrip1
        '
        Me.RadStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadLabelElement1, Me.CommandBarSeparator1, Me.RadLabelElement2, Me.CommandBarSeparator2, Me.RadLabelElement3, Me.CommandBarSeparator3, Me.RadLabelElement4, Me.CommandBarSeparator4, Me.RadLabelElement5})
        Me.RadStatusStrip1.Location = New System.Drawing.Point(0, 346)
        Me.RadStatusStrip1.Name = "RadStatusStrip1"
        Me.RadStatusStrip1.Size = New System.Drawing.Size(730, 26)
        Me.RadStatusStrip1.TabIndex = 1
        Me.RadStatusStrip1.ThemeName = "Crystal"
        '
        'RadLabelElement1
        '
        Me.RadLabelElement1.Name = "RadLabelElement1"
        Me.RadStatusStrip1.SetSpring(Me.RadLabelElement1, False)
        Me.RadLabelElement1.Text = "Hi! "
        Me.RadLabelElement1.TextWrap = True
        '
        'CommandBarSeparator1
        '
        Me.CommandBarSeparator1.Name = "CommandBarSeparator1"
        Me.RadStatusStrip1.SetSpring(Me.CommandBarSeparator1, False)
        Me.CommandBarSeparator1.VisibleInOverflowMenu = False
        '
        'RadLabelElement2
        '
        Me.RadLabelElement2.Name = "RadLabelElement2"
        Me.RadStatusStrip1.SetSpring(Me.RadLabelElement2, False)
        Me.RadLabelElement2.Text = "RadLabelElement2"
        Me.RadLabelElement2.TextWrap = True
        '
        'CommandBarSeparator2
        '
        Me.CommandBarSeparator2.Name = "CommandBarSeparator2"
        Me.RadStatusStrip1.SetSpring(Me.CommandBarSeparator2, False)
        Me.CommandBarSeparator2.VisibleInOverflowMenu = False
        '
        'RadLabelElement3
        '
        Me.RadLabelElement3.Name = "RadLabelElement3"
        Me.RadStatusStrip1.SetSpring(Me.RadLabelElement3, False)
        Me.RadLabelElement3.Text = "MAC"
        Me.RadLabelElement3.TextWrap = True
        '
        'CommandBarSeparator3
        '
        Me.CommandBarSeparator3.Name = "CommandBarSeparator3"
        Me.RadStatusStrip1.SetSpring(Me.CommandBarSeparator3, False)
        Me.CommandBarSeparator3.VisibleInOverflowMenu = False
        '
        'RadLabelElement4
        '
        Me.RadLabelElement4.Name = "RadLabelElement4"
        Me.RadStatusStrip1.SetSpring(Me.RadLabelElement4, False)
        Me.RadLabelElement4.Text = "RadLabelElement4"
        Me.RadLabelElement4.TextWrap = True
        '
        'CommandBarSeparator4
        '
        Me.CommandBarSeparator4.Name = "CommandBarSeparator4"
        Me.RadStatusStrip1.SetSpring(Me.CommandBarSeparator4, False)
        Me.CommandBarSeparator4.VisibleInOverflowMenu = False
        '
        'RadLabelElement5
        '
        Me.RadLabelElement5.Name = "RadLabelElement5"
        Me.RadStatusStrip1.SetSpring(Me.RadLabelElement5, False)
        Me.RadLabelElement5.Text = "RadLabelElement5"
        Me.RadLabelElement5.TextWrap = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 372)
        Me.Controls.Add(Me.RadStatusStrip1)
        Me.Controls.Add(Me.RadMenu1)
        Me.Name = "Frm_main"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.ThemeName = "Crystal"
        CType(Me.RadMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadMenu1 As Telerik.WinControls.UI.RadMenu
    Friend WithEvents RadMenuItem1 As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuItem2 As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuItem3 As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuItem4 As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuItem5 As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuItem6 As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuItem10 As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuItem7 As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuSeparatorItem1 As Telerik.WinControls.UI.RadMenuSeparatorItem
    Friend WithEvents RadMenuItem8 As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuItem9 As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents RadLabelElement1 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents CommandBarSeparator1 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents RadLabelElement2 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents CommandBarSeparator2 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents RadLabelElement3 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents CommandBarSeparator3 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents RadLabelElement4 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents CommandBarSeparator4 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents RadLabelElement5 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RadMenuItem11 As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuItem12 As Telerik.WinControls.UI.RadMenuItem
End Class

