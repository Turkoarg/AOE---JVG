Imports System.Drawing.Drawing2D
Imports AOE_VG.Models

Public Class FormDashboard
    Private gestor As New GestorMaterias()
    Private materiasCarrera As List(Of Materia)

    Private Sub FormDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarMaterias()
    End Sub

    Private Sub CargarMaterias()
        If Program.UsuarioActual Is Nothing Then Return

        ' Obtener materias de la carrera del usuario
        materiasCarrera = gestor.GetMateriasPorCarrera(Program.UsuarioActual.Carrera)

        ' Mostrar en el ListBox o CheckedListBox (después lo diseñamos)
        MessageBox.Show("Cargadas " & materiasCarrera.Count & " materias")
    End Sub
End Class