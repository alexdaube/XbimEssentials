// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.GeometryResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.ProfileResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcArbitraryClosedProfileDef
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcArbitraryClosedProfileDef : IIfcProfileDef
	{
		IIfcCurve @OuterCurve { get;  set; }
	
	}
}

namespace Xbim.Ifc4.ProfileResource
{
	[ExpressType("IfcArbitraryClosedProfileDef", 115)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcArbitraryClosedProfileDef : IfcProfileDef, IInstantiableEntity, IIfcArbitraryClosedProfileDef, IContainsEntityReferences, IEquatable<@IfcArbitraryClosedProfileDef>
	{
		#region IIfcArbitraryClosedProfileDef explicit implementation
		IIfcCurve IIfcArbitraryClosedProfileDef.OuterCurve { 
 
 
			get { return @OuterCurve; } 
			set { OuterCurve = value as IfcCurve;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcArbitraryClosedProfileDef(IModel model) : base(model) 		{ 
		}

		#region Explicit attribute fields
		private IfcCurve _outerCurve;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 5)]
		public IfcCurve @OuterCurve 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _outerCurve;
				((IPersistEntity)this).Activate(false);
				return _outerCurve;
			} 
			set
			{
				SetValue( v =>  _outerCurve = v, _outerCurve, value,  "OuterCurve", 3);
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
					_outerCurve = (IfcCurve)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcArbitraryClosedProfileDef other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcArbitraryClosedProfileDef
            var root = (@IfcArbitraryClosedProfileDef)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcArbitraryClosedProfileDef left, @IfcArbitraryClosedProfileDef right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (ReferenceEquals(left.Model, right.Model));

        }

        public static bool operator !=(@IfcArbitraryClosedProfileDef left, @IfcArbitraryClosedProfileDef right)
        {
            return !(left == right);
        }

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@OuterCurve != null)
					yield return @OuterCurve;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}