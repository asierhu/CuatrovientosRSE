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
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtImagen = New System.Windows.Forms.TextBox()
        Me.btnGuardarCambiosODS = New System.Windows.Forms.Button()
        Me.lblDesODS = New System.Windows.Forms.Label()
        Me.lblNomODS = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDesODS = New System.Windows.Forms.TextBox()
        Me.txtNomODS = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.gBoxModMeta = New System.Windows.Forms.GroupBox()
        Me.cboCarMeta = New System.Windows.Forms.ComboBox()
        Me.txtDescripcionMeta = New System.Windows.Forms.TextBox()
        Me.lblDesMeta = New System.Windows.Forms.Label()
        Me.btnModMeta = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCarMeta = New System.Windows.Forms.TextBox()
        Me.btnAnyadirMeta = New System.Windows.Forms.Button()
        Me.txtAnyadirDesc = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtIDModMeta = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.pbODS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gBoxModificar.SuspendLayout()
        Me.gBoxModMeta.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNumODS
        '
        Me.lblNumODS.AutoSize = True
        Me.lblNumODS.Location = New System.Drawing.Point(65, 50)
        Me.lblNumODS.Name = "lblNumODS"
        Me.lblNumODS.Size = New System.Drawing.Size(0, 16)
        Me.lblNumODS.TabIndex = 0
        '
        'cboODS
        '
        Me.cboODS.FormattingEnabled = True
        Me.cboODS.Location = New System.Drawing.Point(109, 34)
        Me.cboODS.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboODS.Name = "cboODS"
        Me.cboODS.Size = New System.Drawing.Size(385, 24)
        Me.cboODS.TabIndex = 5
        '
        'pbODS
        '
        Me.pbODS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbODS.Location = New System.Drawing.Point(589, 9)
        Me.pbODS.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
        Me.gBoxModificar.Location = New System.Drawing.Point(32, 30)
        Me.gBoxModificar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gBoxModificar.Name = "gBoxModificar"
        Me.gBoxModificar.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gBoxModificar.Size = New System.Drawing.Size(771, 314)
        Me.gBoxModificar.TabIndex = 17
        Me.gBoxModificar.TabStop = False
        Me.gBoxModificar.Text = "Modificar ODS"
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblNumero.Location = New System.Drawing.Point(107, 76)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(0, 16)
        Me.lblNumero.TabIndex = 21
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(523, 193)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 16)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Imagen:"
        '
        'txtImagen
        '
        Me.txtImagen.Location = New System.Drawing.Point(589, 190)
        Me.txtImagen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtImagen.Name = "txtImagen"
        Me.txtImagen.Size = New System.Drawing.Size(175, 22)
        Me.txtImagen.TabIndex = 18
        '
        'btnGuardarCambiosODS
        '
        Me.btnGuardarCambiosODS.Location = New System.Drawing.Point(525, 236)
        Me.btnGuardarCambiosODS.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGuardarCambiosODS.Name = "btnGuardarCambiosODS"
        Me.btnGuardarCambiosODS.Size = New System.Drawing.Size(240, 41)
        Me.btnGuardarCambiosODS.TabIndex = 17
        Me.btnGuardarCambiosODS.Text = "Guardar Cambios ODS"
        Me.btnGuardarCambiosODS.UseVisualStyleBackColor = True
        '
        'lblDesODS
        '
        Me.lblDesODS.AutoSize = True
        Me.lblDesODS.Location = New System.Drawing.Point(19, 153)
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
        Me.txtDesODS.Size = New System.Drawing.Size(385, 147)
        Me.txtDesODS.TabIndex = 11
        '
        'txtNomODS
        '
        Me.txtNomODS.Location = New System.Drawing.Point(109, 113)
        Me.txtNomODS.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNomODS.Name = "txtNomODS"
        Me.txtNomODS.Size = New System.Drawing.Size(385, 22)
        Me.txtNomODS.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(419, 185)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 16)
        Me.Label9.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(419, 153)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 16)
        Me.Label10.TabIndex = 26
        '
        'gBoxModMeta
        '
        Me.gBoxModMeta.Controls.Add(Me.Label6)
        Me.gBoxModMeta.Controls.Add(Me.txtIDModMeta)
        Me.gBoxModMeta.Controls.Add(Me.cboCarMeta)
        Me.gBoxModMeta.Controls.Add(Me.txtDescripcionMeta)
        Me.gBoxModMeta.Controls.Add(Me.lblDesMeta)
        Me.gBoxModMeta.Controls.Add(Me.btnModMeta)
        Me.gBoxModMeta.Location = New System.Drawing.Point(32, 363)
        Me.gBoxModMeta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gBoxModMeta.Name = "gBoxModMeta"
        Me.gBoxModMeta.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gBoxModMeta.Size = New System.Drawing.Size(771, 210)
        Me.gBoxModMeta.TabIndex = 25
        Me.gBoxModMeta.TabStop = False
        Me.gBoxModMeta.Text = "Modificar Meta"
        '
        'cboCarMeta
        '
        Me.cboCarMeta.FormattingEnabled = True
        Me.cboCarMeta.Location = New System.Drawing.Point(116, 25)
        Me.cboCarMeta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboCarMeta.MaxLength = 100
        Me.cboCarMeta.Name = "cboCarMeta"
        Me.cboCarMeta.Size = New System.Drawing.Size(331, 24)
        Me.cboCarMeta.TabIndex = 22
        '
        'txtDescripcionMeta
        '
        Me.txtDescripcionMeta.Location = New System.Drawing.Point(116, 89)
        Me.txtDescripcionMeta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDescripcionMeta.Multiline = True
        Me.txtDescripcionMeta.Name = "txtDescripcionMeta"
        Me.txtDescripcionMeta.Size = New System.Drawing.Size(503, 109)
        Me.txtDescripcionMeta.TabIndex = 22
        '
        'lblDesMeta
        '
        Me.lblDesMeta.AutoSize = True
        Me.lblDesMeta.Location = New System.Drawing.Point(19, 93)
        Me.lblDesMeta.Name = "lblDesMeta"
        Me.lblDesMeta.Size = New System.Drawing.Size(82, 16)
        Me.lblDesMeta.TabIndex = 15
        Me.lblDesMeta.Text = "Descripción:"
        '
        'btnModMeta
        '
        Me.btnModMeta.Location = New System.Drawing.Point(643, 89)
        Me.btnModMeta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnModMeta.Name = "btnModMeta"
        Me.btnModMeta.Size = New System.Drawing.Size(123, 39)
        Me.btnModMeta.TabIndex = 22
        Me.btnModMeta.Text = "Modificar Meta"
        Me.btnModMeta.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(340, 142)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 16)
        Me.Label7.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(340, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 16)
        Me.Label8.TabIndex = 23
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCarMeta)
        Me.GroupBox1.Controls.Add(Me.btnAnyadirMeta)
        Me.GroupBox1.Controls.Add(Me.txtAnyadirDesc)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 577)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(771, 172)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Añadir Meta"
        '
        'txtCarMeta
        '
        Me.txtCarMeta.Location = New System.Drawing.Point(116, 32)
        Me.txtCarMeta.MaxLength = 2
        Me.txtCarMeta.Name = "txtCarMeta"
        Me.txtCarMeta.Size = New System.Drawing.Size(37, 22)
        Me.txtCarMeta.TabIndex = 26
        '
        'btnAnyadirMeta
        '
        Me.btnAnyadirMeta.Location = New System.Drawing.Point(643, 62)
        Me.btnAnyadirMeta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAnyadirMeta.Name = "btnAnyadirMeta"
        Me.btnAnyadirMeta.Size = New System.Drawing.Size(123, 38)
        Me.btnAnyadirMeta.TabIndex = 25
        Me.btnAnyadirMeta.Text = "Añadir Meta"
        Me.btnAnyadirMeta.UseVisualStyleBackColor = True
        '
        'txtAnyadirDesc
        '
        Me.txtAnyadirDesc.Location = New System.Drawing.Point(116, 59)
        Me.txtAnyadirDesc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAnyadirDesc.Multiline = True
        Me.txtAnyadirDesc.Name = "txtAnyadirDesc"
        Me.txtAnyadirDesc.Size = New System.Drawing.Size(503, 109)
        Me.txtAnyadirDesc.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 16)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Descripción:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Identificador:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtIDModMeta
        '
        Me.txtIDModMeta.Location = New System.Drawing.Point(116, 55)
        Me.txtIDModMeta.MaxLength = 2
        Me.txtIDModMeta.Name = "txtIDModMeta"
        Me.txtIDModMeta.Size = New System.Drawing.Size(100, 22)
        Me.txtIDModMeta.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 16)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Identificador:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ModificarODSyMeta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 774)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.gBoxModMeta)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.gBoxModificar)
        Me.Controls.Add(Me.lblNumODS)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "ModificarODSyMeta"
        Me.Text = "ModificarODS"
        CType(Me.pbODS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gBoxModificar.ResumeLayout(False)
        Me.gBoxModificar.PerformLayout()
        Me.gBoxModMeta.ResumeLayout(False)
        Me.gBoxModMeta.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnModMeta As Button
    Friend WithEvents txtDescripcionMeta As TextBox
    Friend WithEvents cboCarMeta As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnAnyadirMeta As Button
    Friend WithEvents txtAnyadirDesc As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCarMeta As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtIDModMeta As TextBox
End Class
