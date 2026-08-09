Imports AOE_JVG.Forms

Module Program
    Public UsuarioActual As Usuario

    Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New Splash())
    End Sub
End Module
