// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.PresentationOrganizationResource
{
	public partial class @IfcPresentationLayerWithStyle : IIfcPresentationLayerWithStyle
	{
		Ifc4.MeasureResource.IfcLogical IIfcPresentationLayerWithStyle.LayerOn 
		{ 
			get
			{
				//## Handle return of LayerOn for which no match was found
			    return new Ifc4.MeasureResource.IfcLogical(LayerOn);
			    //##
			} 
			set
			{
				LayerOn = value;
				
			}
		}
		Ifc4.MeasureResource.IfcLogical IIfcPresentationLayerWithStyle.LayerFrozen 
		{ 
			get
			{
				//## Handle return of LayerFrozen for which no match was found
                return new Ifc4.MeasureResource.IfcLogical(LayerFrozen);
				//##
			} 
			set
			{
				LayerFrozen = value;
				
			}
		}
		Ifc4.MeasureResource.IfcLogical IIfcPresentationLayerWithStyle.LayerBlocked 
		{ 
			get
			{
				//## Handle return of LayerBlocked for which no match was found
                return new Ifc4.MeasureResource.IfcLogical(LayerBlocked);
				//##
			} 
			set
			{
				LayerBlocked = value;
				
			}
		}
		IItemSet<IIfcPresentationStyle> IIfcPresentationLayerWithStyle.LayerStyles 
		{ 
			get
			{
				//## Handle return of LayerStyles for which no match was found
                return new Common.Collections.VolatileProxyItemSet<PresentationAppearanceResource.IfcPresentationStyleSelect, IIfcPresentationStyle>(LayerStyles); 
			    //##
			} 
		}
	//## Custom code
	//##
	}
}