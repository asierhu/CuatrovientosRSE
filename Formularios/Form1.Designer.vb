<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnVerOds = New System.Windows.Forms.Button()
        Me.btnModMeta = New System.Windows.Forms.Button()
        Me.btnModOds = New System.Windows.Forms.Button()
        Me.gBoxModificar = New System.Windows.Forms.GroupBox()
        Me.lblDesODS = New System.Windows.Forms.Label()
        Me.lblNomODS = New System.Windows.Forms.Label()
        Me.lblNumODS = New System.Windows.Forms.Label()
        Me.txtDesODS = New System.Windows.Forms.TextBox()
        Me.txtNumODS = New System.Windows.Forms.TextBox()
        Me.txtNomODS = New System.Windows.Forms.TextBox()
        Me.gBoxModMeta = New System.Windows.Forms.GroupBox()
        Me.lblDesMeta = New System.Windows.Forms.Label()
        Me.lblCarMeta = New System.Windows.Forms.Label()
        Me.lblNumMeta = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.gBoxAnadirMeta = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.gBoxAnadirOds = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnAnadirOds = New System.Windows.Forms.Button()
        Me.btnAnadirMeta = New System.Windows.Forms.Button()
        Me.gBoxModificar.SuspendLayout()
        Me.gBoxModMeta.SuspendLayout()
        Me.gBoxAnadirMeta.SuspendLayout()
        Me.gBoxAnadirOds.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(137, 415)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 16)
        Me.Label2.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(137, 447)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 16)
        Me.Label3.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(277, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(359, 33)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Cuatrovientos ODS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnVerOds
        '
        Me.btnVerOds.Location = New System.Drawing.Point(227, 91)
        Me.btnVerOds.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnVerOds.Name = "btnVerOds"
        Me.btnVerOds.Size = New System.Drawing.Size(221, 47)
        Me.btnVerOds.TabIndex = 11
        Me.btnVerOds.Text = "Ver ODS y metas"
        Me.btnVerOds.UseVisualStyleBackColor = True
        '
        'btnModMeta
        '
        Me.btnModMeta.Location = New System.Drawing.Point(507, 524)
        Me.btnModMeta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnModMeta.Name = "btnModMeta"
        Me.btnModMeta.Size = New System.Drawing.Size(123, 39)
        Me.btnModMeta.TabIndex = 13
        Me.btnModMeta.Text = "Modificar Meta"
        Me.btnModMeta.UseVisualStyleBackColor = True
        '
        'btnModOds
        '
        Me.btnModOds.Location = New System.Drawing.Point(195, 154)
        Me.btnModOds.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnModOds.Name = "btnModOds"
        Me.btnModOds.Size = New System.Drawing.Size(123, 39)
        Me.btnModOds.TabIndex = 12
        Me.btnModOds.Text = "Modificar ODS"
        Me.btnModOds.UseVisualStyleBackColor = True
        '
        'gBoxModificar
        '
        Me.gBoxModificar.Controls.Add(Me.lblDesODS)
        Me.gBoxModificar.Controls.Add(Me.lblNomODS)
        Me.gBoxModificar.Controls.Add(Me.lblNumODS)
        Me.gBoxModificar.Controls.Add(Me.txtDesODS)
        Me.gBoxModificar.Controls.Add(Me.txtNumODS)
        Me.gBoxModificar.Controls.Add(Me.txtNomODS)
        Me.gBoxModificar.Location = New System.Drawing.Point(45, 325)
        Me.gBoxModificar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gBoxModificar.Name = "gBoxModificar"
        Me.gBoxModificar.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gBoxModificar.Size = New System.Drawing.Size(313, 172)
        Me.gBoxModificar.TabIndex = 16
        Me.gBoxModificar.TabStop = False
        Me.gBoxModificar.Text = "Modificar ODS"
        '
        'lblDesODS
        '
        Me.lblDesODS.AutoSize = True
        Me.lblDesODS.Location = New System.Drawing.Point(19, 122)
        Me.lblDesODS.Name = "lblDesODS"
        Me.lblDesODS.Size = New System.Drawing.Size(79, 16)
        Me.lblDesODS.TabIndex = 15
        Me.lblDesODS.Text = "Descripción"
        '
        'lblNomODS
        '
        Me.lblNomODS.AutoSize = True
        Me.lblNomODS.Location = New System.Drawing.Point(19, 78)
        Me.lblNomODS.Name = "lblNomODS"
        Me.lblNomODS.Size = New System.Drawing.Size(59, 16)
        Me.lblNomODS.TabIndex = 14
        Me.lblNomODS.Text = "Nombre "
        '
        'lblNumODS
        '
        Me.lblNumODS.AutoSize = True
        Me.lblNumODS.Location = New System.Drawing.Point(19, 38)
        Me.lblNumODS.Name = "lblNumODS"
        Me.lblNumODS.Size = New System.Drawing.Size(55, 16)
        Me.lblNumODS.TabIndex = 13
        Me.lblNumODS.Text = "Número"
        '
        'txtDesODS
        '
        Me.txtDesODS.Location = New System.Drawing.Point(109, 121)
        Me.txtDesODS.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDesODS.Name = "txtDesODS"
        Me.txtDesODS.Size = New System.Drawing.Size(147, 22)
        Me.txtDesODS.TabIndex = 11
        '
        'txtNumODS
        '
        Me.txtNumODS.Location = New System.Drawing.Point(109, 36)
        Me.txtNumODS.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNumODS.Name = "txtNumODS"
        Me.txtNumODS.Size = New System.Drawing.Size(147, 22)
        Me.txtNumODS.TabIndex = 10
        '
        'txtNomODS
        '
        Me.txtNomODS.Location = New System.Drawing.Point(109, 75)
        Me.txtNomODS.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNomODS.Name = "txtNomODS"
        Me.txtNomODS.Size = New System.Drawing.Size(147, 22)
        Me.txtNomODS.TabIndex = 9
        '
        'gBoxModMeta
        '
        Me.gBoxModMeta.Controls.Add(Me.lblDesMeta)
        Me.gBoxModMeta.Controls.Add(Me.lblCarMeta)
        Me.gBoxModMeta.Controls.Add(Me.lblNumMeta)
        Me.gBoxModMeta.Controls.Add(Me.TextBox1)
        Me.gBoxModMeta.Controls.Add(Me.TextBox2)
        Me.gBoxModMeta.Controls.Add(Me.TextBox3)
        Me.gBoxModMeta.Location = New System.Drawing.Point(401, 325)
        Me.gBoxModMeta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gBoxModMeta.Name = "gBoxModMeta"
        Me.gBoxModMeta.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gBoxModMeta.Size = New System.Drawing.Size(308, 172)
        Me.gBoxModMeta.TabIndex = 19
        Me.gBoxModMeta.TabStop = False
        Me.gBoxModMeta.Text = "Modificar Meta"
        '
        'lblDesMeta
        '
        Me.lblDesMeta.AutoSize = True
        Me.lblDesMeta.Location = New System.Drawing.Point(19, 122)
        Me.lblDesMeta.Name = "lblDesMeta"
        Me.lblDesMeta.Size = New System.Drawing.Size(79, 16)
        Me.lblDesMeta.TabIndex = 15
        Me.lblDesMeta.Text = "Descripción"
        '
        'lblCarMeta
        '
        Me.lblCarMeta.AutoSize = True
        Me.lblCarMeta.Location = New System.Drawing.Point(19, 78)
        Me.lblCarMeta.Name = "lblCarMeta"
        Me.lblCarMeta.Size = New System.Drawing.Size(80, 16)
        Me.lblCarMeta.TabIndex = 14
        Me.lblCarMeta.Text = "Identificador"
        '
        'lblNumMeta
        '
        Me.lblNumMeta.AutoSize = True
        Me.lblNumMeta.Location = New System.Drawing.Point(19, 38)
        Me.lblNumMeta.Name = "lblNumMeta"
        Me.lblNumMeta.Size = New System.Drawing.Size(87, 16)
        Me.lblNumMeta.TabIndex = 13
        Me.lblNumMeta.Text = "Número ODS"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(116, 121)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(147, 22)
        Me.TextBox1.TabIndex = 11
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(116, 36)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(147, 22)
        Me.TextBox2.TabIndex = 10
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(116, 75)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(147, 22)
        Me.TextBox3.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(425, 350)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 16)
        Me.Label7.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(425, 318)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 16)
        Me.Label8.TabIndex = 17
        '
        'gBoxAnadirMeta
        '
        Me.gBoxAnadirMeta.Controls.Add(Me.Label16)
        Me.gBoxAnadirMeta.Controls.Add(Me.Label4)
        Me.gBoxAnadirMeta.Controls.Add(Me.Label6)
        Me.gBoxAnadirMeta.Controls.Add(Me.TextBox4)
        Me.gBoxAnadirMeta.Controls.Add(Me.TextBox5)
        Me.gBoxAnadirMeta.Controls.Add(Me.TextBox6)
        Me.gBoxAnadirMeta.Location = New System.Drawing.Point(805, 325)
        Me.gBoxAnadirMeta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gBoxAnadirMeta.Name = "gBoxAnadirMeta"
        Me.gBoxAnadirMeta.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gBoxAnadirMeta.Size = New System.Drawing.Size(313, 172)
        Me.gBoxAnadirMeta.TabIndex = 22
        Me.gBoxAnadirMeta.TabStop = False
        Me.gBoxAnadirMeta.Text = "Añadir Meta"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(19, 78)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 16)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "Identificador"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 16)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Descripción"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Número ODS"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(109, 121)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(147, 22)
        Me.TextBox4.TabIndex = 11
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(109, 36)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(147, 22)
        Me.TextBox5.TabIndex = 10
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(109, 75)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(147, 22)
        Me.TextBox6.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(503, 394)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 16)
        Me.Label9.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(503, 362)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 16)
        Me.Label10.TabIndex = 20
        '
        'gBoxAnadirOds
        '
        Me.gBoxAnadirOds.Controls.Add(Me.Label11)
        Me.gBoxAnadirOds.Controls.Add(Me.Label12)
        Me.gBoxAnadirOds.Controls.Add(Me.Label13)
        Me.gBoxAnadirOds.Controls.Add(Me.TextBox7)
        Me.gBoxAnadirOds.Controls.Add(Me.TextBox8)
        Me.gBoxAnadirOds.Controls.Add(Me.TextBox9)
        Me.gBoxAnadirOds.Location = New System.Drawing.Point(805, 55)
        Me.gBoxAnadirOds.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gBoxAnadirOds.Name = "gBoxAnadirOds"
        Me.gBoxAnadirOds.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gBoxAnadirOds.Size = New System.Drawing.Size(313, 172)
        Me.gBoxAnadirOds.TabIndex = 19
        Me.gBoxAnadirOds.TabStop = False
        Me.gBoxAnadirOds.Text = "Añadir ODS"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(19, 122)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 16)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Descripción"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(19, 78)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 16)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Nombre "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(19, 38)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 16)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Número"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(109, 121)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(147, 22)
        Me.TextBox7.TabIndex = 11
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(109, 36)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(147, 22)
        Me.TextBox8.TabIndex = 10
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(109, 75)
        Me.TextBox9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(147, 22)
        Me.TextBox9.TabIndex = 9
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(897, 177)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(0, 16)
        Me.Label14.TabIndex = 18
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(897, 145)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(0, 16)
        Me.Label15.TabIndex = 17
        '
        'btnAnadirOds
        '
        Me.btnAnadirOds.Location = New System.Drawing.Point(900, 242)
        Me.btnAnadirOds.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAnadirOds.Name = "btnAnadirOds"
        Me.btnAnadirOds.Size = New System.Drawing.Size(123, 39)
        Me.btnAnadirOds.TabIndex = 23
        Me.btnAnadirOds.Text = "Añadir ODS"
        Me.btnAnadirOds.UseVisualStyleBackColor = True
        '
        'btnAnadirMeta
        '
        Me.btnAnadirMeta.Location = New System.Drawing.Point(900, 524)
        Me.btnAnadirMeta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAnadirMeta.Name = "btnAnadirMeta"
        Me.btnAnadirMeta.Size = New System.Drawing.Size(123, 39)
        Me.btnAnadirMeta.TabIndex = 24
        Me.btnAnadirMeta.Text = "Añadir Meta"
        Me.btnAnadirMeta.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1149, 569)
        Me.Controls.Add(Me.btnVerOds)
        Me.Controls.Add(Me.btnAnadirMeta)
        Me.Controls.Add(Me.btnAnadirOds)
        Me.Controls.Add(Me.gBoxAnadirOds)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.gBoxAnadirMeta)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.gBoxModMeta)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.gBoxModificar)
        Me.Controls.Add(Me.btnModMeta)
        Me.Controls.Add(Me.btnModOds)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gBoxModificar.ResumeLayout(False)
        Me.gBoxModificar.PerformLayout()
        Me.gBoxModMeta.ResumeLayout(False)
        Me.gBoxModMeta.PerformLayout()
        Me.gBoxAnadirMeta.ResumeLayout(False)
        Me.gBoxAnadirMeta.PerformLayout()
        Me.gBoxAnadirOds.ResumeLayout(False)
        Me.gBoxAnadirOds.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnVerOds As Button
    Friend WithEvents btnModMeta As Button
    Friend WithEvents btnModOds As Button
    Friend WithEvents gBoxModificar As GroupBox
    Friend WithEvents txtDesODS As TextBox
    Friend WithEvents txtNumODS As TextBox
    Friend WithEvents txtNomODS As TextBox
    Friend WithEvents lblNumODS As Label
    Friend WithEvents lblDesODS As Label
    Friend WithEvents lblNomODS As Label
    Friend WithEvents gBoxModMeta As GroupBox
    Friend WithEvents lblDesMeta As Label
    Friend WithEvents lblCarMeta As Label
    Friend WithEvents lblNumMeta As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents gBoxAnadirMeta As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents gBoxAnadirOds As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents btnAnadirOds As Button
    Friend WithEvents btnAnadirMeta As Button
End Class
