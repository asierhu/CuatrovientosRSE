<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarODSyMeta
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
        Me.lblNumODS = New System.Windows.Forms.Label()
        Me.cboODS = New System.Windows.Forms.ComboBox()
        Me.pbODS = New System.Windows.Forms.PictureBox()
        Me.gBoxModificar = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtImagen = New System.Windows.Forms.TextBox()
        Me.btnGuardarCambiosODS = New System.Windows.Forms.Button()
        Me.lblDesODS = New System.Windows.Forms.Label()
        Me.lblNomODS = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDesODS = New System.Windows.Forms.TextBox()
        Me.txtNomODS = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.gBoxModMeta = New System.Windows.Forms.GroupBox()
        Me.lblDesMeta = New System.Windows.Forms.Label()
        Me.lblCarMeta = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnModMeta = New System.Windows.Forms.Button()
        Me.txtDescripcionMeta = New System.Windows.Forms.TextBox()
        Me.btnAnadirMeta = New System.Windows.Forms.Button()
        Me.cboCarMeta = New System.Windows.Forms.ComboBox()
        CType(Me.pbODS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gBoxModificar.SuspendLayout()
        Me.gBoxModMeta.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNumODS
        '
        Me.lblNumODS.AutoSize = True
        Me.lblNumODS.Location = New System.Drawing.Point(65, 51)
        Me.lblNumODS.Name = "lblNumODS"
        Me.lblNumODS.Size = New System.Drawing.Size(0, 16)
        Me.lblNumODS.TabIndex = 0
        '
        'cboODS
        '
        Me.cboODS.FormattingEnabled = True
        Me.cboODS.Location = New System.Drawing.Point(109, 35)
        Me.cboODS.Name = "cboODS"
        Me.cboODS.Size = New System.Drawing.Size(386, 24)
        Me.cboODS.TabIndex = 5
        '
        'pbODS
        '
        Me.pbODS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbODS.Location = New System.Drawing.Point(590, 9)
        Me.pbODS.Name = "pbODS"
        Me.pbODS.Size = New System.Drawing.Size(175, 175)
        Me.pbODS.TabIndex = 6
        Me.pbODS.TabStop = False
        '
        'gBoxModificar
        '
        Me.gBoxModificar.Controls.Add(Me.lblNumero)
        Me.gBoxModificar.Controls.Add(Me.Label3)
        Me.gBoxModificar.Controls.Add(Me.Label1)
        Me.gBoxModificar.Controls.Add(Me.txtImagen)
        Me.gBoxModificar.Controls.Add(Me.btnGuardarCambiosODS)
        Me.gBoxModificar.Controls.Add(Me.lblDesODS)
        Me.gBoxModificar.Controls.Add(Me.pbODS)
        Me.gBoxModificar.Controls.Add(Me.lblNomODS)
        Me.gBoxModificar.Controls.Add(Me.cboODS)
        Me.gBoxModificar.Controls.Add(Me.Label2)
        Me.gBoxModificar.Controls.Add(Me.txtDesODS)
        Me.gBoxModificar.Controls.Add(Me.txtNomODS)
        Me.gBoxModificar.Location = New System.Drawing.Point(32, 29)
        Me.gBoxModificar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gBoxModificar.Name = "gBoxModificar"
        Me.gBoxModificar.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gBoxModificar.Size = New System.Drawing.Size(771, 314)
        Me.gBoxModificar.TabIndex = 17
        Me.gBoxModificar.TabStop = False
        Me.gBoxModificar.Text = "Modificar ODS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(522, 193)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 16)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Imagen:"
        '
        'txtImagen
        '
        Me.txtImagen.Location = New System.Drawing.Point(590, 190)
        Me.txtImagen.Name = "txtImagen"
        Me.txtImagen.Size = New System.Drawing.Size(175, 22)
        Me.txtImagen.TabIndex = 18
        '
        'btnGuardarCambiosODS
        '
        Me.btnGuardarCambiosODS.Location = New System.Drawing.Point(525, 236)
        Me.btnGuardarCambiosODS.Name = "btnGuardarCambiosODS"
        Me.btnGuardarCambiosODS.Size = New System.Drawing.Size(240, 41)
        Me.btnGuardarCambiosODS.TabIndex = 17
        Me.btnGuardarCambiosODS.Text = "Guardar Cambios ODS"
        Me.btnGuardarCambiosODS.UseVisualStyleBackColor = True
        '
        'lblDesODS
        '
        Me.lblDesODS.AutoSize = True
        Me.lblDesODS.Location = New System.Drawing.Point(19, 152)
        Me.lblDesODS.Name = "lblDesODS"
        Me.lblDesODS.Size = New System.Drawing.Size(82, 16)
        Me.lblDesODS.TabIndex = 15
        Me.lblDesODS.Text = "Descripción:"
        '
        'lblNomODS
        '
        Me.lblNomODS.AutoSize = True
        Me.lblNomODS.Location = New System.Drawing.Point(19, 116)
        Me.lblNomODS.Name = "lblNomODS"
        Me.lblNomODS.Size = New System.Drawing.Size(59, 16)
        Me.lblNomODS.TabIndex = 14
        Me.lblNomODS.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "ODS:"
        '
        'txtDesODS
        '
        Me.txtDesODS.Location = New System.Drawing.Point(109, 151)
        Me.txtDesODS.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDesODS.Multiline = True
        Me.txtDesODS.Name = "txtDesODS"
        Me.txtDesODS.Size = New System.Drawing.Size(386, 147)
        Me.txtDesODS.TabIndex = 11
        '
        'txtNomODS
        '
        Me.txtNomODS.Location = New System.Drawing.Point(109, 113)
        Me.txtNomODS.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNomODS.Name = "txtNomODS"
        Me.txtNomODS.Size = New System.Drawing.Size(386, 22)
        Me.txtNomODS.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 16)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Número:"
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblNumero.Location = New System.Drawing.Point(106, 76)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(0, 16)
        Me.lblNumero.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(418, 185)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 16)
        Me.Label9.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(418, 153)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 16)
        Me.Label10.TabIndex = 26
        '
        'gBoxModMeta
        '
        Me.gBoxModMeta.Controls.Add(Me.cboCarMeta)
        Me.gBoxModMeta.Controls.Add(Me.btnAnadirMeta)
        Me.gBoxModMeta.Controls.Add(Me.txtDescripcionMeta)
        Me.gBoxModMeta.Controls.Add(Me.lblDesMeta)
        Me.gBoxModMeta.Controls.Add(Me.lblCarMeta)
        Me.gBoxModMeta.Controls.Add(Me.btnModMeta)
        Me.gBoxModMeta.Location = New System.Drawing.Point(32, 363)
        Me.gBoxModMeta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gBoxModMeta.Name = "gBoxModMeta"
        Me.gBoxModMeta.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gBoxModMeta.Size = New System.Drawing.Size(771, 172)
        Me.gBoxModMeta.TabIndex = 25
        Me.gBoxModMeta.TabStop = False
        Me.gBoxModMeta.Text = "Modificar Meta"
        '
        'lblDesMeta
        '
        Me.lblDesMeta.AutoSize = True
        Me.lblDesMeta.Location = New System.Drawing.Point(18, 63)
        Me.lblDesMeta.Name = "lblDesMeta"
        Me.lblDesMeta.Size = New System.Drawing.Size(82, 16)
        Me.lblDesMeta.TabIndex = 15
        Me.lblDesMeta.Text = "Descripción:"
        '
        'lblCarMeta
        '
        Me.lblCarMeta.AutoSize = True
        Me.lblCarMeta.Location = New System.Drawing.Point(18, 32)
        Me.lblCarMeta.Name = "lblCarMeta"
        Me.lblCarMeta.Size = New System.Drawing.Size(83, 16)
        Me.lblCarMeta.TabIndex = 14
        Me.lblCarMeta.Text = "Identificador:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(340, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 16)
        Me.Label7.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(340, 109)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 16)
        Me.Label8.TabIndex = 23
        '
        'btnModMeta
        '
        Me.btnModMeta.Location = New System.Drawing.Point(642, 51)
        Me.btnModMeta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnModMeta.Name = "btnModMeta"
        Me.btnModMeta.Size = New System.Drawing.Size(123, 39)
        Me.btnModMeta.TabIndex = 22
        Me.btnModMeta.Text = "Modificar Meta"
        Me.btnModMeta.UseVisualStyleBackColor = True
        '
        'txtDescripcionMeta
        '
        Me.txtDescripcionMeta.Location = New System.Drawing.Point(116, 59)
        Me.txtDescripcionMeta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDescripcionMeta.Multiline = True
        Me.txtDescripcionMeta.Name = "txtDescripcionMeta"
        Me.txtDescripcionMeta.Size = New System.Drawing.Size(503, 109)
        Me.txtDescripcionMeta.TabIndex = 22
        '
        'btnAnadirMeta
        '
        Me.btnAnadirMeta.Location = New System.Drawing.Point(642, 102)
        Me.btnAnadirMeta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAnadirMeta.Name = "btnAnadirMeta"
        Me.btnAnadirMeta.Size = New System.Drawing.Size(123, 39)
        Me.btnAnadirMeta.TabIndex = 25
        Me.btnAnadirMeta.Text = "Añadir Meta"
        Me.btnAnadirMeta.UseVisualStyleBackColor = True
        '
        'cboCarMeta
        '
        Me.cboCarMeta.FormattingEnabled = True
        Me.cboCarMeta.Location = New System.Drawing.Point(116, 29)
        Me.cboCarMeta.MaxLength = 2
        Me.cboCarMeta.Name = "cboCarMeta"
        Me.cboCarMeta.Size = New System.Drawing.Size(79, 24)
        Me.cboCarMeta.TabIndex = 22
        '
        'ModificarODSyMeta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 580)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.gBoxModMeta)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.gBoxModificar)
        Me.Controls.Add(Me.lblNumODS)
        Me.Name = "ModificarODSyMeta"
        Me.Text = "Form2"
        CType(Me.pbODS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gBoxModificar.ResumeLayout(False)
        Me.gBoxModificar.PerformLayout()
        Me.gBoxModMeta.ResumeLayout(False)
        Me.gBoxModMeta.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNumODS As Label
    Friend WithEvents cboODS As ComboBox
    Friend WithEvents pbODS As PictureBox
    Friend WithEvents gBoxModificar As GroupBox
    Friend WithEvents lblDesODS As Label
    Friend WithEvents lblNomODS As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDesODS As TextBox
    Friend WithEvents txtNomODS As TextBox
    Friend WithEvents btnGuardarCambiosODS As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtImagen As TextBox
    Friend WithEvents lblNumero As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents gBoxModMeta As GroupBox
    Friend WithEvents lblDesMeta As Label
    Friend WithEvents lblCarMeta As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnModMeta As Button
    Friend WithEvents txtDescripcionMeta As TextBox
    Friend WithEvents btnAnadirMeta As Button
    Friend WithEvents cboCarMeta As ComboBox
End Class
