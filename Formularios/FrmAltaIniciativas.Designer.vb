<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAltaIniciativas
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
        Me.btnSelMeta = New System.Windows.Forms.Button()
        Me.lstbMeta = New System.Windows.Forms.ListBox()
        Me.btnBorrarMeta = New System.Windows.Forms.Button()
        Me.btnSelTdMeta = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSelProf = New System.Windows.Forms.Button()
        Me.lstbProf = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboProf = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSelAsign = New System.Windows.Forms.Button()
        Me.lstbAsign = New System.Windows.Forms.ListBox()
        Me.lblasign = New System.Windows.Forms.Label()
        Me.cboAsign = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboCurso = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnSelContratante = New System.Windows.Forms.Button()
        Me.lstbContratantes = New System.Windows.Forms.ListBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboContratantes = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblFinal = New System.Windows.Forms.Label()
        Me.btnAlta = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.numHoras = New System.Windows.Forms.NumericUpDown()
        Me.btnSelTdAsign = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboVerDatos = New System.Windows.Forms.ComboBox()
        Me.borrarcont = New System.Windows.Forms.Button()
        Me.btnBorrarProf = New System.Windows.Forms.Button()
        Me.btnBorrarAsign = New System.Windows.Forms.Button()
        Me.calInicio = New System.Windows.Forms.DateTimePicker()
        Me.calFinal = New System.Windows.Forms.DateTimePicker()
        Me.logo1 = New System.Windows.Forms.PictureBox()
        Me.logo2 = New System.Windows.Forms.PictureBox()
        CType(Me.numHoras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.logo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logo2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboOds
        '
        Me.cboOds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOds.FormattingEnabled = True
        Me.cboOds.Location = New System.Drawing.Point(256, 256)
        Me.cboOds.Margin = New System.Windows.Forms.Padding(4)
        Me.cboOds.Name = "cboOds"
        Me.cboOds.Size = New System.Drawing.Size(469, 24)
        Me.cboOds.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 256)
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
        Me.lblmeta.Location = New System.Drawing.Point(48, 300)
        Me.lblmeta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblmeta.Name = "lblmeta"
        Me.lblmeta.Size = New System.Drawing.Size(162, 16)
        Me.lblmeta.TabIndex = 3
        Me.lblmeta.Text = "Elige las metas a trabajar:"
        '
        'cboMeta
        '
        Me.cboMeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMeta.Enabled = False
        Me.cboMeta.FormattingEnabled = True
        Me.cboMeta.Location = New System.Drawing.Point(255, 300)
        Me.cboMeta.Margin = New System.Windows.Forms.Padding(4)
        Me.cboMeta.Name = "cboMeta"
        Me.cboMeta.Size = New System.Drawing.Size(188, 24)
        Me.cboMeta.TabIndex = 2
        '
        'btnSelMeta
        '
        Me.btnSelMeta.Enabled = False
        Me.btnSelMeta.Location = New System.Drawing.Point(465, 300)
        Me.btnSelMeta.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSelMeta.Name = "btnSelMeta"
        Me.btnSelMeta.Size = New System.Drawing.Size(100, 28)
        Me.btnSelMeta.TabIndex = 6
        Me.btnSelMeta.Text = "Seleccionar"
        Me.btnSelMeta.UseVisualStyleBackColor = True
        '
        'lstbMeta
        '
        Me.lstbMeta.FormattingEnabled = True
        Me.lstbMeta.ItemHeight = 16
        Me.lstbMeta.Location = New System.Drawing.Point(255, 368)
        Me.lstbMeta.Margin = New System.Windows.Forms.Padding(4)
        Me.lstbMeta.Name = "lstbMeta"
        Me.lstbMeta.Size = New System.Drawing.Size(471, 148)
        Me.lstbMeta.TabIndex = 7
        '
        'btnBorrarMeta
        '
        Me.btnBorrarMeta.Location = New System.Drawing.Point(415, 537)
        Me.btnBorrarMeta.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBorrarMeta.Name = "btnBorrarMeta"
        Me.btnBorrarMeta.Size = New System.Drawing.Size(163, 28)
        Me.btnBorrarMeta.TabIndex = 8
        Me.btnBorrarMeta.Text = "Borrar seleccionado"
        Me.btnBorrarMeta.UseVisualStyleBackColor = True
        '
        'btnSelTdMeta
        '
        Me.btnSelTdMeta.Enabled = False
        Me.btnSelTdMeta.Location = New System.Drawing.Point(585, 300)
        Me.btnSelTdMeta.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSelTdMeta.Name = "btnSelTdMeta"
        Me.btnSelTdMeta.Size = New System.Drawing.Size(141, 28)
        Me.btnSelTdMeta.TabIndex = 10
        Me.btnSelTdMeta.Text = "Seleccionar todas"
        Me.btnSelTdMeta.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(251, 341)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Metas seleccionadas:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1091, 626)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Profesores seleccionados:"
        '
        'btnSelProf
        '
        Me.btnSelProf.Location = New System.Drawing.Point(1481, 586)
        Me.btnSelProf.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSelProf.Name = "btnSelProf"
        Me.btnSelProf.Size = New System.Drawing.Size(100, 28)
        Me.btnSelProf.TabIndex = 17
        Me.btnSelProf.Text = "Seleccionar"
        Me.btnSelProf.UseVisualStyleBackColor = True
        '
        'lstbProf
        '
        Me.lstbProf.FormattingEnabled = True
        Me.lstbProf.ItemHeight = 16
        Me.lstbProf.Location = New System.Drawing.Point(1095, 654)
        Me.lstbProf.Margin = New System.Windows.Forms.Padding(4)
        Me.lstbProf.Name = "lstbProf"
        Me.lstbProf.Size = New System.Drawing.Size(361, 148)
        Me.lstbProf.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(916, 586)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 16)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Profesorado a cargo:"
        '
        'cboProf
        '
        Me.cboProf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProf.FormattingEnabled = True
        Me.cboProf.Location = New System.Drawing.Point(1095, 586)
        Me.cboProf.Margin = New System.Windows.Forms.Padding(4)
        Me.cboProf.Name = "cboProf"
        Me.cboProf.Size = New System.Drawing.Size(367, 24)
        Me.cboProf.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1091, 341)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(173, 16)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Asignaturas seleccionados:"
        '
        'btnSelAsign
        '
        Me.btnSelAsign.Enabled = False
        Me.btnSelAsign.Location = New System.Drawing.Point(1481, 306)
        Me.btnSelAsign.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSelAsign.Name = "btnSelAsign"
        Me.btnSelAsign.Size = New System.Drawing.Size(100, 28)
        Me.btnSelAsign.TabIndex = 22
        Me.btnSelAsign.Text = "Seleccionar"
        Me.btnSelAsign.UseVisualStyleBackColor = True
        '
        'lstbAsign
        '
        Me.lstbAsign.FormattingEnabled = True
        Me.lstbAsign.ItemHeight = 16
        Me.lstbAsign.Location = New System.Drawing.Point(1095, 368)
        Me.lstbAsign.Margin = New System.Windows.Forms.Padding(4)
        Me.lstbAsign.Name = "lstbAsign"
        Me.lstbAsign.Size = New System.Drawing.Size(361, 148)
        Me.lstbAsign.TabIndex = 21
        '
        'lblasign
        '
        Me.lblasign.AutoSize = True
        Me.lblasign.Enabled = False
        Me.lblasign.Location = New System.Drawing.Point(916, 306)
        Me.lblasign.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblasign.Name = "lblasign"
        Me.lblasign.Size = New System.Drawing.Size(161, 16)
        Me.lblasign.TabIndex = 20
        Me.lblasign.Text = "Asignaturas involucradas:"
        '
        'cboAsign
        '
        Me.cboAsign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAsign.Enabled = False
        Me.cboAsign.FormattingEnabled = True
        Me.cboAsign.Location = New System.Drawing.Point(1095, 306)
        Me.cboAsign.Margin = New System.Windows.Forms.Padding(4)
        Me.cboAsign.Name = "cboAsign"
        Me.cboAsign.Size = New System.Drawing.Size(361, 24)
        Me.cboAsign.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(917, 256)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(140, 16)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Cursos que participan:"
        '
        'cboCurso
        '
        Me.cboCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCurso.FormattingEnabled = True
        Me.cboCurso.Location = New System.Drawing.Point(1095, 256)
        Me.cboCurso.Margin = New System.Windows.Forms.Padding(4)
        Me.cboCurso.Name = "cboCurso"
        Me.cboCurso.Size = New System.Drawing.Size(361, 24)
        Me.cboCurso.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(251, 626)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(177, 16)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Contratantes seleccionados:"
        '
        'btnSelContratante
        '
        Me.btnSelContratante.Location = New System.Drawing.Point(747, 581)
        Me.btnSelContratante.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSelContratante.Name = "btnSelContratante"
        Me.btnSelContratante.Size = New System.Drawing.Size(100, 28)
        Me.btnSelContratante.TabIndex = 32
        Me.btnSelContratante.Text = "Seleccionar"
        Me.btnSelContratante.UseVisualStyleBackColor = True
        '
        'lstbContratantes
        '
        Me.lstbContratantes.FormattingEnabled = True
        Me.lstbContratantes.ItemHeight = 16
        Me.lstbContratantes.Location = New System.Drawing.Point(255, 654)
        Me.lstbContratantes.Margin = New System.Windows.Forms.Padding(4)
        Me.lstbContratantes.Name = "lstbContratantes"
        Me.lstbContratantes.Size = New System.Drawing.Size(471, 148)
        Me.lstbContratantes.TabIndex = 31
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(47, 587)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(158, 16)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Seleccionar contratantes:"
        '
        'cboContratantes
        '
        Me.cboContratantes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboContratantes.FormattingEnabled = True
        Me.cboContratantes.Location = New System.Drawing.Point(249, 586)
        Me.cboContratantes.Margin = New System.Windows.Forms.Padding(4)
        Me.cboContratantes.Name = "cboContratantes"
        Me.cboContratantes.Size = New System.Drawing.Size(476, 24)
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
        Me.Label13.Location = New System.Drawing.Point(577, 71)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(131, 16)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Título de la iniciativa:"
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(753, 68)
        Me.txtTitulo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(367, 22)
        Me.txtTitulo.TabIndex = 36
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(688, 117)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(114, 16)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "Numero de horas:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(433, 164)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(101, 16)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "Fecha de inicio:"
        '
        'lblFinal
        '
        Me.lblFinal.AutoSize = True
        Me.lblFinal.Location = New System.Drawing.Point(860, 164)
        Me.lblFinal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFinal.Name = "lblFinal"
        Me.lblFinal.Size = New System.Drawing.Size(94, 16)
        Me.lblFinal.TabIndex = 41
        Me.lblFinal.Text = "Fecha de final:"
        '
        'btnAlta
        '
        Me.btnAlta.Location = New System.Drawing.Point(1331, 946)
        Me.btnAlta.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(363, 63)
        Me.btnAlta.TabIndex = 44
        Me.btnAlta.Text = "Dar de alta"
        Me.btnAlta.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(49, 946)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(363, 63)
        Me.btnReset.TabIndex = 45
        Me.btnReset.Text = "Reiniciar"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'numHoras
        '
        Me.numHoras.Location = New System.Drawing.Point(837, 113)
        Me.numHoras.Margin = New System.Windows.Forms.Padding(4)
        Me.numHoras.Name = "numHoras"
        Me.numHoras.Size = New System.Drawing.Size(160, 22)
        Me.numHoras.TabIndex = 46
        '
        'btnSelTdAsign
        '
        Me.btnSelTdAsign.Enabled = False
        Me.btnSelTdAsign.Location = New System.Drawing.Point(1589, 306)
        Me.btnSelTdAsign.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSelTdAsign.Name = "btnSelTdAsign"
        Me.btnSelTdAsign.Size = New System.Drawing.Size(141, 28)
        Me.btnSelTdAsign.TabIndex = 47
        Me.btnSelTdAsign.Text = "Seleccionar todas"
        Me.btnSelTdAsign.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboVerDatos)
        Me.GroupBox1.Location = New System.Drawing.Point(700, 880)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(437, 135)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ver datos de iniciativa"
        '
        'btnEliminar
        '
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Location = New System.Drawing.Point(137, 85)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(177, 44)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 41)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Código:"
        '
        'cboVerDatos
        '
        Me.cboVerDatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVerDatos.FormattingEnabled = True
        Me.cboVerDatos.Location = New System.Drawing.Point(88, 37)
        Me.cboVerDatos.Margin = New System.Windows.Forms.Padding(4)
        Me.cboVerDatos.Name = "cboVerDatos"
        Me.cboVerDatos.Size = New System.Drawing.Size(340, 24)
        Me.cboVerDatos.TabIndex = 0
        '
        'borrarcont
        '
        Me.borrarcont.Location = New System.Drawing.Point(356, 810)
        Me.borrarcont.Margin = New System.Windows.Forms.Padding(4)
        Me.borrarcont.Name = "borrarcont"
        Me.borrarcont.Size = New System.Drawing.Size(163, 28)
        Me.borrarcont.TabIndex = 50
        Me.borrarcont.Text = "Borrar seleccionado"
        Me.borrarcont.UseVisualStyleBackColor = True
        '
        'btnBorrarProf
        '
        Me.btnBorrarProf.Location = New System.Drawing.Point(1201, 810)
        Me.btnBorrarProf.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBorrarProf.Name = "btnBorrarProf"
        Me.btnBorrarProf.Size = New System.Drawing.Size(163, 28)
        Me.btnBorrarProf.TabIndex = 51
        Me.btnBorrarProf.Text = "Borrar seleccionado"
        Me.btnBorrarProf.UseVisualStyleBackColor = True
        '
        'btnBorrarAsign
        '
        Me.btnBorrarAsign.Location = New System.Drawing.Point(1196, 524)
        Me.btnBorrarAsign.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBorrarAsign.Name = "btnBorrarAsign"
        Me.btnBorrarAsign.Size = New System.Drawing.Size(163, 28)
        Me.btnBorrarAsign.TabIndex = 52
        Me.btnBorrarAsign.Text = "Borrar seleccionado"
        Me.btnBorrarAsign.UseVisualStyleBackColor = True
        '
        'calInicio
        '
        Me.calInicio.Location = New System.Drawing.Point(571, 164)
        Me.calInicio.Margin = New System.Windows.Forms.Padding(4)
        Me.calInicio.Name = "calInicio"
        Me.calInicio.Size = New System.Drawing.Size(261, 22)
        Me.calInicio.TabIndex = 53
        '
        'calFinal
        '
        Me.calFinal.Location = New System.Drawing.Point(971, 164)
        Me.calFinal.Margin = New System.Windows.Forms.Padding(4)
        Me.calFinal.Name = "calFinal"
        Me.calFinal.Size = New System.Drawing.Size(261, 22)
        Me.calFinal.TabIndex = 54
        '
        'logo1
        '
        Me.logo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.logo1.Location = New System.Drawing.Point(169, 42)
        Me.logo1.Margin = New System.Windows.Forms.Padding(4)
        Me.logo1.Name = "logo1"
        Me.logo1.Size = New System.Drawing.Size(180, 166)
        Me.logo1.TabIndex = 55
        Me.logo1.TabStop = False
        '
        'logo2
        '
        Me.logo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.logo2.Location = New System.Drawing.Point(1357, 42)
        Me.logo2.Margin = New System.Windows.Forms.Padding(4)
        Me.logo2.Name = "logo2"
        Me.logo2.Size = New System.Drawing.Size(212, 166)
        Me.logo2.TabIndex = 56
        Me.logo2.TabStop = False
        '
        'FrmAltaIniciativas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1749, 1050)
        Me.Controls.Add(Me.logo2)
        Me.Controls.Add(Me.logo1)
        Me.Controls.Add(Me.calFinal)
        Me.Controls.Add(Me.calInicio)
        Me.Controls.Add(Me.btnBorrarAsign)
        Me.Controls.Add(Me.btnBorrarProf)
        Me.Controls.Add(Me.borrarcont)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSelTdAsign)
        Me.Controls.Add(Me.numHoras)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnAlta)
        Me.Controls.Add(Me.lblFinal)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtTitulo)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnSelContratante)
        Me.Controls.Add(Me.lstbContratantes)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cboContratantes)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cboCurso)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnSelAsign)
        Me.Controls.Add(Me.lstbAsign)
        Me.Controls.Add(Me.lblasign)
        Me.Controls.Add(Me.cboAsign)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSelProf)
        Me.Controls.Add(Me.lstbProf)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboProf)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSelTdMeta)
        Me.Controls.Add(Me.btnBorrarMeta)
        Me.Controls.Add(Me.lstbMeta)
        Me.Controls.Add(Me.btnSelMeta)
        Me.Controls.Add(Me.lblmeta)
        Me.Controls.Add(Me.cboMeta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboOds)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmAltaIniciativas"
        Me.Text = "FrAltaIniciativas"
        CType(Me.numHoras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.logo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logo2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboOds As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblmeta As Label
    Friend WithEvents cboMeta As ComboBox
    Friend WithEvents btnSelMeta As Button
    Friend WithEvents lstbMeta As ListBox
    Friend WithEvents btnBorrarMeta As Button
    Friend WithEvents btnSelTdMeta As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSelProf As Button
    Friend WithEvents lstbProf As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cboProf As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSelAsign As Button
    Friend WithEvents lstbAsign As ListBox
    Friend WithEvents lblasign As Label
    Friend WithEvents cboAsign As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cboCurso As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnSelContratante As Button
    Friend WithEvents lstbContratantes As ListBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cboContratantes As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblFinal As Label
    Friend WithEvents btnAlta As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents numHoras As NumericUpDown
    Friend WithEvents btnSelTdAsign As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboVerDatos As ComboBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents borrarcont As Button
    Friend WithEvents btnBorrarProf As Button
    Friend WithEvents btnBorrarAsign As Button
    Friend WithEvents calInicio As DateTimePicker
    Friend WithEvents calFinal As DateTimePicker
    Friend WithEvents logo1 As PictureBox
    Friend WithEvents logo2 As PictureBox
End Class
