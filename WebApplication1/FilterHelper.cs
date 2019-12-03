using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1
{
    public class FilterHelper : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            if (!filterContext.ExceptionHandled && filterContext.Exception is DivideByZeroException)
            {
                filterContext.Result = new ViewResult
                {
                    ViewName = "~/Views/Shared/NotFound.cshtml"
                };
                filterContext.ExceptionHandled = true;
            }
        }
    }
}