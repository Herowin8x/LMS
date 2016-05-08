using Library;
using Library.Model;
using MVC_CustomActionFilter.Helper;
using NHibernateDemo.Repositories;
using NHibernateDemo.Repositories.Imp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class LeavesController : Controller
    {
        private readonly ILeaveRepository _repository;

        public LeavesController(ILeaveRepository repository)
        {
            _repository = repository;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Policy()
        {
            return View();
        }

        public ActionResult NewRequest()
        {
            //TODO
            return View();
        }

        public ActionResult Summary()
        {            
            return View(_repository.GetList());
        }
    }
}
