<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDatosCiclo
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
        Me.btnVerDatos = New System.Windows.Forms.Button()
        Me.lstIniciativas = New System.Windows.Forms.ListBox()
        Me.lstProfes = New System.Windows.Forms.ListBox()
        Me.lstODSs = New System.Windows.Forms.ListBox()
        Me.lstMetas = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(104, 41)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 16)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Curso:"
        '
        'cboCurso
        '
        Me.cboCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCurso.FormattingEnabled = True
        Me.cboCurso.Location = New System.Drawing.Point(186, 38)
        Me.cboCurso.Margin = New System.Windows.Forms.Padding(4)
        Me.cboCurso.Name = "cboCurso"
        Me.cboCurso.Size = New System.Drawing.Size(361, 24)
        Me.cboCurso.TabIndex = 28
        '
        'btnVerDatos
        '
        Me.btnVerDatos.Location = New System.Drawing.Point(581, 41)
        Me.btnVerDatos.Name = "btnVerDatos"
        Me.btnVerDatos.Size = New System.Drawing.Size(75, 23)
        Me.btnVerDatos.TabIndex = 30
        Me.btnVerDatos.Text = "Ver datos"
        Me.btnVerDatos.UseVisualStyleBackColor = True
        '
        'lstIniciativas
        '
        Me.lstIniciativas.FormattingEnabled = True
        Me.lstIniciativas.ItemHeight = 16
        Me.lstIniciativas.Location = New System.Drawing.Point(51, 106)
        Me.lstIniciativas.Name = "lstIniciativas"
        Me.lstIniciativas.Size = New System.Drawing.Size(280, 132)
        Me.lstIniciativas.TabIndex = 31
        '
        'lstProfes
        '
        Me.lstProfes.FormattingEnabled = True
        Me.lstProfes.ItemHeight = 16
        Me.lstProfes.Location = New System.Drawing.Point(395, 106)
        Me.lstProfes.Name = "lstProfes"
        Me.lstProfes.Size = New System.Drawing.Size(280, 132)
        Me.lstProfes.TabIndex = 32
        '
        'lstODSs
        '
        Me.lstODSs.FormattingEnabled = True
        Me.lstODSs.ItemHeight = 16
        Me.lstODSs.Location = New System.Drawing.Point(732, 106)
        Me.lstODSs.Name = "lstODSs"
        Me.lstODSs.Size = New System.Drawing.Size(280, 132)
        Me.lstODSs.TabIndex = 33
        '
        'lstMetas
        '
        Me.lstMetas.FormattingEnabled = True
        Me.lstMetas.HorizontalScrollbar = True
        Me.lstMetas.ItemHeight = 16
        Me.lstMetas.Location = New System.Drawing.Point(51, 280)
        Me.lstMetas.Name = "lstMetas"
        Me.lstMetas.Size = New System.Drawing.Size(961, 260)
        Me.lstMetas.TabIndex = 34
        '
        'FrmDatosCiclo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1085, 617)
        Me.Controls.Add(Me.lstMetas)
        Me.Controls.Add(Me.lstODSs)
        Me.Controls.Add(Me.lstProfes)
        Me.Controls.Add(Me.lstIniciativas)
        Me.Controls.Add(Me.btnVerDatos)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cboCurso)
        Me.Name = "FrmDatosCiclo"
        Me.Text = "FrmIniciativasCiclo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents cboCurso As ComboBox
    Friend WithEvents btnVerDatos As Button
    Friend WithEvents lstIniciativas As ListBox
    Friend WithEvents lstProfes As ListBox
    Friend WithEvents lstODSs As ListBox
    Friend WithEvents lstMetas As ListBox
End Class
