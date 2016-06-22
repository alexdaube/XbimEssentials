// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.ActorResource;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.DateTimeResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.UtilityResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcOwnerHistory
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcOwnerHistory : IPersistEntity
	{
		IIfcPersonAndOrganization @OwningUser { get;  set; }
		IIfcApplication @OwningApplication { get;  set; }
		IfcStateEnum? @State { get;  set; }
		IfcChangeActionEnum? @ChangeAction { get;  set; }
		IfcTimeStamp? @LastModifiedDate { get;  set; }
		IIfcPersonAndOrganization @LastModifyingUser { get;  set; }
		IIfcApplication @LastModifyingApplication { get;  set; }
		IfcTimeStamp @CreationDate { get;  set; }
	
	}
}

namespace Xbim.Ifc4.UtilityResource
{
	[ExpressType("IfcOwnerHistory", 519)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcOwnerHistory : INotifyPropertyChanged, IInstantiableEntity, IIfcOwnerHistory, IContainsEntityReferences, IEquatable<@IfcOwnerHistory>
	{
		#region IIfcOwnerHistory explicit implementation
		IIfcPersonAndOrganization IIfcOwnerHistory.OwningUser { 
 
 
			get { return @OwningUser; } 
			set { OwningUser = value as IfcPersonAndOrganization;}
		}	
		IIfcApplication IIfcOwnerHistory.OwningApplication { 
 
 
			get { return @OwningApplication; } 
			set { OwningApplication = value as IfcApplication;}
		}	
		IfcStateEnum? IIfcOwnerHistory.State { 
 
			get { return @State; } 
			set { State = value;}
		}	
		IfcChangeActionEnum? IIfcOwnerHistory.ChangeAction { 
 
			get { return @ChangeAction; } 
			set { ChangeAction = value;}
		}	
		IfcTimeStamp? IIfcOwnerHistory.LastModifiedDate { 
 
			get { return @LastModifiedDate; } 
			set { LastModifiedDate = value;}
		}	
		IIfcPersonAndOrganization IIfcOwnerHistory.LastModifyingUser { 
 
 
			get { return @LastModifyingUser; } 
			set { LastModifyingUser = value as IfcPersonAndOrganization;}
		}	
		IIfcApplication IIfcOwnerHistory.LastModifyingApplication { 
 
 
			get { return @LastModifyingApplication; } 
			set { LastModifyingApplication = value as IfcApplication;}
		}	
		IfcTimeStamp IIfcOwnerHistory.CreationDate { 
 
			get { return @CreationDate; } 
			set { CreationDate = value;}
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
		internal IfcOwnerHistory(IModel model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPersonAndOrganization _owningUser;
		private IfcApplication _owningApplication;
		private IfcStateEnum? _state;
		private IfcChangeActionEnum? _changeAction;
		private IfcTimeStamp? _lastModifiedDate;
		private IfcPersonAndOrganization _lastModifyingUser;
		private IfcApplication _lastModifyingApplication;
		private IfcTimeStamp _creationDate;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 1)]
		public IfcPersonAndOrganization @OwningUser 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _owningUser;
				((IPersistEntity)this).Activate(false);
				return _owningUser;
			} 
			set
			{
				SetValue( v =>  _owningUser = v, _owningUser, value,  "OwningUser", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 2)]
		public IfcApplication @OwningApplication 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _owningApplication;
				((IPersistEntity)this).Activate(false);
				return _owningApplication;
			} 
			set
			{
				SetValue( v =>  _owningApplication = v, _owningApplication, value,  "OwningApplication", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 3)]
		public IfcStateEnum? @State 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _state;
				((IPersistEntity)this).Activate(false);
				return _state;
			} 
			set
			{
				SetValue( v =>  _state = v, _state, value,  "State", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 4)]
		public IfcChangeActionEnum? @ChangeAction 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _changeAction;
				((IPersistEntity)this).Activate(false);
				return _changeAction;
			} 
			set
			{
				SetValue( v =>  _changeAction = v, _changeAction, value,  "ChangeAction", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 5)]
		public IfcTimeStamp? @LastModifiedDate 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _lastModifiedDate;
				((IPersistEntity)this).Activate(false);
				return _lastModifiedDate;
			} 
			set
			{
				SetValue( v =>  _lastModifiedDate = v, _lastModifiedDate, value,  "LastModifiedDate", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 6)]
		public IfcPersonAndOrganization @LastModifyingUser 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _lastModifyingUser;
				((IPersistEntity)this).Activate(false);
				return _lastModifyingUser;
			} 
			set
			{
				SetValue( v =>  _lastModifyingUser = v, _lastModifyingUser, value,  "LastModifyingUser", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 7)]
		public IfcApplication @LastModifyingApplication 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _lastModifyingApplication;
				((IPersistEntity)this).Activate(false);
				return _lastModifyingApplication;
			} 
			set
			{
				SetValue( v =>  _lastModifyingApplication = v, _lastModifyingApplication, value,  "LastModifyingApplication", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 8)]
		public IfcTimeStamp @CreationDate 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _creationDate;
				((IPersistEntity)this).Activate(false);
				return _creationDate;
			} 
			set
			{
				SetValue( v =>  _creationDate = v, _creationDate, value,  "CreationDate", 8);
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
					_owningUser = (IfcPersonAndOrganization)(value.EntityVal);
					return;
				case 1: 
					_owningApplication = (IfcApplication)(value.EntityVal);
					return;
				case 2: 
                    _state = (IfcStateEnum) System.Enum.Parse(typeof (IfcStateEnum), value.EnumVal, true);
					return;
				case 3: 
                    _changeAction = (IfcChangeActionEnum) System.Enum.Parse(typeof (IfcChangeActionEnum), value.EnumVal, true);
					return;
				case 4: 
					_lastModifiedDate = value.IntegerVal;
					return;
				case 5: 
					_lastModifyingUser = (IfcPersonAndOrganization)(value.EntityVal);
					return;
				case 6: 
					_lastModifyingApplication = (IfcApplication)(value.EntityVal);
					return;
				case 7: 
					_creationDate = value.IntegerVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcOwnerHistory other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcOwnerHistory
            var root = (@IfcOwnerHistory)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcOwnerHistory left, @IfcOwnerHistory right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (ReferenceEquals(left.Model, right.Model));

        }

        public static bool operator !=(@IfcOwnerHistory left, @IfcOwnerHistory right)
        {
            return !(left == right);
        }

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@OwningUser != null)
					yield return @OwningUser;
				if (@OwningApplication != null)
					yield return @OwningApplication;
				if (@LastModifyingUser != null)
					yield return @LastModifyingUser;
				if (@LastModifyingApplication != null)
					yield return @LastModifyingApplication;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}