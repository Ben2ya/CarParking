Imports System.Data.OleDb
Imports MySql.Data.MySqlClient

Public Class Report
    Public con As MySqlConnection
    Public cmd As MySqlCommand
    Public rdr As MySqlDataReader


    Sub GenerateReport()
        Dim html = ""

        html += "<head><style>table {border-collapse: collapse;width: 100%;}th, td{text-align: left;padding: 8px;}tr:nth-child(even){background-color: #f2f2f2}th {background-color: #4CAF50;color: white;}</style></head>"
        html += "<table cellpadding='10' cellspacing='0'><tr></td></tr><tr><td><h2>CAR PARKING SYSTEM</h2>Summary Report </td></tr> "
        html += "<tr></table><table border='1'></td></tr>"
        ' Int(x = 0)
        Dim x As Integer
        x = 0
        html += "<tr>"
        html += "<th>No. </th>"
        html += "<th>Car Plate Number</th>"
        html += "<th>Car Model</th>"
        html += "<th>Color </th>"
        html += "<th>Owner Name</th>"
        html += "<th>Telephone</th>"
        html += "<th>Date Time</th>"
        html += "</tr>"
        Dim search As String
        search = "SELECT * FROM `details` WHERE 1"
        con = New MySqlConnection("server=localhost;uid=root;pwd=;database=carparking;")
        'TRY TO OPEN CONNECTION
        con.Open()
        cmd = New MySqlCommand(search, con)
        rdr = cmd.ExecuteReader()
        While rdr.Read()
            x = x + 1
            html += "<tr>"
            html += "<td class='boldCell'>" + x.ToString() + ".</td>"
            html += "<td class='boldCell'>" + rdr.GetString(0) + "</td>"
            html += "<td class='boldCell'>" + rdr.GetString(1) + "</td>"
            html += "<td class='boldCell'>" + rdr.GetString(2) + "</td>"
            html += "<td class='boldCell'>" + rdr.GetString(3) + "</td>"
            html += "<td class='boldCell'>" + rdr.GetString(4) + "</td>"
            html += "<td class='boldCell'>" + rdr.GetString(5) + "</td>"
            html += "</tr>"
        End While
        html += "</table>"
        WebBrowser1.DocumentText = html




    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        Me.Close()
        Environment.Exit(0)
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        WebBrowser1.ShowPrintDialog()

    End Sub

    Private Sub PrintPreviewToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        WebBrowser1.ShowPrintPreviewDialog()

    End Sub

    Private Sub Report_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        GenerateReport()

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class