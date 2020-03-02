Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports GaskSoft.Munidi.Gesrehu


<TestClass()> Public Class PersonaTest

    <TestMethod()> Public Sub EdadCalculada()
        Dim edadEsperada = 39
        Dim fechaNacimiento = New Date(1980, 2, 29)
        Dim fechaActual = New Date(2020, 2, 28)
        Dim edadActual = CommonHelpers.DateHelper.CalcularEdad(fechaNacimiento, fechaACtual)
        Assert.AreEqual(edadEsperada, edadActual)
        fechaActual = fechaActual.AddDays(1)
        edadActual = CommonHelpers.DateHelper.CalcularEdad(fechaNacimiento, fechaActual)
        Assert.AreEqual(edadEsperada + 1, edadActual)
    End Sub
    <TestMethod()> Public Sub PersonaConFechaDeNacimientoOchoAñosAntesDeHoyDebeRetornar8()
        Dim persona As Persona = New Persona() With {.FechaNacimiento = Now.AddYears(-8)}
        Assert.AreEqual(8, persona.Edad)
    End Sub
    <TestMethod()> Public Sub PersonaConFechaDeNacimientoOchoAñosUnDiaAntesDeHoyDebeRetornar8()
        Dim persona As Persona = New Persona() With {.FechaNacimiento = Now.AddYears(-8).AddDays(-1)}
        Assert.AreEqual(8, persona.Edad)
    End Sub
    <TestMethod()> Public Sub PersonaConFechaDeNacimientoOchoAñosAntesDeHoyUndiaMenosDebeRetornar7()
        Dim persona As Persona = New Persona() With {.FechaNacimiento = Now.AddYears(-8).AddDays(1)}
        Assert.AreEqual(7, persona.Edad)
    End Sub
End Class