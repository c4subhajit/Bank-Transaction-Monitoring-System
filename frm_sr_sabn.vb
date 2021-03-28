Imports System.Data.OleDb
Public Class frm_sr_sabn


    Private Sub cmd_sr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_sr.Click
        Dim dbcon As OleDbConnection
        Dim fdconcmd As OleDbCommand
        Dim fdconstrg As String
        Dim da As OleDb.OleDbDataAdapter
        Dim fddata As DataSet

        dbcon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\db.mdb")

        If Not dbcon.State = ConnectionState.Open Then
            dbcon.Open()
        End If

        fdconstrg = "select * from ACCOUNTS where bankname ='" & Trim(UCase(txt_bn.Text)) & "'"
        fdconcmd = New OleDbCommand(fdconstrg, dbcon)
        da = New OleDb.OleDbDataAdapter(fdconcmd)
        fddata = New DataSet()
        da.Fill(fddata, "My Table")
        dgv_sa.DataSource = fddata.Tables("My Table").DefaultView

        dbcon.Close()
    End Sub

    Private Sub cmd_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_reset.Click
        txt_bn.Text = ""
        dgv_sa.DataSource = ""
    End Sub
End Class