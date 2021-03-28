Imports System.Data.OleDb
Public Class frm_sr_fdan

    Dim dbcon As OleDbConnection
    Dim fdconcmd As OleDbCommand
    Dim fdconstrg As String
    Dim datareader As OleDb.OleDbDataReader

    Private Sub frm_sr_fdan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dbcon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\db.mdb")
        AcceptButton() = cmd_search
        Call clearFields()

    End Sub

    Public Sub clearFields()
        txt_dd.Text = ""
        txt_md.Text = ""
        txt_bn.Text = ""
        txt_brn.Text = ""
        txt_da.Text = ""
        txt_ir.Text = ""
        txt_mv.Text = ""
        With txt_an
            .Text = ""
            .ReadOnly = False
            .Focus()
        End With
    End Sub

    Private Sub cmd_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_search.Click

        dbcon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\db.mdb")

        If Not dbcon.State = ConnectionState.Open Then
            dbcon.Open()
        End If

        fdconstrg = "select bankname,bname,opendate,maturedate,depoamt,intrate,matureamt from ACCOUNTS where acno=" & txt_an.Text & "and acctype='FIXED DEPOSIT'"
        fdconcmd = New OleDbCommand(fdconstrg, dbcon)
        datareader = fdconcmd.ExecuteReader()
        datareader.Read()
        If datareader.HasRows Then
            txt_bn.Text = datareader.Item(0)
            txt_brn.Text = datareader.Item(1)
            txt_da.Text = datareader.Item(4)
            txt_ir.Text = datareader.Item(5)
            txt_dd.Text = datareader.Item(2)
            txt_md.Text = datareader.Item(3)
            txt_mv.Text = datareader.Item(6)
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