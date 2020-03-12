Public Class Menu
    Dim _personass As List(Of Persona)
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _personass = New List(Of Persona)

        _personass.Add(New Persona With {.Id = 1, .Apellidos = "sssssss"})
        _personass.Add(New Persona With {.Id = 2, .Apellidos = "sdesds"})
        _personass.Add(New Persona With {.Id = 3, .Apellidos = "qqqwq"})
        _personass.Add(New Persona With {.Id = 4, .Apellidos = "vbvbfe"})
        _personass.Add(New Persona With {.Id = 5, .Apellidos = "4sffgr"})

        PersonaBindingSource.DataSource = _personass

    End Sub
End Class