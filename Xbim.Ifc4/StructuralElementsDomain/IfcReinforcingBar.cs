// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.ProfileResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.StructuralElementsDomain;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcReinforcingBar
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcReinforcingBar : IIfcReinforcingElement
	{
		IfcPositiveLengthMeasure? @NominalDiameter { get; }
		IfcAreaMeasure? @CrossSectionArea { get; }
		IfcPositiveLengthMeasure? @BarLength { get; }
		IfcReinforcingBarTypeEnum? @PredefinedType { get; }
		IfcReinforcingBarSurfaceEnum? @BarSurface { get; }
	
	}
}

namespace Xbim.Ifc4.StructuralElementsDomain
{
	[ExpressType("IfcReinforcingBar", 903)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcReinforcingBar : IfcReinforcingElement, IInstantiableEntity, IIfcReinforcingBar, IEqualityComparer<@IfcReinforcingBar>, IEquatable<@IfcReinforcingBar>
	{
		#region IIfcReinforcingBar explicit implementation
		IfcPositiveLengthMeasure? IIfcReinforcingBar.NominalDiameter { get { return @NominalDiameter; } }	
		IfcAreaMeasure? IIfcReinforcingBar.CrossSectionArea { get { return @CrossSectionArea; } }	
		IfcPositiveLengthMeasure? IIfcReinforcingBar.BarLength { get { return @BarLength; } }	
		IfcReinforcingBarTypeEnum? IIfcReinforcingBar.PredefinedType { get { return @PredefinedType; } }	
		IfcReinforcingBarSurfaceEnum? IIfcReinforcingBar.BarSurface { get { return @BarSurface; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcReinforcingBar(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure? _nominalDiameter;
		private IfcAreaMeasure? _crossSectionArea;
		private IfcPositiveLengthMeasure? _barLength;
		private IfcReinforcingBarTypeEnum? _predefinedType;
		private IfcReinforcingBarSurfaceEnum? _barSurface;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 34)]
		public IfcPositiveLengthMeasure? @NominalDiameter 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _nominalDiameter;
				((IPersistEntity)this).Activate(false);
				return _nominalDiameter;
			} 
			set
			{
				SetValue( v =>  _nominalDiameter = v, _nominalDiameter, value,  "NominalDiameter");
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 35)]
		public IfcAreaMeasure? @CrossSectionArea 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _crossSectionArea;
				((IPersistEntity)this).Activate(false);
				return _crossSectionArea;
			} 
			set
			{
				SetValue( v =>  _crossSectionArea = v, _crossSectionArea, value,  "CrossSectionArea");
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 36)]
		public IfcPositiveLengthMeasure? @BarLength 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _barLength;
				((IPersistEntity)this).Activate(false);
				return _barLength;
			} 
			set
			{
				SetValue( v =>  _barLength = v, _barLength, value,  "BarLength");
			} 
		}	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 37)]
		public IfcReinforcingBarTypeEnum? @PredefinedType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _predefinedType;
				((IPersistEntity)this).Activate(false);
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType");
			} 
		}	
		[EntityAttribute(14, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 38)]
		public IfcReinforcingBarSurfaceEnum? @BarSurface 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _barSurface;
				((IPersistEntity)this).Activate(false);
				return _barSurface;
			} 
			set
			{
				SetValue( v =>  _barSurface = v, _barSurface, value,  "BarSurface");
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
				case 6: 
				case 7: 
				case 8: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 9: 
					_nominalDiameter = value.RealVal;
					return;
				case 10: 
					_crossSectionArea = value.RealVal;
					return;
				case 11: 
					_barLength = value.RealVal;
					return;
				case 12: 
                    _predefinedType = (IfcReinforcingBarTypeEnum) System.Enum.Parse(typeof (IfcReinforcingBarTypeEnum), value.EnumVal, true);
					return;
				case 13: 
                    _barSurface = (IfcReinforcingBarSurfaceEnum) System.Enum.Parse(typeof (IfcReinforcingBarSurfaceEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*CorrectPredefinedType:((PredefinedType = IfcReinforcingBarTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcObject.ObjectType));*/
		/*CorrectTypeAssigned:('IFC4.IFCREINFORCINGBARTYPE' IN TYPEOF(SELF\IfcObject.IsTypedBy[1].RelatingType));*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcReinforcingBar other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcReinforcingBar
            var root = (@IfcReinforcingBar)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcReinforcingBar left, @IfcReinforcingBar right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcReinforcingBar left, @IfcReinforcingBar right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcReinforcingBar x, @IfcReinforcingBar y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcReinforcingBar obj)
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