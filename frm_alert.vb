Imports System.Data.OleDb
Public Class frm_alert
    Dim dbcon As OleDbConnection
    Dim baln As Double
    Dim fdconcmd As OleDbCommand
    Dim fdconstrg As String
    Dim da As OleDb.OleDbDataAdapter
    Dim datareader As OleDbDataReader
    Dim currentDate, compareDate As Date
    Dim alertData As DataSet
    Public rowCount7, rowCount30, rowCount90 As Integer

    Private Sub frm_alert_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub frm_alert_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        dbcon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\db.mdb")

        If Not dbcon.State = ConnectionState.Open Then
            dbcon.Open()
        End If

        currentDate = Date.Today

        '=============================================================
        '            ALERT FOR MATURITY WITHIN 0 TO 7 DAYS
        '=============================================================        

        compareDate = DateAdd("d", 7, currentDate)

        fdconstrg = "select acno,bankname,bname,opendate,maturedate,depoamt,intrate,matureamt from ACCOUNTS where maturedate between #" & _
        CDate(currentDate) & "# and #" & CDate(compareDate) & "#"

        fdconcmd = New OleDbCommand(fdconstrg, dbcon)
        da = New OleDbDataAdapter(fdconcmd)
        alertData = New DataSet()
        da.Fill(alertData, "My Table")
        dgv_7.DataSource = alertData.Tables("My Table")

        rowCount7 = alertData.Tables(0).Rows.Count

        '=============================================================
        '            ALERT FOR MATURITY WITHIN 8 TO 30 DAYS
        '=============================================================        

        currentDate = compareDate
        compareDate = DateAdd("d", 30, currentDate)

        fdconstrg = "select acno,bankname,bname,opendate,maturedate,depoamt,intrate,matureamt from ACCOUNTS where maturedate between #" & _
        CDate(currentDate) & "# and #" & CDate(compareDate) & "#"

        fdconcmd = New OleDbCommand(fdconstrg, dbcon)
        da = New OleDbDataAdapter(fdconcmd)
        alertData = New DataSet()
        da.Fill(alertData, "My Table")
        dgv_30.DataSource = alertData.Tables("My Table")

        rowCount30 = alertData.Tables(0).Rows.Count

        '=============================================================
        '            ALERT FOR MATURITY WITHIN 30 TO 90 DAYS
        '=============================================================        

        currentDate = compareDate
        compareDate = DateAdd("d", 90, currentDate)

        fdconstrg = "select acno,bankname,bname,opendate,maturedate,depoamt,intrate,matureamt from ACCOUNTS where maturedate between #" & _
        CDate(currentDate) & "# and #" & CDate(compareDate) & "#"

        fdconcmd = New OleDbCommand(fdconstrg, dbcon)
        da = New OleDbDataAdapter(fdconcmd)
        alertData = New DataSet()
        da.Fill(alertData, "My Table")
        dgv_90.DataSource = alertData.Tables("My Table")

        rowCount90 = alertData.Tables(0).Rows.Count

        dbcon.Close()

        frm_home.lbl_7days.Text = rowCount7
        frm_home.lbl_30days.Text = rowCount30
        frm_home.lbl_90days.Text = rowCount90
    End Sub

End Class