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
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.PresentationAppearanceResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcSurfaceStyle
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcSurfaceStyle : IIfcPresentationStyle, IfcPresentationStyleSelect
	{
		IfcSurfaceSide @Side { get;  set; }
		IItemSet<IIfcSurfaceStyleElementSelect> @Styles { get; }
	
	}
}

namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	[ExpressType("IfcSurfaceStyle", 260)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSurfaceStyle : IfcPresentationStyle, IInstantiableEntity, IIfcSurfaceStyle, IEquatable<@IfcSurfaceStyle>
	{
		#region IIfcSurfaceStyle explicit implementation
		IfcSurfaceSide IIfcSurfaceStyle.Side { 
 
			get { return @Side; } 
			set { Side = value;}
		}	
		IItemSet<IIfcSurfaceStyleElementSelect> IIfcSurfaceStyle.Styles { 
			get { return new Common.Collections.ProxyItemSet<IfcSurfaceStyleElementSelect, IIfcSurfaceStyleElementSelect>( @Styles); } 
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSurfaceStyle(IModel model) : base(model) 		{ 
			_styles = new ItemSet<IfcSurfaceStyleElementSelect>( this, 5,  3);
		}

		#region Explicit attribute fields
		private IfcSurfaceSide _side;
		private readonly ItemSet<IfcSurfaceStyleElementSelect> _styles;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 2)]
		public IfcSurfaceSide @Side 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _side;
				((IPersistEntity)this).Activate(false);
				return _side;
			} 
			set
			{
				SetValue( v =>  _side = v, _side, value,  "Side", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, 5, 3)]
		public IItemSet<IfcSurfaceStyleElementSelect> @Styles 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _styles;
				((IPersistEntity)this).Activate(false);
				return _styles;
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
                    _side = (IfcSurfaceSide) System.Enum.Parse(typeof (IfcSurfaceSide), value.EnumVal, true);
					return;
				case 2: 
					_styles.InternalAdd((IfcSurfaceStyleElementSelect)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcSurfaceStyle other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcSurfaceStyle
            var root = (@IfcSurfaceStyle)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcSurfaceStyle left, @IfcSurfaceStyle right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (ReferenceEquals(left.Model, right.Model));

        }

        public static bool operator !=(@IfcSurfaceStyle left, @IfcSurfaceStyle right)
        {
            return !(left == right);
        }

        public static bool operator ==(@IfcSurfaceStyle left, IfcPresentationStyleSelect right)
		{
			return left == right as @IfcSurfaceStyle;
		}

		public static bool operator !=(@IfcSurfaceStyle left, IfcPresentationStyleSelect right)
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