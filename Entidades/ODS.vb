Imports System.Collections.ObjectModel

Public Class ODS
    Implements IEquatable(Of ODS)

    Public Property NumeroODS As Byte
    Public Property Nombre As String
    Public Property Descripcion As String
    Public Property Imagen As String
    Public Sub New()

    End Sub
    Public Sub New(numeroODS As Byte)
        Me.NumeroODS = numeroODS
        Me.Nombre = ""
        Me.Descripcion = ""
        Me.Imagen = $"{numeroODS}.jpg"
    End Sub

    Public Sub New(numeroODS As Byte, nombre As String, descripcion As String)
        Me.NumeroODS = numeroODS
        Me.Nombre = nombre
        Me.Descripcion = descripcion
        Me.Imagen = $"{numeroODS}.jpg"
    End Sub
    Public Sub New(numeroODS As Byte, nombre As String, descripcion As String, imagen As String)
        Me.NumeroODS = numeroODS
        Me.Nombre = nombre
        Me.Descripcion = descripcion
        Me.Imagen = imagen
    End Sub

    Public Overrides Function Equals(obj As Object) As Boolean
        Return Equals(TryCast(obj, ODS))
    End Function

    Public Overloads Function Equals(other As ODS) As Boolean Implements IEquatable(Of ODS).Equals
        Return other IsNot Nothing AndAlso
               NumeroODS = other.NumeroODS
    End Function
    Public Overrides Function ToString() As String
        Return $"{NumeroODS}: {Nombre}"
    End Function
End Class