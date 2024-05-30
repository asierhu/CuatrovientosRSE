Imports GestionBd
Public Class FrmPrincipal

    Private Sub btnVerOds_Click(sender As Object, e As EventArgs) Handles btnVerOds.Click
        Dim frmVerODSMetas = New FrmVerODSMetas
        frmVerODSMetas.Show()
    End Sub

    Private Sub btnModOds_Click(sender As Object, e As EventArgs) Handles btnModOds.Click
        Dim frmModificarODSyMeta = New FrmModificarODSyMeta
        frmModificarODSyMeta.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnCrearIni_Click(sender As Object, e As EventArgs) Handles btnCrearIni.Click
        Dim frmAltaIniciativas As New FrmAltaIniciativas
        frmAltaIniciativas.Show()
    End Sub

    Private Sub btnDatosDeCiclo_Click(sender As Object, e As EventArgs) Handles btnDatosDeCiclo.Click
        Dim frmDatosCiclo As New FrmDatosCiclo
        frmDatosCiclo.Show()
    End Sub

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gestion = New Gestion
    End Sub

    Private Sub btnLeerFichero_Click(sender As Object, e As EventArgs) Handles btnLeerFichero.Click
        gestion.LeerFichero()
    End Sub
End Class
