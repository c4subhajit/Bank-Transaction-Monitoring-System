Imports System.Data.OleDb
Public Class frm_sr_sadot

    Private Sub frm_sr_sadot_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbDataSet3.SA' table. You can move, or remove it, as needed.
        'Me.SATableAdapter.Fill(Me.DbDataSet3.SA)

        txt_dot.Enabled = False
        dtp_dot.Enabled = False
        dtp_from.Enabled = False
        dtp_to.Enabled = False
        txt_dot.Text = ""
        txt_from.Text = ""
        txt_to.Text = ""
    End Sub

    Private Sub cmd_sr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_sr.Click
        Dim dbcon As OleDbConnection
        Dim saconcmd As OleDbCommand
        Dim saconstrg As String
        Dim da As OleDb.OleDbDataAdapter
        Dim sadata As DataSet

        dbcon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\db.mdb")

        If Not dbcon.State = ConnectionState.Open Then
            dbcon.Open()
        End If

        If cmb_sr.Text = "A Particuler Date" Then
            
           
            saconstrg = "select * from ACCOUNTS where dot =#" & Trim(CDate(txt_dot.Text)) & "#"
            saconcmd = New OleDbCommand(saconstrg, dbcon)
            da = New OleDb.OleDbDataAdapter(saconcmd)
            sadata = New DataSet()
            da.Fill(sadata, "My Table")
            dgv_srdot.DataSource = sadata.Tables("My Table").DefaultView


        End If

        If cmb_sr.Text = "Range of Date" Then
            saconstrg = "select * from ACCOUNTS where dot between #" & Trim(CDate(txt_from.Text)) & "# and #" & Trim(CDate(txt_to.Text)) & "#"
            saconcmd = New OleDbCommand(saconstrg, dbcon)
            da = New OleDb.OleDbDataAdapter(saconcmd)
            sadata = New DataSet()
            da.Fill(sadata, "My Table")
            dgv_srdot.DataSource = sadata.Tables("My Table").DefaultView
        End If

        dbcon.Close()

    End Sub

    Private Sub dtp_dot_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_dot.ValueChanged
        txt_dot.Text = dtp_dot.Value
        dgv_srdot.DataSource = ""
    End Sub

    Private Sub dtp_from_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_from.ValueChanged
        txt_from.Text = dtp_from.Value
        dgv_srdot.DataSource = ""
    End Sub

    Private Sub dtp_to_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_to.ValueChanged
        txt_to.Text = dtp_to.Value
        dgv_srdot.DataSource = ""
    End Sub

    Private Sub cmd_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_reset.Click
        
        dtp_to.Enabled = False
        dtp_from.Enabled = False
        txt_to.Text = ""
        txt_from.Text = ""
        cmb_sr.Text = ""
        dgv_srdot.DataSource = ""
        txt_dot.Text = ""
    End Sub

    Private Sub cmb_sr_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_sr.SelectedIndexChanged
        If cmb_sr.Text = "A Particuler Date" Then
            txt_dot.Enabled = True
            dtp_dot.Enabled = True
            txt_from.Enabled = False
            dtp_from.Enabled = False
            txt_to.Enabled = False
            dtp_to.Enabled = False
        End If
        If cmb_sr.Text = "Range of Date" Then
            txt_dot.Enabled = False
            dtp_dot.Enabled = False
            txt_from.Enabled = True
            dtp_from.Enabled = True
            txt_to.Enabled = True
            dtp_to.Enabled = True
        End If
    End Sub
End Class