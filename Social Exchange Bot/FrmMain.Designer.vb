<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.ThemeMain = New NetSeal.NSTheme()
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.gbAdd = New NetSeal.NSGroupBox()
        Me.BtnShowDebug = New NetSeal.NSButton()
        Me.BtnRegisterAccount = New NetSeal.NSButton()
        Me.folvMain = New BrightIdeasSoftware.FastObjectListView()
        Me.btnAddAccount = New NetSeal.NSButton()
        Me.wbMain = New Gecko.GeckoWebBrowser()
        Me.txtPassword = New NetSeal.NSTextBox()
        Me.txtUsername = New NetSeal.NSTextBox()
        Me.gbService = New NetSeal.NSComboBox()
        Me.lPassword = New NetSeal.NSLabel()
        Me.lUsername = New NetSeal.NSLabel()
        Me.lService = New NetSeal.NSLabel()
        Me.cbMinimize = New NetSeal.NSControlButton()
        Me.cbMaximize = New NetSeal.NSControlButton()
        Me.cbClose = New NetSeal.NSControlButton()
        Me.cmMain = New NetSeal.NSContextMenu()
        Me.tsmiStartEarning = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopEarningToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.ThemeMain.SuspendLayout()
        Me.tlpMain.SuspendLayout()
        Me.gbAdd.SuspendLayout()
        CType(Me.folvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'ThemeMain
        '
        Me.ThemeMain.AccentOffset = 42
        Me.ThemeMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ThemeMain.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.ThemeMain.Controls.Add(Me.tlpMain)
        Me.ThemeMain.Controls.Add(Me.cbMinimize)
        Me.ThemeMain.Controls.Add(Me.cbMaximize)
        Me.ThemeMain.Controls.Add(Me.cbClose)
        Me.ThemeMain.Customization = ""
        Me.ThemeMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ThemeMain.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.ThemeMain.Image = Nothing
        Me.ThemeMain.Location = New System.Drawing.Point(0, 0)
        Me.ThemeMain.Movable = True
        Me.ThemeMain.Name = "ThemeMain"
        Me.ThemeMain.NoRounding = False
        Me.ThemeMain.Sizable = True
        Me.ThemeMain.Size = New System.Drawing.Size(707, 355)
        Me.ThemeMain.SmartBounds = True
        Me.ThemeMain.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ThemeMain.TabIndex = 0
        Me.ThemeMain.Text = "Social Exchange Devil"
        Me.ThemeMain.TransparencyKey = System.Drawing.Color.Empty
        Me.ThemeMain.Transparent = False
        '
        'tlpMain
        '
        Me.tlpMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpMain.ColumnCount = 1
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.Controls.Add(Me.gbAdd, 0, 0)
        Me.tlpMain.Location = New System.Drawing.Point(3, 35)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 1
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 412.0!))
        Me.tlpMain.Size = New System.Drawing.Size(704, 317)
        Me.tlpMain.TabIndex = 3
        '
        'gbAdd
        '
        Me.gbAdd.Controls.Add(Me.BtnShowDebug)
        Me.gbAdd.Controls.Add(Me.BtnRegisterAccount)
        Me.gbAdd.Controls.Add(Me.folvMain)
        Me.gbAdd.Controls.Add(Me.btnAddAccount)
        Me.gbAdd.Controls.Add(Me.wbMain)
        Me.gbAdd.Controls.Add(Me.txtPassword)
        Me.gbAdd.Controls.Add(Me.txtUsername)
        Me.gbAdd.Controls.Add(Me.gbService)
        Me.gbAdd.Controls.Add(Me.lPassword)
        Me.gbAdd.Controls.Add(Me.lUsername)
        Me.gbAdd.Controls.Add(Me.lService)
        Me.gbAdd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbAdd.DrawSeperator = False
        Me.gbAdd.Location = New System.Drawing.Point(3, 3)
        Me.gbAdd.Name = "gbAdd"
        Me.gbAdd.Size = New System.Drawing.Size(698, 406)
        Me.gbAdd.SubTitle = "Add an account to start mining."
        Me.gbAdd.TabIndex = 2
        Me.gbAdd.Text = "Add"
        Me.gbAdd.Title = "Automatically mine credits on many social exchange networks!"
        '
        'BtnShowDebug
        '
        Me.BtnShowDebug.Location = New System.Drawing.Point(657, 3)
        Me.BtnShowDebug.Name = "BtnShowDebug"
        Me.BtnShowDebug.Size = New System.Drawing.Size(32, 23)
        Me.BtnShowDebug.TabIndex = 16
        Me.BtnShowDebug.Text = "dbg"
        Me.ToolTipMain.SetToolTip(Me.BtnShowDebug, "Show/Hide the debug window.")
        '
        'BtnRegisterAccount
        '
        Me.BtnRegisterAccount.Location = New System.Drawing.Point(6, 274)
        Me.BtnRegisterAccount.Name = "BtnRegisterAccount"
        Me.BtnRegisterAccount.Size = New System.Drawing.Size(191, 23)
        Me.BtnRegisterAccount.TabIndex = 15
        Me.BtnRegisterAccount.Text = "      Register Account"
        Me.ToolTipMain.SetToolTip(Me.BtnRegisterAccount, "Open the register page of the selected network.")
        '
        'folvMain
        '
        Me.folvMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.folvMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.folvMain.ForeColor = System.Drawing.Color.White
        Me.folvMain.FullRowSelect = True
        Me.folvMain.Location = New System.Drawing.Point(203, 54)
        Me.folvMain.Name = "folvMain"
        Me.folvMain.ShowGroups = False
        Me.folvMain.Size = New System.Drawing.Size(486, 240)
        Me.folvMain.TabIndex = 3
        Me.folvMain.UseCompatibleStateImageBehavior = False
        Me.folvMain.View = System.Windows.Forms.View.Details
        Me.folvMain.VirtualMode = True
        '
        'btnAddAccount
        '
        Me.btnAddAccount.Location = New System.Drawing.Point(6, 245)
        Me.btnAddAccount.Name = "btnAddAccount"
        Me.btnAddAccount.Size = New System.Drawing.Size(191, 23)
        Me.btnAddAccount.TabIndex = 14
        Me.btnAddAccount.Text = "         Add Account"
        Me.ToolTipMain.SetToolTip(Me.btnAddAccount, "Add an account with the entered username and password to your list.")
        '
        'wbMain
        '
        Me.wbMain.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.wbMain.Location = New System.Drawing.Point(719, -352)
        Me.wbMain.Name = "wbMain"
        Me.wbMain.Size = New System.Drawing.Size(1024, 768)
        Me.wbMain.TabIndex = 3
        Me.wbMain.UseHttpActivityObserver = False
        '
        'txtPassword
        '
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.Location = New System.Drawing.Point(6, 216)
        Me.txtPassword.MaxLength = 32767
        Me.txtPassword.Multiline = False
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.ReadOnly = False
        Me.txtPassword.Size = New System.Drawing.Size(191, 23)
        Me.txtPassword.TabIndex = 9
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ToolTipMain.SetToolTip(Me.txtPassword, "Enter the password for the selected network.")
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtUsername
        '
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.Location = New System.Drawing.Point(6, 158)
        Me.txtUsername.MaxLength = 32767
        Me.txtUsername.Multiline = False
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.ReadOnly = False
        Me.txtUsername.Size = New System.Drawing.Size(191, 23)
        Me.txtUsername.TabIndex = 8
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ToolTipMain.SetToolTip(Me.txtUsername, "Enter the username for the selected network.")
        Me.txtUsername.UseSystemPasswordChar = False
        '
        'gbService
        '
        Me.gbService.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.gbService.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.gbService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.gbService.ForeColor = System.Drawing.Color.White
        Me.gbService.FormattingEnabled = True
        Me.gbService.Items.AddRange(New Object() {"SocialClerks.com", "Social-Media-Exchanger.com", "MyDailyLikes.com", "AddMeFast.com", "followmybuzz.com"})
        Me.gbService.Location = New System.Drawing.Point(6, 85)
        Me.gbService.Name = "gbService"
        Me.gbService.Size = New System.Drawing.Size(191, 21)
        Me.gbService.TabIndex = 7
        Me.ToolTipMain.SetToolTip(Me.gbService, "Select a social network where you want to earn credits.")
        '
        'lPassword
        '
        Me.lPassword.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lPassword.Location = New System.Drawing.Point(6, 187)
        Me.lPassword.Name = "lPassword"
        Me.lPassword.Size = New System.Drawing.Size(75, 23)
        Me.lPassword.TabIndex = 2
        Me.lPassword.Text = "lPassword"
        Me.ToolTipMain.SetToolTip(Me.lPassword, "Enter the password for the selected network.")
        Me.lPassword.Value1 = "Password:"
        Me.lPassword.Value2 = ""
        '
        'lUsername
        '
        Me.lUsername.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lUsername.Location = New System.Drawing.Point(6, 129)
        Me.lUsername.Name = "lUsername"
        Me.lUsername.Size = New System.Drawing.Size(75, 23)
        Me.lUsername.TabIndex = 1
        Me.lUsername.Text = "lUsername"
        Me.ToolTipMain.SetToolTip(Me.lUsername, "Enter the username for the selected network.")
        Me.lUsername.Value1 = "Username:"
        Me.lUsername.Value2 = ""
        '
        'lService
        '
        Me.lService.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lService.Location = New System.Drawing.Point(6, 56)
        Me.lService.Name = "lService"
        Me.lService.Size = New System.Drawing.Size(156, 23)
        Me.lService.TabIndex = 0
        Me.lService.Text = "lService"
        Me.ToolTipMain.SetToolTip(Me.lService, "Select a social network where you want to earn credits.")
        Me.lService.Value1 = "Social Exchange Networks:"
        Me.lService.Value2 = ""
        '
        'cbMinimize
        '
        Me.cbMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbMinimize.ControlButton = NetSeal.NSControlButton.Button.Minimize
        Me.cbMinimize.Location = New System.Drawing.Point(645, 6)
        Me.cbMinimize.Margin = New System.Windows.Forms.Padding(0)
        Me.cbMinimize.MaximumSize = New System.Drawing.Size(18, 20)
        Me.cbMinimize.MinimumSize = New System.Drawing.Size(18, 20)
        Me.cbMinimize.Name = "cbMinimize"
        Me.cbMinimize.Size = New System.Drawing.Size(18, 20)
        Me.cbMinimize.TabIndex = 2
        Me.cbMinimize.Text = "NsControlButton1"
        '
        'cbMaximize
        '
        Me.cbMaximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbMaximize.ControlButton = NetSeal.NSControlButton.Button.MaximizeRestore
        Me.cbMaximize.Enabled = False
        Me.cbMaximize.Location = New System.Drawing.Point(663, 6)
        Me.cbMaximize.Margin = New System.Windows.Forms.Padding(0)
        Me.cbMaximize.MaximumSize = New System.Drawing.Size(18, 20)
        Me.cbMaximize.MinimumSize = New System.Drawing.Size(18, 20)
        Me.cbMaximize.Name = "cbMaximize"
        Me.cbMaximize.Size = New System.Drawing.Size(18, 20)
        Me.cbMaximize.TabIndex = 1
        Me.cbMaximize.Text = "NsControlButton1"
        '
        'cbClose
        '
        Me.cbClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbClose.ControlButton = NetSeal.NSControlButton.Button.Close
        Me.cbClose.Location = New System.Drawing.Point(681, 6)
        Me.cbClose.Margin = New System.Windows.Forms.Padding(0)
        Me.cbClose.MaximumSize = New System.Drawing.Size(18, 20)
        Me.cbClose.MinimumSize = New System.Drawing.Size(18, 20)
        Me.cbClose.Name = "cbClose"
        Me.cbClose.Size = New System.Drawing.Size(18, 20)
        Me.cbClose.TabIndex = 0
        Me.cbClose.Text = "NsControlButton1"
        '
        'cmMain
        '
        Me.cmMain.ForeColor = System.Drawing.Color.White
        Me.cmMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiStartEarning, Me.StopEarningToolStripMenuItem, Me.RemoveAccountToolStripMenuItem})
        Me.cmMain.Name = "cmMain"
        Me.cmMain.Size = New System.Drawing.Size(166, 70)
        '
        'tsmiStartEarning
        '
        Me.tsmiStartEarning.Name = "tsmiStartEarning"
        Me.tsmiStartEarning.Size = New System.Drawing.Size(165, 22)
        Me.tsmiStartEarning.Text = "Start earning"
        '
        'StopEarningToolStripMenuItem
        '
        Me.StopEarningToolStripMenuItem.Name = "StopEarningToolStripMenuItem"
        Me.StopEarningToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.StopEarningToolStripMenuItem.Text = "Stop earning"
        '
        'RemoveAccountToolStripMenuItem
        '
        Me.RemoveAccountToolStripMenuItem.Name = "RemoveAccountToolStripMenuItem"
        Me.RemoveAccountToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.RemoveAccountToolStripMenuItem.Text = "Remove Account"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 355)
        Me.Controls.Add(Me.ThemeMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Social Exchange Devil"
        Me.TopMost = True
        Me.ThemeMain.ResumeLayout(False)
        Me.tlpMain.ResumeLayout(False)
        Me.gbAdd.ResumeLayout(False)
        CType(Me.folvMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ThemeMain As NetSeal.NSTheme
    Friend WithEvents tlpMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cbMinimize As NetSeal.NSControlButton
    Friend WithEvents cbClose As NetSeal.NSControlButton
    Friend WithEvents cmMain As NetSeal.NSContextMenu
    Friend WithEvents tsmiStartEarning As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopEarningToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gbAdd As NSGroupBox
    Friend WithEvents BtnShowDebug As NSButton
    Friend WithEvents BtnRegisterAccount As NSButton
    Friend WithEvents folvMain As FastObjectListView
    Friend WithEvents btnAddAccount As NSButton
    Friend WithEvents wbMain As Gecko.GeckoWebBrowser
    Friend WithEvents txtPassword As NSTextBox
    Friend WithEvents txtUsername As NSTextBox
    Friend WithEvents gbService As NSComboBox
    Friend WithEvents lPassword As NSLabel
    Friend WithEvents lUsername As NSLabel
    Friend WithEvents lService As NSLabel
    Friend WithEvents cbMaximize As NSControlButton
    Friend WithEvents ToolTipMain As ToolTip
End Class
