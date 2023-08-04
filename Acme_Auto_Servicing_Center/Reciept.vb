Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient
Public Class Reciept
    Public connection As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=carservice_database;User=root;Password=;")
    Public sql As String
    Public query As String
    Public cmd As MySqlCommand
    Public reader As MySqlDataReader
    Public dataset As DataSet
    Public dataAdapter As New MySqlDataAdapter
    Public servicceID As Integer

    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim paper As Integer

    Dim typelimit As Integer = MakeService.i
    Dim partslimit As Integer = MakeService.j
    Dim mechaniclimit As Integer = MakeService.k

    Dim grandtotal As Decimal
    Private Sub PD_BeginPrint(sender As Object, e As Printing.PrintEventArgs) Handles PD.BeginPrint
        Dim page As New PageSettings
        page.PaperSize = New PaperSize("Custom", 250, 300)
        PD.DefaultPageSettings = page
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f8 As New Font("Calibri", 8, FontStyle.Regular)
        Dim f10 As New Font("Calibri", 7, FontStyle.Regular)
        Dim f10b As New Font("Calibri", 8, FontStyle.Bold)
        Dim f14 As New Font("Calibri", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width


        Dim right As New StringFormat
        Dim center As New StringFormat
        Dim left As New StringFormat
        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center
        left.Alignment = StringAlignment.Near

        Dim line As String
        line = "================================================="
        e.Graphics.DrawString("Acme Auto Servicing Center", f14, Brushes.Black, centermargin, 5, center)
        e.Graphics.DrawString("Sitio Saguingan, Upper Bicutan, Taguig City", f10, Brushes.Black, centermargin, 25, center)
        e.Graphics.DrawString("Contact number: 09511459080 " + vbCrLf + " Dave Merc Adlawan", f10, Brushes.Black, centermargin, 35, center)
        e.Graphics.DrawString("Service ID: " & servicceID, f10, Brushes.Black, 35, 60, center)
        e.Graphics.DrawString("Service Date: " & Now().ToShortDateString, f10, Brushes.Black, rightmargin - 5, 60, right)
        e.Graphics.DrawString(line, f10, Brushes.Black, centermargin, 70, center)

        e.Graphics.DrawString("Service avail: ", f10b, Brushes.Black, 45, 80, center)
        Dim space As Integer = 93
        For uwo As Integer = 0 To typelimit - 1
            e.Graphics.DrawString(MakeService.arrServiceType(uwo), f10, Brushes.Black, 60, space, center)
            e.Graphics.DrawString(MakeService.arrServiceTypeFee(uwo).ToString("C2"), f10, Brushes.Black, rightmargin - 45, space, center)
            space += 10
        Next
        e.Graphics.DrawString(line, f10, Brushes.Black, centermargin, space + 5, center)

        space += 20
        e.Graphics.DrawString("Parts Purchase: ", f10b, Brushes.Black, 45, space, center)
        space += 10
        For shesh As Integer = 0 To partslimit - 1
            e.Graphics.DrawString(MakeService.arrParts(shesh), f10, Brushes.Black, 60, space, center)
            e.Graphics.DrawString(MakeService.arrPartsQuantity(shesh) & "   x   " & MakeService.arrPartsFee(shesh).ToString("C2"), f10, Brushes.Black, rightmargin - 45, space, center)
            space += 10
        Next
        e.Graphics.DrawString(line, f10, Brushes.Black, centermargin, space + 5, center)

        space += 20
        e.Graphics.DrawString("Mechanics: ", f10b, Brushes.Black, 45, space, center)
        space += 15
        For yamete As Integer = 0 To mechaniclimit - 1
            e.Graphics.DrawString(MakeService.arrMechanics(yamete), f10, Brushes.Black, 60, space, center)
            space += 10
        Next
        e.Graphics.DrawString(line, f10, Brushes.Black, centermargin, space + 5, center)
        space += 20
        e.Graphics.DrawString("Grand Total: " & grandtotal.ToString("C2"), f10, Brushes.Black, rightmargin - 10, space, right)
    End Sub

    Private Sub Reciept_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            connection.Open()
            query = "SELECT service_id FROM service WHERE service_id = (SELECT MAX(service_id) FROM service)"
            cmd = New MySqlCommand(query, connection)
            reader = cmd.ExecuteReader()
            reader.Read()
            servicceID = reader("service_id")
            reader.Close()
        Catch ex As MySqlException
            MsgBox("Error in collectig data from database. Error is :" & ex.Message)
        End Try
        If MakeService.txtTotalPartsPrice.Text = "" Then
            MakeService.txtTotalPartsPrice.Text = 0
        End If
        If MakeService.txtTotalService.Text = "" Then
            MakeService.txtTotalService.Text = 0
        End If
        grandtotal = CDec(MakeService.txtTotalPartsPrice.Text) + CDec(MakeService.txtTotalService.Text)
        connection.Close()
        PPD.Document = PD
        PPD.ShowDialog()
    End Sub
End Class