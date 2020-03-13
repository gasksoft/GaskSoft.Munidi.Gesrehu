Imports GaskSoft.Munidi.Gesrehu.Core.NetFramework

Public MustInherit Class Proceso
    Public Property Id As Integer
    Public Property Fecha As Date
    Public Overridable ReadOnly Property Contratos As New ObservableListSource(Of Contrato)
End Class
