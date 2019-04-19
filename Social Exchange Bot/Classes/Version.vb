Imports System.Net
Imports LicenseSpring

Public Class Version
    Public Shared Property LicenseKey As String
    Public Shared License As ILicense
    Public Shared Property IsTrial As Boolean
    Public Shared Property Vertified As Boolean
    Public Shared Property CurrentVersion As String 'Hold the current version from server

    Public Shared Property CurrentId As String

    Public Shared ReadOnly Property SoftwareVersion As String
        Get
            Return "2.0.1.3"
        End Get
    End Property

    Public Shared ReadOnly Property ProductCode As String
        Get
            Return "sd"
        End Get
    End Property

    Public Shared ReadOnly Property ProductName As String
        Get
            Return "Social Exchange Devil1"
        End Get
    End Property

    Public Shared ReadOnly Property SoftwareId As String
        Get
            Return "1"
        End Get
    End Property

    Public Shared Function Check() As Boolean
        Try
            Using wClient As New WebClientEx
                wClient.Headers.Add(HttpRequestHeader.UserAgent, "Social Exchange Devil  " & SoftwareVersion)
                wClient.Timeout = 30000
                CurrentVersion = wClient.DownloadString("https://cdn.gsoftwarelab.com/social_exchange_bot/version")
            End Using

            If SoftwareVersion = CurrentVersion Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show("Can't reach update server. Please try again later. If this error doesn't seems to be temporary please contact us.", "Server down", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End Try

    End Function
End Class