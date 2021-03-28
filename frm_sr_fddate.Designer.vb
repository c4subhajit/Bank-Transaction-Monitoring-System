<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_sr_fddate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_sr_fddate))
        Me.cmd_reset = New System.Windows.Forms.Button
        Me.cmd_search = New System.Windows.Forms.Button
        Me.txt_dd_from = New System.Windows.Forms.TextBox
        Me.lbl_doo = New System.Windows.Forms.Label
        Me.dtp_from = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmb_saerchby = New System.Windows.Forms.ComboBox
        Me.dtp_to = New System.Windows.Forms.DateTimePicker
        Me.txt_dd_to = New System.Windows.Forms.TextBox
        Me.dgv_fd = New System.Windows.Forms.DataGridView
        Me.lbl_to = New System.Windows.Forms.Label
        CType(Me.dgv_fd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_reset
        '
        Me.cmd_reset.Location = New System.Drawing.Point(324, 46)
        Me.cmd_reset.Name = "cmd_reset"
        Me.cmd_reset.Size = New System.Drawing.Size(75, 23)
        Me.cmd_reset.TabIndex = 5
        Me.cmd_reset.Text = "Reset"
        Me.cmd_reset.UseVisualStyleBackColor = True
        '
        'cmd_search
        '
        Me.cmd_search.Location = New System.Drawing.Point(205, 46)
        Me.cmd_search.Name = "cmd_search"
        Me.cmd_search.Size = New System.Drawing.Size(75, 23)
        Me.cmd_search.TabIndex = 4
        Me.cmd_search.Text = "Search"
        Me.cmd_search.UseVisualStyleBackColor = True
        '
        'txt_dd_from
        '
        Me.txt_dd_from.Location = New System.Drawing.Point(302, 12)
        Me.txt_dd_from.Name = "txt_dd_from"
        Me.txt_dd_from.ReadOnly = True
        Me.txt_dd_from.Size = New System.Drawing.Size(95, 20)
        Me.txt_dd_from.TabIndex = 63
        Me.txt_dd_from.TabStop = False
        Me.txt_dd_from.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_doo
        '
        Me.lbl_doo.AutoSize = True
        Me.lbl_doo.Location = New System.Drawing.Point(211, 15)
        Me.lbl_doo.Name = "lbl_doo"
        Me.lbl_doo.Size = New System.Drawing.Size(0, 13)
        Me.lbl_doo.TabIndex = 62
        '
        'dtp_from
        '
        Me.dtp_from.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_from.Location = New System.Drawing.Point(403, 12)
        Me.dtp_from.Name = "dtp_from"
        Me.dtp_from.Size = New System.Drawing.Size(20, 20)
        Me.dtp_from.TabIndex = 2
        Me.dtp_from.Value = New Date(2012, 7, 7, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Search By"
        '
        'cmb_saerchby
        '
        Me.cmb_saerchby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_saerchby.FormattingEnabled = True
        Me.cmb_saerchby.Items.AddRange(New Object() {"Particular Date", "Range of Date"})
        Me.cmb_saerchby.Location = New System.Drawing.Point(71, 12)
        Me.cmb_saerchby.Name = "cmb_saerchby"
        Me.cmb_saerchby.Size = New System.Drawing.Size(121, 21)
        Me.cmb_saerchby.TabIndex = 1
        '
        'dtp_to
        '
        Me.dtp_to.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_to.Location = New System.Drawing.Point(567, 12)
        Me.dtp_to.Name = "dtp_to"
        Me.dtp_to.Size = New System.Drawing.Size(20, 20)
        Me.dtp_to.TabIndex = 3
        Me.dtp_to.Value = New Date(2012, 7, 7, 0, 0, 0, 0)
        '
        'txt_dd_to
        '
        Me.txt_dd_to.Location = New System.Drawing.Point(466, 12)
        Me.txt_dd_to.Name = "txt_dd_to"
        Me.txt_dd_to.ReadOnly = True
        Me.txt_dd_to.Size = New System.Drawing.Size(95, 20)
        Me.txt_dd_to.TabIndex = 68
        Me.txt_dd_to.TabStop = False
        Me.txt_dd_to.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgv_fd
        '
        Me.dgv_fd.AllowUserToAddRows = False
        Me.dgv_fd.AllowUserToDeleteRows = False
        Me.dgv_fd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_fd.Location = New System.Drawing.Point(11, 79)
        Me.dgv_fd.Name = "dgv_fd"
        Me.dgv_fd.ReadOnly = True
        Me.dgv_fd.Size = New System.Drawing.Size(575, 223)
        Me.dgv_fd.TabIndex = 70
        Me.dgv_fd.TabStop = False
        '
        'lbl_to
        '
        Me.lbl_to.AutoSize = True
        Me.lbl_to.Location = New System.Drawing.Point(434, 15)
        Me.lbl_to.Name = "lbl_to"
        Me.lbl_to.Size = New System.Drawing.Size(20, 13)
        Me.lbl_to.TabIndex = 71
        Me.lbl_to.Text = "To"
        '
        'frm_sr_fddate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 312)
        Me.Controls.Add(Me.lbl_to)
        Me.Controls.Add(Me.dgv_fd)
        Me.Controls.Add(Me.dtp_to)
        Me.Controls.Add(Me.txt_dd_to)
        Me.Controls.Add(Me.cmb_saerchby)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtp_from)
        Me.Controls.Add(Me.txt_dd_from)
        Me.Controls.Add(Me.lbl_doo)
        Me.Controls.Add(Me.cmd_reset)
        Me.Controls.Add(Me.cmd_search)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(615, 350)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(615, 350)
        Me.Name = "frm_sr_fddate"
        CType(Me.dgv_fd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_reset As System.Windows.Forms.Button
    Friend WithEvents cmd_search As System.Windows.Forms.Button
    Friend WithEvents txt_dd_from As System.Windows.Forms.TextBox
    Friend WithEvents lbl_doo As System.Windows.Forms.Label
    Friend WithEvents dtp_from As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_saerchby As System.Windows.Forms.ComboBox
    Friend WithEvents dtp_to As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_dd_to As System.Windows.Forms.TextBox
    Friend WithEvents dgv_fd As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_to As System.Windows.Forms.Label
End Class
