using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entities;
using BusinessLayer;

namespace CoffeeShopUI.Controllers
{
    public class LoginController : Controller
    {
        UserBusiness _userBus;

        public LoginController()
        {
            _userBus = new UserBusiness();
        }

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string userName,string password)
        {
            try
            {
                User user = _userBus.GetUserByPassword(userName, password);
                Session["UserID"] = user.ID;
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return View();
            }     
        }


        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "Login");
        }

    }
}