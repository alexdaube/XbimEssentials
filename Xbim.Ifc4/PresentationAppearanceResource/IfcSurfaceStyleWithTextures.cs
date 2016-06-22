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
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcSurfaceStyleWithTextures
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcSurfaceStyleWithTextures : IIfcPresentationItem, IfcSurfaceStyleElementSelect
	{
		IItemSet<IIfcSurfaceTexture> @Textures { get; }
	
	}
}

namespace Xbim.Ifc4.PresentationAppearanceResource
{
	[ExpressType("IfcSurfaceStyleWithTextures", 392)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSurfaceStyleWithTextures : IfcPresentationItem, IInstantiableEntity, IIfcSurfaceStyleWithTextures, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcSurfaceStyleWithTextures>
	{
		#region IIfcSurfaceStyleWithTextures explicit implementation
		IItemSet<IIfcSurfaceTexture> IIfcSurfaceStyleWithTextures.Textures { 
			get { return new Common.Collections.ProxyItemSet<IfcSurfaceTexture, IIfcSurfaceTexture>( @Textures); } 
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSurfaceStyleWithTextures(IModel model) : base(model) 		{ 
			_textures = new ItemSet<IfcSurfaceTexture>( this, 0,  1);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IfcSurfaceTexture> _textures;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 1, -1, 1)]
		public IItemSet<IfcSurfaceTexture> @Textures 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _textures;
				((IPersistEntity)this).Activate(false);
				return _textures;
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_textures.InternalAdd((IfcSurfaceTexture)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcSurfaceStyleWithTextures other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcSurfaceStyleWithTextures
            var root = (@IfcSurfaceStyleWithTextures)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcSurfaceStyleWithTextures left, @IfcSurfaceStyleWithTextures right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (ReferenceEquals(left.Model, right.Model));

        }

        public static bool operator !=(@IfcSurfaceStyleWithTextures left, @IfcSurfaceStyleWithTextures right)
        {
            return !(left == right);
        }

        public static bool operator ==(@IfcSurfaceStyleWithTextures left, IfcSurfaceStyleElementSelect right)
		{
			return left == right as @IfcSurfaceStyleWithTextures;
		}

		public static bool operator !=(@IfcSurfaceStyleWithTextures left, IfcSurfaceStyleElementSelect right)
		{
			return !(left == right);
		}

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				foreach(var entity in @Textures)
					yield return entity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				foreach(var entity in @Textures)
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