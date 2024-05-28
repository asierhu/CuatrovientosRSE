Public Class Contratante
    Implements IEquatable(Of Contratante)

    Public Property CodContratante As Integer
    Public Property Nombre As String
    Public Property Descripcion As String
    Public Sub New(codContratante As Integer)
        Me.CodContratante = codContratante
    End Sub
    Public Sub New(codContratante As Integer, nombre As String, descripcion As String)
        Me.New(codContratante)
        Me.Nombre = nombre
        Me.Descripcion = descripcion
    End Sub
    Public Overrides Function Equals(obj As Object) As Boolean
        Return Equals(TryCast(obj, Contratante))
    End Function

    Public Overloads Function Equals(other As Contratante) As Boolean Implements IEquatable(Of Contratante).Equals
        Return other IsNot Nothing AndAlso
               CodContratante = other.CodContratante
    End Function
    Public Overrides Function ToString() As String
        Return $"{Nombre}"
    End Function

End Class
