Imports System.Net

Public Class FrmUpdate
    Dim _iSkip As Integer = 30

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()
        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

    End Sub

    Private Sub cbClose_Click(sender As Object, e As EventArgs) Handles cbClose.Click
        tSkip.Stop()
        Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        tSkip.Stop()
        Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If MsgBox("Are you sure to close the application and download the new update?", MsgBoxStyle.YesNo, "Are you sure?") = MsgBoxResult.Yes Then
            Process.Start(Application.StartupPath & "\Updater.exe")
            Application.Exit()
        End If
    End Sub

    Private Sub pbLogo_Click(sender As Object, e As EventArgs) Handles pbLogo.Click
        Process.Start("http://gsoftwarelab.com")
    End Sub

    Private Sub UpdateFrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Using wClient As New WebClientEx
                wClient.Headers.Add(HttpRequestHeader.UserAgent, "Social Exchange Devil " & Version.SoftwareVersion)
                wClient.Timeout = 20000
                txtChangelog.Text = wClient.DownloadString("https://cdn.gsoftwarelab.com/social_exchange_bot/changelog").Replace(vbLf, vbNewLine)
            End Using

            If Version.Check Then
                lNewUpdate.Value2 = "No Update Avaiable!"
                tSkip.Stop()
                Close()
            Else
                lNewUpdate.Value2 = "New Update Avaiable!"
                'Me.lVersion.Value2 = Version.GetCurVers
                If Version.CurrentVersion.Contains("f") Then
                    btnSkip.Enabled = False
                    cbClose.Enabled = False
                Else
                    btnSkip.Text = String.Format("    Skip ({0})", _iSkip.ToString)
                    btnSkip.Refresh()
                    tSkip.Start()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnSkip_Click(sender As Object, e As EventArgs) Handles btnSkip.Click
        tSkip.Stop()
        Close()
    End Sub

    Private Sub tSkip_Tick(sender As Object, e As EventArgs) Handles tSkip.Tick
        Try
            If _iSkip = 0 Then
                btnSkip.Text = String.Format("    Skip ({0})", _iSkip.ToString)
                btnSkip.Refresh()

                _iSkip = 30
                Close()
            Else
                _iSkip -= 1
                btnSkip.Text = String.Format("    Skip ({0})", _iSkip.ToString)
                btnSkip.Refresh()
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class