Imports GaskSoft.Munidi.Gesrehu.Core.NetFramework

Public MustInherit Class Proceso
    Property ProcesoId As Integer
    Property Contratos As New ObservableListSource(Of Contrato)
End Class
