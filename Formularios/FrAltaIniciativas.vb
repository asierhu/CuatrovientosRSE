Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Tab
Imports Entidades

Public Class FrAltaIniciativas
    Private Sub FrAltaIniciativas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboods.Items.AddRange(gestion.Agenda2030.ToArray)
    End Sub
    Private odsSeleccionado As ODS
    Private metaSeleccionada As Meta

    Private Sub selods_Click(sender As Object, e As EventArgs) Handles selods.Click
        cbometa.Items.Clear()
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
            seltdmeta.Enabled = True
            Dim Msgerror As String
            cbometa.Items.AddRange(gestion.VerMetasDeODS(odsSeleccionado.NumeroODS, Msgerror).ToArray)
        End If
    End Sub

    Private Sub selmeta_Click(sender As Object, e As EventArgs) Handles selmeta.Click
        metaSeleccionada = TryCast(cbometa.SelectedItem, Meta)
        If Not lstbmeta.Items.Contains(metaSeleccionada) Then
            lstbmeta.Items.Add(metaSeleccionada)
        Else
            MessageBox.Show("Esa meta ya está seleccionada")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles seltdmeta.Click
        Dim metas = New List(Of Meta)
        For Each meta In odsSeleccionado.Metas
            lstbmeta.Items.Remove(meta)
        Next
        For Each meta In odsSeleccionado.Metas
            If Not lstbmeta.Items.Contains(meta) Then
                lstbmeta.Items.Add(meta)
            Else
                MessageBox.Show("Esas metas ya están seleccionadas")
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lstbmeta.Items.Remove(lstbmeta.SelectedItem)
    End Sub
End Class