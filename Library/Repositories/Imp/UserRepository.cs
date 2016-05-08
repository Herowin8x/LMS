using Library;
using Library.Model;
using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace NHibernateDemo.Repositories.Imp
{
    public class UserRepository : IUserRepository
    {
        public static ISession session = null;
        public static bool isLogin = false;

        public UserRepository()
        {
            session = SessionManager.OpenSession();
        }

        public User GetById(string userId)
        {
            return session.Get<User>(userId);
        }

        public User GetByEmail(string email)
        {
            var user = session
           .CreateCriteria(typeof(User))
           .Add(Restrictions.Like("EmailAddr", email))
           .UniqueResult<User>();
            return user;
        }

        public void Update(User user)
        {
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Clear();
                session.Update(user);
                transaction.Commit();
            }
        }
    }
}
