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
namespace Xbim.Ifc2x3.ProcessExtension
{
	public partial class @IfcWorkSchedule : IIfcWorkSchedule
	{

		private  Ifc4.Interfaces.IfcWorkScheduleTypeEnum? _predefinedType;

		Ifc4.Interfaces.IfcWorkScheduleTypeEnum? IIfcWorkSchedule.PredefinedType 
		{ 
			get
			{
				return _predefinedType;
			} 
			set
			{
				SetValue(v => _predefinedType = v, _predefinedType, value, "PredefinedType", byte.MaxValue);
				
			}
		}
	//## Custom code
	//##
	}
}