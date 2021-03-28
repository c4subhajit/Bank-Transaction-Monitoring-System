Imports System.Data.OleDb
Public Class frm_useraccounts

    Dim dbcon As OleDbConnection
    Dim usercmd As OleDbCommand
    Dim userconstrg As String
    Dim da As OleDb.OleDbDataAdapter
    Dim dataReaderUser As OleDbDataReader
    Dim j As Integer

    Private Sub cmb_change_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_change.SelectedIndexChanged

        If cmb_change.Text = "Change Username" Then
            lbl_user.Enabled = True
            txt_user.Enabled = True
            lbl_pass.Enabled = False
            txt_pass.Enabled = False
        End If

        If cmb_change.Text = "Change Password" Then
            lbl_pass.Enabled = True
            txt_pass.Enabled = True
            lbl_user.Enabled = False
            txt_user.Enabled = False
        End If

    End Sub

    Public Sub reset()

        cmb_change.Text = ""
        lbl_user.Enabled = False
        txt_user.Enabled = False
        txt_user.Text = ""
        lbl_pass.Enabled = False
        txt_pass.Enabled = False
        txt_pass.Text = ""

    End Sub

    Private Sub frm_useraccounts_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Call reset()
        dbcon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\db.mdb")
        AcceptButton() = cmd_continue

    End Sub

    Private Sub cmd_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_save.Click

        If Not dbcon.State = ConnectionState.Open Then
            dbcon.Open()
        End If

        If cmb_change.SelectedItem = "Change Username" Then
            If Not txt_user.Text = "" Then
                userconstrg = "update ADMINISTRATOR set userid='" & txt_user.Text & "'"
                usercmd = New OleDbCommand(userconstrg, dbcon)
                j = usercmd.ExecuteNonQuery

                If j = 1 Then
                    MsgBox("Username Updated Successfully")
                End If
                dbcon.Close()
                Call reset()
                Exit Sub
            Else
                MsgBox("Please enter new username to update or click continue to proceed to the application")
            End If
        End If

        If cmb_change.SelectedItem = "Change Password" Then
            If Not txt_user.Text = "" Then
                userconstrg = "update ADMINISTRATOR set pass='" & txt_pass.Text & "'"
                usercmd = New OleDbCommand(userconstrg, dbcon)
                j = usercmd.ExecuteNonQuery

                If j = 1 Then
                    MsgBox("Password Updated Successfully")
                End If
                dbcon.Close()
                Call reset()
                Exit Sub
            Else
                MsgBox("Please enter new password to update or click continue to proceed to the application")
            End If
        End If

        MsgBox("Click continue to proceed to the application")

    End Sub

    Private Sub cmd_continue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_continue.Click

        Me.Close()
        frm_home.MenuStrip_TFDPC.Enabled = True
        frm_home.lbl_7days.Enabled = True
        frm_home.lbl_30days.Enabled = True
        frm_home.lbl_90days.Enabled = True
        Call frm_home.maturityCheck()
        frm_alert.Show()
        frm_alert.Hide()

    End Sub
End Class