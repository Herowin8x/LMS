using System;
using System.Collections.Generic;

namespace Library.Model
{
	[Serializable]
	public partial class Role
	{
		public Role()
		{
            Permissions = new List<Permission>();		
		}
		public virtual string RoleId
		{
			get;
			set;
		}
		public virtual string RoleName
		{
			get;
			set;
		}
		public virtual ICollection<Permission> Permissions
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
				
			return Equals(obj as Role);
		}
		
		public virtual bool Equals(Role obj)
		{
			if (obj == null) return false;

			if (Equals(RoleId, obj.RoleId) == false) return false;
			if (Equals(RoleName, obj.RoleName) == false) return false;
			return true;
		}
		
		public override int GetHashCode()
		{
			int result = 1;

			result = (result * 397) ^ (RoleId != null ? RoleId.GetHashCode() : 0);
			result = (result * 397) ^ (RoleName != null ? RoleName.GetHashCode() : 0);
			return result;
		}
	}
}