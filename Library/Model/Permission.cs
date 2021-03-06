using System;
using System.Collections.Generic;

namespace Library.Model
{
	[Serializable]
	public partial class Permission
	{
		public Permission()
		{
			Roles = new List<Role>();		
		}
		public virtual string PermissionId
		{
			get;
			set;
		}
		public virtual string PermissionName
		{
			get;
			set;
		}
		public virtual ICollection<Role> Roles
		{
			get;
			set;
		}
		
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(this, obj))
				return true;
				
			return Equals(obj as Permission);
		}
		
		public virtual bool Equals(Permission obj)
		{
			if (obj == null) return false;

			if (Equals(PermissionId, obj.PermissionId) == false) return false;
			if (Equals(PermissionName, obj.PermissionName) == false) return false;
			return true;
		}
		
		public override int GetHashCode()
		{
			int result = 1;

			result = (result * 397) ^ (PermissionId != null ? PermissionId.GetHashCode() : 0);
			result = (result * 397) ^ (PermissionName != null ? PermissionName.GetHashCode() : 0);
			return result;
		}
	}
}