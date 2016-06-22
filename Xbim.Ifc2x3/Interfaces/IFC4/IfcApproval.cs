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
namespace Xbim.Ifc2x3.ApprovalResource
{
	public partial class @IfcApproval : IIfcApproval
	{
		Ifc4.MeasureResource.IfcIdentifier? IIfcApproval.Identifier 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcIdentifier(Identifier);
			} 
			set
			{
				Identifier = value.HasValue ? 
					new MeasureResource.IfcIdentifier(value.Value) :  
					 default(MeasureResource.IfcIdentifier) ;
				
			}
		}
		Ifc4.MeasureResource.IfcLabel? IIfcApproval.Name 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcLabel(Name);
			} 
			set
			{
				Name = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 default(MeasureResource.IfcLabel) ;
				
			}
		}
		Ifc4.MeasureResource.IfcText? IIfcApproval.Description 
		{ 
			get
			{
				if (!Description.HasValue) return null;
				return new Ifc4.MeasureResource.IfcText(Description.Value);
			} 
			set
			{
				Description = value.HasValue ? 
					new MeasureResource.IfcText(value.Value) :  
					 new MeasureResource.IfcText?() ;
				
			}
		}
		Ifc4.DateTimeResource.IfcDateTime? IIfcApproval.TimeOfApproval 
		{ 
			get
			{
				//## Handle return of TimeOfApproval for which no match was found
			    return ApprovalDateTime != null
			        ? new Ifc4.DateTimeResource.IfcDateTime(ApprovalDateTime.ToISODateTimeString())
			        : null;
			    //##
			} 
			set
			{
				//## Handle setting of TimeOfApproval for which no match was found
                if (!value.HasValue)
                {
                    ApprovalDateTime = null;
                    return;
                }
                System.DateTime d = value.Value;
                ApprovalDateTime = Model.Instances.New<DateTimeResource.IfcDateAndTime>(dt =>
                {
                    dt.DateComponent = Model.Instances.New<DateTimeResource.IfcCalendarDate>(date =>
                    {
                        date.YearComponent = d.Year;
                        date.MonthComponent = d.Month;
                        date.DayComponent = d.Day;
                    });
                    dt.TimeComponent = Model.Instances.New<DateTimeResource.IfcLocalTime>(t =>
                    {
                        t.HourComponent = d.Hour;
                        t.MinuteComponent = d.Minute;
                        t.SecondComponent = d.Second;
                    });
                });
				//##
				NotifyPropertyChanged("TimeOfApproval");
				
			}
		}
		Ifc4.MeasureResource.IfcLabel? IIfcApproval.Status 
		{ 
			get
			{
				if (!ApprovalStatus.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(ApprovalStatus.Value);
			} 
			set
			{
				ApprovalStatus = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}
		Ifc4.MeasureResource.IfcLabel? IIfcApproval.Level 
		{ 
			get
			{
				if (!ApprovalLevel.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(ApprovalLevel.Value);
			} 
			set
			{
				ApprovalLevel = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}
		Ifc4.MeasureResource.IfcText? IIfcApproval.Qualifier 
		{ 
			get
			{
				if (!ApprovalQualifier.HasValue) return null;
				return new Ifc4.MeasureResource.IfcText(ApprovalQualifier.Value);
			} 
			set
			{
				ApprovalQualifier = value.HasValue ? 
					new MeasureResource.IfcText(value.Value) :  
					 new MeasureResource.IfcText?() ;
				
			}
		}

		private  IIfcActorSelect _requestingApproval;

		IIfcActorSelect IIfcApproval.RequestingApproval 
		{ 
			get
			{
				return _requestingApproval;
			} 
			set
			{
				SetValue(v => _requestingApproval = v, _requestingApproval, value, "RequestingApproval", byte.MaxValue);
				
			}
		}

		private  IIfcActorSelect _givingApproval;

		IIfcActorSelect IIfcApproval.GivingApproval 
		{ 
			get
			{
				return _givingApproval;
			} 
			set
			{
				SetValue(v => _givingApproval = v, _givingApproval, value, "GivingApproval", byte.MaxValue);
				
			}
		}
		IEnumerable<IIfcExternalReferenceRelationship> IIfcApproval.HasExternalReferences 
		{ 
			get
			{
				return Model.Instances.Where<IIfcExternalReferenceRelationship>(e => e.RelatedResourceObjects != null &&  e.RelatedResourceObjects.Contains(this), "RelatedResourceObjects", this);
			} 
		}
		IEnumerable<IIfcRelAssociatesApproval> IIfcApproval.ApprovedObjects 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelAssociatesApproval>(e => (e.RelatingApproval as IfcApproval) == this, "RelatingApproval", this);
			} 
		}
		IEnumerable<IIfcResourceApprovalRelationship> IIfcApproval.ApprovedResources 
		{ 
			get
			{
				return Model.Instances.Where<IIfcResourceApprovalRelationship>(e => (e.RelatingApproval as IfcApproval) == this, "RelatingApproval", this);
			} 
		}
		IEnumerable<IIfcApprovalRelationship> IIfcApproval.IsRelatedWith 
		{ 
			get
			{
				return Model.Instances.Where<IIfcApprovalRelationship>(e => e.RelatedApprovals != null &&  e.RelatedApprovals.Contains(this), "RelatedApprovals", this);
			} 
		}
		IEnumerable<IIfcApprovalRelationship> IIfcApproval.Relates 
		{ 
			get
			{
				return Model.Instances.Where<IIfcApprovalRelationship>(e => (e.RelatingApproval as IfcApproval) == this, "RelatingApproval", this);
			} 
		}
	//## Custom code
	//##
	}
}