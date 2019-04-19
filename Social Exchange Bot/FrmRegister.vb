Imports System.Threading
Imports NLog
Imports System.Web
Imports LicenseSpring

Public Class FrmRegister

    Public Vertified As Boolean = False
    Public Valid As Boolean = False
    Public Shared LicenseKey As String = Nothing

    Private licenseID As String
    Dim LizensManager As ILicenseManager = LicenseManager.GetInstance()

    Public Sub New()
        'Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        Dim configuration = New LicenseSpringConfiguration(
            apiKey:="874109dd-83d0-471d-852e-a9e4c6816eaf",
            sharedKey:="OZY76XToZ4toJ2JBfpnG7thaYUCE-oQj-UjaM3WDBl8",
            productCode:=Version.ProductCode,
            appName:=Version.ProductName,
            appVersion:=Version.CurrentVersion,
            licenseFilePath:=Nothing)

        LizensManager.Initialize(configuration)
    End Sub

    Private Sub BtnActivate_Click(sender As Object, e As EventArgs) Handles btnActivate.Click
        If txtLicenseCode.Text = Nothing Then
            MessageBox.Show("Please enter a license code first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            My.Settings.License = txtLicenseCode.Text 'Store licensecode in my settings
            My.Settings.Save()

            ActivateProduct()
        End If
    End Sub

    Private Sub btnActivateLite_Click(sender As Object, e As EventArgs) Handles BtnActivateLite.Click
        Dim email As String

        email = InputBox(Prompt:="Please enter your email address here in order to receive a free trial license." & vbNewLine & "(By using this form you agree with the storage and handling of your data by GSoftwareLab)", Title:="Trial License")

        If email = Nothing Or email.Contains("@") = False Then
            MessageBox.Show("Please enter a real email address in order to get a trial license.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If GetTrialLicense(email) Then
                InputBox("License created successfully. Please write your license down and press OK to activate Proxy Buddy.", "Trial License", Version.LicenseKey)
                txtLicenseCode.Text = Version.LicenseKey
                ActivateLicense(Version.LicenseKey)
            Else
                MessageBox.Show("Something went wrong, please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub


    Private Sub Register_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try
            If Version.Check() = False Then
                FrmUpdate.Show()
            End If

            If Not My.Settings.License = Nothing Then
                txtLicenseCode.Text = My.Settings.License
                ActivateProduct()
            End If

            Me.TopMost = False


        Catch ex As Exception
            MsgBox("Can't connect to secure server! Please try again later.", MsgBoxStyle.Critical, "Critical Error")
        End Try
    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NsThemeRegister.Text = "Social Exchange Devil " + Version.SoftwareVersion
        Text = "Social Exchange Devil " + Version.SoftwareVersion

        If Not Version.Check Then
            If Version.CurrentVersion.Contains("f") Then
                Process.Start(Application.StartupPath + "/Updater.exe")
                Application.Exit()
            End If

            FrmUpdate.Show()
        End If

        If Vertified Then
            Application.Exit()
        End If
    End Sub

    Private Sub ActivateProduct()
        Try
            If ActivateLicense(My.Settings.License) Then
                If CheckLicense(Version.License) Then 'Check the license key
                    Version.LicenseKey = My.Settings.License

                    If Version.License.Type = LicenseType.Trial Then 'Check if license is trial or now
                        Version.IsTrial = True
                    Else
                        Version.IsTrial = False
                    End If

                    FrmMain.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Please try it again later or contact the support under contact@gsoftwarelab.com if you need help.", "Invaild or expired license", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Function GetTrialLicense(ByVal email As String) As Boolean
        Try
            Version.LicenseKey = LizensManager.GetTrialKey(email)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Function ActivateLicense(licensekey As String) As Boolean
        Try
            Version.License = LizensManager.ActivateLicense(licensekey)
            Return True
        Catch ex As Exception
            MessageBox.Show("Please try it again later or contact the support under contact@gsoftwarelab.com if you need help.", "Invaild or expired license", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return False
    End Function

    Private Function CheckLicense(license As ILicense) As Boolean
        Try
            If license Is Nothing Then
                Return False
            Else
                license.Check()
                Version.Vertified = True
                Return license.IsActive 'License Valid -> Return true
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub NsControlButtonClose_Click(sender As Object, e As EventArgs) Handles NsControlButtonClose.Click
        Application.Exit()
    End Sub

    Private Sub lPoweredBy_Click(sender As Object, e As EventArgs) Handles lPoweredBy.Click
        Process.Start("https://licensespring.com")
    End Sub
End Class