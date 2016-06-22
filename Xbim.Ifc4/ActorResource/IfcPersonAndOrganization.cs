// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.PropertyResource;
using Xbim.Ifc4.ExternalReferenceResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.ActorResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcPersonAndOrganization
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcPersonAndOrganization : IPersistEntity, IfcActorSelect, IfcObjectReferenceSelect, IfcResourceObjectSelect
	{
		IIfcPerson @ThePerson { get;  set; }
		IIfcOrganization @TheOrganization { get;  set; }
		IItemSet<IIfcActorRole> @Roles { get; }
	
	}
}

namespace Xbim.Ifc4.ActorResource
{
	[ExpressType("IfcPersonAndOrganization", 663)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPersonAndOrganization : INotifyPropertyChanged, IInstantiableEntity, IIfcPersonAndOrganization, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcPersonAndOrganization>
	{
		#region IIfcPersonAndOrganization explicit implementation
		IIfcPerson IIfcPersonAndOrganization.ThePerson { 
 
 
			get { return @ThePerson; } 
			set { ThePerson = value as IfcPerson;}
		}	
		IIfcOrganization IIfcPersonAndOrganization.TheOrganization { 
 
 
			get { return @TheOrganization; } 
			set { TheOrganization = value as IfcOrganization;}
		}	
		IItemSet<IIfcActorRole> IIfcPersonAndOrganization.Roles { 
			get { return new Common.Collections.ProxyItemSet<IfcActorRole, IIfcActorRole>( @Roles); } 
		}	
		 
		#endregion

		#region Implementation of IPersistEntity

		public int EntityLabel {get; internal set;}
		
		public IModel Model { get; internal set; }

		/// <summary>
        /// This property is deprecated and likely to be removed. Use just 'Model' instead.
        /// </summary>
		[Obsolete("This property is deprecated and likely to be removed. Use just 'Model' instead.")]
        public IModel ModelOf { get { return Model; } }
		
	    internal ActivationStatus ActivationStatus = ActivationStatus.NotActivated;

	    ActivationStatus IPersistEntity.ActivationStatus { get { return ActivationStatus; } }
		
		void IPersistEntity.Activate(bool write)
		{
			switch (ActivationStatus)
		    {
		        case ActivationStatus.ActivatedReadWrite:
		            return;
		        case ActivationStatus.NotActivated:
		            lock (this)
		            {
                        //check again in the lock
		                if (ActivationStatus == ActivationStatus.NotActivated)
		                {
		                    if (Model.Activate(this, write))
		                    {
		                        ActivationStatus = write
		                            ? ActivationStatus.ActivatedReadWrite
		                            : ActivationStatus.ActivatedRead;
		                    }
		                }
		            }
		            break;
		        case ActivationStatus.ActivatedRead:
		            if (!write) return;
		            if (Model.Activate(this, true))
                        ActivationStatus = ActivationStatus.ActivatedReadWrite;
		            break;
		        default:
		            throw new ArgumentOutOfRangeException();
		    }
		}

		void IPersistEntity.Activate (Action activation)
		{
			if (ActivationStatus != ActivationStatus.NotActivated) return; //activation can only happen once in a lifetime of the object
			
			activation();
			ActivationStatus = ActivationStatus.ActivatedRead;
		}

		ExpressType IPersistEntity.ExpressType { get { return Model.Metadata.ExpressType(this);  } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPersonAndOrganization(IModel model) 		{ 
			Model = model; 
			_roles = new OptionalItemSet<IfcActorRole>( this, 0,  3);
		}

		#region Explicit attribute fields
		private IfcPerson _thePerson;
		private IfcOrganization _theOrganization;
		private readonly OptionalItemSet<IfcActorRole> _roles;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 1)]
		public IfcPerson @ThePerson 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _thePerson;
				((IPersistEntity)this).Activate(false);
				return _thePerson;
			} 
			set
			{
				SetValue( v =>  _thePerson = v, _thePerson, value,  "ThePerson", 1);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 2)]
		public IfcOrganization @TheOrganization 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _theOrganization;
				((IPersistEntity)this).Activate(false);
				return _theOrganization;
			} 
			set
			{
				SetValue( v =>  _theOrganization = v, _theOrganization, value,  "TheOrganization", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.Class, 1, -1, 3)]
		public IOptionalItemSet<IfcActorRole> @Roles 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _roles;
				((IPersistEntity)this).Activate(false);
				return _roles;
			} 
		}	
		#endregion




		#region INotifyPropertyChanged implementation
		 
		public event PropertyChangedEventHandler PropertyChanged;

		protected void NotifyPropertyChanged( string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

		#endregion

		#region Transactional property setting

		protected void SetValue<TProperty>(Action<TProperty> setter, TProperty oldValue, TProperty newValue, string notifyPropertyName, byte propertyOrder)
		{
			//activate for write if it is not activated yet
			if (ActivationStatus != ActivationStatus.ActivatedReadWrite)
				((IPersistEntity)this).Activate(true);

			//just set the value if the model is marked as non-transactional
			if (!Model.IsTransactional)
			{
				setter(newValue);
				NotifyPropertyChanged(notifyPropertyName);
				return;
			}

			//check there is a transaction
			var txn = Model.CurrentTransaction;
			if (txn == null) throw new Exception("Operation out of transaction.");

			Action doAction = () => {
				setter(newValue);
				NotifyPropertyChanged(notifyPropertyName);
			};
			Action undoAction = () => {
				setter(oldValue);
				NotifyPropertyChanged(notifyPropertyName);
			};
			doAction();

			//do action and THAN add to transaction so that it gets the object in new state
			txn.AddReversibleAction(doAction, undoAction, this, ChangeType.Modified, propertyOrder);
		}

		#endregion

		#region IPersist implementation
		public virtual void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_thePerson = (IfcPerson)(value.EntityVal);
					return;
				case 1: 
					_theOrganization = (IfcOrganization)(value.EntityVal);
					return;
				case 2: 
					_roles.InternalAdd((IfcActorRole)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcPersonAndOrganization other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcPersonAndOrganization
            var root = (@IfcPersonAndOrganization)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcPersonAndOrganization left, @IfcPersonAndOrganization right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (ReferenceEquals(left.Model, right.Model));

        }

        public static bool operator !=(@IfcPersonAndOrganization left, @IfcPersonAndOrganization right)
        {
            return !(left == right);
        }

        public static bool operator ==(@IfcPersonAndOrganization left, IfcActorSelect right)
		{
			return left == right as @IfcPersonAndOrganization;
		}

		public static bool operator !=(@IfcPersonAndOrganization left, IfcActorSelect right)
		{
			return !(left == right);
		}

        public static bool operator ==(@IfcPersonAndOrganization left, IfcObjectReferenceSelect right)
		{
			return left == right as @IfcPersonAndOrganization;
		}

		public static bool operator !=(@IfcPersonAndOrganization left, IfcObjectReferenceSelect right)
		{
			return !(left == right);
		}

        public static bool operator ==(@IfcPersonAndOrganization left, IfcResourceObjectSelect right)
		{
			return left == right as @IfcPersonAndOrganization;
		}

		public static bool operator !=(@IfcPersonAndOrganization left, IfcResourceObjectSelect right)
		{
			return !(left == right);
		}

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@ThePerson != null)
					yield return @ThePerson;
				if (@TheOrganization != null)
					yield return @TheOrganization;
				foreach(var entity in @Roles)
					yield return entity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@ThePerson != null)
					yield return @ThePerson;
				if (@TheOrganization != null)
					yield return @TheOrganization;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}