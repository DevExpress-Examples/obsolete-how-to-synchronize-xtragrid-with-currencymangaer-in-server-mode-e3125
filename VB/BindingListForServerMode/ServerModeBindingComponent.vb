Imports System
Imports System.Collections
Imports DevExpress.XtraGrid
Imports System.Windows.Forms
Imports System.ComponentModel
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Data

Namespace BindinListForServerMode
    Public Class ServerModeBindingComponent
        Inherits Component
        Implements IBindingList, ITypedList

        Private Shared ReadOnly fListChanged As New Object()
        Private Const NotSupportedExceptionMessage As String = "This method is not supported"
        Private FocusedRow As Integer

        Private fGrid As GridControl
        Public Property Grid() As GridControl
            Get
                Return fGrid
            End Get
            Set(ByVal value As GridControl)
                If fGrid Is value Then
                    Return
                End If
                ReleaseGrid()
                fGrid = value
                If View Is Nothing Then
                    Return
                End If
                AddHandler View.RowCountChanged, AddressOf OnRowCountChanged
                AddHandler View.CellValueChanged, AddressOf OnCellValueChanged
                AddHandler View.FocusedRowChanged, AddressOf OnFocusedRowChanged
                AddHandler View.RowLoaded, AddressOf OnRowLoaded
                TryGetCurrencyManager()
            End Set
        End Property

        Private ReadOnly Property TypedList() As ITypedList
            Get
                Return If(View Is Nothing, Nothing, TryCast(View.DataSource, ITypedList))
            End Get
        End Property

        Private ReadOnly Property View() As GridView
            Get
                Return If(Grid Is Nothing, Nothing, TryCast(Grid.MainView, GridView))
            End Get
        End Property

        Private fCurrencyManager As CurrencyManager
        Private ReadOnly Property CurrencyManager() As CurrencyManager
            Get
                If fCurrencyManager Is Nothing Then
                    TryGetCurrencyManager()
                End If
                Return fCurrencyManager
            End Get
        End Property

        Private Sub TryGetCurrencyManager()
            If fCurrencyManager IsNot Nothing OrElse Grid Is Nothing Then
                Return
            End If
            Dim frm As Form = Grid.FindForm()
            If frm Is Nothing Then
                Return
            End If
            fCurrencyManager = CType(frm.BindingContext(Me), CurrencyManager)
            AddHandler fCurrencyManager.PositionChanged, AddressOf OnPositionChanged
        End Sub

        Private Sub OnRowCountChanged(ByVal sender As Object, ByVal e As EventArgs)
            RaiseListChanged(ListChangedType.Reset, -1)
        End Sub

        Private Sub OnCellValueChanged(ByVal sender As Object, ByVal e As CellValueChangedEventArgs)
            RaiseListChanged(ListChangedType.ItemChanged, e.RowHandle)
        End Sub

        Private LockCurrentChanged As Boolean
        Private Sub OnFocusedRowChanged(ByVal sender As Object, ByVal e As FocusedRowChangedEventArgs)
            If LockCurrentChanged OrElse CurrencyManager Is Nothing Then
                Return
            End If
            LockCurrentChanged = True
            Try
                Dim row As Object = View.GetFocusedRow()
                If TypeOf row Is NotLoadedObject Then
                    FocusedRow = e.FocusedRowHandle
                Else
                    CurrencyManager.Position = e.FocusedRowHandle
                End If

            Finally
                LockCurrentChanged = False
            End Try
        End Sub

        Private Sub OnPositionChanged(ByVal sender As Object, ByVal e As EventArgs)
            If LockCurrentChanged Then
                Return
            End If
            LockCurrentChanged = True
            Try
                View.FocusedRowHandle = fCurrencyManager.Position
            Finally
                LockCurrentChanged = False
            End Try
        End Sub

        Private Sub RaiseListChanged(ByVal type As ListChangedType, ByVal newIndex As Integer)
            Dim handler As ListChangedEventHandler = CType(Events(fListChanged), ListChangedEventHandler)
            If handler IsNot Nothing Then
                handler(Me, New ListChangedEventArgs(type, newIndex))
            End If
        End Sub

        Private Sub ReleaseGrid()
            If View Is Nothing Then
                Return
            End If
            RemoveHandler View.RowCountChanged, AddressOf OnRowCountChanged
            RemoveHandler View.CellValueChanged, AddressOf OnCellValueChanged
            RemoveHandler View.FocusedRowChanged, AddressOf OnFocusedRowChanged
            RemoveHandler View.RowLoaded, AddressOf OnRowLoaded
            fGrid = Nothing
            RemoveHandler fCurrencyManager.PositionChanged, AddressOf OnPositionChanged
            fCurrencyManager = Nothing
        End Sub

        Private Sub OnRowLoaded(ByVal sender As Object, ByVal e As RowEventArgs)
            If FocusedRow = e.RowHandle Then
                CurrencyManager.Position = FocusedRow
            End If
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                ReleaseGrid()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "IBindingList Members"

        Private Sub IBindingList_AddIndex(ByVal [property] As PropertyDescriptor) Implements IBindingList.AddIndex
        End Sub

        Private Function IBindingList_AddNew() As Object Implements IBindingList.AddNew
            Throw New NotSupportedException(NotSupportedExceptionMessage)
        End Function

        Private ReadOnly Property IBindingList_AllowEdit() As Boolean Implements IBindingList.AllowEdit
            Get
                Return True
            End Get
        End Property

        Private ReadOnly Property IBindingList_AllowNew() As Boolean Implements IBindingList.AllowNew
            Get
                Return False
            End Get
        End Property

        Private ReadOnly Property IBindingList_AllowRemove() As Boolean Implements IBindingList.AllowRemove
            Get
                Return False
            End Get
        End Property

        Private Sub IBindingList_ApplySort(ByVal [property] As PropertyDescriptor, ByVal direction As ListSortDirection) Implements IBindingList.ApplySort
            Throw New NotSupportedException(NotSupportedExceptionMessage)
        End Sub

        Private Function IBindingList_Find(ByVal [property] As PropertyDescriptor, ByVal key As Object) As Integer Implements IBindingList.Find
            Throw New NotSupportedException(NotSupportedExceptionMessage)
        End Function

        Private ReadOnly Property IBindingList_IsSorted() As Boolean Implements IBindingList.IsSorted
            Get
                Return False
            End Get
        End Property

        Private Custom Event ListChanged As ListChangedEventHandler Implements IBindingList.ListChanged
            AddHandler(ByVal value As ListChangedEventHandler)
                Events.AddHandler(fListChanged, value)
            End AddHandler
            RemoveHandler(ByVal value As ListChangedEventHandler)
                Events.RemoveHandler(fListChanged, value)
            End RemoveHandler
            RaiseEvent(ByVal sender As System.Object, ByVal e As System.ComponentModel.ListChangedEventArgs)
            End RaiseEvent
        End Event

        Private Sub IBindingList_RemoveIndex(ByVal [property] As PropertyDescriptor) Implements IBindingList.RemoveIndex
            Throw New NotSupportedException(NotSupportedExceptionMessage)
        End Sub

        Private Sub IBindingList_RemoveSort() Implements IBindingList.RemoveSort
            Throw New NotSupportedException(NotSupportedExceptionMessage)
        End Sub

        Private ReadOnly Property IBindingList_SortDirection() As ListSortDirection Implements IBindingList.SortDirection
            Get
                Throw New NotSupportedException(NotSupportedExceptionMessage)
            End Get
        End Property

        Private ReadOnly Property IBindingList_SortProperty() As PropertyDescriptor Implements IBindingList.SortProperty
            Get
                Throw New NotSupportedException(NotSupportedExceptionMessage)
            End Get
        End Property

        Private ReadOnly Property IBindingList_SupportsChangeNotification() As Boolean Implements IBindingList.SupportsChangeNotification
            Get
                Return True
            End Get
        End Property

        Private ReadOnly Property IBindingList_SupportsSearching() As Boolean Implements IBindingList.SupportsSearching
            Get
                Return False
            End Get
        End Property

        Private ReadOnly Property IBindingList_SupportsSorting() As Boolean Implements IBindingList.SupportsSorting
            Get
                Return False
            End Get
        End Property

        #End Region

        #Region "IList Members"

        Private Function IList_Add(ByVal value As Object) As Integer Implements IList.Add
            Throw New NotSupportedException(NotSupportedExceptionMessage)
        End Function

        Private Sub IList_Clear() Implements IList.Clear
            Throw New NotSupportedException(NotSupportedExceptionMessage)
        End Sub

        Private Function IList_Contains(ByVal value As Object) As Boolean Implements IList.Contains
            Throw New NotSupportedException(NotSupportedExceptionMessage)
        End Function

        Private Function IList_IndexOf(ByVal value As Object) As Integer Implements IList.IndexOf
            Throw New NotSupportedException(NotSupportedExceptionMessage)
        End Function

        Private Sub IList_Insert(ByVal index As Integer, ByVal value As Object) Implements IList.Insert
            Throw New NotSupportedException(NotSupportedExceptionMessage)
        End Sub

        Private ReadOnly Property IList_IsFixedSize() As Boolean Implements IList.IsFixedSize
            Get
                Return False
            End Get
        End Property

        Private ReadOnly Property IList_IsReadOnly() As Boolean Implements IList.IsReadOnly
            Get
                Return False
            End Get
        End Property

        Private Sub IList_Remove(ByVal value As Object) Implements IList.Remove
            Throw New NotSupportedException(NotSupportedExceptionMessage)
        End Sub

        Private Sub IList_RemoveAt(ByVal index As Integer) Implements IList.RemoveAt
            Throw New NotSupportedException(NotSupportedExceptionMessage)
        End Sub

        Public Property IList_Item(ByVal index As Integer) As Object Implements IList.Item
            Get
                Return View.GetRow(index)
            End Get
            Set(ByVal value As Object)
                Throw New NotSupportedException(NotSupportedExceptionMessage)
            End Set
        End Property

        #End Region

        #Region "ICollection Members"

        Private Sub ICollection_CopyTo(ByVal array As Array, ByVal index As Integer) Implements ICollection.CopyTo
            Throw New NotSupportedException(NotSupportedExceptionMessage)
        End Sub

        Private ReadOnly Property ICollection_Count() As Integer Implements ICollection.Count
            Get
                Return If(View Is Nothing, 0, View.DataRowCount)
            End Get
        End Property

        Private ReadOnly Property ICollection_IsSynchronized() As Boolean Implements ICollection.IsSynchronized
            Get
                Throw New NotSupportedException(NotSupportedExceptionMessage)
            End Get
        End Property

        Private ReadOnly Property ICollection_SyncRoot() As Object Implements ICollection.SyncRoot
            Get
                Throw New NotSupportedException(NotSupportedExceptionMessage)
            End Get
        End Property

        #End Region

        #Region "IEnumerable Members"

        Private Function IEnumerable_GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
            Return New ServerModeBindingComponent.EmptyEnumerator()
        End Function

        Private Class EmptyEnumerator
            Implements IEnumerator

            Private ReadOnly Property IEnumerator_Current() As Object Implements IEnumerator.Current
                Get
                    Throw New NotSupportedException(NotSupportedExceptionMessage)
                End Get
            End Property

            Private Function IEnumerator_MoveNext() As Boolean Implements IEnumerator.MoveNext
                Return False
            End Function

            Private Sub IEnumerator_Reset() Implements IEnumerator.Reset
                Throw New NotSupportedException(NotSupportedExceptionMessage)
            End Sub
        End Class

        #End Region

        #Region "ITypedList Members"

        Private Function ITypedList_GetItemProperties(ByVal listAccessors() As PropertyDescriptor) As PropertyDescriptorCollection Implements ITypedList.GetItemProperties
            If listAccessors IsNot Nothing AndAlso listAccessors.Length > 0 Then
                Throw New NotSupportedException(NotSupportedExceptionMessage)
            End If
            If View IsNot Nothing AndAlso View.DataSource Is Nothing Then
                Grid.ForceInitialize()
            End If
            Return If(TypedList Is Nothing, New PropertyDescriptorCollection(New PropertyDescriptor(){}), TypedList.GetItemProperties(Nothing))
        End Function

        Private Function ITypedList_GetListName(ByVal listAccessors() As PropertyDescriptor) As String Implements ITypedList.GetListName
            If listAccessors IsNot Nothing AndAlso listAccessors.Length > 0 Then
                Throw New NotSupportedException(NotSupportedExceptionMessage)
            End If
            Return If(TypedList Is Nothing, String.Empty, TypedList.GetListName(Nothing))
        End Function
        #End Region
    End Class
End Namespace