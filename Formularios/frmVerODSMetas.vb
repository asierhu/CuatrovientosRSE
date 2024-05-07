Imports System.IO
Imports Entidades
Imports GestionBd

Public Class frmVerODSMetas

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboODS.SelectedIndexChanged
        Dim mensajerror As String = ""
        Dim odsSeleccionado As ODS = TryCast(cboODS.SelectedItem, ODS)
        dgvMetas.DataSource = gestion.VerMetasDeODS(odsSeleccionado.NumeroODS, mensajerror)
        pbODS.BackgroundImage = Image.FromFile($"imagenes/{odsSeleccionado.NumeroODS}.jpg")
    End Sub

    Private Sub VerODSMetas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboODS.Items.AddRange(gestion.Agenda2030.ToArray)
    End Sub
End Class