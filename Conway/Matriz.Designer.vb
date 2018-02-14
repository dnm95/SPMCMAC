<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Matriz
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Matriz))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Grafiquito1 = New ClonalSelection.GraficaMatriz()
        Me.btnZoomOut = New System.Windows.Forms.Button()
        Me.btnZooIn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.Grafiquito1)
        Me.Panel1.Location = New System.Drawing.Point(-4, 47)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1362, 657)
        Me.Panel1.TabIndex = 56
        '
        'Grafiquito1
        '
        Me.Grafiquito1.BackColor = System.Drawing.Color.White
        Me.Grafiquito1.Location = New System.Drawing.Point(8, 3)
        Me.Grafiquito1.Name = "Grafiquito1"
        Me.Grafiquito1.Size = New System.Drawing.Size(1354, 638)
        Me.Grafiquito1.TabIndex = 0
        '
        'btnZoomOut
        '
        Me.btnZoomOut.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnZoomOut.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZoomOut.Image = CType(resources.GetObject("btnZoomOut.Image"), System.Drawing.Image)
        Me.btnZoomOut.Location = New System.Drawing.Point(68, 12)
        Me.btnZoomOut.Name = "btnZoomOut"
        Me.btnZoomOut.Size = New System.Drawing.Size(67, 29)
        Me.btnZoomOut.TabIndex = 58
        Me.btnZoomOut.UseVisualStyleBackColor = True
        '
        'btnZooIn
        '
        Me.btnZooIn.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnZooIn.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZooIn.Image = CType(resources.GetObject("btnZooIn.Image"), System.Drawing.Image)
        Me.btnZooIn.Location = New System.Drawing.Point(5, 12)
        Me.btnZooIn.Name = "btnZooIn"
        Me.btnZooIn.Size = New System.Drawing.Size(67, 29)
        Me.btnZooIn.TabIndex = 57
        Me.btnZooIn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(166, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(206, 21)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Célula Infectada (Cancerosa)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(425, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 21)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Célula en Tratamiento"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Red
        Me.Panel2.Location = New System.Drawing.Point(378, 15)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(29, 18)
        Me.Panel2.TabIndex = 61
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(593, 15)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(29, 18)
        Me.Panel3.TabIndex = 62
        '
        'Timer1
        '
        Me.Timer1.Interval = 60
        '
        'Matriz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 716)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnZoomOut)
        Me.Controls.Add(Me.btnZooIn)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Matriz"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Matriz de Simulación"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Grafiquito1 As GraficaMatriz
    Friend WithEvents btnZoomOut As Button
    Friend WithEvents btnZooIn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Timer1 As Timer
End Class
