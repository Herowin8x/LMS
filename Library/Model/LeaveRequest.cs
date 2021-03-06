using System;
using System.Collections.Generic;

namespace Library.Model
{
	[Serializable]
	public partial class LeaveRequest
	{
		public LeaveRequest()
		{		
		}
		public virtual byte[] Attachment
		{
			get;
			set;
		}
		public virtual DateTime FromDate
		{
			get;
			set;
		}
		public virtual bool? IsFirstHaft
		{
			get;
			set;
		}
		public virtual bool? IsHaftDay
		{
			get;
			set;
		}
		public virtual bool? IsSecondHaft
		{
			get;
			set;
		}
		public virtual string LeaveDescription
		{
			get;
			set;
		}
		public virtual string LeaveRequestId
		{
			get;
			set;
		}
		public virtual short RequestStatus
		{
			get;
			set;
		}
		public virtual DateTime ToDate
		{
			get;
			set;
		}
		public virtual TypeOfLeave TypeOfLeave
		{
			get;
			set;
		}
		public virtual User User
		{
			get;
			set;
		}
		
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(this, obj))
				return true;
				
			return Equals(obj as LeaveRequest);
		}
		
		public virtual bool Equals(LeaveRequest obj)
		{
			if (obj == null) return false;

			if (Equals(Attachment, obj.Attachment) == false) return false;
			if (Equals(FromDate, obj.FromDate) == false) return false;
			if (Equals(IsFirstHaft, obj.IsFirstHaft) == false) return false;
			if (Equals(IsHaftDay, obj.IsHaftDay) == false) return false;
			if (Equals(IsSecondHaft, obj.IsSecondHaft) == false) return false;
			if (Equals(LeaveDescription, obj.LeaveDescription) == false) return false;
			if (Equals(LeaveRequestId, obj.LeaveRequestId) == false) return false;
			if (Equals(RequestStatus, obj.RequestStatus) == false) return false;
			if (Equals(ToDate, obj.ToDate) == false) return false;
			return true;
		}
		
		public override int GetHashCode()
		{
			int result = 1;

			result = (result * 397) ^ (Attachment != null ? Attachment.GetHashCode() : 0);
			result = (result * 397) ^ FromDate.GetHashCode();
			result = (result * 397) ^ (IsFirstHaft != null ? IsFirstHaft.GetHashCode() : 0);
			result = (result * 397) ^ (IsHaftDay != null ? IsHaftDay.GetHashCode() : 0);
			result = (result * 397) ^ (IsSecondHaft != null ? IsSecondHaft.GetHashCode() : 0);
			result = (result * 397) ^ (LeaveDescription != null ? LeaveDescription.GetHashCode() : 0);
			result = (result * 397) ^ (LeaveRequestId != null ? LeaveRequestId.GetHashCode() : 0);
			result = (result * 397) ^ RequestStatus.GetHashCode();
			result = (result * 397) ^ ToDate.GetHashCode();
			return result;
		}
	}
}