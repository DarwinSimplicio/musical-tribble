<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_login))
        Me.CrystalTheme1 = New Telerik.WinControls.Themes.CrystalTheme()
        Me.txt_pass = New Telerik.WinControls.UI.RadButtonTextBox()
        Me.RadImageButtonElement2 = New Telerik.WinControls.UI.RadImageButtonElement()
        Me.CommandBarSeparator1 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.btn_show = New Telerik.WinControls.UI.RadImageButtonElement()
        Me.btn_login = New Telerik.WinControls.UI.RadButton()
        Me.btn_cancel = New Telerik.WinControls.UI.RadButton()
        Me.txt_user = New Telerik.WinControls.UI.RadButtonTextBox()
        Me.RadImageButtonElement1 = New Telerik.WinControls.UI.RadImageButtonElement()
        Me.CommandBarSeparator2 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadDesktopAlert1 = New Telerik.WinControls.UI.RadDesktopAlert(Me.components)
        CType(Me.txt_pass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_login, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_cancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_user, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_pass
        '
        Me.txt_pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txt_pass.LeftButtonItems.AddRange(New Telerik.WinControls.RadItem() {Me.RadImageButtonElement2, Me.CommandBarSeparator1})
        Me.txt_pass.Location = New System.Drawing.Point(12, 105)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_pass.RightButtonItems.AddRange(New Telerik.WinControls.RadItem() {Me.btn_show})
        Me.txt_pass.Size = New System.Drawing.Size(215, 26)
        Me.txt_pass.TabIndex = 1
        Me.txt_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_pass.ThemeName = "Crystal"
        '
        'RadImageButtonElement2
        '
        Me.RadImageButtonElement2.Image = CType(resources.GetObject("RadImageButtonElement2.Image"), System.Drawing.Image)
        Me.RadImageButtonElement2.Margin = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.RadImageButtonElement2.Name = "RadImageButtonElement2"
        Me.RadImageButtonElement2.ShowBorder = False
        Me.RadImageButtonElement2.Text = "RadImageButtonElement2"
        '
        'CommandBarSeparator1
        '
        Me.CommandBarSeparator1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.CommandBarSeparator1.Name = "CommandBarSeparator1"
        Me.CommandBarSeparator1.VisibleInOverflowMenu = False
        '
        'btn_show
        '
        Me.btn_show.Image = CType(resources.GetObject("btn_show.Image"), System.Drawing.Image)
        Me.btn_show.Margin = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.btn_show.Name = "btn_show"
        Me.btn_show.ShowBorder = False
        Me.btn_show.Text = "RadImageButtonElement3"
        '
        'btn_login
        '
        Me.btn_login.Image = CType(resources.GetObject("btn_login.Image"), System.Drawing.Image)
        Me.btn_login.Location = New System.Drawing.Point(12, 138)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(80, 34)
        Me.btn_login.TabIndex = 2
        Me.btn_login.Text = "Login"
        Me.btn_login.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_login.ThemeName = "Crystal"
        '
        'btn_cancel
        '
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.Location = New System.Drawing.Point(98, 138)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(80, 34)
        Me.btn_cancel.TabIndex = 3
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancel.ThemeName = "Crystal"
        '
        'txt_user
        '
        Me.txt_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txt_user.LeftButtonItems.AddRange(New Telerik.WinControls.RadItem() {Me.RadImageButtonElement1, Me.CommandBarSeparator2})
        Me.txt_user.Location = New System.Drawing.Point(12, 68)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(215, 26)
        Me.txt_user.TabIndex = 0
        Me.txt_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_user.ThemeName = "Crystal"
        '
        'RadImageButtonElement1
        '
        Me.RadImageButtonElement1.AutoSize = True
        Me.RadImageButtonElement1.Image = CType(resources.GetObject("RadImageButtonElement1.Image"), System.Drawing.Image)
        Me.RadImageButtonElement1.ImageIndexClicked = 0
        Me.RadImageButtonElement1.ImageIndexHovered = 0
        Me.RadImageButtonElement1.Margin = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.RadImageButtonElement1.Name = "RadImageButtonElement1"
        Me.RadImageButtonElement1.ShowBorder = False
        Me.RadImageButtonElement1.StretchHorizontally = False
        Me.RadImageButtonElement1.StretchVertically = False
        Me.RadImageButtonElement1.Text = "RadImageButtonElement1"
        Me.RadImageButtonElement1.UseCompatibleTextRendering = False
        '
        'CommandBarSeparator2
        '
        Me.CommandBarSeparator2.Name = "CommandBarSeparator2"
        Me.CommandBarSeparator2.VisibleInOverflowMenu = False
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(113, 12)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(114, 28)
        Me.RadLabel1.TabIndex = 5
        Me.RadLabel1.Text = "User Login"
        '
        'RadDesktopAlert1
        '
        Me.RadDesktopAlert1.ScreenPosition = Telerik.WinControls.UI.AlertScreenPosition.TopCenter
        Me.RadDesktopAlert1.ThemeName = "Crystal"
        '
        'Frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 184)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.txt_user)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.txt_pass)
        Me.Name = "Frm_login"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ThemeName = "Crystal"
        CType(Me.txt_pass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_login, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_cancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_user, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalTheme1 As Telerik.WinControls.Themes.CrystalTheme
    Friend WithEvents txt_pass As Telerik.WinControls.UI.RadButtonTextBox
    Friend WithEvents btn_login As Telerik.WinControls.UI.RadButton
    Friend WithEvents btn_cancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents txt_user As Telerik.WinControls.UI.RadButtonTextBox
    Friend WithEvents RadImageButtonElement1 As Telerik.WinControls.UI.RadImageButtonElement
    Friend WithEvents CommandBarSeparator2 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents RadImageButtonElement2 As Telerik.WinControls.UI.RadImageButtonElement
    Friend WithEvents CommandBarSeparator1 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents btn_show As Telerik.WinControls.UI.RadImageButtonElement
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadDesktopAlert1 As Telerik.WinControls.UI.RadDesktopAlert
End Class

