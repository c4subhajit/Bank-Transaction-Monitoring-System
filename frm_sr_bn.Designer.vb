<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_sr_bn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_sr_bn))
        Me.cmd_reset = New System.Windows.Forms.Button
        Me.dgv_ca = New System.Windows.Forms.DataGridView
        Me.cmd_search = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmb_bn = New System.Windows.Forms.ComboBox
        CType(Me.dgv_ca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_reset
        '
        Me.cmd_reset.Location = New System.Drawing.Point(327, 47)
        Me.cmd_reset.Name = "cmd_reset"
        Me.cmd_reset.Size = New System.Drawing.Size(75, 23)
        Me.cmd_reset.TabIndex = 3
        Me.cmd_reset.Text = "Reset"
        Me.cmd_reset.UseVisualStyleBackColor = True
        '
        'dgv_ca
        '
        Me.dgv_ca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ca.Location = New System.Drawing.Point(12, 83)
        Me.dgv_ca.Name = "dgv_ca"
        Me.dgv_ca.Size = New System.Drawing.Size(600, 222)
        Me.dgv_ca.TabIndex = 8
        Me.dgv_ca.TabStop = False
        '
        'cmd_search
        '
        Me.cmd_search.Location = New System.Drawing.Point(218, 47)
        Me.cmd_search.Name = "cmd_search"
        Me.cmd_search.Size = New System.Drawing.Size(75, 23)
        Me.cmd_search.TabIndex = 2
        Me.cmd_search.Text = "Search"
        Me.cmd_search.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(182, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Name Of Bank"
        '
        'cmb_bn
        '
        Me.cmb_bn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_bn.FormattingEnabled = True
        Me.cmb_bn.Location = New System.Drawing.Point(265, 12)
        Me.cmb_bn.Name = "cmb_bn"
        Me.cmb_bn.Size = New System.Drawing.Size(164, 21)
        Me.cmb_bn.TabIndex = 1
        '
        'frm_sr_bn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 317)
        Me.Controls.Add(Me.cmb_bn)
        Me.Controls.Add(Me.cmd_reset)
        Me.Controls.Add(Me.dgv_ca)
        Me.Controls.Add(Me.cmd_search)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(640, 355)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(640, 355)
        Me.Name = "frm_sr_bn"
        Me.Text = "Search By Bank Name"
        CType(Me.dgv_ca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_reset As System.Windows.Forms.Button
    Friend WithEvents dgv_ca As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_search As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_bn As System.Windows.Forms.ComboBox
End Class
