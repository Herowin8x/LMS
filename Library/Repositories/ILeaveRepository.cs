using Library.Model;
using System;
using System.Collections.Generic;

namespace NHibernateDemo.Repositories
{
    public interface ILeaveRepository
    {
        IEnumerable<LeaveRequest> GetList();
    }
}
