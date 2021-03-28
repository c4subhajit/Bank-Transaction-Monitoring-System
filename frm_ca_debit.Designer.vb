<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ca_debit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ca_debit))
        Me.cmd_search = New System.Windows.Forms.Button
        Me.dtp_dot = New System.Windows.Forms.DateTimePicker
        Me.txt_dot = New System.Windows.Forms.TextBox
        Me.txt_wa = New System.Windows.Forms.TextBox
        Me.lbl_debit = New System.Windows.Forms.Label
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
        Me.SuspendLayout()
        '
        'cmd_search
        '
        Me.cmd_search.Location = New System.Drawing.Point(22, 196)
        Me.cmd_search.Name = "cmd_search"
        Me.cmd_search.Size = New System.Drawing.Size(70, 23)
        Me.cmd_search.TabIndex = 2
        Me.cmd_search.Text = "Search"
        Me.cmd_search.UseVisualStyleBackColor = True
        '
        'dtp_dot
        '
        Me.dtp_dot.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_dot.Location = New System.Drawing.Point(259, 128)
        Me.dtp_dot.Name = "dtp_dot"
        Me.dtp_dot.Size = New System.Drawing.Size(18, 20)
        Me.dtp_dot.TabIndex = 3
        Me.dtp_dot.Value = New Date(2012, 6, 20, 0, 0, 0, 0)
        '
        'txt_dot
        '
        Me.txt_dot.Location = New System.Drawing.Point(119, 128)
        Me.txt_dot.Name = "txt_dot"
        Me.txt_dot.ReadOnly = True
        Me.txt_dot.Size = New System.Drawing.Size(135, 20)
        Me.txt_dot.TabIndex = 81
        Me.txt_dot.TabStop = False
        '
        'txt_wa
        '
        Me.txt_wa.Location = New System.Drawing.Point(119, 158)
        Me.txt_wa.Name = "txt_wa"
        Me.txt_wa.Size = New System.Drawing.Size(158, 20)
        Me.txt_wa.TabIndex = 4
        '
        'lbl_debit
        '
        Me.lbl_debit.AutoSize = True
        Me.lbl_debit.Location = New System.Drawing.Point(19, 161)
        Me.lbl_debit.Name = "lbl_debit"
        Me.lbl_debit.Size = New System.Drawing.Size(93, 13)
        Me.lbl_debit.TabIndex = 79
        Me.lbl_debit.Text = "Withdrawl Amount"
        '
        'txt_brn
        '
        Me.txt_brn.Location = New System.Drawing.Point(119, 45)
        Me.txt_brn.Name = "txt_brn"
        Me.txt_brn.ReadOnly = True
        Me.txt_brn.Size = New System.Drawing.Size(158, 20)
        Me.txt_brn.TabIndex = 78
        Me.txt_brn.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(40, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = "Branch Name"
        '
        'cmd_reset
        '
        Me.cmd_reset.Location = New System.Drawing.Point(196, 196)
        Me.cmd_reset.Name = "cmd_reset"
        Me.cmd_reset.Size = New System.Drawing.Size(74, 23)
        Me.cmd_reset.TabIndex = 6
        Me.cmd_reset.Text = "Reset"
        Me.cmd_reset.UseVisualStyleBackColor = True
        '
        'cmd_ok
        '
        Me.cmd_ok.Location = New System.Drawing.Point(110, 196)
        Me.cmd_ok.Name = "cmd_ok"
        Me.cmd_ok.Size = New System.Drawing.Size(69, 23)
        Me.cmd_ok.TabIndex = 5
        Me.cmd_ok.Text = "Ok"
        Me.cmd_ok.UseVisualStyleBackColor = True
        '
        'lbl_dot
        '
        Me.lbl_dot.AutoSize = True
        Me.lbl_dot.Location = New System.Drawing.Point(15, 133)
        Me.lbl_dot.Name = "lbl_dot"
        Me.lbl_dot.Size = New System.Drawing.Size(97, 13)
        Me.lbl_dot.TabIndex = 74
        Me.lbl_dot.Text = "Date Of Trasaction"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Account Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(66, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Balance"
        '
        'txt_blnc
        '
        Me.txt_blnc.Location = New System.Drawing.Point(119, 102)
        Me.txt_blnc.Name = "txt_blnc"
        Me.txt_blnc.ReadOnly = True
        Me.txt_blnc.Size = New System.Drawing.Size(158, 20)
        Me.txt_blnc.TabIndex = 71
        Me.txt_blnc.TabStop = False
        '
        'txt_an
        '
        Me.txt_an.Location = New System.Drawing.Point(119, 73)
        Me.txt_an.Name = "txt_an"
        Me.txt_an.Size = New System.Drawing.Size(158, 20)
        Me.txt_an.TabIndex = 1
        '
        'txt_bn
        '
        Me.txt_bn.Location = New System.Drawing.Point(119, 17)
        Me.txt_bn.Name = "txt_bn"
        Me.txt_bn.ReadOnly = True
        Me.txt_bn.Size = New System.Drawing.Size(158, 20)
        Me.txt_bn.TabIndex = 69
        Me.txt_bn.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Name of Bank"
        '
        'frm_ca_debit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 232)
        Me.Controls.Add(Me.cmd_search)
        Me.Controls.Add(Me.dtp_dot)
        Me.Controls.Add(Me.txt_dot)
        Me.Controls.Add(Me.txt_wa)
        Me.Controls.Add(Me.lbl_debit)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(310, 270)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(310, 270)
        Me.Name = "frm_ca_debit"
        Me.Text = "Debit Record In Current Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_search As System.Windows.Forms.Button
    Friend WithEvents dtp_dot As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_dot As System.Windows.Forms.TextBox
    Friend WithEvents txt_wa As System.Windows.Forms.TextBox
    Friend WithEvents lbl_debit As System.Windows.Forms.Label
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
End Class
