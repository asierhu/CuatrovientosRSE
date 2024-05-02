<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerODSMetas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cboods = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cboods
        '
        Me.cboods.FormattingEnabled = True
        Me.cboods.Location = New System.Drawing.Point(288, 54)
        Me.cboods.Name = "cboods"
        Me.cboods.Size = New System.Drawing.Size(204, 21)
        Me.cboods.TabIndex = 0
        '
        'VerODSMetas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cboods)
        Me.Name = "VerODSMetas"
        Me.Text = "VerODSMetas"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cboods As ComboBox
End Class
