Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Text.RegularExpressions
Imports Gecko
Imports Gecko.Collections
Imports Gecko.DOM

Public Class MyDailyLikes

    Shared Property SpeedFactor As Integer = 1


    ' Loops for a specificied period of time (milliseconds)
    Private Shared Sub wait(ByVal interval As Integer)
        Dim sw As New Stopwatch
        sw.Start()
        Do While sw.ElapsedMilliseconds < interval
            ' Allows UI to remain responsive
            Application.DoEvents()
        Loop
        sw.Stop()
    End Sub

#Region "SocialMediaExchanger"


    Public Shared Function Login(ByVal username As String, ByVal password As String) As String
        Try
            FrmMain.wbMain.Navigate("http://mydailylikes.com/logout.php")
            wait(5000 * SpeedFactor)

            FrmMain.wbMain.Navigate("http://mydailylikes.com/index.php")
            wait(5000 * SpeedFactor)

            ' 
            'Dim elogin As GeckoInputElement = CType(FrmMain.wbMain.Document.GetElementsByTagName("form").First()., GeckoInputElement)
            Dim elogin As GeckoFormElement = CType(FrmMain.wbMain.Document.GetElementsByTagName("form").First(), GeckoFormElement)

            Dim test As GeckoNode = FrmMain.wbMain.Document.GetElementsByClassName("gbut").First()

            Dim ele As GeckoInputElement = CType(test, GeckoInputElement)



            Dim elements As IDomHtmlCollection(Of GeckoElement) = elogin.GetElementsByTagName("input")
            elements(0).SetAttribute("value", username)
            wait(1000 * SpeedFactor)
            elements(1).SetAttribute("value", password)

            ele.Click()

            ' elogin.submit()
            wait(5000 * SpeedFactor)

            Select Case True

                Case FrmMain.wbMain.Document.Body.InnerHtml.Contains("Wrong username or password!")

                    Return "Invalid Username & Password"

                Case FrmMain.wbMain.Document.Body.InnerHtml.Contains("Account Manager")

                    Return "Login successful"

                Case Else

                    Return "Something went wrong"

            End Select

        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Shared Function Logout() As String
        Try
            FrmMain.wbMain.Navigate("http://mydailylikes.com/logout.php")
            wait(5000 * SpeedFactor)

            Return "True"

        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Shared Function Earn(ByVal lvitem As SocialList) As String
        Try
            Dim crd As String = Nothing

            FrmMain.wbMain.Navigate("http://mydailylikes.com/surf.php")
            wait(5000 * SpeedFactor)



            For i As Integer = 0 To 1000000000
                If Config.Earning = False Then
                    Exit For
                End If

                crd = GetCredits(FrmMain.wbMain.Document)
                If crd IsNot Nothing Then
                    lvitem.Credits = crd
                    FrmMain.folvMain.UpdateObject(lvitem)
                End If

                wait(31000)

                crd = GetCredits(FrmMain.wbMain.Document)
                If crd IsNot Nothing Then
                    lvitem.Credits = crd
                    FrmMain.folvMain.UpdateObject(lvitem)
                End If

                If Config.Earning = False Then
                    Exit For
                End If

            Next

            Return "True"

        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Shared Function GetCredits(ByVal doc As GeckoDocument) As String
        Try
            Dim elementWb As GeckoHtmlElement = Nothing
            elementWb = doc.GetHtmlElementById("skipped_td")

            Dim tmpCredits As String = elementWb.InnerHtml


            tmpCredits = tmpCredits.Split(CChar("|"))(0)
            tmpCredits = tmpCredits.Replace("Your coins: ", "")
            tmpCredits = tmpCredits.Replace(" ", "")

            Return tmpCredits
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

#End Region
End Class
