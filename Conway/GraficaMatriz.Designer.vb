<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GraficaMatriz
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PB = New System.Windows.Forms.PictureBox()
        CType(Me.PB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PB
        '
        Me.PB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PB.Location = New System.Drawing.Point(0, 0)
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(302, 248)
        Me.PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PB.TabIndex = 0
        Me.PB.TabStop = False
        '
        'GraficaMatriz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.PB)
        Me.Name = "GraficaMatriz"
        Me.Size = New System.Drawing.Size(302, 248)
        CType(Me.PB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PB As System.Windows.Forms.PictureBox

End Class
