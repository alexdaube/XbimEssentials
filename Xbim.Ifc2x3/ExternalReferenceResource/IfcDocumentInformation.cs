// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.ActorResource;
using Xbim.Ifc2x3.DateTimeResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.ExternalReferenceResource;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcDocumentInformation
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcDocumentInformation : IPersistEntity, IfcDocumentSelect
	{
		IfcIdentifier @DocumentId { get; }
		IfcLabel @Name { get; }
		IfcText? @Description { get; }
		IEnumerable<IIfcDocumentReference> @DocumentReferences { get; }
		IfcText? @Purpose { get; }
		IfcText? @IntendedUse { get; }
		IfcText? @Scope { get; }
		IfcLabel? @Revision { get; }
		IIfcActorSelect @DocumentOwner { get; }
		IEnumerable<IIfcActorSelect> @Editors { get; }
		IIfcDateAndTime @CreationTime { get; }
		IIfcDateAndTime @LastRevisionTime { get; }
		IIfcDocumentElectronicFormat @ElectronicFormat { get; }
		IIfcCalendarDate @ValidFrom { get; }
		IIfcCalendarDate @ValidUntil { get; }
		IfcDocumentConfidentialityEnum? @Confidentiality { get; }
		IfcDocumentStatusEnum? @Status { get; }
		IEnumerable<IIfcDocumentInformationRelationship> @IsPointedTo {  get; }
		IEnumerable<IIfcDocumentInformationRelationship> @IsPointer {  get; }
	
	}
}

