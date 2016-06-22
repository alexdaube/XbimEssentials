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
    /// Readonly interface for IfcFixedReferenceSweptAreaSolid
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcFixedReferenceSweptAreaSolid : IIfcSweptAreaSolid
	{
		IIfcCurve @Directrix { get;  set; }
		IfcParameterValue? @StartParam { get;  set; }
		IfcParameterValue? @EndParam { get;  set; }
		IIfcDirection @FixedReference { get;  set; }
	
	}
}

namespace Xbim.Ifc4.GeometricModelResource
{
	[ExpressType("IfcFixedReferenceSweptAreaSolid", 1180)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcFixedReferenceSweptAreaSolid : IfcSweptAreaSolid, IInstantiableEntity, IIfcFixedReferenceSweptAreaSolid, IContainsEntityReferences, IEquatable<@IfcFixedReferenceSweptAreaSolid>
	{
		#region IIfcFixedReferenceSweptAreaSolid explicit implementation
		IIfcCurve IIfcFixedReferenceSweptAreaSolid.Directrix { 
 
 
			get { return @Directrix; } 
			set { Directrix = value as IfcCurve;}
		}	
		IfcParameterValue? IIfcFixedReferenceSweptAreaSolid.StartParam { 
 
			get { return @StartParam; } 
			set { StartParam = value;}
		}	
		IfcParameterValue? IIfcFixedReferenceSweptAreaSolid.EndParam { 
 
			get { return @EndParam; } 
			set { EndParam = value;}
		}	
		IIfcDirection IIfcFixedReferenceSweptAreaSolid.FixedReference { 
 
 
			get { return @FixedReference; } 
			set { FixedReference = value as IfcDirection;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcFixedReferenceSweptAreaSolid(IModel model) : base(model) 		{ 
		}

		#region Explicit attribute fields
		private IfcCurve _directrix;
		private IfcParameterValue? _startParam;
		private IfcParameterValue? _endParam;
		private IfcDirection _fixedReference;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 5)]
		public IfcCurve @Directrix 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _directrix;
				((IPersistEntity)this).Activate(false);
				return _directrix;
			} 
			set
			{
				SetValue( v =>  _directrix = v, _directrix, value,  "Directrix", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 6)]
		public IfcParameterValue? @StartParam 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _startParam;
				((IPersistEntity)this).Activate(false);
				return _startParam;
			} 
			set
			{
				SetValue( v =>  _startParam = v, _startParam, value,  "StartParam", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 7)]
		public IfcParameterValue? @EndParam 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _endParam;
				((IPersistEntity)this).Activate(false);
				return _endParam;
			} 
			set
			{
				SetValue( v =>  _endParam = v, _endParam, value,  "EndParam", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 8)]
		public IfcDirection @FixedReference 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _fixedReference;
				((IPersistEntity)this).Activate(false);
				return _fixedReference;
			} 
			set
			{
				SetValue( v =>  _fixedReference = v, _fixedReference, value,  "FixedReference", 6);
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
					_directrix = (IfcCurve)(value.EntityVal);
					return;
				case 3: 
					_startParam = value.RealVal;
					return;
				case 4: 
					_endParam = value.RealVal;
					return;
				case 5: 
					_fixedReference = (IfcDirection)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcFixedReferenceSweptAreaSolid other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcFixedReferenceSweptAreaSolid
            var root = (@IfcFixedReferenceSweptAreaSolid)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcFixedReferenceSweptAreaSolid left, @IfcFixedReferenceSweptAreaSolid right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (ReferenceEquals(left.Model, right.Model));

        }

        public static bool operator !=(@IfcFixedReferenceSweptAreaSolid left, @IfcFixedReferenceSweptAreaSolid right)
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
				if (@Directrix != null)
					yield return @Directrix;
				if (@FixedReference != null)
					yield return @FixedReference;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}