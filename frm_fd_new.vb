Imports System.Data.OleDb

Public Class frm_fd_new
    Dim dbcon As OleDbConnection
    Dim baln As Double
    Dim fdconcmd As OleDbCommand
    Dim fdconstrg As String
    Dim caconcmd As OleDbCommand
    Dim caconstrg As String
    Dim datareader As OleDb.OleDbDataReader
    Dim ttconcmd As OleDbCommand
    Dim frmstr, tostr, ttconstrg1, ttconstrg2 As String
    Dim tid As Double
    Dim saconcmd As OleDbCommand
    Dim saconstrg As String
    Dim j, l, m As Integer
    Public charecter As Char 'validation
    Public ascii As Integer ' validation
    Private acctype As String ' validation

    Private Sub frm_fd_new_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        AcceptButton() = cmd_ok
        dbcon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\db.mdb")
        Call clearFields()

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

    Public Sub clearFields()

        txt_bn.Text = ""
        txt_brn.Text = ""
        txt_an.Text = ""
        txt_da.Text = ""
        txt_ir.Text = ""
        dtp_dd.Value = Date.Today
        txt_dd.Text = ""
        dtp_md.Value = Date.Today
        txt_md.Text = ""
        txt_mv.Text = ""
        txt_tan.Text = ""
        cmb_mod.SelectedItem = "Cash"
        txt_bn.Focus()

    End Sub

    Public Sub checkTableUpdate()

        If Not j = 1 Then
            MsgBox("Error in Inserting data into ACCOUNTS Table")
        ElseIf Not l = 1 Then
            MsgBox("Error in Updating Current Account")
        ElseIf Not m = 1 Then
            MsgBox("Error in Updating Transaction Table")
        ElseIf (j = 1 And l = 1 And m = 1) Then
            MsgBox("Record Inserted Successfully")
            Call clearFields()
        End If

    End Sub

    Private Sub dtp_dd_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_dd.ValueChanged
        txt_dd.Text = dtp_dd.Value
    End Sub

    Private Sub dtp_md_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_md.ValueChanged
        If Not txt_dd.Text = "" Then
            txt_md.Text = dtp_md.Value
        End If
    End Sub

    Private Sub cmb_mod_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_mod.SelectedIndexChanged

        If cmb_mod.SelectedItem = "Account Transfer" Then
            cmb_toa.Visible = True
            lbl_toa.Visible = True
            txt_tan.Visible = False
            lbl_tan.Visible = False
        End If

        If cmb_mod.SelectedItem = "Cash" Then
            cmb_toa.Visible = False
            txt_tan.Visible = False
            lbl_tan.Visible = False
            lbl_toa.Visible = False
            cmb_toa.Text = ""
            txt_tan.Text = ""
        End If

    End Sub

    Private Sub cmb_toa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_toa.SelectedIndexChanged
        lbl_tan.Visible = True
        txt_tan.Visible = True
    End Sub

    Private Sub cmd_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_ok.Click

        If MessageBox.Show("Confirm Record Insert?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            If txt_an.Text = "" Then
                MsgBox("Please Enter Account Number")
            ElseIf txt_bn.Text = "" Then
                MsgBox("Please Enter Bank Name")
            ElseIf txt_brn.Text = "" Then
                MsgBox("Please Enter Branch Name")
            ElseIf txt_da.Text = "" Then
                MsgBox("Please Enter Deposit Amount")
            ElseIf txt_dd.Text = "" Then
                MsgBox("Please Enter Date of Deposit")
            ElseIf txt_ir.Text = "" Then
                MsgBox("Please Enter Interest Rate")
            ElseIf txt_md.Text = "" Then
                MsgBox("Please Enter Mature Date")
            ElseIf Not (CDate(txt_md.Text) >= CDate(txt_dd.Text)) Then
                MsgBox("Date difference not valid")
            ElseIf txt_mv.Text = "" Then
                MsgBox("Please Enter Maturity Value")
            ElseIf Not (Val(txt_mv.Text) > Val(txt_da.Text)) Then
                MsgBox("Maturity value cannot be less than deposit amount")
            ElseIf cmb_mod.SelectedItem = "" Then
                MsgBox("Please Enter Mode of Transaction")
            ElseIf cmb_mod.Text = "Account Transfer" And cmb_toa.Text = "" Then
                MsgBox("Please Enter Type of Account")
            Else

                If Not dbcon.State = ConnectionState.Open Then
                    dbcon.Open()
                End If

                fdconstrg = "insert into ACCOUNTS (acno,acctype,bankname,bname,opendate,maturedate,dot,depoamt,intrate,matureamt) values (" & Trim(txt_an.Text) _
                & ",'FIXED DEPOSIT','" & Trim(UCase(txt_bn.Text)) & "','" & Trim(UCase(txt_brn.Text)) _
                & "','" & Trim(CDate(txt_dd.Text)) & "','" & Trim(CDate(txt_md.Text)) & "','" & Trim(CDate(txt_dd.Text)) _
                & "'," & CDbl(txt_da.Text) & "," & Trim(CSng(txt_ir.Text)) & "," & Trim(CDbl(txt_mv.Text)) & ")"

                '=====================================================
                '        ACCOUNT TRANSFER FROM CURRENT ACCOUNT
                '=====================================================

                If cmb_toa.SelectedItem = "Current Account" Then

                    If Not txt_tan.Text = "" Then

                        If Not dbcon.State = ConnectionState.Open Then
                            dbcon.Open()
                        End If

                        caconstrg = "select acno, acctype, balance from ACCOUNTS where (acno=" & txt_tan.Text & " and acctype = 'CURRENT ACCOUNT')"
                        caconcmd = New OleDbCommand(caconstrg, dbcon)
                        datareader = caconcmd.ExecuteReader()
                        datareader.Read()

                        If datareader.HasRows Then
                            baln = datareader.Item(2)
                        Else
                            MsgBox("Invalid Current Account Number")
                            dbcon.Close()
                            Exit Sub
                        End If
                        baln -= Val(txt_da.Text)
                        If baln < 0.0 Then
                            MsgBox("Insufficient balance in selected account for fund transfer")
                            Exit Sub
                        End If

                        caconstrg = "update ACCOUNTS set balance=" & baln & " where (acno = " & txt_tan.Text & " and acctype = 'CURRENT ACCOUNT')"
                        caconcmd = New OleDbCommand(caconstrg, dbcon)
                        l = caconcmd.ExecuteNonQuery

                        fdconcmd = New OleDbCommand(fdconstrg, dbcon)
                        j = fdconcmd.ExecuteNonQuery

                        Call getTransId()

                        frmstr = UCase(cmb_toa.SelectedItem) & " NO. " & txt_tan.Text
                        tostr = "FD ACCOUNT NO. " & txt_an.Text
                        ttconstrg1 = "insert into TT values (" & tid & ",'" & Trim(CDate(Date.Today)) & "','" & _
                        frmstr & "','" & tostr & "'," & txt_da.Text & ",'ACCOUNT CREATED')"

                        ttconcmd = New OleDbCommand(ttconstrg1, dbcon)
                        m = ttconcmd.ExecuteNonQuery

                        Call checkTableUpdate()
                        dbcon.Close()
                        Exit Sub
                    Else
                        MsgBox("Enter debit account number")
                        Exit Sub
                    End If

                End If

                '=====================================================
                '        ACCOUNT TRANSFER FROM SAVINGS ACCOUNT
                '=====================================================

                If cmb_toa.SelectedItem = "Savings Account" Then

                    If Not txt_tan.Text = "" Then

                        If Not dbcon.State = ConnectionState.Open Then
                            dbcon.Open()
                        End If

                        saconstrg = "select acno, acctype, balance from ACCOUNTS where (acno=" & txt_tan.Text & " and acctype = 'SAVINGS ACCOUNT')"
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

                        baln -= Val(txt_da.Text)
                        If baln < 0 Then
                            MsgBox("Insufficient balance in selected account for fund transfer")
                            Exit Sub
                        End If

                        saconstrg = "update ACCOUNTS set balance=" & baln & " where (acno = " & txt_tan.Text & " and acctype = 'SAVINGS ACCOUNT')"
                        saconcmd = New OleDbCommand(saconstrg, dbcon)
                        l = saconcmd.ExecuteNonQuery

                        fdconcmd = New OleDbCommand(fdconstrg, dbcon)
                        j = fdconcmd.ExecuteNonQuery

                        Call getTransId()

                        frmstr = UCase(cmb_toa.SelectedItem) & " NO. " & txt_tan.Text
                        tostr = "FD ACCOUNT NO. " & txt_an.Text
                        ttconstrg1 = "insert into TT values (" & tid & ",'" & Trim(CDate(Date.Today)) & "','" & _
                        frmstr & "','" & tostr & "'," & txt_da.Text & ",'ACCOUNT CREATED')"

                        ttconcmd = New OleDbCommand(ttconstrg1, dbcon)
                        m = ttconcmd.ExecuteNonQuery

                        Call checkTableUpdate()
                        dbcon.Close()
                        Exit Sub
                    Else
                        MsgBox("Enter debit account number")
                        Exit Sub
                    End If

                End If

                '=====================================================
                '                 FOR CASH DEPOSIT
                '=====================================================

                If cmb_mod.SelectedItem = "Cash" Then

                    fdconcmd = New OleDbCommand(fdconstrg, dbcon)
                    Dim j As Integer = fdconcmd.ExecuteNonQuery

                    Call getTransId()

                    tostr = "FD ACCOUNT NO. " & txt_an.Text
                    ttconstrg1 = "insert into TT values (" & tid & ",'" & Trim(CDate(Date.Today)) & "','CASH','" & _
                    tostr & "'," & txt_da.Text & ",'ACCOUNT CREATED')"

                    ttconcmd = New OleDbCommand(ttconstrg1, dbcon)
                    Dim m As Integer = ttconcmd.ExecuteNonQuery

                    If Not j = 1 Then
                        MsgBox("Error in Inserting data to FD Table")
                    ElseIf Not m = 1 Then
                        MsgBox("Error in Updating Transaction Table")
                    ElseIf (j = 1 And m = 1) Then
                        MsgBox("Record Inserted Successfully")
                        Call clearFields()
                    End If
                    dbcon.Close()
                    Exit Sub
                End If
                dbcon.Close()
            End If
        End If
    End Sub

    Private Sub cmd_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_reset.Click

        If MessageBox.Show("Confirm Data Reset ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Call clearFields()
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

    Private Sub txt_da_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_da.Validating
        Call txt_depoamt_validate()
    End Sub

    Private Sub txt_ir_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_ir.Validating
        Call txt_intrate_validate()
    End Sub

    Private Sub txt_mv_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_mv.Validating
        Call txt_matureValue_validate()
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
            fdconstrg = "select * from ACCOUNTS where (acno = " & txt_an.Text & " and acctype = 'FIXED DEPOSIT')"
            fdconcmd = New OleDbCommand(fdconstrg, dbcon)
            datareader = fdconcmd.ExecuteReader()
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

    Public Sub txt_depoamt_validate()
        For i = 1 To Len(txt_da.Text)
            charecter = GetChar(txt_da.Text, i)
            ascii = Asc(charecter)
            If Not ((ascii >= 48 And ascii <= 57) Or ascii = 46) Then
                MsgBox("Special charecter(s)/ Alphanumeric(s) not allowed")
                txt_da.Focus()
                Exit Sub
            End If
        Next

        If Not Len(txt_da.Text) <= 19 Then
            MsgBox("Account number limitation within 19 digits")
            txt_da.Focus()
            Exit Sub
        End If
    End Sub

    Public Sub txt_intrate_validate()
        For i = 1 To Len(txt_ir.Text)
            charecter = GetChar(txt_ir.Text, i)
            ascii = Asc(charecter)
            If Not ((ascii >= 48 And ascii <= 57) Or ascii = 46) Then
                MsgBox("Special charecter(s)/ Alphanumeric(s) not allowed")
                txt_ir.Focus()
                Exit Sub
            End If
        Next

        If Not Len(txt_ir.Text) <= 8 Then
            MsgBox("Please enter proper rate of interest")
            txt_ir.Focus()
        End If
    End Sub

    Public Sub txt_matureValue_validate()
        For i = 1 To Len(txt_mv.Text)
            charecter = GetChar(txt_mv.Text, i)
            ascii = Asc(charecter)
            If Not ((ascii >= 48 And ascii <= 57) Or ascii = 46) Then
                MsgBox("Special charecter(s)/ Alphanumeric(s) not allowed")
                txt_mv.Focus()
                Exit Sub
            End If
        Next

        If Not Len(txt_mv.Text) <= 19 Then
            MsgBox("Account number limitation within 19 digits")
            txt_mv.Focus()
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

        If Not dbcon.State = ConnectionState.Open Then
            dbcon.Open()
        End If

        If Not txt_tan.Text = "" Then
            fdconstrg = "select * from ACCOUNTS where (acno = " & txt_tan.Text & " and acctype = '" & acctype & "')"
            fdconcmd = New OleDbCommand(fdconstrg, dbcon)
            datareader = fdconcmd.ExecuteReader()
            datareader.Read()
            If Not datareader.HasRows Then
                MsgBox("Account number given for fund transfer doesnot exists.")
                txt_tan.Clear()
                txt_tan.Focus()
            End If
        End If
        dbcon.Close()
    End Sub

End Class