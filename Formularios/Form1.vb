Imports Entidades
Imports GestionBd
Public Class Form1
    Dim gestion As New Gestion
    Private Sub btnModOds_Click(sender As Object, e As EventArgs)
        Dim num As Integer
        If Not Integer.TryParse(txtNumODS.Text, num) OrElse String.IsNullOrWhiteSpace(txtNomODS.Text) OrElse String.IsNullOrWhiteSpace(txtDesODS.Text) Then
            MessageBox.Show("Rellena todos los apartados para modificar un ODS")
            Exit Sub
        End If
        Dim ods As New ODS(num)
        ods.Descripcion = txtDesODS.Text
        gestion.ModificarODS(ods)
    End Sub

End Class
