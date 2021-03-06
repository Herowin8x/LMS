using System;
using NHibernate;
using NHibernate.Cfg;
using NHibernateDemo.Repositories.Imp;

namespace Library
{
    public static partial class SessionManager
	{
		private static readonly ISessionFactory _sessionFactory;

		static SessionManager()
		{
			Configuration cfg = new Configuration().Configure();
            cfg.AddAssembly(typeof(SessionManager).Assembly);
            _sessionFactory = cfg.BuildSessionFactory();
		}

		public static ISession OpenSession()
		{
			return _sessionFactory.OpenSession();
		}

        public static void CloseSession()
        {
            _sessionFactory.Close();
            _sessionFactory.Dispose();
        }
	}
}