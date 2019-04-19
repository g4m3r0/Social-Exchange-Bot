Imports System.Net

Public Class RequestResponseList
    Implements IEquatable(Of RequestResponseList)
    Public Property Response As String
    Public Property CContainer As CookieContainer

    Public Function Equals1(other As RequestResponseList) As Boolean _
Implements IEquatable(Of RequestResponseList).Equals

        ' Check whether the compared object is null.
        If other Is Nothing Then Return False

        ' Check whether the compared object references the same data.
        If Me Is other Then Return True

        ' Check whether the products' properties are equal.
        Return Response.Equals(other.Response)
    End Function

    Public Overrides Function GetHashCode() As Integer

        ' Get the hash code for the Name field if it is not null.
        Dim hashProductName = Response.GetHashCode()

        ' Calculate the hash code for the product.
        Return hashProductName
    End Function
End Class
