Imports Newtonsoft.Json

Public Class FormLogin
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        CargarCarreras()

        Dim usuarioGuardado As Usuario = Usuario.Cargar()
        If usuarioGuardado IsNot Nothing Then
            txtUsuario.Text = usuarioGuardado.Nombre
            cmbCarrera.SelectedItem = usuarioGuardado.Carrera
        End If
    End Sub

    Private Sub CargarCarreras()
        cmbCarrera.Items.Clear()
        cmbCarrera.Items.AddRange(New String() {
            "Informática", "Biología", "Física", "Matemática", "Química",
            "Historia", "Geografía", "Filosofía", "Letras", "Psicología",
            "Economía", "Cs. de la Administración", "Cs. Política",
            "Cs. Jurídicas", "Cs. de la Educación"
        })
        cmbCarrera.SelectedIndex = 0
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If String.IsNullOrEmpty(txtUsuario.Text) Then
            MessageBox.Show("Ingresá tu usuario", "Campo requerido",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cmbCarrera.SelectedItem Is Nothing Then
            MessageBox.Show("Seleccioná tu carrera", "Campo requerido",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim usuario As New Usuario()
        usuario.Nombre = txtUsuario.Text
        usuario.Carrera = cmbCarrera.SelectedItem.ToString()
        usuario.Guardar()

        ' Guardar en variable global (desde el módulo Globales)
        UsuarioActual = usuario

        Dim dashboard As New FormDashboard()
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub

    ' EVENTOS PARA EL ENTER
    Private Sub FormLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub

    Private Sub txtUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtContraseña.Focus()
        End If
    End Sub

    Private Sub txtContraseña_KeyDown(sender As Object, e As KeyEventArgs) Handles txtContraseña.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub
End Class