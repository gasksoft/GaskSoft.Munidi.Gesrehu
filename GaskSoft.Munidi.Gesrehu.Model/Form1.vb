Imports GaskSoft.Munidi.Gesrehu.Entities

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim aaa As New ModelContext


        Dim p1 As New Persona With {
            .ApellidoPaterno = "ap1",
            .ApellidoMaterno = "am1",
            .Nombres = "n1",
            .Dni = "dni1"
        }


        Dim p2 As New Persona With {
            .ApellidoPaterno = "ap2",
            .ApellidoMaterno = "am2",
            .Nombres = "n2",
            .Dni = "dni2"
        }

        Dim p3 As New Persona With {
            .ApellidoPaterno = "ap3",
            .ApellidoMaterno = "am3",
            .Nombres = "n3",
            .Dni = "dni3"
        }

        aaa.Personas.Add(p1)
        aaa.Personas.Add(p2)
        aaa.Personas.Add(p3)


        Close()
    End Sub
End Class