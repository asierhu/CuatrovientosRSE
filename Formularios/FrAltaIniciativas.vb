﻿Imports System.Collections.ObjectModel
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Tab
Imports Entidades

Public Class FrAltaIniciativas
    Private Sub FrAltaIniciativas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        logo1.BackgroundImage = Image.FromFile("imagenes/logo.png")
        logo2.BackgroundImage = Image.FromFile("imagenes/logo2.png")
        Dim msgError As String = ""
        Try
            cboOds.Items.AddRange(gestion.ODSs(msgError).ToArray)
            cboContratantes.Items.AddRange(gestion.ContratantesEnBaseDeDatos(msgError).ToArray)
            cboProf.Items.AddRange(gestion.ProfesoresEnBaseDeDatos(msgError).ToArray)
            cboCurso.Items.AddRange(gestion.CursosEnBaseDeDatos(msgError).ToArray)
            'cboVerDatos.Items.AddRange(gestion.VerIniciativasEnBaseDeDatos(msgError).ToArray) PARA CUANDO SE HAGA EL METODO EN GESTION
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If msgError <> "" Then
                MessageBox.Show(msgError)
            End If
        End Try
        cboVerDatos.Items.AddRange(gestion.IniciativasEnBaseDeDatos(msgError).ToArray)
    End Sub
    Private odsSeleccionado As ODS
    Private metaSeleccionada As Meta
    Private contratanteSeleccionado As Contratante
    Private profesorSeleccionado As Profesor
    Private cursoseleccionado As Curso
    Private asignaturaseleccionada As Asignatura

    Private Sub selods_Click(sender As Object, e As EventArgs) Handles cboOds.SelectedIndexChanged
        cboMeta.Items.Clear()
        odsSeleccionado = TryCast(cboOds.SelectedItem, ODS)
        If cboOds.SelectedItem Is Nothing Then
            errorTxtVacio("cboOds")
            Exit Sub
        End If
        lblmeta.Enabled = True
        cboMeta.Enabled = True
        selMeta.Enabled = True
        selTdMeta.Enabled = True
        Dim Msgerror As String
        cboMeta.Items.AddRange(gestion.VerMetasDeODS(odsSeleccionado.NumeroODS, Msgerror).ToArray)
    End Sub

    Private Sub selmeta_Click(sender As Object, e As EventArgs) Handles selMeta.Click, selContratante.Click, selProf.Click, selAsign.Click, selTdMeta.Click, seltdasign.Click
        Dim control As New Button
        control = TryCast(sender, Control)
        Select Case control.Name.ToLower
            Case "selmeta"
                If cboMeta.SelectedItem Is Nothing Then
                    errorTxtVacio("cboMeta")
                    Exit Sub
                End If
                metaSeleccionada = TryCast(cboMeta.SelectedItem, Meta)
                If lstbMeta.Items.Contains(metaSeleccionada) Then MessageBox.Show("Esa meta ya está seleccionada")
                Exit Sub
                lstbMeta.Items.Add(metaSeleccionada)
            Case "seltdmeta"
                Dim msgError As String = ""
                Dim metas As ReadOnlyCollection(Of Meta) = gestion.VerMetasDeODS(odsSeleccionado.NumeroODS, msgError)
                If msgError <> "" Then
                    MessageBox.Show(msgError)
                End If
                For Each meta In metas
                    lstbMeta.Items.Remove(meta)
                Next
                For Each meta In metas
                    lstbMeta.Items.Add(meta)
                Next
            Case "selcontratante"
                If cboContratantes.SelectedItem Is Nothing Then
                    errorTxtVacio("selcontratantes")
                    Exit Sub
                End If
                contratanteSeleccionado = TryCast(cboContratantes.SelectedItem, Contratante)
                If lstbContratantes.Items.Contains(contratanteSeleccionado) Then
                    MessageBox.Show("Ese contratante ya está seleccionado")
                    Exit Sub
                End If
                lstbContratantes.Items.Add(contratanteSeleccionado)
            Case "selprof"
                If cboProf.SelectedItem Is Nothing Then
                    errorTxtVacio("selprof")
                    Exit Sub
                End If
                profesorSeleccionado = TryCast(cboProf.SelectedItem, Profesor)
                If lstbProf.Items.Contains(profesorSeleccionado) Then
                    MessageBox.Show("Ese profesor ya está seleccionado")
                    Exit Sub
                End If
                lstbProf.Items.Add(profesorSeleccionado)
            Case "selasign"
                If cboAsign.SelectedItem Is Nothing Then
                    errorTxtVacio("selasign")
                    Exit Sub
                End If
                asignaturaseleccionada = TryCast(cboAsign.SelectedItem, Asignatura)
                If lstbAsign.Items.Contains(asignaturaseleccionada) Then
                    MessageBox.Show("Esa asignatura ya está seleccionada")
                    Exit Sub
                End If
                lstbAsign.Items.Add(asignaturaseleccionada)
            Case "seltdasign"
                Dim msgError As String = ""
                Dim asigns As ReadOnlyCollection(Of Asignatura) = gestion.VerAsignaturasDeCurso(cursoseleccionado.Nombre, msgError)
                If msgError <> "" Then
                    MessageBox.Show(msgError)
                End If
                For Each asign In asigns
                    lstbAsign.Items.Remove(asign)
                Next
                For Each asign In asigns
                    If Not lstbAsign.Items.Contains(asign) Then
                        lstbAsign.Items.Add(asign)
                    Else
                        MessageBox.Show("Esas asignaturas ya están seleccionadas")
                        Exit Sub
                    End If
                Next
        End Select

    End Sub

    Private Sub chksinfinal_CheckedChanged(sender As Object, e As EventArgs) Handles chkSinFinal.CheckedChanged
        If chkSinFinal.Checked Then
            calFinal.Enabled = False
            lblFinal.Enabled = False
        Else
            calFinal.Enabled = True
            lblFinal.Enabled = True
        End If
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtTitulo.Clear()
        numHoras.ResetText()
        calInicio.Value = Now
        calFinal.Value = Now
        cboOds.Items.Clear()
        cboMeta.Items.Clear()
        lstbMeta.Items.Clear()
        lstbContratantes.Items.Clear()
        lstbProf.Items.Clear()
        cboAsign.Items.Clear()
        lstbAsign.Items.Clear()
    End Sub

    Private Sub errorTxtVacio(controlPasado As String)
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

    Private Sub selProf_Click(sender As Object, e As EventArgs) Handles selProf.Click
        If cboProf.SelectedItem Is Nothing Then
            errorTxtVacio("cboProf")
        End If
    End Sub

    Private Sub selCurso_Click(sender As Object, e As EventArgs)
        If cboCurso.SelectedItem Is Nothing Then
            errorTxtVacio("cboCurso")
        End If
    End Sub

    Private Sub selAsign_Click(sender As Object, e As EventArgs) Handles selAsign.Click
        If cboAsign.SelectedItem Is Nothing Then
            errorTxtVacio("cboAsign")
        End If
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
        selAsign.Enabled = True
        seltdasign.Enabled = True
        Dim Msgerror As String = ""
        cboAsign.Items.AddRange(gestion.VerAsignaturasDeCurso(cursoSeleccionado.Nombre, Msgerror).ToArray)
    End Sub

    Private Sub borrarLstb(sender As Object, e As EventArgs) Handles borrarcont.Click, borrarprof.Click, btnBorrarMeta.Click, borrarasign.Click
        Dim control As New Button
        control = TryCast(sender, Button)
        Select Case control.Name.ToLower
            Case "borrarcont"
                lstbContratantes.Items.Remove(lstbContratantes.SelectedItem)
            Case "borrarprof"
                lstbProf.Items.Remove(lstbProf.SelectedItem)
            Case "btnborrarmeta"
                lstbMeta.Items.Remove(lstbMeta.SelectedItem)
            Case "borrarasign"
                lstbAsign.Items.Remove(lstbAsign.SelectedItem)
        End Select
    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        Dim listaContratantes As New List(Of Contratante)
        Dim listaMetas As New List(Of Meta)
        Dim listaProfesores As New List(Of Profesor)
        Dim listaAsignaturas As New List(Of Asignatura)
        For i = 0 To lstbContratantes.Items.Count - 1
            listaContratantes.Add(lstbContratantes.Items(i))
        Next
        For i = 0 To lstbMeta.Items.Count - 1
            listaMetas.Add(lstbMeta.Items(i))
        Next
        For i = 0 To lstbProf.Items.Count - 1
            listaProfesores.Add(lstbProf.Items(i))
        Next
        Dim asigAux As Asignatura
        For i = 0 To lstbAsign.Items.Count - 1
            asigAux = TryCast(lstbAsign.Items(i), Asignatura)
            listaAsignaturas.Add(New Asignatura(asigAux.CodAsignatura, asigAux.Nombre, asigAux.NombreCurso))
        Next
        Dim iniciativaNueva As New Iniciativa(listaContratantes.AsReadOnly, listaMetas.AsReadOnly, listaProfesores.AsReadOnly, listaAsignaturas.AsReadOnly, numHoras.Value, txtTitulo.Text, calInicio.Value, calFinal.Value)
        gestion.AnyadirIniciativa(iniciativaNueva)
    End Sub

    Private Sub cboVerDatos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVerDatos.SelectedIndexChanged
        btnEliminar.Enabled = True
        Dim iniciativaNueva As Iniciativa = cboVerDatos.SelectedItem
        txtTitulo.Text = iniciativaNueva.Titulo
        numHoras.Value = iniciativaNueva.Horas
        calInicio.Value = iniciativaNueva.FechaInicio
        If iniciativaNueva.FechaFin <> Nothing Then
            chkSinFinal.Checked = False
            calFinal.Value = iniciativaNueva.FechaFin
        Else
            chkSinFinal.Checked = True
        End If
        lstbMeta.Items.AddRange(iniciativaNueva.Metas.ToArray)
        lstbContratantes.Items.AddRange(iniciativaNueva.Contratantes.ToArray)
        lstbProf.Items.AddRange(iniciativaNueva.Profesores.ToArray)
        lstbAsign.Items.AddRange(iniciativaNueva.Asignaturas.ToArray)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If cboVerDatos.SelectedItem Is Nothing Then
            MessageBox.Show("Selecciona una iniciativa a eliminar")
            Exit Sub
        End If
        Dim msg As String = gestion.EliminarIni(TryCast(cboVerDatos.SelectedItem, Iniciativa))
        If msg <> "" Then
            MessageBox.Show(msg)
        End If
    End Sub

    Private Sub cboAsign_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAsign.SelectedIndexChanged

    End Sub

    Private Sub cboMeta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMeta.SelectedIndexChanged

    End Sub

    Private Sub cboContratantes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboContratantes.SelectedIndexChanged

    End Sub

    Private Sub cboProf_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProf.SelectedIndexChanged

    End Sub
End Class