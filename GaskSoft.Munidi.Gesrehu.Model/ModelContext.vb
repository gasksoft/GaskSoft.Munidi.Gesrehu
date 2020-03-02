Imports System.Data.Entity
Imports GaskSoft.Munidi.Gesrehu.Entities

Public Class ModelContext
    Inherits DbContext

    Sub New()
        MyBase.New("ModelContext")

        Database.SetInitializer(New MigrateDatabaseToLatestVersion(Of ModelContext, Migrations.Configuration))
    End Sub

    Property Personas As DbSet(Of Persona)
    Property Contratos As DbSet(Of Contrato)
    Property Procesos As DbSet(Of Proceso)
    Property Regimenes As DbSet(Of Regimen)

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        modelBuilder.Entity(Of Persona).
            ToTable(NameOf(Persona)).
            HasKey(Function(x) x.Dni)

        modelBuilder.Entity(Of Persona).
            HasOptional(Function(x) x.Responsable).
            WithMany(Function(x) x.Dependientes)

        modelBuilder.Entity(Of Empleado).
            ToTable(NameOf(Empleado))

        modelBuilder.Entity(Of Contrato).
            ToTable(NameOf(Contrato)).
            HasRequired(Function(x) x.Proceso).
            WithMany(Function(x) x.Contratos)

        modelBuilder.Entity(Of Contrato).
            HasRequired(Function(x) x.Regimen).
            WithMany(Function(x) x.Contratos)

        modelBuilder.Entity(Of Contrato).
            HasRequired(Function(x) x.Empleado).
            WithMany(Function(x) x.Contratos)

        modelBuilder.Entity(Of Regimen).
            ToTable(NameOf(Regimen))

        modelBuilder.Entity(Of Proceso).
            ToTable(NameOf(Proceso))

    End Sub
End Class
