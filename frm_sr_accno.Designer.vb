<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_sr_accno
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
        Me.amt_select = New System.Windows.Forms.TrackBar
        CType(Me.amt_select, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'amt_select
        '
        Me.amt_select.Location = New System.Drawing.Point(97, 162)
        Me.amt_select.Name = "amt_select"
        Me.amt_select.Size = New System.Drawing.Size(104, 45)
        Me.amt_select.TabIndex = 0
        '
        'frm_sr_accno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 345)
        Me.Controls.Add(Me.amt_select)
        Me.Name = "frm_sr_accno"
        Me.Text = "frm_sr_accno"
        CType(Me.amt_select, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents amt_select As System.Windows.Forms.TrackBar
End Class
