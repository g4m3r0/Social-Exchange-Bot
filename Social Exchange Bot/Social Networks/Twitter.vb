Imports System.Net

Public Class Twitter

    Shared _ccTwitter As CookieContainer
    Shared _authToken As String

    Shared _email As String
    Shared _password As String

    Public Sub New(ByVal email As String, ByVal password As String)
        _email = email
        _password = password
    End Sub


    Shared Function Login() As String
        Dim data As String = "/logout?authenticity_token=" & _authToken & "&reliability_event=&scribe_log="
        Dim response As String = Nothing

        response = Request.PostRequest(data, "http://twitter.com", "http://twitter.com", "Mozilla/5.0 (Windows NT 6.3; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/43.0.2357.134 Safari/537.36", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8", "application/x-www-form-urlencoded", _ccTwitter, 30000)

        Return response
    End Function

    Shared Function Logout() As String


        'get auth token
        _authToken = ""
        _ccTwitter = Nothing


        'post login
        Dim data As String = "/sessions?session%5Busername_or_email%5D=" & _email & "&session%5Bpassword%5D=" & _password & "&remember_me=1&return_to_ssl=false&scribe_log=&redirect_after_login=%2F&authenticity_token=" & _authToken
        Dim response As String = Nothing

        response = Request.PostRequest(data, "http://twitter.com", "http://twitter.com", "Mozilla/5.0 (Windows NT 6.3; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/43.0.2357.134 Safari/537.36", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8", "application/x-www-form-urlencoded", _ccTwitter, 30000)

        Return response
    End Function

    Shared Function Follow() As String


        'get auth token /intent/user?screen_name=PhentermineWeb
        _authToken = ""
        _ccTwitter = Nothing
        Dim screenName As String = Nothing
        Dim profileID As String = Nothing


        'post follow
        Dim data As String = "/intent/follow?screen_name=" & screenName & "&authenticity_token=" & _authToken & "&screen_name=" & screenName & "&profile_id=" & profileID
        Dim response As String = Nothing

        response = Request.PostRequest(data, "http://twitter.com", "http://twitter.com", "Mozilla/5.0 (Windows NT 6.3; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/43.0.2357.134 Safari/537.36", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8", "application/x-www-form-urlencoded", _ccTwitter, 30000)

        Return response
    End Function

End Class
