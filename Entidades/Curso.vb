Public Class Curso
    Implements IEquatable(Of Curso)

    Public Property Nombre As String
    Public Property Asignaturas As List(Of Asignatura)
    Public Sub New(nombre As String)
        Me.Nombre = nombre
    End Sub
    Public Sub New(nombre As String, asignaturas As List(Of Asignatura))
        Me.Nombre = nombre
        Me.Asignaturas = asignaturas
    End Sub

    Public Overrides Function Equals(obj As Object) As Boolean
        Return Equals(TryCast(obj, Curso))
    End Function

    Public Overloads Function Equals(other As Curso) As Boolean Implements IEquatable(Of Curso).Equals
        Return other IsNot Nothing AndAlso
               Nombre = other.Nombre
    End Function
    Public Overrides Function ToString() As String
        Return $"{Nombre}"
    End Function

End Class
