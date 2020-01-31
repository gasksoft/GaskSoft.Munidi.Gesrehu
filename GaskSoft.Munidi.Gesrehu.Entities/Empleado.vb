Imports GaskSoft.Munidi.Gesrehu.Core.NetFramework

Public Class Empleado
    Inherits Persona
    Sub New()
        Telefonos = New ObservableListSource(Of Telefono)
    End Sub
    Overridable ReadOnly Property Telefonos As ObservableListSource(Of Telefono)
    Overridable Property Domicilio As Domicilio
    Overridable Property Regimen As Regimen
    Overridable Property AdministradorFondoPensiones As AdministradorFondoPensiones
End Class
