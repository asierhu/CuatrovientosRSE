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
        CType(Me.numHoras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboOds
        '
        Me.cboOds.FormattingEnabled = True
        Me.cboOds.Location = New System.Drawing.Point(232, 432)
        Me.cboOds.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboOds.Name = "cboOds"
        Me.cboOds.Size = New System.Drawing.Size(469, 24)
        Me.cboOds.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 432)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Elige los ODS implicados:"
        '
        'lblmeta
        '
        Me.lblmeta.AutoSize = True
        Me.lblmeta.Enabled = False
        Me.lblmeta.Location = New System.Drawing.Point(54, 476)
        Me.lblmeta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblmeta.Name = "lblmeta"
        Me.lblmeta.Size = New System.Drawing.Size(162, 16)
        Me.lblmeta.TabIndex = 3
        Me.lblmeta.Text = "Elige las metas a trabajar:"
        '
        'cboMeta
        '
        Me.cboMeta.Enabled = False
        Me.cboMeta.FormattingEnabled = True
        Me.cboMeta.Location = New System.Drawing.Point(231, 476)
        Me.cboMeta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboMeta.Name = "cboMeta"
        Me.cboMeta.Size = New System.Drawing.Size(188, 24)
        Me.cboMeta.TabIndex = 2
        '
        'selMeta
        '
        Me.selMeta.Enabled = False
        Me.selMeta.Location = New System.Drawing.Point(441, 476)
        Me.selMeta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.selMeta.Name = "selMeta"
        Me.selMeta.Size = New System.Drawing.Size(100, 28)
        Me.selMeta.TabIndex = 6
        Me.selMeta.Text = "Seleccionar"
        Me.selMeta.UseVisualStyleBackColor = True
        '
        'lstbMeta
        '
        Me.lstbMeta.FormattingEnabled = True
        Me.lstbMeta.ItemHeight = 16
        Me.lstbMeta.Location = New System.Drawing.Point(231, 544)
        Me.lstbMeta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstbMeta.Name = "lstbMeta"
        Me.lstbMeta.Size = New System.Drawing.Size(361, 148)
        Me.lstbMeta.TabIndex = 7
        '
        'btnBorrarMeta
        '
        Me.btnBorrarMeta.Location = New System.Drawing.Point(877, 656)
        Me.btnBorrarMeta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBorrarMeta.Name = "btnBorrarMeta"
        Me.btnBorrarMeta.Size = New System.Drawing.Size(163, 28)
        Me.btnBorrarMeta.TabIndex = 8
        Me.btnBorrarMeta.Text = "Borrar seleccionado"
        Me.btnBorrarMeta.UseVisualStyleBackColor = True
        '
        'selTdMeta
        '
        Me.selTdMeta.Enabled = False
        Me.selTdMeta.Location = New System.Drawing.Point(561, 476)
        Me.selTdMeta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.selTdMeta.Name = "selTdMeta"
        Me.selTdMeta.Size = New System.Drawing.Size(152, 28)
        Me.selTdMeta.TabIndex = 10
        Me.selTdMeta.Text = "Seleccionar todas"
        Me.selTdMeta.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(227, 517)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Metas seleccionadas:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(2032, 319)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Profesores seleccionados:"
        '
        'selProf
        '
        Me.selProf.Location = New System.Drawing.Point(1598, 161)
        Me.selProf.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.selProf.Name = "selProf"
        Me.selProf.Size = New System.Drawing.Size(100, 28)
        Me.selProf.TabIndex = 17
        Me.selProf.Text = "Seleccionar"
        Me.selProf.UseVisualStyleBackColor = True
        '
        'lstbProf
        '
        Me.lstbProf.FormattingEnabled = True
        Me.lstbProf.ItemHeight = 16
        Me.lstbProf.Location = New System.Drawing.Point(2036, 346)
        Me.lstbProf.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstbProf.Name = "lstbProf"
        Me.lstbProf.Size = New System.Drawing.Size(361, 148)
        Me.lstbProf.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1032, 161)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 16)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Profesorado a cargo:"
        '
        'cboProf
        '
        Me.cboProf.FormattingEnabled = True
        Me.cboProf.Location = New System.Drawing.Point(1210, 161)
        Me.cboProf.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboProf.Name = "cboProf"
        Me.cboProf.Size = New System.Drawing.Size(367, 24)
        Me.cboProf.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(2032, 839)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(173, 16)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Asignaturas seleccionados:"
        '
        'selAsign
        '
        Me.selAsign.Enabled = False
        Me.selAsign.Location = New System.Drawing.Point(1598, 267)
        Me.selAsign.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.selAsign.Name = "selAsign"
        Me.selAsign.Size = New System.Drawing.Size(100, 28)
        Me.selAsign.TabIndex = 22
        Me.selAsign.Text = "Seleccionar"
        Me.selAsign.UseVisualStyleBackColor = True
        '
        'lstbAsign
        '
        Me.lstbAsign.FormattingEnabled = True
        Me.lstbAsign.ItemHeight = 16
        Me.lstbAsign.Location = New System.Drawing.Point(2036, 866)
        Me.lstbAsign.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstbAsign.Name = "lstbAsign"
        Me.lstbAsign.Size = New System.Drawing.Size(361, 148)
        Me.lstbAsign.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Enabled = False
        Me.Label7.Location = New System.Drawing.Point(1032, 267)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(161, 16)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Asignaturas involucradas:"
        '
        'cboAsign
        '
        Me.cboAsign.Enabled = False
        Me.cboAsign.FormattingEnabled = True
        Me.cboAsign.Location = New System.Drawing.Point(1210, 267)
        Me.cboAsign.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboAsign.Name = "cboAsign"
        Me.cboAsign.Size = New System.Drawing.Size(367, 24)
        Me.cboAsign.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(1033, 217)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(140, 16)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Cursos que participan:"
        '
        'cboCurso
        '
        Me.cboCurso.FormattingEnabled = True
        Me.cboCurso.Location = New System.Drawing.Point(1210, 217)
        Me.cboCurso.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboCurso.Name = "cboCurso"
        Me.cboCurso.Size = New System.Drawing.Size(361, 24)
        Me.cboCurso.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(2032, 73)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(177, 16)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Contratantes seleccionados:"
        '
        'selContratante
        '
        Me.selContratante.Location = New System.Drawing.Point(1598, 100)
        Me.selContratante.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.selContratante.Name = "selContratante"
        Me.selContratante.Size = New System.Drawing.Size(100, 28)
        Me.selContratante.TabIndex = 32
        Me.selContratante.Text = "Seleccionar"
        Me.selContratante.UseVisualStyleBackColor = True
        '
        'lstbContratantes
        '
        Me.lstbContratantes.FormattingEnabled = True
        Me.lstbContratantes.ItemHeight = 16
        Me.lstbContratantes.Location = New System.Drawing.Point(2036, 100)
        Me.lstbContratantes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstbContratantes.Name = "lstbContratantes"
        Me.lstbContratantes.Size = New System.Drawing.Size(361, 148)
        Me.lstbContratantes.TabIndex = 31
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(1011, 100)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(158, 16)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Seleccionar contratantes:"
        '
        'cboContratantes
        '
        Me.cboContratantes.FormattingEnabled = True
        Me.cboContratantes.Location = New System.Drawing.Point(1210, 100)
        Me.cboContratantes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboContratantes.Name = "cboContratantes"
        Me.cboContratantes.Size = New System.Drawing.Size(367, 24)
        Me.cboContratantes.TabIndex = 29
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(28, 42)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 16)
        Me.Label12.TabIndex = 34
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(76, 76)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(131, 16)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Título de la iniciativa:"
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(252, 73)
        Me.txtTitulo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(367, 22)
        Me.txtTitulo.TabIndex = 36
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(103, 125)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(114, 16)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "Numero de horas:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(115, 167)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(101, 16)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "Fecha de inicio:"
        '
        'calInicio
        '
        Me.calInicio.Location = New System.Drawing.Point(232, 167)
        Me.calInicio.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.calInicio.Name = "calInicio"
        Me.calInicio.TabIndex = 40
        '
        'calFinal
        '
        Me.calFinal.Location = New System.Drawing.Point(651, 167)
        Me.calFinal.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.calFinal.Name = "calFinal"
        Me.calFinal.TabIndex = 42
        '
        'lblFinal
        '
        Me.lblFinal.AutoSize = True
        Me.lblFinal.Location = New System.Drawing.Point(541, 167)
        Me.lblFinal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFinal.Name = "lblFinal"
        Me.lblFinal.Size = New System.Drawing.Size(94, 16)
        Me.lblFinal.TabIndex = 41
        Me.lblFinal.Text = "Fecha de final:"
        '
        'chkSinFinal
        '
        Me.chkSinFinal.AutoSize = True
        Me.chkSinFinal.Location = New System.Drawing.Point(704, 381)
        Me.chkSinFinal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkSinFinal.Name = "chkSinFinal"
        Me.chkSinFinal.Size = New System.Drawing.Size(130, 20)
        Me.chkSinFinal.TabIndex = 43
        Me.chkSinFinal.Text = "Sin fecha de final"
        Me.chkSinFinal.UseVisualStyleBackColor = True
        '
        'btnAlta
        '
        Me.btnAlta.Location = New System.Drawing.Point(2036, 1113)
        Me.btnAlta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(363, 63)
        Me.btnAlta.TabIndex = 44
        Me.btnAlta.Text = "Dar de alta"
        Me.btnAlta.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(1252, 639)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(363, 63)
        Me.btnReset.TabIndex = 45
        Me.btnReset.Text = "Reiniciar"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'numHoras
        '
        Me.numHoras.Location = New System.Drawing.Point(252, 122)
        Me.numHoras.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.numHoras.Name = "numHoras"
        Me.numHoras.Size = New System.Drawing.Size(160, 22)
        Me.numHoras.TabIndex = 46
        '
        'FrAltaIniciativas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1710, 742)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrAltaIniciativas"
        Me.Text = "FrAltaIniciativas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.numHoras, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
