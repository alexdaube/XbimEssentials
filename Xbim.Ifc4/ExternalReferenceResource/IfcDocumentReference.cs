// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
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
    /// Readonly interface for IfcDocumentReference
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcDocumentReference : IIfcExternalReference, IfcDocumentSelect
	{
		IfcText? @Description { get; }
		IIfcDocumentInformation @ReferencedDocument { get; }
		IEnumerable<IIfcRelAssociatesDocument> @DocumentRefForObjects {  get; }
	
	}
}

namespace Xbim.Ifc4.ExternalReferenceResource
{
	[IndexedClass]
	[ExpressType("IfcDocumentReference", 587)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcDocumentReference : IfcExternalReference, IInstantiableEntity, IIfcDocumentReference, IEqualityComparer<@IfcDocumentReference>, IEquatable<@IfcDocumentReference>
	{
		#region IIfcDocumentReference explicit implementation
		IfcText? IIfcDocumentReference.Description { get { return @Description; } }	
		IIfcDocumentInformation IIfcDocumentReference.ReferencedDocument { get { return @ReferencedDocument; } }	
		 
		IEnumerable<IIfcRelAssociatesDocument> IIfcDocumentReference.DocumentRefForObjects {  get { return @DocumentRefForObjects; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcDocumentReference(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcText? _description;
		private IfcDocumentInformation _referencedDocument;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 5)]
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
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 6)]
		public IfcDocumentInformation @ReferencedDocument 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _referencedDocument;
				((IPersistEntity)this).Activate(false);
				return _referencedDocument;
			} 
			set
			{
				SetValue( v =>  _referencedDocument = v, _referencedDocument, value,  "ReferencedDocument");
			} 
		}	
		#endregion



		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1, 7)]
		public IEnumerable<IfcRelAssociatesDocument> @DocumentRefForObjects 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelAssociatesDocument>(e => (e.RelatingDocument as IfcDocumentReference) == this);
			} 
		}
		#endregion


		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 3: 
					_description = value.StringVal;
					return;
				case 4: 
					_referencedDocument = (IfcDocumentInformation)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : EXISTS(Name) XOR EXISTS(ReferencedDocument);*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcDocumentReference other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcDocumentReference
            var root = (@IfcDocumentReference)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcDocumentReference left, @IfcDocumentReference right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcDocumentReference left, @IfcDocumentReference right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcDocumentReference x, @IfcDocumentReference y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcDocumentReference obj)
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