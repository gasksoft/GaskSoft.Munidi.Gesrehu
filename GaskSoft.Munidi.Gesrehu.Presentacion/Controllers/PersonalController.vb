Imports System.Web.Mvc

Namespace Controllers
    Public Class PersonalController
        Inherits Controller

        ' GET: Personal
        Function Index() As ActionResult
            Return View()
        End Function
    End Class
End Namespace