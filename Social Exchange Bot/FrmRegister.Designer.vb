Imports NetSeal

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegister
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegister))
        Me.NsThemeRegister = New NetSeal.NSTheme()
        Me.lPoweredBy = New System.Windows.Forms.Label()
        Me.BtnActivateLite = New NetSeal.NSButton()
        Me.NsControlButtonMinimize = New NetSeal.NSControlButton()
        Me.NsControlButtonClose = New NetSeal.NSControlButton()
        Me.BtnActivate = New NetSeal.NSButton()
        Me.txtLicenseCode = New NetSeal.NSTextBox()
        Me.lLicenseCode = New NetSeal.NSLabel()
        Me.tTest = New System.Windows.Forms.Timer(Me.components)
        Me.NsThemeRegister.SuspendLayout()
        Me.SuspendLayout()
        '
        'NsThemeRegister
        '
        Me.NsThemeRegister.AccentOffset = 42
        Me.NsThemeRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.NsThemeRegister.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.NsThemeRegister.Controls.Add(Me.lPoweredBy)
        Me.NsThemeRegister.Controls.Add(Me.BtnActivateLite)
        Me.NsThemeRegister.Controls.Add(Me.NsControlButtonMinimize)
        Me.NsThemeRegister.Controls.Add(Me.NsControlButtonClose)
        Me.NsThemeRegister.Controls.Add(Me.BtnActivate)
        Me.NsThemeRegister.Controls.Add(Me.txtLicenseCode)
        Me.NsThemeRegister.Controls.Add(Me.lLicenseCode)
        Me.NsThemeRegister.Customization = ""
        Me.NsThemeRegister.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NsThemeRegister.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.NsThemeRegister.Image = Nothing
        Me.NsThemeRegister.Location = New System.Drawing.Point(0, 0)
        Me.NsThemeRegister.Movable = True
        Me.NsThemeRegister.Name = "NsThemeRegister"
        Me.NsThemeRegister.NoRounding = False
        Me.NsThemeRegister.Sizable = False
        Me.NsThemeRegister.Size = New System.Drawing.Size(285, 142)
        Me.NsThemeRegister.SmartBounds = True
        Me.NsThemeRegister.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.NsThemeRegister.TabIndex = 1
        Me.NsThemeRegister.Text = "Social Exchange Devil"
        Me.NsThemeRegister.TransparencyKey = System.Drawing.Color.Empty
        Me.NsThemeRegister.Transparent = False
        '
        'lPoweredBy
        '
        Me.lPoweredBy.AutoSize = True
        Me.lPoweredBy.ForeColor = System.Drawing.Color.White
        Me.lPoweredBy.Location = New System.Drawing.Point(62, 121)
        Me.lPoweredBy.Name = "lPoweredBy"
        Me.lPoweredBy.Size = New System.Drawing.Size(152, 13)
        Me.lPoweredBy.TabIndex = 13
        Me.lPoweredBy.Text = "powered by licensespring"
        '
        'BtnActivateLite
        '
        Me.BtnActivateLite.Location = New System.Drawing.Point(155, 95)
        Me.BtnActivateLite.Name = "BtnActivateLite"
        Me.BtnActivateLite.Size = New System.Drawing.Size(118, 23)
        Me.BtnActivateLite.TabIndex = 12
        Me.BtnActivateLite.Text = "Get Free License"
        '
        'NsControlButtonMinimize
        '
        Me.NsControlButtonMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NsControlButtonMinimize.ControlButton = NetSeal.NSControlButton.Button.Minimize
        Me.NsControlButtonMinimize.Location = New System.Drawing.Point(240, 4)
        Me.NsControlButtonMinimize.Margin = New System.Windows.Forms.Padding(0)
        Me.NsControlButtonMinimize.MaximumSize = New System.Drawing.Size(18, 20)
        Me.NsControlButtonMinimize.MinimumSize = New System.Drawing.Size(18, 20)
        Me.NsControlButtonMinimize.Name = "NsControlButtonMinimize"
        Me.NsControlButtonMinimize.Size = New System.Drawing.Size(18, 20)
        Me.NsControlButtonMinimize.TabIndex = 10
        Me.NsControlButtonMinimize.Text = "Minimize"
        '
        'NsControlButtonClose
        '
        Me.NsControlButtonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NsControlButtonClose.ControlButton = NetSeal.NSControlButton.Button.Close
        Me.NsControlButtonClose.Location = New System.Drawing.Point(258, 4)
        Me.NsControlButtonClose.Margin = New System.Windows.Forms.Padding(0)
        Me.NsControlButtonClose.MaximumSize = New System.Drawing.Size(18, 20)
        Me.NsControlButtonClose.MinimumSize = New System.Drawing.Size(18, 20)
        Me.NsControlButtonClose.Name = "NsControlButtonClose"
        Me.NsControlButtonClose.Size = New System.Drawing.Size(18, 20)
        Me.NsControlButtonClose.TabIndex = 9
        Me.NsControlButtonClose.Text = "Close"
        '
        'BtnActivate
        '
        Me.BtnActivate.Location = New System.Drawing.Point(12, 95)
        Me.BtnActivate.Name = "BtnActivate"
        Me.BtnActivate.Size = New System.Drawing.Size(137, 23)
        Me.BtnActivate.TabIndex = 1
        Me.BtnActivate.Text = "Activate Product"
        '
        'txtLicenseCode
        '
        Me.txtLicenseCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLicenseCode.Location = New System.Drawing.Point(12, 66)
        Me.txtLicenseCode.MaxLength = 32767
        Me.txtLicenseCode.Multiline = False
        Me.txtLicenseCode.Name = "txtLicenseCode"
        Me.txtLicenseCode.ReadOnly = False
        Me.txtLicenseCode.Size = New System.Drawing.Size(261, 23)
        Me.txtLicenseCode.TabIndex = 0
        Me.txtLicenseCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtLicenseCode.UseSystemPasswordChar = False
        '
        'lLicenseCode
        '
        Me.lLicenseCode.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lLicenseCode.Location = New System.Drawing.Point(12, 37)
        Me.lLicenseCode.Name = "lLicenseCode"
        Me.lLicenseCode.Size = New System.Drawing.Size(92, 23)
        Me.lLicenseCode.TabIndex = 5
        Me.lLicenseCode.Text = "License Code:"
        Me.lLicenseCode.Value1 = "License"
        Me.lLicenseCode.Value2 = "Code"
        '
        'tTest
        '
        Me.tTest.Enabled = True
        Me.tTest.Interval = 1000
        '
        'FrmRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(285, 142)
        Me.Controls.Add(Me.NsThemeRegister)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Social Exchange Devil"
        Me.TopMost = True
        Me.NsThemeRegister.ResumeLayout(False)
        Me.NsThemeRegister.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NsThemeRegister As NSTheme
    Friend WithEvents NsControlButtonMinimize As NSControlButton
    Friend WithEvents NsControlButtonClose As NSControlButton
    Friend WithEvents BtnActivate As NSButton
    Friend WithEvents txtLicenseCode As NSTextBox
    Friend WithEvents lLicenseCode As NSLabel
    Friend WithEvents tTest As System.Windows.Forms.Timer
    Friend WithEvents BtnActivateLite As NSButton
    Friend WithEvents lPoweredBy As Label
End Class
