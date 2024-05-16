Imports System.Collections.ObjectModel

Public Class Iniciativa
    Implements IEquatable(Of Iniciativa)

    Public Property CodIniciativa As Integer
    Public Property Contratantes As ReadOnlyCollection(Of Contratante)
    Public Property Metas As ReadOnlyCollection(Of Meta)
    Public Property Profesores As ReadOnlyCollection(Of Profesor)
    Public Property Asignaturas As ReadOnlyCollection(Of Asignatura)
    Public Property Horas As Integer
    Public Property Titulo As String
    Public Property FechaInicio As Date
    Public Property FechaFin As Date
    Public Sub New(codIniciativa As Integer)
        Me.CodIniciativa = codIniciativa
    End Sub
    Public Sub New(codIniciativa As Integer, contratantes As ReadOnlyCollection(Of Contratante), metas As ReadOnlyCollection(Of Meta), profesores As ReadOnlyCollection(Of Profesor), asignaturas As ReadOnlyCollection(Of Asignatura), horas As Integer, titulo As String, fechaInicio As Date, fechaFin As Date)
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

    Public Sub New(contratantes As ReadOnlyCollection(Of Contratante), metas As ReadOnlyCollection(Of Meta), profesores As ReadOnlyCollection(Of Profesor), asignaturas As ReadOnlyCollection(Of Asignatura), horas As Integer, titulo As String, fechaInicio As Date, fechaFin As Date)
        Me.Contratantes = contratantes
        Me.Metas = metas
        Me.Profesores = profesores
        Me.Asignaturas = asignaturas
        Me.Horas = horas
        Me.Titulo = titulo
        Me.FechaInicio = fechaInicio
        Me.FechaFin = fechaFin
    End Sub
    Public Sub New(contratantes As ReadOnlyCollection(Of Contratante), metas As ReadOnlyCollection(Of Meta), profesores As ReadOnlyCollection(Of Profesor), asignaturas As ReadOnlyCollection(Of Asignatura), horas As Integer, titulo As String, fechaInicio As Date)
        Me.Contratantes = contratantes
        Me.Metas = metas
        Me.Profesores = profesores
        Me.Asignaturas = asignaturas
        Me.Horas = horas
        Me.Titulo = titulo
        Me.FechaInicio = fechaInicio
        Me.FechaFin = Nothing
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
