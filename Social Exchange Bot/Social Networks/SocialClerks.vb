Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Text.RegularExpressions
Imports Gecko
Imports Gecko.Collections
Imports Gecko.DOM

Public Class SocialClerks
    Shared Property SpeedFactor As Integer = 1
    Shared Property EarningSocialclerks As Boolean
    Shared Property StopEarningSocialclerks As Boolean

    Public Shared Function PostRequest(ByVal data As String, ByVal url As String, ByVal referer As String, ByRef ccontainer As CookieContainer) As String
        Dim serverResponse As String = ""

        Try


            Dim byteArray As Byte() = Encoding.UTF8.GetBytes(data)
            Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
            request.CookieContainer = ccontainer
            request.Method = "POST"
            request.Headers.Add(HttpRequestHeader.AcceptCharset, "windows-1258,utf-8;q=0.7,*;q=0.3")
            request.Headers.Add(HttpRequestHeader.AcceptEncoding, "gzip, deflate")
            request.Headers.Add(HttpRequestHeader.AcceptLanguage, "en-US,en;q=0.5")
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:17.0) Gecko/20100101 Firefox/17.0"
            request.Referer = referer
            request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8"
            request.KeepAlive = True
            request.ContentType = "application/x-www-form-urlencoded; charset=UTF-8"
            request.Timeout = 10000


            request.ContentLength = byteArray.Length
            Dim dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteArray, 0, byteArray.Length)
            dataStream.Close()

            Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)


            dataStream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            serverResponse = reader.ReadToEnd()
            reader.Close()
            dataStream.Close()
            response.Close()

            Return serverResponse
        Catch exception As Exception

            MsgBox(exception.ToString)
            Return serverResponse
        End Try
    End Function

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

#Region "SocialClerks"


    Public Shared Function SocialClerksLogin(ByVal username As String, ByVal password As String) As String
        Try
            FrmMain.wbMain.Navigate("http://www.socialclerks.com/registration/user/signout")
            wait(5000 * SpeedFactor)

            FrmMain.wbMain.Navigate("http://www.socialclerks.com/")
            wait(5000 * SpeedFactor)

            Dim login As GeckoFormElement = CType(FrmMain.wbMain.Document.Forms.Last, GeckoFormElement)
            Dim elements As IDomHtmlCollection(Of GeckoElement) = login.GetElementsByTagName("input")
            elements(0).SetAttribute("value", username)
            elements(1).SetAttribute("value", password)

            wait(1000 * SpeedFactor)
            login.submit()

            wait(5000 * SpeedFactor)

            Select Case True

                Case FrmMain.wbMain.Document.Body.InnerHtml.Contains("Invalid Username & Password")

                    Return "Invalid Username & Password"

                Case FrmMain.wbMain.Document.Body.InnerHtml.Contains("credits_left")

                    Return "Login successful"

                Case Else

                    Return "Something went wrong"

            End Select

        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Shared Function SocialClerksLogout() As Boolean
        Try
            FrmMain.wbMain.Navigate("http://www.socialclerks.com/registration/user/signout")
            wait(5000 * SpeedFactor)

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Shared Function SocialClerksEarn(ByVal cheat As Boolean, ByVal lvitem As SocialList) As String
        Try
            FrmMain.wbMain.Navigate("http://socialclerk.net/website/dashboard/all")
            wait(5000 * SpeedFactor)

            Dim theElementCollection As GeckoElementCollection = Nothing
            theElementCollection = FrmMain.wbMain.Document.GetElementsByTagName("a")

            For Each curElement As GeckoHtmlElement In theElementCollection

                If curElement.GetAttribute("class") = "follow" Then
                    Dim input As String = curElement.GetAttribute("onclick").ToString

                    Dim pattern As String = "'\d\d'"
                    Dim output As String = Nothing
                    For Each match As Match In Regex.Matches(input, pattern, RegexOptions.IgnoreCase)
                        output = match.Value
                    Next

                    If cheat Then
                        curElement.SetAttribute("onclick", input.Replace(output, "'2'"))
                        wait(1000 * SpeedFactor)
                    End If

                    curElement.Click()
                    wait(5000 * SpeedFactor)

                    lvitem.Credits = SocialClerksGetCredits(False)
                    FrmMain.folvMain.UpdateObject(lvitem)

                    If Config.Earning = False Then
                        Exit For
                    End If

                End If

            Next

            Return "True"

        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Shared Function SocialClerksGetCredits(ByVal redirect As Boolean) As String
        Try
            If redirect Then
                FrmMain.wbMain.Navigate("http://socialclerk.net/website/dashboard/all")
                wait(5000 * SpeedFactor)
            End If


            If FrmMain.wbMain.Document.Body.InnerHtml.Contains("credits_left") Then
                Dim credits As String = Nothing

                Dim theElementCollection As GeckoElementCollection = Nothing
                theElementCollection = FrmMain.wbMain.Document.GetElementsByTagName("div")

                For Each curElement As GeckoHtmlElement In theElementCollection

                    If curElement.GetAttribute("class") = "bgbuycredit-textarea" Then
                        credits = curElement.InnerHtml
                        Exit For
                    End If

                Next


                Return credits.Replace(CChar(" "), CChar(""))
            Else
                Return "0"
            End If
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

#End Region
End Class
