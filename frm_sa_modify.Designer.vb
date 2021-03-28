<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_sa_modify
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_sa_modify))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt_bn = New System.Windows.Forms.TextBox
        Me.txt_brn = New System.Windows.Forms.TextBox
        Me.txt_an = New System.Windows.Forms.TextBox
        Me.txt_ir = New System.Windows.Forms.TextBox
        Me.txt_doo = New System.Windows.Forms.TextBox
        Me.dtp_doo = New System.Windows.Forms.DateTimePicker
        Me.txt_blnc = New System.Windows.Forms.TextBox
        Me.cmd_search = New System.Windows.Forms.Button
        Me.cmd_update = New System.Windows.Forms.Button
        Me.cmd_reset = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name of Bank"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Branch Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Account Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Interest Rate"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Date of Opening"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(71, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Amount"
        '
        'txt_bn
        '
        Me.txt_bn.Location = New System.Drawing.Point(120, 14)
        Me.txt_bn.Name = "txt_bn"
        Me.txt_bn.Size = New System.Drawing.Size(148, 20)
        Me.txt_bn.TabIndex = 3
        '
        'txt_brn
        '
        Me.txt_brn.Location = New System.Drawing.Point(120, 44)
        Me.txt_brn.Name = "txt_brn"
        Me.txt_brn.Size = New System.Drawing.Size(148, 20)
        Me.txt_brn.TabIndex = 4
        '
        'txt_an
        '
        Me.txt_an.Location = New System.Drawing.Point(120, 75)
        Me.txt_an.Name = "txt_an"
        Me.txt_an.Size = New System.Drawing.Size(148, 20)
        Me.txt_an.TabIndex = 1
        '
        'txt_ir
        '
        Me.txt_ir.Location = New System.Drawing.Point(120, 106)
        Me.txt_ir.Name = "txt_ir"
        Me.txt_ir.Size = New System.Drawing.Size(148, 20)
        Me.txt_ir.TabIndex = 5
        '
        'txt_doo
        '
        Me.txt_doo.Location = New System.Drawing.Point(120, 137)
        Me.txt_doo.Name = "txt_doo"
        Me.txt_doo.ReadOnly = True
        Me.txt_doo.Size = New System.Drawing.Size(120, 20)
        Me.txt_doo.TabIndex = 10
        Me.txt_doo.TabStop = False
        Me.txt_doo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtp_doo
        '
        Me.dtp_doo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_doo.Location = New System.Drawing.Point(248, 137)
        Me.dtp_doo.Name = "dtp_doo"
        Me.dtp_doo.Size = New System.Drawing.Size(20, 20)
        Me.dtp_doo.TabIndex = 6
        Me.dtp_doo.Value = New Date(2012, 7, 5, 0, 0, 0, 0)
        '
        'txt_blnc
        '
        Me.txt_blnc.Location = New System.Drawing.Point(120, 168)
        Me.txt_blnc.Name = "txt_blnc"
        Me.txt_blnc.Size = New System.Drawing.Size(148, 20)
        Me.txt_blnc.TabIndex = 7
        '
        'cmd_search
        '
        Me.cmd_search.Location = New System.Drawing.Point(16, 209)
        Me.cmd_search.Name = "cmd_search"
        Me.cmd_search.Size = New System.Drawing.Size(75, 23)
        Me.cmd_search.TabIndex = 2
        Me.cmd_search.Text = "Search"
        Me.cmd_search.UseVisualStyleBackColor = True
        '
        'cmd_update
        '
        Me.cmd_update.Location = New System.Drawing.Point(104, 209)
        Me.cmd_update.Name = "cmd_update"
        Me.cmd_update.Size = New System.Drawing.Size(75, 23)
        Me.cmd_update.TabIndex = 8
        Me.cmd_update.Text = "Update"
        Me.cmd_update.UseVisualStyleBackColor = True
        '
        'cmd_reset
        '
        Me.cmd_reset.Location = New System.Drawing.Point(195, 209)
        Me.cmd_reset.Name = "cmd_reset"
        Me.cmd_reset.Size = New System.Drawing.Size(75, 23)
        Me.cmd_reset.TabIndex = 9
        Me.cmd_reset.Text = "Reset"
        Me.cmd_reset.UseVisualStyleBackColor = True
        '
        'frm_sa_modify
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(287, 250)
        Me.Controls.Add(Me.cmd_reset)
        Me.Controls.Add(Me.cmd_update)
        Me.Controls.Add(Me.cmd_search)
        Me.Controls.Add(Me.txt_blnc)
        Me.Controls.Add(Me.dtp_doo)
        Me.Controls.Add(Me.txt_doo)
        Me.Controls.Add(Me.txt_ir)
        Me.Controls.Add(Me.txt_an)
        Me.Controls.Add(Me.txt_brn)
        Me.Controls.Add(Me.txt_bn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(303, 288)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(303, 288)
        Me.Name = "frm_sa_modify"
        Me.Text = "Modify Record In Savings Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_bn As System.Windows.Forms.TextBox
    Friend WithEvents txt_brn As System.Windows.Forms.TextBox
    Friend WithEvents txt_an As System.Windows.Forms.TextBox
    Friend WithEvents txt_ir As System.Windows.Forms.TextBox
    Friend WithEvents txt_doo As System.Windows.Forms.TextBox
    Friend WithEvents dtp_doo As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_blnc As System.Windows.Forms.TextBox
    Friend WithEvents cmd_search As System.Windows.Forms.Button
    Friend WithEvents cmd_update As System.Windows.Forms.Button
    Friend WithEvents cmd_reset As System.Windows.Forms.Button
End Class
