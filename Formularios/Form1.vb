﻿Imports GestionBd
Public Class Form1
    Dim gestion As New Gestion

    Private Sub btnVerOds_Click(sender As Object, e As EventArgs) Handles btnVerOds.Click
        VerODSMetas = New VerODSMetas
        VerODSMetas.Show()
    End Sub
End Class
