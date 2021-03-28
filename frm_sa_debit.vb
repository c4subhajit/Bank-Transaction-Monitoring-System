Imports System.Data.OleDb
Public Class frm_sa_debit

    Public dbcon As OleDbConnection
    Dim saconcmd As OleDbCommand
    Dim saconstrg As String
    Dim datareader As OleDb.OleDbDataReader
    Dim ttconcmd As OleDbCommand
    Dim ttconstrg1, ttconstrg2, frmstr As String
    Dim tid As Double
    Dim k, m As Integer
    Dim blnc As Double
    Public charecter As Char 'validation
    Public ascii As Integer ' validation

    Private Sub frm_sa_debit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

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
        txt_ir.Text = ""
        txt_blnc.Text = ""
        txt_wa.Text = ""

    End Sub

    Public Sub enable()

        cmd_search.Enabled = False
        cmd_ok.Enabled = True
        txt_an.ReadOnly = True

    End Sub

    Public Sub disable()

        cmd_search.Enabled = True
        cmd_ok.Enabled = False
        txt_an.ReadOnly = False

    End Sub

    Public Sub Showall()

        lbl_dot.Visible = True
        lbl_debit.Visible = True
        txt_dot.Visible = True
        txt_wa.Visible = True
        dtp_dot.Visible = True
        txt_wa.Focus()

    End Sub

    Public Sub hidden()

        lbl_dot.Visible = False
        lbl_debit.Visible = False
        txt_dot.Visible = False
        txt_wa.Visible = False
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

            saconstrg = "select * from ACCOUNTS where (acno = " & _
            txt_an.Text & " and acctype = 'SAVINGS ACCOUNT')"

            saconcmd = New OleDbCommand(saconstrg, dbcon)
            datareader = saconcmd.ExecuteReader()
            datareader.Read()

            If datareader.HasRows Then
                Call enable()
                Call Showall()
                txt_bn.Text = datareader.Item(2)
                txt_brn.Text = datareader.Item(3)
                txt_ir.Text = datareader.Item(8)
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
            ElseIf txt_wa.Text = "" Then
                MsgBox("Enter Debit Amount")
                txt_wa.Focus()
            Else
                blnc = Val(txt_blnc.Text) - Val(txt_wa.Text)
                If blnc < 0 Then
                    MsgBox("Insufficient balance in selected account for fund transfer")
                    Exit Sub
                End If

                saconstrg = "update ACCOUNTS set dot='" & Trim(CDate(txt_dot.Text)) & _
                "',balance=" & CDbl(blnc) & " where (acno = " & txt_an.Text & _
                " and acctype = 'SAVINGS ACCOUNT')"

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
                ttconstrg1 = "insert into TT values (" & tid & ",'" & Trim(CDate(Date.Today)) & "','" & _
                frmstr & "',''," & txt_wa.Text & ",'WITHDRAWL')"

                ttconcmd = New OleDbCommand(ttconstrg1, dbcon)
                m = ttconcmd.ExecuteNonQuery

                If Not k = 1 Then
                    MsgBox("Error in Updateing ACCOUNTS Table")
                ElseIf Not m = 1 Then
                    MsgBox("Error in Updating Transaction Table")
                ElseIf (k = 1 And m = 1) Then
                    MsgBox("Withdrawl Successfully")
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
        Call txt_wa_validate()
    End Sub

    Private Sub txt_an_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_an.Validating
        Call txt_an_validate()
    End Sub

    '=================================================================
    '                   TEXT VALIDATION FUNCTIONS
    '=================================================================

    Public Sub txt_wa_validate()
        For i = 1 To Len(txt_wa.Text)
            charecter = GetChar(txt_wa.Text, i)
            ascii = Asc(charecter)
            If Not ((ascii >= 48 And ascii <= 57) Or ascii = 46) Then
                MsgBox("Special charecter(s)/ Alphanumeric(s) not allowed")
                txt_wa.Focus()
                Exit Sub
            End If
        Next

        If Not Len(txt_wa.Text) <= 19 Then
            MsgBox("Amount exceeds the maximum withdrawl limit of 19 digits")
            txt_wa.Focus()
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