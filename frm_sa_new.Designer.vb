<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_sa_new
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_sa_new))
        Me.txt_brn = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmd_reset = New System.Windows.Forms.Button
        Me.cmd_ok = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_blnc = New System.Windows.Forms.TextBox
        Me.txt_an = New System.Windows.Forms.TextBox
        Me.txt_bn = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_dot = New System.Windows.Forms.TextBox
        Me.dtp_dd = New System.Windows.Forms.DateTimePicker
        Me.txt_tan = New System.Windows.Forms.TextBox
        Me.cmb_toa = New System.Windows.Forms.ComboBox
        Me.lbl_tan = New System.Windows.Forms.Label
        Me.lbl_toa = New System.Windows.Forms.Label
        Me.cmb_mod = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_ir = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'txt_brn
        '
        Me.txt_brn.Location = New System.Drawing.Point(112, 46)
        Me.txt_brn.Name = "txt_brn"
        Me.txt_brn.Size = New System.Drawing.Size(158, 20)
        Me.txt_brn.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(31, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Branch Name"
        '
        'cmd_reset
        '
        Me.cmd_reset.Location = New System.Drawing.Point(464, 132)
        Me.cmd_reset.Name = "cmd_reset"
        Me.cmd_reset.Size = New System.Drawing.Size(75, 23)
        Me.cmd_reset.TabIndex = 11
        Me.cmd_reset.Text = "Reset"
        Me.cmd_reset.UseVisualStyleBackColor = True
        '
        'cmd_ok
        '
        Me.cmd_ok.Location = New System.Drawing.Point(339, 132)
        Me.cmd_ok.Name = "cmd_ok"
        Me.cmd_ok.Size = New System.Drawing.Size(75, 23)
        Me.cmd_ok.TabIndex = 10
        Me.cmd_ok.Text = "Ok"
        Me.cmd_ok.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Date Of Opening"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Account Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Amount"
        '
        'txt_blnc
        '
        Me.txt_blnc.Location = New System.Drawing.Point(112, 132)
        Me.txt_blnc.Name = "txt_blnc"
        Me.txt_blnc.Size = New System.Drawing.Size(158, 20)
        Me.txt_blnc.TabIndex = 5
        '
        'txt_an
        '
        Me.txt_an.Location = New System.Drawing.Point(112, 74)
        Me.txt_an.Name = "txt_an"
        Me.txt_an.Size = New System.Drawing.Size(158, 20)
        Me.txt_an.TabIndex = 3
        '
        'txt_bn
        '
        Me.txt_bn.Location = New System.Drawing.Point(112, 17)
        Me.txt_bn.Name = "txt_bn"
        Me.txt_bn.Size = New System.Drawing.Size(158, 20)
        Me.txt_bn.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Name of Bank"
        '
        'txt_dot
        '
        Me.txt_dot.Location = New System.Drawing.Point(112, 103)
        Me.txt_dot.Name = "txt_dot"
        Me.txt_dot.ReadOnly = True
        Me.txt_dot.Size = New System.Drawing.Size(134, 20)
        Me.txt_dot.TabIndex = 36
        Me.txt_dot.TabStop = False
        Me.txt_dot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtp_dd
        '
        Me.dtp_dd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_dd.Location = New System.Drawing.Point(252, 103)
        Me.dtp_dd.Name = "dtp_dd"
        Me.dtp_dd.Size = New System.Drawing.Size(18, 20)
        Me.dtp_dd.TabIndex = 4
        Me.dtp_dd.Value = New Date(2012, 7, 5, 0, 0, 0, 0)
        '
        'txt_tan
        '
        Me.txt_tan.Location = New System.Drawing.Point(407, 81)
        Me.txt_tan.Name = "txt_tan"
        Me.txt_tan.Size = New System.Drawing.Size(158, 20)
        Me.txt_tan.TabIndex = 9
        '
        'cmb_toa
        '
        Me.cmb_toa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_toa.FormattingEnabled = True
        Me.cmb_toa.Items.AddRange(New Object() {"Savings Account", "Current Account"})
        Me.cmb_toa.Location = New System.Drawing.Point(407, 50)
        Me.cmb_toa.Name = "cmb_toa"
        Me.cmb_toa.Size = New System.Drawing.Size(158, 21)
        Me.cmb_toa.TabIndex = 8
        '
        'lbl_tan
        '
        Me.lbl_tan.AutoSize = True
        Me.lbl_tan.Location = New System.Drawing.Point(286, 84)
        Me.lbl_tan.Name = "lbl_tan"
        Me.lbl_tan.Size = New System.Drawing.Size(115, 13)
        Me.lbl_tan.TabIndex = 42
        Me.lbl_tan.Text = "Debit Account Number"
        '
        'lbl_toa
        '
        Me.lbl_toa.AutoSize = True
        Me.lbl_toa.Location = New System.Drawing.Point(315, 53)
        Me.lbl_toa.Name = "lbl_toa"
        Me.lbl_toa.Size = New System.Drawing.Size(86, 13)
        Me.lbl_toa.TabIndex = 41
        Me.lbl_toa.Text = "Type of Account"
        '
        'cmb_mod
        '
        Me.cmb_mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_mod.FormattingEnabled = True
        Me.cmb_mod.Items.AddRange(New Object() {"Cash", "Account Transfer"})
        Me.cmb_mod.Location = New System.Drawing.Point(407, 18)
        Me.cmb_mod.Name = "cmb_mod"
        Me.cmb_mod.Size = New System.Drawing.Size(158, 21)
        Me.cmb_mod.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(316, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 13)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Mode of Deposit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Interest"
        '
        'txt_ir
        '
        Me.txt_ir.Location = New System.Drawing.Point(112, 163)
        Me.txt_ir.Name = "txt_ir"
        Me.txt_ir.Size = New System.Drawing.Size(158, 20)
        Me.txt_ir.TabIndex = 6
        '
        'frm_sa_new
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 197)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_ir)
        Me.Controls.Add(Me.txt_tan)
        Me.Controls.Add(Me.cmb_toa)
        Me.Controls.Add(Me.lbl_tan)
        Me.Controls.Add(Me.lbl_toa)
        Me.Controls.Add(Me.cmb_mod)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dtp_dd)
        Me.Controls.Add(Me.txt_dot)
        Me.Controls.Add(Me.txt_brn)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmd_reset)
        Me.Controls.Add(Me.cmd_ok)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_blnc)
        Me.Controls.Add(Me.txt_an)
        Me.Controls.Add(Me.txt_bn)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(602, 235)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(602, 235)
        Me.Name = "frm_sa_new"
        Me.Text = " New Record in Savings Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_brn As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmd_reset As System.Windows.Forms.Button
    Friend WithEvents cmd_ok As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_blnc As System.Windows.Forms.TextBox
    Friend WithEvents txt_an As System.Windows.Forms.TextBox
    Friend WithEvents txt_bn As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_dot As System.Windows.Forms.TextBox
    Friend WithEvents dtp_dd As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_tan As System.Windows.Forms.TextBox
    Friend WithEvents cmb_toa As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_tan As System.Windows.Forms.Label
    Friend WithEvents lbl_toa As System.Windows.Forms.Label
    Friend WithEvents cmb_mod As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_ir As System.Windows.Forms.TextBox
End Class
