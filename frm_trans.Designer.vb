<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_trans
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_trans))
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmb_mot = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmb_tt = New System.Windows.Forms.ComboBox
        Me.opt_date = New System.Windows.Forms.RadioButton
        Me.grpbox_time = New System.Windows.Forms.GroupBox
        Me.cmb_ey = New System.Windows.Forms.ComboBox
        Me.cmb_sy = New System.Windows.Forms.ComboBox
        Me.cmb_monthyear = New System.Windows.Forms.ComboBox
        Me.cmb_month = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txt_ed = New System.Windows.Forms.TextBox
        Me.txt_sd = New System.Windows.Forms.TextBox
        Me.dtp_sd = New System.Windows.Forms.DateTimePicker
        Me.dtp_ed = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.opt_year = New System.Windows.Forms.RadioButton
        Me.opt_month = New System.Windows.Forms.RadioButton
        Me.dgv_tt = New System.Windows.Forms.DataGridView
        Me.cmd_show = New System.Windows.Forms.Button
        Me.grpbox_time.SuspendLayout()
        CType(Me.dgv_tt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mode of Transaction Display"
        '
        'cmb_mot
        '
        Me.cmb_mot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_mot.FormattingEnabled = True
        Me.cmb_mot.Items.AddRange(New Object() {"All Transactions", "Transactions By Date", "Transactions By Type"})
        Me.cmb_mot.Location = New System.Drawing.Point(162, 12)
        Me.cmb_mot.Name = "cmb_mot"
        Me.cmb_mot.Size = New System.Drawing.Size(137, 21)
        Me.cmb_mot.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(342, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Select Transaction Type"
        '
        'cmb_tt
        '
        Me.cmb_tt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tt.FormattingEnabled = True
        Me.cmb_tt.Items.AddRange(New Object() {"Account Created", "Account Modified", "Account Deleted", "Account Matured", "Withdrawl", "Deposit", "Cash Transfer", "Account Transfer"})
        Me.cmb_tt.Location = New System.Drawing.Point(471, 12)
        Me.cmb_tt.Name = "cmb_tt"
        Me.cmb_tt.Size = New System.Drawing.Size(133, 21)
        Me.cmb_tt.TabIndex = 3
        '
        'opt_date
        '
        Me.opt_date.AutoSize = True
        Me.opt_date.Location = New System.Drawing.Point(24, 19)
        Me.opt_date.Name = "opt_date"
        Me.opt_date.Size = New System.Drawing.Size(63, 17)
        Me.opt_date.TabIndex = 5
        Me.opt_date.TabStop = True
        Me.opt_date.Text = "By Date"
        Me.opt_date.UseVisualStyleBackColor = True
        '
        'grpbox_time
        '
        Me.grpbox_time.Controls.Add(Me.cmb_ey)
        Me.grpbox_time.Controls.Add(Me.cmb_sy)
        Me.grpbox_time.Controls.Add(Me.cmb_monthyear)
        Me.grpbox_time.Controls.Add(Me.cmb_month)
        Me.grpbox_time.Controls.Add(Me.Label9)
        Me.grpbox_time.Controls.Add(Me.txt_ed)
        Me.grpbox_time.Controls.Add(Me.txt_sd)
        Me.grpbox_time.Controls.Add(Me.dtp_sd)
        Me.grpbox_time.Controls.Add(Me.dtp_ed)
        Me.grpbox_time.Controls.Add(Me.Label8)
        Me.grpbox_time.Controls.Add(Me.Label7)
        Me.grpbox_time.Controls.Add(Me.Label6)
        Me.grpbox_time.Controls.Add(Me.Label5)
        Me.grpbox_time.Controls.Add(Me.Label4)
        Me.grpbox_time.Controls.Add(Me.Label3)
        Me.grpbox_time.Controls.Add(Me.opt_year)
        Me.grpbox_time.Controls.Add(Me.opt_month)
        Me.grpbox_time.Controls.Add(Me.opt_date)
        Me.grpbox_time.Location = New System.Drawing.Point(12, 40)
        Me.grpbox_time.Name = "grpbox_time"
        Me.grpbox_time.Size = New System.Drawing.Size(710, 114)
        Me.grpbox_time.TabIndex = 6
        Me.grpbox_time.TabStop = False
        Me.grpbox_time.Text = "Select Time Period"
        '
        'cmb_ey
        '
        Me.cmb_ey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ey.FormattingEnabled = True
        Me.cmb_ey.Location = New System.Drawing.Point(551, 60)
        Me.cmb_ey.Name = "cmb_ey"
        Me.cmb_ey.Size = New System.Drawing.Size(120, 21)
        Me.cmb_ey.TabIndex = 30
        '
        'cmb_sy
        '
        Me.cmb_sy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_sy.FormattingEnabled = True
        Me.cmb_sy.Location = New System.Drawing.Point(551, 37)
        Me.cmb_sy.Name = "cmb_sy"
        Me.cmb_sy.Size = New System.Drawing.Size(120, 21)
        Me.cmb_sy.TabIndex = 29
        '
        'cmb_monthyear
        '
        Me.cmb_monthyear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_monthyear.FormattingEnabled = True
        Me.cmb_monthyear.Location = New System.Drawing.Point(326, 59)
        Me.cmb_monthyear.Name = "cmb_monthyear"
        Me.cmb_monthyear.Size = New System.Drawing.Size(120, 21)
        Me.cmb_monthyear.TabIndex = 28
        '
        'cmb_month
        '
        Me.cmb_month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_month.FormattingEnabled = True
        Me.cmb_month.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cmb_month.Location = New System.Drawing.Point(326, 37)
        Me.cmb_month.Name = "cmb_month"
        Me.cmb_month.Size = New System.Drawing.Size(120, 21)
        Me.cmb_month.TabIndex = 27
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(211, 90)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(300, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "For  SINGLE   Date / Year    Enter the   START   Date / Year."
        '
        'txt_ed
        '
        Me.txt_ed.Location = New System.Drawing.Point(93, 61)
        Me.txt_ed.Name = "txt_ed"
        Me.txt_ed.ReadOnly = True
        Me.txt_ed.Size = New System.Drawing.Size(100, 20)
        Me.txt_ed.TabIndex = 21
        '
        'txt_sd
        '
        Me.txt_sd.Location = New System.Drawing.Point(93, 38)
        Me.txt_sd.Name = "txt_sd"
        Me.txt_sd.ReadOnly = True
        Me.txt_sd.Size = New System.Drawing.Size(100, 20)
        Me.txt_sd.TabIndex = 20
        '
        'dtp_sd
        '
        Me.dtp_sd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_sd.Location = New System.Drawing.Point(199, 38)
        Me.dtp_sd.MinDate = New Date(2008, 1, 1, 0, 0, 0, 0)
        Me.dtp_sd.Name = "dtp_sd"
        Me.dtp_sd.RightToLeftLayout = True
        Me.dtp_sd.Size = New System.Drawing.Size(18, 20)
        Me.dtp_sd.TabIndex = 17
        Me.dtp_sd.Value = New Date(2012, 6, 22, 0, 0, 0, 0)
        '
        'dtp_ed
        '
        Me.dtp_ed.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_ed.Location = New System.Drawing.Point(199, 61)
        Me.dtp_ed.MinDate = New Date(2008, 1, 1, 0, 0, 0, 0)
        Me.dtp_ed.Name = "dtp_ed"
        Me.dtp_ed.RightToLeftLayout = True
        Me.dtp_ed.Size = New System.Drawing.Size(18, 20)
        Me.dtp_ed.TabIndex = 14
        Me.dtp_ed.Value = New Date(2012, 6, 22, 0, 0, 0, 0)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(491, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Start Year"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(494, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "End Year"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(290, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Year"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(282, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Month"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "End Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Start Date"
        '
        'opt_year
        '
        Me.opt_year.AutoSize = True
        Me.opt_year.Location = New System.Drawing.Point(483, 19)
        Me.opt_year.Name = "opt_year"
        Me.opt_year.Size = New System.Drawing.Size(62, 17)
        Me.opt_year.TabIndex = 7
        Me.opt_year.TabStop = True
        Me.opt_year.Text = "By Year"
        Me.opt_year.UseVisualStyleBackColor = True
        '
        'opt_month
        '
        Me.opt_month.AutoSize = True
        Me.opt_month.Location = New System.Drawing.Point(251, 19)
        Me.opt_month.Name = "opt_month"
        Me.opt_month.Size = New System.Drawing.Size(70, 17)
        Me.opt_month.TabIndex = 6
        Me.opt_month.TabStop = True
        Me.opt_month.Text = "By Month"
        Me.opt_month.UseVisualStyleBackColor = True
        '
        'dgv_tt
        '
        Me.dgv_tt.AllowUserToAddRows = False
        Me.dgv_tt.AllowUserToDeleteRows = False
        Me.dgv_tt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_tt.Location = New System.Drawing.Point(12, 163)
        Me.dgv_tt.Name = "dgv_tt"
        Me.dgv_tt.ReadOnly = True
        Me.dgv_tt.Size = New System.Drawing.Size(710, 237)
        Me.dgv_tt.TabIndex = 7
        '
        'cmd_show
        '
        Me.cmd_show.Location = New System.Drawing.Point(649, 10)
        Me.cmd_show.Name = "cmd_show"
        Me.cmd_show.Size = New System.Drawing.Size(72, 23)
        Me.cmd_show.TabIndex = 8
        Me.cmd_show.Text = "Show"
        Me.cmd_show.UseVisualStyleBackColor = True
        '
        'frm_trans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 412)
        Me.Controls.Add(Me.cmd_show)
        Me.Controls.Add(Me.dgv_tt)
        Me.Controls.Add(Me.grpbox_time)
        Me.Controls.Add(Me.cmb_tt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_mot)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(750, 450)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(750, 450)
        Me.Name = "frm_trans"
        Me.Text = "Transactions"
        Me.grpbox_time.ResumeLayout(False)
        Me.grpbox_time.PerformLayout()
        CType(Me.dgv_tt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_mot As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_tt As System.Windows.Forms.ComboBox
    Friend WithEvents opt_date As System.Windows.Forms.RadioButton
    Friend WithEvents grpbox_time As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents opt_year As System.Windows.Forms.RadioButton
    Friend WithEvents opt_month As System.Windows.Forms.RadioButton
    Friend WithEvents dtp_sd As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_ed As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_ed As System.Windows.Forms.TextBox
    Friend WithEvents txt_sd As System.Windows.Forms.TextBox
    Friend WithEvents dgv_tt As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_show As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmb_monthyear As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_month As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_ey As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_sy As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
