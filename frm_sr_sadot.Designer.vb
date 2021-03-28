<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_sr_sadot
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmb_sr = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_dot = New System.Windows.Forms.TextBox
        Me.dtp_dot = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_from = New System.Windows.Forms.TextBox
        Me.txt_to = New System.Windows.Forms.TextBox
        Me.dtp_from = New System.Windows.Forms.DateTimePicker
        Me.dtp_to = New System.Windows.Forms.DateTimePicker
        Me.dgv_srdot = New System.Windows.Forms.DataGridView
        Me.cmd_sr = New System.Windows.Forms.Button
        Me.cmd_reset = New System.Windows.Forms.Button
        CType(Me.dgv_srdot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(106, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search By"
        '
        'cmb_sr
        '
        Me.cmb_sr.FormattingEnabled = True
        Me.cmb_sr.Items.AddRange(New Object() {"A Particuler Date", "Range of Date"})
        Me.cmb_sr.Location = New System.Drawing.Point(168, 11)
        Me.cmb_sr.Name = "cmb_sr"
        Me.cmb_sr.Size = New System.Drawing.Size(121, 21)
        Me.cmb_sr.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Date of Transaction"
        '
        'txt_dot
        '
        Me.txt_dot.Location = New System.Drawing.Point(168, 46)
        Me.txt_dot.Name = "txt_dot"
        Me.txt_dot.ReadOnly = True
        Me.txt_dot.Size = New System.Drawing.Size(100, 20)
        Me.txt_dot.TabIndex = 3
        '
        'dtp_dot
        '
        Me.dtp_dot.Location = New System.Drawing.Point(267, 46)
        Me.dtp_dot.Name = "dtp_dot"
        Me.dtp_dot.Size = New System.Drawing.Size(22, 20)
        Me.dtp_dot.TabIndex = 4
        Me.dtp_dot.Value = New Date(2012, 6, 2, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(132, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "From"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(142, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "To"
        '
        'txt_from
        '
        Me.txt_from.Location = New System.Drawing.Point(168, 87)
        Me.txt_from.Name = "txt_from"
        Me.txt_from.ReadOnly = True
        Me.txt_from.Size = New System.Drawing.Size(106, 20)
        Me.txt_from.TabIndex = 7
        '
        'txt_to
        '
        Me.txt_to.Location = New System.Drawing.Point(168, 119)
        Me.txt_to.Name = "txt_to"
        Me.txt_to.ReadOnly = True
        Me.txt_to.Size = New System.Drawing.Size(100, 20)
        Me.txt_to.TabIndex = 8
        '
        'dtp_from
        '
        Me.dtp_from.Location = New System.Drawing.Point(267, 87)
        Me.dtp_from.Name = "dtp_from"
        Me.dtp_from.Size = New System.Drawing.Size(21, 20)
        Me.dtp_from.TabIndex = 9
        Me.dtp_from.Value = New Date(2012, 6, 2, 0, 0, 0, 0)
        '
        'dtp_to
        '
        Me.dtp_to.Location = New System.Drawing.Point(268, 119)
        Me.dtp_to.Name = "dtp_to"
        Me.dtp_to.Size = New System.Drawing.Size(21, 20)
        Me.dtp_to.TabIndex = 10
        Me.dtp_to.Value = New Date(2012, 6, 2, 0, 0, 0, 0)
        '
        'dgv_srdot
        '
        Me.dgv_srdot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_srdot.Location = New System.Drawing.Point(12, 195)
        Me.dgv_srdot.Name = "dgv_srdot"
        Me.dgv_srdot.Size = New System.Drawing.Size(404, 150)
        Me.dgv_srdot.TabIndex = 11
        '
        'cmd_sr
        '
        Me.cmd_sr.Location = New System.Drawing.Point(114, 157)
        Me.cmd_sr.Name = "cmd_sr"
        Me.cmd_sr.Size = New System.Drawing.Size(75, 23)
        Me.cmd_sr.TabIndex = 12
        Me.cmd_sr.Text = "Search"
        Me.cmd_sr.UseVisualStyleBackColor = True
        '
        'cmd_reset
        '
        Me.cmd_reset.Location = New System.Drawing.Point(229, 157)
        Me.cmd_reset.Name = "cmd_reset"
        Me.cmd_reset.Size = New System.Drawing.Size(75, 23)
        Me.cmd_reset.TabIndex = 13
        Me.cmd_reset.Text = "Reset"
        Me.cmd_reset.UseVisualStyleBackColor = True
        '
        'frm_sr_sadot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 358)
        Me.Controls.Add(Me.cmd_reset)
        Me.Controls.Add(Me.cmd_sr)
        Me.Controls.Add(Me.dgv_srdot)
        Me.Controls.Add(Me.dtp_to)
        Me.Controls.Add(Me.dtp_from)
        Me.Controls.Add(Me.txt_to)
        Me.Controls.Add(Me.txt_from)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtp_dot)
        Me.Controls.Add(Me.txt_dot)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_sr)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_sr_sadot"
        Me.Text = "Search By Date of Transaction"
        CType(Me.dgv_srdot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_sr As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_dot As System.Windows.Forms.TextBox
    Friend WithEvents dtp_dot As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_from As System.Windows.Forms.TextBox
    Friend WithEvents txt_to As System.Windows.Forms.TextBox
    Friend WithEvents dtp_from As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_to As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgv_srdot As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_sr As System.Windows.Forms.Button
    Friend WithEvents cmd_reset As System.Windows.Forms.Button
End Class
