Imports System.Data.OleDb
Public Class frm_ca_credit

    Public dbcon As OleDbConnection
    Dim caconcmd, caconcmd1, ttconcmd As OleDbCommand
    Dim caconstrg, caconstrg1, ttconstrg1, ttconstrg2, frmstr As String
    Dim datareader As OleDb.OleDbDataReader
    Dim tid As Double
    Dim j, m As Integer
    Dim blnc As Double
    Public charecter As Char 'validation
    Public ascii As Integer ' validation

    Private Sub frm_ca_credit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dbcon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\db.mdb")
        AcceptButton() = cmd_search
        Call clearfield()
        Call disable()
        Call hidden()

    End Sub

    Public Sub clearfield()

        txt_bn.Text = ""
        txt_brn.Text = ""
        With txt_an
            .Text = ""
            .ReadOnly = False
            .Focus()
        End With
        dtp_dot.Value = Date.Today
        txt_dot.Text = ""
        txt_blnc.Text = ""
        txt_da.Text = ""

    End Sub

    Public Sub enable()

        cmd_search.Enabled = False
        cmd_ok.Enabled = True
        txt_an.ReadOnly = True
        AcceptButton() = cmd_ok

    End Sub

    Public Sub disable()

        cmd_search.Enabled = True
        cmd_ok.Enabled = False
        txt_an.ReadOnly = False
        AcceptButton() = cmd_search

    End Sub

    Public Sub Showall()

        lbl_dot.Visible = True
        lbl_credit.Visible = True
        txt_dot.Visible = True
        txt_da.Visible = True
        dtp_dot.Visible = True
        txt_da.Focus()

    End Sub

    Public Sub hidden()

        lbl_dot.Visible = False
        lbl_credit.Visible = False
        txt_dot.Visible = False
        txt_da.Visible = False
        dtp_dot.Visible = False

    End Sub

    Private Sub dtp_dot_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_dot.ValueChanged
        txt_dot.Text = dtp_dot.Value
    End Sub

    Private Sub cmd_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_search.Click

        CausesValidation() = True

        If txt_an.Text = "" Then
            MsgBox("Please insert account no")
            Exit Sub
        End If

        If Not (txt_an.Text = "") Then

            If Not dbcon.State = ConnectionState.Open Then
                dbcon.Open()
            End If

            caconstrg1 = "select * from ACCOUNTS where (acno = " & _
            txt_an.Text & " and acctype = 'CURRENT ACCOUNT')"

            caconcmd1 = New OleDbCommand(caconstrg1, dbcon)
            datareader = caconcmd1.ExecuteReader()
            datareader.Read()

            If datareader.HasRows Then
                Call enable()
                Call Showall()
                txt_bn.Text = datareader.Item(2)
                txt_brn.Text = datareader.Item(3)
                txt_blnc.Text = datareader.Item(10)
                dbcon.Close()
            Else
                MsgBox("No Record Found")
                Call clearfield()
                dbcon.Close()
            End If
        End If
    End Sub

    Private Sub cmd_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_ok.Click

        CausesValidation() = True

        If MessageBox.Show("Confirm Amount Withdrawl?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            If Not dbcon.State = ConnectionState.Open Then
                dbcon.Open()
            End If

            If txt_dot.Text = "" Then
                MsgBox("Enter Date of Transaction")
            ElseIf txt_da.Text = "" Then
                MsgBox("Enter Debit Amount")
                txt_da.Focus()
            Else
                blnc = Val(txt_blnc.Text) + Val(txt_da.Text)
                If Not Len(Str((Val(txt_blnc.Text) + Val(txt_da.Text)))) <= 19 Then
                    MsgBox("Amount exceeds the maximum balance limit of 19 digits after credit")
                    txt_da.Focus()
                    Exit Sub
                End If

                caconstrg = "update ACCOUNTS set dot='" & Trim(CDate(txt_dot.Text)) & _
                    "',balance=" & Trim(CDbl(blnc)) & " where (acno = " & txt_an.Text & _
                    " and acctype = 'CURRENT ACCOUNT')"

                caconcmd = New OleDbCommand(caconstrg, dbcon)
                j = caconcmd.ExecuteNonQuery

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

                frmstr = "CURRENT ACCOUNT NO. " & txt_an.Text
                ttconstrg1 = "insert into TT values (" & tid & ",'" & Trim(CDate(Date.Today)) & "','" & _
                frmstr & "',''," & txt_da.Text & ",'DEPOSIT')"

                ttconcmd = New OleDbCommand(ttconstrg1, dbcon)
                m = ttconcmd.ExecuteNonQuery

                If Not j = 1 Then
                    MsgBox("Error in Updateing ACCOUNTS Table")
                ElseIf Not m = 1 Then
                    MsgBox("Error in Updating Transaction Table")
                ElseIf (j = 1 And m = 1) Then
                    MsgBox("Deposit Successfully")
                End If

                Call clearfield()
                Call disable()
                Call hidden()
                dbcon.Close()
            End If
        End If
    End Sub

    Private Sub cmd_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_reset.Click

        If MessageBox.Show("Confirm Data Reset ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Call clearfield()
            Call disable()
            Call hidden()
        End If

    End Sub

    '=================================================================
    '                   TEXT VALIDATION OF DATA FIELDS
    '=================================================================

    Private Sub txt_blnc_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_blnc.Validating
        Call txt_da_validate()
    End Sub

    Private Sub txt_an_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_an.Validating
        Call txt_an_validate()
    End Sub

    '=================================================================
    '                   TEXT VALIDATION FUNCTIONS
    '=================================================================

    Public Sub txt_da_validate()
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
            MsgBox("Amount exceeds the maximum deposit limit of 19 digits")
            txt_da.Focus()
            Exit Sub
        End If
    End Sub

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

End Class