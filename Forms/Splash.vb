Public Class Splash
    Private timer As Timer
    Private progress As Integer = 0

    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IniciarTimer()
    End Sub

    Private Sub IniciarTimer()
        timer = New Timer()
        timer.Interval = 30
        AddHandler timer.Tick, AddressOf Timer_Tick
        timer.Start()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs)
        progress += 2

        progressBar.Value = Math.Min(progress, 100)
        lblProgress.Text = progress & "%"

        If progress >= 100 Then
            timer.Stop()
            timer.Dispose()

            Dim login As New FormLogin()
            login.Show()
            Me.Hide()
        End If
    End Sub
End Class
