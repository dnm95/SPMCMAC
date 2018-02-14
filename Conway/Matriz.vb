Public Class Matriz
    Public banderaZoomIn As Integer
    Public ancho As Double
    Public alto As Double

    Private Sub Matriz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(0, 0)
        Me.Size = SystemInformation.PrimaryMonitorSize
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized

        ancho = Grafiquito1.Width
        alto = Grafiquito1.Height
    End Sub

    Public Sub ZoomIn()
        'Aumentar contador de zoom
        banderaZoomIn += 1

        'Solo se puede hacer 10 veces zoom
        If banderaZoomIn <= 10 Then
            Grafiquito1.Width *= 1.2
            Grafiquito1.Height *= 1.2
        Else
            MessageBox.Show("Solo se puede hacer un máximo de 10 zooms", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Public Sub ZoomOut()
        'Grafiquito1.Width *= 0.8
        'Grafiquito1.Height *= 0.8
        Grafiquito1.Width = ancho
        Grafiquito1.Height = alto
        banderaZoomIn = 0
    End Sub

    Private Sub btnZooIn_Click(sender As Object, e As EventArgs) Handles btnZooIn.Click
        ZoomIn()
    End Sub

    Private Sub btnZoomOut_Click(sender As Object, e As EventArgs) Handles btnZoomOut.Click
        ZoomOut()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Grafiquito1.SetMatriz(Main.modelo.GetMatriz)
    End Sub

    Private Sub Matriz_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Main.btnIniciar.Text = "Iniciar Simulación"
        Main.Timer1.Enabled = False
        Estadisticas.Timer1.Enabled = False
        Main.TimerCronometro.Stop()
        Main.AbrirArchivoCSVToolStripMenuItem.Enabled = True
    End Sub
End Class