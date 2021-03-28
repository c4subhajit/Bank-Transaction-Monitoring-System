Imports System.Data.OleDb
Public Class frm_ca_delete
    Public dbcon As OleDbConnection
    Dim caconcmd1 As OleDbCommand
    Dim caconstrg1 As String
    Dim concmd As OleDbCommand
    Dim constrg As String
    Dim datareader As OleDb.OleDbDataReader
    Dim j, m As Integer
    Dim ttconcmd As OleDbCommand
    Dim ttconstrg1, ttconstrg2, frmstr As String
    Dim tid As Double
    Public charecter As Char 'validation
    Public ascii As Integer ' validation

    Private Sub frm_ca_delete_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dbcon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\db.mdb")
        AcceptButton() = cmd_search
        Call clearfield()
        Call disable()

    End Sub

    Public Sub clearfield()
        
        txt_bn.Text = ""
        txt_brn.Text = ""
        With txt_an
            .Text = ""
            .ReadOnly = False
            .Focus()
        End With
        txt_doo.Text = ""
        txt_blnc.Text = ""

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

        If Not (txt_an.Text = "") Then

            If Not dbcon.State = ConnectionState.Open Then
                dbcon.Open()
            End If

            caconstrg1 = "select * from ACCOUNTS where (acno=" & _
            txt_an.Text & " and acctype = 'CURRENT ACCOUNT')"

            caconcmd1 = New OleDbCommand(caconstrg1, dbcon)
            datareader = caconcmd1.ExecuteReader()
            datareader.Read()

            If datareader.HasRows Then
                Call enable()
                txt_bn.Text = datareader.Item(2)
                txt_brn.Text = datareader.Item(3)
                txt_doo.Text = datareader.Item(4)
                txt_blnc.Text = datareader.Item(10)
                dbcon.Close()
            Else
                MsgBox("No Record Found by This Account Number")
                Call clearfield()
                dbcon.Close()
            End If
        End If
    End Sub

    Private Sub cmd_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_delete.Click

        If MessageBox.Show("Confirm Record Delete?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            If Not dbcon.State = ConnectionState.Open Then
                dbcon.Open()
            End If

            constrg = "delete from ACCOUNTS where (acno=" & _
            txt_an.Text & " and acctype = 'CURRENT ACCOUNT')"
            concmd = New OleDbCommand(constrg, dbcon)
            j = concmd.ExecuteNonQuery

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
            frmstr & "',''," & txt_blnc.Text & ",'ACCOUNT DELETED')"

            ttconcmd = New OleDbCommand(ttconstrg1, dbcon)
            Dim m As Integer = ttconcmd.ExecuteNonQuery

            If Not j = 1 Then
                MsgBox("Error in Updateing data to CA Table")
            ElseIf Not m = 1 Then
                MsgBox("Error in Updating Transaction Table")
            ElseIf (j = 1 And m = 1) Then
                MsgBox("Record Deleted Successfully")
                Call clearfield()
                Call disable()
            End If
            
            dbcon.Close()
        End If
    End Sub

    Private Sub cmd_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_reset.Click

        If MessageBox.Show("Confirm Data Reset ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Call clearfield()
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