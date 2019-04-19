Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Text.RegularExpressions
Imports Gecko
Imports Gecko.Collections
Imports Gecko.DOM

Public Class SocialExchangeScript
    Shared Property SpeedFactor As Integer = 1
    Shared Property URL As String


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

#Region "SocialExchangeScript"

    Public Shared Function Login(ByVal username As String, ByVal password As String, ByVal service As String) As String
        Try
            If service.StartsWith("http://") Then
                URL = service
            Else
                URL = "http://" + service
            End If

            FrmMain.wbMain.Navigate(URL & "/logout.php")
            wait(5000 * SpeedFactor)

            FrmMain.wbMain.Navigate(URL & "/index.php")
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

                Case FrmMain.wbMain.Document.Body.InnerHtml.Contains("Account Manager") Or FrmMain.wbMain.Document.Body.InnerHtml.Contains("Welcome")

                    Return "Login successful"

                Case Else

                    Return "Something went wrong"

            End Select

        Catch ex As Exception
            MsgBox(ex.ToString)
            Return ex.Message
        End Try
    End Function

    Public Shared Function Logout(ByVal service As String) As String
        Try
            If URL = Nothing Then
                If service.StartsWith("http://") Then
                    URL = service
                Else
                    URL = "http://" + service
                End If
            End If

            FrmMain.wbMain.Navigate(URL & "/logout.php")
            wait(5000 * SpeedFactor)

            Return "True"

        Catch ex As Exception
            MsgBox(ex.ToString)
            Return ex.Message
        End Try
    End Function

    Public Shared Function Earn(ByVal lvitem As SocialList) As String
        Try
            Dim crd As String = Nothing

            FrmMain.wbMain.Navigate(URL & "/surf.php")
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
            MsgBox(ex.ToString)
            Return ex.Message
        End Try
    End Function

    Public Shared Function GetCredits(ByVal doc As GeckoDocument) As String
        Try
            Dim elementWb As GeckoHtmlElement = Nothing
            elementWb = doc.GetHtmlElementById("c_coins")

            Dim tmpCredits As String = elementWb.NodeValue



            tmpCredits = tmpCredits.Split(CChar("|"))(0)
            Try
                tmpCredits = tmpCredits.Replace("Your coins: ", "")
            Catch ex As Exception
                tmpCredits = tmpCredits.Replace("Coins: ", "")
            End Try

            tmpCredits = tmpCredits.Replace(" ", "")

            Return tmpCredits
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return ex.Message
        End Try
    End Function

#End Region
End Class
