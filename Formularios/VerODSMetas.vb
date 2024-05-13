Imports System.IO
Imports Entidades
Imports GestionBd

Public Class VerODSMetas

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboODS.SelectedIndexChanged
        Dim mensajerror As String = "" ' todo Debería llamarse mensajeError
        Dim odsSeleccionado As ODS = TryCast(cboODS.SelectedItem, ODS)
        ' todo PROFESORADO En vuestro caso ya tenéis las metas en odsSeleccionado
        dgvMetas.DataSource = gestion.VerMetasDeODS(odsSeleccionado.NumeroODS, mensajerror)
        ' todo PROFESORADO No hacéis nada con mensajeerror
        pbODS.BackgroundImage = Image.FromFile($"imagenes/{odsSeleccionado.NumeroODS}.jpg")
        ' todo PROFESORADO Debe controlar que la imagen existe y que no provoca error de ejecución.
        ' La propiedad Imagen debía traer de la capa de datos el valor que le ponéis aquí
    End Sub

    Private Sub VerODSMetas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboODS.Items.AddRange(gestion.Agenda2030.ToArray) ' todo PROFESORADO Siempre hay que limpiar la lista antes por si se llama al formulario con ShowDialog
    End Sub
End Class