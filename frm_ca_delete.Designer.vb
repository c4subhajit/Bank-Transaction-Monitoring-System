<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ca_delete
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ca_delete))
        Me.txt_brn = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmd_reset = New System.Windows.Forms.Button
        Me.cmd_delete = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_blnc = New System.Windows.Forms.TextBox
        Me.txt_an = New System.Windows.Forms.TextBox
        Me.txt_bn = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_doo = New System.Windows.Forms.TextBox
        Me.cmd_search = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txt_brn
        '
        Me.txt_brn.Location = New System.Drawing.Point(114, 43)
        Me.txt_brn.Name = "txt_brn"
        Me.txt_brn.ReadOnly = True
        Me.txt_brn.Size = New System.Drawing.Size(158, 20)
        Me.txt_brn.TabIndex = 47
        Me.txt_brn.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Branch Name"
        '
        'cmd_reset
        '
        Me.cmd_reset.Location = New System.Drawing.Point(191, 163)
        Me.cmd_reset.Name = "cmd_reset"
        Me.cmd_reset.Size = New System.Drawing.Size(75, 23)
        Me.cmd_reset.TabIndex = 4
        Me.cmd_reset.Text = "Reset"
        Me.cmd_reset.UseVisualStyleBackColor = True
        '
        'cmd_delete
        '
        Me.cmd_delete.Location = New System.Drawing.Point(108, 163)
        Me.cmd_delete.Name = "cmd_delete"
        Me.cmd_delete.Size = New System.Drawing.Size(75, 23)
        Me.cmd_delete.TabIndex = 3
        Me.cmd_delete.Text = "Delete"
        Me.cmd_delete.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Date of opening"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Account Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Balance"
        '
        'txt_blnc
        '
        Me.txt_blnc.Location = New System.Drawing.Point(114, 127)
        Me.txt_blnc.Name = "txt_blnc"
        Me.txt_blnc.ReadOnly = True
        Me.txt_blnc.Size = New System.Drawing.Size(158, 20)
        Me.txt_blnc.TabIndex = 40
        Me.txt_blnc.TabStop = False
        '
        'txt_an
        '
        Me.txt_an.Location = New System.Drawing.Point(114, 72)
        Me.txt_an.Name = "txt_an"
        Me.txt_an.Size = New System.Drawing.Size(158, 20)
        Me.txt_an.TabIndex = 1
        '
        'txt_bn
        '
        Me.txt_bn.Location = New System.Drawing.Point(114, 15)
        Me.txt_bn.Name = "txt_bn"
        Me.txt_bn.ReadOnly = True
        Me.txt_bn.Size = New System.Drawing.Size(158, 20)
        Me.txt_bn.TabIndex = 38
        Me.txt_bn.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Name of Bank"
        '
        'txt_doo
        '
        Me.txt_doo.Location = New System.Drawing.Point(114, 101)
        Me.txt_doo.Name = "txt_doo"
        Me.txt_doo.ReadOnly = True
        Me.txt_doo.Size = New System.Drawing.Size(158, 20)
        Me.txt_doo.TabIndex = 51
        Me.txt_doo.TabStop = False
        '
        'cmd_search
        '
        Me.cmd_search.Location = New System.Drawing.Point(22, 163)
        Me.cmd_search.Name = "cmd_search"
        Me.cmd_search.Size = New System.Drawing.Size(75, 23)
        Me.cmd_search.TabIndex = 2
        Me.cmd_search.Text = "Search"
        Me.cmd_search.UseVisualStyleBackColor = True
        '
        'frm_ca_delete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 202)
        Me.Controls.Add(Me.cmd_search)
        Me.Controls.Add(Me.txt_doo)
        Me.Controls.Add(Me.txt_brn)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmd_reset)
        Me.Controls.Add(Me.cmd_delete)
        Me.Controls.Add(Me.Label7)
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
        Me.Name = "frm_ca_delete"
        Me.Text = "Delete Record In Current Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_brn As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmd_reset As System.Windows.Forms.Button
    Friend WithEvents cmd_delete As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_blnc As System.Windows.Forms.TextBox
    Friend WithEvents txt_an As System.Windows.Forms.TextBox
    Friend WithEvents txt_bn As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_doo As System.Windows.Forms.TextBox
    Friend WithEvents cmd_search As System.Windows.Forms.Button
End Class
