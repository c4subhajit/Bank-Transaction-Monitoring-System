Imports System.Data.OleDb
Public Class frm_sr_fddate

    Dim dbcon As OleDbConnection
    Dim fdconcmd As OleDbCommand
    Dim fdconstrg As String
    Dim da As OleDb.OleDbDataAdapter
    Dim fddata As DataSet
    Dim rowCount As Double

    Private Sub frm_sr_fddo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        dbcon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\db.mdb")
        Call hidden()
        lbl_doo.Text = frm_home.lbl_text
        Me.Text = frm_home.frm_name
        AcceptButton() = cmd_search
        dtp_from.Value = Date.Today
        txt_dd_from.Text = ""
        dtp_to.Value = Date.Today
        txt_dd_to.Text = ""

    End Sub

    Public Sub hidden()

        lbl_doo.Visible = False
        txt_dd_from.Visible = False
        dtp_from.Visible = False
        lbl_to.Visible = False
        txt_dd_to.Visible = False
        dtp_to.Visible = False

    End Sub

    Private Sub dtp_from_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_from.ValueChanged
        txt_dd_from.Text = dtp_from.Value
        dgv_fd.DataSource = ""
    End Sub

    Private Sub dtp_to_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_to.ValueChanged
        txt_dd_to.Text = dtp_to.Value
        dgv_fd.DataSource = ""
    End Sub

    Private Sub cmb_saerchby_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_saerchby.SelectedIndexChanged

        If cmb_saerchby.Text = "Particular Date" Then
            lbl_doo.Visible = True
            txt_dd_from.Visible = True
            dtp_from.Visible = True
            lbl_to.Visible = False
            txt_dd_to.Visible = False
            dtp_to.Visible = False
            dtp_from.Value = Date.Today
            txt_dd_from.Text = ""
            dtp_to.Value = Date.Today
            txt_dd_to.Text = ""
            dgv_fd.DataSource = ""
        End If

        If cmb_saerchby.Text = "Range of Date" Then
            lbl_doo.Visible = True
            txt_dd_from.Visible = True
            dtp_from.Visible = True
            lbl_to.Visible = True
            txt_dd_to.Visible = True
            dtp_to.Visible = True
            dtp_from.Value = Date.Today
            txt_dd_from.Text = ""
            dtp_to.Value = Date.Today
            txt_dd_to.Text = ""
            dgv_fd.DataSource = ""
        End If

    End Sub

    Private Sub cmd_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_search.Click

        If Not dbcon.State = ConnectionState.Open Then
            dbcon.Open()
        End If

        If cmb_saerchby.Text = "" Then
            MsgBox("Please Enter Search By Pattern")
        End If

        If cmb_saerchby.Text = "Particular Date" Then
            If txt_dd_from.Text = "" Then
                MsgBox("Please Enter Date")
                Exit Sub
            End If
            fdconstrg = "select acno,bankname,bname,opendate,maturedate,depoamt,intrate,matureamt from ACCOUNTS where (" & frm_home.query_txt & "<=#" & _
            Trim(CDate(txt_dd_from.Text)) & "# and acctype='FIXED DEPOSIT')"
            fdconcmd = New OleDbCommand(fdconstrg, dbcon)
            da = New OleDb.OleDbDataAdapter(fdconcmd)
            fddata = New DataSet()
            da.Fill(fddata, "My Table")
            dgv_fd.DataSource = fddata.Tables("My Table").DefaultView
            rowCount = fddata.Tables(0).Rows.Count
            If rowCount = 0 Then
                MsgBox(frm_home.no_record_msg & " Before This Date")
            End If

        End If

        If cmb_saerchby.Text = "Range of Date" Then
            If txt_dd_from.Text = "" Then
                MsgBox("Please Enter Starting Date")
                Exit Sub
            End If
            If txt_dd_to.Text = "" Then
                MsgBox("Please Enter Ending Date")
                Exit Sub
            End If
            fdconstrg = "select acno,bankname,bname,opendate,maturedate,depoamt,intrate,matureamt from ACCOUNTS where ((" & frm_home.query_txt & " between #" & _
            Trim(CDate(txt_dd_from.Text)) & "# and #" & Trim(CDate(txt_dd_to.Text)) & "#) and acctype='FIXED DEPOSIT')"

            fdconcmd = New OleDbCommand(fdconstrg, dbcon)
            da = New OleDb.OleDbDataAdapter(fdconcmd)
            fddata = New DataSet()
            da.Fill(fddata, "My Table")
            dgv_fd.DataSource = fddata.Tables("My Table").DefaultView
            rowCount = fddata.Tables(0).Rows.Count
            If rowCount = 0 Then
                MsgBox(frm_home.no_record_msg & " In This Time Period")
            End If

        End If

        dbcon.Close()

    End Sub

    Private Sub cmd_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_reset.Click
        dtp_from.Value = Date.Today
        txt_dd_from.Text = ""
        dtp_to.Value = Date.Today
        txt_dd_to.Text = ""
        cmb_saerchby.Text = ""
        dgv_fd.DataSource = ""
        Call hidden()
    End Sub

End Class