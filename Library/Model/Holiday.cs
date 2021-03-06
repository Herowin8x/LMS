using System;
using System.Collections.Generic;

namespace Library.Model
{
	[Serializable]
	public partial class Holiday
	{
		public virtual DateTime ActualDate
		{
			get;
			set;
		}
		public virtual DateTime HolidayDate
		{
			get;
			set;
		}
		public virtual string HolidayId
		{
			get;
			set;
		}
		public virtual string HolidayName
		{
			get;
			set;
		}
        public virtual ICollection<User> Users
		{
			get;
			set;
		}	
	}
}