Public Class SubSistema
    Property Id As Integer
    Property Nombre As String
    Property Modulos As ICollection(Of Modulo)

    Public Property Sistema As Sistema
        Get
            Return Nothing
        End Get
        Set(value As Sistema)
        End Set
    End Property
End Class
