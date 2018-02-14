Public Class GraficaMatriz

    'Matriz contenedora de los datos (0, 1,2)
    Private Matriz(,) As Integer

    'Para indicar si ya se inicio la gráfica
    Private Cargado As Boolean = False

    'Establece la matriz de datos
    Public Sub SetMatriz(ByVal matrix As Integer(,))
        Matriz = matrix
        Cargado = True
        Graficar()
    End Sub
    Public Function GetMatriz() As Integer(,)
        Return Matriz
    End Function

    'Graficar la matriz especificada con SetMatriz
    Public Sub Graficar()
        Dim maxX = Matriz.GetUpperBound(0)
        Dim maxY = Matriz.GetUpperBound(1)

        Dim m_bmp As Bitmap = GraficarMalla(maxX, maxY, PB.Width, PB.Height)
        GraficarPuntos(m_bmp)
        PB.Image = m_bmp
    End Sub

    'Graficar la matriz especificada en el parametro
    Public Sub Graficar(ByVal Matrix(,) As Integer)
        Matriz = Matrix
        Cargado = True
        Graficar()
    End Sub

    'Función que grafica en un bitmap el cuadriculado dada la cantidad de posiciones en x y en y, y dados el ancho y alto del objeto
    'Cantidad de elementos para los x
    'Cantidad de elementos para los y
    'Alto del bitmap
    'Ancho del bitmap

    Private Function GraficarMalla(ByVal x As Integer, ByVal y As Integer, ByVal w As Integer, ByVal h As Integer) As Bitmap
        If h + w <= 0 Then Return Nothing

        'Creo el bitmap
        Dim m_bmp As Bitmap = New Bitmap(w, h)
        'Obtengo el graphics
        Dim g As Graphics = Graphics.FromImage(m_bmp)
        Dim pen1 As New Pen(Color.White, 1)

        g.DrawRectangle(pen1, 0, 0, w - 1, h - 1)

        'Dibujar 3 lineas verticales
        'Dim gapX As Single = w / x
        'For i As Integer = (x / 3) To (x / 3)
        '    Dim lx As Single = gapX * i
        '    g.DrawLine(pen1, lx, 0, lx, h)
        'Next i

        'gapX = w / x
        'For i As Integer = (x / 3) * 2 To (x / 3) * 2
        '    Dim lx As Single = gapX * i
        '    g.DrawLine(pen1, lx, 0, lx, h)
        'Next i

        'Para las Lineas horizontales
        'Dim gapY As Single = h / y
        'For i As Integer = 1 To y - 1
        'Dim ly As Single = gapY * i
        'g.DrawLine(pen1, 0, ly, w, ly)
        'Next
        'Devuelvo el bitmap ya cuadriculado
        Return m_bmp
    End Function

    'Grafica los valores que contengan los elementos de la matriz y se dibuja una elipse verde donde la matriz sea 1
    Private Sub GraficarPuntos(ByVal bmp As Bitmap)
        'Obtengo el graphics la malla
        Dim g As Graphics = Graphics.FromImage(bmp)

        Dim br As Brush = Brushes.OrangeRed
        Dim br2 As Brush = Brushes.White
        Dim br3 As Brush = Brushes.ForestGreen

        Dim gapX As Single = bmp.Width / Matriz.GetUpperBound(0)
        Dim gapY As Single = bmp.Height / Matriz.GetUpperBound(1)
        For x = 1 To Matriz.GetUpperBound(0)
            For y = 1 To Matriz.GetUpperBound(1)
                If Matriz(x - 1, y - 1) = 1 Then
                    'Celula infectada en la matriz se identifica con un 1
                    g.FillEllipse(br, gapX * (x - 1) + 1, gapY * (y - 1) + 1, gapX - 2, gapY - 2)
                ElseIf Matriz(x - 1, y - 1) = 2 Then
                    'Celula en tratamiento en la matriz se identifica con un 2
                    g.FillEllipse(br3, gapX * (x - 1) + 1, gapY * (y - 1) + 1, gapX - 2, gapY - 2)
                Else
                    'Celula Muerta en la matriz se identifica con un 0
                    g.FillEllipse(br2, gapX * (x - 1) + 1, gapY * (y - 1) + 1, gapX - 2, gapY - 2)
                End If
            Next y
        Next x

    End Sub

    Private Sub PB_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PB.SizeChanged
        If Cargado Then Graficar()
    End Sub
    
End Class
