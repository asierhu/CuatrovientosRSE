Public Class Profesor
    Implements IEquatable(Of Profesor)

    Public Property IdProfesor As Integer
    Public Property Nombre As String
    Public Property Apellido1 As String
    Public Property Apellido2 As String
    Public Property FechaNacimiento As Date
    Public Sub New(idProfesor As String)
        Me.IdProfesor = idProfesor
    End Sub
    Public Sub New(idProfesor As Integer, nombre As String, apellido1 As String, apellido2 As String, fechaNacimiento As Date)
        Me.IdProfesor = idProfesor
        Me.Nombre = nombre
        Me.Apellido1 = apellido1
        Me.Apellido2 = apellido2
        Me.FechaNacimiento = fechaNacimiento
    End Sub

    Public Overrides Function Equals(obj As Object) As Boolean
        Return Equals(TryCast(obj, Profesor))
    End Function

    Public Overloads Function Equals(other As Profesor) As Boolean Implements IEquatable(Of Profesor).Equals
        Return other IsNot Nothing AndAlso
               IdProfesor = other.IdProfesor
    End Function

    Public Overrides Function ToString() As String
        Return $"{Apellido1} {Apellido2},{Nombre}"
    End Function
End Class
