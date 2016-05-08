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
    public class UsersController : Controller
    {
        private readonly IUserRepository _repository;

        public UsersController(IUserRepository repository)
        {
            _repository = repository;
        }

        public ActionResult Login()
        {
            //Check in a user will be logout
            if (UserRepository.isLogin == true)
            {
                SessionManager.CloseSession();
                UserRepository.isLogin = false;
            }

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User user)
        {
            User oldUser = _repository.GetByEmail(user.EmailAddr);
            if (user.EmailAddr == oldUser.EmailAddr && user.PassWord == oldUser.PassWord)
            {
                UserRepository.isLogin = true;
                Session["fullName"] = oldUser.LastName + " " + oldUser.FirstName;
                Session["userId"] = oldUser.UserId;

                return RedirectToAction("Details/" + oldUser.UserId);
            }

            return View();
        }   

        [CustomAuthFilter]
        [CustomExceptionFilter]
        public ActionResult Details(string id)
        {
            return View(_repository.GetById(id));
        }

        public ActionResult Edit(string id)
        {
            return View(_repository.GetById(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                _repository.Update(user);
                Session["fullName"] = user.LastName + " " + user.FirstName;
                return RedirectToAction("Details/" + user.UserId);
            }
            return View(user);
        }
    }
}
