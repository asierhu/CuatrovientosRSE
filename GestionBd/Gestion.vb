Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports Entidades
Public Class Gestion

    Private Iniciativas As List(Of Iniciativa)
    Private Profesores As List(Of Profesor)
    Private Contratantes As List(Of Contratante)
    Private Cursos As List(Of Curso)
    Private Const CADENA_CONEXION = "Data Source = .; Initial Catalog = CUATROVIENTOSRSE; Integrated Security = SSPI; MultipleActiveResultSets=true" ' Cadena de conexión para indicar la base de datos con la que vamos a conectar

    Public Function ODSEnBaseDeDatos(ByRef msgError As String) As ReadOnlyCollection(Of ODS)
        Dim ods = New List(Of ODS)
        Dim conect As New SqlConnection(CADENA_CONEXION)
        Dim sql As String = "SELECT NUMERO_ODS, NOMBRE, DESCRIPCION FROM ODS"
        Try
            conect.Open()
            Dim cmdODS As New SqlCommand(sql, conect)
            Dim drODS As SqlDataReader = cmdODS.ExecuteReader
            While drODS.Read
                ods.Add(New ODS(drODS("NUMERO_ODS"), drODS("NOMBRE"), drODS("DESCRIPCION")))
            End While
        Catch ex As Exception
            msgError = ex.Message
        Finally
            conect.Close()
        End Try
        Return ods.AsReadOnly
    End Function
    Public Function VerMetasDeODS(numODS As Byte, ByRef msgError As String) As ReadOnlyCollection(Of Meta)
        Dim metas As New List(Of Meta)
        Dim conect As New SqlConnection(CADENA_CONEXION)
        Dim sql As String = "SELECT NUMERO_ODS, CARACTER_META, DESCRIPCION FROM METAS WHERE METAS.NUMERO_ODS=@NumODS"
        Try
            conect.Open()
            Dim cmdMeta As New SqlCommand(sql, conect)
            cmdMeta.Parameters.AddWithValue("@NumODS", numODS)
            Dim drMetas As SqlDataReader = cmdMeta.ExecuteReader
            If Not drMetas.HasRows Then
                msgError = "Este ODS no tiene metas registradas"
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
    Public Function CursosEnBaseDeDatos(ByRef msgError As String) As ReadOnlyCollection(Of Curso)
        Dim cursos = New List(Of Curso)
        Dim conect As New SqlConnection(CADENA_CONEXION)
        Dim sql As String = "SELECT NOMBRE_CURSO FROM CURSO"
        Try
            conect.Open()
            Dim cmdODS As New SqlCommand(sql, conect)
            Dim drODS As SqlDataReader = cmdODS.ExecuteReader
            While drODS.Read
                cursos.Add(New Curso(drODS("NOMBRE_CURSO")))
            End While
        Catch ex As Exception
            msgError = ex.Message
        Finally
            conect.Close()
        End Try
        Return cursos.AsReadOnly
    End Function

    Private Function VerAsignaturasDeCurso(nombreCurso As String, ByRef msgError As String) As ReadOnlyCollection(Of Asignatura)
        Dim asignaturasDeCurso As New List(Of Asignatura)
        Dim conect As New SqlConnection(CADENA_CONEXION)
        Dim sql As String = "SELECT COD_ASIGNATURA, NOMBRE_ASIGNATURA FROM ASIGNATURA WHERE ASIGNATURA.NOMBRE_CURSO = @NOMBRECURSO"
        Try
            conect.Open()
            Dim cmdAsignatura As New SqlCommand(sql, conect)
            cmdAsignatura.Parameters.AddWithValue("@NOMBRECURSO", nombreCurso)
            Dim drAsignaturas As SqlDataReader = cmdAsignatura.ExecuteReader
            If Not drAsignaturas.HasRows Then
                msgError = "Este ODS no tiene metas registradas"
            End If
            While drAsignaturas.Read
                asignaturasDeCurso.Add(New Asignatura(drAsignaturas("COD_ASIGNATURA"), drAsignaturas("NOMBRE_ASIGNATURA")))
            End While
        Catch ex As Exception
            msgError = ex.Message
        Finally
            conect.Close()
        End Try
        Return asignaturasDeCurso.AsReadOnly
    End Function
    Public Function ContratantesEnBaseDeDatos(ByRef msgError As String) As ReadOnlyCollection(Of Contratante)
        Dim contratantes = New List(Of Contratante)
        Dim conect As New SqlConnection(CADENA_CONEXION)
        Dim sql As String = "SELECT COD_CONTRATANTE, NOMBRE_CONTRATANTE, DESCRIPCION FROM CONTRATANTE"
        Try
            conect.Open()
            Dim cmdODS As New SqlCommand(sql, conect)
            Dim drODS As SqlDataReader = cmdODS.ExecuteReader
            While drODS.Read
                contratantes.Add(New Contratante(drODS("COD_CONTRATANTE"), drODS("NOMBRE_CONTRATANTE"), drODS("DESCRIPCION")))
            End While
        Catch ex As Exception
            msgError = ex.Message
        Finally
            conect.Close()
        End Try
        Return contratantes.AsReadOnly
    End Function
    Public Function ProfesoresEnBaseDeDatos(ByRef msgError As String) As ReadOnlyCollection(Of Profesor)
        Dim profesores = New List(Of Profesor)
        Dim conect As New SqlConnection(CADENA_CONEXION)
        Dim sql As String = "SELECT ID_PROFESOR, NOMBRE_PROFESOR, APELLIDO1, APELLIDO2, FECHA_NACIMIENTO FROM PROFESORES"
        Try
            conect.Open()
            Dim cmdODS As New SqlCommand(sql, conect)
            Dim drODS As SqlDataReader = cmdODS.ExecuteReader
            While drODS.Read
                profesores.Add(New Profesor(drODS("ID_PROFESOR"), drODS("NOMBRE_PROFESOR"), drODS("APELLIDO1"), drODS("APELLIDO2"), drODS("FECHA_NACIMIENTO")))
            End While
        Catch ex As Exception
            msgError = ex.Message
        Finally
            conect.Close()
        End Try
        Return profesores.AsReadOnly
    End Function
    Public Function ModificarODS(odsModificado As ODS) As String
        Dim msgError As String = ""
        Dim ods As ReadOnlyCollection(Of ODS) = ODSEnBaseDeDatos(msgError)
        Dim odsGuardado As ODS = ods(ods.IndexOf(odsModificado))
        If msgError <> "" Then
            Return msgError
        End If
        Dim nuevoNombre As String = ""
        If Not odsModificado.Nombre.ToLower = odsGuardado.Nombre.ToLower Then
            If odsModificado.Nombre.Contains("*") Then
                Return "El nombre del ODS no puede contener el caracter '*'"
            End If
            nuevoNombre = odsModificado.Nombre
        End If
        Dim nuevaDesc As String = ""
        If Not odsModificado.Descripcion.ToLower = odsGuardado.Descripcion.ToLower Then
            If odsModificado.Descripcion.Contains("*") Then
                Return "La descripción del ODS no puede contener el caracter '*'"
            End If
            nuevaDesc = odsModificado.Descripcion
        End If
        Dim nuevaImg As String = ""
        If Not odsModificado.Imagen.ToLower = odsGuardado.Imagen.ToLower Then
            If odsModificado.Imagen.Contains("*") Then
                Return "La dirección de la imagen no puede contener el caracter '*'"
            End If
            nuevaImg = odsModificado.Imagen
        End If

        Dim conect As New SqlConnection(CADENA_CONEXION)
        Dim sql As String = "UPDATE ODS SET "
        If nuevoNombre <> "" Then
            sql += "NOMBRE=@NUEVONOMBRE"
        End If
        If nuevaDesc <> "" Then
            If sql.EndsWith("@NUEVONOMBRE") Then
                sql += ", "
            End If
            sql += "DESCRIPCION=@NUEVADESC"
        End If
        If nuevaImg <> "" Then
            If sql.EndsWith("@NUEVONOMBRE") OrElse sql.EndsWith("@NUEVADESC") Then
                sql += ", "
            End If
            sql += "IMAGEN=@NUEVAIMAGEN"
        End If
        If sql = "UPDATE ODS SET " Then
            Return "No has hecho cambios"
        Else
            sql += " WHERE NUMERO_ODS=@NUMODS"
        End If
        Try
            conect.Open()
            Dim cmdODS As New SqlCommand(sql, conect)
            If sql.Contains("@NUEVONOMBRE") Then
                cmdODS.Parameters.AddWithValue("@NUEVONOMBRE", nuevoNombre)
            End If
            If sql.Contains("@NUEVADESC") Then
                cmdODS.Parameters.AddWithValue("@NUEVADESC", nuevaDesc)
            End If
            If sql.Contains("@NUEVAIMAGEN") Then
                cmdODS.Parameters.AddWithValue("@NUEVAIMAGEN", nuevaImg)
            End If
            cmdODS.ExecuteNonQuery()
        Catch ex As Exception
            msgError = ex.Message
        Finally
            conect.Close()
        End Try
        Return ""
    End Function
    Public Function ModificarMeta(metaModificada As Meta, caracterAnterior As String) As String
        Dim msgError As String = ""
        Dim metas As ReadOnlyCollection(Of Meta) = VerMetasDeODS(metaModificada.NumeroODS, msgError)
        Dim metaGuardada As Meta = metas(metas.IndexOf(New Meta(metaModificada.NumeroODS, caracterAnterior)))
        Dim nuevaID As String = ""
        If Not metaModificada.IDMeta.ToLower = metaGuardada.IDMeta.ToLower Then
            If metaModificada.IDMeta.Contains("*") Then
                Return "El identificador de una meta no puede contener el caracter '*'"
            End If
            nuevaID = metaModificada.IDMeta
        End If
        Dim nuevaDesc As String = ""
        If Not metaModificada.Descripcion.ToLower = metaGuardada.Descripcion.ToLower Then
            If metaModificada.Descripcion.Contains("*") Then
                Return "La descripción de la meta no puede contener el caracter '*'"
            End If
            nuevaDesc = metaModificada.Descripcion
        End If
        'UPDATE
        Dim conect As New SqlConnection(CADENA_CONEXION)
        Dim sql As String = "UPDATE METAS SET "
        If nuevaID <> "" Then
            sql += "CARACTER_META=@NUEVAID"
        End If
        If nuevaDesc <> "" Then
            If sql.EndsWith("@NUEVAID") Then
                sql += ", "
            End If
            sql += "DESCRIPCION=@NUEVADESC"
        End If
        If sql = "UPDATE METAS SET " Then
            Return "No has hecho cambios"
        Else
            sql += " WHERE NUMERO_ODS=@NUMODS AND CARACTER_META=@IDANTERIOR"
        End If
        Try
            conect.Open()
            Dim cmdODS As New SqlCommand(sql, conect)
            If sql.Contains("@NUEVAID") Then
                cmdODS.Parameters.AddWithValue("@NUEVAID", nuevaID)
            End If
            If sql.Contains("@NUEVADESC") Then
                cmdODS.Parameters.AddWithValue("@NUEVADESC", nuevaDesc)
            End If
            cmdODS.Parameters.AddWithValue("@NUMODS", metaGuardada.NumeroODS)
            cmdODS.Parameters.AddWithValue("@IDANTERIOR", caracterAnterior)
            cmdODS.ExecuteNonQuery()
        Catch ex As Exception
            msgError = ex.Message
        Finally
            conect.Close()
        End Try

        Return ""
    End Function
    Public Function AnyadirMeta(meta As Meta) As String
        Dim msgError = ""
        Dim metas As ReadOnlyCollection(Of Meta) = VerMetasDeODS(meta.NumeroODS, msgError)
        'For i = 0 To odsGuardado.Metas.Count - 1
        '    If odsGuardado.Metas(i).Equals(meta) Then
        '        indiceMeta = i
        '        Exit For
        '    End If
        'Next
        Dim indiceMeta As Integer = metas.IndexOf(meta)
        If indiceMeta <> -1 Then
            Return $"La meta {meta} ya existía en el ODS número {meta.NumeroODS}"
        End If
        If meta.Descripcion.Contains("*") Then
            Return $"La descripcion de la nueva meta {meta.ToString(True)} no puede contener el caracter '*'"
        End If
        Dim conect As New SqlConnection(CADENA_CONEXION)
        Dim sql As String = "INSERT INTO METAS VALUES (@NUMODS, @CARMETA, @DESCRIPCION)"
        Try
            conect.Open()
            Dim cmdODS As New SqlCommand(sql, conect)
            cmdODS.Parameters.AddWithValue("@NUMODS", meta.NumeroODS)
            cmdODS.Parameters.AddWithValue("@CARMETA", meta.IDMeta)
            cmdODS.Parameters.AddWithValue("@DESCRIPCION", meta.Descripcion)
            cmdODS.ExecuteNonQuery()
        Catch ex As Exception
            msgError = ex.Message
        Finally
            conect.Close()
        End Try
        Return ""
    End Function

    Public Function AnyadirIniciativa(iniciativa As Iniciativa) As String
        Dim indiceIniciativa As Integer = Iniciativas.IndexOf(iniciativa)
        If indiceIniciativa <> -1 Then
            Return $"La iniciativa ya existe"
        End If
        If iniciativa.Horas < 0 Then
            Return $"Las horas invertidas en una iniciativa no pueden ser inferiores a 0"
        End If
        If String.IsNullOrWhiteSpace(iniciativa.Titulo) Then
            Return "El titulo no puede quedar en blanco"
        End If
        If iniciativa.FechaFin < iniciativa.FechaInicio Then
            Return "La fecha en la que finaliza una iniciativa no puede ser menor que la fecha en la que inicia"
        End If
        If iniciativa.Contratantes.Count = 0 Then
            Return "Una iniciativa tiene que ser contratada por un contratante como mínimo"
        End If
        If iniciativa.Metas.Count = 0 Then
            Return "Una iniciativa tiene que tener mínimo un objetivo/meta"
        End If
        If iniciativa.Profesores.Count = 0 Then
            Return "En la iniciativa tiene que haber mínimo un profesor encargado"
        End If
        If iniciativa.Asignaturas.Count = 0 Then
            Return "En la iniciativa tiene que participar como mínimo una asignatura"
        End If
        Iniciativas.Add(iniciativa)
        Return ""
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
