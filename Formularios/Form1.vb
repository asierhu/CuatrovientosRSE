Imports GestionBd
Public Class Form1

    Private Sub btnVerOds_Click(sender As Object, e As EventArgs) Handles btnVerOds.Click
        Dim verODSMetas = New frmVerODSMetas
        verODSMetas.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gestion = New Gestion
    End Sub

    Private Sub btnModOds_Click(sender As Object, e As EventArgs) Handles btnModOds.Click
        Dim modificarODSyMeta = New frmModificarODSyMeta
        modificarODSyMeta.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btncrearini_Click(sender As Object, e As EventArgs) Handles btncrearini.Click
        Dim FrAltaIniciativas As New FrAltaIniciativas
        FrAltaIniciativas.Show()
    End Sub
End Class
