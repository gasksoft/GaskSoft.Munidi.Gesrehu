Imports GaskSoft.Munidi.Gesrehu.Entities

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim aaa As New ModelContext


        Dim p1 As New Empleado With {
            .ApellidoPaterno = "ap1",
            .ApellidoMaterno = "am1",
            .Nombres = "n1",
            .Dni = "dni1",
            .FechaNacimiento = New Date(1978, 11, 23)
        }

        Dim p2 As New Persona With {
            .ApellidoPaterno = "ap2",
            .ApellidoMaterno = "am2",
            .Nombres = "n2",
            .Dni = "dni2",
            .FechaNacimiento = New Date(1978, 11, 23)
        }

        Dim p3 As New Persona With {
            .ApellidoPaterno = "ap3",
            .ApellidoMaterno = "am3",
            .Nombres = "n3",
            .Dni = "dni3",
            .FechaNacimiento = New Date(1978, 11, 23)
        }

        p2.Responsable = p1
        p3.Responsable = p1

        aaa.Personas.Add(p1)
        aaa.Personas.Add(p2)
        aaa.Personas.Add(p3)

        Dim proceso1 As New Concurso



        aaa.SaveChanges()

        Close()
    End Sub
End Class