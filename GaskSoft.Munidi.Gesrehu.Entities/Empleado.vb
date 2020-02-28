Imports GaskSoft.Munidi.Gesrehu.Core.NetFramework

Public Class Empleado
    Inherits Persona
    Property PersonasDependientes As New ObservableListSource(Of Persona)
    Property Contratos As New ObservableListSource(Of Contrato)
End Class
