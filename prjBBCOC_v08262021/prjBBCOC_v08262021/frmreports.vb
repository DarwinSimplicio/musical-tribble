Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Public Class frmreports
    Dim cls As New clsPrimary
    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        ' Dim strReportPath As String = Application.StartupPath & _
        '           "\report1.rpt"
        Dim strReportPath As String = reportname

        'Dim dt As New DataTable
        'If Not cls._spselect_login1(dt) Then

        '    Throw New Exception(cls.errMessage)
        'End If

        If Not IO.File.Exists(strReportPath) Then
            Throw (New Exception("Unable to locate report file:" & _
              vbCrLf & strReportPath))
        End If

        Dim cr As New ReportDocument

        'cr.PrintOptions.PrinterName = "\\leo-PC\EPSON TM-T81 Receipt"
        ' cr.Load(strReportPath, OpenReportMethod.OpenReportByDefault)
        cr.Load(strReportPath)

        cr.SetDataSource(xdt)
        CrystalReportViewer1.ShowRefreshButton = False
        CrystalReportViewer1.ShowCloseButton = False
        CrystalReportViewer1.ShowGroupTreeButton = False
        If z1 <> Nothing Then
            cr.SetParameterValue("z1", z1)
        End If
        If z2 <> Nothing Then
            cr.SetParameterValue("z2", z2)
        End If
        If z3 <> Nothing Then
            cr.SetParameterValue("z3", z3)
        End If
        If z4 <> Nothing Then
            cr.SetParameterValue("z4", z4)
        End If

        If z5 <> Nothing Then
            cr.SetParameterValue("z5", z5)
        End If


        If x1 <> Nothing Then
            cr.SetParameterValue("x1", x1)
        End If
        If x2 <> Nothing Then
            cr.SetParameterValue("x2", x2)
        End If
        If x3 <> Nothing Then
            cr.SetParameterValue("x3", x3)
        End If
        If x4 <> Nothing Then
            cr.SetParameterValue("x4", x4)
        End If
        If x5 <> Nothing Then
            cr.SetParameterValue("x5", x5)
        End If
        If x6 <> Nothing Then
            cr.SetParameterValue("x6", x6)
        End If
        If x7 <> Nothing Then
            cr.SetParameterValue("x7", x7)
        End If
        If x8 <> Nothing Then
            cr.SetParameterValue("x8", x8)
        End If

        


        If xdisplay = 1 Then
            CrystalReportViewer1.ReportSource = cr
        Else

            'report.PrintOptions.PrinterName = "\\\\\\\\network\\\\printer"
            '   cr.Load(strReportPath, OpenReportMethod.OpenReportByDefault)
            cr.PrintToPrinter(1, False, 0, 0)
            Me.Close()
        End If

        '  Dim report As New ReportDocument

        '  report.PrintToPrinter(1, False, 0, 0)

        'Dim report As New ReportDocument
        'report.PrintOptions.PrinterName = "\\network\printer"
        'report.Load(CrystalReportName.rpt, OpenReportMethod.OpenReportByDefault)
        'report.PrintToPrinter(1, False, 0, 0)
    End Sub

    Private Sub frmreports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class