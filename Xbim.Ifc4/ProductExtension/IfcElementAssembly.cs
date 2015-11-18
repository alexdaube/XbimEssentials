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
using Xbim.Ifc4.ProductExtension;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcElementAssembly
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcElementAssembly : IIfcElement
	{
		IfcAssemblyPlaceEnum? @AssemblyPlace { get; }
		IfcElementAssemblyTypeEnum? @PredefinedType { get; }
	
	}
}

namespace Xbim.Ifc4.ProductExtension
{
	[ExpressType("IfcElementAssembly", 618)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcElementAssembly : IfcElement, IInstantiableEntity, IIfcElementAssembly, IEqualityComparer<@IfcElementAssembly>, IEquatable<@IfcElementAssembly>
	{
		#region IIfcElementAssembly explicit implementation
		IfcAssemblyPlaceEnum? IIfcElementAssembly.AssemblyPlace { get { return @AssemblyPlace; } }	
		IfcElementAssemblyTypeEnum? IIfcElementAssembly.PredefinedType { get { return @PredefinedType; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcElementAssembly(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcAssemblyPlaceEnum? _assemblyPlace;
		private IfcElementAssemblyTypeEnum? _predefinedType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 33)]
		public IfcAssemblyPlaceEnum? @AssemblyPlace 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _assemblyPlace;
				((IPersistEntity)this).Activate(false);
				return _assemblyPlace;
			} 
			set
			{
				SetValue( v =>  _assemblyPlace = v, _assemblyPlace, value,  "AssemblyPlace");
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 34)]
		public IfcElementAssemblyTypeEnum? @PredefinedType 
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
                    _assemblyPlace = (IfcAssemblyPlaceEnum) System.Enum.Parse(typeof (IfcAssemblyPlaceEnum), value.EnumVal, true);
					return;
				case 9: 
                    _predefinedType = (IfcElementAssemblyTypeEnum) System.Enum.Parse(typeof (IfcElementAssemblyTypeEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*CorrectPredefinedType: ((PredefinedType = IfcElementAssemblyTypeEnum.USERDEFINED) AND EXISTS (SELF\IfcObject.ObjectType));*/
		/*CorrectTypeAssigned:  ('IFC4.IFCELEMENTASSEMBLYTYPE' IN TYPEOF(SELF\IfcObject.IsTypedBy[1].RelatingType));*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcElementAssembly other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcElementAssembly
            var root = (@IfcElementAssembly)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcElementAssembly left, @IfcElementAssembly right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcElementAssembly left, @IfcElementAssembly right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcElementAssembly x, @IfcElementAssembly y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcElementAssembly obj)
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