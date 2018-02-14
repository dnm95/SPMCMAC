Public Class Automata

    Private Matriz(,) As Integer
    Private ultimoPunto As Point

    Private _Generacion As Integer = 0
    Private _cantTratamiento As Integer = 0
    Public _clonacion As Integer = 0
    Public _duracion As Integer = 0
    Public _suministro As Integer = 0
    Public _inicioTrat As Integer = 0
	
	'Obtener la generación actual del simulador
    Public ReadOnly Property Generacion() As Integer
        Get
            Return _Generacion
        End Get
    End Property

	'Obtener la matriz con todos sus valores
    Public Function GetMatriz() As Integer(,)
        Return Matriz
    End Function

    Private Sub New()
    End Sub

	'Crear nueva matriz con valores establecidos por el usuario
    Sub New(ByVal maxX As Integer, ByVal maxY As Integer)
        ReDim Matriz(maxX, maxY)
        ultimoPunto = New Point(maxX, maxY)
    End Sub

    'Devuelve verdadero si al menos un elemento de la matriz contiene un 1 (celula infectada)
    Public Function AlgunoInfectado() As Boolean
        For x As Integer = 0 To Matriz.GetUpperBound(0) - 1
            For y As Integer = 0 To Matriz.GetUpperBound(1) - 1
                If Matriz(x, y) = 1 Then Return True
            Next y
        Next x
        Return False
    End Function
	
    'Devuelve la catidad de celulas infectadas en la matriz
    Public Function Infectados() As Single
        Dim cantvivos As Integer = 0
        For x As Integer = 0 To Matriz.GetUpperBound(0) - 1
            For y As Integer = 0 To Matriz.GetUpperBound(1) - 1
                If Matriz(x, y) = 1 Then
                    cantvivos += 1
                End If
            Next y
        Next x
        Return cantvivos
    End Function

    'Devuelve la catidad de casillas vacias o celulas muertas
    Public Function Muertas() As Single
        Dim cantmuertas As Integer = 0
        For x As Integer = 0 To Matriz.GetUpperBound(0) - 1
            For y As Integer = 0 To Matriz.GetUpperBound(1) - 1
                If Matriz(x, y) <> 1 And Matriz(x, y) <> 2 Then
                    cantmuertas += 1
                End If
            Next y
        Next x
        Return cantmuertas
    End Function

    'Devuelve la catidad de celulas en tratamiento en la matriz
    Public Function CantTratamiento() As Single
        Dim cantratamiento As Integer = 0
        For x As Integer = 0 To Matriz.GetUpperBound(0) - 1
            For y As Integer = 0 To Matriz.GetUpperBound(1) - 1
                If Matriz(x, y) = 2 Then
                    cantratamiento += 1
                End If
            Next y
        Next x
        Return cantratamiento
    End Function


    'Devuelve el porcentaje de ocupación actual (valor entre 0 y 1)
    Public Function Ocupacion() As Single
        Dim cant As Integer = 0
        For x As Integer = 0 To Matriz.GetUpperBound(0) - 1
            For y As Integer = 0 To Matriz.GetUpperBound(1) - 1
                If Matriz(x, y) = 1 Or Matriz(x, y) = 2 Then
                    cant += 1
                End If
            Next y
        Next x
        Return cant / (Matriz.GetUpperBound(0) * Matriz.GetUpperBound(1))
    End Function

	'Establecer un porcentaje de celulas infectadas, que son distribuidas aleatoriamente por toda la matriz
    Public Sub AleatorioMatriz(ByVal pVivo As Byte)
        If pVivo > 99 Or pVivo < 1 Then Exit Sub

		'En cada posición de la matriz se genera un numero aleatorio entre 0 y 100, si el numero aleatorio es menor
		'al porcentaje que establecio el usuario se crea una celula infectada, en caso contrario la casilla queda vacia o muerta
        For x As Integer = 0 To Matriz.GetUpperBound(0) - 1
            For y As Integer = 0 To Matriz.GetUpperBound(1) - 1
                If Rnd() * 100 < pVivo Then
                    Matriz(x, y) = 1
                Else
                    Matriz(x, y) = 0
                End If
            Next y
        Next x
    End Sub
	
	'Solo se establece una celula aleatoria por toda la matriz.
    Public Sub CelulaAleatoria()
        Dim randomValueX As Integer
        Dim randomValueY As Integer
        randomValueX = CInt(Math.Floor((Matriz.GetUpperBound(0) + 1) * Rnd()))
        randomValueY = CInt(Math.Floor((Matriz.GetUpperBound(1) + 1) * Rnd()))
        Matriz(randomValueX, randomValueY) = 1

    End Sub
	
	'Se borra todo el contenido de la matriz y se resetean las generaciones a cero
    Public Sub BorrarMatriz()
        ReDim Matriz(Matriz.GetUpperBound(0), Matriz.GetUpperBound(1))
        _Generacion = 0
    End Sub

	'Metodo mas importante de la clase, es el encargado de realizar la clonacion de las celulas infectadas 
	'La regla del automata establece que para que se pueda clonar una celula infectada debe tener como minimo un vecino infectado
    Public Sub Clonacion()
        Dim Vivos As Integer

        Dim newMatriz(ultimoPunto.X, ultimoPunto.Y) As Integer

        For x As Integer = 0 To Matriz.GetUpperBound(0) - 1
            For y As Integer = 0 To Matriz.GetUpperBound(1) - 1
                Vivos = GetVecinosInfectados(New Point(x, y))
                If Matriz(x, y) = 0 Then
                    'Esta muerta
                    If Vivos >= 1 Then
                        newMatriz(x, y) = 1 'Nace
                    End If

                ElseIf Matriz(x, y) = 1 Then
                    newMatriz(x, y) = 1 'Se mantiene viva
                End If

                If Matriz(x, y) = 2 Then ' Si esta en tratamiento, mantiene su estado
                    newMatriz(x, y) = 2
                End If
            Next y
        Next x

        Matriz = newMatriz


    End Sub
	
	'Este metodo es el encargado de simular la liberacion de la quimioterapia, a cada celula infectada en la matriz
	'se le aplica el tratamiento, la efectividad de la quimioterapia es del 60%
    Public Sub Tratamiento()
        Dim Vivos As Integer
        Dim newMatriz(ultimoPunto.X, ultimoPunto.Y) As Integer

        For x As Integer = 0 To Matriz.GetUpperBound(0) - 1
            For y As Integer = 0 To Matriz.GetUpperBound(1) - 1
                Vivos = GetVecinosInfectados(New Point(x, y))
                If Matriz(x, y) = 1 Then
                    'La efectividad de la quimioterapia es del 60%
                    If CInt(Rnd() * 100) > 40 Then
                        newMatriz(x, y) = 2
                    Else
                        newMatriz(x, y) = 1
                    End If
                End If
                If Matriz(x, y) = 2 Then
                    newMatriz(x, y) = 2
                End If
            Next y
        Next x

        Matriz = newMatriz
    End Sub

	'Este metodo solo se encarga de limpiar la matriz una vez que concluyo todo el proceso del tratamiento
    Public Sub FinTratamiento()
        Dim newMatriz(ultimoPunto.X, ultimoPunto.Y) As Integer

        For x As Integer = 0 To Matriz.GetUpperBound(0) - 1
            For y As Integer = 0 To Matriz.GetUpperBound(1) - 1
                If Matriz(x, y) = 2 Then
                    newMatriz(x, y) = 0
                End If
                If Matriz(x, y) = 1 Then
                    newMatriz(x, y) = 1
                End If
            Next y
        Next x

        Matriz = newMatriz
    End Sub

	'En este metodo se estan aplicando todas las reglas estableceidas para el automata celular
    Public Sub ReglasAC()
	
        'Redimensionar la matriz si la ocupacion esta al 100%
        Dim ocu As Integer = CInt(Ocupacion() * 100)
        If ocu = 100 Then
            'Agregar 5 filas y columnas (X,Y)
            Dim auxX As Integer = ultimoPunto.X + 5
            Dim auxY As Integer = ultimoPunto.Y + 5

            'Crear una matriz auxiliar
            Dim newMatriz(ultimoPunto.X, ultimoPunto.Y) As Integer
            newMatriz = Matriz 'Copiar el contenido de la matriz original a la matriz auxiliar
            'Redimensionar la matriz original agregando 5 filas y columnas
            ReDim Matriz(ultimoPunto.X + 5, ultimoPunto.Y + 5)

            'Actualizar los falores de filas y columnas (X,Y)
            ultimoPunto = New Point(auxX, auxY)

            'Copiar el contenido de la matriz auxiliar a la matriz redimensionada
            For x As Integer = 0 To newMatriz.GetUpperBound(0) - 1
                For y As Integer = 0 To newMatriz.GetUpperBound(1) - 1
                    If newMatriz(x, y) = 0 Then
                        'Esta muerta
                        Matriz(x, y) = 0
                    End If
                    If newMatriz(x, y) = 1 Then
                        Matriz(x, y) = 1
                    End If

                    If newMatriz(x, y) = 2 Then
                        Matriz(x, y) = 2
                    End If
                Next y
            Next x
        End If
		
		'Calcular el numero de dosis para el tratamiento
        Dim numeroDosis As Integer = (_duracion * 30) / _suministro

        'Cada N generaciones establecidas por el usuario se realiza el proceso de clonacion
        If _Generacion <> 0 And _Generacion <> 1 And _Generacion Mod _clonacion = 0 Then
            Clonacion()
        End If

        'A partir de la generación 3650 se suministra, por así decirlo, la primera dosis del tratamiento
        ', se suministra posteriormente cada 20 generaciones hasta llegar a 6 dosis (4 meses de tratamiento)
        If _Generacion >= _inicioTrat And _Generacion Mod _suministro = 0 And _cantTratamiento < numeroDosis Then
            Tratamiento()
            _cantTratamiento += 1
        End If

        'Se limpia la matriz tras concluir el ciclo de la quimioterapia
        If _cantTratamiento >= numeroDosis Then
            FinTratamiento()
        End If

        'Si existe alguna celula infectada se incrementa en 1 la generacion
        If AlgunoInfectado() Then
            _Generacion += 1
        End If

    End Sub

	'Prototipo de una nueva regla que tal vez pueda describir mejor el proceso de metastasis
    Public Sub ReglaDeDifusion()
        Dim Vivos As Integer
        Dim newMatriz(ultimoPunto.X, ultimoPunto.Y) As Integer

        For x As Integer = 0 To Matriz.GetUpperBound(0) - 1
            For y As Integer = 0 To Matriz.GetUpperBound(1) - 1
                Vivos = GetVecinosInfectados(New Point(x, y))
                If Matriz(x, y) = 0 Then
                    'Esta muerta
                    If Vivos = 2 Then
                        newMatriz(x, y) = 1 'Nace
                    End If
                ElseIf Matriz(x, y) = 1 Then
                    'Esta viva
                    If Vivos = 7 Then
                        newMatriz(x, y) = 1 'Sobrevive
                    End If
                End If
            Next y
        Next x

        Matriz = newMatriz
    End Sub

    'Devuelve la cantidad de celulas que se encuentran en tratamiento
    Public Function EnTratamiento() As Single
        Dim cantTratamiento As Integer = 0
        For x As Integer = 0 To Matriz.GetUpperBound(0) - 1
            For y As Integer = 0 To Matriz.GetUpperBound(1) - 1
                If Matriz(x, y) = 2 Then
                    cantTratamiento += 1
                End If
            Next y
        Next x
        Return cantTratamiento
    End Function

    'Devuelve la cantidad de vecinos vivos de un punto a evaluar de la matriz
    Private Function GetVecinosInfectados(ByVal pEvaluar As Point) As Integer
        Dim pVecinos As List(Of Point) = GetVecinos(pEvaluar)
        Dim TotalVivos As Integer = 0
        For Each p As Point In pVecinos
            TotalVivos += Matriz(p.X, p.Y)
        Next
        Return TotalVivos
    End Function

    'Devuelve una lista con los puntos que son vecinos al punto dado
    Private Function GetVecinos(ByVal pEvaluar As Point) As List(Of Point)
        Dim Vecinos As New List(Of Point)
        With pEvaluar
            'Arriba a la izquierda
            If .X > 0 And .Y > 0 Then
                Vecinos.Add(New Point(.X - 1, .Y - 1))
            End If
            'Arriba al centro
            If .Y > 0 Then
                Vecinos.Add(New Point(.X, .Y - 1))
            End If
            'Arriba a la derecha
            If .X < ultimoPunto.X And .Y > 0 Then
                Vecinos.Add(New Point(.X + 1, .Y - 1))
            End If
            'A la izquierda
            If .X > 0 Then
                Vecinos.Add(New Point(.X - 1, .Y))
            End If
            'A la derecha
            If .X < ultimoPunto.X Then
                Vecinos.Add(New Point(.X + 1, .Y))
            End If
            'Abajo a la izquierda
            If .X > 0 And .Y < ultimoPunto.Y Then
                Vecinos.Add(New Point(.X - 1, .Y + 1))
            End If
            'Abajo 
            If .Y < ultimoPunto.Y Then
                Vecinos.Add(New Point(.X, .Y + 1))
            End If
            'Abajo a la derecha
            If .X < ultimoPunto.X And .Y < ultimoPunto.Y Then
                Vecinos.Add(New Point(.X + 1, .Y + 1))
            End If
        End With

        Return Vecinos
    End Function

End Class
