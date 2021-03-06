using System;
using System.Collections.Generic;

namespace Library.Model
{
	[Serializable]
	public partial class TypeOfLeave
	{
		public TypeOfLeave()
		{
			LeaveAllowances = new List<LeaveAllowance>();
            LeaveRequests = new List<LeaveRequest>();		
		}
		public virtual int AllowanceLeave
		{
			get;
			set;
		}
		public virtual string Description
		{
			get;
			set;
		}
		public virtual DateTime? ExpiredDate
		{
			get;
			set;
		}
		public virtual bool? IsPaid
		{
			get;
			set;
		}
		public virtual string LeaveTypeId
		{
			get;
			set;
		}
		public virtual string Name
		{
			get;
			set;
		}
		public virtual DateTime StartedDate
		{
			get;
			set;
		}
		public virtual ICollection<LeaveAllowance> LeaveAllowances
		{
			get;
			set;
		}
		public virtual ICollection<LeaveRequest> LeaveRequests
		{
			get;
			set;
		}
		
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(this, obj))
				return true;
				
			return Equals(obj as TypeOfLeave);
		}
		
		public virtual bool Equals(TypeOfLeave obj)
		{
			if (obj == null) return false;

			if (Equals(AllowanceLeave, obj.AllowanceLeave) == false) return false;
			if (Equals(Description, obj.Description) == false) return false;
			if (Equals(ExpiredDate, obj.ExpiredDate) == false) return false;
			if (Equals(IsPaid, obj.IsPaid) == false) return false;
			if (Equals(LeaveTypeId, obj.LeaveTypeId) == false) return false;
			if (Equals(Name, obj.Name) == false) return false;
			if (Equals(StartedDate, obj.StartedDate) == false) return false;
			return true;
		}
		
		public override int GetHashCode()
		{
			int result = 1;

			result = (result * 397) ^ AllowanceLeave.GetHashCode();
			result = (result * 397) ^ (Description != null ? Description.GetHashCode() : 0);
			result = (result * 397) ^ (ExpiredDate != null ? ExpiredDate.GetHashCode() : 0);
			result = (result * 397) ^ (IsPaid != null ? IsPaid.GetHashCode() : 0);
			result = (result * 397) ^ (LeaveTypeId != null ? LeaveTypeId.GetHashCode() : 0);
			result = (result * 397) ^ (Name != null ? Name.GetHashCode() : 0);
			result = (result * 397) ^ StartedDate.GetHashCode();
			return result;
		}
	}
}