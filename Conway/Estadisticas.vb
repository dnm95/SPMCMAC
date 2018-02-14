Imports System.Windows.Forms.DataVisualization.Charting
Imports ClonalSelection.Main
Public Class Estadisticas

    Public infectados As Integer = 0
    Public enTratamiento As Integer = 0
    Public generacion As Integer = 0
    Public Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Hacer que el form inicie en pantalla maximizada
        Me.Location = New Point(0, 0)
        Me.Size = SystemInformation.PrimaryMonitorSize
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized

        'Dar estilo a las graficas
        Me.Chart1.Series(0).BorderWidth = 2.4
        Me.Chart1.Series(1).BorderWidth = 2.4
        Me.Chart1.Series(1).Color = Color.DarkGreen

        btnSaveGraph.Enabled = False

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Me.Chart1.Series("Celulas Cancerosas").Points.AddY(infectados)
        Me.Chart1.Series("Celulas Tratadas").Points.AddY(enTratamiento)

        txtCancer.Text = infectados
        txtTratadas.Text = enTratamiento
        txtDias.Text = generacion
        Dim mean As Double = Chart1.DataManipulator.Statistics.Mean("Celulas Cancerosas")
        Dim median As Double = Chart1.DataManipulator.Statistics.Median("Celulas Cancerosas")
        Dim meanTratadas As Double = Chart1.DataManipulator.Statistics.Mean("Celulas Tratadas")

        txtMedia.Text = mean
        txtMediana.Text = median
        txtMediaTratadas.Text = meanTratadas

    End Sub

    Public Sub LimpiarForm()
        Me.Chart1.Series("Celulas Cancerosas").Points.Clear()
        Me.Chart1.Series("Celulas Tratadas").Points.Clear()
        txtCancer.Clear()
        txtDias.Clear()
        txtMedia.Clear()
        txtMediana.Clear()
        txtTratadas.Clear()
        txtMediaTratadas.Clear()
    End Sub

    Private Sub Estadisticas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Main.btnIniciar.Text = "Iniciar Simulación"
        Main.Timer1.Enabled = False
        Matriz.Timer1.Enabled = False
        Main.TimerCronometro.Stop()
        Main.AbrirArchivoCSVToolStripMenuItem.Enabled = True
    End Sub

    Private Sub btnSaveGraph_Click(sender As Object, e As EventArgs) Handles btnSaveGraph.Click
        Try
            SaveFileDialog1.Filter = "PNG Files (*.png*)|*.png"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.Chart1.SaveImage(SaveFileDialog1.FileName, ChartImageFormat.Png)
                MessageBox.Show("Imagen Guardada en " & SaveFileDialog1.FileName, "Exportar Gráfico", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Se produjo un error al intentar guardar el archivo", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class