Imports System.Data.OleDb
Public Class frm_sr_bn
    Public dbcon As OleDbConnection
    Dim fdconcmd As OleDbCommand
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim fdconstr As String
    Dim datareader As OleDbDataReader

    Private Sub frm_sr_cabn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        AcceptButton() = cmd_search

        dbcon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\db.mdb")

        If Not dbcon.State = ConnectionState.Open Then
            dbcon.Open()
        End If

        fdconstr = "select bankname from ACCOUNTS where acctype = '" & frm_home.acctype_sr_bn & "'"
        fdconcmd = New OleDbCommand(fdconstr, dbcon)
        datareader = fdconcmd.ExecuteReader()

        While datareader.Read()
            If Not cmb_bn.Items.Contains(datareader.Item(0)) Then
                cmb_bn.Items.Add(datareader.Item(0))
            End If
        End While

        dbcon.Close()
    End Sub

    Private Sub cmd_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_reset.Click

        cmb_bn.Text = ""
        dgv_ca.DataSource = ""

    End Sub

    Private Sub cmd_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_search.Click

        If Not dbcon.State = ConnectionState.Open Then
            dbcon.Open()
        End If

        fdconstr = "select " & frm_home.fieldName_sr_bn & " from ACCOUNTS where acctype='" & frm_home.acctype_sr_bn & "' and bankname ='" & cmb_bn.Text & "'"
        fdconcmd = New OleDbCommand(fdconstr, dbcon)

        da = New OleDbDataAdapter(fdconcmd)
        ds = New DataSet()
        da.Fill(ds, "ACCOUNTS")

        dgv_ca.DataSource = ds.Tables("ACCOUNTS").DefaultView

        dbcon.Close()

    End Sub

    Private Sub cmb_bn_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_bn.SelectedIndexChanged
        dgv_ca.DataSource = ""
    End Sub
End Class