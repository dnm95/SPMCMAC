<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaSimulaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirArchivoCSVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtDosis = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtEstadisticas = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSimulacion = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDuracionTotal = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPeriodoTrat = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtInicioTrat = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtClonacion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMuertas = New System.Windows.Forms.TextBox()
        Me.txtTratamiento = New System.Windows.Forms.TextBox()
        Me.txtInfectadas = New System.Windows.Forms.TextBox()
        Me.txtOcupacion = New System.Windows.Forms.TextBox()
        Me.txtGeneracion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TimerCronometro = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnIniciar
        '
        Me.btnIniciar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnIniciar.Font = New System.Drawing.Font("Microsoft NeoGothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIniciar.Location = New System.Drawing.Point(583, 624)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(200, 40)
        Me.btnIniciar.TabIndex = 55
        Me.btnIniciar.Text = "Iniciar Simulación"
        Me.btnIniciar.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 60
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1354, 28)
        Me.MenuStrip1.TabIndex = 58
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaSimulaciónToolStripMenuItem, Me.AbrirArchivoCSVToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(71, 24)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'NuevaSimulaciónToolStripMenuItem
        '
        Me.NuevaSimulaciónToolStripMenuItem.Name = "NuevaSimulaciónToolStripMenuItem"
        Me.NuevaSimulaciónToolStripMenuItem.Size = New System.Drawing.Size(197, 24)
        Me.NuevaSimulaciónToolStripMenuItem.Text = "&Nueva Simulación"
        '
        'AbrirArchivoCSVToolStripMenuItem
        '
        Me.AbrirArchivoCSVToolStripMenuItem.Enabled = False
        Me.AbrirArchivoCSVToolStripMenuItem.Name = "AbrirArchivoCSVToolStripMenuItem"
        Me.AbrirArchivoCSVToolStripMenuItem.Size = New System.Drawing.Size(197, 24)
        Me.AbrirArchivoCSVToolStripMenuItem.Text = "Abrir Archivo CSV"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(197, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManualToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(63, 24)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'ManualToolStripMenuItem
        '
        Me.ManualToolStripMenuItem.Name = "ManualToolStripMenuItem"
        Me.ManualToolStripMenuItem.Size = New System.Drawing.Size(204, 24)
        Me.ManualToolStripMenuItem.Text = "Manual de Usuario"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(204, 24)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca del Sistema"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft NeoGothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(199, 28)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Generación (Actual):"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.txtDosis)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.txtEstadisticas)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.txtSimulacion)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtDuracionTotal)
        Me.Panel1.Controls.Add(Me.btnIniciar)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtPeriodoTrat)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtInicioTrat)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtClonacion)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtMuertas)
        Me.Panel1.Controls.Add(Me.txtTratamiento)
        Me.Panel1.Controls.Add(Me.txtInfectadas)
        Me.Panel1.Controls.Add(Me.txtOcupacion)
        Me.Panel1.Controls.Add(Me.txtGeneracion)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(1, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1367, 685)
        Me.Panel1.TabIndex = 60
        '
        'txtDosis
        '
        Me.txtDosis.Enabled = False
        Me.txtDosis.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDosis.Location = New System.Drawing.Point(1070, 383)
        Me.txtDosis.Name = "txtDosis"
        Me.txtDosis.Size = New System.Drawing.Size(271, 31)
        Me.txtDosis.TabIndex = 92
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft NeoGothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(701, 386)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(275, 28)
        Me.Label14.TabIndex = 91
        Me.Label14.Text = "Total de Dosis a Suministrar:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft NeoGothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(1309, 173)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(34, 28)
        Me.Label21.TabIndex = 90
        Me.Label21.Text = "00"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft NeoGothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(9, 327)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(525, 43)
        Me.Label13.TabIndex = 82
        Me.Label13.Text = "Condiciones Iniciales de Simulación"
        '
        'txtEstadisticas
        '
        Me.txtEstadisticas.Enabled = False
        Me.txtEstadisticas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstadisticas.Location = New System.Drawing.Point(1072, 120)
        Me.txtEstadisticas.Name = "txtEstadisticas"
        Me.txtEstadisticas.Size = New System.Drawing.Size(271, 31)
        Me.txtEstadisticas.TabIndex = 81
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft NeoGothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(701, 117)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(277, 28)
        Me.Label12.TabIndex = 80
        Me.Label12.Text = "Visualización de Estadísticas:"
        '
        'txtSimulacion
        '
        Me.txtSimulacion.Enabled = False
        Me.txtSimulacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSimulacion.Location = New System.Drawing.Point(1072, 68)
        Me.txtSimulacion.Name = "txtSimulacion"
        Me.txtSimulacion.Size = New System.Drawing.Size(271, 31)
        Me.txtSimulacion.TabIndex = 79
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft NeoGothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(701, 65)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(365, 28)
        Me.Label11.TabIndex = 78
        Me.Label11.Text = "Visualización Gráfica de la Simulación:"
        '
        'txtDuracionTotal
        '
        Me.txtDuracionTotal.Enabled = False
        Me.txtDuracionTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDuracionTotal.Location = New System.Drawing.Point(399, 549)
        Me.txtDuracionTotal.Name = "txtDuracionTotal"
        Me.txtDuracionTotal.Size = New System.Drawing.Size(271, 31)
        Me.txtDuracionTotal.TabIndex = 77
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft NeoGothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 549)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(305, 28)
        Me.Label10.TabIndex = 76
        Me.Label10.Text = "Duración Total del Tratamiento:"
        '
        'txtPeriodoTrat
        '
        Me.txtPeriodoTrat.Enabled = False
        Me.txtPeriodoTrat.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeriodoTrat.Location = New System.Drawing.Point(399, 492)
        Me.txtPeriodoTrat.Name = "txtPeriodoTrat"
        Me.txtPeriodoTrat.Size = New System.Drawing.Size(271, 31)
        Me.txtPeriodoTrat.TabIndex = 75
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft NeoGothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 492)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(240, 28)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "Periodo del Tratamiento:"
        '
        'txtInicioTrat
        '
        Me.txtInicioTrat.Enabled = False
        Me.txtInicioTrat.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInicioTrat.Location = New System.Drawing.Point(399, 437)
        Me.txtInicioTrat.Name = "txtInicioTrat"
        Me.txtInicioTrat.Size = New System.Drawing.Size(271, 31)
        Me.txtInicioTrat.TabIndex = 73
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft NeoGothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 437)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(219, 28)
        Me.Label8.TabIndex = 72
        Me.Label8.Text = "Inicio del Tratamiento:"
        '
        'txtClonacion
        '
        Me.txtClonacion.Enabled = False
        Me.txtClonacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClonacion.Location = New System.Drawing.Point(399, 386)
        Me.txtClonacion.Name = "txtClonacion"
        Me.txtClonacion.Size = New System.Drawing.Size(271, 31)
        Me.txtClonacion.TabIndex = 71
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft NeoGothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 386)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(162, 28)
        Me.Label7.TabIndex = 70
        Me.Label7.Text = "Clonación Cada:"
        '
        'txtMuertas
        '
        Me.txtMuertas.Enabled = False
        Me.txtMuertas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMuertas.Location = New System.Drawing.Point(399, 270)
        Me.txtMuertas.Name = "txtMuertas"
        Me.txtMuertas.Size = New System.Drawing.Size(271, 31)
        Me.txtMuertas.TabIndex = 69
        '
        'txtTratamiento
        '
        Me.txtTratamiento.Enabled = False
        Me.txtTratamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTratamiento.Location = New System.Drawing.Point(399, 221)
        Me.txtTratamiento.Name = "txtTratamiento"
        Me.txtTratamiento.Size = New System.Drawing.Size(271, 31)
        Me.txtTratamiento.TabIndex = 68
        '
        'txtInfectadas
        '
        Me.txtInfectadas.Enabled = False
        Me.txtInfectadas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInfectadas.Location = New System.Drawing.Point(399, 170)
        Me.txtInfectadas.Name = "txtInfectadas"
        Me.txtInfectadas.Size = New System.Drawing.Size(271, 31)
        Me.txtInfectadas.TabIndex = 67
        '
        'txtOcupacion
        '
        Me.txtOcupacion.Enabled = False
        Me.txtOcupacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOcupacion.Location = New System.Drawing.Point(399, 117)
        Me.txtOcupacion.Name = "txtOcupacion"
        Me.txtOcupacion.Size = New System.Drawing.Size(271, 31)
        Me.txtOcupacion.TabIndex = 66
        '
        'txtGeneracion
        '
        Me.txtGeneracion.Enabled = False
        Me.txtGeneracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGeneracion.Location = New System.Drawing.Point(399, 65)
        Me.txtGeneracion.Name = "txtGeneracion"
        Me.txtGeneracion.Size = New System.Drawing.Size(271, 31)
        Me.txtGeneracion.TabIndex = 65
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft NeoGothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(359, 43)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Resumen de Simulación"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft NeoGothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 270)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(306, 28)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Celdas Disponibles en la Matriz:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft NeoGothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(327, 28)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Células en Tratamiento (Actuales):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft NeoGothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(282, 28)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Células Infectadas (Actuales):"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft NeoGothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(309, 28)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Ocupación de la Matriz (Actual):"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 716)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simulador del Proceso de Metastasis"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevaSimulaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnIniciar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMuertas As TextBox
    Friend WithEvents txtTratamiento As TextBox
    Friend WithEvents txtInfectadas As TextBox
    Friend WithEvents txtOcupacion As TextBox
    Friend WithEvents txtGeneracion As TextBox
    Friend WithEvents txtClonacion As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtInicioTrat As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPeriodoTrat As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtDuracionTotal As TextBox
    Friend WithEvents txtSimulacion As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtEstadisticas As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TimerCronometro As Timer
    Friend WithEvents Label21 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtDosis As TextBox
    Friend WithEvents AbrirArchivoCSVToolStripMenuItem As ToolStripMenuItem
End Class
