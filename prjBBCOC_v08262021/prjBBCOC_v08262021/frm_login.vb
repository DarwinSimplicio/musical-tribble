Imports System.Security
Imports System.Security.Cryptography
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions
Imports System.Text
Imports System.Net.NetworkInformation
Imports Telerik.WinControls




Public Class Frm_login
    Dim cls As New clsPrimary
    Function getMacAddress()
        Dim nics() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces
        Return nics(0).GetPhysicalAddress.ToString
    End Function
    Private Function md5Encrypt(plainText As String)
        Dim mySalt As String = "@dRsShieLdIaNe!"
        Dim bytHashedData As Byte()
        Dim encoder As New UTF8Encoding()
        Dim md5Hasher As New MD5CryptoServiceProvider

        bytHashedData = md5Hasher.ComputeHash(encoder.GetBytes(mySalt & plainText))
        Dim str As String

        For i = 0 To bytHashedData.Length - 1
            str = str & bytHashedData(i)
        Next

        Return str

    End Function
    Private Sub login()
        If txt_user.Text = String.Empty Then
            txt_user.Focus()
        ElseIf txt_pass.Text = String.Empty Then
            txt_pass.Focus()
        Else
            Dim dt As New DataTable

            If Not cls._sp_select_login(txt_user.Text, md5Encrypt(txt_pass.Text), dt) Then

                Throw New Exception(cls.errMessage)
            End If
            If dt.Rows.Count > 0 Then
                xmac = getMacAddress()
                xpc = System.Net.Dns.GetHostName
                xclass = dt.Rows(0).Item("tuPosition").ToString.Trim
                xuser = Me.txt_user.Text
                xid = dt.Rows(0).Item("nrecno").ToString.Trim
                xcname = dt.Rows(0).Item("tuFname").ToString.Trim
                'Me.RadDesktopAlert1.ContentImage = envelopeImage
                '------------message box

                RadMessageBox.SetThemeName("Crystal")
                Dim ds As DialogResult = RadMessageBox.Show(Me, "Login Successfull", "Login", MessageBoxButtons.OK, RadMessageIcon.Info)
                ' Me.Text = ds.ToString()

                '-----------message box
                txt_user.Text = ""
                txt_pass.Text = ""


                Dim xfrm As New Frm_main
                xfrm.Show()
                Me.Dispose(False)
            Else
                '------------message box

                RadMessageBox.SetThemeName("Crystal")
                Dim ds As DialogResult = RadMessageBox.Show(Me, "Either User Name or Password is incorrect!", "Login", MessageBoxButtons.OK, RadMessageIcon.Error)
                ' Me.Text = ds.ToString()

                '-----------message box

                txt_user.Text = ""
                txt_pass.Text = ""

                txt_user.Focus()
                Exit Sub
            End If
        End If
    End Sub
    '21561092141072519120851913218810749124154
    '21561092141072519120851913218810749124154
    '7056661391722292351172285942077196134190
    Private Sub btn_show_Click(sender As Object, e As EventArgs) Handles btn_show.Click
        If txt_pass.PasswordChar = "•" Then
            txt_pass.PasswordChar = ""
        Else
            txt_pass.PasswordChar = "•"
        End If
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        'Dim autoshell = My.Computer.Registry.LocalMachine.OpenSubKey("Software\Configuration_Settings\Connection", True)
        ' '' Set the value to 0
        'autoshell.SetValue("8D7B6N5A4M3E21", "prjPaySys28042021_v01")
        'autoshell.Close()
        Me.Close()
        Application.Exit()
        closeprj()

    End Sub
    Private Sub closeprj()

        'Do Until Process.GetProcessesByName("prjTactical").count < 1
        For Each p As Process In Process.GetProcessesByName("prjPaySys28042021_v02")
            p.Kill()
            p.Close()

        Next

    End Sub
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click

        login()

    End Sub

    Private Sub txt_user_GotFocus(sender As Object, e As EventArgs) Handles txt_user.GotFocus
        txt_user.SelectAll()
    End Sub

    Private Sub txt_user_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_user.KeyUp
        If e.KeyCode = Keys.Enter Then
            Me.txt_pass.Focus()
        End If
    End Sub

    Private Sub txt_pass_GotFocus(sender As Object, e As EventArgs) Handles txt_pass.GotFocus
        txt_pass.SelectAll()
    End Sub

    Private Sub txt_pass_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_pass.KeyUp
        If e.KeyCode = Keys.Enter Then
            login()
        End If
    End Sub


    Private Sub txt_pass_TextChanged(sender As Object, e As EventArgs) Handles txt_pass.TextChanged

    End Sub
    
    Private Sub Frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim xfrm As New frm_connect
        If xfrm.IsDisposed = False Then

            If xfrm.Visible = True Then
                xfrm.Visible = False

            End If
        End If
    End Sub
End Class
