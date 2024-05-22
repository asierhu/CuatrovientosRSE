Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports System.IO
Imports Entidades
Imports Microsoft.Win32
Public Class Gestion

    Private cadenaConexion As String
    Public Sub New()
        Dim servidor As String = "."
        If Environment.MachineName = "4V-PRO-948" Then
            servidor = "4V-PRO-948\SQLEXPRESS"
        End If
        cadenaConexion = $"Data Source = {servidor}; Initial Catalog = CUATROVIENTOSRSE; Integrated Security = SSPI; MultipleActiveResultSets=true"
    End Sub
    Public Function ODSEnBaseDeDatos(ByRef msgError As String) As ReadOnlyCollection(Of ODS)
        Dim ods = New List(Of ODS)
        Dim conect As New SqlConnection(cadenaConexion)
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
        Dim conect As New SqlConnection(cadenaConexion)
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
        Dim conect As New SqlConnection(cadenaConexion)
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
        Dim conect As New SqlConnection(cadenaConexion)
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
        Return asignaturasDeCurso.AsReadOnly
    End Function
    Public Function ContratantesEnBaseDeDatos(ByRef msgError As String) As ReadOnlyCollection(Of Contratante)
        Dim contratantes = New List(Of Contratante)
        Dim conect As New SqlConnection(cadenaConexion)
        Dim sql As String = "SELECT COD_CONTRATANTE, NOMBRE_CONTRATANTE, DESCRIPCION FROM CONTRATANTE"
        Try
            conect.Open()
            Dim cmdCont As New SqlCommand(sql, conect)
            Dim drCont As SqlDataReader = cmdCont.ExecuteReader
            While drCont.Read
                contratantes.Add(New Contratante(drCont("COD_CONTRATANTE"), drCont("NOMBRE_CONTRATANTE"), drCont("DESCRIPCION")))
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
        Dim conect As New SqlConnection(cadenaConexion)
        Dim sql As String = "SELECT ID_PROFESOR, NOMBRE_PROFESOR, APELLIDO1, APELLIDO2, FECHA_NACIMIENTO FROM PROFESORES"
        Try
            conect.Open()
            Dim cmdProfe As New SqlCommand(sql, conect)
            Dim drProfe As SqlDataReader = cmdProfe.ExecuteReader
            While drProfe.Read
                profesores.Add(New Profesor(drProfe("ID_PROFESOR"), drProfe("NOMBRE_PROFESOR"), drProfe("APELLIDO1"), drProfe("APELLIDO2"), drProfe("FECHA_NACIMIENTO")))
            End While
        Catch ex As Exception
            msgError = ex.Message
        Finally
            conect.Close()
        End Try
        Return profesores.AsReadOnly
    End Function
    Public Function Iniciativas(ByRef msgError As String) As ReadOnlyCollection(Of Iniciativa)
        Dim listaIniciativas = New List(Of Iniciativa)
        Dim conect As New SqlConnection(cadenaConexion)
        Dim sql As String = "SELECT COD_INICIATIVA, HORAS, TITULO, FECHA_INICIO, FECHA_FIN FROM INICIATIVAS"
        Try
            conect.Open()
            Dim cmdIni As New SqlCommand(sql, conect)
            Dim drIni As SqlDataReader = cmdIni.ExecuteReader
            Dim codIniciativa As Integer
            While drIni.Read
                codIniciativa = drIni("COD_INICIATIVA")
                listaIniciativas.Add(New Iniciativa(codIniciativa, ContratantesDeIniciativa(codIniciativa), MetasDeIniciativa(codIniciativa), ProfesoresDeIniciativa(codIniciativa), AsignaturasDeIniciativa(codIniciativa), drIni("HORAS"), drIni("TITULO"), drIni("FECHA_INICIO"), drIni("FECHA_FIN")))
            End While
        Catch ex As Exception
            msgError = ex.Message
        Finally
            conect.Close()
        End Try
        Return listaIniciativas.AsReadOnly

    End Function
    Private Function ContratantesDeIniciativa(codIniciativa As Integer) As ReadOnlyCollection(Of Contratante)
        Dim contratantes = New List(Of Contratante)
        Dim conect As New SqlConnection(cadenaConexion)
        Dim sql As String = "SELECT COD_CONTRATANTE, NOMBRE_CONTRATANTE, DESCRIPCION FROM CONTRATANTE WHERE COD_CONTRATANTE IN(SELECT COD_CONTRATANTE FROM CONTRATANTE_INICIATIVA WHERE COD_INICIATIVA=@CODIGO)"
        Try
            conect.Open()
            Dim cmdCont As New SqlCommand(sql, conect)
            cmdCont.Parameters.AddWithValue("@CODIGO", codIniciativa)
            Dim drCont As SqlDataReader = cmdCont.ExecuteReader

            While drCont.Read
                contratantes.Add(New Contratante(drCont("COD_CONTRATANTE"), drCont("NOMBRE_CONTRATANTE"), drCont("DESCRIPCION")))
            End While
        Catch ex As Exception
            ex = ex
        Finally
            conect.Close()
        End Try
        Return contratantes.AsReadOnly
    End Function
    Private Function ProfesoresDeIniciativa(codIniciativa As Integer) As ReadOnlyCollection(Of Profesor)
        Dim profesores = New List(Of Profesor)
        Dim conect As New SqlConnection(cadenaConexion)
        Dim sql As String = "SELECT ID_PROFESOR, NOMBRE_PROFESOR, APELLIDO1, APELLIDO2, FECHA_NACIMIENTO FROM PROFESORES WHERE ID_PROFESOR IN(SELECT ID_PROFESOR FROM PROFESORES_INICIATIVA WHERE COD_INICIATIVA=@CODIGO)"
        Try
            conect.Open()
            Dim cmdProfe As New SqlCommand(sql, conect)
            cmdProfe.Parameters.AddWithValue("@CODIGO", codIniciativa)
            Dim drProfe As SqlDataReader = cmdProfe.ExecuteReader

            While drProfe.Read
                profesores.Add(New Profesor(drProfe("ID_PROFESOR"), drProfe("NOMBRE_PROFESOR"), drProfe("APELLIDO1"), drProfe("APELLIDO2"), drProfe("FECHA_NACIMIENTO")))
            End While
        Catch ex As Exception

        Finally
            conect.Close()
        End Try
        Return profesores.AsReadOnly
    End Function

    Private Function MetasDeIniciativa(codIniciativa As Integer) As ReadOnlyCollection(Of Meta)
        Dim metas As New List(Of Meta)
        Dim conect As New SqlConnection(cadenaConexion)
        Dim sql As String = "SELECT NUMERO_ODS, CARACTER_META, DESCRIPCION FROM METAS WHERE NUMERO_ODS IN(SELECT NUMERO_ODS FROM METAS_INICIATIVA WHERE COD_INICIATIVA=@CODIGO) AND CARACTER_META IN(SELECT CARACTER_META FROM METAS_INICIATIVA WHERE COD_INICIATIVA=@CODIGO)"
        Try
            conect.Open()
            Dim cmdMeta As New SqlCommand(sql, conect)
            cmdMeta.Parameters.AddWithValue("@CODIGO", codIniciativa)
            Dim drMetas As SqlDataReader = cmdMeta.ExecuteReader
            While drMetas.Read
                metas.Add(New Meta(drMetas("NUMERO_ODS"), drMetas("CARACTER_META"), drMetas("DESCRIPCION")))
            End While
        Catch ex As Exception

        Finally
            conect.Close()
        End Try
        Return metas.AsReadOnly
    End Function
    Private Function AsignaturasDeIniciativa(codIniciativa As Integer) As ReadOnlyCollection(Of Asignatura)
        Dim metas As New List(Of Asignatura)
        Dim conect As New SqlConnection(cadenaConexion)
        Dim sql As String = "SELECT COD_ASIGNATURA, NOMBRE_ASIGNATURA, NOMBRE_CURSO FROM ASIGNATURA WHERE COD_ASIGNATURA IN(SELECT COD_ASIGNATURA FROM ASIGNATURAS_INICIATIVA WHERE COD_INICIATIVA=@CODIGO)"
        Try
            conect.Open()
            Dim cmdMeta As New SqlCommand(sql, conect)
            cmdMeta.Parameters.AddWithValue("@CODIGO", codIniciativa)
            Dim drMetas As SqlDataReader = cmdMeta.ExecuteReader
            While drMetas.Read
                metas.Add(New Asignatura(drMetas("COD_ASIGNATURA"), drMetas("NOMBRE_ASIGNATURA"), drMetas("NOMBRE_CURSO")))
            End While
        Catch ex As Exception

        Finally
            conect.Close()
        End Try
        Return metas.AsReadOnly
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

        Dim conect As New SqlConnection(cadenaConexion)
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
        Dim conect As New SqlConnection(cadenaConexion)
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
        Dim conect As New SqlConnection(cadenaConexion)
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
    Public Function AnyadirODS(ods As ODS) As String
        Dim msgError = ""
        Dim odss As ReadOnlyCollection(Of ODS) = ODSEnBaseDeDatos(msgError)
        Dim indiceMeta As Integer = odss.IndexOf(ods)
        If indiceMeta <> -1 Then
            Return $"El ODS {ods} ya existía"
        End If
        If ods.Descripcion.Contains("*") Then
            Return $"La descripcion del ODS {ods} no puede contener el caracter '*'"
        End If
        Dim conect As New SqlConnection(cadenaConexion)
        Dim sql As String = "INSERT INTO ODS VALUES (@NUMODS, @NOMBRE, @DESCRIPCION, @IMAGEN)"
        Try
            conect.Open()
            Dim cmdMeta As New SqlCommand(sql, conect)
            cmdMeta.Parameters.AddWithValue("@NUMODS", ods.NumeroODS)
            cmdMeta.Parameters.AddWithValue("@NOMBRE", ods.Nombre)
            cmdMeta.Parameters.AddWithValue("@DESCRIPCION", ods.Descripcion)
            cmdMeta.Parameters.AddWithValue("@IMAGEN", ods.Imagen)
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
        Dim iniciativas As ReadOnlyCollection(Of Iniciativa) = Me.Iniciativas(msgError)
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
        If Not iniciativa.FechaFin = Nothing Then
            If iniciativa.FechaFin.ToShortDateString < iniciativa.FechaInicio.ToShortDateString Then
                Return "La fecha en la que finaliza una iniciativa no puede ser menor que la fecha en la que inicia"
            End If
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

        Dim conect As New SqlConnection(cadenaConexion)
        Try
            conect.Open()
            Dim sql As String = "INSERT INTO INICIATIVAS VALUES (@HORAS,@TITULO,@FECHAINI,@FECHAFIN)"
            If iniciativa.FechaFin = Nothing Then
                sql = "INSERT INTO INICIATIVAS VALUES (@HORAS,@TITULO,@FECHAINI, @FECHAFIN)"
            End If
            'Dim cmdUltimoNumIni As New SqlCommand("NUEVOCODIGO", conect)
            'cmdUltimoNumIni.CommandType = CommandType.StoredProcedure
            'Dim nuevoCod As Integer = cmdUltimoNumIni.ExecuteScalar
            Dim cmdUltimoNumIni As New SqlCommand("NUEVOCODIGO", conect)
            cmdUltimoNumIni.CommandType = CommandType.StoredProcedure
            Dim returnValue As New SqlParameter("@ReturnVal", SqlDbType.Int)
            returnValue.Direction = ParameterDirection.ReturnValue
            cmdUltimoNumIni.Parameters.Add(returnValue)
            cmdUltimoNumIni.ExecuteNonQuery()
            Dim nuevoCod As Integer = Convert.ToInt32(returnValue.Value)
            'insert iniciativa
            Dim cmdINI As New SqlCommand(sql, conect)
            cmdINI.Parameters.AddWithValue("@HORAS", iniciativa.Horas)
            cmdINI.Parameters.AddWithValue("@TITULO", iniciativa.Titulo)
            cmdINI.Parameters.AddWithValue("@FECHAINI", iniciativa.FechaInicio)
            cmdINI.Parameters.AddWithValue("@FECHAFIN", iniciativa.FechaFin)
            cmdINI.ExecuteNonQuery()
            'insert ASIGNATURAS_INICIATIVA
            For Each asignatura In iniciativa.Asignaturas
                sql = "INSERT INTO ASIGNATURAS_INICIATIVA VALUES (@NOMBRECURSO,@CODASIGNATURA,@CODINICIATIVA)"
                cmdINI = New SqlCommand(sql, conect)
                cmdINI.Parameters.AddWithValue("@NOMBRECURSO", asignatura.NombreCurso)
                cmdINI.Parameters.AddWithValue("@CODASIGNATURA", asignatura.CodAsignatura)
                cmdINI.Parameters.AddWithValue("@CODINICIATIVA", nuevoCod)
                cmdINI.ExecuteNonQuery()
            Next
            'insert METAS_INICIATIVA
            For Each meta In iniciativa.Metas
                sql = "INSERT INTO METAS_INICIATIVA VALUES (@NUMODS,@CARMETA,@CODINICIATIVA)"
                cmdINI = New SqlCommand(sql, conect)
                cmdINI.Parameters.AddWithValue("@NUMODS", meta.NumeroODS)
                cmdINI.Parameters.AddWithValue("@CARMETA", meta.IDMeta)
                cmdINI.Parameters.AddWithValue("@CODINICIATIVA", nuevoCod)
                cmdINI.ExecuteNonQuery()
            Next
            'INSERT CONTRATANTE_INICIATIVA
            For Each cont In iniciativa.Contratantes
                sql = "INSERT INTO CONTRATANTE_INICIATIVA VALUES (@CODCONTRATANTE,@CODINICIATIVA)"
                cmdINI = New SqlCommand(sql, conect)
                cmdINI.Parameters.AddWithValue("@CODCONTRATANTE", cont.CodContratante)
                cmdINI.Parameters.AddWithValue("@CODINICIATIVA", nuevoCod)
                cmdINI.ExecuteNonQuery()
            Next
            'insert PROFESORES_INICIATIVA
            For Each prof In iniciativa.Profesores
                sql = "INSERT INTO PROFESORES_INICIATIVA VALUES (@IDPROF,@CODINICIATIVA)"
                cmdINI = New SqlCommand(sql, conect)
                cmdINI.Parameters.AddWithValue("@IDPROF", prof.IdProfesor)
                cmdINI.Parameters.AddWithValue("@CODINICIATIVA", nuevoCod)
                cmdINI.ExecuteNonQuery()
            Next
        Catch ex As Exception
            msgError = ex.Message

        Finally
            conect.Close()
        End Try
        Return ""
    End Function
    Public Function EliminarIni(ini As Iniciativa) As String
        Dim conect As New SqlConnection(cadenaConexion)
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

    Public Sub LeerFichero()
        Const RUTAFICHERODATOS As String = "/Ficheros/ODSMetas.txt"
        Const RUTAFICHEROLOG As String = "/Ficheros/comentariosODS.log"
        If Not File.Exists(RUTAFICHERODATOS) Then
            File.AppendAllLines(RUTAFICHEROLOG, "EL fichero no existe".ToArray)
        End If
        Dim lineas As String()
        Dim linea As String()
        Dim meta As Meta
        Dim ods As ODS
        Dim msgError As String = ""
        lineas = File.ReadAllLines(RUTAFICHERODATOS)
        For i = 0 To lineas.Length - 1
            msgError = ""
            linea = lineas(i).Split("*")
            For j = 0 To linea.Length - 1
                If String.IsNullOrWhiteSpace(linea(j)) Then
                    File.AppendAllLines(RUTAFICHEROLOG, New String() {$"El parámetro {j} está vacío"})
                    Exit For
                End If
            Next
            If lineas.Length = 3 Then
                meta = New Meta(linea(0), linea(1), linea(2))
                msgError = AnyadirMeta(meta)
            End If
            If lineas.Length = 4 Then
                ods = New ODS(linea(0), linea(1), linea(2), linea(3))

            End If
            If Not lineas.Length = 3 Or Not lineas.Length = 4 Then
                File.AppendAllLines(RUTAFICHEROLOG, New String() {$"EL numero de parametros no es el correcto"})
            End If
            If msgError <> "" Then
                File.AppendAllLines(RUTAFICHEROLOG, msgError)
            End If
        Next
    End Sub
    Public Function DatosDeCiclo(ciclo As Curso, ByRef iniciativas As List(Of String), ByRef metas As List(Of String), ByRef profes As List(Of String), ByRef odss As List(Of String)) As String
        Dim conect As New SqlConnection(cadenaConexion)
        Dim sql As String = "EXEC PROCEDIMIENTO3 @CICLO"
        Try
            conect.Open()
            Dim cmdMeta As New SqlCommand(sql, conect)
            cmdMeta.Parameters.AddWithValue("@CICLO", ciclo.Nombre)
            cmdMeta.ExecuteNonQuery()
            Dim drMetas As SqlDataReader = cmdMeta.ExecuteReader
            While drMetas.Read
                If Not iniciativas.Contains(drMetas("TITULO")) Then
                    iniciativas.Add(drMetas("TITULO"))
                End If
                If Not metas.Contains(drMetas("DESCRIPCION")) Then
                    metas.Add(drMetas("DESCRIPCION"))
                End If
                If Not odss.Contains(drMetas("NOMBRE")) Then
                    odss.Add(drMetas("NOMBRE"))
                End If
                If Not profes.Contains(drMetas("NOMBRE_PROFESOR")) Then
                    profes.Add(drMetas("NOMBRE_PROFESOR"))
                End If
            End While
        Catch ex As Exception
            Return ex.Message
        Finally
            conect.Close()
        End Try
        Return ""
    End Function
End Class
