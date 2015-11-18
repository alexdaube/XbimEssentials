// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

using Xbim.Common;

namespace Xbim.Ifc2x3
{
    public class ItemSet<T> : IItemSet<T>
    {
        private readonly List<T> _set;

        private IModel Model { get { return OwningEntity.Model; } }

		public IPersistEntity OwningEntity { get; private set; }

        protected List<T> Internal
        {
            get { return _set; }
        }


        internal ItemSet(IPersistEntity entity)
        {
            _set = new List<T>();
			OwningEntity = entity;
        }

		internal ItemSet(IPersistEntity entity, int capacity)
        {
			//this will create internal list of optimal capacity
            _set = new List<T>(capacity > 0 ? capacity : 0);
			OwningEntity = entity;
        }

        internal ItemSet(IPersistEntity entity, IEnumerable<T> collection)
        {
            _set = new List<T>(collection);
			OwningEntity = entity;
        }

		//this is to be only used internaly to add object outside of any transaction or event firing
		//that is typically during parsing operation
		internal void InternalAdd(T value)
		{
			Internal.Add(value);
		}

		
        public T InternalGetAt(int index)
        {
            if (index < Count)
                return this[index];

            if (index > Count)
                throw new Exception("It is not possible to get object which is more that just the next after the last one.");
            
            if (!typeof (IList).IsAssignableFrom(typeof (T)))
                return default(T);

            var result = (T) Activator.CreateInstance(typeof (T), BindingFlags.NonPublic | BindingFlags.Instance, null,
                new object[] {OwningEntity}, null);
            InternalAdd(result);
            return result;

        }

        /// <summary>
        /// This function makes it possible to add nested lists if this is the case.
        /// It works like InsertAt is the object doesn't exist already. You cannot create lists with wholes.
        /// </summary>
        /// <param name="index">Index of the object</param>
        /// <returns>Object at specified index. If it is a nested list and it doesn't exist it gets created.</returns>
        public T GetAt(int index)
        {
            if (index < Count)
                return this[index];

            if (index > Count)
                throw new Exception("It is not possible to get object which is more that just the next after the last one.");
            
            if (!typeof(IList).IsAssignableFrom(typeof(T)))
                return default(T);
            
            var result = (T)Activator.CreateInstance(typeof(T), BindingFlags.NonPublic | BindingFlags.Instance, null, 
                new object[]{OwningEntity}, null);
            Insert(index, result);
            return result;
        }

        #region IItemSet<T> Members
        public T First
        {
            get { return Internal.First(); }
        }

        public T FirstOrDefault()
        {
            return Internal.FirstOrDefault();
        }

        public T FirstOrDefault(Func<T, bool> predicate)
        {
            return Internal.FirstOrDefault(predicate);
        }

        public TF FirstOrDefault<TF>(Func<TF, bool> predicate)
        {
            return OfType<TF>().FirstOrDefault(predicate);
        }

        public IEnumerable<TW> Where<TW>(Func<TW, bool> predicate)
        {
            return OfType<TW>().Where(predicate);
        }

        public IEnumerable<TO> OfType<TO>()
        {
            return Internal.Count == 0 ? Enumerable.Empty<TO>() : Internal.OfType<TO>();
        }
        #endregion

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyCountChanged()
        {
            if (PropertyChanged == null) return;
            PropertyChanged(this, new PropertyChangedEventArgs("Count"));
        }

        #endregion

        #region INotifyCollectionChanged Members

        public event NotifyCollectionChangedEventHandler CollectionChanged;
		
		private void NotifyCollectionChanged(NotifyCollectionChangedAction action, T item)
		{
			if (CollectionChanged == null) return;
			CollectionChanged(this, new NotifyCollectionChangedEventArgs(action, item));
		}

		private void NotifyCollectionChanged(NotifyCollectionChangedAction action, IEnumerable<T> items)
		{
			if (CollectionChanged == null) return;
			CollectionChanged(this, new NotifyCollectionChangedEventArgs(action, items));
		}

		private void NotifyCollectionChanged(NotifyCollectionChangedAction action)
		{
			if (CollectionChanged == null) return;
			CollectionChanged(this, new NotifyCollectionChangedEventArgs(action));
		}

        #endregion

        #region ICollection<T> Members

        public virtual void Add(T item)
        {
            if(Model.IsTransactional && Model.CurrentTransaction == null)
                throw new Exception("Operation out of transaction");
			
			//activate owning entity for write in case it is not active yet
			OwningEntity.Activate(true);

			Action doAction = () => {
				Internal.Add(item);
				NotifyCollectionChanged(NotifyCollectionChangedAction.Add, item);
				NotifyCountChanged();
			};

			doAction();

            if (!Model.IsTransactional) return;
            
            Action undoAction = () => {
				Internal.Remove(item);
				NotifyCollectionChanged(NotifyCollectionChangedAction.Remove, item);
				NotifyCountChanged();
			};

            Model.CurrentTransaction.AddReversibleAction(doAction, undoAction, OwningEntity, ChangeType.Modified);
        }


        public virtual void Clear()
        {
                        if (Model.IsTransactional && Model.CurrentTransaction == null)
                throw new Exception("Operation out of transaction");

            OwningEntity.Activate(true);

            var oldItems = Internal.ToArray();
            Action doAction = () =>
            {
                Internal.Clear();
                NotifyCollectionChanged(NotifyCollectionChangedAction.Reset);
                NotifyCountChanged();
            };
            doAction();

            if (!Model.IsTransactional) return;

            Action undoAction = () =>
            {
                Internal.AddRange(oldItems);
                NotifyCollectionChanged(NotifyCollectionChangedAction.Add, oldItems);
                NotifyCountChanged();
            };
            Model.CurrentTransaction.AddReversibleAction(doAction, undoAction, OwningEntity, ChangeType.Modified);
        }

