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
using Xbim.Ifc4.DateTimeResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcIrregularTimeSeries
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcIrregularTimeSeries : IIfcTimeSeries
	{
		IItemSet<IIfcIrregularTimeSeriesValue> @Values { get; }
	
	}
}

namespace Xbim.Ifc4.DateTimeResource
{
	[ExpressType("IfcIrregularTimeSeries", 570)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcIrregularTimeSeries : IfcTimeSeries, IInstantiableEntity, IIfcIrregularTimeSeries, IContainsEntityReferences, IEquatable<@IfcIrregularTimeSeries>
	{
		#region IIfcIrregularTimeSeries explicit implementation
		IItemSet<IIfcIrregularTimeSeriesValue> IIfcIrregularTimeSeries.Values { 
			get { return new Common.Collections.ProxyItemSet<IfcIrregularTimeSeriesValue, IIfcIrregularTimeSeriesValue>( @Values); } 
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcIrregularTimeSeries(IModel model) : base(model) 		{ 
			_values = new ItemSet<IfcIrregularTimeSeriesValue>( this, 0,  9);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IfcIrregularTimeSeriesValue> _values;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 1, -1, 10)]
		public IItemSet<IfcIrregularTimeSeriesValue> @Values 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _values;
				((IPersistEntity)this).Activate(false);
				return _values;
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 8: 
					_values.InternalAdd((IfcIrregularTimeSeriesValue)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcIrregularTimeSeries other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcIrregularTimeSeries
            var root = (@IfcIrregularTimeSeries)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcIrregularTimeSeries left, @IfcIrregularTimeSeries right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (ReferenceEquals(left.Model, right.Model));

        }

        public static bool operator !=(@IfcIrregularTimeSeries left, @IfcIrregularTimeSeries right)
        {
            return !(left == right);
        }

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Unit != null)
					yield return @Unit;
				foreach(var entity in @Values)
					yield return entity;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}