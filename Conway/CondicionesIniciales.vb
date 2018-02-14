Public Class CondicionesIniciales
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Try
            SaveFileDialog1.Filter = "CSV Files (*.csv*)|*.csv"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                Main.csvFile = SaveFileDialog1.FileName
                Main.outFile = My.Computer.FileSystem.OpenTextFileWriter(SaveFileDialog1.FileName, False)
                Main.GeneraCSV()
                MessageBox.Show("Archivo CSV creado en " & SaveFileDialog1.FileName, "Nueva Simulación", MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnApply.Enabled = True
                btnClear.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show("Se produjo un error al intentar guardar el archivo", "Creación de Archivo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Main.Show()
        Me.Close()
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        Main.clonacion = (Convert.ToInt32(cmbClonacion.SelectedItem))
        Main.duracion = (Convert.ToInt32(cmbDuracion.SelectedItem))
        Main.suministro = (Convert.ToInt32(cmbDias.SelectedItem))
        Main.inicioTrat = (Convert.ToInt32(cmbInicioTrat.SelectedItem))
        Main.porcentajeInfectadas = NumericUpDown2.Value
        Main.tamFilas = NumericUpDown1.Value
        Main.tamColumnas = NumericUpDown3.Value

        If CheckBox1.Checked Then
            Main.banderaEstadisticas = True
        Else
            Main.banderaEstadisticas = False
        End If

        If CheckBox2.Checked Then
            Main.banderaGrafica = True
        Else
            Main.banderaGrafica = False
        End If

        Main.RedimensionarMatriz()
        Main.LimpiarFormulario()
        Main.AplicarCondiciones()

        MessageBox.Show("Condiciones Iniciales Aplicadas", "Nueva Simulación", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Main.btnIniciar.Enabled = True

        If CheckBox1.Checked = False And CheckBox2.Checked = False Then
            MessageBox.Show("Solo se generará el archivo CSV como resultado de la simulación.", "Nueva Simulación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        Main.Show()
        Estadisticas.Close()
        Matriz.Close()
        Me.Close()
    End Sub

    Private Sub CondicionesIniciales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Valor por default para los combobox y el checkbox
        cmbClonacion.SelectedIndex = 1
        cmbInicioTrat.SelectedIndex = 1
        cmbDias.SelectedIndex = 2
        cmbDuracion.SelectedIndex = 0
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        btnApply.Enabled = False
    End Sub

End Class