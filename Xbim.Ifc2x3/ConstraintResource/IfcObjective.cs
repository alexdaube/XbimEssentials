// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.ConstraintResource;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcObjective
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcObjective : IIfcConstraint
	{
		IIfcMetric @BenchmarkValues { get; }
		IIfcMetric @ResultValues { get; }
		IfcObjectiveEnum @ObjectiveQualifier { get; }
		IfcLabel? @UserDefinedQualifier { get; }
	
	}
}

namespace Xbim.Ifc2x3.ConstraintResource
{
	[ExpressType("IfcObjective", 518)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcObjective : IfcConstraint, IInstantiableEntity, IIfcObjective, IEqualityComparer<@IfcObjective>, IEquatable<@IfcObjective>
	{
		#region IIfcObjective explicit implementation
		IIfcMetric IIfcObjective.BenchmarkValues { get { return @BenchmarkValues; } }	
		IIfcMetric IIfcObjective.ResultValues { get { return @ResultValues; } }	
		IfcObjectiveEnum IIfcObjective.ObjectiveQualifier { get { return @ObjectiveQualifier; } }	
		IfcLabel? IIfcObjective.UserDefinedQualifier { get { return @UserDefinedQualifier; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcObjective(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcMetric _benchmarkValues;
		private IfcMetric _resultValues;
		private IfcObjectiveEnum _objectiveQualifier;
		private IfcLabel? _userDefinedQualifier;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 14)]
		public IfcMetric @BenchmarkValues 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _benchmarkValues;
				((IPersistEntity)this).Activate(false);
				return _benchmarkValues;
			} 
			set
			{
				SetValue( v =>  _benchmarkValues = v, _benchmarkValues, value,  "BenchmarkValues");
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 15)]
		public IfcMetric @ResultValues 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _resultValues;
				((IPersistEntity)this).Activate(false);
				return _resultValues;
			} 
			set
			{
				SetValue( v =>  _resultValues = v, _resultValues, value,  "ResultValues");
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 16)]
		public IfcObjectiveEnum @ObjectiveQualifier 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _objectiveQualifier;
				((IPersistEntity)this).Activate(false);
				return _objectiveQualifier;
			} 
			set
			{
				SetValue( v =>  _objectiveQualifier = v, _objectiveQualifier, value,  "ObjectiveQualifier");
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 17)]
		public IfcLabel? @UserDefinedQualifier 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _userDefinedQualifier;
				((IPersistEntity)this).Activate(false);
				return _userDefinedQualifier;
			} 
			set
			{
				SetValue( v =>  _userDefinedQualifier = v, _userDefinedQualifier, value,  "UserDefinedQualifier");
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 7: 
					_benchmarkValues = (IfcMetric)(value.EntityVal);
					return;
				case 8: 
					_resultValues = (IfcMetric)(value.EntityVal);
					return;
				case 9: 
                    _objectiveQualifier = (IfcObjectiveEnum) System.Enum.Parse(typeof (IfcObjectiveEnum), value.EnumVal, true);
					return;
				case 10: 
					_userDefinedQualifier = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR21:             ((ObjectiveQualifier = IfcObjectiveEnum.USERDEFINED) AND EXISTS(SELF\IfcObjective.UserDefinedQualifier));*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcObjective other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcObjective
            var root = (@IfcObjective)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcObjective left, @IfcObjective right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcObjective left, @IfcObjective right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcObjective x, @IfcObjective y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcObjective obj)
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