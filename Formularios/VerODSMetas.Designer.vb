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
        Me.dgvmetas = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvmetas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboods
        '
        Me.cboods.FormattingEnabled = True
        Me.cboods.Location = New System.Drawing.Point(291, 61)
        Me.cboods.Name = "cboods"
        Me.cboods.Size = New System.Drawing.Size(216, 21)
        Me.cboods.TabIndex = 0
        '
        'dgvmetas
        '
        Me.dgvmetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvmetas.Location = New System.Drawing.Point(175, 114)
        Me.dgvmetas.Name = "dgvmetas"
        Me.dgvmetas.Size = New System.Drawing.Size(446, 298)
        Me.dgvmetas.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(299, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Selecciona un ODS para ver sus metas:"
        '
        'VerODSMetas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvmetas)
        Me.Controls.Add(Me.cboods)
        Me.Name = "VerODSMetas"
        Me.Text = "VerODSMetas"
        CType(Me.dgvmetas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboods As ComboBox
    Friend WithEvents dgvmetas As DataGridView
    Friend WithEvents Label1 As Label
End Class
