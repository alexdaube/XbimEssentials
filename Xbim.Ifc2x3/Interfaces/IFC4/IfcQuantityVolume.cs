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
namespace Xbim.Ifc2x3.QuantityResource
{
	public partial class @IfcQuantityVolume : IIfcQuantityVolume
	{
		Ifc4.MeasureResource.IfcVolumeMeasure IIfcQuantityVolume.VolumeValue 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcVolumeMeasure(VolumeValue);
			} 
			set
			{
				VolumeValue = new MeasureResource.IfcVolumeMeasure(value);
				
			}
		}

		private  Ifc4.MeasureResource.IfcLabel? _formula;

		Ifc4.MeasureResource.IfcLabel? IIfcQuantityVolume.Formula 
		{ 
			get
			{
				return _formula;
			} 
			set
			{
				SetValue(v => _formula = v, _formula, value, "Formula", byte.MaxValue);
				
			}
		}
	//## Custom code
	//##
	}
}