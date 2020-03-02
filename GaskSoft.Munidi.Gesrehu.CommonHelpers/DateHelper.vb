Public Class DateHelper
    Private Sub New()
    End Sub

    Public Shared Function CalcularEdad(fechaNacimiento As Date, fechaActual As Date) As Integer
        Return Math.Floor(Fecha2Double(fechaActual) - Fecha2Double(fechaNacimiento))
    End Function

    Public Shared Function CalcularEdad(fechaNacimiento As Date) As Integer
        Return CalcularEdad(fechaNacimiento, Now)
    End Function

    Public Shared Function Fecha2Double(fecha As Date) As Double
        Dim mesDecimal = fecha.Month / 12
        Dim diaDecimal = fecha.Day / 372
        Return fecha.Year + mesDecimal + diaDecimal
    End Function
End Class
