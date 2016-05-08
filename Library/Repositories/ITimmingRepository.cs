using Library.Model;
using System;
using System.Collections.Generic;

namespace NHibernateDemo.Repositories
{
    public interface ITimmingRepository
    {
        IEnumerable<Timming> GetById(string userId);
    }
}
