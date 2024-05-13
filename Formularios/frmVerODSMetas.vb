Imports System.IO
Imports Entidades
Imports GestionBd

Public Class frmVerODSMetas

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboODS.SelectedIndexChanged
        Dim mensajerror As String = "" ' todo Debería llamarse mensajeError
        Dim odsSeleccionado As ODS = TryCast(cboODS.SelectedItem, ODS)
        ' todo PROFESORADO En vuestro caso ya tenéis las metas en odsSeleccionado
        dgvMetas.DataSource = gestion.VerMetasDeODS(odsSeleccionado.NumeroODS, mensajerror)
        ' todo PROFESORADO No hacéis nada con mensajeerror
        pbODS.BackgroundImage = Image.FromFile($"imagenes/{odsSeleccionado.NumeroODS}.jpg")
        For i = 0 To dgvMetas.ColumnCount - 1
            dgvMetas.Columns.Item(i).Width = 300
            dgvMetas.Rows.Item(i).Height = 100
        Next
    End Sub

    Private Sub VerODSMetas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim msgError As String = ""
        Try
            cboODS.Items.AddRange(gestion.ODSEnBaseDeDatos(msgError).ToArray)
        Catch ex As Exception
        Finally
            If msgError <> "" Then
                MessageBox.Show(msgError)
            End If
        End Try

    End Sub
End Class