Imports System.Data.SqlClient
Imports System.Configuration.ConfigurationSettings
Imports System.IO
Imports System.Reflection
Public Class clsPrimary
    Dim _con As SqlConnection
    Dim _errMessage As String

    Public Function CreateObjectInstance(ByVal objectName As String) As Object
        Dim obj As Object
        Try
            If objectName.LastIndexOf(".") = -1 Then
                objectName = [Assembly].GetEntryAssembly.GetName.Name & "." & objectName
            End If

            obj = [Assembly].GetEntryAssembly.CreateInstance(objectName)

        Catch ex As Exception
            obj = Nothing
        End Try
        Return obj

    End Function



    Public Sub New()
        Try
            OpenDB()
        Catch ex As Exception
            _errMessage = ex.Message
        End Try
    End Sub
    Private Function OpenDB() As Boolean
        Try
            _con = New SqlConnection(strCon)
            _con.Open()
        Catch ex As Exception

            _errMessage = ex.Message

        End Try
    End Function

    Public Property errMessage() As String

        Get
            Return _errMessage
        End Get

        Set(ByVal Value As String)

            _errMessage = Value

        End Set

    End Property
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
    Public Function dbuser() As String
        Try
            ' Open the file using a stream reader.
            Dim dbx1s As String
            dbx1s = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Configuration_Settings\Connection", "8U7S6E5R4", Nothing)
            Return encrypt(0, dbx1s.ToString.Trim, xkey)

        Catch e As Exception
            Console.WriteLine("The file could not be read:")
            Console.WriteLine(e.Message)
        End Try
    End Function
    Public Function dbpass() As String
        Try
            ' Open the file using a stream reader.
            Dim dbx1s As String
            dbx1s = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Configuration_Settings\Connection", "8P7A6S5S4", Nothing)
            Return encrypt(0, dbx1s.ToString.Trim, xkey)

        Catch e As Exception
            Console.WriteLine("The file could not be read:")
            Console.WriteLine(e.Message)
        End Try
    End Function
    Public Function dbname() As String
        Try
            ' Open the file using a stream reader.
            Dim dbx1s As String
            dbx1s = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Configuration_Settings\Connection", "8D7B6N5A4M3E2", Nothing)
            Return dbx1s.ToString.Trim

        Catch e As Exception
            Console.WriteLine("The file could not be read:")
            Console.WriteLine(e.Message)
        End Try
    End Function
    Public Function dbsource() As String
        Try
            ' Open the file using a stream reader.
            Dim dbx1s As String
            dbx1s = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Configuration_Settings\Connection", "8S7E6R5V4E3R2N1A8M7E6", Nothing)
            Return dbx1s.ToString.Trim

        Catch e As Exception
            Console.WriteLine("The file could not be read:")
            Console.WriteLine(e.Message)
        End Try
    End Function

    Public ReadOnly Property strCon() As String

        Get
            'Return AppSettings("conn")
            Return "Data Source=" & xyzdbserver & ";Initial Catalog=" & xyzdbname & ";User Id=" & xyzdbuser & ";Password=" & xyzdbpass & ";"
        End Get

    End Property
    Public Function dtDatabase(ByVal strSelect As String) As DataTable
        Dim conDatabase As New SqlConnection
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        conDatabase.ConnectionString = AppSettings("conn")

        cmd = conDatabase.CreateCommand
        cmd.CommandText = strSelect

        da.SelectCommand = cmd
        da.Fill(dt)
        Return (dt)

        conDatabase.Close()

        conDatabase = Nothing
        da = Nothing
        cmd = Nothing
        dt = Nothing

    End Function
    Public Sub executeNoparam(ByVal str As String)
        Dim conDatabase As New SqlConnection
        Dim cmdDatabase As New SqlCommand
        Dim trDatabase As SqlTransaction

        conDatabase.ConnectionString = AppSettings("conn1")
        conDatabase.Open()

        cmdDatabase = conDatabase.CreateCommand
        cmdDatabase.CommandText = str

        trDatabase = conDatabase.BeginTransaction()
        cmdDatabase.Transaction = trDatabase

        Try
            cmdDatabase.ExecuteNonQuery()
            trDatabase.Commit()
        Catch ex As Exception
            Dim x As String
            x = ex.Message
            trDatabase.Rollback()
        Finally
            conDatabase.Close()
        End Try

        conDatabase.Close()
        conDatabase = Nothing
        cmdDatabase = Nothing
        trDatabase = Nothing

    End Sub
    Public Sub KeyPressNumeric(ByVal pFlag As Boolean, ByVal e As KeyPressEventArgs)
        If pFlag = True Then
            If Not IsNumeric(e.KeyChar.ToString) Then
                e.Handled = True
            End If
        ElseIf pFlag = False Then
            If Not IsNumeric(e.KeyChar.ToString) Then e.Handled = True
        End If


    End Sub
    Public Sub KeyPressNumeric(ByVal e As KeyPressEventArgs)

        If Not IsNumeric(e.KeyChar.ToString) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Decimal) Then

            e.Handled = True
        End If

    End Sub
    Public Function _sp_select_login(ByVal tuUname As String, ByVal tuPassword As String, ByRef dt As DataTable) As Boolean

        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter

        Try
            cmd = New SqlCommand("_sp_select_login", _con)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@tuUname", tuUname))
            cmd.Parameters.Add(New SqlParameter("@tuPassword", tuPassword))

            da = New SqlDataAdapter(cmd)
            da.Fill(dt)

            Return True

        Catch ex As Exception

            _errMessage = ex.Message

            Return False

        Finally

            da.Dispose()
            cmd.Dispose()
            '_con.Close()
        End Try

    End Function
    Public Function _spinsert_tbl_member(ByVal fname As String, ByVal grpnum As Integer, ByVal stat As Integer) As Boolean

        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter

        Try
            cmd = New SqlCommand("_spinsert_tbl_member", _con)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@fname", fname))
            cmd.Parameters.Add(New SqlParameter("@grpnum", grpnum))
            cmd.Parameters.Add(New SqlParameter("@stat", stat))

            cmd.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            _errMessage = ex.Message
            Return False
        Finally
            cmd.Dispose()
            ' _con.Close()

        End Try

    End Function
    Public Function _spinsert_group(ByVal grpdesc As String) As Boolean

        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter

        Try
            cmd = New SqlCommand("_spinsert_group", _con)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@grpdesc", grpdesc))



            cmd.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            _errMessage = ex.Message
            Return False
        Finally
            cmd.Dispose()
            ' _con.Close()

        End Try

    End Function
    Public Function _spinsert_branch(ByVal brname As String) As Boolean

        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter

        Try
            cmd = New SqlCommand("_spinsert_branch", _con)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@brname", brname))



            cmd.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            _errMessage = ex.Message
            Return False
        Finally
            cmd.Dispose()
            ' _con.Close()

        End Try

    End Function
    Public Function _spinsert_batch(ByVal batcode As String) As Boolean

        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter

        Try
            cmd = New SqlCommand("_spinsert_batch", _con)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@batcode", batcode))



            cmd.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            _errMessage = ex.Message
            Return False
        Finally
            cmd.Dispose()
            ' _con.Close()

        End Try

    End Function
    Public Function _spinsert_tgiveHeader(ByVal tcode As String, ByVal tdate As Date, ByVal tday As String, ByVal batch As Integer, _
                                          ByVal branch As Integer, ByVal cdesc As String) As Boolean

        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter

        Try
            cmd = New SqlCommand("_spinsert_tgiveHeader", _con)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@tcode", tcode))
            cmd.Parameters.Add(New SqlParameter("@tdate", tdate))
            cmd.Parameters.Add(New SqlParameter("@tday", tday))
            cmd.Parameters.Add(New SqlParameter("@batch", batch))
            cmd.Parameters.Add(New SqlParameter("@branch", branch))
            cmd.Parameters.Add(New SqlParameter("@cdesc", cdesc))

            cmd.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            _errMessage = ex.Message
            Return False
        Finally
            cmd.Dispose()
            ' _con.Close()

        End Try

    End Function
    Public Function _spinsert_tgiveData(ByVal tcode As String, ByVal idnum As String, ByVal nrecno As Integer, ByVal amount As Decimal) As Boolean

        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter

        Try
            cmd = New SqlCommand("_spinsert_tgiveData", _con)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@tcode", tcode))
            cmd.Parameters.Add(New SqlParameter("@idnum", idnum))
            cmd.Parameters.Add(New SqlParameter("@nrecno", nrecno))
            cmd.Parameters.Add(New SqlParameter("@amount", amount))

            cmd.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            _errMessage = ex.Message
            Return False
        Finally
            cmd.Dispose()
            ' _con.Close()

        End Try

    End Function
    Public Function _spupdate_tgiveHeader(ByVal tcode As String, ByVal tdate As Date, ByVal tday As String, ByVal batch As Integer, _
                                          ByVal branch As Integer, ByVal cdesc As String) As Boolean

        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter

        Try
            cmd = New SqlCommand("_spupdate_tgiveHeader", _con)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@tcode", tcode))
            cmd.Parameters.Add(New SqlParameter("@tdate", tdate))
            cmd.Parameters.Add(New SqlParameter("@tday", tday))
            cmd.Parameters.Add(New SqlParameter("@batch", batch))
            cmd.Parameters.Add(New SqlParameter("@branch", branch))
            cmd.Parameters.Add(New SqlParameter("@cdesc", cdesc))

            cmd.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            _errMessage = ex.Message
            Return False
        Finally
            cmd.Dispose()
            ' _con.Close()

        End Try

    End Function
    Public Function _spinsert_givings(ByVal cdesc As String) As Boolean

        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter

        Try
            cmd = New SqlCommand("_spinsert_givings", _con)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@cdesc", cdesc))



            cmd.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            _errMessage = ex.Message
            Return False
        Finally
            cmd.Dispose()
            ' _con.Close()

        End Try

    End Function
    Public Function _spupdate_group(ByVal nrecno As Integer, ByVal grpdesc As String) As Boolean

        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter

        Try
            cmd = New SqlCommand("_spupdate_group", _con)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@nrecno", nrecno))
            cmd.Parameters.Add(New SqlParameter("@grpdesc", grpdesc))



            cmd.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            _errMessage = ex.Message
            Return False
        Finally
            cmd.Dispose()
            ' _con.Close()

        End Try

    End Function
    Public Function _spupdate_branch(ByVal nrecno As Integer, ByVal brname As String) As Boolean

        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter

        Try
            cmd = New SqlCommand("_spupdate_branch", _con)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@nrecno", nrecno))
            cmd.Parameters.Add(New SqlParameter("@brname", brname))



            cmd.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            _errMessage = ex.Message
            Return False
        Finally
            cmd.Dispose()
            ' _con.Close()

        End Try

    End Function
    Public Function _spupdate_batch(ByVal nrecno As Integer, ByVal batcode As String) As Boolean

        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter

        Try
            cmd = New SqlCommand("_spupdate_batch", _con)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@nrecno", nrecno))
            cmd.Parameters.Add(New SqlParameter("@batcode", batcode))



            cmd.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            _errMessage = ex.Message
            Return False
        Finally
            cmd.Dispose()
            ' _con.Close()

        End Try

    End Function
    Public Function _spupdate_givings(ByVal nrecno As Integer, ByVal cdesc As String) As Boolean

        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter

        Try
            cmd = New SqlCommand("_spupdate_givings", _con)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@nrecno", nrecno))
            cmd.Parameters.Add(New SqlParameter("@cdesc", cdesc))



            cmd.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            _errMessage = ex.Message
            Return False
        Finally
            cmd.Dispose()
            ' _con.Close()

        End Try

    End Function
    Public Function _spupdate_givings1(ByVal nrecno As Integer, ByVal ordPos As Integer) As Boolean

        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter

        Try
            cmd = New SqlCommand("_spupdate_givings1", _con)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@nrecno", nrecno))
            cmd.Parameters.Add(New SqlParameter("@ordPos", ordPos))



            cmd.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            _errMessage = ex.Message
            Return False
        Finally
            cmd.Dispose()
            ' _con.Close()

        End Try

    End Function
    Public Function _spdelete_group(ByVal nrecno As Integer) As Boolean

        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter

        Try
            cmd = New SqlCommand("_spdelete_group", _con)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@nrecno", nrecno))




            cmd.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            _errMessage = ex.Message
            Return False
        Finally
            cmd.Dispose()
            ' _con.Close()

        End Try

    End Function
    Public Function _spdelete_branch(ByVal nrecno As Integer) As Boolean

        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter

        Try
            cmd = New SqlCommand("_spdelete_branch", _con)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@nrecno", nrecno))




            cmd.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            _errMessage = ex.Message
            Return False
        Finally
            cmd.Dispose()
            ' _con.Close()

        End Try

    End Function
    Public Function _spdelete_batch(ByVal nrecno As Integer) As Boolean

        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter

        Try
            cmd = New SqlCommand("_spdelete_batch", _con)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@nrecno", nrecno))




            cmd.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            _errMessage = ex.Message
            Return False
        Finally
            cmd.Dispose()
            ' _con.Close()

        End Try

    End Function
    Public Function _spdelete_tgiveHeader(ByVal tcode As String) As Boolean

        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter

        Try
            cmd = New SqlCommand("_spdelete_tgiveHeader", _con)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@tcode", tcode))




            cmd.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            _errMessage = ex.Message
            Return False
        Finally
            cmd.Dispose()
            ' _con.Close()

        End Try

    End Function
    Public Function _spdelete_tgiveData(ByVal tcode As String, ByVal idnum As String) As Boolean

        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter

        Try
            cmd = New SqlCommand("_spdelete_tgiveData", _con)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@tcode", tcode))
            cmd.Parameters.Add(New SqlParameter("@idnum", idnum))



            cmd.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            _errMessage = ex.Message
            Return False
        Finally
            cmd.Dispose()
            ' _con.Close()

        End Try

    End Function
    Public Function _spdelete_givings(ByVal nrecno As Integer) As Boolean

        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter

        Try
            cmd = New SqlCommand("_spdelete_givings", _con)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@nrecno", nrecno))




            cmd.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            _errMessage = ex.Message
            Return False
        Finally
            cmd.Dispose()
            ' _con.Close()

        End Try

    End Function
    

    Public Function _spupdate_tbl_member(ByVal idnum As String, ByVal fname As String, ByVal grpnum As Integer, ByVal stat As Integer) As Boolean

        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter

        Try
            cmd = New SqlCommand("_spupdate_tbl_member", _con)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@idnum", idnum))
            cmd.Parameters.Add(New SqlParameter("@fname", fname))
            cmd.Parameters.Add(New SqlParameter("@grpnum", grpnum))
            cmd.Parameters.Add(New SqlParameter("@stat", stat))

            cmd.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            _errMessage = ex.Message
            Return False
        Finally
            cmd.Dispose()
            ' _con.Close()

        End Try

    End Function
    Public Function _spdelete_tbl_member(ByVal idnum As String) As Boolean

        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter

        Try
            cmd = New SqlCommand("_spdelete_tbl_member", _con)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@idnum", idnum))



            cmd.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            _errMessage = ex.Message
            Return False
        Finally
            cmd.Dispose()
            ' _con.Close()

        End Try

    End Function
    Public Function _spselect_tbl_group1(ByRef dt As DataTable) As Boolean

        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter

        Try
            cmd = New SqlCommand("_spselect_tbl_group1", _con)

            cmd.CommandType = CommandType.StoredProcedure

            da = New SqlDataAdapter(cmd)
            da.Fill(dt)

            Return True

        Catch ex As Exception

            _errMessage = ex.Message

            Return False

        Finally

            da.Dispose()
            cmd.Dispose()
            '_con.Close()
        End Try

    End Function
    Public Function _spselect_stat(ByRef dt As DataTable) As Boolean

        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter

        Try
            cmd = New SqlCommand("_spselect_stat", _con)

            cmd.CommandType = CommandType.StoredProcedure

            da = New SqlDataAdapter(cmd)
            da.Fill(dt)

            Return True

        Catch ex As Exception

            _errMessage = ex.Message

            Return False

        Finally

            da.Dispose()
            cmd.Dispose()
            '_con.Close()
        End Try

    End Function
    Public Function _spselect_tbl_member1(ByRef dt As DataTable) As Boolean

        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter

        Try
            cmd = New SqlCommand("_spselect_tbl_member1", _con)

            cmd.CommandType = CommandType.StoredProcedure

            da = New SqlDataAdapter(cmd)
            da.Fill(dt)

            Return True

        Catch ex As Exception

            _errMessage = ex.Message

            Return False

        Finally

            da.Dispose()
            cmd.Dispose()
            '_con.Close()
        End Try

    End Function
    Public Function _spselect_ledg1(ByVal idnum As String, ByVal xfrom As DateTime, ByVal xto As DateTime, ByRef dt As DataTable) As Boolean

        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter

        Try
            cmd = New SqlCommand("_spselect_ledg1", _con)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@idnum", idnum))
            cmd.Parameters.Add(New SqlParameter("@xfrom", xfrom))
            cmd.Parameters.Add(New SqlParameter("@xto", xto))
            da = New SqlDataAdapter(cmd)
            da.Fill(dt)

            Return True

        Catch ex As Exception

            _errMessage = ex.Message

            Return False

        Finally

            da.Dispose()
            cmd.Dispose()
            '_con.Close()
        End Try

    End Function
    Public Function _spselect_ledg2(ByVal idnum As String, ByVal tcode As String, ByRef dt As DataTable) As Boolean

        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter

        Try
            cmd = New SqlCommand("_spselect_ledg2", _con)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@idnum", idnum))
            cmd.Parameters.Add(New SqlParameter("@tcode", tcode))

            da = New SqlDataAdapter(cmd)
            da.Fill(dt)

            Return True

        Catch ex As Exception

            _errMessage = ex.Message

            Return False

        Finally

            da.Dispose()
            cmd.Dispose()
            '_con.Close()
        End Try

    End Function
    Public Function _spselect_ledg3(ByVal xfrom As DateTime, ByVal xto As DateTime, ByRef dt As DataTable) As Boolean

        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter

        Try
            cmd = New SqlCommand("_spselect_ledg3", _con)

            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Add(New SqlParameter("@xfrom", xfrom))
            cmd.Parameters.Add(New SqlParameter("@xto", xto))
            da = New SqlDataAdapter(cmd)
            da.Fill(dt)

            Return True

        Catch ex As Exception

            _errMessage = ex.Message

            Return False

        Finally

            da.Dispose()
            cmd.Dispose()
            '_con.Close()
        End Try

    End Function
    Public Function _spselect_ledg4(ByVal tcode As String, ByRef dt As DataTable) As Boolean

        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter

        Try
            cmd = New SqlCommand("_spselect_ledg4", _con)

            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Add(New SqlParameter("@tcode", tcode))

            da = New SqlDataAdapter(cmd)
            da.Fill(dt)

            Return True

        Catch ex As Exception

            _errMessage = ex.Message

            Return False

        Finally

            da.Dispose()
            cmd.Dispose()
            '_con.Close()
        End Try

    End Function
    Public Function _spselect_ledg5(ByVal idnum As String, ByVal xfrom As DateTime, ByVal xto As DateTime, ByRef dt As DataTable) As Boolean

        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter

        Try
            cmd = New SqlCommand("_spselect_ledg5", _con)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@idnum", idnum))
            cmd.Parameters.Add(New SqlParameter("@xfrom", xfrom))
            cmd.Parameters.Add(New SqlParameter("@xto", xto))
            da = New SqlDataAdapter(cmd)
            da.Fill(dt)

            Return True

        Catch ex As Exception

            _errMessage = ex.Message

            Return False

        Finally

            da.Dispose()
            cmd.Dispose()
            '_con.Close()
        End Try

    End Function
    Public Function _spselect_ledg6(ByVal idnum As String, ByVal tcode As String, ByRef dt As DataTable) As Boolean

        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter

        Try
            cmd = New SqlCommand("_spselect_ledg6", _con)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@idnum", idnum))
            cmd.Parameters.Add(New SqlParameter("@tcode", tcode))

            da = New SqlDataAdapter(cmd)
            da.Fill(dt)

            Return True

        Catch ex As Exception

            _errMessage = ex.Message

            Return False

        Finally

            da.Dispose()
            cmd.Dispose()
            '_con.Close()
        End Try

    End Function
    Public Function _spselect_ledg7(ByVal nrecno As Integer, ByVal xfrom As DateTime, ByVal xto As DateTime, ByRef dt As DataTable) As Boolean

        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter

        Try
            cmd = New SqlCommand("_spselect_ledg7", _con)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@nrecno", nrecno))
            cmd.Parameters.Add(New SqlParameter("@xfrom", xfrom))
            cmd.Parameters.Add(New SqlParameter("@xto", xto))

            da = New SqlDataAdapter(cmd)
            da.Fill(dt)

            Return True

        Catch ex As Exception

            _errMessage = ex.Message

            Return False

        Finally

            da.Dispose()
            cmd.Dispose()
            '_con.Close()
        End Try

    End Function
    Public Function _spselect_ledg8(ByVal nrecno As Integer, ByVal tcode As String, ByRef dt As DataTable) As Boolean

        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter

        Try
            cmd = New SqlCommand("_spselect_ledg8", _con)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@nrecno", nrecno))
            cmd.Parameters.Add(New SqlParameter("@tcode", tcode))

            da = New SqlDataAdapter(cmd)
            da.Fill(dt)

            Return True

        Catch ex As Exception

            _errMessage = ex.Message

            Return False

        Finally

            da.Dispose()
            cmd.Dispose()
            '_con.Close()
        End Try

    End Function
    Public Function _spselect_group1(ByRef dt As DataTable) As Boolean

        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter

        Try
            cmd = New SqlCommand("_spselect_group1", _con)

            cmd.CommandType = CommandType.StoredProcedure

            da = New SqlDataAdapter(cmd)
            da.Fill(dt)

            Return True

        Catch ex As Exception

            _errMessage = ex.Message

            Return False

        Finally

            da.Dispose()
            cmd.Dispose()
            '_con.Close()
        End Try

    End Function
    Public Function _spselect_membersIsExists(ByVal fname As String, ByRef dt As DataTable) As Boolean

        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter

        Try
            cmd = New SqlCommand("_spselect_membersIsExists", _con)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@fname", fname))
            da = New SqlDataAdapter(cmd)
            da.Fill(dt)

            Return True

        Catch ex As Exception

            _errMessage = ex.Message

            Return False

        Finally

            da.Dispose()
            cmd.Dispose()
            '_con.Close()
        End Try

    End Function
    
    Public Function _spselect_branch1(ByRef dt As DataTable) As Boolean

        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter

        Try
            cmd = New SqlCommand("_spselect_branch1", _con)

            cmd.CommandType = CommandType.StoredProcedure

            da = New SqlDataAdapter(cmd)
            da.Fill(dt)

            Return True

        Catch ex As Exception

            _errMessage = ex.Message

            Return False

        Finally

            da.Dispose()
            cmd.Dispose()
            '_con.Close()
        End Try

    End Function
    Public Function _spselect_batch1(ByRef dt As DataTable) As Boolean

        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter

        Try
            cmd = New SqlCommand("_spselect_batch1", _con)

            cmd.CommandType = CommandType.StoredProcedure

            da = New SqlDataAdapter(cmd)
            da.Fill(dt)

            Return True

        Catch ex As Exception

            _errMessage = ex.Message

            Return False

        Finally

            da.Dispose()
            cmd.Dispose()
            '_con.Close()
        End Try

    End Function
    Public Function _spselect_tgiveHeader1(ByRef dt As DataTable) As Boolean

        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter

        Try
            cmd = New SqlCommand("_spselect_tgiveHeader1", _con)

            cmd.CommandType = CommandType.StoredProcedure

            da = New SqlDataAdapter(cmd)
            da.Fill(dt)

            Return True

        Catch ex As Exception

            _errMessage = ex.Message

            Return False

        Finally

            da.Dispose()
            cmd.Dispose()
            '_con.Close()
        End Try

    End Function
    Public Function _spselect_rptmembers(ByRef dt As DataTable) As Boolean

        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter

        Try
            cmd = New SqlCommand("_spselect_rptmembers", _con)

            cmd.CommandType = CommandType.StoredProcedure

            da = New SqlDataAdapter(cmd)
            da.Fill(dt)

            Return True

        Catch ex As Exception

            _errMessage = ex.Message

            Return False

        Finally

            da.Dispose()
            cmd.Dispose()
            '_con.Close()
        End Try

    End Function
    Public Function _spselect_daySummary(ByVal tcode As String, ByRef dt As DataTable) As Boolean

        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter

        Try
            cmd = New SqlCommand("_spselect_daySummary", _con)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@tcode", tcode))
            da = New SqlDataAdapter(cmd)
            da.Fill(dt)

            Return True

        Catch ex As Exception

            _errMessage = ex.Message

            Return False

        Finally

            da.Dispose()
            cmd.Dispose()
            '_con.Close()
        End Try

    End Function
    Public Function _spselect_givings1(ByRef dt As DataTable) As Boolean

        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter

        Try
            cmd = New SqlCommand("_spselect_givings1", _con)

            cmd.CommandType = CommandType.StoredProcedure

            da = New SqlDataAdapter(cmd)
            da.Fill(dt)

            Return True

        Catch ex As Exception

            _errMessage = ex.Message

            Return False

        Finally

            da.Dispose()
            cmd.Dispose()
            '_con.Close()
        End Try

    End Function
    Public Function _spselect_tbl_tgiveData2(ByVal tcode As String, ByVal idnum As String, ByRef dt As DataTable) As Boolean

        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter

        Try
            cmd = New SqlCommand("_spselect_tbl_tgiveData2", _con)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@tcode", tcode))
            cmd.Parameters.Add(New SqlParameter("@idnum", idnum))
            da = New SqlDataAdapter(cmd)
            da.Fill(dt)

            Return True

        Catch ex As Exception

            _errMessage = ex.Message

            Return False

        Finally

            da.Dispose()
            cmd.Dispose()
            '_con.Close()
        End Try

    End Function
    Public Function _spselect_tbl_member2(ByVal idnum As String, ByRef dt As DataTable) As Boolean

        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter

        Try
            cmd = New SqlCommand("_spselect_tbl_member2", _con)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@idnum", idnum))
            da = New SqlDataAdapter(cmd)
            da.Fill(dt)

            Return True

        Catch ex As Exception

            _errMessage = ex.Message

            Return False

        Finally

            da.Dispose()
            cmd.Dispose()
            '_con.Close()
        End Try

    End Function
    Public Function _spselect_group2(ByVal nrecno As Integer, ByRef dt As DataTable) As Boolean

        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter

        Try
            cmd = New SqlCommand("_spselect_group2", _con)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@nrecno", nrecno))




            da = New SqlDataAdapter(cmd)
            da.Fill(dt)

            Return True

        Catch ex As Exception
            _errMessage = ex.Message
            Return False
        Finally

            da.Dispose()
            cmd.Dispose()
            ' _con.Close()

        End Try

    End Function
    Public Function _spselect_branch2(ByVal nrecno As Integer, ByRef dt As DataTable) As Boolean

        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter

        Try
            cmd = New SqlCommand("_spselect_branch2", _con)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@nrecno", nrecno))




            da = New SqlDataAdapter(cmd)
            da.Fill(dt)

            Return True

        Catch ex As Exception
            _errMessage = ex.Message
            Return False
        Finally

            da.Dispose()
            cmd.Dispose()
            ' _con.Close()

        End Try

    End Function
    Public Function _spselect_batch2(ByVal nrecno As Integer, ByRef dt As DataTable) As Boolean

        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter

        Try
            cmd = New SqlCommand("_spselect_batch2", _con)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@nrecno", nrecno))




            da = New SqlDataAdapter(cmd)
            da.Fill(dt)

            Return True

        Catch ex As Exception
            _errMessage = ex.Message
            Return False
        Finally

            da.Dispose()
            cmd.Dispose()
            ' _con.Close()

        End Try

    End Function
    Public Function _spselect_tgiveHeader2(ByVal tcode As String, ByRef dt As DataTable) As Boolean

        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter

        Try
            cmd = New SqlCommand("_spselect_tgiveHeader2", _con)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@tcode", tcode))




            da = New SqlDataAdapter(cmd)
            da.Fill(dt)

            Return True

        Catch ex As Exception
            _errMessage = ex.Message
            Return False
        Finally

            da.Dispose()
            cmd.Dispose()
            ' _con.Close()

        End Try

    End Function
    Public Function _spselect_givings2(ByVal nrecno As Integer, ByRef dt As DataTable) As Boolean

        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter

        Try
            cmd = New SqlCommand("_spselect_givings2", _con)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@nrecno", nrecno))




            da = New SqlDataAdapter(cmd)
            da.Fill(dt)

            Return True

        Catch ex As Exception
            _errMessage = ex.Message
            Return False
        Finally

            da.Dispose()
            cmd.Dispose()
            ' _con.Close()

        End Try

    End Function
End Class
