Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports Entidades
Public Class Gestion
    Private _Agenda2030 As List(Of ODS)
    Private Const CADENA_CONEXION = "Data Source = .; Initial Catalog = CUATROVIENTOSRSE; Integrated Security = SSPI; MultipleActiveResultSets=true" ' Cadena de conexión para indicar la base de datos con la que vamos a conectar

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
            metaODSGuardado = odsGuardado.Metas(i)
            If metaODSNuevo.Descripcion.Contains("*") Then
                Return $"La descripcion de la meta {metaODSNuevo.ToString(True)} no puede contener el caracter '*'"
            End If
            If Not metaODSNuevo.Descripcion.ToLower = metaODSGuardado.Descripcion.ToLower Then
                cambios = True
                metaODSGuardado.Descripcion = metaODSNuevo.Descripcion
            End If
        Next
        If Not cambios Then
            Return "No has hecho cambios"
        End If
        Return ""
    End Function
    Public Function AnyadirMeta(meta As Meta) As String
        Dim odsGuardado As ODS = _Agenda2030(meta.NumeroODS - 1)
        Dim indiceMeta As Integer = odsGuardado.Metas.IndexOf(meta)
        If indiceMeta <> -1 Then
            Return $"La meta {odsGuardado.Metas(indiceMeta).ToString(True)} ya existía en {odsGuardado.Nombre}"
        End If
        If meta.Descripcion.Contains("*") Then
            Return $"La descripcion de la nueva meta {meta.ToString(True)} no puede contener el caracter '*'"
        End If
        odsGuardado.Metas.Add(meta)
        Return ""
    End Function
    Public Function VerMetasDeODS(numODS As Byte, ByRef msgError As String) As ReadOnlyCollection(Of Meta)
        Dim metas As List(Of Meta)
        Dim conect As New SqlConnection(CADENA_CONEXION)
        Dim cmdProv As New SqlCommand("SELECT METAS.NUMERO_ODS FROM METAS", conect)
        Try
            conect.Open()
            Dim drProvincias As SqlDataReader = cmdProv.ExecuteReader
            If Not drProvincias.HasRows Then
                msgError = "No hay provincias"
            End If
            While drProvincias.Read
                metas.Add(New Meta())
            End While
        Catch ex As Exception
            msgError = ex.Message
        Finally
            conect.Close()
        End Try
        Return metas.AsReadOnly

    End Function

End Class
