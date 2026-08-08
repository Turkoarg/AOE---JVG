Imports Newtonsoft.Json

Public Class FormLogin

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCarreras()

        ' Si ya hay un usuario guardado, cargarlo
        Dim usuarioGuardado As Usuario = Usuario.Cargar()
        If usuarioGuardado IsNot Nothing Then
            txtUsuario.Text = usuarioGuardado.Nombre
            cmbCarrera.SelectedItem = usuarioGuardado.Carrera
        End If
    End Sub

    Private Sub CargarCarreras()
        cmbCarrera.Items.Clear()
        cmbCarrera.Items.AddRange(New String() {
            "Informática",
            "Biología",
            "Física",
            "Matemática",
            "Química",
            "Historia",
            "Geografía",
            "Filosofía",
            "Letras",
            "Psicología",
            "Economía",
            "Cs. de la Administración",
            "Cs. Política",
            "Cs. Jurídicas",
            "Cs. de la Educación"
        })
        cmbCarrera.SelectedIndex = 0
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Validar campos
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

        ' Crear usuario
        Dim usuario As New Usuario()
        usuario.Nombre = txtUsuario.Text
        usuario.Carrera = cmbCarrera.SelectedItem.ToString()

        ' Guardar usuario en archivo
        usuario.Guardar()

        ' Guardar en variable global
        Program.UsuarioActual = usuario

        ' Abrir Dashboard
        Dim dashboard As New FormDashboard()
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub
End Class