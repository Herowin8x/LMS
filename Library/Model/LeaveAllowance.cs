using System;
using System.Collections.Generic;

namespace Library.Model
{
	[Serializable]
	public partial class LeaveAllowance
	{
		public LeaveAllowance()
		{		
		}
		public virtual string EmpLeaveId
		{
			get;
			set;
		}
		public virtual int LeaveRemaining
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
				
			return Equals(obj as LeaveAllowance);
		}
		
		public virtual bool Equals(LeaveAllowance obj)
		{
			if (obj == null) return false;

			if (Equals(EmpLeaveId, obj.EmpLeaveId) == false) return false;
			if (Equals(LeaveRemaining, obj.LeaveRemaining) == false) return false;
			return true;
		}
		
		public override int GetHashCode()
		{
			int result = 1;

			result = (result * 397) ^ (EmpLeaveId != null ? EmpLeaveId.GetHashCode() : 0);
			result = (result * 397) ^ LeaveRemaining.GetHashCode();
			return result;
		}
	}
}