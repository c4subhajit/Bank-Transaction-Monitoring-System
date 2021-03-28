<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ca_credit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ca_credit))
        Me.dtp_dot = New System.Windows.Forms.DateTimePicker
        Me.cmd_search = New System.Windows.Forms.Button
        Me.txt_dot = New System.Windows.Forms.TextBox
        Me.lbl_credit = New System.Windows.Forms.Label
        Me.txt_brn = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmd_reset = New System.Windows.Forms.Button
        Me.cmd_ok = New System.Windows.Forms.Button
        Me.lbl_dot = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_blnc = New System.Windows.Forms.TextBox
        Me.txt_an = New System.Windows.Forms.TextBox
        Me.txt_bn = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_da = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'dtp_dot
        '
        Me.dtp_dot.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_dot.Location = New System.Drawing.Point(256, 122)
        Me.dtp_dot.Name = "dtp_dot"
        Me.dtp_dot.Size = New System.Drawing.Size(18, 20)
        Me.dtp_dot.TabIndex = 3
        Me.dtp_dot.Value = New Date(2012, 6, 20, 0, 0, 0, 0)
        '
        'cmd_search
        '
        Me.cmd_search.Location = New System.Drawing.Point(18, 193)
        Me.cmd_search.Name = "cmd_search"
        Me.cmd_search.Size = New System.Drawing.Size(75, 23)
        Me.cmd_search.TabIndex = 2
        Me.cmd_search.Text = "Search"
        Me.cmd_search.UseVisualStyleBackColor = True
        '
        'txt_dot
        '
        Me.txt_dot.Location = New System.Drawing.Point(116, 122)
        Me.txt_dot.Name = "txt_dot"
        Me.txt_dot.ReadOnly = True
        Me.txt_dot.Size = New System.Drawing.Size(131, 20)
        Me.txt_dot.TabIndex = 68
        Me.txt_dot.TabStop = False
        '
        'lbl_credit
        '
        Me.lbl_credit.AutoSize = True
        Me.lbl_credit.Location = New System.Drawing.Point(17, 151)
        Me.lbl_credit.Name = "lbl_credit"
        Me.lbl_credit.Size = New System.Drawing.Size(93, 13)
        Me.lbl_credit.TabIndex = 66
        Me.lbl_credit.Text = "Deposited amount"
        '
        'txt_brn
        '
        Me.txt_brn.Location = New System.Drawing.Point(116, 44)
        Me.txt_brn.Name = "txt_brn"
        Me.txt_brn.ReadOnly = True
        Me.txt_brn.Size = New System.Drawing.Size(158, 20)
        Me.txt_brn.TabIndex = 65
        Me.txt_brn.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(38, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "Branch Name"
        '
        'cmd_reset
        '
        Me.cmd_reset.Location = New System.Drawing.Point(197, 193)
        Me.cmd_reset.Name = "cmd_reset"
        Me.cmd_reset.Size = New System.Drawing.Size(75, 23)
        Me.cmd_reset.TabIndex = 6
        Me.cmd_reset.Text = "Reset"
        Me.cmd_reset.UseVisualStyleBackColor = True
        '
        'cmd_ok
        '
        Me.cmd_ok.Location = New System.Drawing.Point(107, 193)
        Me.cmd_ok.Name = "cmd_ok"
        Me.cmd_ok.Size = New System.Drawing.Size(75, 23)
        Me.cmd_ok.TabIndex = 5
        Me.cmd_ok.Text = "Ok"
        Me.cmd_ok.UseVisualStyleBackColor = True
        '
        'lbl_dot
        '
        Me.lbl_dot.AutoSize = True
        Me.lbl_dot.Location = New System.Drawing.Point(19, 125)
        Me.lbl_dot.Name = "lbl_dot"
        Me.lbl_dot.Size = New System.Drawing.Size(91, 13)
        Me.lbl_dot.TabIndex = 61
        Me.lbl_dot.Text = "Date of trasaction"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Account Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = " Balance"
        '
        'txt_blnc
        '
        Me.txt_blnc.Location = New System.Drawing.Point(116, 96)
        Me.txt_blnc.Name = "txt_blnc"
        Me.txt_blnc.ReadOnly = True
        Me.txt_blnc.Size = New System.Drawing.Size(158, 20)
        Me.txt_blnc.TabIndex = 58
        Me.txt_blnc.TabStop = False
        '
        'txt_an
        '
        Me.txt_an.Location = New System.Drawing.Point(116, 70)
        Me.txt_an.Name = "txt_an"
        Me.txt_an.Size = New System.Drawing.Size(158, 20)
        Me.txt_an.TabIndex = 1
        '
        'txt_bn
        '
        Me.txt_bn.Location = New System.Drawing.Point(116, 18)
        Me.txt_bn.Name = "txt_bn"
        Me.txt_bn.ReadOnly = True
        Me.txt_bn.Size = New System.Drawing.Size(158, 20)
        Me.txt_bn.TabIndex = 56
        Me.txt_bn.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Name of Bank"
        '
        'txt_da
        '
        Me.txt_da.Location = New System.Drawing.Point(116, 148)
        Me.txt_da.Name = "txt_da"
        Me.txt_da.Size = New System.Drawing.Size(158, 20)
        Me.txt_da.TabIndex = 4
        '
        'frm_ca_credit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(291, 233)
        Me.Controls.Add(Me.txt_da)
        Me.Controls.Add(Me.cmd_search)
        Me.Controls.Add(Me.txt_dot)
        Me.Controls.Add(Me.lbl_credit)
        Me.Controls.Add(Me.txt_brn)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmd_reset)
        Me.Controls.Add(Me.cmd_ok)
        Me.Controls.Add(Me.lbl_dot)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_blnc)
        Me.Controls.Add(Me.txt_an)
        Me.Controls.Add(Me.txt_bn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtp_dot)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(307, 271)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(307, 271)
        Me.Name = "frm_ca_credit"
        Me.Text = "Credit Record In Current Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtp_dot As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmd_search As System.Windows.Forms.Button
    Friend WithEvents txt_dot As System.Windows.Forms.TextBox
    Friend WithEvents lbl_credit As System.Windows.Forms.Label
    Friend WithEvents txt_brn As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmd_reset As System.Windows.Forms.Button
    Friend WithEvents cmd_ok As System.Windows.Forms.Button
    Friend WithEvents lbl_dot As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_blnc As System.Windows.Forms.TextBox
    Friend WithEvents txt_an As System.Windows.Forms.TextBox
    Friend WithEvents txt_bn As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_da As System.Windows.Forms.TextBox
End Class
