Imports NetSeal

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUpdate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUpdate))
        Me.pbGun = New System.Windows.Forms.PictureBox()
        Me.btnClose = New NetSeal.NSButton()
        Me.btnUpdate = New NetSeal.NSButton()
        Me.lNewUpdate = New NetSeal.NSLabel()
        Me.cbClose = New NetSeal.NSControlButton()
        Me.NsThemeUpdate = New NetSeal.NSTheme()
        Me.txtChangelog = New System.Windows.Forms.TextBox()
        Me.btnSkip = New NetSeal.NSButton()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.NsCheckBox1 = New NetSeal.NSCheckBox()
        Me.tSkip = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pbGun, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NsThemeUpdate.SuspendLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbGun
        '
        Me.pbGun.BackgroundImage = Global.Social_Exchange_Bot.My.Resources.Resources.white
        Me.pbGun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbGun.Location = New System.Drawing.Point(12, 36)
        Me.pbGun.Name = "pbGun"
        Me.pbGun.Size = New System.Drawing.Size(61, 48)
        Me.pbGun.TabIndex = 5
        Me.pbGun.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(148, 93)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(53, 23)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnUpdate.Location = New System.Drawing.Point(249, 33)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(83, 51)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "     Update"
        '
        'lNewUpdate
        '
        Me.lNewUpdate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lNewUpdate.Location = New System.Drawing.Point(91, 46)
        Me.lNewUpdate.Name = "lNewUpdate"
        Me.lNewUpdate.Size = New System.Drawing.Size(134, 27)
        Me.lNewUpdate.TabIndex = 1
        Me.lNewUpdate.Text = "NsLabel1"
        Me.lNewUpdate.Value1 = " "
        Me.lNewUpdate.Value2 = "Searching for Updates.."
        '
        'cbClose
        '
        Me.cbClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbClose.ControlButton = NetSeal.NSControlButton.Button.Close
        Me.cbClose.Location = New System.Drawing.Point(407, 4)
        Me.cbClose.Margin = New System.Windows.Forms.Padding(0)
        Me.cbClose.MaximumSize = New System.Drawing.Size(18, 20)
        Me.cbClose.MinimumSize = New System.Drawing.Size(18, 20)
        Me.cbClose.Name = "cbClose"
        Me.cbClose.Size = New System.Drawing.Size(18, 20)
        Me.cbClose.TabIndex = 0
        Me.cbClose.Text = "Close"
        '
        'NsThemeUpdate
        '
        Me.NsThemeUpdate.AccentOffset = 42
        Me.NsThemeUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.NsThemeUpdate.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.NsThemeUpdate.Controls.Add(Me.txtChangelog)
        Me.NsThemeUpdate.Controls.Add(Me.btnSkip)
        Me.NsThemeUpdate.Controls.Add(Me.pbGun)
        Me.NsThemeUpdate.Controls.Add(Me.cbClose)
        Me.NsThemeUpdate.Controls.Add(Me.lNewUpdate)
        Me.NsThemeUpdate.Controls.Add(Me.btnUpdate)
        Me.NsThemeUpdate.Controls.Add(Me.pbLogo)
        Me.NsThemeUpdate.Customization = ""
        Me.NsThemeUpdate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NsThemeUpdate.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.NsThemeUpdate.Image = Nothing
        Me.NsThemeUpdate.Location = New System.Drawing.Point(0, 0)
        Me.NsThemeUpdate.Movable = True
        Me.NsThemeUpdate.Name = "NsThemeUpdate"
        Me.NsThemeUpdate.NoRounding = False
        Me.NsThemeUpdate.Sizable = False
        Me.NsThemeUpdate.Size = New System.Drawing.Size(432, 353)
        Me.NsThemeUpdate.SmartBounds = False
        Me.NsThemeUpdate.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.NsThemeUpdate.TabIndex = 0
        Me.NsThemeUpdate.Text = "Social Exchange Devil - Update"
        Me.NsThemeUpdate.TransparencyKey = System.Drawing.Color.Empty
        Me.NsThemeUpdate.Transparent = False
        '
        'txtChangelog
        '
        Me.txtChangelog.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtChangelog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtChangelog.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.txtChangelog.ForeColor = System.Drawing.Color.White
        Me.txtChangelog.Location = New System.Drawing.Point(12, 90)
        Me.txtChangelog.Multiline = True
        Me.txtChangelog.Name = "txtChangelog"
        Me.txtChangelog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtChangelog.Size = New System.Drawing.Size(409, 180)
        Me.txtChangelog.TabIndex = 9
        '
        'btnSkip
        '
        Me.btnSkip.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSkip.Location = New System.Drawing.Point(338, 33)
        Me.btnSkip.Name = "btnSkip"
        Me.btnSkip.Size = New System.Drawing.Size(83, 51)
        Me.btnSkip.TabIndex = 6
        Me.btnSkip.Text = "       Skip"
        '
        'pbLogo
        '
        Me.pbLogo.BackColor = System.Drawing.Color.Transparent
        Me.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbLogo.Location = New System.Drawing.Point(12, 276)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(409, 68)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbLogo.TabIndex = 8
        Me.pbLogo.TabStop = False
        '
        'NsCheckBox1
        '
        Me.NsCheckBox1.Checked = False
        Me.NsCheckBox1.Location = New System.Drawing.Point(0, 0)
        Me.NsCheckBox1.Name = "NsCheckBox1"
        Me.NsCheckBox1.Size = New System.Drawing.Size(0, 0)
        Me.NsCheckBox1.TabIndex = 0
        '
        'tSkip
        '
        Me.tSkip.Interval = 1000
        '
        'FrmUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 353)
        Me.Controls.Add(Me.NsThemeUpdate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Avaiable"
        Me.TopMost = True
        CType(Me.pbGun, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NsThemeUpdate.ResumeLayout(False)
        Me.NsThemeUpdate.PerformLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbClose As NSControlButton
    Friend WithEvents btnClose As NSButton
    Friend WithEvents btnUpdate As NSButton
    Friend WithEvents lNewUpdate As NSLabel
    Friend WithEvents pbGun As System.Windows.Forms.PictureBox
    Friend WithEvents NsThemeUpdate As NSTheme
    Friend WithEvents NsCheckBox1 As NSCheckBox
    Friend WithEvents btnSkip As NSButton
    Friend WithEvents pbLogo As System.Windows.Forms.PictureBox
    Friend WithEvents txtChangelog As System.Windows.Forms.TextBox
    Friend WithEvents tSkip As System.Windows.Forms.Timer
End Class
