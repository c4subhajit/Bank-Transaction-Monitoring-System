<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_alert
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_alert))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.dgv_7 = New System.Windows.Forms.DataGridView
        Me.dgv_30 = New System.Windows.Forms.DataGridView
        Me.dgv_90 = New System.Windows.Forms.DataGridView
        CType(Me.dgv_7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_90, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Red
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(169, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Maturing within 0 to 7 days"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(169, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Maturing within 8 to 30 days"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Yellow
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(169, 300)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(194, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Maturing within 31 to 90 days"
        '
        'dgv_7
        '
        Me.dgv_7.AllowUserToAddRows = False
        Me.dgv_7.AllowUserToDeleteRows = False
        Me.dgv_7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_7.Location = New System.Drawing.Point(12, 35)
        Me.dgv_7.Name = "dgv_7"
        Me.dgv_7.ReadOnly = True
        Me.dgv_7.Size = New System.Drawing.Size(519, 116)
        Me.dgv_7.TabIndex = 3
        '
        'dgv_30
        '
        Me.dgv_30.AllowUserToAddRows = False
        Me.dgv_30.AllowUserToDeleteRows = False
        Me.dgv_30.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_30.Location = New System.Drawing.Point(12, 178)
        Me.dgv_30.Name = "dgv_30"
        Me.dgv_30.ReadOnly = True
        Me.dgv_30.Size = New System.Drawing.Size(519, 116)
        Me.dgv_30.TabIndex = 4
        '
        'dgv_90
        '
        Me.dgv_90.AllowUserToAddRows = False
        Me.dgv_90.AllowUserToDeleteRows = False
        Me.dgv_90.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_90.Location = New System.Drawing.Point(12, 322)
        Me.dgv_90.Name = "dgv_90"
        Me.dgv_90.ReadOnly = True
        Me.dgv_90.Size = New System.Drawing.Size(519, 116)
        Me.dgv_90.TabIndex = 5
        '
        'frm_alert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 451)
        Me.Controls.Add(Me.dgv_90)
        Me.Controls.Add(Me.dgv_30)
        Me.Controls.Add(Me.dgv_7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(559, 489)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(559, 489)
        Me.Name = "frm_alert"
        Me.Text = "Alert"
        CType(Me.dgv_7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_90, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgv_7 As System.Windows.Forms.DataGridView
    Friend WithEvents dgv_30 As System.Windows.Forms.DataGridView
    Friend WithEvents dgv_90 As System.Windows.Forms.DataGridView
End Class
