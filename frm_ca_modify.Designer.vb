<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ca_modify
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ca_modify))
        Me.txt_brn = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmd_reset = New System.Windows.Forms.Button
        Me.cmd_update = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_blnc = New System.Windows.Forms.TextBox
        Me.txt_an = New System.Windows.Forms.TextBox
        Me.txt_bn = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmd_search = New System.Windows.Forms.Button
        Me.txt_doo = New System.Windows.Forms.TextBox
        Me.dtp_doo = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txt_brn
        '
        Me.txt_brn.Location = New System.Drawing.Point(112, 42)
        Me.txt_brn.Name = "txt_brn"
        Me.txt_brn.Size = New System.Drawing.Size(158, 20)
        Me.txt_brn.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(31, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Branch Name"
        '
        'cmd_reset
        '
        Me.cmd_reset.Location = New System.Drawing.Point(200, 167)
        Me.cmd_reset.Name = "cmd_reset"
        Me.cmd_reset.Size = New System.Drawing.Size(75, 23)
        Me.cmd_reset.TabIndex = 8
        Me.cmd_reset.Text = "Reset"
        Me.cmd_reset.UseVisualStyleBackColor = True
        '
        'cmd_update
        '
        Me.cmd_update.Location = New System.Drawing.Point(110, 167)
        Me.cmd_update.Name = "cmd_update"
        Me.cmd_update.Size = New System.Drawing.Size(75, 23)
        Me.cmd_update.TabIndex = 7
        Me.cmd_update.Text = "Update"
        Me.cmd_update.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Account Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Amount"
        '
        'txt_blnc
        '
        Me.txt_blnc.Location = New System.Drawing.Point(112, 122)
        Me.txt_blnc.Name = "txt_blnc"
        Me.txt_blnc.Size = New System.Drawing.Size(158, 20)
        Me.txt_blnc.TabIndex = 6
        '
        'txt_an
        '
        Me.txt_an.Location = New System.Drawing.Point(112, 68)
        Me.txt_an.Name = "txt_an"
        Me.txt_an.Size = New System.Drawing.Size(158, 20)
        Me.txt_an.TabIndex = 1
        '
        'txt_bn
        '
        Me.txt_bn.Location = New System.Drawing.Point(112, 15)
        Me.txt_bn.Name = "txt_bn"
        Me.txt_bn.Size = New System.Drawing.Size(158, 20)
        Me.txt_bn.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Name of Bank"
        '
        'cmd_search
        '
        Me.cmd_search.Location = New System.Drawing.Point(15, 167)
        Me.cmd_search.Name = "cmd_search"
        Me.cmd_search.Size = New System.Drawing.Size(75, 23)
        Me.cmd_search.TabIndex = 2
        Me.cmd_search.Text = "Search"
        Me.cmd_search.UseVisualStyleBackColor = True
        '
        'txt_doo
        '
        Me.txt_doo.Location = New System.Drawing.Point(112, 95)
        Me.txt_doo.Name = "txt_doo"
        Me.txt_doo.ReadOnly = True
        Me.txt_doo.Size = New System.Drawing.Size(133, 20)
        Me.txt_doo.TabIndex = 95
        Me.txt_doo.TabStop = False
        Me.txt_doo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtp_doo
        '
        Me.dtp_doo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_doo.Location = New System.Drawing.Point(252, 95)
        Me.dtp_doo.Name = "dtp_doo"
        Me.dtp_doo.Size = New System.Drawing.Size(18, 20)
        Me.dtp_doo.TabIndex = 5
        Me.dtp_doo.Value = New Date(2012, 7, 19, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 96
        Me.Label5.Text = "Date of Opening"
        '
        'frm_ca_modify
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 202)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtp_doo)
        Me.Controls.Add(Me.txt_doo)
        Me.Controls.Add(Me.cmd_search)
        Me.Controls.Add(Me.txt_brn)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmd_reset)
        Me.Controls.Add(Me.cmd_update)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_blnc)
        Me.Controls.Add(Me.txt_an)
        Me.Controls.Add(Me.txt_bn)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(305, 240)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(305, 240)
        Me.Name = "frm_ca_modify"
        Me.Text = "Modify Record In Current Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_brn As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmd_reset As System.Windows.Forms.Button
    Friend WithEvents cmd_update As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_blnc As System.Windows.Forms.TextBox
    Friend WithEvents txt_an As System.Windows.Forms.TextBox
    Friend WithEvents txt_bn As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmd_search As System.Windows.Forms.Button
    Friend WithEvents txt_doo As System.Windows.Forms.TextBox
    Friend WithEvents dtp_doo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
