Imports System.Data.OleDb
Public Class frm_sr_dotCaSa

    Dim dbcon As OleDbConnection
    Dim srconcmd As OleDbCommand
    Dim srda As OleDbDataAdapter
    Dim srds As DataSet
    Dim srconstr As String

    Private Sub frm_sr_cadt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dbcon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\db.mdb")
        AcceptButton() = cmd_show
        Call reset()
        dtp_from.Value = Date.Today
        txt_from.Text = ""
        dtp_to.Value = Date.Today
        txt_to.Text = ""
    End Sub

    Private Sub dtp_from_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_from.ValueChanged
        txt_from.Text = dtp_from.Value
        dgv_sr_dotCaSa.DataSource = ""
    End Sub

    Private Sub dtp_to_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_to.ValueChanged
        txt_to.Text = dtp_to.Value
        dgv_sr_dotCaSa.DataSource = ""
    End Sub

    Public Sub reset()
        txt_to.Visible = False
        lbl_to.Visible = False
        lbl_dot.Visible = False
        dtp_to.Visible = False
        txt_from.Visible = False
        dtp_from.Visible = False
        cmb_searchby.Text = " "
        dgv_sr_dotCaSa.DataSource = ""
    End Sub

    Private Sub cmb_searchby_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_searchby.SelectedIndexChanged

        If cmb_searchby.Text = "Single Date" Then
            lbl_dot.Visible = True
            txt_from.Visible = True
            dtp_from.Value = Date.Today
            txt_from.Text = ""
            dtp_to.Value = Date.Today
            txt_to.Text = ""
            dtp_from.Visible = True
            lbl_to.Visible = False
            txt_to.Visible = False
            dtp_to.Visible = False
            dgv_sr_dotCaSa.DataSource = ""
        End If

        If cmb_searchby.Text = "Range Of Date" Then

            lbl_dot.Visible = True
            txt_from.Visible = True
            dtp_from.Value = Date.Today
            txt_from.Text = ""
            dtp_to.Value = Date.Today
            txt_to.Text = ""
            dtp_from.Visible = True
            lbl_to.Visible = True
            txt_to.Visible = True
            dtp_to.Visible = True
            dgv_sr_dotCaSa.DataSource = ""
        End If
    End Sub

    Private Sub cmd_show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_show.Click

        If Not dbcon.State = ConnectionState.Open Then
            dbcon.Open()
        End If
        If cmb_searchby.Text = "Single Date" Then

            srconstr = "select acno,acctype,bankname,bname,opendate,dot,balance from ACCOUNTS where acctype='" & _
            frm_home.acctype_sr_dot_CaSa & "' and dot=#" & (CDate(txt_from.Text)) & "#"

            srconcmd = New OleDbCommand(srconstr, dbcon)

            srda = New OleDbDataAdapter(srconcmd)
            srds = New DataSet()
            srda.Fill(srds, "ACCOUNTS")

            dgv_sr_dotCaSa.DataSource = srds.Tables("ACCOUNTS").DefaultView

            dbcon.Close()

        ElseIf cmb_searchby.Text = "Range Of Date" Then

            srconstr = "select acno,acctype,bankname,bname,opendate,dot,balance from ACCOUNTS where acctype='" & _
            frm_home.acctype_sr_dot_CaSa & "' and dot between #" & Trim(CDate(txt_from.Text)) & "# and #" & Trim(CDate(txt_to.Text)) & " #"

            srconcmd = New OleDbCommand(srconstr, dbcon)

            srda = New OleDbDataAdapter(srconcmd)
            srds = New DataSet()
            srda.Fill(srds, "ACCOUNTS")

            dgv_sr_dotCaSa.DataSource = srds.Tables("ACCOUNTS").DefaultView
            dtp_from.Visible = True
            dbcon.Close()

        End If
    End Sub

    Private Sub cmd_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_reset.Click
        dtp_from.Value = Date.Today
        txt_from.Text = ""
        dtp_to.Value = Date.Today
        txt_to.Text = ""
        cmb_searchby.Text = ""
        dgv_sr_dotCaSa.DataSource = ""
        Call reset()
    End Sub

End Class