using System;
using System.Collections.Generic;

namespace Library.Model
{
	[Serializable]
	public partial class User
	{
		public virtual string Address
		{
			get;
			set;
		}
		public virtual string ContactPhone
		{
			get;
			set;
		}
		public virtual DateTime DayOfBirth
		{
			get;
			set;
		}
		public virtual string EmailAddr
		{
			get;
			set;
		}
		public virtual string FirstName
		{
			get;
			set;
		}
		public virtual DateTime JoinDate
		{
			get;
			set;
		}
		public virtual string LastName
		{
			get;
			set;
		}
		public virtual string Level
		{
			get;
			set;
		}
		public virtual string PassWord
		{
			get;
			set;
		}
		public virtual string Possition
		{
			get;
			set;
		}
		public virtual string UserId
		{
			get;
			set;
		}
		public virtual Holiday Holiday
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
        public virtual ICollection<Role> Roles
		{
			get;
			set;
		}
        public virtual ICollection<Timming> Timmings
		{
			get;
			set;
		}
	}
}