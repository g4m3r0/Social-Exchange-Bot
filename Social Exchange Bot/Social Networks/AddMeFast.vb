Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Text.RegularExpressions
Imports Gecko
Imports Gecko.Collections
Imports Gecko.DOM

Public Class AddMeFast

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

#Region "AddMeFast"


    Public Shared Function Login(ByVal username As String, ByVal password As String) As String
        Try
            Logout()

            FrmMain.wbMain.Navigate("http://addmefast.com/login/incorrect")
            wait(5000 * SpeedFactor)

            Dim elogin As GeckoFormElement = CType(FrmMain.wbMain.Document.GetElementsByTagName("form").First(), GeckoFormElement)

            Dim test As GeckoNode = FrmMain.wbMain.Document.GetElementsByClassName("sign_up btn").First()

            Dim ele As GeckoInputElement = CType(test, GeckoInputElement)



            Dim elements As IDomHtmlCollection(Of GeckoElement) = elogin.GetElementsByTagName("input")
            elements(0).SetAttribute("value", username)
            wait(1000 * SpeedFactor)
            elements(1).SetAttribute("value", password)

            'elogin.submit()

            ele.Click()
            wait(5000 * SpeedFactor)

            Select Case True

                Case FrmMain.wbMain.Document.Body.InnerHtml.Contains("Login Error")

                    Return "Invalid Username & Password"

                Case FrmMain.wbMain.Document.Body.InnerHtml.Contains("Welcome! You")

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
            FrmMain.wbMain.Navigate("http://addmefast.com/login/logout")
            wait(5000 * SpeedFactor)

            Return "True"

        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Shared Function Earn(ByVal lvitem As SocialList) As String
        Try
            Dim crd As String = Nothing

            FrmMain.wbMain.Navigate("http://addmefast.com/websites")
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

                If FrmMain.wbMain.Document.Body.InnerHtml.Contains("You will receive") Then
                    wait(30000)
                Else
                    FrmMain.wbMain.Navigate("http://addmefast.com/websites")
                    wait(5000 * SpeedFactor)
                End If

                If i = 10 Then
                    i = 0
                    FrmMain.wbMain.Navigate("http://addmefast.com/websites")
                    wait(5000 * SpeedFactor)
                Else
                    If Not FrmMain.wbMain.Url.ToString.Contains("addmefast") Then
                        FrmMain.wbMain.Navigate("http://addmefast.com/websites")
                    End If
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

    Public Shared Function EarnYoutube(ByVal lvitem As SocialList) As String
        Try
            Dim crd As String = Nothing

            FrmMain.wbMain.Navigate("http://addmefast.com/free_points/youtube_views")
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


                Dim elements As GeckoElementCollection = CType(FrmMain.wbMain.Document.GetElementsByTagName("a"), GeckoElementCollection)

                For Each ele As GeckoElement In elements
                    If ele.GetAttribute("class") = "single_like_button btn3-wrap" Then
                        Dim cele As GeckoInputElement = CType(ele, GeckoInputElement)
                        cele.Click()
                    End If
                Next


                'Dim test As GeckoNode = FrmMain.wbMain.Document.GetElementsByClassName("single_like_button btn3-wrap").First()
                'Dim ele As GeckoInputElement = CType(test, GeckoInputElement)
                'ele.Click()

                wait(30000)

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
            Dim elements As GeckoElementCollection = CType(FrmMain.wbMain.Document.GetElementsByTagName("span"), GeckoElementCollection)

            For Each ele As GeckoElement In elements
                If ele.GetAttribute("class") = "points_count" Then
                    Return ele.TextContent
                End If
            Next

        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

#End Region

End Class
