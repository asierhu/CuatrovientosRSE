Imports System.Runtime.CompilerServices
Imports Entidades

Public Class ModificarODSyMeta
    Private odsSeleccionado As ODS
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboODS.SelectedIndexChanged
        odsSeleccionado = TryCast(cboODS.SelectedItem, ODS)
        pbODS.BackgroundImage = Image.FromFile($"imagenes/{odsSeleccionado.NumeroODS}.jpg")
        lblNumero.Text = odsSeleccionado.NumeroODS
        txtNomODS.Text = odsSeleccionado.Nombre
        txtDesODS.Text = odsSeleccionado.Descripcion
        txtImagen.Text = odsSeleccionado.Imagen
        cboCarMeta.Items.Clear()
        txtDescripcionMeta.Text = ""
        Dim msgError As String = ""
        cboCarMeta.Items.AddRange(gestion.Agenda2030(gestion.Agenda2030.IndexOf(New ODS(odsSeleccionado.NumeroODS))).Metas.ToArray)
        If msgError <> "" Then
            MessageBox.Show(msgError)
        End If
    End Sub

    Private Sub ModificarODSyMeta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboODS.Items.AddRange(gestion.Agenda2030.ToArray)
    End Sub

    Private Sub btnGuardarCambiosODS_Click(sender As Object, e As EventArgs) Handles btnGuardarCambiosODS.Click
        Dim msg As String = gestion.ModificarODS(New ODS(lblNumero.Text, txtNomODS.Text, txtDesODS.Text, txtImagen.Text))
        If msg <> "" Then
            MessageBox.Show(msg)
        End If
    End Sub

    Private Sub btnModMeta_Click(sender As Object, e As EventArgs) Handles btnModMeta.Click
        If cboCarMeta.SelectedItem Is Nothing Then
            MessageBox.Show("Debes seleccionar una meta para poder modificarla")
            Exit Sub
        End If
        Dim msg As String = gestion.ModificarMeta(New Meta(odsSeleccionado.NumeroODS, cboCarMeta.SelectedItem.ToString, txtDescripcionMeta.Text))
        If msg <> "" Then
            MessageBox.Show(msg)
        End If
    End Sub

    Private Sub cboCarMeta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCarMeta.SelectedIndexChanged
        txtDescripcionMeta.Text = TryCast(cboCarMeta.SelectedItem, Meta).Descripcion
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cboODS.SelectedItem Is Nothing Then
            MessageBox.Show("Debes seleccionar un ODS para poder añadir una meta")
            Exit Sub
        End If

        Dim msg As String = gestion.AnyadirMeta(New Meta(odsSeleccionado.NumeroODS, txtCarMeta.Text, txtDescripcionMeta.Text))
        If msg <> "" Then
            MessageBox.Show(msg)
        End If
    End Sub
End Class