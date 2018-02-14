Public Class Main

    Public modelo As New Automata(300, 300) 'Crear objeto de tipo automata
    Public infectadas As Integer
    Public muertas As Integer
    Public tratamiento As Integer
    Public bandera As Integer
    Public banderaRedim As Integer
    Public banderaEstat As Integer
    Public banderaZoomIn As Integer
    Public porcentajeInfectadas As Byte
    Public clonacion As Integer
    Public duracion As Integer
    Public suministro As Integer
    Public inicioTrat As Integer
    Public tamFilas As Integer
    Public tamColumnas As Integer
    Public csvFile As String
    Public outFile As IO.StreamWriter
    Public banderaGrafica As Boolean
    Public banderaEstadisticas As Boolean

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Hacer que el form inicie en pantalla maximizada
        Me.Location = New Point(0, 0)
        Me.Size = SystemInformation.PrimaryMonitorSize
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized

        'Centrar contenido de los textboxes
        txtClonacion.TextAlign = HorizontalAlignment.Center
        txtDuracionTotal.TextAlign = HorizontalAlignment.Center
        txtGeneracion.TextAlign = HorizontalAlignment.Center
        txtInfectadas.TextAlign = HorizontalAlignment.Center
        txtInicioTrat.TextAlign = HorizontalAlignment.Center
        txtMuertas.TextAlign = HorizontalAlignment.Center
        txtOcupacion.TextAlign = HorizontalAlignment.Center
        txtPeriodoTrat.TextAlign = HorizontalAlignment.Center
        txtTratamiento.TextAlign = HorizontalAlignment.Center
        txtSimulacion.TextAlign = HorizontalAlignment.Center
        txtEstadisticas.TextAlign = HorizontalAlignment.Center
        txtDosis.TextAlign = HorizontalAlignment.Center

        'Activar el boton de iniciar simulacion
        btnIniciar.Enabled = False

    End Sub

    Public Sub GeneraCSV()
        'Preparar archivo csv
        outFile.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"))
    End Sub
    Public Sub AplicarCondiciones()
        modelo._clonacion = clonacion
        modelo._duracion = duracion
        modelo._suministro = suministro
        modelo._inicioTrat = inicioTrat
        Dim numeroDosis As Integer = (duracion * 30) / suministro

        txtClonacion.Text = clonacion.ToString + " generaciones"
        txtDuracionTotal.Text = duracion.ToString + " meses"
        txtInicioTrat.Text = inicioTrat.ToString + " generación"
        txtPeriodoTrat.Text = "cada " + suministro.ToString + " días"
        txtDosis.Text = numeroDosis

        If banderaGrafica = True Then
            txtSimulacion.Text = "Activado"
        Else
            txtSimulacion.Text = "Desactivado"
        End If

        If banderaEstadisticas = True Then
            txtEstadisticas.Text = "Activado"
        Else
            txtEstadisticas.Text = "Desactivado"
        End If

        'Poner encabezados del archivo csv
        outFile.WriteLine("Periodo de Clonación:," & clonacion & " generación")
        outFile.WriteLine("Inicio del tratamiento:," & inicioTrat & " generación")
        outFile.WriteLine("Periodo de Suministro del Tratamiento:," & suministro & " días")
        outFile.WriteLine("Duración del Tratamiento:," & duracion & " meses")
        outFile.WriteLine("No_Generación, Células Infectadas, Celulas en Tratamiento, Celulas Muertas")

        AbrirArchivoCSVToolStripMenuItem.Enabled = True
    End Sub

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        If btnIniciar.Text = "Iniciar Simulación" Then
            bandera += 1
            If bandera = 1 Then
                modelo.AleatorioMatriz(porcentajeInfectadas)
                'modelo.CelulaAleatoria()
            End If
            If banderaGrafica = True Then
                Matriz.Show()
                Matriz.Timer1.Enabled = True
            End If

            'Activar formulario de estadisticas si el usuario marco el checkbox
            If banderaEstadisticas = True Then
                Estadisticas.Show()
                Estadisticas.Timer1.Enabled = True
            End If

            'Activar boton de detener la simulacion
            btnIniciar.Text = "Detener Simulación"

            'Iniciar timer, es el encargado de realizar la simulacion
            Timer1.Enabled = True

            'Iniciar timer de cronometro
            'Cronometro.Show()
            'Cronometro.TimerCronometro.Start()

            'Desactivar funcion de abrir archivo csv
            AbrirArchivoCSVToolStripMenuItem.Enabled = False

            'Desactivar boton de exportar gráfica
            Estadisticas.btnSaveGraph.Enabled = False

        Else
            'Activar barra de propiedades
            btnIniciar.Text = "Iniciar Simulación"
            Timer1.Enabled = False
            Estadisticas.Timer1.Enabled = False
            Matriz.Timer1.Enabled = False
            'Cronometro.TimerCronometro.Stop()
            AbrirArchivoCSVToolStripMenuItem.Enabled = True
            Estadisticas.btnSaveGraph.Enabled = True
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        GeneraSimulacion()
    End Sub

    Private Sub GeneraSimulacion()
        'Calculo el porcentaje de ocupación actual y celulas vivas
        Dim ocu As Integer = CInt(modelo.Ocupacion * 100)
        infectadas = CInt(modelo.Infectados)
        muertas = CInt(modelo.Muertas)
        tratamiento = CInt(modelo.CantTratamiento)

        If banderaEstadisticas = True Then
            Estadisticas.infectados = infectadas
            Estadisticas.enTratamiento = tratamiento
            Estadisticas.generacion = modelo.Generacion
        End If

        'Ejecutar las reglas del AC
        modelo.ReglasAC()

        If banderaGrafica = True Then
            'Actualizar grafico de la matriz, con los nuevos valores de las celulas
            Matriz.Grafiquito1.SetMatriz(modelo.GetMatriz)
        End If

        'Mostrar valores de simulacion en los cuadros de texto
        txtGeneracion.Text = modelo.Generacion
        txtOcupacion.Text = ocu.ToString + "%"
        txtInfectadas.Text = infectadas
        txtMuertas.Text = muertas
        txtTratamiento.Text = tratamiento

        'Escribir en el archivo csv los valores
        outFile.WriteLine(modelo.Generacion & ", " & modelo.Infectados & ", " & modelo.CantTratamiento & ", " & modelo.Muertas)

        'Siempre estar validando que haya por lo menos una celula infectada
        If modelo.AlgunoInfectado() = False Then
            'Activar barra de propiedades
            btnIniciar.Text = "Iniciar Simulación"
            btnIniciar.Enabled = False
            Timer1.Enabled = False
            Estadisticas.Timer1.Enabled = False
            Estadisticas.btnSaveGraph.Enabled = True

            'Mostrar mensaje de simulacion terminada
            MessageBox.Show("Simulación Finalizada, no hay células infectadas.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'Limpiar matriz
            LimpiarMatriz()

            txtInfectadas.Text = "0"
            If banderaEstadisticas = True Then
                Estadisticas.txtCancer.Text = "0"
            End If

            'Cerrar archivo csv
            outFile.Close()
        End If

    End Sub

    Public Sub LimpiarMatriz()
        bandera = 0
        modelo.BorrarMatriz()
        Matriz.Grafiquito1.SetMatriz(modelo.GetMatriz)
    End Sub

    Public Sub LimpiarFormulario()
        txtInfectadas.Clear()
        txtMuertas.Clear()
        txtTratamiento.Clear()
        txtOcupacion.Clear()
        txtGeneracion.Clear()
        txtDosis.Clear()
        Cronometro.Label21.Text = "00"
        Cronometro.Label18.Text = "00"
        Cronometro.Text = "00"
        Cronometro.Text = "00"
    End Sub

    Public Sub RedimensionarMatriz()
        'Crear nueva instancia del automata con los nuevos valore de redimension
        modelo = New Automata(tamFilas, tamColumnas)
        Matriz.Grafiquito1.SetMatriz(modelo.GetMatriz)

        'Graficar la nueva matriz
        Matriz.Grafiquito1.Graficar()

        'Limpiar matriz tras la redimension
        LimpiarMatriz()

        bandera = 0
    End Sub

    Private Sub prueba_FormClosed(sender As Object, e As FormClosedEventArgs)
        outFile.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub ManualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManualToolStripMenuItem.Click
        Dim FilePath As String = My.Application.Info.DirectoryPath & "\Manual_Usuario.pdf"
        Try
            Process.Start(FilePath)
        Catch ex As Exception
            MessageBox.Show("No se encontró un lector de archivos PDF.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Acerca.Show()
    End Sub

    Private Sub NuevaSimulaciónToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles NuevaSimulaciónToolStripMenuItem.Click
        CondicionesIniciales.Show()
    End Sub

    Private Sub AbrirArchivoCSVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirArchivoCSVToolStripMenuItem.Click
        Dim FilePath As String = csvFile
        Try
            Process.Start(FilePath)
        Catch ex As Exception
            MessageBox.Show("No se pudo abrir el archivo CSV.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class