using Library;
using Library.Model;
using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace NHibernateDemo.Repositories.Imp
{
    public class TimmingRepository : ITimmingRepository
    {
        public IEnumerable<Timming> GetById(string userId)
        {
            return UserRepository.session.QueryOver<Timming>().Where(c => c.User.UserId == userId).List();
        }
    }
}
