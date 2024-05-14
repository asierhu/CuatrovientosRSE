Imports System.Runtime.CompilerServices
Imports Entidades

Public Class ModificarODSyMeta ' todo Si es un formulario debe comenzar por Frm (cambiar en el explorador de soluciones)
    Private odsSeleccionado As ODS
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboODS.SelectedIndexChanged, btnAnyadirMeta.Click ' todo PROFESORADO El nombre del método no es lógico ComboBox1_SelectedIndexChanged: debería ser cboODS_SelectedIndexChanged
        odsSeleccionado = TryCast(cboODS.SelectedItem, ODS)
        pbODS.BackgroundImage = Image.FromFile($"imagenes/{odsSeleccionado.NumeroODS}.jpg")
        lblNumero.Text = odsSeleccionado.NumeroODS
        txtNomODS.Text = odsSeleccionado.Nombre
        txtDesODS.Text = odsSeleccionado.Descripcion
        txtImagen.Text = odsSeleccionado.Imagen
        cboCarMeta.Items.Clear()
        txtDescripcionMeta.Text = ""
        Dim msgError As String = ""
        'cboCarMeta.Items.AddRange(gestion.Agenda2030(gestion.Agenda2030.IndexOf(New ODS(odsSeleccionado.NumeroODS))).Metas.ToArray)
        cboCarMeta.Items.AddRange(gestion.VerMetasDeODS(odsSeleccionado.NumeroODS, msgError).ToArray)
        If msgError <> "" Then
            MessageBox.Show(msgError)
        End If
    End Sub

    Private Sub ModificarODSyMeta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub btnGuardarCambiosODS_Click(sender As Object, e As EventArgs) Handles btnGuardarCambiosODS.Click
        Dim msg As String = gestion.ModificarODS(New ODS(lblNumero.Text, txtNomODS.Text, txtDesODS.Text, txtImagen.Text)) ' todo PROFESORADO Si se cambia el ODS automáticamente debe cambiar en el combo
        If msg <> "" Then
            MessageBox.Show(msg)
        End If
    End Sub

    Private Sub btnModMeta_Click(sender As Object, e As EventArgs) Handles btnModMeta.Click
        If cboCarMeta.SelectedItem Is Nothing Then
            MessageBox.Show("Debes seleccionar una meta para poder modificarla")
            Exit Sub
        End If
        Dim msg As String = gestion.ModificarMeta(New Meta(odsSeleccionado.NumeroODS, txtIDModMeta.Text, txtDescripcionMeta.Text), TryCast(cboCarMeta.SelectedItem, Meta).IDMeta) ' todo PROFESORADO: Error de compilación
        If msg <> "" Then
            MessageBox.Show(msg)
        End If
    End Sub

    Private Sub cboCarMeta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCarMeta.SelectedIndexChanged
        txtDescripcionMeta.Text = TryCast(cboCarMeta.SelectedItem, Meta).Descripcion
        txtIDModMeta.Text = TryCast(cboCarMeta.SelectedItem, Meta).IDMeta
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAnyadirMeta.Click
        If cboODS.SelectedItem Is Nothing Then
            MessageBox.Show("Debes seleccionar un ODS para poder añadir una meta")
            Exit Sub
        End If
        Dim msg As String = gestion.AnyadirMeta(New Meta(odsSeleccionado.NumeroODS, txtCarMeta.Text, txtAnyadirDesc.Text))
        If msg <> "" Then
            MessageBox.Show(msg)
        End If
    End Sub
End Class