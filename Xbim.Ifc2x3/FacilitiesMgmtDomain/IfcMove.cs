// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.ProcessExtension;
using Xbim.Ifc2x3.ProductExtension;
using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.FacilitiesMgmtDomain;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcMove
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcMove : IIfcTask
	{
		IIfcSpatialStructureElement @MoveFrom { get; }
		IIfcSpatialStructureElement @MoveTo { get; }
		IEnumerable<IfcText> @PunchList { get; }
	
	}
}

namespace Xbim.Ifc2x3.FacilitiesMgmtDomain
{
	[ExpressType("IfcMove", 74)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMove : IfcTask, IInstantiableEntity, IIfcMove, IEqualityComparer<@IfcMove>, IEquatable<@IfcMove>
	{
		#region IIfcMove explicit implementation
		IIfcSpatialStructureElement IIfcMove.MoveFrom { get { return @MoveFrom; } }	
		IIfcSpatialStructureElement IIfcMove.MoveTo { get { return @MoveTo; } }	
		IEnumerable<IfcText> IIfcMove.PunchList { get { return @PunchList; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMove(IModel model) : base(model) 		{ 
			Model = model; 
			_punchList = new OptionalItemSet<IfcText>( this, 0 );
		}

		#region Explicit attribute fields
		private IfcSpatialStructureElement _moveFrom;
		private IfcSpatialStructureElement _moveTo;
		private OptionalItemSet<IfcText> _punchList;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(11, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 19)]
		public IfcSpatialStructureElement @MoveFrom 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _moveFrom;
				((IPersistEntity)this).Activate(false);
				return _moveFrom;
			} 
			set
			{
				SetValue( v =>  _moveFrom = v, _moveFrom, value,  "MoveFrom");
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 20)]
		public IfcSpatialStructureElement @MoveTo 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _moveTo;
				((IPersistEntity)this).Activate(false);
				return _moveTo;
			} 
			set
			{
				SetValue( v =>  _moveTo = v, _moveTo, value,  "MoveTo");
			} 
		}	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.ListUnique, EntityAttributeType.None, 1, -1, 21)]
		public OptionalItemSet<IfcText> @PunchList 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _punchList;
				((IPersistEntity)this).Activate(false);
				return _punchList;
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
				case 9: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 10: 
					_moveFrom = (IfcSpatialStructureElement)(value.EntityVal);
					return;
				case 11: 
					_moveTo = (IfcSpatialStructureElement)(value.EntityVal);
					return;
				case 12: 
					if (_punchList == null) _punchList = new OptionalItemSet<IfcText>( this );
					_punchList.InternalAdd(value.StringVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : SIZEOF(SELF\IfcProcess.OperatesOn) >= 1;*/
		/*WR2:              )) >= 1;*/
		/*WR3:	WR3 : EXISTS(SELF\IfcRoot.Name);*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcMove other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcMove
            var root = (@IfcMove)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcMove left, @IfcMove right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcMove left, @IfcMove right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcMove x, @IfcMove y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcMove obj)
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