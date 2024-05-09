Imports System.Collections.ObjectModel
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Tab
Imports Entidades

Public Class FrAltaIniciativas
    Private Sub FrAltaIniciativas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        logo1.BackgroundImage = Image.FromFile("imagenes/logo.png")
        logo2.BackgroundImage = Image.FromFile("imagenes/logo2.png")
        Dim msgError As String = ""
        Try
            cboOds.Items.AddRange(gestion.ODSEnBaseDeDatos(msgError).ToArray)
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
        For i = 0 To cboContratantes.Items.Count - 1
            listaContratantes.Add(cboContratantes.Items(i))
        Next
        For i = 0 To cboMeta.Items.Count - 1
            listaMetas.Add(cboMeta.Items(i))
        Next
        For i = 0 To cboProf.Items.Count - 1
            listaProfesores.Add(cboProf.Items(i))
        Next
        For i = 0 To cboAsign.Items.Count - 1
            listaAsignaturas.Add(cboAsign.Items(i))
        Next
        Dim iniciativaNueva As New Iniciativa(listaContratantes, listaMetas, listaProfesores, listaAsignaturas, numHoras.Value, txtTitulo.Text, calInicio.Value, calFinal.Value)
    End Sub

    Private Sub cboVerDatos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVerDatos.SelectedIndexChanged
        Dim iniciativaNueva = New Iniciativa '(cboVerDatos.SelectedIndex[todos los datos])
        txtTitulo = iniciativaNueva.Titulo
        numHoras = iniciativaNueva.Horas
        calInicio.Value = iniciativaNueva.FechaInicio
        If iniciativaNueva.FechaFin Is Not Nothing Then
            chkSinFinal.Checked = False
            calFinal.Value = iniciativaNueva.FechaFin
        Else
            chkSinFinal.Checked = True
        End If
        lstbMeta.Items = iniciativaNueva.Metas
        lstbContratantes.Items = iniciativaNueva.Contratantes
        lstbProf.Items = iniciativaNueva.Profesores
        lstbAsign.Items = iniciativaNueva.Asignaturas
    End Sub
End Class