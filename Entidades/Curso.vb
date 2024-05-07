Public Class Curso
    Public Property NombreCurso As String
    Public Property Asignaturas As List(Of Asignatura)
    Public Sub New(nombreCurso As String)
        Me.NombreCurso = nombreCurso
    End Sub
    Public Sub New(nombreCurso As String, asignaturas As List(Of Asignatura))
        Me.NombreCurso = nombreCurso
        Me.Asignaturas = asignaturas
    End Sub

End Class
