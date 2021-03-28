<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_home
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
        Me.components = New System.ComponentModel.Container
        Me.MenuStrip_TFDPC = New System.Windows.Forms.MenuStrip
        Me.FixedDeposit = New System.Windows.Forms.ToolStripMenuItem
        Me.NewRecordFD = New System.Windows.Forms.ToolStripMenuItem
        Me.ModifyRecordFD = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteRecordFD = New System.Windows.Forms.ToolStripMenuItem
        Me.CurrentAccount = New System.Windows.Forms.ToolStripMenuItem
        Me.NewRecordCA = New System.Windows.Forms.ToolStripMenuItem
        Me.ModifyRecordCA = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteRecordCA = New System.Windows.Forms.ToolStripMenuItem
        Me.DebitCA = New System.Windows.Forms.ToolStripMenuItem
        Me.CreditCA = New System.Windows.Forms.ToolStripMenuItem
        Me.SavingsAccount = New System.Windows.Forms.ToolStripMenuItem
        Me.NewRecordSA = New System.Windows.Forms.ToolStripMenuItem
        Me.ModifyRecordSA = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteRecordSA = New System.Windows.Forms.ToolStripMenuItem
        Me.DebitSA = New System.Windows.Forms.ToolStripMenuItem
        Me.CreditSA = New System.Windows.Forms.ToolStripMenuItem
        Me.Search = New System.Windows.Forms.ToolStripMenuItem
        Me.FixedDepositToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ByAccountNumberFD = New System.Windows.Forms.ToolStripMenuItem
        Me.ByBankNameFD = New System.Windows.Forms.ToolStripMenuItem
        Me.ByDateOfOpeningFD = New System.Windows.Forms.ToolStripMenuItem
        Me.ByDateOfMaturityFD = New System.Windows.Forms.ToolStripMenuItem
        Me.CurrentAccountToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ByAccountNumberCA = New System.Windows.Forms.ToolStripMenuItem
        Me.ByBankNameCA = New System.Windows.Forms.ToolStripMenuItem
        Me.ByDateOfTransactionCA = New System.Windows.Forms.ToolStripMenuItem
        Me.SavingsAccountToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ByAccountNumberSA = New System.Windows.Forms.ToolStripMenuItem
        Me.ByBankNameSA = New System.Windows.Forms.ToolStripMenuItem
        Me.ByDateOfTransactionSA = New System.Windows.Forms.ToolStripMenuItem
        Me.Alert = New System.Windows.Forms.ToolStripMenuItem
        Me.Transaction = New System.Windows.Forms.ToolStripMenuItem
        Me.CurrentStatus = New System.Windows.Forms.ToolStripMenuItem
        Me.SystemTools = New System.Windows.Forms.ToolStripMenuItem
        Me.Utilities = New System.Windows.Forms.ToolStripMenuItem
        Me.Calculator = New System.Windows.Forms.ToolStripMenuItem
        Me.Notepad = New System.Windows.Forms.ToolStripMenuItem
        Me.Logout = New System.Windows.Forms.ToolStripMenuItem
        Me.Exit_soft = New System.Windows.Forms.ToolStripMenuItem
        Me.About = New System.Windows.Forms.ToolStripMenuItem
        Me.BackDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.lbl_90days = New System.Windows.Forms.Label
        Me.lbl_30days = New System.Windows.Forms.Label
        Me.lbl_7days = New System.Windows.Forms.Label
        Me.FBD_dbBackup = New System.Windows.Forms.FolderBrowserDialog
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel8 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel9 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel10 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.StatusStrip_TFDPC = New System.Windows.Forms.StatusStrip
        Me.OFD_db = New System.Windows.Forms.OpenFileDialog
        Me.lbl_clock = New System.Windows.Forms.Label
        Me.Timer_Clock = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip_TFDPC.SuspendLayout()
        Me.StatusStrip_TFDPC.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip_TFDPC
        '
        Me.MenuStrip_TFDPC.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FixedDeposit, Me.CurrentAccount, Me.SavingsAccount, Me.Search, Me.Alert, Me.Transaction, Me.CurrentStatus, Me.SystemTools})
        Me.MenuStrip_TFDPC.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip_TFDPC.Name = "MenuStrip_TFDPC"
        Me.MenuStrip_TFDPC.Size = New System.Drawing.Size(792, 24)
        Me.MenuStrip_TFDPC.TabIndex = 0
        Me.MenuStrip_TFDPC.Text = "MenuStrip1"
        '
        'FixedDeposit
        '
        Me.FixedDeposit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewRecordFD, Me.ModifyRecordFD, Me.DeleteRecordFD})
        Me.FixedDeposit.Name = "FixedDeposit"
        Me.FixedDeposit.Size = New System.Drawing.Size(84, 20)
        Me.FixedDeposit.Text = "&Fixed Deposit"
        '
        'NewRecordFD
        '
        Me.NewRecordFD.Name = "NewRecordFD"
        Me.NewRecordFD.Size = New System.Drawing.Size(154, 22)
        Me.NewRecordFD.Text = "&New Record"
        '
        'ModifyRecordFD
        '
        Me.ModifyRecordFD.Name = "ModifyRecordFD"
        Me.ModifyRecordFD.Size = New System.Drawing.Size(154, 22)
        Me.ModifyRecordFD.Text = "&Modify Record"
        '
        'DeleteRecordFD
        '
        Me.DeleteRecordFD.Name = "DeleteRecordFD"
        Me.DeleteRecordFD.Size = New System.Drawing.Size(154, 22)
        Me.DeleteRecordFD.Text = "&Delete Record"
        '
        'CurrentAccount
        '
        Me.CurrentAccount.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewRecordCA, Me.ModifyRecordCA, Me.DeleteRecordCA, Me.DebitCA, Me.CreditCA})
        Me.CurrentAccount.Name = "CurrentAccount"
        Me.CurrentAccount.ShowShortcutKeys = False
        Me.CurrentAccount.Size = New System.Drawing.Size(98, 20)
        Me.CurrentAccount.Text = "&Current Account"
        '
        'NewRecordCA
        '
        Me.NewRecordCA.Name = "NewRecordCA"
        Me.NewRecordCA.Size = New System.Drawing.Size(154, 22)
        Me.NewRecordCA.Text = "&New Record"
        '
        'ModifyRecordCA
        '
        Me.ModifyRecordCA.Name = "ModifyRecordCA"
        Me.ModifyRecordCA.Size = New System.Drawing.Size(154, 22)
        Me.ModifyRecordCA.Text = "&Modify Record"
        '
        'DeleteRecordCA
        '
        Me.DeleteRecordCA.Name = "DeleteRecordCA"
        Me.DeleteRecordCA.Size = New System.Drawing.Size(154, 22)
        Me.DeleteRecordCA.Text = "&Delete Record"
        '
        'DebitCA
        '
        Me.DebitCA.Name = "DebitCA"
        Me.DebitCA.Size = New System.Drawing.Size(154, 22)
        Me.DebitCA.Text = "De&bit"
        '
        'CreditCA
        '
        Me.CreditCA.Name = "CreditCA"
        Me.CreditCA.Size = New System.Drawing.Size(154, 22)
        Me.CreditCA.Text = "C&redit"
        '
        'SavingsAccount
        '
        Me.SavingsAccount.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewRecordSA, Me.ModifyRecordSA, Me.DeleteRecordSA, Me.DebitSA, Me.CreditSA})
        Me.SavingsAccount.Name = "SavingsAccount"
        Me.SavingsAccount.Size = New System.Drawing.Size(98, 20)
        Me.SavingsAccount.Text = "&Savings Account"
        '
        'NewRecordSA
        '
        Me.NewRecordSA.Name = "NewRecordSA"
        Me.NewRecordSA.Size = New System.Drawing.Size(154, 22)
        Me.NewRecordSA.Text = "&New Record"
        '
        'ModifyRecordSA
        '
        Me.ModifyRecordSA.Name = "ModifyRecordSA"
        Me.ModifyRecordSA.Size = New System.Drawing.Size(154, 22)
        Me.ModifyRecordSA.Text = "&Modify Record"
        '
        'DeleteRecordSA
        '
        Me.DeleteRecordSA.Name = "DeleteRecordSA"
        Me.DeleteRecordSA.Size = New System.Drawing.Size(154, 22)
        Me.DeleteRecordSA.Text = "&Delete Record"
        '
        'DebitSA
        '
        Me.DebitSA.Name = "DebitSA"
        Me.DebitSA.Size = New System.Drawing.Size(154, 22)
        Me.DebitSA.Text = "De&bit"
        '
        'CreditSA
        '
        Me.CreditSA.Name = "CreditSA"
        Me.CreditSA.Size = New System.Drawing.Size(154, 22)
        Me.CreditSA.Text = "C&redit"
        '
        'Search
        '
        Me.Search.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FixedDepositToolStripMenuItem1, Me.CurrentAccountToolStripMenuItem1, Me.SavingsAccountToolStripMenuItem1})
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(52, 20)
        Me.Search.Text = "Sea&rch"
        '
        'FixedDepositToolStripMenuItem1
        '
        Me.FixedDepositToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ByAccountNumberFD, Me.ByBankNameFD, Me.ByDateOfOpeningFD, Me.ByDateOfMaturityFD})
        Me.FixedDepositToolStripMenuItem1.Name = "FixedDepositToolStripMenuItem1"
        Me.FixedDepositToolStripMenuItem1.Size = New System.Drawing.Size(164, 22)
        Me.FixedDepositToolStripMenuItem1.Text = "&Fixed Deposit"
        '
        'ByAccountNumberFD
        '
        Me.ByAccountNumberFD.Name = "ByAccountNumberFD"
        Me.ByAccountNumberFD.Size = New System.Drawing.Size(179, 22)
        Me.ByAccountNumberFD.Text = "By &Account Number"
        '
        'ByBankNameFD
        '
        Me.ByBankNameFD.Name = "ByBankNameFD"
        Me.ByBankNameFD.Size = New System.Drawing.Size(179, 22)
        Me.ByBankNameFD.Text = "By &Bank Name"
        '
        'ByDateOfOpeningFD
        '
        Me.ByDateOfOpeningFD.Name = "ByDateOfOpeningFD"
        Me.ByDateOfOpeningFD.Size = New System.Drawing.Size(179, 22)
        Me.ByDateOfOpeningFD.Text = "By Date of &Opening"
        '
        'ByDateOfMaturityFD
        '
        Me.ByDateOfMaturityFD.Name = "ByDateOfMaturityFD"
        Me.ByDateOfMaturityFD.Size = New System.Drawing.Size(179, 22)
        Me.ByDateOfMaturityFD.Text = "By Date of &Maturity"
        '
        'CurrentAccountToolStripMenuItem1
        '
        Me.CurrentAccountToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ByAccountNumberCA, Me.ByBankNameCA, Me.ByDateOfTransactionCA})
        Me.CurrentAccountToolStripMenuItem1.Name = "CurrentAccountToolStripMenuItem1"
        Me.CurrentAccountToolStripMenuItem1.Size = New System.Drawing.Size(164, 22)
        Me.CurrentAccountToolStripMenuItem1.Text = "&Current Account"
        '
        'ByAccountNumberCA
        '
        Me.ByAccountNumberCA.Name = "ByAccountNumberCA"
        Me.ByAccountNumberCA.Size = New System.Drawing.Size(195, 22)
        Me.ByAccountNumberCA.Text = "By &Account Number"
        '
        'ByBankNameCA
        '
        Me.ByBankNameCA.Name = "ByBankNameCA"
        Me.ByBankNameCA.Size = New System.Drawing.Size(195, 22)
        Me.ByBankNameCA.Text = "By &Bank Name"
        '
        'ByDateOfTransactionCA
        '
        Me.ByDateOfTransactionCA.Name = "ByDateOfTransactionCA"
        Me.ByDateOfTransactionCA.Size = New System.Drawing.Size(195, 22)
        Me.ByDateOfTransactionCA.Text = "By Date of &Transaction"
        '
        'SavingsAccountToolStripMenuItem1
        '
        Me.SavingsAccountToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ByAccountNumberSA, Me.ByBankNameSA, Me.ByDateOfTransactionSA})
        Me.SavingsAccountToolStripMenuItem1.Name = "SavingsAccountToolStripMenuItem1"
        Me.SavingsAccountToolStripMenuItem1.Size = New System.Drawing.Size(164, 22)
        Me.SavingsAccountToolStripMenuItem1.Text = "&Savings Account"
        '
        'ByAccountNumberSA
        '
        Me.ByAccountNumberSA.Name = "ByAccountNumberSA"
        Me.ByAccountNumberSA.Size = New System.Drawing.Size(195, 22)
        Me.ByAccountNumberSA.Text = "By &Account Number"
        '
        'ByBankNameSA
        '
        Me.ByBankNameSA.Name = "ByBankNameSA"
        Me.ByBankNameSA.Size = New System.Drawing.Size(195, 22)
        Me.ByBankNameSA.Text = "By &Bank Name"
        '
        'ByDateOfTransactionSA
        '
        Me.ByDateOfTransactionSA.Name = "ByDateOfTransactionSA"
        Me.ByDateOfTransactionSA.Size = New System.Drawing.Size(195, 22)
        Me.ByDateOfTransactionSA.Text = "By Date of &Transaction"
        '
        'Alert
        '
        Me.Alert.Name = "Alert"
        Me.Alert.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.Alert.Size = New System.Drawing.Size(42, 20)
        Me.Alert.Text = "&Alert"
        '
        'Transaction
        '
        Me.Transaction.Name = "Transaction"
        Me.Transaction.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.Transaction.Size = New System.Drawing.Size(75, 20)
        Me.Transaction.Text = "&Transaction"
        '
        'CurrentStatus
        '
        Me.CurrentStatus.Name = "CurrentStatus"
        Me.CurrentStatus.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CurrentStatus.Size = New System.Drawing.Size(90, 20)
        Me.CurrentStatus.Text = "C&urrent Status"
        '
        'SystemTools
        '
        Me.SystemTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Utilities, Me.Logout, Me.Exit_soft, Me.About, Me.BackDatabaseToolStripMenuItem})
        Me.SystemTools.Name = "SystemTools"
        Me.SystemTools.ShortcutKeyDisplayString = ""
        Me.SystemTools.Size = New System.Drawing.Size(54, 20)
        Me.SystemTools.Text = "S&ystem"
        '
        'Utilities
        '
        Me.Utilities.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Calculator, Me.Notepad})
        Me.Utilities.Name = "Utilities"
        Me.Utilities.Size = New System.Drawing.Size(193, 22)
        Me.Utilities.Text = "&Utilities"
        '
        'Calculator
        '
        Me.Calculator.Name = "Calculator"
        Me.Calculator.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.Calculator.Size = New System.Drawing.Size(172, 22)
        Me.Calculator.Text = "&Calculator"
        '
        'Notepad
        '
        Me.Notepad.Name = "Notepad"
        Me.Notepad.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.Notepad.Size = New System.Drawing.Size(172, 22)
        Me.Notepad.Text = "&Notepad"
        '
        'Logout
        '
        Me.Logout.Name = "Logout"
        Me.Logout.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.Logout.Size = New System.Drawing.Size(193, 22)
        Me.Logout.Text = "&Logout"
        '
        'Exit_soft
        '
        Me.Exit_soft.Name = "Exit_soft"
        Me.Exit_soft.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.Exit_soft.Size = New System.Drawing.Size(193, 22)
        Me.Exit_soft.Text = "&Exit"
        '
        'About
        '
        Me.About.Name = "About"
        Me.About.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.About.Size = New System.Drawing.Size(193, 22)
        Me.About.Text = "&About"
        '
        'BackDatabaseToolStripMenuItem
        '
        Me.BackDatabaseToolStripMenuItem.Name = "BackDatabaseToolStripMenuItem"
        Me.BackDatabaseToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10
        Me.BackDatabaseToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.BackDatabaseToolStripMenuItem.Text = "&Backup Database"
        '
        'lbl_90days
        '
        Me.lbl_90days.AutoSize = True
        Me.lbl_90days.BackColor = System.Drawing.Color.Yellow
        Me.lbl_90days.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_90days.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_90days.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lbl_90days.Location = New System.Drawing.Point(739, 4)
        Me.lbl_90days.MaximumSize = New System.Drawing.Size(41, 15)
        Me.lbl_90days.MinimumSize = New System.Drawing.Size(41, 15)
        Me.lbl_90days.Name = "lbl_90days"
        Me.lbl_90days.Size = New System.Drawing.Size(41, 15)
        Me.lbl_90days.TabIndex = 2
        Me.lbl_90days.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_30days
        '
        Me.lbl_30days.AutoSize = True
        Me.lbl_30days.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_30days.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_30days.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_30days.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lbl_30days.Location = New System.Drawing.Point(692, 4)
        Me.lbl_30days.MaximumSize = New System.Drawing.Size(41, 15)
        Me.lbl_30days.MinimumSize = New System.Drawing.Size(41, 15)
        Me.lbl_30days.Name = "lbl_30days"
        Me.lbl_30days.Size = New System.Drawing.Size(41, 15)
        Me.lbl_30days.TabIndex = 3
        Me.lbl_30days.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_7days
        '
        Me.lbl_7days.AutoSize = True
        Me.lbl_7days.BackColor = System.Drawing.Color.Red
        Me.lbl_7days.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_7days.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_7days.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lbl_7days.Location = New System.Drawing.Point(644, 4)
        Me.lbl_7days.MaximumSize = New System.Drawing.Size(41, 15)
        Me.lbl_7days.MinimumSize = New System.Drawing.Size(41, 15)
        Me.lbl_7days.Name = "lbl_7days"
        Me.lbl_7days.Size = New System.Drawing.Size(41, 15)
        Me.lbl_7days.TabIndex = 4
        Me.lbl_7days.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FBD_dbBackup
        '
        Me.FBD_dbBackup.Description = "Browse and select directory to backup database."
        Me.FBD_dbBackup.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(66, 17)
        Me.ToolStripStatusLabel5.Text = "Alt+A=Alert"
        '
        'ToolStripStatusLabel7
        '
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(114, 17)
        Me.ToolStripStatusLabel7.Text = "Alt+C=Current Status"
        '
        'ToolStripStatusLabel8
        '
        Me.ToolStripStatusLabel8.Name = "ToolStripStatusLabel8"
        Me.ToolStripStatusLabel8.Size = New System.Drawing.Size(98, 17)
        Me.ToolStripStatusLabel8.Text = "Alt+T=Transaction"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(95, 17)
        Me.ToolStripStatusLabel3.Text = "Ctrl+C=Calculator"
        '
        'ToolStripStatusLabel9
        '
        Me.ToolStripStatusLabel9.Name = "ToolStripStatusLabel9"
        Me.ToolStripStatusLabel9.Size = New System.Drawing.Size(80, 17)
        Me.ToolStripStatusLabel9.Text = "Ctrl+L=LogOut"
        '
        'ToolStripStatusLabel10
        '
        Me.ToolStripStatusLabel10.Name = "ToolStripStatusLabel10"
        Me.ToolStripStatusLabel10.Size = New System.Drawing.Size(66, 17)
        Me.ToolStripStatusLabel10.Text = "Alt+F4=Exit"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(116, 17)
        Me.ToolStripStatusLabel1.Text = "F10=Backup Database"
        '
        'StatusStrip_TFDPC
        '
        Me.StatusStrip_TFDPC.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel5, Me.ToolStripStatusLabel7, Me.ToolStripStatusLabel8, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel9, Me.ToolStripStatusLabel10, Me.ToolStripStatusLabel1})
        Me.StatusStrip_TFDPC.Location = New System.Drawing.Point(0, 524)
        Me.StatusStrip_TFDPC.Name = "StatusStrip_TFDPC"
        Me.StatusStrip_TFDPC.Size = New System.Drawing.Size(792, 22)
        Me.StatusStrip_TFDPC.TabIndex = 6
        Me.StatusStrip_TFDPC.Text = "StatusStrip1"
        '
        'lbl_clock
        '
        Me.lbl_clock.AutoSize = True
        Me.lbl_clock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_clock.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_clock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_clock.Location = New System.Drawing.Point(593, 495)
        Me.lbl_clock.MinimumSize = New System.Drawing.Size(180, 16)
        Me.lbl_clock.Name = "lbl_clock"
        Me.lbl_clock.Size = New System.Drawing.Size(180, 18)
        Me.lbl_clock.TabIndex = 8
        Me.lbl_clock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer_Clock
        '
        '
        'frm_home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TFDPC_v2._0.My.Resources.Resources.bamboo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(792, 546)
        Me.Controls.Add(Me.lbl_clock)
        Me.Controls.Add(Me.StatusStrip_TFDPC)
        Me.Controls.Add(Me.lbl_7days)
        Me.Controls.Add(Me.lbl_30days)
        Me.Controls.Add(Me.lbl_90days)
        Me.Controls.Add(Me.MenuStrip_TFDPC)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip_TFDPC
        Me.MaximumSize = New System.Drawing.Size(800, 580)
        Me.MinimumSize = New System.Drawing.Size(800, 580)
        Me.Name = "frm_home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TFDPC Bank Transaction Monitor v1.0"
        Me.MenuStrip_TFDPC.ResumeLayout(False)
        Me.MenuStrip_TFDPC.PerformLayout()
        Me.StatusStrip_TFDPC.ResumeLayout(False)
        Me.StatusStrip_TFDPC.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip_TFDPC As System.Windows.Forms.MenuStrip
    Friend WithEvents FixedDeposit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CurrentAccount As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SavingsAccount As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Search As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Alert As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FixedDepositToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ByAccountNumberFD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ByBankNameFD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ByDateOfOpeningFD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ByDateOfMaturityFD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CurrentAccountToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ByAccountNumberCA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ByBankNameCA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SavingsAccountToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ByDateOfTransactionCA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ByAccountNumberSA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ByBankNameSA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ByDateOfTransactionSA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewRecordFD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifyRecordFD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteRecordFD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewRecordCA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifyRecordCA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteRecordCA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DebitCA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreditCA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewRecordSA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifyRecordSA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteRecordSA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DebitSA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreditSA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Transaction As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SystemTools As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbl_90days As System.Windows.Forms.Label
    Friend WithEvents lbl_30days As System.Windows.Forms.Label
    Friend WithEvents lbl_7days As System.Windows.Forms.Label
    Friend WithEvents CurrentStatus As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Utilities As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Logout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Exit_soft As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents About As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Calculator As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Notepad As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackDatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FBD_dbBackup As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel7 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel8 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel9 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel10 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip_TFDPC As System.Windows.Forms.StatusStrip
    Friend WithEvents OFD_db As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lbl_clock As System.Windows.Forms.Label
    Friend WithEvents Timer_Clock As System.Windows.Forms.Timer

End Class
