<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDashboard
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        panelSuperior = New Panel()
        menuPrincipal = New MenuStrip()
        ArchivoToolStripMenuItem = New ToolStripMenuItem()
        CargarAlumnoToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripSeparator()
        GuardarProgresoToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripSeparator()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        CálculosToolStripMenuItem = New ToolStripMenuItem()
        PorcentajeDeLaCarreraToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem3 = New ToolStripSeparator()
        EstadísticasToolStripMenuItem = New ToolStripMenuItem()
        BibliotecaToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem4 = New ToolStripSeparator()
        ImprimirToolStripMenuItem = New ToolStripMenuItem()
        HorariosToolStripMenuItem = New ToolStripMenuItem()
        DiseñadorDeHorariosToolStripMenuItem = New ToolStripMenuItem()
        VerPDFsToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem5 = New ToolStripSeparator()
        WebÚtilesToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem6 = New ToolStripSeparator()
        SecretaríaToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem7 = New ToolStripSeparator()
        PreguntasFrecuentesDelJVGToolStripMenuItem = New ToolStripMenuItem()
        ÚtilesToolStripMenuItem = New ToolStripMenuItem()
        TeléfonosDelInstitutoToolStripMenuItem = New ToolStripMenuItem()
        HorarioDeAtenciónToolStripMenuItem = New ToolStripMenuItem()
        CronogramaDeCursadaToolStripMenuItem = New ToolStripMenuItem()
        PlanDeEstudiosToolStripMenuItem = New ToolStripMenuItem()
        PasatiemposToolStripMenuItem = New ToolStripMenuItem()
        PalabrasCruzadasToolStripMenuItem = New ToolStripMenuItem()
        AhorcadoToolStripMenuItem = New ToolStripMenuItem()
        LaberintoToolStripMenuItem = New ToolStripMenuItem()
        SudokuToolStripMenuItem = New ToolStripMenuItem()
        AyudaToolStripMenuItem = New ToolStripMenuItem()
        ManualDeUsuarioToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem8 = New ToolStripSeparator()
        BuscarActualizacionesToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem9 = New ToolStripSeparator()
        AcercaDeToolStripMenuItem = New ToolStripMenuItem()
        panelSuperior.SuspendLayout()
        menuPrincipal.SuspendLayout()
        SuspendLayout()
        ' 
        ' panelSuperior
        ' 
        panelSuperior.BackColor = Color.DodgerBlue
        panelSuperior.Controls.Add(menuPrincipal)
        panelSuperior.Dock = DockStyle.Top
        panelSuperior.Location = New Point(0, 0)
        panelSuperior.Name = "panelSuperior"
        panelSuperior.Size = New Size(884, 60)
        panelSuperior.TabIndex = 0
        ' 
        ' menuPrincipal
        ' 
        menuPrincipal.Items.AddRange(New ToolStripItem() {ArchivoToolStripMenuItem, CálculosToolStripMenuItem, HorariosToolStripMenuItem, BibliotecaToolStripMenuItem, ÚtilesToolStripMenuItem, PasatiemposToolStripMenuItem, AyudaToolStripMenuItem})
        menuPrincipal.Location = New Point(0, 0)
        menuPrincipal.Name = "menuPrincipal"
        menuPrincipal.Size = New Size(884, 24)
        menuPrincipal.TabIndex = 1
        menuPrincipal.Text = "MenuStrip1"
        ' 
        ' ArchivoToolStripMenuItem
        ' 
        ArchivoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CargarAlumnoToolStripMenuItem, ToolStripMenuItem1, GuardarProgresoToolStripMenuItem, ToolStripMenuItem2, ImprimirToolStripMenuItem, ToolStripMenuItem4, SalirToolStripMenuItem})
        ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        ArchivoToolStripMenuItem.Size = New Size(75, 20)
        ArchivoToolStripMenuItem.Text = "📂 Archivo"
        ' 
        ' CargarAlumnoToolStripMenuItem
        ' 
        CargarAlumnoToolStripMenuItem.Name = "CargarAlumnoToolStripMenuItem"
        CargarAlumnoToolStripMenuItem.Size = New Size(180, 22)
        CargarAlumnoToolStripMenuItem.Text = "Cargar Alumno"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(177, 6)
        ' 
        ' GuardarProgresoToolStripMenuItem
        ' 
        GuardarProgresoToolStripMenuItem.Name = "GuardarProgresoToolStripMenuItem"
        GuardarProgresoToolStripMenuItem.Size = New Size(180, 22)
        GuardarProgresoToolStripMenuItem.Text = "Guardar Progreso"
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(177, 6)
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.Size = New Size(180, 22)
        SalirToolStripMenuItem.Text = "Salir"
        ' 
        ' CálculosToolStripMenuItem
        ' 
        CálculosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {PorcentajeDeLaCarreraToolStripMenuItem, ToolStripMenuItem3, EstadísticasToolStripMenuItem})
        CálculosToolStripMenuItem.Name = "CálculosToolStripMenuItem"
        CálculosToolStripMenuItem.Size = New Size(79, 20)
        CálculosToolStripMenuItem.Text = "📊 Cálculos"
        ' 
        ' PorcentajeDeLaCarreraToolStripMenuItem
        ' 
        PorcentajeDeLaCarreraToolStripMenuItem.Name = "PorcentajeDeLaCarreraToolStripMenuItem"
        PorcentajeDeLaCarreraToolStripMenuItem.Size = New Size(199, 22)
        PorcentajeDeLaCarreraToolStripMenuItem.Text = "Porcentaje de la Carrera"
        ' 
        ' ToolStripMenuItem3
        ' 
        ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        ToolStripMenuItem3.Size = New Size(196, 6)
        ' 
        ' EstadísticasToolStripMenuItem
        ' 
        EstadísticasToolStripMenuItem.Name = "EstadísticasToolStripMenuItem"
        EstadísticasToolStripMenuItem.Size = New Size(199, 22)
        EstadísticasToolStripMenuItem.Text = "Estadísticas"
        ' 
        ' BibliotecaToolStripMenuItem
        ' 
        BibliotecaToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {VerPDFsToolStripMenuItem, ToolStripMenuItem5, WebÚtilesToolStripMenuItem, ToolStripMenuItem6, SecretaríaToolStripMenuItem, ToolStripMenuItem7, PreguntasFrecuentesDelJVGToolStripMenuItem})
        BibliotecaToolStripMenuItem.Name = "BibliotecaToolStripMenuItem"
        BibliotecaToolStripMenuItem.Size = New Size(71, 20)
        BibliotecaToolStripMenuItem.Text = "Biblioteca"
        ' 
        ' ToolStripMenuItem4
        ' 
        ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        ToolStripMenuItem4.Size = New Size(177, 6)
        ' 
        ' ImprimirToolStripMenuItem
        ' 
        ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        ImprimirToolStripMenuItem.Size = New Size(180, 22)
        ImprimirToolStripMenuItem.Text = "Imprimir"
        ' 
        ' HorariosToolStripMenuItem
        ' 
        HorariosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {DiseñadorDeHorariosToolStripMenuItem})
        HorariosToolStripMenuItem.Name = "HorariosToolStripMenuItem"
        HorariosToolStripMenuItem.Size = New Size(64, 20)
        HorariosToolStripMenuItem.Text = "Horarios"
        ' 
        ' DiseñadorDeHorariosToolStripMenuItem
        ' 
        DiseñadorDeHorariosToolStripMenuItem.Name = "DiseñadorDeHorariosToolStripMenuItem"
        DiseñadorDeHorariosToolStripMenuItem.Size = New Size(191, 22)
        DiseñadorDeHorariosToolStripMenuItem.Text = "Diseñador de Horarios"
        ' 
        ' VerPDFsToolStripMenuItem
        ' 
        VerPDFsToolStripMenuItem.Name = "VerPDFsToolStripMenuItem"
        VerPDFsToolStripMenuItem.Size = New Size(180, 22)
        VerPDFsToolStripMenuItem.Text = "Ver PDFs"
        ' 
        ' ToolStripMenuItem5
        ' 
        ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        ToolStripMenuItem5.Size = New Size(177, 6)
        ' 
        ' WebÚtilesToolStripMenuItem
        ' 
        WebÚtilesToolStripMenuItem.Name = "WebÚtilesToolStripMenuItem"
        WebÚtilesToolStripMenuItem.Size = New Size(180, 22)
        WebÚtilesToolStripMenuItem.Text = "Web Útiles"
        ' 
        ' ToolStripMenuItem6
        ' 
        ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        ToolStripMenuItem6.Size = New Size(177, 6)
        ' 
        ' SecretaríaToolStripMenuItem
        ' 
        SecretaríaToolStripMenuItem.Name = "SecretaríaToolStripMenuItem"
        SecretaríaToolStripMenuItem.Size = New Size(180, 22)
        SecretaríaToolStripMenuItem.Text = "Secretaría"
        ' 
        ' ToolStripMenuItem7
        ' 
        ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        ToolStripMenuItem7.Size = New Size(177, 6)
        ' 
        ' PreguntasFrecuentesDelJVGToolStripMenuItem
        ' 
        PreguntasFrecuentesDelJVGToolStripMenuItem.Name = "PreguntasFrecuentesDelJVGToolStripMenuItem"
        PreguntasFrecuentesDelJVGToolStripMenuItem.Size = New Size(180, 22)
        PreguntasFrecuentesDelJVGToolStripMenuItem.Text = "Correlativas (PDF)"
        ' 
        ' ÚtilesToolStripMenuItem
        ' 
        ÚtilesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {TeléfonosDelInstitutoToolStripMenuItem, HorarioDeAtenciónToolStripMenuItem, CronogramaDeCursadaToolStripMenuItem, PlanDeEstudiosToolStripMenuItem})
        ÚtilesToolStripMenuItem.Name = "ÚtilesToolStripMenuItem"
        ÚtilesToolStripMenuItem.Size = New Size(48, 20)
        ÚtilesToolStripMenuItem.Text = "Útiles"
        ' 
        ' TeléfonosDelInstitutoToolStripMenuItem
        ' 
        TeléfonosDelInstitutoToolStripMenuItem.Name = "TeléfonosDelInstitutoToolStripMenuItem"
        TeléfonosDelInstitutoToolStripMenuItem.Size = New Size(218, 22)
        TeléfonosDelInstitutoToolStripMenuItem.Text = "📞 Teléfonos del Instituto"
        ' 
        ' HorarioDeAtenciónToolStripMenuItem
        ' 
        HorarioDeAtenciónToolStripMenuItem.Name = "HorarioDeAtenciónToolStripMenuItem"
        HorarioDeAtenciónToolStripMenuItem.Size = New Size(218, 22)
        HorarioDeAtenciónToolStripMenuItem.Text = "🕐 Horario de Atención"
        ' 
        ' CronogramaDeCursadaToolStripMenuItem
        ' 
        CronogramaDeCursadaToolStripMenuItem.Name = "CronogramaDeCursadaToolStripMenuItem"
        CronogramaDeCursadaToolStripMenuItem.Size = New Size(218, 22)
        CronogramaDeCursadaToolStripMenuItem.Text = "📅 Cronograma de Cursada"
        ' 
        ' PlanDeEstudiosToolStripMenuItem
        ' 
        PlanDeEstudiosToolStripMenuItem.Name = "PlanDeEstudiosToolStripMenuItem"
        PlanDeEstudiosToolStripMenuItem.Size = New Size(218, 22)
        PlanDeEstudiosToolStripMenuItem.Text = "📝 Plan de Estudios"
        ' 
        ' PasatiemposToolStripMenuItem
        ' 
        PasatiemposToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {PalabrasCruzadasToolStripMenuItem, AhorcadoToolStripMenuItem, LaberintoToolStripMenuItem, SudokuToolStripMenuItem})
        PasatiemposToolStripMenuItem.Name = "PasatiemposToolStripMenuItem"
        PasatiemposToolStripMenuItem.Size = New Size(104, 20)
        PasatiemposToolStripMenuItem.Text = "🎮 Pasatiempos "
        ' 
        ' PalabrasCruzadasToolStripMenuItem
        ' 
        PalabrasCruzadasToolStripMenuItem.Name = "PalabrasCruzadasToolStripMenuItem"
        PalabrasCruzadasToolStripMenuItem.Size = New Size(184, 22)
        PalabrasCruzadasToolStripMenuItem.Text = "✏️ Palabras Cruzadas"
        ' 
        ' AhorcadoToolStripMenuItem
        ' 
        AhorcadoToolStripMenuItem.Name = "AhorcadoToolStripMenuItem"
        AhorcadoToolStripMenuItem.Size = New Size(184, 22)
        AhorcadoToolStripMenuItem.Text = "🔤 Ahorcado"
        ' 
        ' LaberintoToolStripMenuItem
        ' 
        LaberintoToolStripMenuItem.Name = "LaberintoToolStripMenuItem"
        LaberintoToolStripMenuItem.Size = New Size(184, 22)
        LaberintoToolStripMenuItem.Text = "🌀 Laberinto"
        ' 
        ' SudokuToolStripMenuItem
        ' 
        SudokuToolStripMenuItem.Name = "SudokuToolStripMenuItem"
        SudokuToolStripMenuItem.Size = New Size(184, 22)
        SudokuToolStripMenuItem.Text = ChrW(55358) & ChrW(56809) & " Sudoku"
        ' 
        ' AyudaToolStripMenuItem
        ' 
        AyudaToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ManualDeUsuarioToolStripMenuItem, ToolStripMenuItem8, BuscarActualizacionesToolStripMenuItem, ToolStripMenuItem9, AcercaDeToolStripMenuItem})
        AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        AyudaToolStripMenuItem.Size = New Size(53, 20)
        AyudaToolStripMenuItem.Text = "Ayuda"
        ' 
        ' ManualDeUsuarioToolStripMenuItem
        ' 
        ManualDeUsuarioToolStripMenuItem.Name = "ManualDeUsuarioToolStripMenuItem"
        ManualDeUsuarioToolStripMenuItem.Size = New Size(192, 22)
        ManualDeUsuarioToolStripMenuItem.Text = "Manual de Usuario"
        ' 
        ' ToolStripMenuItem8
        ' 
        ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        ToolStripMenuItem8.Size = New Size(189, 6)
        ' 
        ' BuscarActualizacionesToolStripMenuItem
        ' 
        BuscarActualizacionesToolStripMenuItem.Name = "BuscarActualizacionesToolStripMenuItem"
        BuscarActualizacionesToolStripMenuItem.Size = New Size(192, 22)
        BuscarActualizacionesToolStripMenuItem.Text = "Buscar actualizaciones"
        ' 
        ' ToolStripMenuItem9
        ' 
        ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        ToolStripMenuItem9.Size = New Size(189, 6)
        ' 
        ' AcercaDeToolStripMenuItem
        ' 
        AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        AcercaDeToolStripMenuItem.Size = New Size(192, 22)
        AcercaDeToolStripMenuItem.Text = "Acerca de..."
        ' 
        ' FormDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(884, 561)
        Controls.Add(panelSuperior)
        MainMenuStrip = menuPrincipal
        Name = "FormDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Asistente Organizativo Estudiantil - JVG"
        panelSuperior.ResumeLayout(False)
        panelSuperior.PerformLayout()
        menuPrincipal.ResumeLayout(False)
        menuPrincipal.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelSuperior As Panel
    Friend WithEvents menuPrincipal As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargarAlumnoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents GuardarProgresoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CálculosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PorcentajeDeLaCarreraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents EstadísticasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BibliotecaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripSeparator
    Friend WithEvents HorariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DiseñadorDeHorariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerPDFsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripSeparator
    Friend WithEvents WebÚtilesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripSeparator
    Friend WithEvents SecretaríaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As ToolStripSeparator
    Friend WithEvents PreguntasFrecuentesDelJVGToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÚtilesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TeléfonosDelInstitutoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HorarioDeAtenciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CronogramaDeCursadaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlanDeEstudiosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasatiemposToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PalabrasCruzadasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AhorcadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaberintoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SudokuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManualDeUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As ToolStripSeparator
    Friend WithEvents BuscarActualizacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As ToolStripSeparator
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
End Class
