using System;
using System.Collections;
using DevExpress.XtraGrid;
using System.Windows.Forms;
using System.ComponentModel;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Data;

namespace BindinListForServerMode {
    public class ServerModeBindingComponent :Component, IBindingList, ITypedList {
        static readonly object fListChanged = new object();
        const string NotSupportedExceptionMessage = "This method is not supported";
        int FocusedRow;

        GridControl fGrid;
        public GridControl Grid {
            get { return fGrid; }
            set {
                if (fGrid == value) return;
                ReleaseGrid();
                fGrid = value;
                if (View == null) return;
                View.RowCountChanged += OnRowCountChanged;
                View.CellValueChanged += OnCellValueChanged;
                View.FocusedRowChanged += OnFocusedRowChanged;
                View.RowLoaded += OnRowLoaded;
                TryGetCurrencyManager();
            }
        }

        ITypedList TypedList {
            get { return View == null ? null : View.DataSource as ITypedList; }
        }

        GridView View {
            get { return Grid == null ? null : Grid.MainView as GridView; }
        }

        CurrencyManager fCurrencyManager;
        CurrencyManager CurrencyManager {
            get {
                if (fCurrencyManager == null)
                    TryGetCurrencyManager();
                return fCurrencyManager;
            }
        }

        private void TryGetCurrencyManager() {
            if (fCurrencyManager != null || Grid == null) return;
            Form frm = Grid.FindForm();
            if (frm == null) return;
            fCurrencyManager = (CurrencyManager)frm.BindingContext[this];
            fCurrencyManager.PositionChanged += OnPositionChanged;
        }

        void OnRowCountChanged(object sender, EventArgs e) {
            RaiseListChanged(ListChangedType.Reset, -1);
        }

        void OnCellValueChanged(object sender, CellValueChangedEventArgs e) {
            RaiseListChanged(ListChangedType.ItemChanged, e.RowHandle);
        }

        bool LockCurrentChanged;
        void OnFocusedRowChanged(object sender, FocusedRowChangedEventArgs e) {
            if (LockCurrentChanged || CurrencyManager == null) return;
            LockCurrentChanged = true;
            try {
                object row = View.GetFocusedRow();
                if (row is NotLoadedObject)
                    FocusedRow = e.FocusedRowHandle;
                else CurrencyManager.Position = e.FocusedRowHandle;

            } finally { LockCurrentChanged = false; }
        }

        void OnPositionChanged(object sender, EventArgs e) {
            if (LockCurrentChanged) return;
            LockCurrentChanged = true;
            try {
                View.FocusedRowHandle = fCurrencyManager.Position;
            } finally { LockCurrentChanged = false; }
        }

        void RaiseListChanged(ListChangedType type, int newIndex) {
            ListChangedEventHandler handler = (ListChangedEventHandler)Events[fListChanged];
            if (handler != null) handler(this, new ListChangedEventArgs(type, newIndex));
        }

        void ReleaseGrid() {
            if (View == null) return;
            View.RowCountChanged -= OnRowCountChanged;
            View.CellValueChanged -= OnCellValueChanged;
            View.FocusedRowChanged -= OnFocusedRowChanged;
            View.RowLoaded -= OnRowLoaded;
            fGrid = null;
            fCurrencyManager.PositionChanged -= OnPositionChanged;
            fCurrencyManager = null;
        }

        void OnRowLoaded(object sender, RowEventArgs e) {
            if (FocusedRow == e.RowHandle)
                CurrencyManager.Position = FocusedRow;
        }

        protected override void Dispose(bool disposing) {
            if (disposing)
                ReleaseGrid();
            base.Dispose(disposing);
        }

        #region IBindingList Members

        void IBindingList.AddIndex(PropertyDescriptor property) { }

        object IBindingList.AddNew() {
            throw new NotSupportedException(NotSupportedExceptionMessage);
        }

        bool IBindingList.AllowEdit {
            get { return true; }
        }

        bool IBindingList.AllowNew {
            get { return false; }
        }

        bool IBindingList.AllowRemove {
            get { return false; }
        }

        void IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction) {
            throw new NotSupportedException(NotSupportedExceptionMessage);
        }

