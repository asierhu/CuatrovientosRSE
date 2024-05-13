Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports Entidades
Public Class Gestion
    ' todo PROFESORADO Estamos en acceso conectado. Es decir, los datos están en la base de datos
    ' Cuando los necesitamos recurrimos allí para obtenerlos, y lo mismo al modificarlos
    Private _Agenda2030 As List(Of ODS)
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

    Public Function VerAsignaturasDeCurso(nombreCurso As String, ByRef msgError As String) As ReadOnlyCollection(Of Asignatura)
        Dim asignaturasDeCurso As New List(Of Asignatura)
        Dim conect As New SqlConnection(CADENA_CONEXION)
        Dim sql As String = "SELECT COD_ASIGNATURA, NOMBRE_ASIGNATURA,NOMBRE_CURSO FROM ASIGNATURA WHERE ASIGNATURA.NOMBRE_CURSO = @NOMBRECURSO"
        Try
            conect.Open()
            Dim cmdAsignatura As New SqlCommand(sql, conect)
            cmdAsignatura.Parameters.AddWithValue("@NOMBRECURSO", nombreCurso)
            Dim drAsignaturas As SqlDataReader = cmdAsignatura.ExecuteReader
            If Not drAsignaturas.HasRows Then
                msgError = "Este ODS no tiene metas registradas"
            End If
            While drAsignaturas.Read
                asignaturasDeCurso.Add(New Asignatura(drAsignaturas("COD_ASIGNATURA"), drAsignaturas("NOMBRE_ASIGNATURA"), drAsignaturas("NOMBRE_CURSO")))
            End While
        Catch ex As Exception
            msgError = ex.Message
        Finally
            conect.Close()
        End Try
        End Sub
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
                Return "El nombre del ODS no puede contener el caracter '*'" ' todo PROFESORADO ¿Qué sentido tiene preguntar si contiene *?
            End If
            nuevoNombre = odsModificado.Nombre
        End If
        If Not odsModificado.Descripcion.ToLower = odsGuardado.Descripcion.ToLower Then
            If odsModificado.Descripcion.Contains("*") Then
                Return "La descripción del ODS no puede contener el caracter '*'"
            End If
            nuevaDesc = odsModificado.Descripcion
        End If
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
        End If
        Return ""
    End Function
    Public Function ModificarMeta(metaModificada As Meta) As String
        Dim cambios As Boolean = False
        Dim odsAux As ODS = _Agenda2030(_Agenda2030.IndexOf(New ODS(metaModificada.NumeroODS)))
        Dim indiceMetaODS As Integer = odsAux.Metas.IndexOf(New Meta(metaModificada.NumeroODS, metaModificada.IDMeta))
        Dim metaGuardada As Meta = odsAux.Metas(indiceMetaODS)
        If Not metaModificada.IDMeta.ToLower = metaGuardada.IDMeta.ToLower Then
            If metaModificada.IDMeta.Contains("*") Then ' todo Otra vez lo mismo que en ODS....
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
            Dim cmdMeta As New SqlCommand(sql, conect)
            If sql.Contains("@NUEVAID") Then
                cmdMeta.Parameters.AddWithValue("@NUEVAID", nuevaID)
            End If
            If sql.Contains("@NUEVADESC") Then
                cmdMeta.Parameters.AddWithValue("@NUEVADESC", nuevaDesc)
            End If
            cmdMeta.Parameters.AddWithValue("@NUMODS", metaGuardada.NumeroODS)
            cmdMeta.Parameters.AddWithValue("@IDANTERIOR", caracterAnterior)
            cmdMeta.ExecuteNonQuery()
        Catch ex As Exception
            msgError = ex.Message
        Finally
            conect.Close()
        End Try

        Return ""

    End Function
    Public Function AnyadirMeta(meta As Meta) As String
        Dim odsGuardado As ODS = _Agenda2030(meta.NumeroODS - 1)
        Dim indiceMeta As Integer = odsGuardado.Metas.IndexOf(New Meta(meta.NumeroODS, meta.IDMeta))
        For i = 0 To odsGuardado.Metas.Count - 1
            If odsGuardado.Metas(i).Equals(meta) Then
                indiceMeta = i
                Exit For
            End If
        Next
        If indiceMeta <> -1 Then
            Return $"La meta {meta} ya existía en el ODS número {meta.NumeroODS}"
        End If
        If meta.Descripcion.Contains("*") Then ' todo De nuevo....
            Return $"La descripcion de la nueva meta {meta.ToString(True)} no puede contener el caracter '*'"
        End If
        Dim conect As New SqlConnection(CADENA_CONEXION)
        Dim sql As String = "INSERT INTO METAS VALUES (@NUMODS, @CARMETA, @DESCRIPCION)"
        Try
            conect.Open()
            Dim cmdMeta As New SqlCommand(sql, conect)
            cmdMeta.Parameters.AddWithValue("@NUMODS", meta.NumeroODS)
            cmdMeta.Parameters.AddWithValue("@CARMETA", meta.IDMeta)
            cmdMeta.Parameters.AddWithValue("@DESCRIPCION", meta.Descripcion)
            cmdMeta.ExecuteNonQuery()
        Catch ex As Exception
            msgError = ex.Message
        Finally
            conect.Close()
        End Try
        Return ""
    End Function

    Public Function AnyadirIniciativa(iniciativa As Iniciativa) As String
        Dim msgError As String = ""
        Dim iniciativas As ReadOnlyCollection(Of Iniciativa) = IniciativasEnBaseDeDatos(msgError)
        If msgError <> "" Then
            Return msgError
        End If
        Dim indiceIniciativa As Integer = iniciativas.IndexOf(iniciativa)
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

        Dim conect As New SqlConnection(CADENA_CONEXION)
        Dim sql As String = "INSERT INTO INICIATIVAS VALUES (@HORAS,@TITULO,@FECHAINI,@FECHAFIN)"
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
        Return ""
    End Function
    Public Function EliminarIni(ini As Iniciativa) As String
        Dim conect As New SqlConnection(CADENA_CONEXION)
        Dim sql As String = "DELETE FROM ASIGNATURAS_INICIATIVA WHERE COD_INICIATIVA=@CODINICIATIVA"
        Try
            conect.Open()
            Dim cmdINI As New SqlCommand(sql, conect)
            cmdINI = New SqlCommand(sql, conect)
            cmdINI.Parameters.AddWithValue("@CODINICIATIVA", ini.CodIniciativa)
            cmdINI.ExecuteNonQuery()

            sql = "DELETE FROM CONTRATANTE_INICIATIVA WHERE COD_INICIATIVA=@CODINICIATIVA"
            cmdINI = New SqlCommand(sql, conect)
            cmdINI.Parameters.AddWithValue("@CODINICIATIVA", ini.CodIniciativa)
            cmdINI.ExecuteNonQuery()

            sql = "DELETE FROM METAS_INICIATIVA WHERE COD_INICIATIVA=@CODINICIATIVA"
            cmdINI = New SqlCommand(sql, conect)
            cmdINI.Parameters.AddWithValue("@CODINICIATIVA", ini.CodIniciativa)
            cmdINI.ExecuteNonQuery()

            sql = "DELETE FROM PROFESORES_INICIATIVA WHERE COD_INICIATIVA=@CODINICIATIVA"
            cmdINI = New SqlCommand(sql, conect)
            cmdINI.Parameters.AddWithValue("@CODINICIATIVA", ini.CodIniciativa)
            cmdINI.ExecuteNonQuery()

            sql = "DELETE FROM INICIATIVAS WHERE COD_INICIATIVA=@CODINICIATIVA"
            cmdINI = New SqlCommand(sql, conect)
            cmdINI.Parameters.AddWithValue("@CODINICIATIVA", ini.CodIniciativa)
            cmdINI.ExecuteNonQuery()

        Catch ex As Exception
            Return ex.Message
        Finally
            conect.Close()
        End Try
        Return ""
    End Function
End Class
