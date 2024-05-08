Public Class Iniciativa
    Implements IEquatable(Of Iniciativa)

    Public Property CodIniciativa As Integer
    Public Property Contratantes As List(Of Contratante)
    Public Property Metas As List(Of Meta)
    Public Property Profesores As List(Of Profesor)
    Public Property Asignaturas As List(Of Asignatura)
    Public Property Horas As Integer
    Public Property Titulo As String
    Public Property FechaInicio As Date
    Public Property FechaFin As Date
    Public Sub New(codIniciativa As Integer)
        Me.CodIniciativa = codIniciativa
    End Sub

    Public Sub New(codIniciativa As Integer, contratantes As List(Of Contratante), metas As List(Of Meta), profesores As List(Of Profesor), asignaturas As List(Of Asignatura), horas As Integer, titulo As String, fechaInicio As Date, fechaFin As Date)
        Me.CodIniciativa = codIniciativa
        Me.Contratantes = contratantes
        Me.Metas = metas
        Me.Profesores = profesores
        Me.Asignaturas = asignaturas
        Me.Horas = horas
        Me.Titulo = titulo
        Me.FechaInicio = fechaInicio
        Me.FechaFin = fechaFin
    End Sub

    Public Overrides Function Equals(obj As Object) As Boolean
        Return Equals(TryCast(obj, Iniciativa))
    End Function

    Public Overloads Function Equals(other As Iniciativa) As Boolean Implements IEquatable(Of Iniciativa).Equals
        Return other IsNot Nothing AndAlso
               CodIniciativa = other.CodIniciativa
    End Function

    Public Overrides Function ToString() As String
        Return $"{Titulo}"
    End Function

End Class
