Imports System.Data.Entity
Imports System.Data.Entity.ModelConfiguration
Imports GaskSoft.Munidi.Gesrehu.Entities

Public Class ModelContext
    Inherits DbContext

    Public Sub New()
        MyBase.New("ModelContext")

        Database.SetInitializer(New MigrateDatabaseToLatestVersion(Of ModelContext, Migrations.Configuration))
    End Sub

    Public Property Personas As DbSet(Of Persona)
    Public Property Contratos As DbSet(Of Contrato)
    Public Property Procesos As DbSet(Of Proceso)

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        modelBuilder.Configurations.Add(New PersonaMap)
        modelBuilder.Configurations.Add(New EmpleadoMap)
        modelBuilder.Configurations.Add(New ProcesoMap)
        modelBuilder.Configurations.Add(New ContratoMap)
        modelBuilder.Configurations.Add(New AdendaMap)
        modelBuilder.Configurations.Add(New PlazoContratoMap)
    End Sub
End Class

Public Class PersonaMap
    Inherits EntityTypeConfiguration(Of Persona)

    Public Sub New()
        ToTable(NameOf(Persona))
        HasKey(Function(x) x.Dni)
        HasOptional(Function(x) x.Responsable).WithMany(Function(x) x.Dependientes)
    End Sub
End Class

Public Class ContratoMap
    Inherits EntityTypeConfiguration(Of Contrato)

    Public Sub New()
        ToTable(NameOf(Contrato))
        HasRequired(Function(x) x.PlazoContrato).WithRequiredPrincipal(Function(x) x.Contrato)
        HasRequired(Function(x) x.Empleado).WithMany(Function(x) x.Contratos)
        HasRequired(Function(x) x.Proceso).WithMany(Function(x) x.Contratos)
    End Sub
End Class

Public Class EmpleadoMap
    Inherits EntityTypeConfiguration(Of Empleado)

    Public Sub New()
        ToTable(NameOf(Empleado))
    End Sub
End Class

Public Class AdendaMap
    Inherits EntityTypeConfiguration(Of Adenda)

    Public Sub New()
        ToTable(NameOf(Adenda))
    End Sub
End Class

Public Class PlazoContratoMap
    Inherits EntityTypeConfiguration(Of PlazoContrato)

    Public Sub New()
        ToTable(NameOf(PlazoContrato))
    End Sub
End Class

Public Class ProcesoMap
    Inherits EntityTypeConfiguration(Of Proceso)

    Public Sub New()
        ToTable(NameOf(Proceso))
    End Sub
End Class