Public Class Materia
    Public Property Id As Integer
    Public Property Nombre As String
    Public Property Modalidad As String
    Public Property Horas As Integer
    Public Property Correlativas As New List(Of Integer)
    Public Property DepartamentosPermitidos As New List(Of String)
End Class