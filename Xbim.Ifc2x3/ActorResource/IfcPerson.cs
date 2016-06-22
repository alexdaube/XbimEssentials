// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.PropertyResource;
using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.ActorResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcPerson
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcPerson : IPersistEntity, IfcActorSelect, IfcObjectReferenceSelect
	{
		IfcIdentifier? @Id { get;  set; }
		IfcLabel? @FamilyName { get;  set; }
		IfcLabel? @GivenName { get;  set; }
		IItemSet<IfcLabel> @MiddleNames { get; }
		IItemSet<IfcLabel> @PrefixTitles { get; }
		IItemSet<IfcLabel> @SuffixTitles { get; }
		IItemSet<IIfcActorRole> @Roles { get; }
		IItemSet<IIfcAddress> @Addresses { get; }
		IEnumerable<IIfcPersonAndOrganization> @EngagedIn {  get; }
	
	}
}

namespace Xbim.Ifc2x3.ActorResource
{
	[ExpressType("IfcPerson", 198)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPerson : INotifyPropertyChanged, IInstantiableEntity, IIfcPerson, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcPerson>
	{
		#region IIfcPerson explicit implementation
		IfcIdentifier? IIfcPerson.Id { 
 
			get { return @Id; } 
			set { Id = value;}
		}	
		IfcLabel? IIfcPerson.FamilyName { 
 
			get { return @FamilyName; } 
			set { FamilyName = value;}
		}	
		IfcLabel? IIfcPerson.GivenName { 
 
			get { return @GivenName; } 
			set { GivenName = value;}
		}	
		IItemSet<IfcLabel> IIfcPerson.MiddleNames { 
			get { return @MiddleNames; } 
		}	
		IItemSet<IfcLabel> IIfcPerson.PrefixTitles { 
			get { return @PrefixTitles; } 
		}	
		IItemSet<IfcLabel> IIfcPerson.SuffixTitles { 
			get { return @SuffixTitles; } 
		}	
		IItemSet<IIfcActorRole> IIfcPerson.Roles { 
			get { return new Common.Collections.ProxyItemSet<IfcActorRole, IIfcActorRole>( @Roles); } 
		}	
		IItemSet<IIfcAddress> IIfcPerson.Addresses { 
			get { return new Common.Collections.ProxyItemSet<IfcAddress, IIfcAddress>( @Addresses); } 
		}	
		 
		IEnumerable<IIfcPersonAndOrganization> IIfcPerson.EngagedIn {  get { return @EngagedIn; } }
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
		internal IfcPerson(IModel model) 		{ 
			Model = model; 
			_middleNames = new OptionalItemSet<IfcLabel>( this, 0,  4);
			_prefixTitles = new OptionalItemSet<IfcLabel>( this, 0,  5);
			_suffixTitles = new OptionalItemSet<IfcLabel>( this, 0,  6);
			_roles = new OptionalItemSet<IfcActorRole>( this, 0,  7);
			_addresses = new OptionalItemSet<IfcAddress>( this, 0,  8);
		}

		#region Explicit attribute fields
		private IfcIdentifier? _id;
		private IfcLabel? _familyName;
		private IfcLabel? _givenName;
		private readonly OptionalItemSet<IfcLabel> _middleNames;
		private readonly OptionalItemSet<IfcLabel> _prefixTitles;
		private readonly OptionalItemSet<IfcLabel> _suffixTitles;
		private readonly OptionalItemSet<IfcActorRole> _roles;
		private readonly OptionalItemSet<IfcAddress> _addresses;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 1)]
		public IfcIdentifier? @Id 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _id;
				((IPersistEntity)this).Activate(false);
				return _id;
			} 
			set
			{
				SetValue( v =>  _id = v, _id, value,  "Id", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 2)]
		public IfcLabel? @FamilyName 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _familyName;
				((IPersistEntity)this).Activate(false);
				return _familyName;
			} 
			set
			{
				SetValue( v =>  _familyName = v, _familyName, value,  "FamilyName", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 3)]
		public IfcLabel? @GivenName 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _givenName;
				((IPersistEntity)this).Activate(false);
				return _givenName;
			} 
			set
			{
				SetValue( v =>  _givenName = v, _givenName, value,  "GivenName", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.None, 1, -1, 4)]
		public IOptionalItemSet<IfcLabel> @MiddleNames 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _middleNames;
				((IPersistEntity)this).Activate(false);
				return _middleNames;
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.None, 1, -1, 5)]
		public IOptionalItemSet<IfcLabel> @PrefixTitles 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _prefixTitles;
				((IPersistEntity)this).Activate(false);
				return _prefixTitles;
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.None, 1, -1, 6)]
		public IOptionalItemSet<IfcLabel> @SuffixTitles 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _suffixTitles;
				((IPersistEntity)this).Activate(false);
				return _suffixTitles;
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.Class, 1, -1, 7)]
		public IOptionalItemSet<IfcActorRole> @Roles 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _roles;
				((IPersistEntity)this).Activate(false);
				return _roles;
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.Class, 1, -1, 8)]
		public IOptionalItemSet<IfcAddress> @Addresses 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _addresses;
				((IPersistEntity)this).Activate(false);
				return _addresses;
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("ThePerson")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, -1, 9)]
		public IEnumerable<IfcPersonAndOrganization> @EngagedIn 
		{ 
			get 
			{
				return Model.Instances.Where<IfcPersonAndOrganization>(e => Equals(e.ThePerson), "ThePerson", this);
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
					_id = value.StringVal;
					return;
				case 1: 
					_familyName = value.StringVal;
					return;
				case 2: 
					_givenName = value.StringVal;
					return;
				case 3: 
					_middleNames.InternalAdd(value.StringVal);
					return;
				case 4: 
					_prefixTitles.InternalAdd(value.StringVal);
					return;
				case 5: 
					_suffixTitles.InternalAdd(value.StringVal);
					return;
				case 6: 
					_roles.InternalAdd((IfcActorRole)value.EntityVal);
					return;
				case 7: 
					_addresses.InternalAdd((IfcAddress)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcPerson other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcPerson
            var root = (@IfcPerson)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcPerson left, @IfcPerson right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (ReferenceEquals(left.Model, right.Model));

        }

        public static bool operator !=(@IfcPerson left, @IfcPerson right)
        {
            return !(left == right);
        }

        public static bool operator ==(@IfcPerson left, IfcActorSelect right)
		{
			return left == right as @IfcPerson;
		}

		public static bool operator !=(@IfcPerson left, IfcActorSelect right)
		{
			return !(left == right);
		}

        public static bool operator ==(@IfcPerson left, IfcObjectReferenceSelect right)
		{
			return left == right as @IfcPerson;
		}

		public static bool operator !=(@IfcPerson left, IfcObjectReferenceSelect right)
		{
			return !(left == right);
		}

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				foreach(var entity in @Roles)
					yield return entity;
				foreach(var entity in @Addresses)
					yield return entity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				foreach(var entity in @Addresses)
					yield return entity;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}