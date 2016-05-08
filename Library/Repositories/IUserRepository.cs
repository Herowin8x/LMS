using Library.Model;
using System;
using System.Collections.Generic;

namespace NHibernateDemo.Repositories
{
    public interface IUserRepository
    {
        void Update(User user);
        User GetById(string userId);
        User GetByEmail(string email);
    }
}
