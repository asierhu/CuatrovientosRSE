Imports System.Runtime.CompilerServices
Imports Entidades

Public Class FrmModificarODSyMeta
    Private odsSeleccionado As ODS

    Private Sub FrmModificarODSyMeta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarCboODS()
    End Sub
    Private Sub ActualizarCboODS()
        Dim msgError As String = ""
        cboODS.Items.Clear()

        Try
            cboODS.Items.AddRange(gestion.ODSs(msgError).ToArray)
            If msgError <> "" Then
                MessageBox.Show(msgError)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
    End Sub
    Private Sub ActualizarCboMetas()
        Dim msgError As String = ""
        cboCarMeta.Items.Clear()
        'cboCarMeta.Items.AddRange(gestion.Agenda2030(gestion.Agenda2030.IndexOf(New ODS(odsSeleccionado.NumeroODS))).Metas.ToArray)
        Try
            cboCarMeta.Items.AddRange(gestion.VerMetasDeODS(odsSeleccionado.NumeroODS, msgError).ToArray)
            If msgError <> "" Then
                MessageBox.Show(msgError)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub btnGuardarCambiosODS_Click(sender As Object, e As EventArgs) Handles btnGuardarCambiosODS.Click
        Dim msg As String = gestion.ModificarODS(New ODS(lblNumero.Text, txtNomODS.Text, txtDesODS.Text, txtImagen.Text))
        If msg <> "" Then
            MessageBox.Show(msg)
            Exit Sub
        End If
        ActualizarCboODS()
    End Sub

    Private Sub btnModMeta_Click(sender As Object, e As EventArgs) Handles btnModMeta.Click
        If cboCarMeta.SelectedItem Is Nothing Then
            MessageBox.Show("Debes seleccionar una meta para poder modificarla")
            Exit Sub
        End If
        Dim msg As String = gestion.ModificarMeta(New Meta(odsSeleccionado.NumeroODS, txtIDModMeta.Text, txtDescripcionMeta.Text), TryCast(cboCarMeta.SelectedItem, Meta).IDMeta)
        If msg <> "" Then
            MessageBox.Show(msg)
            Exit Sub
        End If
        ActualizarCboMetas()
        txtIDModMeta.Text = ""
        txtDescripcionMeta.Text = ""
    End Sub

    Private Sub cboCarMeta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCarMeta.SelectedIndexChanged
        txtDescripcionMeta.Text = TryCast(cboCarMeta.SelectedItem, Meta).Descripcion
        txtIDModMeta.Text = TryCast(cboCarMeta.SelectedItem, Meta).IDMeta
    End Sub
    Private Sub cboODS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboODS.SelectedIndexChanged
        odsSeleccionado = TryCast(cboODS.SelectedItem, ODS)
        pbODS.BackgroundImage = Image.FromFile($"imagenes/{odsSeleccionado.NumeroODS}.jpg")
        lblNumero.Text = odsSeleccionado.NumeroODS
        txtNomODS.Text = odsSeleccionado.Nombre
        txtDesODS.Text = odsSeleccionado.Descripcion
        txtImagen.Text = odsSeleccionado.Imagen
        cboCarMeta.Items.Clear()
        txtDescripcionMeta.Text = ""
        ActualizarCboMetas()
    End Sub

    Private Sub btnAnyadirMeta_Click(sender As Object, e As EventArgs) Handles btnAnyadirMeta.Click
        If cboODS.SelectedItem Is Nothing Then
            MessageBox.Show("Debes seleccionar un ODS para poder añadir una meta")
            Exit Sub
        End If
        Dim msg As String = gestion.AnyadirMeta(New Meta(odsSeleccionado.NumeroODS, txtCarMeta.Text, txtAnyadirDesc.Text))
        If msg <> "" Then
            MessageBox.Show(msg)
            Exit Sub
        End If
        ActualizarCboMetas()
    End Sub

End Class