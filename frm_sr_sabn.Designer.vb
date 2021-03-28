<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_sr_sabn
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
        Me.txt_bn = New System.Windows.Forms.TextBox
        Me.cmd_sr = New System.Windows.Forms.Button
        Me.cmd_reset = New System.Windows.Forms.Button
        Me.dgv_sa = New System.Windows.Forms.DataGridView
        CType(Me.dgv_sa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name of Bank"
        '
        'txt_bn
        '
        Me.txt_bn.Location = New System.Drawing.Point(143, 12)
        Me.txt_bn.Name = "txt_bn"
        Me.txt_bn.Size = New System.Drawing.Size(159, 20)
        Me.txt_bn.TabIndex = 1
        '
        'cmd_sr
        '
        Me.cmd_sr.Location = New System.Drawing.Point(95, 70)
        Me.cmd_sr.Name = "cmd_sr"
        Me.cmd_sr.Size = New System.Drawing.Size(75, 23)
        Me.cmd_sr.TabIndex = 2
        Me.cmd_sr.Text = "Search"
        Me.cmd_sr.UseVisualStyleBackColor = True
        '
        'cmd_reset
        '
        Me.cmd_reset.Location = New System.Drawing.Point(185, 70)
        Me.cmd_reset.Name = "cmd_reset"
        Me.cmd_reset.Size = New System.Drawing.Size(75, 23)
        Me.cmd_reset.TabIndex = 3
        Me.cmd_reset.Text = "Reset"
        Me.cmd_reset.UseVisualStyleBackColor = True
        '
        'dgv_sa
        '
        Me.dgv_sa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_sa.Location = New System.Drawing.Point(12, 109)
        Me.dgv_sa.Name = "dgv_sa"
        Me.dgv_sa.Size = New System.Drawing.Size(356, 150)
        Me.dgv_sa.TabIndex = 4
        '
        'frm_sr_sabn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 273)
        Me.Controls.Add(Me.dgv_sa)
        Me.Controls.Add(Me.cmd_reset)
        Me.Controls.Add(Me.cmd_sr)
        Me.Controls.Add(Me.txt_bn)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_sr_sabn"
        Me.Text = "Search By Bank Name"
        CType(Me.dgv_sa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_bn As System.Windows.Forms.TextBox
    Friend WithEvents cmd_sr As System.Windows.Forms.Button
    Friend WithEvents cmd_reset As System.Windows.Forms.Button
    Friend WithEvents dgv_sa As System.Windows.Forms.DataGridView
End Class
