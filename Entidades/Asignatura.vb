Public Class Asignatura
    Implements IEquatable(Of Asignatura)
    Public Property Nombre As String
    Public Property CodAsignatura As Integer
    Public Sub New(codAsignatura As Integer)
        Me.CodAsignatura = codAsignatura
    End Sub
    Public Sub New(codAsignatura As Integer, nombreAsignatura As String)
        Me.CodAsignatura = codAsignatura
        Me.Nombre = nombreAsignatura
    End Sub

    Public Overrides Function Equals(obj As Object) As Boolean
        Return Equals(TryCast(obj, Asignatura))
    End Function

    Public Overloads Function Equals(other As Asignatura) As Boolean Implements IEquatable(Of Asignatura).Equals
        Return other IsNot Nothing AndAlso
               CodAsignatura = other.CodAsignatura
    End Function
    Public Overrides Function ToString() As String
        Return $"{Nombre}"
    End Function

End Class
