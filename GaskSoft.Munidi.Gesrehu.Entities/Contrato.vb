Imports GaskSoft.Munidi.Gesrehu.Core.NetFramework

Public MustInherit Class Contrato
    Public Property Id As Integer
    Public Property Empleado As Empleado
    Public Property Proceso As Proceso
    Public Property PlazoContrato As PlazoContrato
    Public Overridable ReadOnly Property Adendas As ObservableListSource(Of Adenda)
End Class
