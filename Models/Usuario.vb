Public Class Usuario
    Public Property Nombre As String
    Public Property Carrera As String
    Public Property MateriasAprobadas As New List(Of Integer)

    ' Guardar en archivo JSON
    Public Sub Guardar()
        Dim ruta As String = "usuario.json"
        Dim json As String = Newtonsoft.Json.JsonConvert.SerializeObject(Me)
        System.IO.File.WriteAllText(ruta, json)
    End Sub

    ' Cargar desde archivo JSON
    Public Shared Function Cargar() As Usuario
        Dim ruta As String = "usuario.json"
        If System.IO.File.Exists(ruta) Then
            Dim json As String = System.IO.File.ReadAllText(ruta)
            Return Newtonsoft.Json.JsonConvert.DeserializeObject(Of Usuario)(json)
        End If
        Return Nothing
    End Function
End Class