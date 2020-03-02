Imports GaskSoft.Munidi.Gesrehu.CommonHelpers

Public Class Persona
    Public Property Dni As String
    Public Property ApellidoPaterno As String
    Public Property ApellidoMaterno As String
    Public Property Nombres As String
    Public Property EstadoCivil As EEstadoCivil
    Public Property FechaNacimiento As Date?

    Public Property Responsable As Empleado

    Public ReadOnly Property Edad As Integer
        Get
            Return DateHelper.CalcularEdad(FechaNacimiento)
        End Get
    End Property

    Public ReadOnly Property ApellidosNombres As String
        Get
            Return $"{Trim($"{ApellidoMaterno} {ApellidoMaterno}")}, {Nombres}"
        End Get
    End Property
End Class
