Imports System.Data.OleDb
Public Class frm_ca_new
    Dim dbcon As OleDbConnection
    Dim caconcmd As OleDbCommand
    Dim caconstrg As String
    Dim saconcmd As OleDbCommand
    Dim saconstrg As String
    Dim ttconcmd As OleDbCommand
    Dim ttconstrg1, ttconstrg2, frmstr, tostr As String
    Dim datareader As OleDbDataReader
    Dim baln As Double
    Dim tid As Double
    Dim j, l, m As Integer
    Public charecter As Char 'validation
    Public ascii As Integer ' validation
    Private acctype As String ' validation

    Private Sub frm_ca_new_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dbcon = New OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & Application.StartupPath & "\db.mdb")
        AcceptButton() = cmd_ok
        Call clearfield()

    End Sub

    Public Sub getTransId()

        ttconstrg2 = "select max(idno) from TT"
        ttconcmd = New OleDbCommand(ttconstrg2, dbcon)
        datareader = ttconcmd.ExecuteReader()
        datareader.Read()

        If datareader.HasRows Then
            tid = datareader.Item(0)
            tid += 1
        Else
            tid = 1
        End If

    End Sub

    Public Sub clearfield()
        txt_an.Text = ""
        txt_blnc.Text = ""
        txt_bn.Text = ""
        txt_brn.Text = ""
        dtp_dd.Value = Date.Today
        txt_dot.Text = ""
        txt_tan.Text = ""
        cmb_mod.SelectedItem = "Cash"
        txt_bn.Focus()
    End Sub

    Public Sub checkTableUpdate()

        If Not j = 1 Then
            MsgBox("Error in Inserting data into ACCOUNTS Table")
        ElseIf Not l = 1 Then
            MsgBox("Error in Updating Current/Savings Account")
        ElseIf Not m = 1 Then
            MsgBox("Error in Updating Transaction Table")
        ElseIf (j = 1 And l = 1 And m = 1) Then
            MsgBox("Record Inserted Successfully")
        End If

    End Sub

    Private Sub dtp_dd_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_dd.ValueChanged
        txt_dot.Text = dtp_dd.Value
    End Sub

    Private Sub cmb_mod_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_mod.SelectedIndexChanged
        If cmb_mod.SelectedItem = "Account Transfer" Then
            lbl_toa.Visible = True
            cmb_toa.Visible = True
            lbl_tan.Visible = False
            txt_tan.Visible = False
        End If

        If cmb_mod.SelectedItem = "Cash" Then
            cmb_toa.Text = ""
            txt_tan.Text = ""
            lbl_toa.Visible = False
            cmb_toa.Visible = False
            lbl_tan.Visible = False
            txt_tan.Visible = False
        End If
    End Sub

    Private Sub cmb_toa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_toa.SelectedIndexChanged
        lbl_tan.Visible = True
        txt_tan.Visible = True
    End Sub

    Private Sub cmd_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_ok.Click

        If MessageBox.Show("Confirm Record Insert?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            If txt_bn.Text = "" Then
                MsgBox("Insert name of the bank")
            ElseIf txt_brn.Text = "" Then
                MsgBox("Insert branch name")
            ElseIf txt_an.Text = "" Then
                MsgBox("Insert account no")
            ElseIf txt_dot.Text = "" Then
                MsgBox("Insert date of transaction")
            ElseIf txt_blnc.Text = "" Then
                MsgBox("Insert amount deposited")
            ElseIf cmb_mod.SelectedItem = "" Then
                MsgBox("Please enter mode of transaction")
            ElseIf cmb_mod.Text = "Account Transfer" And cmb_toa.Text = "" Then
                MsgBox("Please enter type of account")
            Else

                If Not dbcon.State = ConnectionState.Open Then
                    dbcon.Open()
                End If

                caconstrg = "insert into ACCOUNTS (acno,acctype,bankname,bname,opendate,dot,balance)values (" & _
                txt_an.Text & ",'CURRENT ACCOUNT','" & UCase(txt_bn.Text) & "','" & UCase(txt_brn.Text) & "','" & _
                Trim(CDate(txt_dot.Text)) & "','" & Trim(CDate(txt_dot.Text)) & "'," & txt_blnc.Text & ")"

                '.......................................
                'ACCOUNT TRANSFER FROM SAVINGS ACCOUNT
                '.......................................

                If cmb_toa.SelectedItem = "Savings Account" Then

                    If Not txt_tan.Text = "" Then

                        If Not dbcon.State = ConnectionState.Open Then
                            dbcon.Open()
                        End If

                        saconstrg = "select acno, acctype, balance from ACCOUNTS where (acno=" & _
                        txt_tan.Text & " and acctype = 'SAVINGS ACCOUNT')"

                        saconcmd = New OleDbCommand(saconstrg, dbcon)
                        datareader = saconcmd.ExecuteReader()
                        datareader.Read()

                        If datareader.HasRows Then
                            baln = datareader.Item(2)
                        Else
                            MsgBox("Invalid Savings Account Number")
                            dbcon.Close()
                            Exit Sub
                        End If

                        baln -= Val(txt_blnc.Text)
                        If baln < 0 Then
                            MsgBox("Insufficient balance in selected account for fund transfer")
                            Exit Sub
                        End If

                        saconstrg = "update ACCOUNTS set balance=" & baln & " where (acno= " & _
                        txt_tan.Text & " and acctype = 'SAVINGS ACCOUNT')"

                        saconcmd = New OleDbCommand(saconstrg, dbcon)
                        l = saconcmd.ExecuteNonQuery

                        caconcmd = New OleDbCommand(caconstrg, dbcon)
                        j = caconcmd.ExecuteNonQuery

                        Call getTransId()

                        frmstr = UCase(cmb_toa.SelectedItem) & " NO. " & txt_tan.Text
                        tostr = "CA ACCOUNT NO. " & txt_an.Text
                        ttconstrg1 = "insert into TT values (" & tid & ",'" & Trim(CDate(Date.Today)) & "','" & _
                        frmstr & "','" & tostr & "'," & txt_blnc.Text & ",'ACCOUNT CREATED')"

                        ttconcmd = New OleDbCommand(ttconstrg1, dbcon)
                        m = ttconcmd.ExecuteNonQuery

                        Call checkTableUpdate()
                        Call clearfield()

                        dbcon.Close()
                        Exit Sub
                    Else
                        MsgBox("Enter debit account number")
                        Exit Sub
                    End If

                End If

                '......................................
                'ACCOUNT TRANSFER FROM CURRENT ACCOUNT
                '......................................

                If cmb_toa.SelectedItem = "Current Account" Then

                    If Not txt_tan.Text = "" Then

                        If Not dbcon.State = ConnectionState.Open Then
                            dbcon.Open()
                        End If

                        saconstrg = "select acno, acctype, balance from ACCOUNTS where (acno=" & txt_tan.Text & " and acctype = 'CURRENT ACCOUNT')"
                        saconcmd = New OleDbCommand(saconstrg, dbcon)
                        datareader = saconcmd.ExecuteReader()
                        datareader.Read()

                        If datareader.HasRows Then
                            baln = datareader.Item(2)
                        Else
                            MsgBox("Invalid Current Account Number")
                            dbcon.Close()
                            Exit Sub
                        End If

                        baln -= Val(txt_blnc.Text)
                        If baln < 0 Then
                            MsgBox("Insufficient balance in selected account for fund transfer")
                            Exit Sub
                        End If

                        saconstrg = "update ACCOUNTS set balance=" & baln & " where (acno= " & txt_tan.Text & " and acctype = 'CURRENT ACCOUNT')"
                        saconcmd = New OleDbCommand(saconstrg, dbcon)
                        l = saconcmd.ExecuteNonQuery

                        caconcmd = New OleDbCommand(caconstrg, dbcon)
                        j = caconcmd.ExecuteNonQuery

                        Call getTransId()

                        frmstr = UCase(cmb_toa.SelectedItem) & " NO. " & txt_tan.Text
                        tostr = "CA ACCOUNT NO. " & txt_an.Text
                        ttconstrg1 = "insert into TT values (" & tid & ",'" & Trim(CDate(Date.Today)) & "','" & _
                        frmstr & "','" & tostr & "'," & txt_blnc.Text & ",'ACCOUNT CREATED')"

                        ttconcmd = New OleDbCommand(ttconstrg1, dbcon)
                        m = ttconcmd.ExecuteNonQuery

                        Call checkTableUpdate()
                        Call clearfield()
                        Exit Sub
                        dbcon.Close()

                    Else
                        MsgBox("Enter debit account number")
                        Exit Sub
                    End If

                End If

                '...................
                'CASH DEPOSIT
                '...................

                If cmb_mod.SelectedItem = "Cash" Then

                    caconcmd = New OleDbCommand(caconstrg, dbcon)
                    j = caconcmd.ExecuteNonQuery

                    Call getTransId()

                    tostr = "CA ACCOUNT NO " & txt_an.Text
                    ttconstrg1 = "insert into TT values (" & tid & ",'" & Trim(CDate(Date.Today)) & "','CASH','" & _
                    tostr & "'," & txt_blnc.Text & ",'ACCOUNT CREATED')"

                    ttconcmd = New OleDbCommand(ttconstrg1, dbcon)
                    Dim m As Integer = ttconcmd.ExecuteNonQuery

                    If Not j = 1 Then
                        MsgBox("Error in Inserting data into ACCOUNTS Table")
                    ElseIf Not m = 1 Then
                        MsgBox("Error in Updating Transaction Table")
                    ElseIf (j = 1 And m = 1) Then
                        MsgBox("Record Inserted Successfully")
                    End If

                    Call clearfield()
                    dbcon.Close()
                    Exit Sub
                End If
                dbcon.Close()
            End If
        End If
    End Sub

    Private Sub cmd_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_reset.Click

        If MessageBox.Show("Confirm Data Reset ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Call clearfield()
        End If

    End Sub

    '=================================================================
    '                   TEXT VALIDATION OF DATA FIELDS
    '=================================================================

    Private Sub txt_bn_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_bn.Validating
        Call txt_bn_validate()
    End Sub

    Private Sub txt_brn_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_brn.Validating
        Call txt_brn_validate()
    End Sub

    Private Sub txt_an_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_an.Validating
        Call txt_an_validate()
    End Sub

    Private Sub txt_blnc_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_blnc.Validating
        Call txt_amt_validate()
    End Sub

    Private Sub txt_tan_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_tan.Validating
        Call txt_tan_validate()
    End Sub

    '=================================================================
    '                   TEXT VALIDATION FUNCTIONS
    '=================================================================

    Public Sub txt_an_validate()
        For i = 1 To Len(txt_an.Text)
            charecter = GetChar(txt_an.Text, i)
            ascii = Asc(charecter)
            If Not (ascii >= 48 And ascii <= 57) Then
                MsgBox("Special charecter(s)/ Alphanumeric(s) not allowed")
                txt_an.Focus()
                Exit Sub
            End If
        Next

        If Not Len(txt_an.Text) <= 19 Then
            MsgBox("Account number limitation within 19 digits")
            txt_an.Focus()
            Exit Sub
        End If

        If Not dbcon.State = ConnectionState.Open Then
            dbcon.Open()
        End If

        If Not txt_an.Text = "" Then
            caconstrg = "select * from ACCOUNTS where (acno = " & txt_an.Text & " and acctype = 'CURRENT ACCOUNT')"
            caconcmd = New OleDbCommand(caconstrg, dbcon)
            datareader = caconcmd.ExecuteReader()
            datareader.Read()
            If datareader.HasRows Then
                MsgBox("Account number already exists.")
                txt_an.Clear()
                txt_an.Focus()
            End If
        End If

    End Sub

    Public Sub txt_bn_validate()
        For i = 1 To Len(txt_bn.Text)
            charecter = GetChar(txt_bn.Text, i)
            ascii = Asc(charecter)
            If Not (ascii = 32 Or (ascii >= 65 And ascii <= 90) _
                    Or (ascii >= 97 And ascii <= 122)) Then
                MsgBox("Number(s) and special charecter(s) not allowed")
                txt_bn.Focus()
                Exit For
            End If
        Next

        If Not Len(txt_bn.Text) <= 250 Then
            MsgBox("Bank name limitation within 250 charecters")
            txt_bn.Focus()
        End If
    End Sub

    Public Sub txt_brn_validate()
        For i = 1 To Len(txt_brn.Text)
            charecter = GetChar(txt_brn.Text, i)
            ascii = Asc(charecter)
            If Not (ascii = 32 Or (ascii >= 48 And ascii <= 57) Or (ascii >= 65 And ascii <= 90) _
                    Or (ascii >= 97 And ascii <= 122) Or ascii = 46) Then
                MsgBox("Special charecter(s) not allowed")
                txt_brn.Focus()
                Exit For
            End If
        Next

        If Not Len(txt_brn.Text) <= 250 Then
            MsgBox("Branch name limitation within 250 charecters")
            txt_brn.Focus()
        End If
    End Sub

    Public Sub txt_amt_validate()
        For i = 1 To Len(txt_blnc.Text)
            charecter = GetChar(txt_blnc.Text, i)
            ascii = Asc(charecter)
            If Not ((ascii >= 48 And ascii <= 57) Or ascii = 46) Then
                MsgBox("Special charecter(s)/ Alphanumeric(s) not allowed")
                txt_blnc.Focus()
                Exit Sub
            End If
        Next

        If Not Len(txt_blnc.Text) <= 19 Then
            MsgBox("Account number limitation within 19 digits")
            txt_blnc.Focus()
            Exit Sub
        End If
    End Sub

    Public Sub txt_tan_validate()
        acctype = UCase(cmb_toa.Text)
        For i = 1 To Len(txt_tan.Text)
            charecter = GetChar(txt_tan.Text, i)
            ascii = Asc(charecter)
            If Not (ascii >= 48 And ascii <= 57) Then
                MsgBox("Special charecter(s)/ Alphanumeric(s) not allowed")
                txt_tan.Focus()
                Exit Sub
            End If
        Next

        If Not Len(txt_tan.Text) <= 19 Then
            MsgBox("Account number limitation within 19 digits")
            txt_tan.Focus()
        End If

        If Not txt_tan.Text = "" Then
            caconstrg = "select * from ACCOUNTS where (acno = " & txt_tan.Text & " and acctype = '" & acctype & "')"
            caconcmd = New OleDbCommand(caconstrg, dbcon)
            datareader = caconcmd.ExecuteReader()
            datareader.Read()
            If Not datareader.HasRows Then
                MsgBox("Account number given for fund transfer doesnot exists.")
                txt_tan.Clear()
                txt_tan.Focus()
            End If
        End If
    End Sub

End Class