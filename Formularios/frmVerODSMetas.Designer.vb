﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerODSMetas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cboODS = New System.Windows.Forms.ComboBox()
        Me.dgvMetas = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbODS = New System.Windows.Forms.PictureBox()
        CType(Me.dgvMetas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbODS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboODS
        '
        Me.cboODS.FormattingEnabled = True
        Me.cboODS.Location = New System.Drawing.Point(34, 63)
        Me.cboODS.Name = "cboODS"
        Me.cboODS.Size = New System.Drawing.Size(1042, 21)
        Me.cboODS.TabIndex = 0
        '
        'dgvMetas
        '
        Me.dgvMetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMetas.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMetas.Location = New System.Drawing.Point(34, 114)
        Me.dgvMetas.Name = "dgvMetas"
        Me.dgvMetas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgvMetas.RowHeadersWidth = 51
        Me.dgvMetas.Size = New System.Drawing.Size(1042, 315)
        Me.dgvMetas.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(469, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Selecciona un ODS para ver sus metas:"
        '
        'pbODS
        '
        Me.pbODS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbODS.Location = New System.Drawing.Point(505, 446)
        Me.pbODS.Name = "pbODS"
        Me.pbODS.Size = New System.Drawing.Size(122, 112)
        Me.pbODS.TabIndex = 3
        Me.pbODS.TabStop = False
        '
        'frmVerODSMetas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1119, 594)
        Me.Controls.Add(Me.pbODS)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvMetas)
        Me.Controls.Add(Me.cboODS)
        Me.Name = "frmVerODSMetas"
        Me.Text = "VerODSMetas"
        CType(Me.dgvMetas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbODS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboODS As ComboBox
    Friend WithEvents dgvMetas As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents pbODS As PictureBox
End Class