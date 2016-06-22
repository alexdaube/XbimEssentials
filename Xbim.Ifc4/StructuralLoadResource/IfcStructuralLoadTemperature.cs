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
using Xbim.Ifc4.StructuralLoadResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcStructuralLoadTemperature
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcStructuralLoadTemperature : IIfcStructuralLoadStatic
	{
		IfcThermodynamicTemperatureMeasure? @DeltaTConstant { get;  set; }
		IfcThermodynamicTemperatureMeasure? @DeltaTY { get;  set; }
		IfcThermodynamicTemperatureMeasure? @DeltaTZ { get;  set; }
	
	}
}

namespace Xbim.Ifc4.StructuralLoadResource
{
	[ExpressType("IfcStructuralLoadTemperature", 36)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcStructuralLoadTemperature : IfcStructuralLoadStatic, IInstantiableEntity, IIfcStructuralLoadTemperature, IEquatable<@IfcStructuralLoadTemperature>
	{
		#region IIfcStructuralLoadTemperature explicit implementation
		IfcThermodynamicTemperatureMeasure? IIfcStructuralLoadTemperature.DeltaTConstant { 
 
			get { return @DeltaTConstant; } 
			set { DeltaTConstant = value;}
		}	
		IfcThermodynamicTemperatureMeasure? IIfcStructuralLoadTemperature.DeltaTY { 
 
			get { return @DeltaTY; } 
			set { DeltaTY = value;}
		}	
		IfcThermodynamicTemperatureMeasure? IIfcStructuralLoadTemperature.DeltaTZ { 
 
			get { return @DeltaTZ; } 
			set { DeltaTZ = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralLoadTemperature(IModel model) : base(model) 		{ 
		}

		#region Explicit attribute fields
		private IfcThermodynamicTemperatureMeasure? _deltaTConstant;
		private IfcThermodynamicTemperatureMeasure? _deltaTY;
		private IfcThermodynamicTemperatureMeasure? _deltaTZ;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 2)]
		public IfcThermodynamicTemperatureMeasure? @DeltaTConstant 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _deltaTConstant;
				((IPersistEntity)this).Activate(false);
				return _deltaTConstant;
			} 
			set
			{
				SetValue( v =>  _deltaTConstant = v, _deltaTConstant, value,  "DeltaTConstant", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 3)]
		public IfcThermodynamicTemperatureMeasure? @DeltaTY 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _deltaTY;
				((IPersistEntity)this).Activate(false);
				return _deltaTY;
			} 
			set
			{
				SetValue( v =>  _deltaTY = v, _deltaTY, value,  "DeltaTY", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 4)]
		public IfcThermodynamicTemperatureMeasure? @DeltaTZ 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _deltaTZ;
				((IPersistEntity)this).Activate(false);
				return _deltaTZ;
			} 
			set
			{
				SetValue( v =>  _deltaTZ = v, _deltaTZ, value,  "DeltaTZ", 4);
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
					_deltaTConstant = value.RealVal;
					return;
				case 2: 
					_deltaTY = value.RealVal;
					return;
				case 3: 
					_deltaTZ = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcStructuralLoadTemperature other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcStructuralLoadTemperature
            var root = (@IfcStructuralLoadTemperature)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcStructuralLoadTemperature left, @IfcStructuralLoadTemperature right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (ReferenceEquals(left.Model, right.Model));

        }

        public static bool operator !=(@IfcStructuralLoadTemperature left, @IfcStructuralLoadTemperature right)
        {
            return !(left == right);
        }

        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}