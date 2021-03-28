Imports System.Data.OleDb

Public Class frm_trans

    Dim dbcon As OleDbConnection
    Dim ttconcmd As OleDbCommand
    Dim ttconstrg As String
    Dim da As OleDb.OleDbDataAdapter
    Dim datareader As OleDbDataReader
    Dim ttdata As DataSet
    Dim rowCount As Double
    Dim maxdate, mindate As Date
    Dim maxyear, minyear As Integer
    Dim startMonthDate, endMonthDate As String


    Private Sub frm_trans_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        dbcon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\db.mdb")

        cmb_tt.Enabled = False
        grpbox_time.Enabled = False
        opt_date.Select()

        Call dateclear()

        '======================================================
        '             ADDING YEAR COMBOBOX VALUES
        '======================================================

        If Not dbcon.State = ConnectionState.Open Then
            dbcon.Open()
        End If

        ttconstrg = "select max(dot) from TT"
        ttconcmd = New OleDbCommand(ttconstrg, dbcon)
        datareader = ttconcmd.ExecuteReader()
        datareader.Read()

        If datareader.HasRows Then
            maxdate = datareader.Item(0)
            maxyear = maxdate.Year
        End If

        ttconstrg = "select min(dot) from TT"
        ttconcmd = New OleDbCommand(ttconstrg, dbcon)
        datareader = ttconcmd.ExecuteReader()
        datareader.Read()

        If datareader.HasRows Then
            mindate = datareader.Item(0)
            minyear = mindate.Year
        End If
        dbcon.Close()

        For count As Integer = minyear To maxyear
            cmb_monthyear.Items.Add(count)
            cmb_sy.Items.Add(count)
            cmb_ey.Items.Add(count)
        Next

        '======================================================
    End Sub

    Public Sub dateclear()
        txt_sd.Text = ""
        txt_ed.Text = ""
        cmb_month.Text = ""
        cmb_monthyear.Text = ""
        cmb_sy.Text = ""
        cmb_ey.Text = ""
        dgv_tt.DataSource = ""
    End Sub

    Private Sub cmb_mot_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_mot.SelectedIndexChanged

        If cmb_mot.SelectedItem = "All Transactions" Then

            cmb_tt.Enabled = False
            cmb_tt.Text = ""
            grpbox_time.Enabled = False
            opt_date.Select()

            Call dateclear()

        End If

        If cmb_mot.SelectedItem = "Transactions By Date" Then

            cmb_tt.Enabled = False
            cmb_tt.Text = ""
            grpbox_time.Enabled = True
            opt_date.Select()

            Call dateclear()

        End If

        If cmb_mot.SelectedItem = "Transactions By Type" Then

            cmb_tt.Enabled = True
            grpbox_time.Enabled = False
            opt_date.Select()

            Call dateclear()

        End If

    End Sub

    Private Sub cmb_tt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_tt.SelectedIndexChanged

        dgv_tt.DataSource = ""

    End Sub

    Private Sub opt_date_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opt_date.CheckedChanged

        dtp_sd.Enabled = True
        dtp_ed.Enabled = True
        cmb_month.Enabled = False
        cmb_monthyear.Enabled = False
        cmb_sy.Enabled = False
        cmb_ey.Enabled = False

        Call dateclear()

    End Sub

    Private Sub opt_month_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opt_month.CheckedChanged

        dtp_sd.Enabled = False
        dtp_ed.Enabled = False
        cmb_month.Enabled = True
        cmb_monthyear.Enabled = True
        cmb_sy.Enabled = False
        cmb_ey.Enabled = False

        Call dateclear()

    End Sub

    Private Sub opt_year_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opt_year.CheckedChanged

        dtp_sd.Enabled = False
        dtp_ed.Enabled = False
        cmb_month.Enabled = False
        cmb_monthyear.Enabled = False
        cmb_sy.Enabled = True
        cmb_ey.Enabled = True

        Call dateclear()

    End Sub

    Private Sub dtp_sd_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_sd.ValueChanged

        txt_sd.Text = dtp_sd.Value
        dgv_tt.DataSource = ""

    End Sub

    Private Sub dtp_ed_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_ed.ValueChanged

        txt_ed.Text = dtp_ed.Value
        dgv_tt.DataSource = ""

    End Sub

    Private Sub cmd_show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_show.Click

        '===================================================
        '              ALL TRANSACTION SEARCH
        '===================================================

        If cmb_mot.Text = "All Transactions" Then

            If Not dbcon.State = ConnectionState.Open Then
                dbcon.Open()
            End If

            ttconstrg = "select * from TT"
            ttconcmd = New OleDbCommand(ttconstrg, dbcon)
            da = New OleDb.OleDbDataAdapter(ttconcmd)
            ttdata = New DataSet()
            da.Fill(ttdata, "My Table")
            dgv_tt.DataSource = ttdata.Tables("My Table").DefaultView

            dbcon.Close()

        End If

        '===================================================
        '            TRANSACTION BY TYPE SEARCH
        '===================================================

        '                  SEARCH BY ACCOUNT CREATED
        '                 ---------------------------

        If (cmb_mot.Text = "Transactions By Type" And cmb_tt.Text = "Account Created") Then

            If Not dbcon.State = ConnectionState.Open Then
                dbcon.Open()
            End If

            ttconstrg = "select * from TT where remark = 'ACCOUNT CREATED'"
            ttconcmd = New OleDbCommand(ttconstrg, dbcon)
            da = New OleDb.OleDbDataAdapter(ttconcmd)
            ttdata = New DataSet()
            da.Fill(ttdata, "My Table")
            dgv_tt.DataSource = ttdata.Tables("My Table").DefaultView
            rowCount = ttdata.Tables(0).Rows.Count
            If rowCount = 0 Then
                MsgBox("No Transaction Of This Particular Type")
            End If

            dbcon.Close()

        End If

        '                  SEARCH BY ACCOUNT MODIFIED
        '                 ----------------------------

        If (cmb_mot.Text = "Transactions By Type" And cmb_tt.Text = "Account Modified") Then

            If Not dbcon.State = ConnectionState.Open Then
                dbcon.Open()
            End If

            ttconstrg = "select * from TT where remark = 'ACCOUNT MODIFIED'"
            ttconcmd = New OleDbCommand(ttconstrg, dbcon)
            da = New OleDb.OleDbDataAdapter(ttconcmd)
            ttdata = New DataSet()
            da.Fill(ttdata, "My Table")
            dgv_tt.DataSource = ttdata.Tables("My Table").DefaultView
            rowCount = ttdata.Tables(0).Rows.Count
            If rowCount = 0 Then
                MsgBox("No Transaction Of This Particular Type")
            End If

            dbcon.Close()

        End If

        '                  SEARCH BY ACCOUNT DELETED
        '                 ---------------------------    

        If (cmb_mot.Text = "Transactions By Type" And cmb_tt.Text = "Account Deleted") Then

            If Not dbcon.State = ConnectionState.Open Then
                dbcon.Open()
            End If

            ttconstrg = "select * from TT where remark = 'ACCOUNT DELETED'"
            ttconcmd = New OleDbCommand(ttconstrg, dbcon)
            da = New OleDb.OleDbDataAdapter(ttconcmd)
            ttdata = New DataSet()
            da.Fill(ttdata, "My Table")
            dgv_tt.DataSource = ttdata.Tables("My Table").DefaultView
            rowCount = ttdata.Tables(0).Rows.Count
            If rowCount = 0 Then
                MsgBox("No Transaction Of This Particular Type")
            End If

            dbcon.Close()

        End If

        '                  SEARCH BY ACCOUNT MATURED
        '                 ---------------------------

        If (cmb_mot.Text = "Transactions By Type" And cmb_tt.Text = "Account Matured") Then

            If Not dbcon.State = ConnectionState.Open Then
                dbcon.Open()
            End If

            ttconstrg = "select * from TT where remark = 'ACCOUNT MATURED'"
            ttconcmd = New OleDbCommand(ttconstrg, dbcon)
            da = New OleDb.OleDbDataAdapter(ttconcmd)
            ttdata = New DataSet()
            da.Fill(ttdata, "My Table")
            dgv_tt.DataSource = ttdata.Tables("My Table").DefaultView
            rowCount = ttdata.Tables(0).Rows.Count
            If rowCount = 0 Then
                MsgBox("No Transaction Of This Particular Type")
            End If

            dbcon.Close()

        End If

        '                  SEARCH BY WITHDRAWL
        '                 ---------------------

        If (cmb_mot.Text = "Transactions By Type" And cmb_tt.Text = "Withdrawl") Then

            If Not dbcon.State = ConnectionState.Open Then
                dbcon.Open()
            End If

            ttconstrg = "select * from TT where remark = 'WITHDRAWL'"
            ttconcmd = New OleDbCommand(ttconstrg, dbcon)
            da = New OleDb.OleDbDataAdapter(ttconcmd)
            ttdata = New DataSet()
            da.Fill(ttdata, "My Table")
            dgv_tt.DataSource = ttdata.Tables("My Table").DefaultView
            rowCount = ttdata.Tables(0).Rows.Count
            If rowCount = 0 Then
                MsgBox("No Transaction Of This Particular Type")
            End If

            dbcon.Close()

        End If

        '                  SEARCH BY DEPOSIT
        '                 --------------------

        If (cmb_mot.Text = "Transactions By Type" And cmb_tt.Text = "Deposit") Then

            If Not dbcon.State = ConnectionState.Open Then
                dbcon.Open()
            End If

            ttconstrg = "select * from TT where remark = 'DEPOSIT'"
            ttconcmd = New OleDbCommand(ttconstrg, dbcon)
            da = New OleDb.OleDbDataAdapter(ttconcmd)
            ttdata = New DataSet()
            da.Fill(ttdata, "My Table")
            dgv_tt.DataSource = ttdata.Tables("My Table").DefaultView
            rowCount = ttdata.Tables(0).Rows.Count
            If rowCount = 0 Then
                MsgBox("No Transaction Of This Particular Type")
            End If

            dbcon.Close()

        End If

        '                  CASH TRANSFER
        '                 ---------------

        If (cmb_mot.Text = "Transactions By Type" And cmb_tt.Text = "Cash Transfer") Then

            If Not dbcon.State = ConnectionState.Open Then
                dbcon.Open()
            End If

            ttconstrg = "select * from TT where from = 'CASH'"
            ttconcmd = New OleDbCommand(ttconstrg, dbcon)
            da = New OleDb.OleDbDataAdapter(ttconcmd)
            ttdata = New DataSet()
            da.Fill(ttdata, "My Table")
            dgv_tt.DataSource = ttdata.Tables("My Table").DefaultView
            rowCount = ttdata.Tables(0).Rows.Count
            If rowCount = 0 Then
                MsgBox("No Transaction Of This Particular Type")
            End If

            dbcon.Close()

        End If


        '                  ACCOUNT TRANSFER
        '                 ------------------

        If (cmb_mot.Text = "Transactions By Type" And cmb_tt.Text = "Account Transfer") Then

            If Not dbcon.State = ConnectionState.Open Then
                dbcon.Open()
            End If

            ttconstrg = "select * from TT where (from like '%ACCOUNT%') and (to like '%ACCOUNT%')"
            ttconcmd = New OleDbCommand(ttconstrg, dbcon)
            da = New OleDb.OleDbDataAdapter(ttconcmd)
            ttdata = New DataSet()
            da.Fill(ttdata, "My Table")
            dgv_tt.DataSource = ttdata.Tables("My Table").DefaultView
            rowCount = ttdata.Tables(0).Rows.Count
            If rowCount = 0 Then
                MsgBox("No Transaction Of This Particular Type")
            End If

            dbcon.Close()

        End If

        '===================================================
        '            TRANSACTION SEARCH BY DATE
        '===================================================

        '                  SEARCH BY DATE
        '                 ----------------

        If (cmb_mot.Text = "Transactions By Date" And opt_date.Checked = True) Then

            If Not dbcon.State = ConnectionState.Open Then
                dbcon.Open()
            End If

            If txt_ed.Text = "" Then
                ttconstrg = "select * from TT where dot =#" & Trim(CDate(txt_sd.Text)) & "#"

                ttconcmd = New OleDbCommand(ttconstrg, dbcon)
                da = New OleDb.OleDbDataAdapter(ttconcmd)
                ttdata = New DataSet()
                da.Fill(ttdata, "My Table")
                dgv_tt.DataSource = ttdata.Tables("My Table").DefaultView

                rowCount = ttdata.Tables(0).Rows.Count
                If rowCount = 0 Then
                    MsgBox("No Transaction Carried Out On This Particular Date")
                End If

            End If

            If Not (txt_sd.Text = "" Or txt_ed.Text = "") Then

                If Not (CDate(txt_ed.Text) > CDate(txt_sd.Text)) Then
                    MsgBox("Date difference not valid")
                    Exit Sub
                End If

                ttconstrg = "select * from TT where dot between #" & Trim(CDate(txt_sd.Text)) & "# and #" & Trim(CDate(txt_ed.Text)) & "#"

                ttconcmd = New OleDbCommand(ttconstrg, dbcon)
                da = New OleDb.OleDbDataAdapter(ttconcmd)
                ttdata = New DataSet()
                da.Fill(ttdata, "My Table")
                dgv_tt.DataSource = ttdata.Tables("My Table").DefaultView

                rowCount = ttdata.Tables(0).Rows.Count
                If rowCount = 0 Then
                    MsgBox("No Transaction Carried Out During This Time Period")
                End If

            End If
            dbcon.Close()

        End If

        '                  SEARCH BY MONTH
        '                 -----------------

        If (cmb_mot.Text = "Transactions By Date" And opt_month.Checked = True) Then

            If Not dbcon.State = ConnectionState.Open Then
                dbcon.Open()
            End If

            If cmb_month.Text = "" Then
                MsgBox("Please Select Month")
            ElseIf cmb_monthyear.Text = "" Then
                MsgBox("Please Select Year")
            ElseIf Not cmb_monthyear.Items.Count() = 0 Then

                If cmb_month.Text = "January" Then
                    startMonthDate = "01/01/" & cmb_monthyear.Text
                    endMonthDate = "01/31/" & cmb_monthyear.Text
                ElseIf cmb_month.Text = "February" Then
                    startMonthDate = "02/01/" & cmb_monthyear.Text
                    endMonthDate = "02/29/" & cmb_monthyear.Text
                ElseIf cmb_month.Text = "March" Then
                    startMonthDate = "03/01/" & cmb_monthyear.Text
                    endMonthDate = "03/31/" & cmb_monthyear.Text
                ElseIf cmb_month.Text = "April" Then
                    startMonthDate = "04/01/" & cmb_monthyear.Text
                    endMonthDate = "04/30/" & cmb_monthyear.Text
                ElseIf cmb_month.Text = "May" Then
                    startMonthDate = "05/01/" & cmb_monthyear.Text
                    endMonthDate = "05/31/" & cmb_monthyear.Text
                ElseIf cmb_month.Text = "June" Then
                    startMonthDate = "06/01/" & cmb_monthyear.Text
                    endMonthDate = "06/30/" & cmb_monthyear.Text
                ElseIf cmb_month.Text = "July" Then
                    startMonthDate = "07/01/" & cmb_monthyear.Text
                    endMonthDate = "07/31/" & cmb_monthyear.Text
                ElseIf cmb_month.Text = "August" Then
                    startMonthDate = "08/01/" & cmb_monthyear.Text
                    endMonthDate = "08/31/" & cmb_monthyear.Text
                ElseIf cmb_month.Text = "September" Then
                    startMonthDate = "09/01/" & cmb_monthyear.Text
                    endMonthDate = "09/30/" & cmb_monthyear.Text
                ElseIf cmb_month.Text = "October" Then
                    startMonthDate = "10/01/" & cmb_monthyear.Text
                    endMonthDate = "10/31/" & cmb_monthyear.Text
                ElseIf cmb_month.Text = "November" Then
                    startMonthDate = "11/01/" & cmb_monthyear.Text
                    endMonthDate = "11/30/" & cmb_monthyear.Text
                ElseIf cmb_month.Text = "December" Then
                    startMonthDate = "12/01/" & cmb_monthyear.Text
                    endMonthDate = "12/31/" & cmb_monthyear.Text
                End If

                ttconstrg = "select * from TT where dot between #" & Trim(CDate(startMonthDate)) & "# and #" & Trim(CDate(endMonthDate)) & "#"

                ttconcmd = New OleDbCommand(ttconstrg, dbcon)
                da = New OleDb.OleDbDataAdapter(ttconcmd)
                ttdata = New DataSet()
                da.Fill(ttdata, "My Table")
                dgv_tt.DataSource = ttdata.Tables("My Table").DefaultView

                rowCount = ttdata.Tables(0).Rows.Count
                If rowCount = 0 Then
                    MsgBox("No Transaction Carried Out During This Time Period")
                End If
            Else
                MsgBox("Transaction table contains no data")
            End If
            dbcon.Close()

        End If

        '                  SEARCH BY YEAR
        '                 ----------------

        If (cmb_mot.Text = "Transactions By Date" And opt_year.Checked = True) Then

            If Not dbcon.State = ConnectionState.Open Then
                dbcon.Open()
            End If

            If ((cmb_ey.Text = "") Or ((Val(cmb_ey.Text) - Val(cmb_sy.Text)) = 0)) Then

                ttconstrg = "select * from TT where dot between #" & Trim(CDate("01/01/" & _
                cmb_sy.Text)) & "# and #" & Trim(CDate("12/31/" & cmb_sy.Text)) & "#"

                ttconcmd = New OleDbCommand(ttconstrg, dbcon)
                da = New OleDb.OleDbDataAdapter(ttconcmd)
                ttdata = New DataSet()
                da.Fill(ttdata, "My Table")
                dgv_tt.DataSource = ttdata.Tables("My Table").DefaultView

                rowCount = ttdata.Tables(0).Rows.Count
                If rowCount = 0 Then
                    MsgBox("No Transaction Carried Out On This Particular Date")
                End If

            End If

            If Not (txt_sd.Text = "" Or txt_ed.Text = "") Then

                If Not (Year(cmb_ey.SelectedItem) > Year(cmb_sy.SelectedItem)) Then
                    MsgBox("Year difference not valid")
                    Exit Sub
                End If

                ttconstrg = "select * from TT where dot between #" & Trim(CDate("01/01/" & _
                cmb_sy.Text)) & "# and #" & Trim(CDate("12/31/" & cmb_ey.Text)) & "#"

                ttconcmd = New OleDbCommand(ttconstrg, dbcon)
                da = New OleDb.OleDbDataAdapter(ttconcmd)
                ttdata = New DataSet()
                da.Fill(ttdata, "My Table")
                dgv_tt.DataSource = ttdata.Tables("My Table").DefaultView

                rowCount = ttdata.Tables(0).Rows.Count
                If rowCount = 0 Then
                    MsgBox("No Transaction Carried Out During This Time Period")
                End If

            End If
            dbcon.Close()
        End If
    End Sub

End Class