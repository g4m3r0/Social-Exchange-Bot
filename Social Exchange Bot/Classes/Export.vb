Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class Export

    Public Function AccountsAll(aLi As List(Of SocialList)) As Object
        Dim bf As New BinaryFormatter()
        Try
            Dim fs As FileStream = New FileStream(Application.StartupPath & "\data\accounts.db", FileMode.Create)
            bf.Serialize(fs, aLi)
            fs.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        Return Nothing
    End Function

End Class
