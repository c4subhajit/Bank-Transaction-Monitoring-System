Imports System.Data.OleDb
Public Class frm_sa_modify

    Dim dbcon As OleDbConnection
    Dim saconcmd As OleDbCommand
    Dim saconstrg As String
    Dim datareader As OleDb.OleDbDataReader
    Dim ttconcmd As OleDbCommand
    Dim ttconstrg1, ttconstrg2, frmstr As String
    Dim tid As Double
    Dim m, k As Integer
    Dim search_status As Integer
    Public charecter As Char 'validation
    Public ascii As Integer ' validation

    Private Sub frm_sa_modify_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dbcon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\db.mdb")
        AcceptButton() = cmd_search
        Call clearFields()
        Call disable()
        txt_an.Focus()

    End Sub

    Public Sub clearFields()

        txt_bn.Text = ""
        txt_brn.Text = ""
        With txt_an
            .Text = ""
            .ReadOnly = False
            .Focus()
        End With
        txt_ir.Text = ""
        dtp_doo.Value = Date.Today
        txt_doo.Text = ""
        txt_blnc.Text = ""

    End Sub

    Public Sub enable()

        txt_bn.ReadOnly = False
        txt_brn.ReadOnly = False
        txt_an.ReadOnly = True
        txt_ir.ReadOnly = False
        txt_blnc.ReadOnly = False
        dtp_doo.Enabled = True
        cmd_search.Enabled = False
        cmd_update.Enabled = True
        AcceptButton() = cmd_update
        txt_bn.Focus()

    End Sub

    Public Sub disable()

        txt_bn.ReadOnly = True
        txt_brn.ReadOnly = True
        txt_an.ReadOnly = False
        txt_ir.ReadOnly = True
        txt_blnc.ReadOnly = True
        dtp_doo.Enabled = False
        cmd_search.Enabled = True
        cmd_update.Enabled = False
        AcceptButton() = cmd_search
        txt_an.Focus()

    End Sub

    Private Sub dtp_doo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_doo.ValueChanged
        txt_doo.Text = dtp_doo.Value
    End Sub

    Private Sub cmd_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_search.Click

        CausesValidation() = True

        If txt_an.Text = "" Then
            MsgBox("Please insert account no.")
            Exit Sub
        End If

        If Not txt_an.Text = "" Then

            If Not dbcon.State = ConnectionState.Open Then
                dbcon.Open()
            End If
            
            saconstrg = "select * from ACCOUNTS where (acno=" & txt_an.Text & " and acctype = 'SAVINGS ACCOUNT')"
            saconcmd = New OleDbCommand(saconstrg, dbcon)
            datareader = saconcmd.ExecuteReader()
            datareader.Read()

            If datareader.HasRows Then
                Call enable()
                txt_bn.Text = datareader.Item(2)
                txt_brn.Text = datareader.Item(3)
                txt_ir.Text = datareader.Item(8)
                txt_doo.Text = datareader.Item(4)
                txt_blnc.Text = datareader.Item(10)
                dbcon.Close()
            Else
                MsgBox("No Record Found by This Account Number")
                Call clearFields()
                dbcon.Close()
            End If
        End If
    End Sub

    Private Sub cmd_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_update.Click

        CausesValidation() = True

        If MessageBox.Show("Confirm Record Update?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            If txt_bn.Text = "" Then
                MsgBox("Insert name of the bank")
            ElseIf txt_brn.Text = "" Then
                MsgBox("Insert branch name")
            ElseIf txt_ir.Text = "" Then
                MsgBox("Insert interest rate")
            ElseIf txt_doo.Text = "" Then
                MsgBox("Insert date of transaction")
            ElseIf txt_blnc.Text = "" Then
                MsgBox("Insert amount deposited")
            Else

                If Not dbcon.State = ConnectionState.Open Then
                    dbcon.Open()
                End If

                saconstrg = "update ACCOUNTS set bankname='" & Trim(UCase(txt_bn.Text)) & "',bname='" _
                & Trim(UCase(txt_brn.Text)) & "',opendate='" & Trim(CDate(txt_doo.Text)) & _
                "',balance=" & CDbl(txt_blnc.Text) & ",dot='" & Trim(CDate(txt_doo.Text)) & "',intrate=" & Trim(CSng(txt_ir.Text)) & _
                " where (acno = " & txt_an.Text & " and acctype = 'SAVINGS ACCOUNT')"

                saconcmd = New OleDbCommand(saconstrg, dbcon)

                k = saconcmd.ExecuteNonQuery

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

                frmstr = "SAVINGS ACCOUNT NO. " & txt_an.Text
                ttconstrg1 = "insert into TT values (" & tid & ",'" & Trim(CDate(Date.Today)) & _
                "',' " & frmstr & " ',''," & txt_blnc.Text & ",'ACCOUNT MODIFIED')"

                ttconcmd = New OleDbCommand(ttconstrg1, dbcon)
                m = ttconcmd.ExecuteNonQuery

                If Not k = 1 Then
                    MsgBox("Accounts table modify failed")
                ElseIf Not m = 1 Then
                    MsgBox("Transaction table update failed")
                ElseIf (k = 1 And m = 1) Then
                    MsgBox("Record Updated Successfully")
                    Call clearFields()
                    Call disable()
                End If

                dbcon.Close()
            End If
        End If
    End Sub

    Private Sub cmd_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_reset.Click

        If MessageBox.Show("Confirm Data Reset?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Call clearFields()
            Call disable()
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
    Private Sub txt_ir_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_ir.Validating
        Call txt_ir_validate()
    End Sub

    Private Sub txt_blnc_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_blnc.Validating
        Call txt_amt_validate()
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
    Public Sub txt_ir_validate()
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

End Class