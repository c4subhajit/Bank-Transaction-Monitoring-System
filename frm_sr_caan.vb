Imports System.Data.OleDb
Public Class frm_sr_caan

    Dim dbcon As OleDbConnection
    Dim concmd1 As OleDbCommand
    Dim constrg1 As String
    Dim datareader As OleDb.OleDbDataReader

    Private Sub frm_sr_caan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dbcon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\db.mdb")
        AcceptButton() = cmd_search
        Call clearFields()

    End Sub

    Public Sub clearFields()
        txt_dot.Text = ""
        txt_bl.Text = ""
        txt_bn.Text = ""
        txt_brn.Text = ""
        With txt_an
            .Text = ""
            .ReadOnly = False
            .Focus()
        End With
    End Sub

    Private Sub cmd_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_search.Click

        If Not dbcon.State = ConnectionState.Open Then
            dbcon.Open()
        End If

        constrg1 = "select bankname,bname,dot,balance from ACCOUNTS where acno = " & txt_an.Text & " and acctype = 'CURRENT ACCOUNT'"
        concmd1 = New OleDbCommand(constrg1, dbcon)
        datareader = concmd1.ExecuteReader()
        datareader.Read()
        If datareader.HasRows Then
            txt_bn.Text = datareader.Item(0)
            txt_brn.Text = datareader.Item(1)
            txt_dot.Text = datareader.Item(2)
            txt_bl.Text = datareader.Item(3)
            txt_an.ReadOnly = True
            dbcon.Close()
        Else
            MsgBox("No Record Found")
            Call clearFields()
            dbcon.Close()
        End If
        
    End Sub

    Private Sub cmd_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_reset.Click
        Call clearFields()
    End Sub

End Class