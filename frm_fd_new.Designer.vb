<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_fd_new
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_fd_new))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_bn = New System.Windows.Forms.TextBox
        Me.txt_an = New System.Windows.Forms.TextBox
        Me.txt_da = New System.Windows.Forms.TextBox
        Me.txt_ir = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_mv = New System.Windows.Forms.TextBox
        Me.cmd_ok = New System.Windows.Forms.Button
        Me.cmd_reset = New System.Windows.Forms.Button
        Me.txt_brn = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.dtp_dd = New System.Windows.Forms.DateTimePicker
        Me.dtp_md = New System.Windows.Forms.DateTimePicker
        Me.txt_dd = New System.Windows.Forms.TextBox
        Me.txt_md = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmb_mod = New System.Windows.Forms.ComboBox
        Me.lbl_toa = New System.Windows.Forms.Label
        Me.lbl_tan = New System.Windows.Forms.Label
        Me.cmb_toa = New System.Windows.Forms.ComboBox
        Me.txt_tan = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(91, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name of Bank"
        '
        'txt_bn
        '
        Me.txt_bn.Location = New System.Drawing.Point(172, 9)
        Me.txt_bn.Name = "txt_bn"
        Me.txt_bn.Size = New System.Drawing.Size(158, 20)
        Me.txt_bn.TabIndex = 1
        '
        'txt_an
        '
        Me.txt_an.Location = New System.Drawing.Point(172, 68)
        Me.txt_an.Name = "txt_an"
        Me.txt_an.Size = New System.Drawing.Size(158, 20)
        Me.txt_an.TabIndex = 3
        '
        'txt_da
        '
        Me.txt_da.Location = New System.Drawing.Point(172, 96)
        Me.txt_da.Name = "txt_da"
        Me.txt_da.Size = New System.Drawing.Size(158, 20)
        Me.txt_da.TabIndex = 4
        '
        'txt_ir
        '
        Me.txt_ir.Location = New System.Drawing.Point(172, 124)
        Me.txt_ir.Name = "txt_ir"
        Me.txt_ir.Size = New System.Drawing.Size(158, 20)
        Me.txt_ir.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(98, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Interest Rate"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(72, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Deposited Amount"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(79, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Account Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Maturity Value before TDS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(95, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Maturity Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(90, 154)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Deposit Date"
        '
        'txt_mv
        '
        Me.txt_mv.Location = New System.Drawing.Point(172, 205)
        Me.txt_mv.Name = "txt_mv"
        Me.txt_mv.Size = New System.Drawing.Size(158, 20)
        Me.txt_mv.TabIndex = 8
        '
        'cmd_ok
        '
        Me.cmd_ok.Location = New System.Drawing.Point(402, 149)
        Me.cmd_ok.Name = "cmd_ok"
        Me.cmd_ok.Size = New System.Drawing.Size(75, 23)
        Me.cmd_ok.TabIndex = 12
        Me.cmd_ok.Text = "Ok"
        Me.cmd_ok.UseVisualStyleBackColor = True
        '
        'cmd_reset
        '
        Me.cmd_reset.Location = New System.Drawing.Point(526, 149)
        Me.cmd_reset.Name = "cmd_reset"
        Me.cmd_reset.Size = New System.Drawing.Size(75, 23)
        Me.cmd_reset.TabIndex = 13
        Me.cmd_reset.Text = "Reset"
        Me.cmd_reset.UseVisualStyleBackColor = True
        '
        'txt_brn
        '
        Me.txt_brn.Location = New System.Drawing.Point(172, 40)
        Me.txt_brn.Name = "txt_brn"
        Me.txt_brn.Size = New System.Drawing.Size(158, 20)
        Me.txt_brn.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(91, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Branch Name"
        '
        'dtp_dd
        '
        Me.dtp_dd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_dd.Location = New System.Drawing.Point(312, 152)
        Me.dtp_dd.Name = "dtp_dd"
        Me.dtp_dd.Size = New System.Drawing.Size(18, 20)
        Me.dtp_dd.TabIndex = 6
        Me.dtp_dd.Value = New Date(2012, 7, 14, 0, 0, 0, 0)
        '
        'dtp_md
        '
        Me.dtp_md.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_md.Location = New System.Drawing.Point(312, 178)
        Me.dtp_md.Name = "dtp_md"
        Me.dtp_md.Size = New System.Drawing.Size(18, 20)
        Me.dtp_md.TabIndex = 7
        Me.dtp_md.Value = New Date(2012, 7, 14, 0, 0, 0, 0)
        '
        'txt_dd
        '
        Me.txt_dd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dd.Location = New System.Drawing.Point(172, 151)
        Me.txt_dd.Name = "txt_dd"
        Me.txt_dd.ReadOnly = True
        Me.txt_dd.Size = New System.Drawing.Size(134, 20)
        Me.txt_dd.TabIndex = 20
        Me.txt_dd.TabStop = False
        Me.txt_dd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_md
        '
        Me.txt_md.Location = New System.Drawing.Point(172, 178)
        Me.txt_md.Name = "txt_md"
        Me.txt_md.ReadOnly = True
        Me.txt_md.Size = New System.Drawing.Size(134, 20)
        Me.txt_md.TabIndex = 21
        Me.txt_md.TabStop = False
        Me.txt_md.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(370, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Mode of Deposit"
        '
        'cmb_mod
        '
        Me.cmb_mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_mod.FormattingEnabled = True
        Me.cmb_mod.Items.AddRange(New Object() {"Cash", "Account Transfer"})
        Me.cmb_mod.Location = New System.Drawing.Point(461, 8)
        Me.cmb_mod.Name = "cmb_mod"
        Me.cmb_mod.Size = New System.Drawing.Size(158, 21)
        Me.cmb_mod.TabIndex = 9
        '
        'lbl_toa
        '
        Me.lbl_toa.AutoSize = True
        Me.lbl_toa.Location = New System.Drawing.Point(369, 42)
        Me.lbl_toa.Name = "lbl_toa"
        Me.lbl_toa.Size = New System.Drawing.Size(86, 13)
        Me.lbl_toa.TabIndex = 24
        Me.lbl_toa.Text = "Type of Account"
        '
        'lbl_tan
        '
        Me.lbl_tan.AutoSize = True
        Me.lbl_tan.Location = New System.Drawing.Point(340, 71)
        Me.lbl_tan.Name = "lbl_tan"
        Me.lbl_tan.Size = New System.Drawing.Size(115, 13)
        Me.lbl_tan.TabIndex = 25
        Me.lbl_tan.Text = "Debit Account Number"
        '
        'cmb_toa
        '
        Me.cmb_toa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_toa.FormattingEnabled = True
        Me.cmb_toa.Items.AddRange(New Object() {"Current Account", "Savings Account"})
        Me.cmb_toa.Location = New System.Drawing.Point(461, 39)
        Me.cmb_toa.Name = "cmb_toa"
        Me.cmb_toa.Size = New System.Drawing.Size(158, 21)
        Me.cmb_toa.TabIndex = 10
        '
        'txt_tan
        '
        Me.txt_tan.Location = New System.Drawing.Point(461, 68)
        Me.txt_tan.Name = "txt_tan"
        Me.txt_tan.Size = New System.Drawing.Size(158, 20)
        Me.txt_tan.TabIndex = 11
        '
        'frm_fd_new
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 236)
        Me.Controls.Add(Me.txt_tan)
        Me.Controls.Add(Me.cmb_toa)
        Me.Controls.Add(Me.lbl_tan)
        Me.Controls.Add(Me.lbl_toa)
        Me.Controls.Add(Me.cmb_mod)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_md)
        Me.Controls.Add(Me.txt_dd)
        Me.Controls.Add(Me.dtp_md)
        Me.Controls.Add(Me.dtp_dd)
        Me.Controls.Add(Me.txt_brn)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmd_reset)
        Me.Controls.Add(Me.cmd_ok)
        Me.Controls.Add(Me.txt_mv)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_ir)
        Me.Controls.Add(Me.txt_da)
        Me.Controls.Add(Me.txt_an)
        Me.Controls.Add(Me.txt_bn)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(670, 274)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(670, 274)
        Me.Name = "frm_fd_new"
        Me.Text = "New Fixed Deposit Record"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_bn As System.Windows.Forms.TextBox
    Friend WithEvents txt_an As System.Windows.Forms.TextBox
    Friend WithEvents txt_da As System.Windows.Forms.TextBox
    Friend WithEvents txt_ir As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_mv As System.Windows.Forms.TextBox
    Friend WithEvents cmd_ok As System.Windows.Forms.Button
    Friend WithEvents cmd_reset As System.Windows.Forms.Button
    Friend WithEvents txt_brn As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtp_dd As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_md As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_dd As System.Windows.Forms.TextBox
    Friend WithEvents txt_md As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmb_mod As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_toa As System.Windows.Forms.Label
    Friend WithEvents lbl_tan As System.Windows.Forms.Label
    Friend WithEvents cmb_toa As System.Windows.Forms.ComboBox
    Friend WithEvents txt_tan As System.Windows.Forms.TextBox
End Class
