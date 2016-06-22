// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.MaterialResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcMaterialProfileWithOffsets
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcMaterialProfileWithOffsets : IIfcMaterialProfile
	{
		IItemSet<IfcLengthMeasure> @OffsetValues { get; }
	
	}
}

namespace Xbim.Ifc4.MaterialResource
{
	[ExpressType("IfcMaterialProfileWithOffsets", 1209)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMaterialProfileWithOffsets : IfcMaterialProfile, IInstantiableEntity, IIfcMaterialProfileWithOffsets, IContainsEntityReferences, IEquatable<@IfcMaterialProfileWithOffsets>
	{
		#region IIfcMaterialProfileWithOffsets explicit implementation
		IItemSet<IfcLengthMeasure> IIfcMaterialProfileWithOffsets.OffsetValues { 
			get { return @OffsetValues; } 
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMaterialProfileWithOffsets(IModel model) : base(model) 		{ 
			_offsetValues = new ItemSet<IfcLengthMeasure>( this, 2,  7);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IfcLengthMeasure> _offsetValues;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.Array, EntityAttributeType.None, 1, 2, 11)]
		public IItemSet<IfcLengthMeasure> @OffsetValues 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _offsetValues;
				((IPersistEntity)this).Activate(false);
				return _offsetValues;
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
				case 3: 
				case 4: 
				case 5: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 6: 
					_offsetValues.InternalAdd(value.RealVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcMaterialProfileWithOffsets other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcMaterialProfileWithOffsets
            var root = (@IfcMaterialProfileWithOffsets)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcMaterialProfileWithOffsets left, @IfcMaterialProfileWithOffsets right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (ReferenceEquals(left.Model, right.Model));

        }

        public static bool operator !=(@IfcMaterialProfileWithOffsets left, @IfcMaterialProfileWithOffsets right)
        {
            return !(left == right);
        }

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Material != null)
					yield return @Material;
				if (@Profile != null)
					yield return @Profile;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}