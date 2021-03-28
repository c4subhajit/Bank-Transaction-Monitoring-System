<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_user = New System.Windows.Forms.TextBox
        Me.txt_pass = New System.Windows.Forms.TextBox
        Me.cmd_login = New System.Windows.Forms.Button
        Me.cmd_reset = New System.Windows.Forms.Button
        Me.chk_change = New System.Windows.Forms.CheckBox
        Me.cmd_exit = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(174, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(176, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'txt_user
        '
        Me.txt_user.Location = New System.Drawing.Point(235, 36)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(118, 20)
        Me.txt_user.TabIndex = 1
        '
        'txt_pass
        '
        Me.txt_pass.Location = New System.Drawing.Point(235, 65)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.Size = New System.Drawing.Size(118, 20)
        Me.txt_pass.TabIndex = 2
        Me.txt_pass.UseSystemPasswordChar = True
        '
        'cmd_login
        '
        Me.cmd_login.Location = New System.Drawing.Point(179, 129)
        Me.cmd_login.Name = "cmd_login"
        Me.cmd_login.Size = New System.Drawing.Size(52, 22)
        Me.cmd_login.TabIndex = 4
        Me.cmd_login.Text = "Login"
        Me.cmd_login.UseVisualStyleBackColor = True
        '
        'cmd_reset
        '
        Me.cmd_reset.Location = New System.Drawing.Point(239, 129)
        Me.cmd_reset.Name = "cmd_reset"
        Me.cmd_reset.Size = New System.Drawing.Size(52, 22)
        Me.cmd_reset.TabIndex = 5
        Me.cmd_reset.Text = "Reset"
        Me.cmd_reset.UseVisualStyleBackColor = True
        '
        'chk_change
        '
        Me.chk_change.AutoSize = True
        Me.chk_change.Location = New System.Drawing.Point(209, 97)
        Me.chk_change.Name = "chk_change"
        Me.chk_change.Size = New System.Drawing.Size(121, 17)
        Me.chk_change.TabIndex = 3
        Me.chk_change.Text = "Change login details"
        Me.chk_change.UseVisualStyleBackColor = True
        '
        'cmd_exit
        '
        Me.cmd_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmd_exit.Location = New System.Drawing.Point(299, 129)
        Me.cmd_exit.Name = "cmd_exit"
        Me.cmd_exit.Size = New System.Drawing.Size(52, 22)
        Me.cmd_exit.TabIndex = 6
        Me.cmd_exit.Text = "Exit"
        Me.cmd_exit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TFDPC_v2._0.My.Resources.Resources.Login
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(165, 200)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmd_exit
        Me.ClientSize = New System.Drawing.Size(376, 196)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmd_exit)
        Me.Controls.Add(Me.chk_change)
        Me.Controls.Add(Me.cmd_reset)
        Me.Controls.Add(Me.cmd_login)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.txt_user)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(384, 230)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(384, 230)
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login to Continue"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_user As System.Windows.Forms.TextBox
    Friend WithEvents txt_pass As System.Windows.Forms.TextBox
    Friend WithEvents cmd_login As System.Windows.Forms.Button
    Friend WithEvents cmd_reset As System.Windows.Forms.Button
    Friend WithEvents chk_change As System.Windows.Forms.CheckBox
    Friend WithEvents cmd_exit As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
