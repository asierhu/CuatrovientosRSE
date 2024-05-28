Imports System.Collections.ObjectModel
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Tab
Imports Entidades

Public Class FrmAltaIniciativas
    Private odsSeleccionado As ODS
    Private metaSeleccionada As Meta
    Private contratanteSeleccionado As Contratante
    Private profesorSeleccionado As Profesor
    Private cursoseleccionado As Curso
    Private asignaturaseleccionada As Asignatura

    Private Sub cboOds_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOds.SelectedIndexChanged
        cboMeta.Items.Clear()
        odsSeleccionado = TryCast(cboOds.SelectedItem, ODS)
        If cboOds.SelectedItem Is Nothing Then
            errorTxtVacio("cboOds")
            Exit Sub
        End If
        lblmeta.Enabled = True
        cboMeta.Enabled = True
        btnSelTdMeta.Enabled = True
        Dim msgError As String = ""
        cboMeta.Items.AddRange(gestion.VerMetasDeODS(odsSeleccionado.NumeroODS, msgError).ToArray)
        If msgError <> "" Then
            MessageBox.Show(msgError)
        End If
    End Sub

    Private Sub FrmAltaIniciativas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        logo1.BackgroundImage = Image.FromFile("imagenes/logo.png")
        logo2.BackgroundImage = Image.FromFile("imagenes/logo2.png")
        Dim msgError As String = ""
        Try
            cboOds.Items.AddRange(gestion.ODSs(msgError).ToArray)
            cboContratantes.Items.AddRange(gestion.Contratantes(msgError).ToArray)
            cboProf.Items.AddRange(gestion.Profesorado(msgError).ToArray)
            cboCurso.Items.AddRange(gestion.Cursos(msgError).ToArray)
            ActualizarCboVerdatos()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        If msgError <> "" Then
            MessageBox.Show(msgError)
        End If
    End Sub
    Private Sub ActualizarCboVerdatos()
        cboVerDatos.Items.Clear()
        Dim msgError As String = ""
        Try
            cboVerDatos.Items.AddRange(gestion.Iniciativas(msgError).ToArray)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        If msgError <> "" Then
            MessageBox.Show(msgError)
        End If
    End Sub


    Private Sub BotonesDeSeleccion_Click(sender As Object, e As EventArgs) Handles btnSelTdMeta.Click, btnSelTdAsign.Click
        Dim control As New Button
        control = TryCast(sender, Control)
        Select Case control.Name.ToLower
            Case "btnseltdmeta"
                Dim msgError As String = ""
                Dim metas As ReadOnlyCollection(Of Meta) = gestion.VerMetasDeODS(odsSeleccionado.NumeroODS, msgError)
                If msgError <> "" Then
                    MessageBox.Show(msgError)
                End If
                For Each meta In metas
                    lstMeta.Items.Remove(meta)
                Next
                For Each meta In metas
                    lstMeta.Items.Add(meta)
                Next
            Case "btnseltdasign"
                Dim msgError As String = ""
                Dim asigns As ReadOnlyCollection(Of Asignatura) = gestion.VerAsignaturasDeCurso(cursoseleccionado.Nombre, msgError)
                If msgError <> "" Then
                    MessageBox.Show(msgError)
                End If
                For Each asign In asigns
                    lstAsign.Items.Remove(asign)
                Next
                For Each asign In asigns
                    If Not lstAsign.Items.Contains(asign) Then
                        lstAsign.Items.Add(asign)
                    Else
                        MessageBox.Show("Esas asignaturas ya están seleccionadas")
                        Exit Sub
                    End If
                Next
        End Select
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtTitulo.Clear()
        numHoras.ResetText()
        calInicio.Value = Now
        calFinal.Value = Now
        cboOds.Items.Clear()
        cboMeta.Items.Clear()
        lstMeta.Items.Clear()
        lstContratantes.Items.Clear()
        lstProf.Items.Clear()
        cboAsign.Items.Clear()
        lstAsign.Items.Clear()
    End Sub

    Private Sub ErrorTxtVacio(controlPasado As String)
        Dim control As String = ""
        Select Case controlPasado.ToLower
            Case "cboods"
                control = "selección de ods"
            Case "cbometa"
                control = "selección de metas"
            Case "cboccontratantes"
                control = "selección de contratantes"
            Case "cboprof"
                control = "selección de profesores"
            Case "cbocurso"
                control = "selección de cursos"
            Case "cboasign"
                control = "selección de asignaturas"
        End Select
        MessageBox.Show($"El control '{control}' está vacío")
    End Sub

    Private Sub cboCurso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCurso.SelectedIndexChanged
        cboAsign.Items.Clear()
        cursoseleccionado = TryCast(cboCurso.SelectedItem, Curso)
        If cboCurso.SelectedItem Is Nothing Then
            errorTxtVacio("cboCurso")
            Exit Sub
        End If
        lblasign.Enabled = True
        cboAsign.Enabled = True
        btnSelTdAsign.Enabled = True
        Dim Msgerror As String = ""
        cboAsign.Items.AddRange(gestion.VerAsignaturasDeCurso(cursoseleccionado.Nombre, Msgerror).ToArray)
    End Sub

    Private Sub BorrarLst(sender As Object, e As EventArgs) Handles btnBorrarCont.Click, btnBorrarProf.Click, btnBorrarMeta.Click, btnBorrarAsign.Click
        Dim control As New Button
        control = TryCast(sender, Button)
        Select Case control.Name.ToLower
            Case "btnborrarcont"
                lstContratantes.Items.Remove(lstContratantes.SelectedItem)
            Case "btnborrarprof"
                lstProf.Items.Remove(lstProf.SelectedItem)
            Case "btnborrarmeta"
                lstMeta.Items.Remove(lstMeta.SelectedItem)
            Case "btborrarasign"
                lstAsign.Items.Remove(lstAsign.SelectedItem)
        End Select
    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        Dim listaContratantes As New List(Of Contratante)
        Dim listaMetas As New List(Of Meta)
        Dim listaProfesores As New List(Of Profesor)
        Dim listaAsignaturas As New List(Of Asignatura)
        For i = 0 To lstContratantes.Items.Count - 1
            listaContratantes.Add(lstContratantes.Items(i))
        Next

        For i = 0 To lstMeta.Items.Count - 1
            listaMetas.Add(lstMeta.Items(i))
        Next
        For i = 0 To lstProf.Items.Count - 1
            listaProfesores.Add(lstProf.Items(i))
        Next
        Dim asigAux As Asignatura
        For i = 0 To lstAsign.Items.Count - 1
            asigAux = TryCast(lstAsign.Items(i), Asignatura)
            listaAsignaturas.Add(New Asignatura(asigAux.CodAsignatura, asigAux.Nombre, asigAux.NombreCurso))
        Next
        Dim iniciativaNueva As Iniciativa
        iniciativaNueva = New Iniciativa(listaContratantes.AsReadOnly, listaMetas.AsReadOnly, listaProfesores.AsReadOnly, listaAsignaturas.AsReadOnly, numHoras.Value, txtTitulo.Text, calInicio.Value, calFinal.Value)
        Dim msg As String = gestion.AnyadirIniciativa(iniciativaNueva)
        If msg <> "" Then
            MessageBox.Show(msg)
            Exit Sub
        End If
        ActualizarCboVerdatos()
        btnReset_Click(Nothing, Nothing)
    End Sub

    Private Sub cboVerDatos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVerDatos.SelectedIndexChanged
        btnEliminar.Enabled = True
        Dim iniciativaNueva As Iniciativa = cboVerDatos.SelectedItem
        txtTitulo.Text = iniciativaNueva.Titulo
        numHoras.Value = iniciativaNueva.Horas
        calInicio.Value = iniciativaNueva.FechaInicio
        lstAsign.Items.Clear()
        lstContratantes.Items.Clear()
        lstMeta.Items.Clear()
        lstProf.Items.Clear()
        lstMeta.Items.AddRange(iniciativaNueva.Metas.ToArray)
        lstContratantes.Items.AddRange(iniciativaNueva.Contratantes.ToArray)
        lstProf.Items.AddRange(iniciativaNueva.Profesores.ToArray)
        lstAsign.Items.AddRange(iniciativaNueva.Asignaturas.ToArray)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If cboVerDatos.SelectedItem Is Nothing Then
            MessageBox.Show("Selecciona una iniciativa a eliminar")
            Exit Sub
        End If
        Dim msg As String = gestion.EliminarIni(TryCast(cboVerDatos.SelectedItem, Iniciativa).CodIniciativa)
        If msg <> "" Then
            MessageBox.Show(msg)
        End If
        btnReset_Click(Nothing, Nothing)
    End Sub

    Private Sub cboMeta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMeta.SelectedIndexChanged
        If cboMeta.SelectedItem Is Nothing Then
            ErrorTxtVacio("cboMeta")
            Exit Sub
        End If
        metaSeleccionada = TryCast(cboMeta.SelectedItem, Meta)
        If lstMeta.Items.Contains(metaSeleccionada) Then
            MessageBox.Show("Esa meta ya está seleccionada")
            Exit Sub
        End If
        lstMeta.Items.Add(metaSeleccionada)
    End Sub

    Private Sub cboContratantes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboContratantes.SelectedIndexChanged
        If cboContratantes.SelectedItem Is Nothing Then
            ErrorTxtVacio("selcontratantes")
            Exit Sub
        End If
        contratanteSeleccionado = TryCast(cboContratantes.SelectedItem, Contratante)
        If lstContratantes.Items.Contains(contratanteSeleccionado) Then
            MessageBox.Show("Ese contratante ya está seleccionado")
            Exit Sub
        End If
        lstContratantes.Items.Add(contratanteSeleccionado)
    End Sub

    Private Sub cboProf_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProf.SelectedIndexChanged

        If cboProf.SelectedItem Is Nothing Then
            ErrorTxtVacio("selprof")
            Exit Sub
        End If
        profesorSeleccionado = TryCast(cboProf.SelectedItem, Profesor)
        If lstProf.Items.Contains(profesorSeleccionado) Then
            MessageBox.Show("Ese profesor ya está seleccionado")
            Exit Sub
        End If
        lstProf.Items.Add(profesorSeleccionado)
    End Sub

    Private Sub cboAsign_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAsign.SelectedIndexChanged
        If cboAsign.SelectedItem Is Nothing Then
            ErrorTxtVacio("selasign")
            Exit Sub
        End If
        asignaturaseleccionada = TryCast(cboAsign.SelectedItem, Asignatura)
        If lstAsign.Items.Contains(asignaturaseleccionada) Then
            MessageBox.Show("Esa asignatura ya está seleccionada")
            Exit Sub
        End If
        lstAsign.Items.Add(asignaturaseleccionada)
    End Sub
End Class