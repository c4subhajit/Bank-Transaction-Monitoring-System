Imports System.Data.OleDb
Public Class frm_login

    Dim dbcon As OleDbConnection
    Dim usercmd As OleDbCommand
    Dim userconstrg As String
    Dim da As OleDb.OleDbDataAdapter
    Dim dataReaderUser As OleDbDataReader


    Public Sub reset()

        txt_user.Focus()
        chk_change.Checked = False

    End Sub

    Private Sub frm_login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frm_home.MenuStrip_TFDPC.Enabled = False

        txt_user.Text = ""
        txt_pass.Text = ""

        If frm_home.Enabled = False Then
            cmd_exit.Enabled = False
        Else
            cmd_exit.Enabled = True
        End If

        dbcon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\db.mdb")
        Call reset()
        txt_user.Focus()
        AcceptButton() = cmd_login

    End Sub

    Private Sub cmd_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_reset.Click
        Call reset()
    End Sub

    Private Sub cmd_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_login.Click

        If Not dbcon.State = ConnectionState.Open Then
            dbcon.Open()
        End If

        If txt_user.Text = "" Then
            MsgBox("Please enter username")
        ElseIf txt_pass.Text = "" Then
            MsgBox("Please enter password")
        Else
            If chk_change.Checked = False Then
                userconstrg = "select userid,pass from ADMINISTRATOR"
                usercmd = New OleDbCommand(userconstrg, dbcon)
                dataReaderUser = usercmd.ExecuteReader()
                dataReaderUser.Read()
                If dataReaderUser.HasRows Then
                    If (txt_user.Text = dataReaderUser.Item(0) And txt_pass.Text = dataReaderUser.Item(1)) Then
                        Call reset()
                        frm_home.Enabled = True
                        frm_home.BringToFront()
                        frm_home.MenuStrip_TFDPC.Enabled = True
                        frm_home.lbl_7days.Enabled = True
                        frm_home.lbl_30days.Enabled = True
                        frm_home.lbl_90days.Enabled = True
                        frm_alert.Show()
                        frm_alert.Hide()
                        Call frm_home.maturityCheck()
                        Me.Close()
                    Else
                        MsgBox("Username or Password incorrect")
                        Call reset()
                    End If
                End If
            End If

            If chk_change.Checked = True Then
                userconstrg = "select userid,pass from ADMINISTRATOR"
                usercmd = New OleDbCommand(userconstrg, dbcon)
                dataReaderUser = usercmd.ExecuteReader()
                dataReaderUser.Read()
                If dataReaderUser.HasRows Then
                    If (txt_user.Text = dataReaderUser.Item(0) And txt_pass.Text = dataReaderUser.Item(1)) Then
                        Call reset()
                        frm_home.Enabled = True
                        frm_home.BringToFront()
                        Try
                            Dim form As New frm_useraccounts
                            form.MdiParent = frm_home
                            form.Show()
                        Catch ex As Exception
                            MessageBox.Show(ex.Message, "Open Child")
                        End Try
                        Me.Close()
                    Else
                        MsgBox("Username or Password incorrect")
                        Call reset()
                    End If
                End If
            End If

            dbcon.Close()

        End If
    End Sub

    Private Sub cmd_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_exit.Click

        If MessageBox.Show("Do u want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            frm_home.Close()
        End If

    End Sub



End Class