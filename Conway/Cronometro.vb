Public Class Cronometro
    Private Sub Cronometro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - 217, Screen.PrimaryScreen.WorkingArea.Height - 103)
    End Sub

    Private Sub TimerCronometro_Tick(sender As Object, e As EventArgs) Handles TimerCronometro.Tick
        TimerCronometro.Interval = 10
        Label21.Text += 1
        If Label21.Text = “60” Then
            Label18.Text += 1
            Label21.Text = 0
        End If
        If Label18.Text = 60 Then
            Label17.Text += 1
            Label18.Text = 0
        End If
        If Label17.Text = 60 Then
            Label16.Text += 1
            Label21.Text = 0
        End If
    End Sub
End Class