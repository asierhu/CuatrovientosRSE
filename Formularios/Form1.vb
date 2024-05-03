Imports GestionBd
Public Class Form1

    Private Sub btnVerOds_Click(sender As Object, e As EventArgs) Handles btnVerOds.Click
        Dim verODSMetas = New VerODSMetas
        verODSMetas.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gestion = New Gestion
    End Sub

    Private Sub btnModOds_Click(sender As Object, e As EventArgs) Handles btnModOds.Click
        Dim modificarODSyMeta = New ModificarODSyMeta
        modificarODSyMeta.Show()
    End Sub
End Class
