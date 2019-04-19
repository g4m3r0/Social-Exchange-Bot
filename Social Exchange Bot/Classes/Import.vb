Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class Import
    Public Function AccountAll(importPath As String) As List(Of SocialList)

        Dim bf As New BinaryFormatter()
        Dim liObjects As New List(Of SocialList)
        Dim fsRead As FileStream

        Try
            If My.Computer.FileSystem.FileExists(importPath) Then
                fsRead = New FileStream(importPath, FileMode.Open)
                liObjects = CType(bf.Deserialize(fsRead), List(Of SocialList))
                fsRead.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        Return liObjects
    End Function

End Class
