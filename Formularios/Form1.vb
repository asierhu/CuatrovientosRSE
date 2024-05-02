Imports GestionBd
Public Class Form1

    Private Sub btnVerOds_Click(sender As Object, e As EventArgs) Handles btnVerOds.Click
        Dim VerODSMetas = New VerODSMetas
        VerODSMetas.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gestion = New Gestion
    End Sub
End Class
