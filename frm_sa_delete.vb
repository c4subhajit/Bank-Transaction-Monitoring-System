Imports System.Data.OleDb
Public Class frm_sa_delete
    Public dbcon As OleDbConnection
    Dim saconcmd As OleDbCommand
    Dim saconstrg As String
    Dim search_status As Integer
    Dim datareader As OleDb.OleDbDataReader
    Dim ttconcmd As OleDbCommand
    Dim ttconstrg1, ttconstrg2, frmstr As String
    Dim k, m As Integer
    Dim tid As Double
    Public charecter As Char 'validation
    Public ascii As Integer ' validation

    Private Sub frm_sa_delete_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dbcon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\db.mdb")
        AcceptButton() = cmd_search
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
        txt_ir.Text = ""
        txt_doo.Text = ""
        txt_blnc.Text = ""

    End Sub

    Public Sub enable()

        cmd_search.Enabled = False
        cmd_delete.Enabled = True
        txt_an.ReadOnly = True

    End Sub

    Public Sub disable()

        cmd_search.Enabled = True
        cmd_delete.Enabled = False
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

            saconstrg = "select * from ACCOUNTS where (acno=" & _
            txt_an.Text & " and acctype = 'SAVINGS ACCOUNT')"

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

    Private Sub cmd_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_delete.Click

        CausesValidation() = True

        If MessageBox.Show("Confirm Record Delete?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            If Not dbcon.State = ConnectionState.Open Then
                dbcon.Open()
            End If

            saconstrg = "delete from ACCOUNTS where (acno=" & _
            txt_an.Text & " and acctype = 'SAVINGS ACCOUNT')"

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
            frmstr & "',''," & txt_blnc.Text & ",'ACCOUNT DELETED')"

            ttconcmd = New OleDbCommand(ttconstrg1, dbcon)
            m = ttconcmd.ExecuteNonQuery

            If Not k = 1 Then
                MsgBox("Record Delete Failed")
            ElseIf Not m = 1 Then
                MsgBox("Transaction Table Update Failed")
            ElseIf (k = 1 And m = 1) Then
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

    '=================================================================
    '                   TEXT VALIDATION OF DATA FIELDS
    '=================================================================

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