<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Estadisticas
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Estadisticas))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMedia = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCancer = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTratadas = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDias = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMediana = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.txtMediaTratadas = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSaveGraph = New System.Windows.Forms.Button()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 60
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend1.IsTextAutoFit = False
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(0, 1)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Color = System.Drawing.Color.Red
        Series1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series1.Legend = "Legend1"
        Series1.Name = "Celulas Cancerosas"
        Series1.YValuesPerPoint = 2
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series2.Legend = "Legend1"
        Series2.Name = "Celulas Tratadas"
        Series2.YValuesPerPoint = 2
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(1029, 669)
        Me.Chart1.TabIndex = 1
        Me.Chart1.Text = "Chart1"
        Title1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.Name = "Title1"
        Title1.Text = "Infectadas vs Tratadas"
        Me.Chart1.Titles.Add(Title1)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft NeoGothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1028, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Media de Células Cancerosas:"
        '
        'txtMedia
        '
        Me.txtMedia.BackColor = System.Drawing.Color.White
        Me.txtMedia.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMedia.Location = New System.Drawing.Point(1032, 174)
        Me.txtMedia.Name = "txtMedia"
        Me.txtMedia.ReadOnly = True
        Me.txtMedia.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtMedia.Size = New System.Drawing.Size(278, 29)
        Me.txtMedia.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft NeoGothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1024, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 43)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Estadísticas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft NeoGothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1027, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 26)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Células Cancerosas:"
        '
        'txtCancer
        '
        Me.txtCancer.BackColor = System.Drawing.Color.White
        Me.txtCancer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCancer.Location = New System.Drawing.Point(1032, 104)
        Me.txtCancer.Name = "txtCancer"
        Me.txtCancer.ReadOnly = True
        Me.txtCancer.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtCancer.Size = New System.Drawing.Size(278, 29)
        Me.txtCancer.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft NeoGothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1028, 285)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(213, 26)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Células en Tratamiento:"
        '
        'txtTratadas
        '
        Me.txtTratadas.BackColor = System.Drawing.Color.White
        Me.txtTratadas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTratadas.Location = New System.Drawing.Point(1032, 312)
        Me.txtTratadas.Name = "txtTratadas"
        Me.txtTratadas.ReadOnly = True
        Me.txtTratadas.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtTratadas.Size = New System.Drawing.Size(278, 29)
        Me.txtTratadas.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft NeoGothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1028, 436)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(172, 26)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Días Transcurridos:"
        '
        'txtDias
        '
        Me.txtDias.BackColor = System.Drawing.Color.White
        Me.txtDias.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDias.Location = New System.Drawing.Point(1032, 463)
        Me.txtDias.Name = "txtDias"
        Me.txtDias.ReadOnly = True
        Me.txtDias.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtDias.Size = New System.Drawing.Size(278, 29)
        Me.txtDias.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft NeoGothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1028, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(283, 26)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Mediana de Células Cancerosas:"
        '
        'txtMediana
        '
        Me.txtMediana.BackColor = System.Drawing.Color.White
        Me.txtMediana.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMediana.Location = New System.Drawing.Point(1035, 244)
        Me.txtMediana.Name = "txtMediana"
        Me.txtMediana.ReadOnly = True
        Me.txtMediana.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtMediana.Size = New System.Drawing.Size(275, 29)
        Me.txtMediana.TabIndex = 16
        '
        'txtMediaTratadas
        '
        Me.txtMediaTratadas.BackColor = System.Drawing.Color.White
        Me.txtMediaTratadas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMediaTratadas.Location = New System.Drawing.Point(1032, 387)
        Me.txtMediaTratadas.Name = "txtMediaTratadas"
        Me.txtMediaTratadas.ReadOnly = True
        Me.txtMediaTratadas.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtMediaTratadas.Size = New System.Drawing.Size(278, 29)
        Me.txtMediaTratadas.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft NeoGothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1028, 360)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(239, 26)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Media de Células Tratadas:"
        '
        'btnSaveGraph
        '
        Me.btnSaveGraph.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSaveGraph.Font = New System.Drawing.Font("Microsoft NeoGothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveGraph.Location = New System.Drawing.Point(1032, 530)
        Me.btnSaveGraph.Name = "btnSaveGraph"
        Me.btnSaveGraph.Size = New System.Drawing.Size(279, 38)
        Me.btnSaveGraph.TabIndex = 19
        Me.btnSaveGraph.Text = "Exportar Gráfica"
        Me.btnSaveGraph.UseVisualStyleBackColor = False
        '
        'Estadisticas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1315, 671)
        Me.Controls.Add(Me.btnSaveGraph)
        Me.Controls.Add(Me.txtMediaTratadas)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtMediana)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDias)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTratadas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCancer)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMedia)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Chart1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Estadisticas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estadísticas"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMedia As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCancer As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTratadas As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDias As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMediana As TextBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents txtMediaTratadas As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnSaveGraph As Button
End Class
