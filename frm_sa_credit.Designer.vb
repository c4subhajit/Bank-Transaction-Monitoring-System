<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_sa_credit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_sa_credit))
        Me.lbl_credit = New System.Windows.Forms.Label
        Me.dtp_dot = New System.Windows.Forms.DateTimePicker
        Me.txt_blnc = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmd_search = New System.Windows.Forms.Button
        Me.cmd_reset = New System.Windows.Forms.Button
        Me.cmd_ok = New System.Windows.Forms.Button
        Me.txt_da = New System.Windows.Forms.TextBox
        Me.txt_dot = New System.Windows.Forms.TextBox
        Me.txt_ir = New System.Windows.Forms.TextBox
        Me.txt_an = New System.Windows.Forms.TextBox
        Me.txt_brn = New System.Windows.Forms.TextBox
        Me.txt_bn = New System.Windows.Forms.TextBox
        Me.lbl_dot = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lbl_credit
        '
        Me.lbl_credit.AutoSize = True
        Me.lbl_credit.Location = New System.Drawing.Point(36, 181)
        Me.lbl_credit.Name = "lbl_credit"
        Me.lbl_credit.Size = New System.Drawing.Size(82, 13)
        Me.lbl_credit.TabIndex = 40
        Me.lbl_credit.Text = "Deposit Amount"
        '
        'dtp_dot
        '
        Me.dtp_dot.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_dot.Location = New System.Drawing.Point(265, 152)
        Me.dtp_dot.Name = "dtp_dot"
        Me.dtp_dot.Size = New System.Drawing.Size(18, 20)
        Me.dtp_dot.TabIndex = 3
        Me.dtp_dot.Value = New Date(2012, 7, 6, 0, 0, 0, 0)
        '
        'txt_blnc
        '
        Me.txt_blnc.Location = New System.Drawing.Point(124, 123)
        Me.txt_blnc.Name = "txt_blnc"
        Me.txt_blnc.ReadOnly = True
        Me.txt_blnc.Size = New System.Drawing.Size(159, 20)
        Me.txt_blnc.TabIndex = 39
        Me.txt_blnc.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(72, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Balance"
        '
        'cmd_search
        '
        Me.cmd_search.Location = New System.Drawing.Point(24, 213)
        Me.cmd_search.Name = "cmd_search"
        Me.cmd_search.Size = New System.Drawing.Size(62, 23)
        Me.cmd_search.TabIndex = 2
        Me.cmd_search.Text = "Search"
        Me.cmd_search.UseVisualStyleBackColor = True
        '
        'cmd_reset
        '
        Me.cmd_reset.Location = New System.Drawing.Point(207, 213)
        Me.cmd_reset.Name = "cmd_reset"
        Me.cmd_reset.Size = New System.Drawing.Size(62, 23)
        Me.cmd_reset.TabIndex = 6
        Me.cmd_reset.Text = "Reset"
        Me.cmd_reset.UseVisualStyleBackColor = True
        '
        'cmd_ok
        '
        Me.cmd_ok.Location = New System.Drawing.Point(116, 213)
        Me.cmd_ok.Name = "cmd_ok"
        Me.cmd_ok.Size = New System.Drawing.Size(62, 23)
        Me.cmd_ok.TabIndex = 5
        Me.cmd_ok.Text = "Ok"
        Me.cmd_ok.UseVisualStyleBackColor = True
        '
        'txt_da
        '
        Me.txt_da.Location = New System.Drawing.Point(124, 178)
        Me.txt_da.Name = "txt_da"
        Me.txt_da.Size = New System.Drawing.Size(159, 20)
        Me.txt_da.TabIndex = 4
        '
        'txt_dot
        '
        Me.txt_dot.Location = New System.Drawing.Point(124, 152)
        Me.txt_dot.Name = "txt_dot"
        Me.txt_dot.ReadOnly = True
        Me.txt_dot.Size = New System.Drawing.Size(135, 20)
        Me.txt_dot.TabIndex = 37
        Me.txt_dot.TabStop = False
        '
        'txt_ir
        '
        Me.txt_ir.Location = New System.Drawing.Point(124, 97)
        Me.txt_ir.Name = "txt_ir"
        Me.txt_ir.ReadOnly = True
        Me.txt_ir.Size = New System.Drawing.Size(159, 20)
        Me.txt_ir.TabIndex = 36
        Me.txt_ir.TabStop = False
        '
        'txt_an
        '
        Me.txt_an.Location = New System.Drawing.Point(124, 70)
        Me.txt_an.Name = "txt_an"
        Me.txt_an.Size = New System.Drawing.Size(159, 20)
        Me.txt_an.TabIndex = 1
        '
        'txt_brn
        '
        Me.txt_brn.Location = New System.Drawing.Point(124, 41)
        Me.txt_brn.Name = "txt_brn"
        Me.txt_brn.ReadOnly = True
        Me.txt_brn.Size = New System.Drawing.Size(159, 20)
        Me.txt_brn.TabIndex = 35
        Me.txt_brn.TabStop = False
        '
        'txt_bn
        '
        Me.txt_bn.Location = New System.Drawing.Point(124, 15)
        Me.txt_bn.Name = "txt_bn"
        Me.txt_bn.ReadOnly = True
        Me.txt_bn.Size = New System.Drawing.Size(159, 20)
        Me.txt_bn.TabIndex = 34
        Me.txt_bn.TabStop = False
        '
        'lbl_dot
        '
        Me.lbl_dot.AutoSize = True
        Me.lbl_dot.Location = New System.Drawing.Point(15, 155)
        Me.lbl_dot.Name = "lbl_dot"
        Me.lbl_dot.Size = New System.Drawing.Size(103, 13)
        Me.lbl_dot.TabIndex = 31
        Me.lbl_dot.Text = "Date Of Transaction"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Interest Rate"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Account No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Branch Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Name of Bank"
        '
        'frm_sa_credit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 251)
        Me.Controls.Add(Me.lbl_credit)
        Me.Controls.Add(Me.dtp_dot)
        Me.Controls.Add(Me.txt_blnc)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmd_search)
        Me.Controls.Add(Me.cmd_reset)
        Me.Controls.Add(Me.cmd_ok)
        Me.Controls.Add(Me.txt_da)
        Me.Controls.Add(Me.txt_dot)
        Me.Controls.Add(Me.txt_ir)
        Me.Controls.Add(Me.txt_an)
        Me.Controls.Add(Me.txt_brn)
        Me.Controls.Add(Me.txt_bn)
        Me.Controls.Add(Me.lbl_dot)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(315, 289)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(315, 289)
        Me.Name = "frm_sa_credit"
        Me.Text = "Credit Record In Savings Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_credit As System.Windows.Forms.Label
    Friend WithEvents dtp_dot As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_blnc As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmd_search As System.Windows.Forms.Button
    Friend WithEvents cmd_reset As System.Windows.Forms.Button
    Friend WithEvents cmd_ok As System.Windows.Forms.Button
    Friend WithEvents txt_da As System.Windows.Forms.TextBox
    Friend WithEvents txt_dot As System.Windows.Forms.TextBox
    Friend WithEvents txt_ir As System.Windows.Forms.TextBox
    Friend WithEvents txt_an As System.Windows.Forms.TextBox
    Friend WithEvents txt_brn As System.Windows.Forms.TextBox
    Friend WithEvents txt_bn As System.Windows.Forms.TextBox
    Friend WithEvents lbl_dot As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
