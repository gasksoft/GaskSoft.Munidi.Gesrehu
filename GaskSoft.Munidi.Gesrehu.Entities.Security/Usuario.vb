Imports GaskSoft.Munidi.Gesrehu.Core.NetFramework

Public Class Usuario
    Public Property UserName As String
    Public Property Password As String
    Public Property Salt As String
    Public Overridable ReadOnly Property Permisos As ObservableListSource(Of Permiso)
End Class
