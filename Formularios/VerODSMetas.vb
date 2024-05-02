Imports Entidades
Imports GestionBd

Public Class VerODSMetas

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboods.SelectedIndexChanged
        Dim mensajerror As String = ""
        dgvmetas.DataSource = gestion.VerMetasDeODS(cboods.SelectedIndex, mensajerror)
    End Sub

    Private Sub VerODSMetas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboods.DisplayMember = ToString()
        cboods.Items.AddRange(gestion.Agenda2030.ToArray)
    End Sub
End Class