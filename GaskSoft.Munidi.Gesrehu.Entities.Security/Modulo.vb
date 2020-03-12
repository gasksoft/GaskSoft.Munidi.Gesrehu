Imports GaskSoft.Munidi.Gesrehu.Core.NetFramework

Public Class Modulo
    Public Property Id As Integer
    Public Property Nombre As String
    Public Property SubSistema As SubSistema
    Public Overridable ReadOnly Property Permisos As ObservableListSource(Of Permiso)
End Class