namespace Xbim.Ifc2x3.ExternalReferenceResource
{
	[IndexedClass]
	[ExpressType("IfcDocumentInformation", 208)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcDocumentInformation : INotifyPropertyChanged, IInstantiableEntity, IIfcDocumentInformation, IEqualityComparer<@IfcDocumentInformation>, IEquatable<@IfcDocumentInformation>
	{
		#region IIfcDocumentInformation explicit implementation
		IfcIdentifier IIfcDocumentInformation.DocumentId { get { return @DocumentId; } }	
		IfcLabel IIfcDocumentInformation.Name { get { return @Name; } }	
		IfcText? IIfcDocumentInformation.Description { get { return @Description; } }	
		IEnumerable<IIfcDocumentReference> IIfcDocumentInformation.DocumentReferences { get { return @DocumentReferences; } }	
		IfcText? IIfcDocumentInformation.Purpose { get { return @Purpose; } }	
		IfcText? IIfcDocumentInformation.IntendedUse { get { return @IntendedUse; } }	
		IfcText? IIfcDocumentInformation.Scope { get { return @Scope; } }	
		IfcLabel? IIfcDocumentInformation.Revision { get { return @Revision; } }	
		IIfcActorSelect IIfcDocumentInformation.DocumentOwner { get { return @DocumentOwner; } }	
		IEnumerable<IIfcActorSelect> IIfcDocumentInformation.Editors { get { return @Editors; } }	
		IIfcDateAndTime IIfcDocumentInformation.CreationTime { get { return @CreationTime; } }	
		IIfcDateAndTime IIfcDocumentInformation.LastRevisionTime { get { return @LastRevisionTime; } }	
		IIfcDocumentElectronicFormat IIfcDocumentInformation.ElectronicFormat { get { return @ElectronicFormat; } }	
		IIfcCalendarDate IIfcDocumentInformation.ValidFrom { get { return @ValidFrom; } }	
		IIfcCalendarDate IIfcDocumentInformation.ValidUntil { get { return @ValidUntil; } }	
		IfcDocumentConfidentialityEnum? IIfcDocumentInformation.Confidentiality { get { return @Confidentiality; } }	
		IfcDocumentStatusEnum? IIfcDocumentInformation.Status { get { return @Status; } }	
		 
		IEnumerable<IIfcDocumentInformationRelationship> IIfcDocumentInformation.IsPointedTo {  get { return @IsPointedTo; } }
		IEnumerable<IIfcDocumentInformationRelationship> IIfcDocumentInformation.IsPointer {  get { return @IsPointer; } }
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
		internal IfcDocumentInformation(IModel model) 		{ 
			Model = model; 
			_documentReferences = new OptionalItemSet<IfcDocumentReference>( this, 0 );
			_editors = new OptionalItemSet<IfcActorSelect>( this, 0 );
		}

		#region Explicit attribute fields
		private IfcIdentifier _documentId;
		private IfcLabel _name;
		private IfcText? _description;
		private OptionalItemSet<IfcDocumentReference> _documentReferences;
		private IfcText? _purpose;
		private IfcText? _intendedUse;
		private IfcText? _scope;
		private IfcLabel? _revision;
		private IfcActorSelect _documentOwner;
		private OptionalItemSet<IfcActorSelect> _editors;
		private IfcDateAndTime _creationTime;
		private IfcDateAndTime _lastRevisionTime;
		private IfcDocumentElectronicFormat _electronicFormat;
		private IfcCalendarDate _validFrom;
		private IfcCalendarDate _validUntil;
		private IfcDocumentConfidentialityEnum? _confidentiality;
		private IfcDocumentStatusEnum? _status;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 1)]
		public IfcIdentifier @DocumentId 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _documentId;
				((IPersistEntity)this).Activate(false);
				return _documentId;
			} 
			set
			{
				SetValue( v =>  _documentId = v, _documentId, value,  "DocumentId");
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 2)]
		public IfcLabel @Name 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _name;
				((IPersistEntity)this).Activate(false);
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name");
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 3)]
		public IfcText? @Description 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _description;
				((IPersistEntity)this).Activate(false);
				return _description;
			} 
			set
			{
				SetValue( v =>  _description = v, _description, value,  "Description");
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1, 4)]
		public OptionalItemSet<IfcDocumentReference> @DocumentReferences 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _documentReferences;
				((IPersistEntity)this).Activate(false);
				return _documentReferences;
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 5)]
		public IfcText? @Purpose 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _purpose;
				((IPersistEntity)this).Activate(false);
				return _purpose;
			} 
			set
			{
				SetValue( v =>  _purpose = v, _purpose, value,  "Purpose");
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 6)]
		public IfcText? @IntendedUse 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _intendedUse;
				((IPersistEntity)this).Activate(false);
				return _intendedUse;
			} 
			set
			{
				SetValue( v =>  _intendedUse = v, _intendedUse, value,  "IntendedUse");
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 7)]
		public IfcText? @Scope 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _scope;
				((IPersistEntity)this).Activate(false);
				return _scope;
			} 
			set
			{
				SetValue( v =>  _scope = v, _scope, value,  "Scope");
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 8)]
		public IfcLabel? @Revision 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _revision;
				((IPersistEntity)this).Activate(false);
				return _revision;
			} 
			set
			{
				SetValue( v =>  _revision = v, _revision, value,  "Revision");
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 9)]
		public IfcActorSelect @DocumentOwner 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _documentOwner;
				((IPersistEntity)this).Activate(false);
				return _documentOwner;
			} 
			set
			{
				SetValue( v =>  _documentOwner = v, _documentOwner, value,  "DocumentOwner");
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1, 10)]
		public OptionalItemSet<IfcActorSelect> @Editors 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _editors;
				((IPersistEntity)this).Activate(false);
				return _editors;
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 11)]
		public IfcDateAndTime @CreationTime 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _creationTime;
				((IPersistEntity)this).Activate(false);
				return _creationTime;
			} 
			set
			{
				SetValue( v =>  _creationTime = v, _creationTime, value,  "CreationTime");
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 12)]
		public IfcDateAndTime @LastRevisionTime 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _lastRevisionTime;
				((IPersistEntity)this).Activate(false);
				return _lastRevisionTime;
			} 
			set
			{
				SetValue( v =>  _lastRevisionTime = v, _lastRevisionTime, value,  "LastRevisionTime");
			} 
		}	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 13)]
		public IfcDocumentElectronicFormat @ElectronicFormat 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _electronicFormat;
				((IPersistEntity)this).Activate(false);
				return _electronicFormat;
			} 
			set
			{
				SetValue( v =>  _electronicFormat = v, _electronicFormat, value,  "ElectronicFormat");
			} 
		}	
		[EntityAttribute(14, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 14)]
		public IfcCalendarDate @ValidFrom 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _validFrom;
				((IPersistEntity)this).Activate(false);
				return _validFrom;
			} 
			set
			{
				SetValue( v =>  _validFrom = v, _validFrom, value,  "ValidFrom");
			} 
		}	
		[EntityAttribute(15, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 15)]
		public IfcCalendarDate @ValidUntil 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _validUntil;
				((IPersistEntity)this).Activate(false);
				return _validUntil;
			} 
			set
			{
				SetValue( v =>  _validUntil = v, _validUntil, value,  "ValidUntil");
			} 
		}	
		[EntityAttribute(16, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 16)]
		public IfcDocumentConfidentialityEnum? @Confidentiality 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _confidentiality;
				((IPersistEntity)this).Activate(false);
				return _confidentiality;
			} 
			set
			{
				SetValue( v =>  _confidentiality = v, _confidentiality, value,  "Confidentiality");
			} 
		}	
		[EntityAttribute(17, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 17)]
		public IfcDocumentStatusEnum? @Status 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _status;
				((IPersistEntity)this).Activate(false);
				return _status;
			} 
			set
			{
				SetValue( v =>  _status = v, _status, value,  "Status");
			} 
		}	
		#endregion



		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1, 18)]
		public IEnumerable<IfcDocumentInformationRelationship> @IsPointedTo 
		{ 
			get 
			{
				return Model.Instances.Where<IfcDocumentInformationRelationship>(e => e.RelatedDocuments != null &&  e.RelatedDocuments.Contains(this));
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1, 19)]
		public IEnumerable<IfcDocumentInformationRelationship> @IsPointer 
		{ 
			get 
			{
				return Model.Instances.Where<IfcDocumentInformationRelationship>(e => (e.RelatingDocument as IfcDocumentInformation) == this);
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

		protected void SetValue<TProperty>(Action<TProperty> setter, TProperty oldValue, TProperty newValue, string notifyPropertyName)
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
			txn.AddReversibleAction(doAction, undoAction, this, ChangeType.Modified);
		}

		#endregion

		#region IPersist implementation
		public virtual void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_documentId = value.StringVal;
					return;
				case 1: 
					_name = value.StringVal;
					return;
				case 2: 
					_description = value.StringVal;
					return;
				case 3: 
					if (_documentReferences == null) _documentReferences = new OptionalItemSet<IfcDocumentReference>( this );
					_documentReferences.InternalAdd((IfcDocumentReference)value.EntityVal);
					return;
				case 4: 
					_purpose = value.StringVal;
					return;
				case 5: 
					_intendedUse = value.StringVal;
					return;
				case 6: 
					_scope = value.StringVal;
					return;
				case 7: 
					_revision = value.StringVal;
					return;
				case 8: 
					_documentOwner = (IfcActorSelect)(value.EntityVal);
					return;
				case 9: 
					if (_editors == null) _editors = new OptionalItemSet<IfcActorSelect>( this );
					_editors.InternalAdd((IfcActorSelect)value.EntityVal);
					return;
				case 10: 
					_creationTime = (IfcDateAndTime)(value.EntityVal);
					return;
				case 11: 
					_lastRevisionTime = (IfcDateAndTime)(value.EntityVal);
					return;
				case 12: 
					_electronicFormat = (IfcDocumentElectronicFormat)(value.EntityVal);
					return;
				case 13: 
					_validFrom = (IfcCalendarDate)(value.EntityVal);
					return;
				case 14: 
					_validUntil = (IfcCalendarDate)(value.EntityVal);
					return;
				case 15: 
                    _confidentiality = (IfcDocumentConfidentialityEnum) System.Enum.Parse(typeof (IfcDocumentConfidentialityEnum), value.EnumVal, true);
					return;
				case 16: 
                    _status = (IfcDocumentStatusEnum) System.Enum.Parse(typeof (IfcDocumentStatusEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public virtual string WhereRule() 
		{
			return "";
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcDocumentInformation other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcDocumentInformation
            var root = (@IfcDocumentInformation)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcDocumentInformation left, @IfcDocumentInformation right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcDocumentInformation left, @IfcDocumentInformation right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcDocumentInformation x, @IfcDocumentInformation y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcDocumentInformation obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}