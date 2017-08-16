using BusinessLayer;
using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoffeeShopUI.Controllers
{
    public class TableController : Controller
    {
        SqlContext _db;
        TableBusiness _tableBus;

        public TableController()
        {
            _tableBus = new TableBusiness();
            _db = new SqlContext();
        }

        // GET: Table
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult CheckInfo()
        {
            List<Check> checkList = _db.Checks.ToList();
            return Json(checkList, JsonRequestBehavior.AllowGet);
        }
    }
}