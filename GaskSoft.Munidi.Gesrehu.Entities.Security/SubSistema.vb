Imports GaskSoft.Munidi.Gesrehu.Core.NetFramework

Public Class SubSistema
    Public Property Id As Integer
    Public Property Nombre As String
    Public Overridable ReadOnly Property Modulos As ObservableListSource(Of Modulo)
    Public Overridable Property Sistema As Sistema
End Class