        int IBindingList.Find(PropertyDescriptor property, object key) {
            throw new NotSupportedException(NotSupportedExceptionMessage);
        }

        bool IBindingList.IsSorted {
            get { return false; }
        }

        event ListChangedEventHandler IBindingList.ListChanged {
            add { Events.AddHandler(fListChanged, value); }
            remove { Events.RemoveHandler(fListChanged, value); }
        }

        void IBindingList.RemoveIndex(PropertyDescriptor property) {
            throw new NotSupportedException(NotSupportedExceptionMessage);
        }

        void IBindingList.RemoveSort() {
            throw new NotSupportedException(NotSupportedExceptionMessage);
        }

        ListSortDirection IBindingList.SortDirection {
            get { throw new NotSupportedException(NotSupportedExceptionMessage); }
        }

        PropertyDescriptor IBindingList.SortProperty {
            get { throw new NotSupportedException(NotSupportedExceptionMessage); }
        }

        bool IBindingList.SupportsChangeNotification {
            get { return true; }
        }

        bool IBindingList.SupportsSearching {
            get { return false; }
        }

        bool IBindingList.SupportsSorting {
            get { return false; }
        }

        #endregion

        #region IList Members

        int IList.Add(object value) {
            throw new NotSupportedException(NotSupportedExceptionMessage);
        }

        void IList.Clear() {
            throw new NotSupportedException(NotSupportedExceptionMessage);
        }

        bool IList.Contains(object value) {
            throw new NotSupportedException(NotSupportedExceptionMessage);
        }

        int IList.IndexOf(object value) {
            throw new NotSupportedException(NotSupportedExceptionMessage);
        }

        void IList.Insert(int index, object value) {
            throw new NotSupportedException(NotSupportedExceptionMessage);
        }

        bool IList.IsFixedSize {
            get { return false; }
        }

        bool IList.IsReadOnly {
            get { return false; }
        }

        void IList.Remove(object value) {
            throw new NotSupportedException(NotSupportedExceptionMessage);
        }

        void IList.RemoveAt(int index) {
            throw new NotSupportedException(NotSupportedExceptionMessage);
        }

        object IList.this[int index] {
            get { return View.GetRow(index); }
            set { throw new NotSupportedException(NotSupportedExceptionMessage); }
        }

        #endregion

        #region ICollection Members

        void ICollection.CopyTo(Array array, int index) {
            throw new NotSupportedException(NotSupportedExceptionMessage);
        }

        int ICollection.Count {
            get { return View == null ? 0 : View.DataRowCount; }
        }

        bool ICollection.IsSynchronized {
            get { throw new NotSupportedException(NotSupportedExceptionMessage); }
        }

        object ICollection.SyncRoot {
            get { throw new NotSupportedException(NotSupportedExceptionMessage); }
        }

        #endregion

        #region IEnumerable Members

        IEnumerator IEnumerable.GetEnumerator() {
            return new ServerModeBindingComponent.EmptyEnumerator();
        }

        private class EmptyEnumerator : IEnumerator {
            object IEnumerator.Current {
                get { throw new NotSupportedException(NotSupportedExceptionMessage); }
            }

            bool IEnumerator.MoveNext() {
                return false;
            }

            void IEnumerator.Reset() {
                throw new NotSupportedException(NotSupportedExceptionMessage);
            }
        }

        #endregion

        #region ITypedList Members

        PropertyDescriptorCollection ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors) {
            if (listAccessors != null && listAccessors.Length > 0)
                throw new NotSupportedException(NotSupportedExceptionMessage);
            if (View != null && View.DataSource == null)
                Grid.ForceInitialize();
            return TypedList == null ? new PropertyDescriptorCollection(new PropertyDescriptor[0]) 
                : TypedList.GetItemProperties(null);
        }

        string ITypedList.GetListName(PropertyDescriptor[] listAccessors) {
            if (listAccessors != null && listAccessors.Length > 0)
                throw new NotSupportedException(NotSupportedExceptionMessage);
            return TypedList == null ? string.Empty : TypedList.GetListName(null);
        }
        #endregion
    }
}