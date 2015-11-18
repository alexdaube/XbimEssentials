// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.PresentationDefinitionResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.PresentationAppearanceResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcSurfaceStyleLighting
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcSurfaceStyleLighting : IIfcPresentationItem, IfcSurfaceStyleElementSelect
	{
		IIfcColourRgb @DiffuseTransmissionColour { get; }
		IIfcColourRgb @DiffuseReflectionColour { get; }
		IIfcColourRgb @TransmissionColour { get; }
		IIfcColourRgb @ReflectanceColour { get; }
	
	}
}

namespace Xbim.Ifc4.PresentationAppearanceResource
{
	[ExpressType("IfcSurfaceStyleLighting", 1068)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSurfaceStyleLighting : IfcPresentationItem, IInstantiableEntity, IIfcSurfaceStyleLighting, IEqualityComparer<@IfcSurfaceStyleLighting>, IEquatable<@IfcSurfaceStyleLighting>
	{
		#region IIfcSurfaceStyleLighting explicit implementation
		IIfcColourRgb IIfcSurfaceStyleLighting.DiffuseTransmissionColour { get { return @DiffuseTransmissionColour; } }	
		IIfcColourRgb IIfcSurfaceStyleLighting.DiffuseReflectionColour { get { return @DiffuseReflectionColour; } }	
		IIfcColourRgb IIfcSurfaceStyleLighting.TransmissionColour { get { return @TransmissionColour; } }	
		IIfcColourRgb IIfcSurfaceStyleLighting.ReflectanceColour { get { return @ReflectanceColour; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSurfaceStyleLighting(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcColourRgb _diffuseTransmissionColour;
		private IfcColourRgb _diffuseReflectionColour;
		private IfcColourRgb _transmissionColour;
		private IfcColourRgb _reflectanceColour;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 1)]
		public IfcColourRgb @DiffuseTransmissionColour 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _diffuseTransmissionColour;
				((IPersistEntity)this).Activate(false);
				return _diffuseTransmissionColour;
			} 
			set
			{
				SetValue( v =>  _diffuseTransmissionColour = v, _diffuseTransmissionColour, value,  "DiffuseTransmissionColour");
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 2)]
		public IfcColourRgb @DiffuseReflectionColour 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _diffuseReflectionColour;
				((IPersistEntity)this).Activate(false);
				return _diffuseReflectionColour;
			} 
			set
			{
				SetValue( v =>  _diffuseReflectionColour = v, _diffuseReflectionColour, value,  "DiffuseReflectionColour");
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 3)]
		public IfcColourRgb @TransmissionColour 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _transmissionColour;
				((IPersistEntity)this).Activate(false);
				return _transmissionColour;
			} 
			set
			{
				SetValue( v =>  _transmissionColour = v, _transmissionColour, value,  "TransmissionColour");
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 4)]
		public IfcColourRgb @ReflectanceColour 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _reflectanceColour;
				((IPersistEntity)this).Activate(false);
				return _reflectanceColour;
			} 
			set
			{
				SetValue( v =>  _reflectanceColour = v, _reflectanceColour, value,  "ReflectanceColour");
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_diffuseTransmissionColour = (IfcColourRgb)(value.EntityVal);
					return;
				case 1: 
					_diffuseReflectionColour = (IfcColourRgb)(value.EntityVal);
					return;
				case 2: 
					_transmissionColour = (IfcColourRgb)(value.EntityVal);
					return;
				case 3: 
					_reflectanceColour = (IfcColourRgb)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
			return "";
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcSurfaceStyleLighting other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcSurfaceStyleLighting
            var root = (@IfcSurfaceStyleLighting)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcSurfaceStyleLighting left, @IfcSurfaceStyleLighting right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcSurfaceStyleLighting left, @IfcSurfaceStyleLighting right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcSurfaceStyleLighting x, @IfcSurfaceStyleLighting y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcSurfaceStyleLighting obj)
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