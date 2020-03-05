Public Class Usuario
    Property UserName As String
    Property Password As String
    Property Salt As String
    Property Permisos As ICollection(Of Permiso)
End Class
