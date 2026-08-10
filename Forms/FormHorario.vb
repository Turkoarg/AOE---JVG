Public Class FormHorario
    Private horariosMaterias As New Dictionary(Of String, List(Of (dia As String, bloque As Integer)))

    Private Sub FormHorario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarHorarios()
        CargarMaterias()
        CargarHorariosMaterias()
    End Sub

    Private Sub CargarHorarios()
        dgvHorario.Rows.Clear()
        Dim horarios As String() = {
            "8:00 a 8:40", "8:40 a 9:20", "9:20 a 10:00", "10:10 a 10:50",
            "10:50 a 11:30", "11:30 a 12:10", "12:10 a 12:50",
            "12:50 a 13:30", "13:30 a 14:10", "14:10 a 14:50",
            "14:50 a 15:30", "15:30 a 16:10", "16:10 a 16:50",
            "16:50 a 17:30", "17:30 a 18:10",
            "18:10 a 18:50", "18:50 a 19:30", "19:30 a 20:10",
            "20:10 a 20:50", "20:50 a 21:30", "21:30 a 22:10", "22:10 a 22:50"
        }
        For Each h In horarios
            dgvHorario.Rows.Add(h, "", "", "", "", "", "")
        Next
    End Sub

    Private Sub CargarMaterias()
        ' Lista de materias de ejemplo (sin usar GestorMaterias)
        Dim materias As String() = {
            "Pedagogía",
    "Psicología Educacional",
    "Sujetos de Nivel",
    "Lectura, Escritura y Oralidad I",
    "Informática",
    "Álgebra",
    "Herramientas Informáticas",
    "Diseño I",
    "Programación I",
    "Trabajo de Campo I",
    "Lectura, Escritura y Oralidad II",
    "Didáctica General",
    "Educación Sexual Integral",
    "Cálculo para Informática",
    "Diseño II",
    "Programación II",
    "Sistemas Informáticos",
    "Tecnologías de la Información y la Comunicación",
    "Materiales Didácticos",
    "Trabajo de Campo II",
    "Filosofía",
    "Inglés I",
    "Derechos Humanos, Sociedad y Estado",
    "Lógica Informática",
    "Discursos Digitales",
    "Programación III",
    "Redes y Comunicación de Datos",
    "Informática Educativa I",
    "Recursos Informáticos Aplicados a Otras Disciplinas",
    "Proyectos Educativos",
    "Construcción de la Práctica Docente I",
    "Historia de la Educación Argentina",
    "Nuevos Escenarios, Cultura Tecnológica y Subjetividad",
    "Inglés II",
    "Informática Educativa II",
    "Técnicas Digitales",
    "Diseño de Sistemas",
    "Modelización Matemática y Simulación",
    "Inteligencia Artificial",
    "Lengua Extranjera No Inglesa",
    "Construcción de la Práctica Docente II",
    "Sistema y Política Educativa"
        }
        lstMaterias.Items.Clear()
        For Each m In materias
            lstMaterias.Items.Add(m)
        Next
    End Sub

    Private Sub CargarHorariosMaterias()
        horariosMaterias.Clear()

        ' Ejemplo: Programación I se dicta Martes y Jueves en bloques 3,4,5,6
        horariosMaterias("Programación I") = New List(Of (dia As String, bloque As Integer)) From {
            ("Martes", 3), ("Martes", 4), ("Martes", 5), ("Martes", 6)
        }

        ' Ejemplo: Diseño I se dicta Miércoles en bloques 1,2,3,4
        horariosMaterias("Diseño I") = New List(Of (dia As String, bloque As Integer)) From {
            ("Miércoles", 1), ("Miércoles", 2), ("Miércoles", 3), ("Miércoles", 4)
        }

        ' Podés agregar más materias con sus horarios acá
    End Sub

    Private Sub lstMaterias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstMaterias.SelectedIndexChanged
        LimpiarColores()

        If lstMaterias.SelectedItem Is Nothing Then Return

        Dim materiaSeleccionada As String = lstMaterias.SelectedItem.ToString()

        If horariosMaterias.ContainsKey(materiaSeleccionada) Then
            Dim horarios = horariosMaterias(materiaSeleccionada)
            For Each h In horarios
                SombrearCelda(h.dia, h.bloque)
            Next
        End If
    End Sub

    Private Sub SombrearCelda(dia As String, bloque As Integer)
        Dim columna As Integer = -1
        Select Case dia
            Case "Lunes" : columna = 1
            Case "Martes" : columna = 2
            Case "Miércoles" : columna = 3
            Case "Jueves" : columna = 4
            Case "Viernes" : columna = 5
            Case "Sábado" : columna = 6
        End Select

        If columna = -1 OrElse bloque < 0 OrElse bloque >= dgvHorario.Rows.Count Then Return

        dgvHorario.Rows(bloque).Cells(columna).Style.BackColor = Color.LightGreen
        dgvHorario.Rows(bloque).Cells(columna).Style.ForeColor = Color.Black
    End Sub

    Private Sub LimpiarColores()
        For Each row As DataGridViewRow In dgvHorario.Rows
            For Each cell As DataGridViewCell In row.Cells
                cell.Style.BackColor = Color.White
                cell.Style.ForeColor = Color.Black
            Next
        Next
    End Sub
End Class