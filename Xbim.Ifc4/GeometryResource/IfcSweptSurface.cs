// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.ProfileResource;
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
    /// Readonly interface for IfcSweptSurface
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcSweptSurface : IIfcSurface
	{
		IIfcProfileDef @SweptCurve { get; }
		IIfcAxis2Placement3D @Position { get; }
	
	}
}

namespace Xbim.Ifc4.GeometryResource
{
	[ExpressType("IfcSweptSurface", 1077)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcSweptSurface : IfcSurface, IIfcSweptSurface, IEqualityComparer<@IfcSweptSurface>, IEquatable<@IfcSweptSurface>
	{
		#region IIfcSweptSurface explicit implementation
		IIfcProfileDef IIfcSweptSurface.SweptCurve { get { return @SweptCurve; } }	
		IIfcAxis2Placement3D IIfcSweptSurface.Position { get { return @Position; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSweptSurface(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcProfileDef _sweptCurve;
		private IfcAxis2Placement3D _position;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 3)]
		public IfcProfileDef @SweptCurve 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _sweptCurve;
				((IPersistEntity)this).Activate(false);
				return _sweptCurve;
			} 
			set
			{
				SetValue( v =>  _sweptCurve = v, _sweptCurve, value,  "SweptCurve");
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 4)]
		public IfcAxis2Placement3D @Position 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _position;
				((IPersistEntity)this).Activate(false);
				return _position;
			} 
			set
			{
				SetValue( v =>  _position = v, _position, value,  "Position");
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_sweptCurve = (IfcProfileDef)(value.EntityVal);
					return;
				case 1: 
					_position = (IfcAxis2Placement3D)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*SweptCurveType:	SweptCurveType : SweptCurve.ProfileType = IfcProfileTypeEnum.Curve;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcSweptSurface other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcSweptSurface
            var root = (@IfcSweptSurface)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcSweptSurface left, @IfcSweptSurface right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcSweptSurface left, @IfcSweptSurface right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcSweptSurface x, @IfcSweptSurface y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcSweptSurface obj)
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