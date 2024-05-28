Imports Entidades

Public Class FrmDatosCiclo
    Private Sub FrmIniciativasCiclo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim msgError As String = ""
        Try
            cboCurso.Items.AddRange(gestion.Cursos(msgError).ToArray)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        If msgError <> "" Then
            MessageBox.Show(msgError)
        End If
        If cboCurso.Items.Count = 0 Then
            MessageBox.Show("No hay cursos/ciclos en la base de datos")
        End If
    End Sub
    Private Sub btnVerDatos_Click(sender As Object, e As EventArgs) Handles btnVerDatos.Click
        If cboCurso.SelectedItem Is Nothing Then
            MessageBox.Show("Debes seleccionar un curso")
            Exit Sub
        End If
        Dim iniciativas, odss, metas, profes As New List(Of String)
        Dim msgError As String = gestion.DatosDeCiclo(cboCurso.SelectedItem, iniciativas, metas, profes, odss)
        If msgError <> "" Then
            MessageBox.Show(msgError)
            Exit Sub
        End If
        lstIniciativas.Items.Clear()
        lstMetas.Items.Clear()
        lstProfes.Items.Clear()
        lstODSs.Items.Clear()
        If iniciativas.Count <> 0 Then
            lstIniciativas.Items.AddRange(iniciativas.ToArray)
        End If
        If metas.Count <> 0 Then
            lstMetas.Items.AddRange(metas.ToArray)
        End If
        If profes.Count <> 0 Then
            lstProfes.Items.AddRange(profes.ToArray)
        End If
        If odss.Count <> 0 Then
            lstODSs.Items.AddRange(odss.ToArray)
        End If
    End Sub
End Class