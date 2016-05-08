//-----------------------------------------------------------------------
// <copyright file="CustAuthFilter" company="SBA">
//  Copyright (c) SBA Company. All right reserved
// </copyright>
// <author>tuannguyendh</author>
// <date>4/29/2016 3:28:52 PM</date>
// <summary></summary>
//-----------------------------------------------------------------------

using Library;
using NHibernateDemo.Repositories.Imp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_CustomActionFilter.Helper
{
    public class CustomAuthFilter : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            if (UserRepository.isLogin == false)
            {
                filterContext.Result = new ViewResult()
                {
                    ViewName = "Login",
                };
            }
        }
    }
}