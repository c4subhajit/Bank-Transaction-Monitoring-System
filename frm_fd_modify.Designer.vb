<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_fd_modify
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_fd_modify))
        Me.txt_md = New System.Windows.Forms.TextBox
        Me.txt_dd = New System.Windows.Forms.TextBox
        Me.dtp_md = New System.Windows.Forms.DateTimePicker
        Me.dtp_dd = New System.Windows.Forms.DateTimePicker
        Me.txt_brn = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt_mv = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_ir = New System.Windows.Forms.TextBox
        Me.txt_da = New System.Windows.Forms.TextBox
        Me.txt_an = New System.Windows.Forms.TextBox
        Me.txt_bn = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmd_search = New System.Windows.Forms.Button
        Me.cmd_update = New System.Windows.Forms.Button
        Me.cmd_reset = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txt_md
        '
        Me.txt_md.Location = New System.Drawing.Point(174, 184)
        Me.txt_md.Name = "txt_md"
        Me.txt_md.ReadOnly = True
        Me.txt_md.Size = New System.Drawing.Size(134, 20)
        Me.txt_md.TabIndex = 41
        Me.txt_md.TabStop = False
        Me.txt_md.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_dd
        '
        Me.txt_dd.Location = New System.Drawing.Point(174, 157)
        Me.txt_dd.Name = "txt_dd"
        Me.txt_dd.ReadOnly = True
        Me.txt_dd.Size = New System.Drawing.Size(134, 20)
        Me.txt_dd.TabIndex = 40
        Me.txt_dd.TabStop = False
        Me.txt_dd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtp_md
        '
        Me.dtp_md.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_md.Location = New System.Drawing.Point(314, 184)
        Me.dtp_md.Name = "dtp_md"
        Me.dtp_md.Size = New System.Drawing.Size(18, 20)
        Me.dtp_md.TabIndex = 8
        Me.dtp_md.TabStop = False
        Me.dtp_md.Value = New Date(2012, 6, 20, 0, 0, 0, 0)
        '
        'dtp_dd
        '
        Me.dtp_dd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_dd.Location = New System.Drawing.Point(314, 158)
        Me.dtp_dd.Name = "dtp_dd"
        Me.dtp_dd.Size = New System.Drawing.Size(18, 20)
        Me.dtp_dd.TabIndex = 7
        Me.dtp_dd.TabStop = False
        Me.dtp_dd.Value = New Date(2012, 6, 20, 0, 0, 0, 0)
        '
        'txt_brn
        '
        Me.txt_brn.Location = New System.Drawing.Point(174, 46)
        Me.txt_brn.Name = "txt_brn"
        Me.txt_brn.Size = New System.Drawing.Size(158, 20)
        Me.txt_brn.TabIndex = 4
        Me.txt_brn.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(88, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Branch Name"
        '
        'txt_mv
        '
        Me.txt_mv.Location = New System.Drawing.Point(174, 211)
        Me.txt_mv.Name = "txt_mv"
        Me.txt_mv.Size = New System.Drawing.Size(158, 20)
        Me.txt_mv.TabIndex = 9
        Me.txt_mv.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(87, 161)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Deposite Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(92, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Maturity Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Maturity Value before TDS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(76, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Account Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(69, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Deposited Amount"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(95, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Interest Rate"
        '
        'txt_ir
        '
        Me.txt_ir.Location = New System.Drawing.Point(174, 130)
        Me.txt_ir.Name = "txt_ir"
        Me.txt_ir.Size = New System.Drawing.Size(158, 20)
        Me.txt_ir.TabIndex = 6
        Me.txt_ir.TabStop = False
        '
        'txt_da
        '
        Me.txt_da.Location = New System.Drawing.Point(174, 102)
        Me.txt_da.Name = "txt_da"
        Me.txt_da.Size = New System.Drawing.Size(158, 20)
        Me.txt_da.TabIndex = 5
        Me.txt_da.TabStop = False
        '
        'txt_an
        '
        Me.txt_an.Location = New System.Drawing.Point(174, 74)
        Me.txt_an.Name = "txt_an"
        Me.txt_an.Size = New System.Drawing.Size(158, 20)
        Me.txt_an.TabIndex = 1
        '
        'txt_bn
        '
        Me.txt_bn.Location = New System.Drawing.Point(174, 17)
        Me.txt_bn.Name = "txt_bn"
        Me.txt_bn.Size = New System.Drawing.Size(158, 20)
        Me.txt_bn.TabIndex = 3
        Me.txt_bn.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(88, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Name of Bank"
        '
        'cmd_search
        '
        Me.cmd_search.Location = New System.Drawing.Point(34, 257)
        Me.cmd_search.Name = "cmd_search"
        Me.cmd_search.Size = New System.Drawing.Size(75, 23)
        Me.cmd_search.TabIndex = 2
        Me.cmd_search.Text = "Search"
        Me.cmd_search.UseVisualStyleBackColor = True
        '
        'cmd_update
        '
        Me.cmd_update.Location = New System.Drawing.Point(146, 257)
        Me.cmd_update.Name = "cmd_update"
        Me.cmd_update.Size = New System.Drawing.Size(75, 23)
        Me.cmd_update.TabIndex = 10
        Me.cmd_update.Text = "Update"
        Me.cmd_update.UseVisualStyleBackColor = True
        '
        'cmd_reset
        '
        Me.cmd_reset.Location = New System.Drawing.Point(257, 257)
        Me.cmd_reset.Name = "cmd_reset"
        Me.cmd_reset.Size = New System.Drawing.Size(75, 23)
        Me.cmd_reset.TabIndex = 11
        Me.cmd_reset.Text = "Reset"
        Me.cmd_reset.UseVisualStyleBackColor = True
        '
        'frm_fd_modify
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 309)
        Me.Controls.Add(Me.cmd_reset)
        Me.Controls.Add(Me.cmd_update)
        Me.Controls.Add(Me.cmd_search)
        Me.Controls.Add(Me.txt_md)
        Me.Controls.Add(Me.txt_dd)
        Me.Controls.Add(Me.dtp_md)
        Me.Controls.Add(Me.dtp_dd)
        Me.Controls.Add(Me.txt_brn)
        Me.Controls.Add(Me.Label8)
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
        Me.MaximumSize = New System.Drawing.Size(388, 347)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(388, 347)
        Me.Name = "frm_fd_modify"
        Me.Text = "Modify Fixed Diposit Record"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_md As System.Windows.Forms.TextBox
    Friend WithEvents txt_dd As System.Windows.Forms.TextBox
    Friend WithEvents dtp_md As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_dd As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_brn As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_mv As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_ir As System.Windows.Forms.TextBox
    Friend WithEvents txt_da As System.Windows.Forms.TextBox
    Friend WithEvents txt_an As System.Windows.Forms.TextBox
    Friend WithEvents txt_bn As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmd_search As System.Windows.Forms.Button
    Friend WithEvents cmd_update As System.Windows.Forms.Button
    Friend WithEvents cmd_reset As System.Windows.Forms.Button
End Class
