<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_sr_dotCaSa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_sr_dotCaSa))
        Me.cmd_reset = New System.Windows.Forms.Button
        Me.cmd_show = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.dgv_sr_dotCaSa = New System.Windows.Forms.DataGridView
        Me.cmb_searchby = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbl_dot = New System.Windows.Forms.Label
        Me.txt_to = New System.Windows.Forms.TextBox
        Me.txt_from = New System.Windows.Forms.TextBox
        Me.dtp_from = New System.Windows.Forms.DateTimePicker
        Me.lbl_to = New System.Windows.Forms.Label
        Me.dtp_to = New System.Windows.Forms.DateTimePicker
        CType(Me.dgv_sr_dotCaSa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_reset
        '
        Me.cmd_reset.Location = New System.Drawing.Point(322, 55)
        Me.cmd_reset.Name = "cmd_reset"
        Me.cmd_reset.Size = New System.Drawing.Size(75, 23)
        Me.cmd_reset.TabIndex = 5
        Me.cmd_reset.Text = "Reset"
        Me.cmd_reset.UseVisualStyleBackColor = True
        '
        'cmd_show
        '
        Me.cmd_show.Location = New System.Drawing.Point(212, 55)
        Me.cmd_show.Name = "cmd_show"
        Me.cmd_show.Size = New System.Drawing.Size(75, 23)
        Me.cmd_show.TabIndex = 4
        Me.cmd_show.Text = "Show"
        Me.cmd_show.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Search By"
        '
        'dgv_sr_dotCaSa
        '
        Me.dgv_sr_dotCaSa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_sr_dotCaSa.Location = New System.Drawing.Point(13, 89)
        Me.dgv_sr_dotCaSa.Name = "dgv_sr_dotCaSa"
        Me.dgv_sr_dotCaSa.Size = New System.Drawing.Size(579, 237)
        Me.dgv_sr_dotCaSa.TabIndex = 62
        Me.dgv_sr_dotCaSa.TabStop = False
        '
        'cmb_searchby
        '
        Me.cmb_searchby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_searchby.FormattingEnabled = True
        Me.cmb_searchby.Items.AddRange(New Object() {"Single Date", "Range Of Date"})
        Me.cmb_searchby.Location = New System.Drawing.Point(70, 23)
        Me.cmb_searchby.Name = "cmb_searchby"
        Me.cmb_searchby.Size = New System.Drawing.Size(108, 21)
        Me.cmb_searchby.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(433, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 64
        '
        'lbl_dot
        '
        Me.lbl_dot.AutoSize = True
        Me.lbl_dot.Location = New System.Drawing.Point(198, 26)
        Me.lbl_dot.Name = "lbl_dot"
        Me.lbl_dot.Size = New System.Drawing.Size(103, 13)
        Me.lbl_dot.TabIndex = 65
        Me.lbl_dot.Text = "Date Of Transaction"
        '
        'txt_to
        '
        Me.txt_to.Location = New System.Drawing.Point(465, 23)
        Me.txt_to.Name = "txt_to"
        Me.txt_to.ReadOnly = True
        Me.txt_to.Size = New System.Drawing.Size(100, 20)
        Me.txt_to.TabIndex = 66
        Me.txt_to.TabStop = False
        Me.txt_to.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_from
        '
        Me.txt_from.Location = New System.Drawing.Point(307, 24)
        Me.txt_from.Name = "txt_from"
        Me.txt_from.ReadOnly = True
        Me.txt_from.Size = New System.Drawing.Size(100, 20)
        Me.txt_from.TabIndex = 2
        Me.txt_from.TabStop = False
        Me.txt_from.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtp_from
        '
        Me.dtp_from.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_from.Location = New System.Drawing.Point(413, 24)
        Me.dtp_from.Name = "dtp_from"
        Me.dtp_from.Size = New System.Drawing.Size(19, 20)
        Me.dtp_from.TabIndex = 2
        Me.dtp_from.Value = New Date(2012, 7, 8, 0, 0, 0, 0)
        '
        'lbl_to
        '
        Me.lbl_to.AutoSize = True
        Me.lbl_to.Location = New System.Drawing.Point(439, 27)
        Me.lbl_to.Name = "lbl_to"
        Me.lbl_to.Size = New System.Drawing.Size(20, 13)
        Me.lbl_to.TabIndex = 69
        Me.lbl_to.Text = "To"
        '
        'dtp_to
        '
        Me.dtp_to.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_to.Location = New System.Drawing.Point(571, 23)
        Me.dtp_to.Name = "dtp_to"
        Me.dtp_to.Size = New System.Drawing.Size(19, 20)
        Me.dtp_to.TabIndex = 3
        Me.dtp_to.Value = New Date(2012, 7, 8, 0, 0, 0, 0)
        '
        'frm_sr_dotCaSa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 339)
        Me.Controls.Add(Me.dtp_to)
        Me.Controls.Add(Me.lbl_to)
        Me.Controls.Add(Me.dtp_from)
        Me.Controls.Add(Me.txt_from)
        Me.Controls.Add(Me.txt_to)
        Me.Controls.Add(Me.lbl_dot)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_searchby)
        Me.Controls.Add(Me.dgv_sr_dotCaSa)
        Me.Controls.Add(Me.cmd_reset)
        Me.Controls.Add(Me.cmd_show)
        Me.Controls.Add(Me.Label7)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(620, 377)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(620, 377)
        Me.Name = "frm_sr_dotCaSa"
        Me.Text = "Search By Date of Transaction"
        CType(Me.dgv_sr_dotCaSa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_reset As System.Windows.Forms.Button
    Friend WithEvents cmd_show As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dgv_sr_dotCaSa As System.Windows.Forms.DataGridView
    Friend WithEvents cmb_searchby As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_dot As System.Windows.Forms.Label
    Friend WithEvents txt_to As System.Windows.Forms.TextBox
    Friend WithEvents txt_from As System.Windows.Forms.TextBox
    Friend WithEvents dtp_from As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_to As System.Windows.Forms.Label
    Friend WithEvents dtp_to As System.Windows.Forms.DateTimePicker
End Class
