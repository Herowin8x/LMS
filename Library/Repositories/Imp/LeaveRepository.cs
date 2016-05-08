using Library;
using Library.Model;
using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace NHibernateDemo.Repositories.Imp
{
    public class LeaveRepository : ILeaveRepository
    {
        public IEnumerable<LeaveRequest> GetList()
        {
            return UserRepository.session.QueryOver<LeaveRequest>().List();
        }
    }
}
