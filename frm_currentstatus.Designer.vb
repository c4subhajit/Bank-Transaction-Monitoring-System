<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_currentstatus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_currentstatus))
        Me.lbl_show = New System.Windows.Forms.Label
        Me.lbl_bank = New System.Windows.Forms.Label
        Me.cmb_show = New System.Windows.Forms.ComboBox
        Me.cmb_bank = New System.Windows.Forms.ComboBox
        Me.lbl_date = New System.Windows.Forms.Label
        Me.txt_sd = New System.Windows.Forms.TextBox
        Me.txt_ed = New System.Windows.Forms.TextBox
        Me.lbl_to = New System.Windows.Forms.Label
        Me.dtp_sd = New System.Windows.Forms.DateTimePicker
        Me.dtp_ed = New System.Windows.Forms.DateTimePicker
        Me.dgv_cs = New System.Windows.Forms.DataGridView
        Me.cmd_show = New System.Windows.Forms.Button
        Me.cmd_reset = New System.Windows.Forms.Button
        Me.lbl_dateinfo = New System.Windows.Forms.Label
        Me.cmb_acctype = New System.Windows.Forms.ComboBox
        Me.lbl_acctype = New System.Windows.Forms.Label
        Me.cmd_print = New System.Windows.Forms.Button
        CType(Me.dgv_cs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_show
        '
        Me.lbl_show.AutoSize = True
        Me.lbl_show.Location = New System.Drawing.Point(405, 10)
        Me.lbl_show.Name = "lbl_show"
        Me.lbl_show.Size = New System.Drawing.Size(49, 13)
        Me.lbl_show.TabIndex = 0
        Me.lbl_show.Text = "Show By"
        '
        'lbl_bank
        '
        Me.lbl_bank.AutoSize = True
        Me.lbl_bank.Location = New System.Drawing.Point(43, 45)
        Me.lbl_bank.Name = "lbl_bank"
        Me.lbl_bank.Size = New System.Drawing.Size(63, 13)
        Me.lbl_bank.TabIndex = 1
        Me.lbl_bank.Text = "Bank Name"
        '
        'cmb_show
        '
        Me.cmb_show.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_show.FormattingEnabled = True
        Me.cmb_show.Items.AddRange(New Object() {"All Record", "By Date", "By Bank Name"})
        Me.cmb_show.Location = New System.Drawing.Point(460, 7)
        Me.cmb_show.Name = "cmb_show"
        Me.cmb_show.Size = New System.Drawing.Size(125, 21)
        Me.cmb_show.TabIndex = 2
        '
        'cmb_bank
        '
        Me.cmb_bank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_bank.FormattingEnabled = True
        Me.cmb_bank.Location = New System.Drawing.Point(112, 42)
        Me.cmb_bank.Name = "cmb_bank"
        Me.cmb_bank.Size = New System.Drawing.Size(121, 21)
        Me.cmb_bank.TabIndex = 3
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Location = New System.Drawing.Point(292, 45)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(83, 13)
        Me.lbl_date.TabIndex = 4
        Me.lbl_date.Text = "Date of opening"
        '
        'txt_sd
        '
        Me.txt_sd.Location = New System.Drawing.Point(379, 42)
        Me.txt_sd.Name = "txt_sd"
        Me.txt_sd.ReadOnly = True
        Me.txt_sd.Size = New System.Drawing.Size(100, 20)
        Me.txt_sd.TabIndex = 5
        Me.txt_sd.TabStop = False
        Me.txt_sd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_ed
        '
        Me.txt_ed.Location = New System.Drawing.Point(551, 42)
        Me.txt_ed.Name = "txt_ed"
        Me.txt_ed.ReadOnly = True
        Me.txt_ed.Size = New System.Drawing.Size(100, 20)
        Me.txt_ed.TabIndex = 6
        Me.txt_ed.TabStop = False
        Me.txt_ed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_to
        '
        Me.lbl_to.AutoSize = True
        Me.lbl_to.Location = New System.Drawing.Point(517, 45)
        Me.lbl_to.Name = "lbl_to"
        Me.lbl_to.Size = New System.Drawing.Size(20, 13)
        Me.lbl_to.TabIndex = 7
        Me.lbl_to.Text = "To"
        '
        'dtp_sd
        '
        Me.dtp_sd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_sd.Location = New System.Drawing.Point(486, 41)
        Me.dtp_sd.Name = "dtp_sd"
        Me.dtp_sd.Size = New System.Drawing.Size(19, 20)
        Me.dtp_sd.TabIndex = 4
        Me.dtp_sd.Value = New Date(2012, 7, 6, 0, 0, 0, 0)
        '
        'dtp_ed
        '
        Me.dtp_ed.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_ed.Location = New System.Drawing.Point(657, 42)
        Me.dtp_ed.Name = "dtp_ed"
        Me.dtp_ed.Size = New System.Drawing.Size(19, 20)
        Me.dtp_ed.TabIndex = 5
        Me.dtp_ed.Value = New Date(2012, 7, 6, 0, 0, 0, 0)
        '
        'dgv_cs
        '
        Me.dgv_cs.AllowUserToAddRows = False
        Me.dgv_cs.AllowUserToDeleteRows = False
        Me.dgv_cs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_cs.Location = New System.Drawing.Point(12, 141)
        Me.dgv_cs.Name = "dgv_cs"
        Me.dgv_cs.ReadOnly = True
        Me.dgv_cs.Size = New System.Drawing.Size(710, 259)
        Me.dgv_cs.TabIndex = 10
        '
        'cmd_show
        '
        Me.cmd_show.Location = New System.Drawing.Point(187, 104)
        Me.cmd_show.Name = "cmd_show"
        Me.cmd_show.Size = New System.Drawing.Size(75, 23)
        Me.cmd_show.TabIndex = 6
        Me.cmd_show.Text = "Show"
        Me.cmd_show.UseVisualStyleBackColor = True
        '
        'cmd_reset
        '
        Me.cmd_reset.Location = New System.Drawing.Point(325, 104)
        Me.cmd_reset.Name = "cmd_reset"
        Me.cmd_reset.Size = New System.Drawing.Size(75, 23)
        Me.cmd_reset.TabIndex = 7
        Me.cmd_reset.Text = "Reset"
        Me.cmd_reset.UseVisualStyleBackColor = True
        '
        'lbl_dateinfo
        '
        Me.lbl_dateinfo.AutoSize = True
        Me.lbl_dateinfo.Location = New System.Drawing.Point(359, 75)
        Me.lbl_dateinfo.Name = "lbl_dateinfo"
        Me.lbl_dateinfo.Size = New System.Drawing.Size(265, 13)
        Me.lbl_dateinfo.TabIndex = 27
        Me.lbl_dateinfo.Text = "For  SINGLE   Date   Enter   only   the   START   Date."
        '
        'cmb_acctype
        '
        Me.cmb_acctype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_acctype.FormattingEnabled = True
        Me.cmb_acctype.Items.AddRange(New Object() {"Fixed Deposit", "Current Account", "Savings Account", "All Accounts"})
        Me.cmb_acctype.Location = New System.Drawing.Point(205, 7)
        Me.cmb_acctype.Name = "cmb_acctype"
        Me.cmb_acctype.Size = New System.Drawing.Size(125, 21)
        Me.cmb_acctype.TabIndex = 1
        '
        'lbl_acctype
        '
        Me.lbl_acctype.AutoSize = True
        Me.lbl_acctype.Location = New System.Drawing.Point(125, 10)
        Me.lbl_acctype.Name = "lbl_acctype"
        Me.lbl_acctype.Size = New System.Drawing.Size(74, 13)
        Me.lbl_acctype.TabIndex = 28
        Me.lbl_acctype.Text = "Account Type"
        '
        'cmd_print
        '
        Me.cmd_print.Location = New System.Drawing.Point(462, 104)
        Me.cmd_print.Name = "cmd_print"
        Me.cmd_print.Size = New System.Drawing.Size(75, 23)
        Me.cmd_print.TabIndex = 29
        Me.cmd_print.Text = "Print"
        Me.cmd_print.UseVisualStyleBackColor = True
        '
        'frm_currentstatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 412)
        Me.Controls.Add(Me.cmd_print)
        Me.Controls.Add(Me.cmb_acctype)
        Me.Controls.Add(Me.lbl_acctype)
        Me.Controls.Add(Me.lbl_dateinfo)
        Me.Controls.Add(Me.cmd_reset)
        Me.Controls.Add(Me.cmd_show)
        Me.Controls.Add(Me.dgv_cs)
        Me.Controls.Add(Me.dtp_ed)
        Me.Controls.Add(Me.dtp_sd)
        Me.Controls.Add(Me.lbl_to)
        Me.Controls.Add(Me.txt_ed)
        Me.Controls.Add(Me.txt_sd)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.cmb_bank)
        Me.Controls.Add(Me.cmb_show)
        Me.Controls.Add(Me.lbl_bank)
        Me.Controls.Add(Me.lbl_show)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(750, 450)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(750, 450)
        Me.Name = "frm_currentstatus"
        Me.Text = "Current Status"
        CType(Me.dgv_cs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_show As System.Windows.Forms.Label
    Friend WithEvents lbl_bank As System.Windows.Forms.Label
    Friend WithEvents cmb_show As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_bank As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_date As System.Windows.Forms.Label
    Friend WithEvents txt_sd As System.Windows.Forms.TextBox
    Friend WithEvents txt_ed As System.Windows.Forms.TextBox
    Friend WithEvents lbl_to As System.Windows.Forms.Label
    Friend WithEvents dtp_sd As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_ed As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgv_cs As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_show As System.Windows.Forms.Button
    Friend WithEvents cmd_reset As System.Windows.Forms.Button
    Friend WithEvents lbl_dateinfo As System.Windows.Forms.Label
    Friend WithEvents cmb_acctype As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_acctype As System.Windows.Forms.Label
    Friend WithEvents cmd_print As System.Windows.Forms.Button
End Class
