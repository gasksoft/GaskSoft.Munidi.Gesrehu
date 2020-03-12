﻿Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Data.Entity

<DebuggerNonUserCode>
Public Class ObservableListSource(Of T As Class)
    Inherits ObservableCollection(Of T)
    Implements IListSource

    Private _bindingList As IBindingList

    Public Sub New()
    End Sub

    Public Sub New(collection As IEnumerable(Of T))
        MyBase.New(collection)
    End Sub

    Public Sub New(list As Collection(Of T))
        MyBase.New(list)
    End Sub

    Private ReadOnly Property ContainsListCollection As Boolean Implements IListSource.ContainsListCollection
        Get
            Return False
        End Get
    End Property

    Public Function GetList() As IList Implements IListSource.GetList

        If _bindingList Is Nothing Then
            _bindingList = ToBindingList()
        End If
        Return _bindingList
    End Function

End Class
