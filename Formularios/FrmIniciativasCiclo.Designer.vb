<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIniciativasCiclo
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboCurso = New System.Windows.Forms.ComboBox()
        Me.lblasign = New System.Windows.Forms.Label()
        Me.cboAsign = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(66, 38)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(140, 16)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Cursos que participan:"
        '
        'cboCurso
        '
        Me.cboCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCurso.FormattingEnabled = True
        Me.cboCurso.Location = New System.Drawing.Point(244, 38)
        Me.cboCurso.Margin = New System.Windows.Forms.Padding(4)
        Me.cboCurso.Name = "cboCurso"
        Me.cboCurso.Size = New System.Drawing.Size(361, 24)
        Me.cboCurso.TabIndex = 28
        '
        'lblasign
        '
        Me.lblasign.AutoSize = True
        Me.lblasign.Enabled = False
        Me.lblasign.Location = New System.Drawing.Point(65, 88)
        Me.lblasign.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblasign.Name = "lblasign"
        Me.lblasign.Size = New System.Drawing.Size(161, 16)
        Me.lblasign.TabIndex = 27
        Me.lblasign.Text = "Asignaturas involucradas:"
        '
        'cboAsign
        '
        Me.cboAsign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAsign.Enabled = False
        Me.cboAsign.FormattingEnabled = True
        Me.cboAsign.Location = New System.Drawing.Point(244, 88)
        Me.cboAsign.Margin = New System.Windows.Forms.Padding(4)
        Me.cboAsign.Name = "cboAsign"
        Me.cboAsign.Size = New System.Drawing.Size(361, 24)
        Me.cboAsign.TabIndex = 26
        '
        'FrmIniciativasCiclo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cboCurso)
        Me.Controls.Add(Me.lblasign)
        Me.Controls.Add(Me.cboAsign)
        Me.Name = "FrmIniciativasCiclo"
        Me.Text = "FrmIniciativasCiclo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents cboCurso As ComboBox
    Friend WithEvents lblasign As Label
    Friend WithEvents cboAsign As ComboBox
End Class
