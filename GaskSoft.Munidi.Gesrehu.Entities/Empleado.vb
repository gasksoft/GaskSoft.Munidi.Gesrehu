Imports GaskSoft.Munidi.Gesrehu.Core.NetFramework

Public Class Empleado
    Inherits Persona

    Public Property Ruc As String
    Public Overridable Property Domicilio As New Domicilio
    Public Overridable ReadOnly Property Dependientes As New ObservableListSource(Of Persona)
    Public Overridable ReadOnly Property Contratos As New ObservableListSource(Of Contrato)
End Class