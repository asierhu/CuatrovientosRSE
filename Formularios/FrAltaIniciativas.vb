Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Tab
Imports Entidades

Public Class FrAltaIniciativas
    Private Sub FrAltaIniciativas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboOds.Items.AddRange(gestion.Agenda2030.ToArray)
    End Sub
    Private odsSeleccionado As ODS
    Private metaSeleccionada As Meta

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

    Private Sub selmeta_Click(sender As Object, e As EventArgs) Handles selMeta.Click
        metaSeleccionada = TryCast(cboMeta.SelectedItem, Meta)
        If Not lstbMeta.Items.Contains(metaSeleccionada) Then
            lstbMeta.Items.Add(metaSeleccionada)
        Else
            MessageBox.Show("Esa meta ya está seleccionada")
        End If
    End Sub

    Private Sub selmetaOselTdMeta(sender As Object, e As EventArgs) Handles selMeta.Click
        If cboMeta.SelectedItem Is Nothing Then
            errorTxtVacio("cboMeta")
            Exit Sub
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles selTdMeta.Click
        Dim metas = New List(Of Meta)
        For Each meta In odsSeleccionado.Metas
            lstbMeta.Items.Remove(meta)
        Next
        For Each meta In odsSeleccionado.Metas
            If Not lstbMeta.Items.Contains(meta) Then
                lstbMeta.Items.Add(meta)
            Else
                MessageBox.Show("Esas metas ya están seleccionadas")
            End If
        Next
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
        calInicio.SetDate(Now)
        calFinal.SetDate(Now)
        cboOds.SelectedItem = Nothing
        cboMeta.Items.Clear()
        lstbMeta.Items.Clear()
        lstbContratantes.Items.Clear()
        lstbProf.Items.Clear()
        cboAsign.Items.Clear()
        lstbAsign.Items.Clear()
    End Sub

    Private Sub btnBorrarMeta_Click(sender As Object, e As EventArgs) Handles btnBorrarMeta.Click
        lstbMeta.Items.Remove(lstbMeta.SelectedItem)
    End Sub

    Private Sub errorTxtVacio(controlPasado As String)
        Dim control As String = ""
        Select Case controlPasado
            Case "cboOds"
                control = "selección de ods"
            Case "cboMeta"
                control = "selección de metas"
            Case "cboContratantes"
                control = "selección de contratantes"
            Case "cboProf"
                control = "selección de profesores"
            Case "cboCurso"
                control = "selección de cursos"
            Case "cboAsign"
                control = "selección de asignaturas"
        End Select
        MessageBox.Show($"El control '{control}' está vacío")
    End Sub

    Private Sub selContratante_Click(sender As Object, e As EventArgs) Handles selContratante.Click
        If cboContratantes.SelectedItem = Nothing Then
            errorTxtVacio("cboContratantes")
        End If
    End Sub

    Private Sub selProf_Click(sender As Object, e As EventArgs) Handles selProf.Click
        If cboProf.SelectedItem = Nothing Then
            errorTxtVacio("cboProf")
        End If
    End Sub

    Private Sub selCurso_Click(sender As Object, e As EventArgs)
        If cboCurso.SelectedItem = Nothing Then
            errorTxtVacio("cboCurso")
        End If
    End Sub

    Private Sub selAsign_Click(sender As Object, e As EventArgs) Handles selAsign.Click
        If cboAsign.SelectedItem = Nothing Then
            errorTxtVacio("cboAsign")
        End If
    End Sub
End Class