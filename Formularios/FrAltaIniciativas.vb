Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Tab
Imports Entidades

Public Class FrAltaIniciativas
    Private Sub FrAltaIniciativas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboods.Items.AddRange(gestion.Agenda2030.ToArray)
    End Sub
    Private odsSeleccionado As ODS
    Private metaSeleccionada As Meta

    Private Sub selods_Click(sender As Object, e As EventArgs) Handles selods.Click
        odsSeleccionado = TryCast(cboods.SelectedItem, ODS)
        If Not lstbods.Items.Contains(odsSeleccionado) Then
            lstbods.Items.Add(odsSeleccionado)
        Else
            MessageBox.Show("Ese ods ya está seleccionado")
        End If
        If lstbods.Items.Count >= 1 Then
            lblmeta.Enabled = True
            cbometa.Enabled = True
            selmeta.Enabled = True
            Dim Msgerror As String
            cbometa.Items.AddRange(gestion.VerMetasDeODS(odsSeleccionado.NumeroODS, Msgerror).ToArray)
        End If
    End Sub

    Private Sub selmeta_Click(sender As Object, e As EventArgs) Handles selmeta.Click

    End Sub
End Class