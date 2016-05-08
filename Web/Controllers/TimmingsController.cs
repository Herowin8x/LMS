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
    //TODO: will be double check late
    [CustomAuthFilter]
    [CustomExceptionFilter]
    public class TimmingsController : Controller
    {
        private readonly ITimmingRepository _repository;

        public TimmingsController(ITimmingRepository repository)
        {
            _repository = repository;
        }

        //TODO
        //[Route("Timming/Index123/{userId}")]
        public ActionResult Index(string userId)
        {
            return View(_repository.GetById(userId));
        }
    }
}