        public bool Contains(T item)
        {
            return Internal.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            Internal.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return Internal.Count; }
        }


        public virtual bool Remove(T item)
        {
            if (Model.IsTransactional && Model.CurrentTransaction == null)
                throw new Exception("Operation out of transaction");

            OwningEntity.Activate(true);

            var removed = Internal.Remove(item);
            //don't do anything if nothing happened realy
            if (!removed) return false;
			//raise events
            NotifyCollectionChanged(NotifyCollectionChangedAction.Remove, item);
            NotifyCountChanged();

            if (!Model.IsTransactional) return true;

            Action doAction = () =>
            {
                Internal.Remove(item);
                NotifyCollectionChanged(NotifyCollectionChangedAction.Remove, item);
                NotifyCountChanged();
            };
            Action undoAction = () =>
            {
                Internal.Add(item);
                NotifyCollectionChanged(NotifyCollectionChangedAction.Add, item);
                NotifyCountChanged();
            };
            Model.CurrentTransaction.AddReversibleAction(doAction, undoAction, OwningEntity, ChangeType.Modified);
            
            return true;
        }

        #endregion

        #region IEnumerable<T> Members

        public IEnumerator<T> GetEnumerator()
        {
            return Internal.Count == 0 ? Enumerable.Empty<T>().GetEnumerator() : Internal.GetEnumerator();
        }

        #endregion

        #region IEnumerable Members

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Internal.Count == 0 ? Enumerable.Empty<T>().GetEnumerator() : Internal.GetEnumerator();
        }

        #endregion

        #region ICollection<T> Members

        void ICollection<T>.Add(T item)
        {
            Add(item);
        }

        void ICollection<T>.Clear()
        {
            Clear();
        }

        bool ICollection<T>.Contains(T item)
        {
            return Internal.Contains(item);
        }

        void ICollection<T>.CopyTo(T[] array, int arrayIndex)
        {
            Internal.CopyTo(array, arrayIndex);
        }

        int ICollection<T>.Count
        {
            get { return Count; }
        }

        bool ICollection<T>.IsReadOnly
        {
            get { return ((IList<T>)Internal).IsReadOnly; }
        }

        bool ICollection<T>.Remove(T item)
        {
            return Remove(item);
        }

        #endregion

        #region ICollection Members

        void ICollection.CopyTo(Array array, int index)
        {
            CopyTo((T[])array, index);
        }

        int ICollection.Count
        {
            get { return Internal.Count; }
        }

        bool ICollection.IsSynchronized
        {
            get { return ((ICollection)Internal).IsSynchronized; }
        }

        object ICollection.SyncRoot
        {
            get { return ((ICollection)Internal).SyncRoot; }
        }

        #endregion

		#region IList<T> members
		public T this[int index]
		{
		    get
		    {
		        return Internal[index];
		    }
		    set
		    {
				if(Model.IsTransactional && Model.CurrentTransaction == null)
				    throw new Exception("Operation out of transaction");

                OwningEntity.Activate(true);

				var oldValue = Internal[index];
                Action doAction = () =>
                {
                    Internal[index] = value;
                    NotifyCollectionChanged(NotifyCollectionChangedAction.Replace, value);
                };

		        doAction();

		        if (!Model.IsTransactional) return;

		        Action undoAction = () =>
		        {
		            Internal[index] = oldValue;
                    NotifyCollectionChanged(NotifyCollectionChangedAction.Replace, oldValue);
		        };
		        
				Model.CurrentTransaction.AddReversibleAction(doAction, undoAction, OwningEntity, ChangeType.Modified);
		    }
		}

		public int IndexOf(T item)
		{
			return Internal.IndexOf(item);
		}


        public void Insert(int index, T item)
        {
            if (Model.IsTransactional && Model.CurrentTransaction == null)
                throw new Exception("Operation out of transaction");

            OwningEntity.Activate(true);

            Action doAction = () =>
            {
                Internal.Insert(index, item);
                NotifyCollectionChanged(NotifyCollectionChangedAction.Add, item);
                NotifyCountChanged();
            };
			doAction();

            if (!Model.IsTransactional) return;

            Action undoAction = () =>
            {
                Internal.RemoveAt(index);
                NotifyCollectionChanged(NotifyCollectionChangedAction.Remove, item);
                NotifyCountChanged();
            };
            Model.CurrentTransaction.AddReversibleAction(doAction, undoAction, OwningEntity, ChangeType.Modified);
        }

        public void RemoveAt(int index)
        {
            var toRemove = Internal[index];
            Remove(toRemove);
        }
        #endregion

        #region IList members
        int IList.Add(object value)
        {
            if (!(value is T)) return -1;

            var v = (T) value;
            Add(v);
            return Internal.Count - 1;
        }

        bool IList.Contains(object value)
        {
            return ((IList)Internal).Contains(value);
        }

        int IList.IndexOf(object value)
        {
            return ((IList)Internal).IndexOf(value);
        }

        void IList.Insert(int index, object value)
        {
            Insert(index, (T)value);
        }

        bool IList.IsFixedSize
        {
            get { return false; }
        }

        bool IList.IsReadOnly
        {
            get { return Model.IsTransactional && Model.CurrentTransaction != null; }
        }

        void IList.Remove(object value)
        {
            Remove((T)value);
        }

        object IList.this[int index]
        {
            get
            {
                return this[index];
            }
            set
            {
                this[index] = value == null ? default(T) : (T)value;
            }
        }
        #endregion
    }
}
