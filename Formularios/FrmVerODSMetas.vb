Imports System.IO
Imports Entidades
Imports GestionBd

Public Class FrmVerODSMetas
    Private Sub cboODS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboODS.SelectedIndexChanged
        Dim msgError As String = ""
        Dim odsSeleccionado As ODS = TryCast(cboODS.SelectedItem, ODS)
        Try
            dgvMetas.DataSource = gestion.VerMetasDeODS(odsSeleccionado.NumeroODS, msgError)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        If msgError <> "" Then
            MessageBox.Show(msgError)
        End If
        pbODS.BackgroundImage = Image.FromFile(odsSeleccionado.Imagen)
    End Sub

    Private Sub FrmVerODSMetas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim msgError As String = ""
        Try
            cboODS.Items.AddRange(gestion.ODSs(msgError).ToArray)
        Catch ex As Exception
        Finally
            If msgError <> "" Then
                MessageBox.Show(msgError)
            End If
        End Try
    End Sub

End Class