using BusinessLayer;
using CoffeeShopUI.Filters;
using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoffeeShopUI.Controllers
{
    public class HomeController : Controller
    {
        SqlContext _db;
        UserBusiness _userBUS;

        public HomeController()
        {
            _userBUS = new UserBusiness();
            _db = new SqlContext();
        }

        // GET: Home
        [LoginRequired]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UserInfo()
        {
            int userId = (int)Session["UserID"];

            User user = _userBUS.Get(userId);

            ViewBag.firstName = user.FirstName;
            ViewBag.lastName = user.LastName;
            ViewBag.title = user.Title.Name;

            return PartialView("PartialSignIn");

        }
        
    }
}