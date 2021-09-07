Imports System
Imports System.IO
Imports System.Text
Imports System.IO.FileAttributes
Imports System.Threading
Public Class frm_connect
    Public Function encrypt(ByVal isEncrypt As Integer, ByVal x As String, ByVal y As String)
        Dim char1 As String
        Dim char2 As String
        Dim ckey As Byte
        Dim strLength As Integer
        Dim result As String = ""
        Dim j As Integer = -1
        If x <> "" And IsNumeric(y) Then
            strLength = x.Length
            For i As Integer = 0 To strLength - 1
                char1 = x.Substring(i, 1)
                If j < y.Length - 1 Then
                    j = j + 1
                Else
                    j = 0
                End If
                ckey = Val(y.Substring(j, 1))
                If isEncrypt = 1 Then
                    char2 = Chr(Asc(char1) + ckey)
                Else
                    char2 = Chr(Asc(char1) - ckey)
                End If
                result &= char2
            Next

        End If
        Return result
    End Function
    Private Sub frm_connect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        xyzdbname = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Configuration_Settings\Connection", "8D7B6N5A4M3E21", Nothing)
        xyzdbserver = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Configuration_Settings\Connection", "8S7E6R5V4E3R2N1A8M7E61", Nothing)
        xyzdbuser = encrypt(0, My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Configuration_Settings\Connection", "8U7S6E5R41", Nothing), xkey)
        xyzdbpass = encrypt(0, My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Configuration_Settings\Connection", "8P7A6S5S41", Nothing), xkey)
        xpath = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Configuration_Settings\Connection", "8R7E6P5O4R3T21", Nothing)
        xpath3 = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Configuration_Settings\Connection", "8M7A6N5U4A3L2", Nothing)
        Dim xfrm As New Frm_login
        xfrm.Show()

        Me.Dispose(False)
        Me.Visible = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose(False)
    End Sub
End Class