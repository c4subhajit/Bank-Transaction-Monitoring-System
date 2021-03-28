Imports System.Data.OleDb

Public Class frm_fd_modify
    Public dbcon As OleDbConnection
    Dim concmd As OleDbCommand
    Dim constrg As String
    Dim datareader As OleDb.OleDbDataReader
    Dim fdconcmd As OleDbCommand
    Dim fdconstrg As String
    Dim ttconcmd As OleDbCommand
    Dim tostr, ttconstrg1, ttconstrg2 As String
    Dim tid As Double
    Dim charecter As Char
    Public ascii As Integer

    Private Sub frm_fd_modify_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        AcceptButton() = cmd_search
        dbcon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\db.mdb")
        Call clearFields()
        Call disableAll()

    End Sub

    Public Sub clearFields()

        txt_bn.Text = ""
        txt_brn.Text = ""
        With txt_an
            .ReadOnly = False
            .Text = ""
            .Focus()
        End With
        txt_da.Text = ""
        txt_ir.Text = ""
        dtp_dd.Value = Date.Today
        txt_dd.Text = ""
        dtp_md.Value = Date.Today
        txt_md.Text = ""
        txt_mv.Text = ""

    End Sub

    Public Sub enableAll()

        txt_bn.ReadOnly = False
        txt_brn.ReadOnly = False
        txt_an.ReadOnly = True
        txt_da.ReadOnly = False
        txt_ir.ReadOnly = False
        txt_mv.ReadOnly = False
        dtp_dd.Enabled = True
        dtp_md.Enabled = True
        cmd_search.Enabled = False
        cmd_update.Enabled = True
        AcceptButton() = cmd_update

    End Sub

    Public Sub disableAll()

        txt_bn.ReadOnly = True
        txt_brn.ReadOnly = True
        txt_an.ReadOnly = False
        txt_da.ReadOnly = True
        txt_ir.ReadOnly = True
        txt_mv.ReadOnly = True
        dtp_dd.Enabled = False
        dtp_md.Enabled = False
        cmd_search.Enabled = True
        cmd_update.Enabled = False
        AcceptButton() = cmd_search

    End Sub

    Private Sub dtp_dd_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_dd.ValueChanged
        txt_dd.Text = dtp_dd.Value
    End Sub

    Private Sub dtp_md_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_md.ValueChanged
        If Not txt_dd.Text = "" Then
            txt_md.Text = dtp_md.Value
        End If
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

            constrg = "select acno,acctype,bankname,bname,opendate,maturedate,depoamt,intrate,matureamt from ACCOUNTS where (acno = " & _
            txt_an.Text & " and acctype = 'FIXED DEPOSIT')"

            concmd = New OleDbCommand(constrg, dbcon)
            datareader = concmd.ExecuteReader()
            datareader.Read()
            If datareader.HasRows Then

                Call enableAll()
                txt_bn.Text = datareader.Item(2)
                txt_brn.Text = datareader.Item(3)
                txt_da.Text = datareader.Item(6)
                txt_ir.Text = datareader.Item(7)
                txt_dd.Text = datareader.Item(4)
                txt_md.Text = datareader.Item(5)
                txt_mv.Text = datareader.Item(8)
                dbcon.Close()
            Else
                MsgBox("No Record Found")
                Call clearFields()
                dbcon.Close()
            End If
        End If
    End Sub

    Private Sub cmd_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_update.Click

        CausesValidation() = True

        If MessageBox.Show("Confirm Record Update?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

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
            Else

                If Not dbcon.State = ConnectionState.Open Then
                    dbcon.Open()
                End If

                fdconstrg = "update ACCOUNTS set bankname='" & Trim(UCase(txt_bn.Text)) & "',bname='" _
                & Trim(UCase(txt_brn.Text)) & "',opendate='" & Trim(CDate(txt_dd.Text)) & _
                "',maturedate='" & Trim(CDate(txt_md.Text)) & "',dot='" & Trim(CDate(txt_dd.Text)) & "',depoamt=" & CDbl(txt_da.Text) & _
                ",intrate=" & Trim(CSng(txt_ir.Text)) & ",matureamt=" & Trim(CDbl(txt_mv.Text)) & _
                " where (acno=" & txt_an.Text & " and acctype = 'FIXED DEPOSIT')"

                fdconcmd = New OleDbCommand(fdconstrg, dbcon)
                Dim j As Integer = fdconcmd.ExecuteNonQuery

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

                tostr = "FD ACCOUNT NO. " & txt_an.Text
                ttconstrg1 = "insert into TT values (" & tid & ",'" & Trim(CDate(Date.Today)) & _
                "','CASH','" & tostr & "'," & txt_da.Text & ",'ACCOUNT MODIFIED')"

                ttconcmd = New OleDbCommand(ttconstrg1, dbcon)
                Dim m As Integer = ttconcmd.ExecuteNonQuery

                If Not j = 1 Then
                    MsgBox("Error in Updating Modified Account Details")
                ElseIf Not m = 1 Then
                    MsgBox("Error in Updating Transaction Table")
                ElseIf (j = 1 And m = 1) Then
                    MsgBox("Record Update Successfully")
                    Call clearFields()
                    Call disableAll()
                End If

                dbcon.Close()
            End If
        End If
    End Sub

    Private Sub cmd_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_reset.Click

        If MessageBox.Show("Confirm Data Reset?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Call disableAll()
            Call clearFields()
        End If
       
    End Sub

    '================================================================
    '                TEXT VALIDATION OF DATA FIELDS
    '================================================================

    Private Sub txt_bn_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_bn.Validating
        Call txt_bn_validate()
    End Sub

    Private Sub txt_brn_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_brn.Validating
        Call txt_brn_validate()
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

    Private Sub txt_an_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_an.Validating
        Call txt_an_validate()
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
                    Or (ascii >= 97 And ascii <= 122)) Then
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

End Class