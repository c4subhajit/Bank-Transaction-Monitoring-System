Imports System.Data.OleDb
Public Class frm_home
    Dim fileName As String
    Dim backUpPath As String
    Dim dbcon As OleDbConnection
    Dim fdconcmd, mtconcmd, ttconcmd As OleDbCommand
    Dim fdconstrg1, fdconstrg2, ttconstrg1, ttconstrg2, mtconstrg As String
    Dim da As OleDb.OleDbDataAdapter
    Dim dataReaderAT, dataReaderTT As OleDbDataReader
    Dim i, j, k, l As Integer
    Dim tid As Double
    Dim frmstr, tostr As String
    Dim currentDate As Date
    Public acctype_sr_bn, fieldName_sr_bn As String 'for search by bank name
    Public lbl_text, query_txt, no_record_msg, frm_name As String ' for FD search by date of Opening/Maturity
    Public acctype_sr_dot_CaSa As String 'for Ca/Sa search by date of transaction

    Private Sub home_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        With Timer_Clock
            .Enabled() = True
            .Start()
            .Interval = 1000
        End With

        MenuStrip_TFDPC.Enabled = False
        lbl_7days.Enabled = False
        lbl_30days.Enabled = False
        lbl_90days.Enabled = False

        Try
            Dim form As New frm_login
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try

        Call dbExistCheck()

        dbcon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\db.mdb")

    End Sub

    Private Sub NewRecordFD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewRecordFD.Click
        Try
            Dim form As New frm_fd_new
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try

    End Sub

    Private Sub ModifyRecordFD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifyRecordFD.Click
        Try
            Dim form As New frm_fd_modify
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub DeleteRecordFD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteRecordFD.Click
        Try
            Dim form As New frm_fd_delete
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub NewRecordCA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewRecordCA.Click
        Try
            Dim form As New frm_ca_new
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub ModifyRecordCA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifyRecordCA.Click
        Try
            Dim form As New frm_ca_modify
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub DeleteRecordCA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteRecordCA.Click
        Try
            Dim form As New frm_ca_delete
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub DebitCA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DebitCA.Click
        Try
            Dim form As New frm_ca_debit
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub CreditCA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreditCA.Click
        Try
            Dim form As New frm_ca_credit
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub NewRecordSA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewRecordSA.Click
        Try
            Dim form As New frm_sa_new
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub ModifyRecordSA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifyRecordSA.Click
        Try
            Dim form As New frm_sa_modify
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub DeleteRecordSA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteRecordSA.Click
        Try
            Dim form As New frm_sa_delete
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub DebitSA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DebitSA.Click
        Try
            Dim form As New frm_sa_debit
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub CreditSA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreditSA.Click
        Try
            Dim form As New frm_sa_credit
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub ByAccountNumberFD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByAccountNumberFD.Click
        Try
            Dim form As New frm_sr_fdan
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub ByAccountNumberCA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByAccountNumberCA.Click
        Try
            Dim form As New frm_sr_caan
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub ByAccountNumberSA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByAccountNumberSA.Click
        Try
            Dim form As New frm_sr_saan
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub ByBankNameFD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByBankNameFD.Click
        acctype_sr_bn = "FIXED DEPOSIT"
        fieldName_sr_bn = "acno,acctype,bankname,bname,opendate,maturedate,depoamt,intrate,matureamt"
        Try
            Dim form As New frm_sr_bn
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub ByBankNameCA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByBankNameCA.Click
        acctype_sr_bn = "CURRENT ACCOUNT"
        fieldName_sr_bn = "acno,acctype,bankname,bname,opendate,dot,balance"
        Try
            Dim form As New frm_sr_bn
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub ByBankNameSA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByBankNameSA.Click
        acctype_sr_bn = "SAVINGS ACCOUNT"
        fieldName_sr_bn = "acno,acctype,bankname,bname,opendate,intrate,dot,balance"
        Try
            Dim form As New frm_sr_bn
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub ByDateOfOpeningFD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByDateOfOpeningFD.Click
        query_txt = "opendate"
        lbl_text = "Date of Opening"
        no_record_msg = "No Fixed Deposit Created"
        frm_name = "Search by Date of Opening"
        Try
            Dim form As New frm_sr_fddate
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub ByDateOfMaturityFD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByDateOfMaturityFD.Click
        query_txt = "maturedate"
        lbl_text = "Date of Maturity"
        no_record_msg = "No Fixed Deposit Maturing"
        frm_name = "Search by Date of Maturity"
        Try
            Dim form As New frm_sr_fddate
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub ByDateOfTransactionCA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByDateOfTransactionCA.Click
        acctype_sr_dot_CaSa = "CURRENT ACCOUNT"
        Try
            Dim form As New frm_sr_dotCaSa
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub ByDateOfTransactionSA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByDateOfTransactionSA.Click
        acctype_sr_dot_CaSa = "SAVINGS ACCOUNT"
        Try
            Dim form As New frm_sr_dotCaSa
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub Transaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Transaction.Click
        Try
            Dim form As New frm_trans
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try

    End Sub

    Private Sub Alert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Alert.Click
        Try
            Dim form As New frm_alert
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try

    End Sub

    Private Sub About_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles About.Click
        Try
            Dim form As New frm_about
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub CurrentStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CurrentStatus.Click
        Try
            Dim form As New frm_currentstatus
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try

    End Sub

    Private Sub Calculator_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calculator.Click
        System.Diagnostics.Process.Start("calc")
    End Sub

    Private Sub Notepad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Notepad.Click
        System.Diagnostics.Process.Start("notepad")
    End Sub

    Private Sub Exit_soft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exit_soft.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub Logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Logout.Click
        Me.Enabled = False
        frm_login.Show()
    End Sub

    Private Sub home_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus

        Call maturityCheck()
        lbl_7days.Text = frm_alert.rowCount7
        lbl_30days.Text = frm_alert.rowCount30
        lbl_90days.Text = frm_alert.rowCount90

    End Sub

    Public Sub maturityCheck()

        If Not dbcon.State = ConnectionState.Open Then
            dbcon.Open()
        End If

        currentDate = Date.Today

        fdconstrg1 = "select acno,acctype,bankname,bname,opendate,maturedate,depoamt,intrate,matureamt from ACCOUNTS where (maturedate < #" & _
        currentDate & "# and acctype = 'FIXED DEPOSIT')"

        fdconcmd = New OleDbCommand(fdconstrg1, dbcon)
        i = fdconcmd.ExecuteNonQuery

        dataReaderAT = fdconcmd.ExecuteReader()
        dataReaderAT.Read()
        If dataReaderAT.HasRows Then

            '============      UPDATING MATURE TABLE       ===============

            mtconstrg = "insert into MT values (" & dataReaderAT.Item(0) & ",'" & dataReaderAT.Item(2) & _
            "','" & dataReaderAT.Item(3) & "','" & dataReaderAT.Item(4) & "','" & dataReaderAT.Item(5) & _
            "'," & dataReaderAT.Item(6) & "," & dataReaderAT.Item(7) & "," & dataReaderAT.Item(8) & ")"

            mtconcmd = New OleDbCommand(mtconstrg, dbcon)

            j = mtconcmd.ExecuteNonQuery

            '============      UPDATING TRANSACTION TABLE       ===============

            ttconstrg2 = "select max(idno) from TT"
            ttconcmd = New OleDbCommand(ttconstrg2, dbcon)
            dataReaderTT = ttconcmd.ExecuteReader()
            dataReaderTT.Read()

            If dataReaderTT.HasRows Then
                tid = dataReaderTT.Item(0)
                tid += 1
            Else
                tid = 1
            End If

            tostr = "FD ACCOUNT NO. " & dataReaderAT.Item(0)
            ttconstrg1 = "insert into TT values (" & tid & ",'" & dataReaderAT.Item(4) & "','','" & _
            tostr & "'," & dataReaderAT.Item(6) & ",'ACCOUNT MATURED')"

            ttconcmd = New OleDbCommand(ttconstrg1, dbcon)
            k = ttconcmd.ExecuteNonQuery

            '============      UPDATING ACCOUNTS TABLE       ===============

            fdconstrg2 = "delete from ACCOUNTS where (acno = " & dataReaderAT.Item(0) & " and acctype = 'FIXED DEPOSIT')"
            fdconcmd = New OleDbCommand(fdconstrg2, dbcon)
            l = fdconcmd.ExecuteNonQuery

            If Not j = 1 Then
                MsgBox("Error in Inserting data into MT Table")
            ElseIf Not k = 1 Then
                MsgBox("Error in Updating Transaction Table")
            ElseIf Not l = 1 Then
                MsgBox("Error in deleting matured FD details from ACCOUNTS Table")
            ElseIf (j = 1 And k = 1 And l = 1) Then
                MsgBox("A FIXED DEPOSIT MATURED TODAY")
            End If

            dbcon.Close()
        Else
            dbcon.Close()
        End If

    End Sub

    Private Sub BackDatabaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackDatabaseToolStripMenuItem.Click

        FBD_dbBackup.ShowDialog()
        FBD_dbBackup.RootFolder = Environment.SpecialFolder.MyComputer
        My.Computer.FileSystem.CopyFile(Application.StartupPath & "\db.mdb", FBD_dbBackup.SelectedPath & "\db.mdb", True)

    End Sub

    Public Sub dbExistCheck()

        If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\db.mdb") Then
            MsgBox("Software database not found. Please browse database file.")
            OFD_db.ShowDialog()
            fileName = My.Computer.FileSystem.GetName(OFD_db.FileName)
            My.Computer.FileSystem.CopyFile(OFD_db.FileName, Application.StartupPath & "\" & fileName, True)
        End If

    End Sub

    Private Sub Timer_Clock_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer_Clock.Tick
        lbl_clock.Text = My.Computer.Clock.LocalTime.ToString
    End Sub

End Class
