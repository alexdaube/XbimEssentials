// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.ActorResource;
using Xbim.Ifc4.DateTimeResource;
using Xbim.Ifc4.Kernel;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.ExternalReferenceResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcLibraryInformation
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcLibraryInformation : IIfcExternalInformation, IfcLibrarySelect
	{
		IfcLabel @Name { get; }
		IfcLabel? @Version { get; }
		IIfcActorSelect @Publisher { get; }
		IfcDateTime? @VersionDate { get; }
		IfcURIReference? @Location { get; }
		IfcText? @Description { get; }
		IEnumerable<IIfcRelAssociatesLibrary> @LibraryInfoForObjects {  get; }
		IEnumerable<IIfcLibraryReference> @HasLibraryReferences {  get; }
	
	}
}

namespace Xbim.Ifc4.ExternalReferenceResource
{
	[IndexedClass]
	[ExpressType("IfcLibraryInformation", 731)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcLibraryInformation : IfcExternalInformation, IInstantiableEntity, IIfcLibraryInformation, IEqualityComparer<@IfcLibraryInformation>, IEquatable<@IfcLibraryInformation>
	{
		#region IIfcLibraryInformation explicit implementation
		IfcLabel IIfcLibraryInformation.Name { get { return @Name; } }	
		IfcLabel? IIfcLibraryInformation.Version { get { return @Version; } }	
		IIfcActorSelect IIfcLibraryInformation.Publisher { get { return @Publisher; } }	
		IfcDateTime? IIfcLibraryInformation.VersionDate { get { return @VersionDate; } }	
		IfcURIReference? IIfcLibraryInformation.Location { get { return @Location; } }	
		IfcText? IIfcLibraryInformation.Description { get { return @Description; } }	
		 
		IEnumerable<IIfcRelAssociatesLibrary> IIfcLibraryInformation.LibraryInfoForObjects {  get { return @LibraryInfoForObjects; } }
		IEnumerable<IIfcLibraryReference> IIfcLibraryInformation.HasLibraryReferences {  get { return @HasLibraryReferences; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcLibraryInformation(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLabel _name;
		private IfcLabel? _version;
		private IfcActorSelect _publisher;
		private IfcDateTime? _versionDate;
		private IfcURIReference? _location;
		private IfcText? _description;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 1)]
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
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 2)]
		public IfcLabel? @Version 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _version;
				((IPersistEntity)this).Activate(false);
				return _version;
			} 
			set
			{
				SetValue( v =>  _version = v, _version, value,  "Version");
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 3)]
		public IfcActorSelect @Publisher 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _publisher;
				((IPersistEntity)this).Activate(false);
				return _publisher;
			} 
			set
			{
				SetValue( v =>  _publisher = v, _publisher, value,  "Publisher");
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 4)]
		public IfcDateTime? @VersionDate 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _versionDate;
				((IPersistEntity)this).Activate(false);
				return _versionDate;
			} 
			set
			{
				SetValue( v =>  _versionDate = v, _versionDate, value,  "VersionDate");
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 5)]
		public IfcURIReference? @Location 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _location;
				((IPersistEntity)this).Activate(false);
				return _location;
			} 
			set
			{
				SetValue( v =>  _location = v, _location, value,  "Location");
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 6)]
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
		#endregion



		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1, 7)]
		public IEnumerable<IfcRelAssociatesLibrary> @LibraryInfoForObjects 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelAssociatesLibrary>(e => (e.RelatingLibrary as IfcLibraryInformation) == this);
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1, 8)]
		public IEnumerable<IfcLibraryReference> @HasLibraryReferences 
		{ 
			get 
			{
				return Model.Instances.Where<IfcLibraryReference>(e => (e.ReferencedLibrary as IfcLibraryInformation) == this);
			} 
		}
		#endregion


		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_name = value.StringVal;
					return;
				case 1: 
					_version = value.StringVal;
					return;
				case 2: 
					_publisher = (IfcActorSelect)(value.EntityVal);
					return;
				case 3: 
					_versionDate = value.StringVal;
					return;
				case 4: 
					_location = value.StringVal;
					return;
				case 5: 
					_description = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
			return "";
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcLibraryInformation other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcLibraryInformation
            var root = (@IfcLibraryInformation)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcLibraryInformation left, @IfcLibraryInformation right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcLibraryInformation left, @IfcLibraryInformation right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcLibraryInformation x, @IfcLibraryInformation y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcLibraryInformation obj)
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