Imports System.Collections.ObjectModel
Imports Entidades
Public Class Gestion
    Private _Agenda2030 As List(Of ODS)
    Public ReadOnly Property Agenda2030 As ReadOnlyCollection(Of ODS)
        Get
            Return _Agenda2030.AsReadOnly
        End Get
    End Property
    Public Sub New()
        _Agenda2030 = New List(Of ODS)
    End Sub
    Public Function ModificarODS(nuevoODS As ODS) As String
        Dim numODS As Byte = nuevoODS.NumeroODS
        Dim cambios As Boolean = False
        If Not (numODS > 0 AndAlso numODS <= 17) Then
            Return $"El ODS número {numODS} no existe"
        End If
        Dim odsGuardado As ODS = _Agenda2030(_Agenda2030.IndexOf(nuevoODS))
        If nuevoODS.Nombre.Contains("*") Then
            Return "El nombre del ODS no puede contener el caracter '*'"
        End If
        If Not nuevoODS.Nombre.ToLower = odsGuardado.Nombre.ToLower Then
            cambios = True
            odsGuardado.Nombre = nuevoODS.Nombre
        End If
        If nuevoODS.Descripcion.Contains("*") Then
            Return "La descripción del ODS no puede contener el caracter '*'"
        End If
        If Not nuevoODS.Descripcion.ToLower = odsGuardado.Descripcion.ToLower Then
            cambios = True
            odsGuardado.Descripcion = nuevoODS.Descripcion
        End If
        Dim metaODSGuardado As Meta
        For i = 0 To nuevoODS.Metas.Count - 1
            Dim metaODSNuevo As Meta = nuevoODS.Metas(i)
            If odsGuardado.Metas(i) IsNot Nothing Then
                metaODSGuardado = odsGuardado.Metas(i)
                If metaODSNuevo.Descripcion.Contains("*") Then
                    Return $"La descripcion de la meta {metaODSNuevo.ToString(True)} no puede contener el caracter '*'"
                End If
                If Not metaODSNuevo.Descripcion.ToLower = metaODSGuardado.Descripcion.ToLower Then
                    cambios = True
                    metaODSGuardado.Descripcion = metaODSNuevo.Descripcion
                End If
            Else
                Dim indiceMeta As Integer = odsGuardado.Metas.IndexOf(metaODSNuevo)
                If indiceMeta <> -1 Then
                    Return $"La meta {odsGuardado.Metas(indiceMeta).ToString(True)} ya existía en {odsGuardado.Nombre}"
                End If
                If metaODSNuevo.Descripcion.Contains("*") Then
                    Return $"La descripcion de la nueva meta {nuevoODS.Metas(i).ToString(True)} no puede contener el caracter '*'"
                End If
                odsGuardado.Metas.Add(New Meta(numODS, metaODSNuevo.IDMeta, metaODSNuevo.Descripcion))
            End If
        Next
        If Not cambios Then
            Return "No has hecho cambios"
        End If
        Return ""
    End Function

End Class
