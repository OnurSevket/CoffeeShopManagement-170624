using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoffeeShopUI.Filters
{
    public class LoginRequiredAttribute:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.Session["UserID"] == null)
            {
                filterContext.Result = new RedirectResult("~/Login", true);
            }
        }

    }
}