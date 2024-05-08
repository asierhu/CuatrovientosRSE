Public Class Meta
    Implements IEquatable(Of Meta)

    Public Property NumeroODS As Byte
    Public Property IDMeta As String
    Public Property Descripcion As String

    Public Overrides Function ToString() As String
        Return $"{NumeroODS}.{IDMeta}"
    End Function
    Public Sub New(numeroODS As Byte, idMeta As String)
        Me.NumeroODS = numeroODS
        Me.IDMeta = idMeta
        Me.Descripcion = ""
    End Sub
    Public Sub New(numeroODS As Byte, idMeta As String, descripcion As String)
        Me.NumeroODS = numeroODS
        Me.IDMeta = idMeta
        Me.Descripcion = descripcion
    End Sub
    Public Overrides Function Equals(obj As Object) As Boolean
        Return Equals(TryCast(obj, Meta))
    End Function

    Public Overloads Function Equals(other As Meta) As Boolean Implements IEquatable(Of Meta).Equals
        Return other IsNot Nothing AndAlso
               NumeroODS = other.NumeroODS AndAlso
               (IDMeta = other.IDMeta + " " OrElse IDMeta = other.IDMeta)
    End Function

End Class
