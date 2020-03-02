Imports GaskSoft.Munidi.Gesrehu.Core.NetFramework

Public MustInherit Class Proceso
    Property Id As Integer
    Property Contratos As New ObservableListSource(Of Contrato)
End Class
