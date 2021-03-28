Imports System.Data.OleDb

Public Class frm_fd_delete
    Public dbcon As OleDbConnection
    Dim fdconcmd As OleDbCommand
    Dim fdconstrg As String
    Dim mtconcmd As OleDbCommand
    Dim mtconstrg As String
    Dim datareader As OleDb.OleDbDataReader
    Dim ttconcmd As OleDbCommand
    Dim frmstr, ttconstrg1, ttconstrg2 As String
    Dim tid As Double
    Public charecter As Char
    Public ascii As Integer

    Private Sub frm_fd_delete_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        AcceptButton() = cmd_search
        dbcon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\db.mdb")
        Call clearFields()
        Call disable()

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
        txt_dd.Text = ""
        txt_md.Text = ""
        txt_mv.Text = ""

    End Sub

    Public Sub enable()

        cmd_search.Enabled = False
        cmd_delete.Enabled = True
        AcceptButton() = cmd_delete
        txt_an.ReadOnly = True

    End Sub

    Public Sub disable()

        cmd_search.Enabled = True
        cmd_delete.Enabled = False
        AcceptButton() = cmd_search
        txt_an.ReadOnly = False

    End Sub

    Private Sub cmd_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_search.Click

        CausesValidation() = True

        If txt_an.Text = "" Then
            MsgBox("Please insert account no")
            Exit Sub
        End If

        If Not txt_an.Text = "" Then

            If Not dbcon.State = ConnectionState.Open Then
                dbcon.Open()
            End If

            fdconstrg = "select acno,acctype,bankname,bname,opendate,maturedate,depoamt,intrate,matureamt from ACCOUNTS where (acno = " & _
            txt_an.Text & " and acctype = 'FIXED DEPOSIT')"
            fdconcmd = New OleDbCommand(fdconstrg, dbcon)
            datareader = fdconcmd.ExecuteReader()
            datareader.Read()

            If datareader.HasRows Then
                Call enable()
                txt_bn.Text = datareader.Item(2)
                txt_brn.Text = datareader.Item(3)
                txt_da.Text = datareader.Item(6)
                txt_ir.Text = datareader.Item(7)
                txt_dd.Text = datareader.Item(4)
                txt_md.Text = datareader.Item(5)
                txt_mv.Text = datareader.Item(8)
                dbcon.Close()
            Else
                MsgBox("No Record Found by This Account Number")
                Call clearFields()
                dbcon.Close()
            End If
        End If
    End Sub

    Private Sub cmd_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_delete.Click

        CausesValidation() = True

        If MessageBox.Show("Confirm Record Delete?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            If Not dbcon.State = ConnectionState.Open Then
                dbcon.Open()
            End If

            fdconstrg = "delete from ACCOUNTS where (acno = " & _
            txt_an.Text & " and acctype = 'FIXED DEPOSIT')"

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

            frmstr = "FD ACCOUNT NO. " & txt_an.Text
            ttconstrg1 = "insert into TT values (" & tid & ",'" & Trim(CDate(Date.Today)) & _
            "','" & frmstr & "',''," & txt_da.Text & ",'ACCOUNT DELETED')"

            ttconcmd = New OleDbCommand(ttconstrg1, dbcon)
            Dim m As Integer = ttconcmd.ExecuteNonQuery

            If Not (j = 1) Then
                MsgBox("Record Delete Unsuccessfull")
            ElseIf Not (m = 1) Then
                MsgBox("Error in Updating Transaction Table")
            ElseIf (j = 1 And m = 1) Then
                MsgBox("Record Deleted Successfully")
                Call clearFields()
                Call disable()
            End If

            dbcon.Close()
        End If
    End Sub

    Private Sub cmd_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_reset.Click

        If MessageBox.Show("Confirm Data Reset ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Call clearFields()
            Call disable()
        End If

    End Sub

    '================================================================
    '                TEXT VALIDATION OF DATA FIELDS
    '================================================================

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

End Class