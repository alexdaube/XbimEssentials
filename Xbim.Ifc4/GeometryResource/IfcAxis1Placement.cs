// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.GeometryResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcAxis1Placement
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcAxis1Placement : IIfcPlacement
	{
		IIfcDirection @Axis { get; }
		Common.Geometry.XbimVector3D @Z  { get ; }
	
	}
}

namespace Xbim.Ifc4.GeometryResource
{
	[ExpressType("IfcAxis1Placement", 427)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcAxis1Placement : IfcPlacement, IInstantiableEntity, IIfcAxis1Placement, IEqualityComparer<@IfcAxis1Placement>, IEquatable<@IfcAxis1Placement>
	{
		#region IIfcAxis1Placement explicit implementation
		IIfcDirection IIfcAxis1Placement.Axis { get { return @Axis; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcAxis1Placement(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcDirection _axis;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 4)]
		public IfcDirection @Axis 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _axis;
				((IPersistEntity)this).Activate(false);
				return _axis;
			} 
			set
			{
				SetValue( v =>  _axis = v, _axis, value,  "Axis");
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 0)]
		public Common.Geometry.XbimVector3D @Z 
		{
			get 
			{
				//## Getter for Z
                return _axis != null ? _axis.Normalise() : new Common.Geometry.XbimVector3D(0, 0, 1);
				//##
			}
		}

		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 1: 
					_axis = (IfcDirection)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*AxisIs3D:	AxisIs3D : (NOT (EXISTS (Axis))) OR (Axis.Dim = 3);*/
		/*LocationIs3D:	LocationIs3D : SELF\IfcPlacement.Location.Dim = 3;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcAxis1Placement other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcAxis1Placement
            var root = (@IfcAxis1Placement)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcAxis1Placement left, @IfcAxis1Placement right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcAxis1Placement left, @IfcAxis1Placement right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcAxis1Placement x, @IfcAxis1Placement y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcAxis1Placement obj)
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