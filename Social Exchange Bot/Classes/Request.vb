Imports System.IO
Imports System.Net
Imports System.Text

Public Class Request

    Public Shared Function PostRequest(ByVal data As String, ByVal url As String, ByVal referer As String, ByVal useragent As String, ByVal accept As String, ByVal contenttype As String, ByRef ccontainer As CookieContainer, ByVal timeout As Integer) As String
        Dim serverResponse As String = ""
        Try


            Dim byteArray As Byte() = Encoding.UTF8.GetBytes(data)
            Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
            request.CookieContainer = ccontainer
            request.Method = "POST"
            request.UserAgent = useragent
            request.Referer = referer
            request.Accept = accept
            request.KeepAlive = True
            request.ContentType = contenttype
            request.Timeout = timeout


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

End Class
