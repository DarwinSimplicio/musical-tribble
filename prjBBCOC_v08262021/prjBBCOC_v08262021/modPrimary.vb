
Imports System.Management
Module modPrimary
#Region "    Variable Declarations    "

    Public notswap As Boolean = True
    Public iscamopen As Boolean

    Public xcode As String
    Public xmac As String
    Public xpc As String
    Public xfilepath As String = "E:\Softwares\Projects\DarwinSimplicioProjects\prjPaySys28042021_v03\filePath"
    Public xcname As String
    Public z1 As String
    Public z2 As String
    Public z3 As String
    Public z4 As String
    Public z5 As String
    Public picCapture As Image
    Public xxx As Integer = 1

    Public tempNum As String
    Public tempName As String

    Public isOkay As Boolean

    'for dialer login only
    Public nusername As String
    Public npass As String
    Public nlink As String
    'for dialer login only



    '-------- for employee references
    Public xTable As String
    Public xOperation As String
    Public xNrecno As String
    Public xTempID As String
    '-------- for employee references

    Public xmth As Integer
    Public xyr As Integer

    Public xctype As String

    Public xrefund As Integer = 0
    Public xtranstype As Integer
    Public xauto As Integer = 1
    Public xnitem_cd As Integer
    Public xcustno As Integer
    Public xcdesc As String
    Public xrsno As Integer

    Public xorleo As Integer
    Public xnetwork As String
    Public xclass As String
    Public xuser As String
    Public xid As String
    Public x1 As String
    Public x2 As String
    Public x3 As String
    Public x4 As String
    Public x5 As String
    Public x6 As String
    Public x7 As String
    Public x8 As String

    Public xprod As Integer
    Public xdisplay As Integer
    Public xbranchid As Integer
    Public xcash As Decimal
    Public xchange As Decimal
    Public xtotal As Decimal
    Public xyzdbname As String
    Public xyzdbserver As String
    Public xyzdbuser As String
    Public xyzdbpass As String
    Public xorno As Integer
    Public xfullname As String
    Public xdt As New DataTable
    Public xclientno As Integer
    'Public xpath As String = "C:\Program Files\POS\Setup1\"
    Public xpath As String
    Public xpath2 As String = "C:\Windows\system\"
    Public xpath3 As String
    Public xkey As String = 11972995
    Public xlevel As Integer = 0
    Public xprint As Integer = 0
    Public xyz As Integer = 0
    Public xgrade As String
    Public xcuser As String
    'Public xuser As String
    Public xsy As String
    Public xmonth As String
    Public xtrans As Date
    Dim _editMode As Boolean
    Public addflg As Integer = 1
    Public sName As String = "Security Agency Management System"

    Public reportname As String
    Public repparam As String
    Public repparam1 As String
    Public xnloan_no As Integer

    Public mcategory As String
    Public scategory As String

#End Region

End Module
