// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.GeometryResource;
using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.GeometricModelResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcExtrudedAreaSolid
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcExtrudedAreaSolid : IIfcSweptAreaSolid
	{
		IIfcDirection @ExtrudedDirection { get;  set; }
		IfcPositiveLengthMeasure @Depth { get;  set; }
	
	}
}

namespace Xbim.Ifc4.GeometricModelResource
{
	[ExpressType("IfcExtrudedAreaSolid", 238)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcExtrudedAreaSolid : IfcSweptAreaSolid, IInstantiableEntity, IIfcExtrudedAreaSolid, IContainsEntityReferences, IEquatable<@IfcExtrudedAreaSolid>
	{
		#region IIfcExtrudedAreaSolid explicit implementation
		IIfcDirection IIfcExtrudedAreaSolid.ExtrudedDirection { 
 
 
			get { return @ExtrudedDirection; } 
			set { ExtrudedDirection = value as IfcDirection;}
		}	
		IfcPositiveLengthMeasure IIfcExtrudedAreaSolid.Depth { 
 
			get { return @Depth; } 
			set { Depth = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcExtrudedAreaSolid(IModel model) : base(model) 		{ 
		}

		#region Explicit attribute fields
		private IfcDirection _extrudedDirection;
		private IfcPositiveLengthMeasure _depth;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 5)]
		public IfcDirection @ExtrudedDirection 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _extrudedDirection;
				((IPersistEntity)this).Activate(false);
				return _extrudedDirection;
			} 
			set
			{
				SetValue( v =>  _extrudedDirection = v, _extrudedDirection, value,  "ExtrudedDirection", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 6)]
		public IfcPositiveLengthMeasure @Depth 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _depth;
				((IPersistEntity)this).Activate(false);
				return _depth;
			} 
			set
			{
				SetValue( v =>  _depth = v, _depth, value,  "Depth", 4);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 2: 
					_extrudedDirection = (IfcDirection)(value.EntityVal);
					return;
				case 3: 
					_depth = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcExtrudedAreaSolid other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcExtrudedAreaSolid
            var root = (@IfcExtrudedAreaSolid)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcExtrudedAreaSolid left, @IfcExtrudedAreaSolid right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (ReferenceEquals(left.Model, right.Model));

        }

        public static bool operator !=(@IfcExtrudedAreaSolid left, @IfcExtrudedAreaSolid right)
        {
            return !(left == right);
        }

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@SweptArea != null)
					yield return @SweptArea;
				if (@Position != null)
					yield return @Position;
				if (@ExtrudedDirection != null)
					yield return @ExtrudedDirection;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}