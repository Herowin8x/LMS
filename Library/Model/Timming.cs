using System;
using System.Collections.Generic;

namespace Library.Model
{
	[Serializable]
	public partial class Timming
	{
		public Timming()
		{		
		}
		public virtual string Comments
		{
			get;
			set;
		}
		public virtual DateTime Day
		{
			get;
			set;
		}
		public virtual DateTime? ManualIn
		{
			get;
			set;
		}
		public virtual DateTime? ManualOut
		{
			get;
			set;
		}
		public virtual bool? Submit
		{
			get;
			set;
		}
		public virtual string TimeId
		{
			get;
			set;
		}
		public virtual DateTime TimeIn
		{
			get;
			set;
		}
		public virtual DateTime TimeOut
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
				
			return Equals(obj as Timming);
		}
		
		public virtual bool Equals(Timming obj)
		{
			if (obj == null) return false;

			if (Equals(Comments, obj.Comments) == false) return false;
			if (Equals(Day, obj.Day) == false) return false;
			if (Equals(ManualIn, obj.ManualIn) == false) return false;
			if (Equals(ManualOut, obj.ManualOut) == false) return false;
			if (Equals(Submit, obj.Submit) == false) return false;
			if (Equals(TimeId, obj.TimeId) == false) return false;
			if (Equals(TimeIn, obj.TimeIn) == false) return false;
			if (Equals(TimeOut, obj.TimeOut) == false) return false;
			return true;
		}
		
		public override int GetHashCode()
		{
			int result = 1;

			result = (result * 397) ^ (Comments != null ? Comments.GetHashCode() : 0);
			result = (result * 397) ^ Day.GetHashCode();
			result = (result * 397) ^ (ManualIn != null ? ManualIn.GetHashCode() : 0);
			result = (result * 397) ^ (ManualOut != null ? ManualOut.GetHashCode() : 0);
			result = (result * 397) ^ (Submit != null ? Submit.GetHashCode() : 0);
			result = (result * 397) ^ (TimeId != null ? TimeId.GetHashCode() : 0);
			result = (result * 397) ^ TimeIn.GetHashCode();
			result = (result * 397) ^ TimeOut.GetHashCode();
			return result;
		}
	}
}