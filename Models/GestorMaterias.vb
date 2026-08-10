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

Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
    Dim filtro As String = txtBuscar.Text.ToLower()

    ' Si el texto está vacío o es el texto de ayuda, mostrar todas las materias
    If String.IsNullOrWhiteSpace(filtro) OrElse txtBuscar.Text = "🔍 Buscar materia..." Then
        CargarMaterias()
        Return
    End If

    ' Filtrar materias
    clbMaterias.Items.Clear()
    For Each m In materias
        If m.ToLower().Contains(filtro) Then
            clbMaterias.Items.Add(m)
        End If
    Next
End Sub