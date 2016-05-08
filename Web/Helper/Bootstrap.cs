using Autofac;
using Autofac.Integration.Mvc;
using NHibernateDemo.Repositories;
using NHibernateDemo.Repositories.Imp;
using System.Reflection;
using System.Web.Mvc;

namespace Web.Helper
{
    public class BootStrap
    {
        public IContainer myContainer { get; private set; }

        public void Configure()
        {
            ContainerBuilder builder = new ContainerBuilder();
            OnConfigure(builder);

            if (this.myContainer == null)
            {
                this.myContainer = builder.Build();
            }
            else
            {
                builder.Update(this.myContainer);
            }

            //This tells the MVC application to use myContainer as its dependency resolver
            DependencyResolver.SetResolver(new AutofacDependencyResolver(this.myContainer));
        }
        
        protected virtual void OnConfigure(ContainerBuilder builder)
        {
            //This is where you register all dependencies

            //The line below tells autofac, when a controller is initialized, pass into its constructor, the implementations of the required interfaces
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            //The line below tells autofac, everytime an implementation IDAL is needed, pass in an instance of the class DAL
            builder.RegisterType<UserRepository>().As<IUserRepository>().SingleInstance();
            builder.RegisterType<TimmingRepository>().As<ITimmingRepository>().SingleInstance();
            builder.RegisterType<LeaveRepository>().As<ILeaveRepository>().SingleInstance();
        }
    }
}
