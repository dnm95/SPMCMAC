<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CondicionesIniciales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CondicionesIniciales))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbClonacion = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbInicioTrat = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbDuracion = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbDias = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(248, 21)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Porcentaje de Células Cancerosas :"
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.NumericUpDown2.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown2.Location = New System.Drawing.Point(338, 86)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.NumericUpDown2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(154, 29)
        Me.NumericUpDown2.TabIndex = 41
        Me.NumericUpDown2.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 21)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Periodo de Clonación (días):"
        '
        'cmbClonacion
        '
        Me.cmbClonacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbClonacion.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbClonacion.FormattingEnabled = True
        Me.cmbClonacion.Items.AddRange(New Object() {"80", "100", "150"})
        Me.cmbClonacion.Location = New System.Drawing.Point(339, 135)
        Me.cmbClonacion.Name = "cmbClonacion"
        Me.cmbClonacion.Size = New System.Drawing.Size(154, 29)
        Me.cmbClonacion.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(254, 21)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Inicio del Tratamiento (generación):"
        '
        'cmbInicioTrat
        '
        Me.cmbInicioTrat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbInicioTrat.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbInicioTrat.FormattingEnabled = True
        Me.cmbInicioTrat.Items.AddRange(New Object() {"1825", "3650", "5475"})
        Me.cmbInicioTrat.Location = New System.Drawing.Point(339, 183)
        Me.cmbInicioTrat.Name = "cmbInicioTrat"
        Me.cmbInicioTrat.Size = New System.Drawing.Size(153, 29)
        Me.cmbInicioTrat.TabIndex = 46
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 284)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(285, 21)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Duración Total del Tratamiento (meses):"
        '
        'cmbDuracion
        '
        Me.cmbDuracion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDuracion.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDuracion.FormattingEnabled = True
        Me.cmbDuracion.Items.AddRange(New Object() {"4", "5", "6"})
        Me.cmbDuracion.Location = New System.Drawing.Point(339, 281)
        Me.cmbDuracion.Name = "cmbDuracion"
        Me.cmbDuracion.Size = New System.Drawing.Size(154, 29)
        Me.cmbDuracion.TabIndex = 53
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(219, 21)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Periodo del tratamiento (días):"
        '
        'cmbDias
        '
        Me.cmbDias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDias.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDias.FormattingEnabled = True
        Me.cmbDias.Items.AddRange(New Object() {"7", "10", "15", "20"})
        Me.cmbDias.Location = New System.Drawing.Point(340, 231)
        Me.cmbDias.Name = "cmbDias"
        Me.cmbDias.Size = New System.Drawing.Size(154, 29)
        Me.cmbDias.TabIndex = 55
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft NeoGothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(436, 36)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "Condiciones Iniciales de Simulación"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 441)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(315, 21)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Ruta y Nombre de Guardado (archivo CSV): "
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(338, 438)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(154, 29)
        Me.btnClear.TabIndex = 58
        Me.btnClear.Text = "Examinar...."
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(326, 501)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(168, 25)
        Me.CheckBox1.TabIndex = 59
        Me.CheckBox1.Text = "Generar Estadísticas"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(16, 501)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(219, 25)
        Me.CheckBox2.TabIndex = 60
        Me.CheckBox2.Text = "Generar Simulación Gráfica"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'btnApply
        '
        Me.btnApply.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnApply.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnApply.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApply.Location = New System.Drawing.Point(11, 575)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(98, 29)
        Me.btnApply.TabIndex = 61
        Me.btnApply.Text = "Aplicar"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(395, 575)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(98, 29)
        Me.btnCancel.TabIndex = 62
        Me.btnCancel.Text = "Cancelar"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 335)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(224, 21)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "Tamaño de Filas para la Matriz:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 390)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(263, 21)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "Tamaño de Columnas para la Matriz:"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(339, 334)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {3000, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(155, 26)
        Me.NumericUpDown1.TabIndex = 65
        Me.NumericUpDown1.Value = New Decimal(New Integer() {150, 0, 0, 0})
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown3.Location = New System.Drawing.Point(339, 390)
        Me.NumericUpDown3.Maximum = New Decimal(New Integer() {3000, 0, 0, 0})
        Me.NumericUpDown3.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(155, 26)
        Me.NumericUpDown3.TabIndex = 66
        Me.NumericUpDown3.Value = New Decimal(New Integer() {150, 0, 0, 0})
        '
        'CondicionesIniciales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 616)
        Me.Controls.Add(Me.NumericUpDown3)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbDias)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbDuracion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbInicioTrat)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbClonacion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CondicionesIniciales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nueva Simulación"
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbClonacion As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbInicioTrat As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbDuracion As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbDias As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents btnClear As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents btnApply As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents NumericUpDown3 As NumericUpDown
End Class
