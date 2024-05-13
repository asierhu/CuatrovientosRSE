Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports Entidades
Public Class Gestion
    ' todo PROFESORADO Estamos en acceso conectado. Es decir, los datos están en la base de datos
    ' Cuando los necesitamos recurrimos allí para obtenerlos, y lo mismo al modificarlos
    Private _Agenda2030 As List(Of ODS)
    Private Const CADENA_CONEXION = "Data Source = .; Initial Catalog = CUATROVIENTOSRSE; Integrated Security = SSPI; MultipleActiveResultSets=true" ' Cadena de conexión para indicar la base de datos con la que vamos a conectar
    ' Private Const CADENA_CONEXION = "Data Source = 4V-PRO-948\SQLEXPRESS; Initial Catalog = CUATROVIENTOSRSE; Integrated Security = SSPI; MultipleActiveResultSets=true"
    Public ReadOnly Property Agenda2030 As ReadOnlyCollection(Of ODS)
        Get
            Return _Agenda2030.AsReadOnly ' todo PROFESORADO. Es aquí (o método) donde hay que leer de la BD. Y devolver posible error de ejecución (si no puede contactar con la bd) 
        End Get
    End Property
    Public Sub New() ' todo PROFESORADO Si se hiciese aquí, debería tener un parámetro ByRef para poder devolver posible error. PERO NO SE LEEN AQUÍ los ODS

        _Agenda2030 = New List(Of ODS)
        Dim conect As New SqlConnection(CADENA_CONEXION)
        Dim sql As String = "SELECT NUMERO_ODS, NOMBRE, DESCRIPCION FROM ODS"
        Try
            conect.Open()
            Dim cmdODS As New SqlCommand(sql, conect)
            Dim drODS As SqlDataReader = cmdODS.ExecuteReader
            While drODS.Read
                _Agenda2030.Add(New ODS(drODS("NUMERO_ODS"), drODS("NOMBRE"), drODS("DESCRIPCION")))
            End While
        Catch ex As Exception
            ' todo PROFESORADO Nunca (o casi) se debe dejar el Catch sin instrucciones
        Finally
            conect.Close()
        End Try
        RellenarMetasDeODS() ' todo ¿Aunque hubiese errores antes?
    End Sub
    Private Sub RellenarMetasDeODS()

        Dim conect As New SqlConnection(CADENA_CONEXION)
        Dim sql As String = "SELECT METAS.NUMERO_ODS,METAS.CARACTER_META,METAS.DESCRIPCION FROM METAS"
        Try
            conect.Open()
            Dim cmdMeta As New SqlCommand(sql, conect)
            Dim drODS As SqlDataReader
            drODS = cmdMeta.ExecuteReader
            While drODS.Read
                _Agenda2030(_Agenda2030.IndexOf(New ODS(drODS("NUMERO_ODS")))).Metas.Add(New Meta(drODS("NUMERO_ODS"), drODS("CARACTER_META"), drODS("DESCRIPCION")))
            End While
        Catch ex As Exception

        Finally
            conect.Close()
        End Try
    End Sub
    Public Function ModificarODS(odsModificado As ODS) As String
        Dim cambios As Boolean = False
        Dim odsGuardado As ODS = _Agenda2030(_Agenda2030.IndexOf(odsModificado))
        If Not odsModificado.Nombre.ToLower = odsGuardado.Nombre.ToLower Then
            If odsModificado.Nombre.Contains("*") Then
                Return "El nombre del ODS no puede contener el caracter '*'" ' todo PROFESORADO ¿Qué sentido tiene preguntar si contiene *?
            End If
            cambios = True
            odsGuardado.Nombre = odsModificado.Nombre
        End If
        If Not odsModificado.Descripcion.ToLower = odsGuardado.Descripcion.ToLower Then ' todo LO mismo
            If odsModificado.Descripcion.Contains("*") Then
                Return "La descripción del ODS no puede contener el caracter '*'"
            End If
            cambios = True
            odsGuardado.Descripcion = odsModificado.Descripcion
        End If
        If Not odsModificado.Imagen.ToLower = odsGuardado.Imagen.ToLower Then ' todo ¿??
            If odsModificado.Imagen.Contains("*") Then
                Return "La dirección de la imagen no puede contener el caracter '*'"
            End If
            cambios = True
            odsGuardado.Descripcion = odsModificado.Descripcion
        End If
        If Not cambios Then
            Return "No has hecho cambios"
        End If
        Return "" ' todo PROFESORADO Los cambios se almacenan en memoria, pero no en la BD
    End Function
    Public Function ModificarMeta(metaModificada As Meta) As String
        Dim cambios As Boolean = False
        Dim odsAux As ODS = _Agenda2030(_Agenda2030.IndexOf(New ODS(metaModificada.NumeroODS)))
        Dim indiceMetaODS As Integer = odsAux.Metas.IndexOf(New Meta(metaModificada.NumeroODS, metaModificada.IDMeta))
        Dim metaGuardada As Meta = odsAux.Metas(indiceMetaODS) ' todo PROFESORADO ERROR de ejecución por el Equals de Meta
        If Not metaModificada.IDMeta.ToLower = metaGuardada.IDMeta.ToLower Then
            If metaModificada.IDMeta.Contains("*") Then ' todo Otra vez lo mismo que en ODS....
                Return "El identificador de una meta no puede contener el caracter '*'"
            End If
            cambios = True
            metaGuardada.IDMeta = metaModificada.IDMeta
        End If
        If Not metaModificada.Descripcion.ToLower = metaGuardada.Descripcion.ToLower Then
            If metaModificada.Descripcion.Contains("*") Then
                Return "La descripción de la meta no puede contener el caracter '*'"
            End If
            cambios = True
            metaGuardada.Descripcion = metaModificada.Descripcion
        End If
        If Not cambios Then
            Return "No has hecho cambios"
        End If
        _Agenda2030(_Agenda2030.IndexOf(New ODS(metaModificada.NumeroODS))) = odsAux
        Return ""
        ' todo Otra vez lo mismo que en ODS....
    End Function
    Public Function AnyadirMeta(meta As Meta) As String
        Dim odsGuardado As ODS = _Agenda2030(meta.NumeroODS - 1)
        Dim indiceMeta As Integer = odsGuardado.Metas.IndexOf(New Meta(meta.NumeroODS, meta.IDMeta))
        For i = 0 To odsGuardado.Metas.Count - 1 ' todo PROFESORADO Si Equals estuviese bien, valdría con Contains de odsGuardado.Metas.Contains 
            If odsGuardado.Metas(i).Equals(meta) Then ' todo No funciona por estar mal Equals
                indiceMeta = i
                Exit For
            End If
        Next
        If indiceMeta <> -1 Then
            Return $"La meta {meta.ToString} ya existía en {odsGuardado.Nombre}"
        End If
        If meta.Descripcion.Contains("*") Then ' todo De nuevo....
            Return $"La descripcion de la nueva meta {meta.ToString(True)} no puede contener el caracter '*'"
        End If
        odsGuardado.Metas.Add(meta)
        Return ""
    End Function
    Public Function VerMetasDeODS(numODS As Byte, ByRef msgError As String) As ReadOnlyCollection(Of Meta)
        Dim metas As New List(Of Meta)
        Dim conect As New SqlConnection(CADENA_CONEXION)
        Dim sql As String = "SELECT METAS.NUMERO_ODS,METAS.CARACTER_META,METAS.DESCRIPCION FROM METAS WHERE METAS.NUMERO_ODS=@NumODS"
        Try
            conect.Open()
            Dim cmdMeta As New SqlCommand(sql, conect)
            cmdMeta.Parameters.AddWithValue("@NumODS", numODS)
            Dim drMetas As SqlDataReader = cmdMeta.ExecuteReader
            If Not drMetas.HasRows Then
                msgError = "Este ODS no tiene metas registradas" ' todo PROFESORADO No tiene sentido que entonces continúe
            End If
            While drMetas.Read
                metas.Add(New Meta(drMetas("NUMERO_ODS"), drMetas("CARACTER_META"), drMetas("DESCRIPCION")))
            End While
        Catch ex As Exception
            msgError = ex.Message
        Finally
            conect.Close()
        End Try
        Return metas.AsReadOnly
    End Function
    'Dim metaODSGuardado As Meta
    'For i = 0 To nuevoODS.Metas.Count - 1
    'Dim metaODSNuevo As Meta = nuevoODS.Metas(i)
    '        metaODSGuardado = odsGuardado.Metas(i)
    '        If metaODSNuevo.Descripcion.Contains("*") Then
    'Return $"La descripcion de la meta {metaODSNuevo.ToString(True)} no puede contener el caracter '*'"
    'End If
    'If Not metaODSNuevo.Descripcion.ToLower = metaODSGuardado.Descripcion.ToLower Then
    '            cambios = True
    '            metaODSGuardado.Descripcion = metaODSNuevo.Descripcion
    '        End If
    'Next

End Class
