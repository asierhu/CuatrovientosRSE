<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrAltaIniciativas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cboods = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblmeta = New System.Windows.Forms.Label()
        Me.cbometa = New System.Windows.Forms.ComboBox()
        Me.lstbods = New System.Windows.Forms.ListBox()
        Me.selods = New System.Windows.Forms.Button()
        Me.selmeta = New System.Windows.Forms.Button()
        Me.lstbmeta = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.seltdmeta = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboods
        '
        Me.cboods.FormattingEnabled = True
        Me.cboods.Location = New System.Drawing.Point(172, 48)
        Me.cboods.Name = "cboods"
        Me.cboods.Size = New System.Drawing.Size(276, 21)
        Me.cboods.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Elige los ODS implicados:"
        '
        'lblmeta
        '
        Me.lblmeta.AutoSize = True
        Me.lblmeta.Enabled = False
        Me.lblmeta.Location = New System.Drawing.Point(39, 103)
        Me.lblmeta.Name = "lblmeta"
        Me.lblmeta.Size = New System.Drawing.Size(127, 13)
        Me.lblmeta.TabIndex = 3
        Me.lblmeta.Text = "Elige las metas a trabajar:"
        '
        'cbometa
        '
        Me.cbometa.Enabled = False
        Me.cbometa.FormattingEnabled = True
        Me.cbometa.Location = New System.Drawing.Point(172, 103)
        Me.cbometa.Name = "cbometa"
        Me.cbometa.Size = New System.Drawing.Size(142, 21)
        Me.cbometa.TabIndex = 2
        '
        'lstbods
        '
        Me.lstbods.FormattingEnabled = True
        Me.lstbods.Location = New System.Drawing.Point(42, 186)
        Me.lstbods.Name = "lstbods"
        Me.lstbods.Size = New System.Drawing.Size(272, 225)
        Me.lstbods.TabIndex = 4
        '
        'selods
        '
        Me.selods.Location = New System.Drawing.Point(463, 48)
        Me.selods.Name = "selods"
        Me.selods.Size = New System.Drawing.Size(75, 23)
        Me.selods.TabIndex = 5
        Me.selods.Text = "Seleccionar"
        Me.selods.UseVisualStyleBackColor = True
        '
        'selmeta
        '
        Me.selmeta.Enabled = False
        Me.selmeta.Location = New System.Drawing.Point(329, 103)
        Me.selmeta.Name = "selmeta"
        Me.selmeta.Size = New System.Drawing.Size(75, 23)
        Me.selmeta.TabIndex = 6
        Me.selmeta.Text = "Seleccionar"
        Me.selmeta.UseVisualStyleBackColor = True
        '
        'lstbmeta
        '
        Me.lstbmeta.FormattingEnabled = True
        Me.lstbmeta.Location = New System.Drawing.Point(346, 186)
        Me.lstbmeta.Name = "lstbmeta"
        Me.lstbmeta.Size = New System.Drawing.Size(272, 225)
        Me.lstbmeta.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(656, 186)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Borrar seleccionado"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(648, 371)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(130, 40)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Dar de alta"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'seltdmeta
        '
        Me.seltdmeta.Enabled = False
        Me.seltdmeta.Location = New System.Drawing.Point(410, 103)
        Me.seltdmeta.Name = "seltdmeta"
        Me.seltdmeta.Size = New System.Drawing.Size(114, 23)
        Me.seltdmeta.TabIndex = 10
        Me.seltdmeta.Text = "Seleccionar todas"
        Me.seltdmeta.UseVisualStyleBackColor = True
        '
        'FrAltaIniciativas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.seltdmeta)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lstbmeta)
        Me.Controls.Add(Me.selmeta)
        Me.Controls.Add(Me.selods)
        Me.Controls.Add(Me.lstbods)
        Me.Controls.Add(Me.lblmeta)
        Me.Controls.Add(Me.cbometa)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboods)
        Me.Name = "FrAltaIniciativas"
        Me.Text = "FrAltaIniciativas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboods As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblmeta As Label
    Friend WithEvents cbometa As ComboBox
    Friend WithEvents lstbods As ListBox
    Friend WithEvents selods As Button
    Friend WithEvents selmeta As Button
    Friend WithEvents lstbmeta As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents seltdmeta As Button
End Class
