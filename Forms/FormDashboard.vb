Public Class FormDashboard
    ' Lista de materias de ejemplo (sin usar GestorMaterias)
    Private materias As New List(Of String) From {
        "Pedagogía",
        "Didáctica General",
        "Filosofía",
        "Psicología Educacional",
        "Sistema y Política Educativa",
        "Lectura, Escritura y Oralidad I",
        "Lectura, Escritura y Oralidad II",
        "Nuevas Tecnologías",
        "Educación Sexual Integral"
    }

    Private Sub FormDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarMaterias()
        CargarHorarioResumen()
        ActualizarEstadisticas()
    End Sub

    Private Sub CargarMaterias()
        clbMaterias.Items.Clear()
        For Each m In materias
            clbMaterias.Items.Add(m)
        Next
    End Sub

    Private Sub CargarHorarioResumen()
        dgvHorarioResumen.Rows.Clear()
        Dim horarios As String() = {
            "8:00", "8:40", "9:20", "10:10", "10:50", "11:30", "12:10",
            "12:50", "13:30", "14:10", "14:50", "15:30", "16:10", "16:50", "17:30"
        }
        For Each h In horarios
            dgvHorarioResumen.Rows.Add(h, "", "", "", "", "", "")
        Next
    End Sub

    Private Sub ActualizarEstadisticas()
        Dim total As Integer = materias.Count
        Dim aprobadas As Integer = 2
        Dim regular As Integer = 2
        Dim enCurso As Integer = 2
        Dim pendientes As Integer = total - (aprobadas + regular + enCurso)

        lblAprobadas.Text = "✅ Aprobadas: " & aprobadas
        lblRegular.Text = "🟡 Regularizadas: " & regular
        lblEnCurso.Text = "🔵 En curso: " & enCurso
        lblPendientes.Text = "⬜ Pendientes: " & pendientes

        Dim porcentaje As Integer = CInt((aprobadas / total) * 100)
        progressBarProgreso.Value = Math.Min(porcentaje, 100)
        lblPorcentaje.Text = porcentaje & "%"
    End Sub

    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        Dim seleccionadas As New List(Of String)
        For i As Integer = 0 To clbMaterias.CheckedItems.Count - 1
            seleccionadas.Add(clbMaterias.CheckedItems(i).ToString())
        Next

        If seleccionadas.Count > 0 Then
            Dim mensaje As String = "Materias seleccionadas:" & vbCrLf
            For Each m In seleccionadas
                mensaje &= "• " & m & vbCrLf
            Next
            MessageBox.Show(mensaje, "Correlativas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("No seleccionaste ninguna materia.", "Correlativas", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Dim filtro As String = txtBuscar.Text.ToLower()
        If String.IsNullOrWhiteSpace(filtro) OrElse txtBuscar.Text = "🔍 Buscar materia..." Then
            CargarMaterias()
            Return
        End If

        clbMaterias.Items.Clear()
        For Each m In materias
            If m.ToLower().Contains(filtro) Then
                clbMaterias.Items.Add(m)
            End If
        Next
    End Sub

    Private Sub txtBuscar_Enter(sender As Object, e As EventArgs) Handles txtBuscar.Enter
        If txtBuscar.Text = "🔍 Buscar materia..." Then
            txtBuscar.Text = ""
            txtBuscar.ForeColor = SystemColors.WindowText
        End If
    End Sub

    Private Sub txtBuscar_Leave(sender As Object, e As EventArgs) Handles txtBuscar.Leave
        If String.IsNullOrWhiteSpace(txtBuscar.Text) Then
            txtBuscar.Text = "🔍 Buscar materia..."
            txtBuscar.ForeColor = SystemColors.GrayText
        End If
    End Sub
End Class