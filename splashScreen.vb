Public Class splashScreen

    Private Sub splashScreen_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        intro.Start()

    End Sub

    Private Sub intro_Tick(sender As Object, e As EventArgs) Handles intro.Tick
        mainMenu.Show()
        Close()
    End Sub
End Class
