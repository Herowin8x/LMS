//-----------------------------------------------------------------------
// <copyright file="CustExceptionFilter" company="SBA">
//  Copyright (c) SBA Company. All right reserved
// </copyright>
// <author>tuannguyendh</author>
// <date>4/29/2016 3:43:42 PM</date>
// <summary></summary>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_CustomActionFilter.Helper
{
    public class CustomExceptionFilter : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            Exception e = filterContext.Exception;
            filterContext.ExceptionHandled = true;
            var result = new ViewResult()
            {
                ViewName = "Error",
            };

            result.ViewBag.OnExceptionMessage = e.Message;
            filterContext.Result = result;
        }
    }
}