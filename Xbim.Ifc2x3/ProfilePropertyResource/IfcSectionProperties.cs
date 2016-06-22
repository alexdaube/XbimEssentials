// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.ProfileResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.ProfilePropertyResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcSectionProperties
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcSectionProperties : IPersistEntity
	{
		IfcSectionTypeEnum @SectionType { get;  set; }
		IIfcProfileDef @StartProfile { get;  set; }
		IIfcProfileDef @EndProfile { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.ProfilePropertyResource
{
	[ExpressType("IfcSectionProperties", 184)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSectionProperties : INotifyPropertyChanged, IInstantiableEntity, IIfcSectionProperties, IContainsEntityReferences, IEquatable<@IfcSectionProperties>
	{
		#region IIfcSectionProperties explicit implementation
		IfcSectionTypeEnum IIfcSectionProperties.SectionType { 
 
			get { return @SectionType; } 
			set { SectionType = value;}
		}	
		IIfcProfileDef IIfcSectionProperties.StartProfile { 
 
 
			get { return @StartProfile; } 
			set { StartProfile = value as IfcProfileDef;}
		}	
		IIfcProfileDef IIfcSectionProperties.EndProfile { 
 
 
			get { return @EndProfile; } 
			set { EndProfile = value as IfcProfileDef;}
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
		internal IfcSectionProperties(IModel model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcSectionTypeEnum _sectionType;
		private IfcProfileDef _startProfile;
		private IfcProfileDef _endProfile;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 1)]
		public IfcSectionTypeEnum @SectionType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _sectionType;
				((IPersistEntity)this).Activate(false);
				return _sectionType;
			} 
			set
			{
				SetValue( v =>  _sectionType = v, _sectionType, value,  "SectionType", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 2)]
		public IfcProfileDef @StartProfile 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _startProfile;
				((IPersistEntity)this).Activate(false);
				return _startProfile;
			} 
			set
			{
				SetValue( v =>  _startProfile = v, _startProfile, value,  "StartProfile", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 3)]
		public IfcProfileDef @EndProfile 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _endProfile;
				((IPersistEntity)this).Activate(false);
				return _endProfile;
			} 
			set
			{
				SetValue( v =>  _endProfile = v, _endProfile, value,  "EndProfile", 3);
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
                    _sectionType = (IfcSectionTypeEnum) System.Enum.Parse(typeof (IfcSectionTypeEnum), value.EnumVal, true);
					return;
				case 1: 
					_startProfile = (IfcProfileDef)(value.EntityVal);
					return;
				case 2: 
					_endProfile = (IfcProfileDef)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcSectionProperties other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcSectionProperties
            var root = (@IfcSectionProperties)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcSectionProperties left, @IfcSectionProperties right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (ReferenceEquals(left.Model, right.Model));

        }

        public static bool operator !=(@IfcSectionProperties left, @IfcSectionProperties right)
        {
            return !(left == right);
        }

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@StartProfile != null)
					yield return @StartProfile;
				if (@EndProfile != null)
					yield return @EndProfile;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}