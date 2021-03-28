Imports System.Data.OleDb

Public Class frm_currentstatus
    Dim dbcon As OleDbConnection
    Dim csconcmd As OleDbCommand
    Dim csconstrg As String
    Dim da As OleDb.OleDbDataAdapter
    Dim datareader As OleDbDataReader
    Dim csdata As DataSet
    Dim rowCount As Double
    Dim acctype, condition, fieldNames As String
    Dim acctype_prt, condition_prt, conditionValue_prt, fieldNames_prt, fromFieldNames_prt As String
    Dim i As Integer

    'Private Sub frm_currentstatus_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    '    If My.Computer.FileSystem.FileExists("c:\db.mdb") Then
    '        My.Computer.FileSystem.DeleteFile("c:\db.mdb")
    '    End If
    'End Sub

    Private Sub frm_cs_fd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        AcceptButton() = cmd_show
        dbcon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\db.mdb")
        Call reset()

    End Sub

    Public Sub reset()

        lbl_bank.Visible = False
        cmb_bank.Visible = False
        lbl_date.Visible = False
        lbl_to.Visible = False
        txt_ed.Visible = False
        lbl_dateinfo.Visible = False
        txt_sd.Visible = False
        dtp_ed.Visible = False
        dtp_sd.Visible = False

    End Sub

    Public Sub clearField()

        cmb_bank.Text = ""
        cmb_show.Text = ""
        cmb_acctype.Text = ""
        txt_ed.Text = ""
        txt_sd.Text = ""
        dgv_cs.DataSource = ""

    End Sub

    Public Sub clearVariable_prt()

        acctype_prt = ""
        condition_prt = ""
        conditionValue_prt = ""
        fieldNames_prt = ""
        fromFieldNames_prt = ""

    End Sub

    Public Sub deletePrintTable()

        csconstrg = "DELETE CURRENTSTATUS.* FROM CURRENTSTATUS"
        csconcmd = New OleDbCommand(csconstrg, dbcon)
        i = csconcmd.ExecuteNonQuery

    End Sub

    Public Sub showAllRecord()

        '============================================================
        '           LOADING GRID VIEW FOR ALL RECORDS
        '============================================================

        If Not dbcon.State = ConnectionState.Open Then
            dbcon.Open()
        End If

        On Error Resume Next

        Call deletePrintTable()

        csconstrg = "INSERT INTO CURRENTSTATUS " & fieldNames_prt & "SELECT " & fromFieldNames_prt & " FROM ACCOUNTS " & condition_prt
        csconcmd = New OleDbCommand(csconstrg, dbcon)
        i = csconcmd.ExecuteNonQuery

        Call clearVariable_prt()

        csconstrg = "select " & fieldNames & " from ACCOUNTS where " & acctype
        csconcmd = New OleDbCommand(csconstrg, dbcon)

        da = New OleDb.OleDbDataAdapter(csconcmd)
        csdata = New DataSet()
        da.Fill(csdata, "My Table")
        dgv_cs.DataSource = csdata.Tables("My Table").DefaultView

        dbcon.Close()
    End Sub

    Public Sub showByBankName()

        '============================================================
        '           LOADING GRID VIEW BY BANK NAME
        '============================================================

        If Not dbcon.State = ConnectionState.Open Then
            dbcon.Open()
        End If

        On Error Resume Next

        Call deletePrintTable()

        csconstrg = "INSERT INTO CURRENTSTATUS " & fieldNames_prt & "SELECT " & fromFieldNames_prt & " FROM ACCOUNTS " & condition_prt
        csconcmd = New OleDbCommand(csconstrg, dbcon)
        i = csconcmd.ExecuteNonQuery

        Call clearVariable_prt()

        csconstrg = "select " & fieldNames & " from ACCOUNTS where bankname = '" & cmb_bank.Text & "' and " & acctype
        csconcmd = New OleDbCommand(csconstrg, dbcon)

        da = New OleDb.OleDbDataAdapter(csconcmd)
        csdata = New DataSet()
        da.Fill(csdata, "My Table")
        dgv_cs.DataSource = csdata.Tables("My Table").DefaultView

        dbcon.Close()

    End Sub

    Public Sub showByDate()

        '==============================================================
        '           LOADING GRID VIEW BY DATE OF TRANSACTION
        '==============================================================
        On Error Resume Next

        If txt_ed.Text = "" Then

            If txt_sd.Text = "" Then
                MsgBox("Enter starting date first")
                Exit Sub
            End If

            If Not dbcon.State = ConnectionState.Open Then
                dbcon.Open()
            End If

            Call deletePrintTable()

            condition_prt = "WHERE (((ACCOUNTS.opendate) <= #" & Trim(CDate(txt_sd.Text)) & "#) AND ((ACCOUNTS.acctype) = '" & acctype_prt & "'))"
            csconstrg = "INSERT INTO CURRENTSTATUS " & fieldNames_prt & "SELECT " & fromFieldNames_prt & " FROM ACCOUNTS " & condition_prt
            csconcmd = New OleDbCommand(csconstrg, dbcon)
            i = csconcmd.ExecuteNonQuery

            Call clearVariable_prt()

            csconstrg = "select " & fieldNames & " from ACCOUNTS where " & condition & " <= #" & _
            CDate(txt_sd.Text) & "# and " & acctype

            csconcmd = New OleDbCommand(csconstrg, dbcon)
            da = New OleDb.OleDbDataAdapter(csconcmd)
            csdata = New DataSet()
            da.Fill(csdata, "My Table")
            dgv_cs.DataSource = csdata.Tables("My Table").DefaultView

            dbcon.Close()

        Else

            If txt_sd.Text = "" Or txt_ed.Text = "" Then
                MsgBox("Enter starting date first")
                Exit Sub
            ElseIf Not (CDate(txt_ed.Text) > CDate(txt_sd.Text)) Then
                MsgBox("Date difference not valid")
                Exit Sub
            End If

            If Not dbcon.State = ConnectionState.Open Then
                dbcon.Open()
            End If

            Call deletePrintTable()

            condition_prt = "WHERE ((((ACCOUNTS.opendate) BETWEEN #" & Trim(CDate(txt_sd.Text)) & "# AND #" & Trim(CDate(txt_ed.Text)) & "#) AND ((ACCOUNTS.acctype) = '" & acctype_prt & "')))"
            csconstrg = "INSERT INTO CURRENTSTATUS " & fieldNames_prt & "SELECT " & fromFieldNames_prt & " FROM ACCOUNTS " & condition_prt
            csconcmd = New OleDbCommand(csconstrg, dbcon)
            i = csconcmd.ExecuteNonQuery

            Call clearVariable_prt()

            csconstrg = "select " & fieldNames & " from ACCOUNTS where " & condition & " between #" & _
            CDate(txt_sd.Text) & "# and #" & CDate(txt_ed.Text) & "# and " & acctype
            csconcmd = New OleDbCommand(csconstrg, dbcon)
            da = New OleDb.OleDbDataAdapter(csconcmd)
            csdata = New DataSet()
            da.Fill(csdata, "My Table")
            dgv_cs.DataSource = csdata.Tables("My Table").DefaultView

            dbcon.Close()
        End If
    End Sub

    Public Sub loadBankName()

        '==============================================================
        '                  BANK NAME LOADING FUNCTION
        '==============================================================

        cmb_bank.Text = ""
        cmb_bank.Items.Clear()

        If Not dbcon.State = ConnectionState.Open Then
            dbcon.Open()
        End If

        csconstrg = "select bankname from ACCOUNTS where " & acctype
        csconcmd = New OleDbCommand(csconstrg, dbcon)
        datareader = csconcmd.ExecuteReader()

        While datareader.Read()
            If Not cmb_bank.Items.Contains(datareader.Item(0)) Then
                cmb_bank.Items.Add(datareader.Item(0))
            End If
        End While

        dbcon.Close()

        dgv_cs.DataSource = ""

    End Sub

    Private Sub dtp_sd_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_sd.ValueChanged
        txt_sd.Text = dtp_sd.Value
        dgv_cs.DataSource = ""
    End Sub

    Private Sub dtp_ed_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_ed.ValueChanged
        txt_ed.Text = dtp_ed.Value
        dgv_cs.DataSource = ""
    End Sub

    Private Sub cmb_show_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_show.SelectedIndexChanged

        If cmb_show.SelectedItem = "All Record" Then
            Call reset()
            dgv_cs.DataSource = ""
            condition_prt = "WHERE (((ACCOUNTS.acctype)='" & acctype_prt & "'))"
        End If

        If cmb_show.SelectedItem = "By Date" Then
            lbl_bank.Visible = False
            cmb_bank.Visible = False
            lbl_date.Visible = True
            lbl_to.Visible = True
            lbl_dateinfo.Visible = True
            txt_ed.Visible = True
            txt_sd.Visible = True
            dtp_ed.Visible = True
            dtp_sd.Visible = True
            txt_ed.Text = ""
            txt_sd.Text = ""
            dgv_cs.DataSource = ""
        End If

        If cmb_show.SelectedItem = "By Bank Name" Then
            lbl_bank.Visible = True
            cmb_bank.Visible = True
            lbl_date.Visible = False
            lbl_to.Visible = False
            lbl_dateinfo.Visible = False
            txt_ed.Visible = False
            txt_sd.Visible = False
            dtp_ed.Visible = False
            dtp_sd.Visible = False
            dgv_cs.DataSource = ""
        End If

    End Sub

    Private Sub cmb_acctype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_acctype.SelectedIndexChanged

        '======================================================
        '   BANK NAME LOADING AND PRINT VARIABLE ASSIGNMENT
        '======================================================

        If cmb_acctype.SelectedItem = "Fixed Deposit" Then

            acctype = "acctype = 'FIXED DEPOSIT'"

            acctype_prt = "FIXED DEPOSIT"
            fieldNames_prt = "( acno, acctype, bankname, bname, opendate, maturedate, depoamt, intrate, matureamt ) "
            fromFieldNames_prt = "ACCOUNTS.acno, ACCOUNTS.acctype, ACCOUNTS.bankname, ACCOUNTS.bname, ACCOUNTS.opendate, ACCOUNTS.maturedate, ACCOUNTS.depoamt, ACCOUNTS.intrate, ACCOUNTS.matureamt"

            dgv_cs.DataSource = ""
            Call loadBankName()

        End If

        If cmb_acctype.SelectedItem = "Current Account" Then

            acctype = "acctype = 'CURRENT ACCOUNT'"

            acctype_prt = "CURRENT ACCOUNT"
            fieldNames_prt = "( acno, acctype, bankname, bname, opendate, dot, balance ) "
            fromFieldNames_prt = "ACCOUNTS.acno, ACCOUNTS.acctype, ACCOUNTS.bankname, ACCOUNTS.bname, ACCOUNTS.opendate, ACCOUNTS.dot, ACCOUNTS.balance"

            dgv_cs.DataSource = ""
            Call loadBankName()

        End If

        If cmb_acctype.SelectedItem = "Savings Account" Then

            acctype = "acctype = 'SAVINGS ACCOUNT'"

            acctype_prt = "SAVINGS ACCOUNT"
            fieldNames_prt = "( acno, acctype, bankname, bname, opendate, dot, intrate, balance ) "
            fromFieldNames_prt = "ACCOUNTS.acno, ACCOUNTS.acctype, ACCOUNTS.bankname, ACCOUNTS.bname, ACCOUNTS.opendate, ACCOUNTS.dot, ACCOUNTS.intrate, ACCOUNTS.balance"

            dgv_cs.DataSource = ""
            Call loadBankName()

        End If

        If cmb_acctype.SelectedItem = "All Accounts" Then

            acctype = "(acctype = 'FIXED DEPOSIT' or acctype = 'CURRENT ACCOUNT' or acctype = 'SAVINGS ACCOUNT')"

            acctype_prt = "FIXED DEPOSIT')) OR (((ACCOUNTS.acctype)='CURRENT ACCOUNT')) OR (((ACCOUNTS.acctype)='SAVINGS ACCOUNT"
            fieldNames_prt = ""
            fromFieldNames_prt = "ACCOUNTS.*"

            dgv_cs.DataSource = ""
            Call loadBankName()

        End If

    End Sub

    Private Sub cmb_bank_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_bank.SelectedIndexChanged

        dgv_cs.DataSource = ""
        conditionValue_prt = cmb_bank.SelectedItem
        condition_prt = "WHERE (((((ACCOUNTS.acctype)='" & acctype_prt & "'))) AND ((ACCOUNTS.bankname)='" & conditionValue_prt & "'))"

    End Sub

    Private Sub cmd_show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_show.Click

        My.Computer.FileSystem.CopyFile(Application.StartupPath & "\db.mdb", "c:\db.mdb", True)

        '                FIXED DEPOSIT
        '==============================================
        If cmb_acctype.Text = "Fixed Deposit" Then

            fieldNames = "acno,acctype,bankname,bname,opendate,maturedate,depoamt,intrate,matureamt"
            condition = "opendate"
            acctype = "acctype = 'FIXED DEPOSIT'"

            If cmb_show.Text = "All Record" Then
                Call showAllRecord()
                Exit Sub
            End If

            If cmb_show.Text = "By Bank Name" Then
                Call showByBankName()
                Exit Sub
            End If

            If cmb_show.Text = "By Date" Then
                Call showByDate()
                Exit Sub
            End If

        End If

        '                CURRENT ACCOUNT
        '==============================================
        If cmb_acctype.Text = "Current Account" Then

            fieldNames = "acno,acctype,bankname,bname,opendate,dot,balance"
            condition = "opendate"
            acctype = "acctype = 'CURRENT ACCOUNT'"

            If cmb_show.Text = "All Record" Then
                Call showAllRecord()
                Exit Sub
            End If

            If cmb_show.Text = "By Bank Name" Then
                Call showByBankName()
                Exit Sub
            End If

            If cmb_show.Text = "By Date" Then
                Call showByDate()
                Exit Sub
            End If

        End If

        '                SAVINGS ACCOUNT
        '==============================================
        If cmb_acctype.Text = "Savings Account" Then

            fieldNames = "acno,acctype,bankname,bname,opendate,dot,intrate,balance"
            condition = "opendate"
            acctype = "acctype = 'SAVINGS ACCOUNT'"

            If cmb_show.Text = "All Record" Then
                Call showAllRecord()
                Exit Sub
            End If

            If cmb_show.Text = "By Bank Name" Then
                Call showByBankName()
                Exit Sub
            End If

            If cmb_show.Text = "By Date" Then
                Call showByDate()
                Exit Sub
            End If

        End If

        '                ALL ACCOUNTS
        '==============================================
        If cmb_acctype.Text = "All Accounts" Then

            fieldNames = "acno,acctype,bankname,bname,opendate,maturedate,dot,depoamt,intrate,matureamt,balance"
            condition = "opendate"
            acctype = "(acctype = 'FIXED DEPOSIT' or acctype = 'CURRENT ACCOUNT' or acctype = 'SAVINGS ACCOUNT')"

            If cmb_show.Text = "All Record" Then
                Call showAllRecord()
                Exit Sub
            End If

            If cmb_show.Text = "By Bank Name" Then
                Call showByBankName()
                Exit Sub
            End If

            If cmb_show.Text = "By Date" Then
                Call showByDate()
                Exit Sub
            End If

        End If

    End Sub

    Private Sub cmd_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_reset.Click

        Call reset()
        Call clearField()
        dgv_cs.DataSource = ""

    End Sub

    Private Sub cmd_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_print.Click

        '           PRINT ALL RECORD
        '======================================

        With cmb_acctype

            If .Text = "All Accounts" And cmb_show.Text = "All Record" Then
                frm_cs_all.Show()
            End If

            If .Text = "Fixed Deposit" And cmb_show.Text = "All Record" Then
                frm_cs_fd.Show()
            End If

            If .Text = "Current Account" And cmb_show.Text = "All Record" Then
                frm_cs_ca.Show()
            End If

            If .Text = "Savings Account" And cmb_show.Text = "All Record" Then
                frm_cs_sa.Show()
            End If

        End With

        '           PRINT RECORD BY BANKNAME
        '============================================

        With cmb_acctype

            If .Text = "All Accounts" And cmb_show.Text = "By Bank Name" Then
                frm_cs_all.Show()
            End If

            If .Text = "Fixed Deposit" And cmb_show.Text = "By Bank Name" Then
                frm_cs_fd.Show()
            End If

            If .Text = "Current Account" And cmb_show.Text = "By Bank Name" Then
                frm_cs_ca.Show()
            End If

            If .Text = "Savings Account" And cmb_show.Text = "By Bank Name" Then
                frm_cs_sa.Show()
            End If

        End With

        '          PRINT RECORD BY DATE 
        '=======================================

        With cmb_acctype

            If .Text = "All Accounts" And cmb_show.Text = "By Date" Then
                frm_cs_all.Show()
            End If

            If .Text = "Fixed Deposit" And cmb_show.Text = "By Date" Then
                frm_cs_fd.Show()
            End If

            If .Text = "Current Account" And cmb_show.Text = "By Date" Then
                frm_cs_ca.Show()
            End If

            If .Text = "Savings Account" And cmb_show.Text = "By Date" Then
                frm_cs_sa.Show()
            End If

        End With

    End Sub

End Class
