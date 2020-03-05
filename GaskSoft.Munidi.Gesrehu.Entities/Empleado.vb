Imports GaskSoft.Munidi.Gesrehu.Core.NetFramework

Public Class Empleado
    Inherits Persona
    Property Ruc As String
    Public Property Domicilio As New Domicilio
    Public Property Dependientes As New ObservableListSource(Of Persona)
    Public Property Contratos As New ObservableListSource(Of Contrato)
End Class