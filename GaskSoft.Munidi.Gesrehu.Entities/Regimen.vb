﻿Imports GaskSoft.Munidi.Gesrehu.Core.NetFramework

Public MustInherit Class Regimen
    Property RegimenId As Integer
    Property Contratos As New ObservableListSource(Of Contrato)
End Class
