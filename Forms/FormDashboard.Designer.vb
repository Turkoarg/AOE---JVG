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
        ImprimirToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem4 = New ToolStripSeparator()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        HorariosToolStripMenuItem = New ToolStripMenuItem()
        DiseñadorDeHorariosToolStripMenuItem = New ToolStripMenuItem()
        BibliotecaToolStripMenuItem = New ToolStripMenuItem()
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
        CálculosToolStripMenuItem = New ToolStripMenuItem()
        PorcentajeDeLaCarreraToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem3 = New ToolStripSeparator()
        EstadísticasToolStripMenuItem = New ToolStripMenuItem()
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
        splitContainer1 = New SplitContainer()
        lblTituloMaterias = New Label()
        txtBuscar = New TextBox()
        clbMaterias = New CheckedListBox()
        btnVerificar = New Button()
        lblProgreso = New Label()
        progressBarProgreso = New ProgressBar()
        lblPorcentaje = New Label()
        lblAprobadas = New Label()
        lblRegular = New Label()
        lblEnCurso = New Label()
        lblPendientes = New Label()
        dgvHorarioResumen = New DataGridView()
        colHora = New DataGridViewTextBoxColumn()
        colLunes = New DataGridViewTextBoxColumn()
        colMartes = New DataGridViewTextBoxColumn()
        colMiercoles = New DataGridViewTextBoxColumn()
        colJueves = New DataGridViewTextBoxColumn()
        colViernes = New DataGridViewTextBoxColumn()
        colSabado = New DataGridViewTextBoxColumn()
        panelSuperior.SuspendLayout()
        menuPrincipal.SuspendLayout()
        CType(splitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        splitContainer1.Panel1.SuspendLayout()
        splitContainer1.Panel2.SuspendLayout()
        splitContainer1.SuspendLayout()
        CType(dgvHorarioResumen, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' panelSuperior
        ' 
        panelSuperior.BackColor = Color.DodgerBlue
        panelSuperior.Controls.Add(menuPrincipal)
        panelSuperior.Dock = DockStyle.Top
        panelSuperior.Location = New Point(0, 0)
        panelSuperior.Name = "panelSuperior"
        panelSuperior.Size = New Size(1084, 60)
        panelSuperior.TabIndex = 0
        ' 
        ' menuPrincipal
        ' 
        menuPrincipal.Items.AddRange(New ToolStripItem() {ArchivoToolStripMenuItem, HorariosToolStripMenuItem, BibliotecaToolStripMenuItem, ÚtilesToolStripMenuItem, CálculosToolStripMenuItem, PasatiemposToolStripMenuItem, AyudaToolStripMenuItem})
        menuPrincipal.Location = New Point(0, 0)
        menuPrincipal.Name = "menuPrincipal"
        menuPrincipal.Size = New Size(1084, 24)
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
        CargarAlumnoToolStripMenuItem.Size = New Size(166, 22)
        CargarAlumnoToolStripMenuItem.Text = "Cargar Alumno"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(163, 6)
        ' 
        ' GuardarProgresoToolStripMenuItem
        ' 
        GuardarProgresoToolStripMenuItem.Name = "GuardarProgresoToolStripMenuItem"
        GuardarProgresoToolStripMenuItem.Size = New Size(166, 22)
        GuardarProgresoToolStripMenuItem.Text = "Guardar Progreso"
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(163, 6)
        ' 
        ' ImprimirToolStripMenuItem
        ' 
        ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        ImprimirToolStripMenuItem.Size = New Size(166, 22)
        ImprimirToolStripMenuItem.Text = "Imprimir"
        ' 
        ' ToolStripMenuItem4
        ' 
        ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        ToolStripMenuItem4.Size = New Size(163, 6)
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.Size = New Size(166, 22)
        SalirToolStripMenuItem.Text = "Salir"
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
        ' BibliotecaToolStripMenuItem
        ' 
        BibliotecaToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {VerPDFsToolStripMenuItem, ToolStripMenuItem5, WebÚtilesToolStripMenuItem, ToolStripMenuItem6, SecretaríaToolStripMenuItem, ToolStripMenuItem7, PreguntasFrecuentesDelJVGToolStripMenuItem})
        BibliotecaToolStripMenuItem.Name = "BibliotecaToolStripMenuItem"
        BibliotecaToolStripMenuItem.Size = New Size(71, 20)
        BibliotecaToolStripMenuItem.Text = "Biblioteca"
        ' 
        ' VerPDFsToolStripMenuItem
        ' 
        VerPDFsToolStripMenuItem.Name = "VerPDFsToolStripMenuItem"
        VerPDFsToolStripMenuItem.Size = New Size(168, 22)
        VerPDFsToolStripMenuItem.Text = "Ver PDFs"
        ' 
        ' ToolStripMenuItem5
        ' 
        ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        ToolStripMenuItem5.Size = New Size(165, 6)
        ' 
        ' WebÚtilesToolStripMenuItem
        ' 
        WebÚtilesToolStripMenuItem.Name = "WebÚtilesToolStripMenuItem"
        WebÚtilesToolStripMenuItem.Size = New Size(168, 22)
        WebÚtilesToolStripMenuItem.Text = "Web Útiles"
        ' 
        ' ToolStripMenuItem6
        ' 
        ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        ToolStripMenuItem6.Size = New Size(165, 6)
        ' 
        ' SecretaríaToolStripMenuItem
        ' 
        SecretaríaToolStripMenuItem.Name = "SecretaríaToolStripMenuItem"
        SecretaríaToolStripMenuItem.Size = New Size(168, 22)
        SecretaríaToolStripMenuItem.Text = "Secretaría"
        ' 
        ' ToolStripMenuItem7
        ' 
        ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        ToolStripMenuItem7.Size = New Size(165, 6)
        ' 
        ' PreguntasFrecuentesDelJVGToolStripMenuItem
        ' 
        PreguntasFrecuentesDelJVGToolStripMenuItem.Name = "PreguntasFrecuentesDelJVGToolStripMenuItem"
        PreguntasFrecuentesDelJVGToolStripMenuItem.Size = New Size(168, 22)
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
        ' splitContainer1
        ' 
        splitContainer1.Dock = DockStyle.Fill
        splitContainer1.ForeColor = Color.Ivory
        splitContainer1.Location = New Point(0, 60)
        splitContainer1.Name = "splitContainer1"
        ' 
        ' splitContainer1.Panel1
        ' 
        splitContainer1.Panel1.Controls.Add(btnVerificar)
        splitContainer1.Panel1.Controls.Add(clbMaterias)
        splitContainer1.Panel1.Controls.Add(txtBuscar)
        splitContainer1.Panel1.Controls.Add(lblTituloMaterias)
        splitContainer1.Panel1MinSize = 400
        ' 
        ' splitContainer1.Panel2
        ' 
        splitContainer1.Panel2.Controls.Add(dgvHorarioResumen)
        splitContainer1.Panel2.Controls.Add(lblPendientes)
        splitContainer1.Panel2.Controls.Add(lblEnCurso)
        splitContainer1.Panel2.Controls.Add(lblRegular)
        splitContainer1.Panel2.Controls.Add(lblAprobadas)
        splitContainer1.Panel2.Controls.Add(lblPorcentaje)
        splitContainer1.Panel2.Controls.Add(progressBarProgreso)
        splitContainer1.Panel2.Controls.Add(lblProgreso)
        splitContainer1.Panel2MinSize = 350
        splitContainer1.Size = New Size(1084, 801)
        splitContainer1.SplitterDistance = 613
        splitContainer1.TabIndex = 1
        ' 
        ' lblTituloMaterias
        ' 
        lblTituloMaterias.AutoSize = True
        lblTituloMaterias.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTituloMaterias.ForeColor = SystemColors.ActiveCaptionText
        lblTituloMaterias.Location = New Point(20, 20)
        lblTituloMaterias.Name = "lblTituloMaterias"
        lblTituloMaterias.Size = New Size(145, 21)
        lblTituloMaterias.TabIndex = 0
        lblTituloMaterias.Text = "📋 MIS MATERIAS"
        ' 
        ' txtBuscar
        ' 
        txtBuscar.ForeColor = Color.Gray
        txtBuscar.Location = New Point(20, 55)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(400, 23)
        txtBuscar.TabIndex = 1
        txtBuscar.Text = "🔍 Buscar materia..."
        ' 
        ' clbMaterias
        ' 
        clbMaterias.CheckOnClick = True
        clbMaterias.Font = New Font("Segoe UI", 10.0F)
        clbMaterias.FormattingEnabled = True
        clbMaterias.Location = New Point(20, 100)
        clbMaterias.Name = "clbMaterias"
        clbMaterias.Size = New Size(400, 304)
        clbMaterias.TabIndex = 2
        ' 
        ' btnVerificar
        ' 
        btnVerificar.BackColor = Color.DodgerBlue
        btnVerificar.FlatStyle = FlatStyle.Flat
        btnVerificar.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVerificar.ForeColor = Color.White
        btnVerificar.Location = New Point(20, 435)
        btnVerificar.Name = "btnVerificar"
        btnVerificar.Size = New Size(400, 40)
        btnVerificar.TabIndex = 3
        btnVerificar.Text = "✅ Verificar Correlativas"
        btnVerificar.UseVisualStyleBackColor = False
        ' 
        ' lblProgreso
        ' 
        lblProgreso.AutoSize = True
        lblProgreso.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblProgreso.ForeColor = Color.Black
        lblProgreso.Location = New Point(21, 20)
        lblProgreso.Name = "lblProgreso"
        lblProgreso.Size = New Size(143, 21)
        lblProgreso.TabIndex = 0
        lblProgreso.Text = "📊 MI PROGRESO"
        ' 
        ' progressBarProgreso
        ' 
        progressBarProgreso.Location = New Point(21, 60)
        progressBarProgreso.Name = "progressBarProgreso"
        progressBarProgreso.Size = New Size(400, 25)
        progressBarProgreso.TabIndex = 1
        ' 
        ' lblPorcentaje
        ' 
        lblPorcentaje.AutoSize = True
        lblPorcentaje.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPorcentaje.ForeColor = Color.Black
        lblPorcentaje.Location = New Point(180, 90)
        lblPorcentaje.Name = "lblPorcentaje"
        lblPorcentaje.Size = New Size(26, 17)
        lblPorcentaje.TabIndex = 2
        lblPorcentaje.Text = "0%"
        ' 
        ' lblAprobadas
        ' 
        lblAprobadas.AutoSize = True
        lblAprobadas.ForeColor = Color.Black
        lblAprobadas.Location = New Point(20, 130)
        lblAprobadas.Name = "lblAprobadas"
        lblAprobadas.Size = New Size(91, 15)
        lblAprobadas.TabIndex = 3
        lblAprobadas.Text = "✅ Aprobadas: 0"
        ' 
        ' lblRegular
        ' 
        lblRegular.AutoSize = True
        lblRegular.BackColor = Color.White
        lblRegular.ForeColor = Color.Black
        lblRegular.Location = New Point(20, 160)
        lblRegular.Name = "lblRegular"
        lblRegular.Size = New Size(106, 15)
        lblRegular.TabIndex = 4
        lblRegular.Text = ChrW(55357) & ChrW(57313) & " Regularizadas: 0"
        ' 
        ' lblEnCurso
        ' 
        lblEnCurso.AutoSize = True
        lblEnCurso.ForeColor = Color.Black
        lblEnCurso.Location = New Point(20, 190)
        lblEnCurso.Name = "lblEnCurso"
        lblEnCurso.Size = New Size(79, 15)
        lblEnCurso.TabIndex = 5
        lblEnCurso.Text = "🔵 En curso: 0"
        ' 
        ' lblPendientes
        ' 
        lblPendientes.AutoSize = True
        lblPendientes.ForeColor = Color.Black
        lblPendientes.Location = New Point(20, 220)
        lblPendientes.Name = "lblPendientes"
        lblPendientes.Size = New Size(90, 15)
        lblPendientes.TabIndex = 6
        lblPendientes.Text = "⬜ Pendientes: 0"
        ' 
        ' dgvHorarioResumen
        ' 
        dgvHorarioResumen.AllowUserToAddRows = False
        dgvHorarioResumen.AllowUserToDeleteRows = False
        dgvHorarioResumen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvHorarioResumen.Columns.AddRange(New DataGridViewColumn() {colHora, colLunes, colMartes, colMiercoles, colJueves, colViernes, colSabado})
        dgvHorarioResumen.Location = New Point(20, 350)
        dgvHorarioResumen.Name = "dgvHorarioResumen"
        dgvHorarioResumen.ReadOnly = True
        dgvHorarioResumen.RowHeadersVisible = False
        dgvHorarioResumen.Size = New Size(400, 180)
        dgvHorarioResumen.TabIndex = 7
        ' 
        ' colHora
        ' 
        colHora.HeaderText = "Hora"
        colHora.Name = "colHora"
        colHora.ReadOnly = True
        colHora.Width = 60
        ' 
        ' colLunes
        ' 
        colLunes.HeaderText = "Lun"
        colLunes.Name = "colLunes"
        colLunes.ReadOnly = True
        colLunes.Width = 50
        ' 
        ' colMartes
        ' 
        colMartes.HeaderText = "Mar"
        colMartes.Name = "colMartes"
        colMartes.ReadOnly = True
        colMartes.Width = 50
        ' 
        ' colMiercoles
        ' 
        colMiercoles.HeaderText = "Mié"
        colMiercoles.Name = "colMiercoles"
        colMiercoles.ReadOnly = True
        colMiercoles.Width = 50
        ' 
        ' colJueves
        ' 
        colJueves.HeaderText = "Jue"
        colJueves.Name = "colJueves"
        colJueves.ReadOnly = True
        colJueves.Width = 50
        ' 
        ' colViernes
        ' 
        colViernes.HeaderText = "Vie"
        colViernes.Name = "colViernes"
        colViernes.ReadOnly = True
        colViernes.Width = 50
        ' 
        ' colSabado
        ' 
        colSabado.HeaderText = "Sáb"
        colSabado.Name = "colSabado"
        colSabado.ReadOnly = True
        colSabado.Width = 50
        ' 
        ' FormDashboard
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1084, 861)
        Controls.Add(splitContainer1)
        Controls.Add(panelSuperior)
        MainMenuStrip = menuPrincipal
        Name = "FormDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Asistente Organizativo Estudiantil - JVG"
        panelSuperior.ResumeLayout(False)
        panelSuperior.PerformLayout()
        menuPrincipal.ResumeLayout(False)
        menuPrincipal.PerformLayout()
        splitContainer1.Panel1.ResumeLayout(False)
        splitContainer1.Panel1.PerformLayout()
        splitContainer1.Panel2.ResumeLayout(False)
        splitContainer1.Panel2.PerformLayout()
        CType(splitContainer1, ComponentModel.ISupportInitialize).EndInit()
        splitContainer1.ResumeLayout(False)
        CType(dgvHorarioResumen, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents splitContainer1 As SplitContainer
    Friend WithEvents lblTituloMaterias As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnVerificar As Button
    Friend WithEvents clbMaterias As CheckedListBox
    Friend WithEvents lblProgreso As Label
    Friend WithEvents progressBarProgreso As ProgressBar
    Friend WithEvents lblAprobadas As Label
    Friend WithEvents lblPorcentaje As Label
    Friend WithEvents lblRegular As Label
    Friend WithEvents dgvHorarioResumen As DataGridView
    Friend WithEvents lblPendientes As Label
    Friend WithEvents lblEnCurso As Label
    Friend WithEvents colHora As DataGridViewTextBoxColumn
    Friend WithEvents colLunes As DataGridViewTextBoxColumn
    Friend WithEvents colMartes As DataGridViewTextBoxColumn
    Friend WithEvents colMiercoles As DataGridViewTextBoxColumn
    Friend WithEvents colJueves As DataGridViewTextBoxColumn
    Friend WithEvents colViernes As DataGridViewTextBoxColumn
    Friend WithEvents colSabado As DataGridViewTextBoxColumn
End Class
