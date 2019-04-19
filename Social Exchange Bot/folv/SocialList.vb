<System.Serializable()>
Public Class SocialList
    Implements IEquatable(Of SocialList)
    Public Property Service As String
    Public Property Username As String
    Public Property Password As String
    Public Property Proxy As String
    Public Property Port As Integer
    Public Property Credits As String
    Public Property Status As String

    Public Function Equals1(other As SocialList) As Boolean _
Implements IEquatable(Of SocialList).Equals

        ' Check whether the compared object is null.
        If other Is Nothing Then Return False

        ' Check whether the compared object references the same data.
        If Me Is other Then Return True

        ' Check whether the products' properties are equal.
        Return Service.Equals(other.Service) AndAlso Username.Equals(other.Username)
    End Function

    Public Overrides Function GetHashCode() As Integer

        ' Get the hash code for the Name field if it is not null.
        Dim hashProductName = Service.GetHashCode()

        ' Get the hash code for the Code field.
        Dim hashProductCode = Username.GetHashCode()

        ' Calculate the hash code for the product.
        Return hashProductName Xor hashProductCode
    End Function

End Class
