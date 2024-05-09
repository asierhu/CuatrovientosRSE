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
        Me.cboOds = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblmeta = New System.Windows.Forms.Label()
        Me.cboMeta = New System.Windows.Forms.ComboBox()
        Me.selMeta = New System.Windows.Forms.Button()
        Me.lstbMeta = New System.Windows.Forms.ListBox()
        Me.btnBorrarMeta = New System.Windows.Forms.Button()
        Me.selTdMeta = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.selProf = New System.Windows.Forms.Button()
        Me.lstbProf = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboProf = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.selAsign = New System.Windows.Forms.Button()
        Me.lstbAsign = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboAsign = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboCurso = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.selContratante = New System.Windows.Forms.Button()
        Me.lstbContratantes = New System.Windows.Forms.ListBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboContratantes = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.calInicio = New System.Windows.Forms.MonthCalendar()
        Me.calFinal = New System.Windows.Forms.MonthCalendar()
        Me.lblFinal = New System.Windows.Forms.Label()
        Me.chkSinFinal = New System.Windows.Forms.CheckBox()
        Me.btnAlta = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.numHoras = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.numHoras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboOds
        '
        Me.cboOds.FormattingEnabled = True
        Me.cboOds.Location = New System.Drawing.Point(174, 351)
        Me.cboOds.Name = "cboOds"
        Me.cboOds.Size = New System.Drawing.Size(353, 21)
        Me.cboOds.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 351)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Elige los ODS implicados:"
        '
        'lblmeta
        '
        Me.lblmeta.AutoSize = True
        Me.lblmeta.Enabled = False
        Me.lblmeta.Location = New System.Drawing.Point(40, 387)
        Me.lblmeta.Name = "lblmeta"
        Me.lblmeta.Size = New System.Drawing.Size(127, 13)
        Me.lblmeta.TabIndex = 3
        Me.lblmeta.Text = "Elige las metas a trabajar:"
        '
        'cboMeta
        '
        Me.cboMeta.Enabled = False
        Me.cboMeta.FormattingEnabled = True
        Me.cboMeta.Location = New System.Drawing.Point(173, 387)
        Me.cboMeta.Name = "cboMeta"
        Me.cboMeta.Size = New System.Drawing.Size(142, 21)
        Me.cboMeta.TabIndex = 2
        '
        'selMeta
        '
        Me.selMeta.Enabled = False
        Me.selMeta.Location = New System.Drawing.Point(331, 387)
        Me.selMeta.Name = "selMeta"
        Me.selMeta.Size = New System.Drawing.Size(75, 23)
        Me.selMeta.TabIndex = 6
        Me.selMeta.Text = "Seleccionar"
        Me.selMeta.UseVisualStyleBackColor = True
        '
        'lstbMeta
        '
        Me.lstbMeta.FormattingEnabled = True
        Me.lstbMeta.Location = New System.Drawing.Point(173, 442)
        Me.lstbMeta.Name = "lstbMeta"
        Me.lstbMeta.Size = New System.Drawing.Size(354, 121)
        Me.lstbMeta.TabIndex = 7
        '
        'btnBorrarMeta
        '
        Me.btnBorrarMeta.Location = New System.Drawing.Point(293, 579)
        Me.btnBorrarMeta.Name = "btnBorrarMeta"
        Me.btnBorrarMeta.Size = New System.Drawing.Size(122, 23)
        Me.btnBorrarMeta.TabIndex = 8
        Me.btnBorrarMeta.Text = "Borrar seleccionado"
        Me.btnBorrarMeta.UseVisualStyleBackColor = True
        '
        'selTdMeta
        '
        Me.selTdMeta.Enabled = False
        Me.selTdMeta.Location = New System.Drawing.Point(421, 387)
        Me.selTdMeta.Name = "selTdMeta"
        Me.selTdMeta.Size = New System.Drawing.Size(106, 23)
        Me.selTdMeta.TabIndex = 10
        Me.selTdMeta.Text = "Seleccionar todas"
        Me.selTdMeta.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(170, 420)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Metas seleccionadas:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(840, 319)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Profesores seleccionados:"
        '
        'selProf
        '
        Me.selProf.Location = New System.Drawing.Point(1133, 286)
        Me.selProf.Name = "selProf"
        Me.selProf.Size = New System.Drawing.Size(75, 23)
        Me.selProf.TabIndex = 17
        Me.selProf.Text = "Seleccionar"
        Me.selProf.UseVisualStyleBackColor = True
        '
        'lstbProf
        '
        Me.lstbProf.FormattingEnabled = True
        Me.lstbProf.Location = New System.Drawing.Point(843, 341)
        Me.lstbProf.Name = "lstbProf"
        Me.lstbProf.Size = New System.Drawing.Size(272, 121)
        Me.lstbProf.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(709, 286)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Profesorado a cargo:"
        '
        'cboProf
        '
        Me.cboProf.FormattingEnabled = True
        Me.cboProf.Location = New System.Drawing.Point(843, 286)
        Me.cboProf.Name = "cboProf"
        Me.cboProf.Size = New System.Drawing.Size(276, 21)
        Me.cboProf.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(844, 547)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Asignaturas seleccionados:"
        '
        'selAsign
        '
        Me.selAsign.Enabled = False
        Me.selAsign.Location = New System.Drawing.Point(1137, 519)
        Me.selAsign.Name = "selAsign"
        Me.selAsign.Size = New System.Drawing.Size(75, 23)
        Me.selAsign.TabIndex = 22
        Me.selAsign.Text = "Seleccionar"
        Me.selAsign.UseVisualStyleBackColor = True
        '
        'lstbAsign
        '
        Me.lstbAsign.FormattingEnabled = True
        Me.lstbAsign.Location = New System.Drawing.Point(847, 569)
        Me.lstbAsign.Name = "lstbAsign"
        Me.lstbAsign.Size = New System.Drawing.Size(272, 121)
        Me.lstbAsign.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Enabled = False
        Me.Label7.Location = New System.Drawing.Point(713, 519)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Asignaturas involucradas:"
        '
        'cboAsign
        '
        Me.cboAsign.Enabled = False
        Me.cboAsign.FormattingEnabled = True
        Me.cboAsign.Location = New System.Drawing.Point(847, 519)
        Me.cboAsign.Name = "cboAsign"
        Me.cboAsign.Size = New System.Drawing.Size(272, 21)
        Me.cboAsign.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(714, 478)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Cursos que participan:"
        '
        'cboCurso
        '
        Me.cboCurso.FormattingEnabled = True
        Me.cboCurso.Location = New System.Drawing.Point(847, 478)
        Me.cboCurso.Name = "cboCurso"
        Me.cboCurso.Size = New System.Drawing.Size(272, 21)
        Me.cboCurso.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(844, 94)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(141, 13)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Contratantes seleccionados:"
        '
        'selContratante
        '
        Me.selContratante.Location = New System.Drawing.Point(1133, 61)
        Me.selContratante.Name = "selContratante"
        Me.selContratante.Size = New System.Drawing.Size(75, 23)
        Me.selContratante.TabIndex = 32
        Me.selContratante.Text = "Seleccionar"
        Me.selContratante.UseVisualStyleBackColor = True
        '
        'lstbContratantes
        '
        Me.lstbContratantes.FormattingEnabled = True
        Me.lstbContratantes.Location = New System.Drawing.Point(847, 116)
        Me.lstbContratantes.Name = "lstbContratantes"
        Me.lstbContratantes.Size = New System.Drawing.Size(272, 121)
        Me.lstbContratantes.TabIndex = 31
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(691, 62)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(128, 13)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Seleccionar contratantes:"
        '
        'cboContratantes
        '
        Me.cboContratantes.FormattingEnabled = True
        Me.cboContratantes.Location = New System.Drawing.Point(843, 61)
        Me.cboContratantes.Name = "cboContratantes"
        Me.cboContratantes.Size = New System.Drawing.Size(276, 21)
        Me.cboContratantes.TabIndex = 29
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(21, 34)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 13)
        Me.Label12.TabIndex = 34
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(57, 62)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(108, 13)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Título de la iniciativa:"
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(189, 59)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(276, 20)
        Me.txtTitulo.TabIndex = 36
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(77, 102)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(91, 13)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "Numero de horas:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(86, 136)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(82, 13)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "Fecha de inicio:"
        '
        'calInicio
        '
        Me.calInicio.Location = New System.Drawing.Point(174, 136)
        Me.calInicio.Name = "calInicio"
        Me.calInicio.TabIndex = 40
        '
        'calFinal
        '
        Me.calFinal.Location = New System.Drawing.Point(488, 136)
        Me.calFinal.Name = "calFinal"
        Me.calFinal.TabIndex = 42
        '
        'lblFinal
        '
        Me.lblFinal.AutoSize = True
        Me.lblFinal.Location = New System.Drawing.Point(406, 136)
        Me.lblFinal.Name = "lblFinal"
        Me.lblFinal.Size = New System.Drawing.Size(77, 13)
        Me.lblFinal.TabIndex = 41
        Me.lblFinal.Text = "Fecha de final:"
        '
        'chkSinFinal
        '
        Me.chkSinFinal.AutoSize = True
        Me.chkSinFinal.Location = New System.Drawing.Point(528, 310)
        Me.chkSinFinal.Name = "chkSinFinal"
        Me.chkSinFinal.Size = New System.Drawing.Size(108, 17)
        Me.chkSinFinal.TabIndex = 43
        Me.chkSinFinal.Text = "Sin fecha de final"
        Me.chkSinFinal.UseVisualStyleBackColor = True
        '
        'btnAlta
        '
        Me.btnAlta.Location = New System.Drawing.Point(554, 740)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(272, 51)
        Me.btnAlta.TabIndex = 44
        Me.btnAlta.Text = "Dar de alta"
        Me.btnAlta.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(1020, 740)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(272, 51)
        Me.btnReset.TabIndex = 45
        Me.btnReset.Text = "Reiniciar"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'numHoras
        '
        Me.numHoras.Location = New System.Drawing.Point(189, 99)
        Me.numHoras.Name = "numHoras"
        Me.numHoras.Size = New System.Drawing.Size(120, 20)
        Me.numHoras.TabIndex = 46
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(1218, 519)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 23)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "Seleccionar todas"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(60, 637)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(328, 154)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ver datos de iniciativa"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(66, 46)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(256, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Código:"
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(103, 91)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(133, 36)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Eliminar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FrAltaIniciativas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1343, 819)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.numHoras)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnAlta)
        Me.Controls.Add(Me.chkSinFinal)
        Me.Controls.Add(Me.calFinal)
        Me.Controls.Add(Me.lblFinal)
        Me.Controls.Add(Me.calInicio)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtTitulo)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.selContratante)
        Me.Controls.Add(Me.lstbContratantes)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cboContratantes)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cboCurso)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.selAsign)
        Me.Controls.Add(Me.lstbAsign)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboAsign)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.selProf)
        Me.Controls.Add(Me.lstbProf)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboProf)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.selTdMeta)
        Me.Controls.Add(Me.btnBorrarMeta)
        Me.Controls.Add(Me.lstbMeta)
        Me.Controls.Add(Me.selMeta)
        Me.Controls.Add(Me.lblmeta)
        Me.Controls.Add(Me.cboMeta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboOds)
        Me.Name = "FrAltaIniciativas"
        Me.Text = "FrAltaIniciativas"
        CType(Me.numHoras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboOds As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblmeta As Label
    Friend WithEvents cboMeta As ComboBox
    Friend WithEvents selMeta As Button
    Friend WithEvents lstbMeta As ListBox
    Friend WithEvents btnBorrarMeta As Button
    Friend WithEvents selTdMeta As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents selProf As Button
    Friend WithEvents lstbProf As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cboProf As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents selAsign As Button
    Friend WithEvents lstbAsign As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cboAsign As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cboCurso As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents selContratante As Button
    Friend WithEvents lstbContratantes As ListBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cboContratantes As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents calInicio As MonthCalendar
    Friend WithEvents calFinal As MonthCalendar
    Friend WithEvents lblFinal As Label
    Friend WithEvents chkSinFinal As CheckBox
    Friend WithEvents btnAlta As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents numHoras As NumericUpDown
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button2 As Button
End Class
