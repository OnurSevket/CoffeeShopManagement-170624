using BusinessLayer;
using CoffeeShopUI.Models.ViewModel;
using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoffeeShopUI.Controllers
{
    public class ManagerController : Controller
    {
        SqlContext _db;
        UserBusiness _userBUS;

        public ManagerController()
        {
            _userBUS = new UserBusiness();
            _db = new SqlContext();
        }

        // GET: Manager
        public ActionResult Index()
        {
            GenderBusiness gb = new GenderBusiness();
            TitleBusiness tb = new TitleBusiness();
            GenderTitle m = new GenderTitle();
            m.Genders = gb.GetAll().ToList();
            m.Titles = tb.GetAll().ToList();
            return View(m);
        }

        public JsonResult AddUser(User user)
        {
            int result;
            if (User != null)
            {
                _db.Users.Add(user);
                result = _db.SaveChanges();
                return Json("İşlem Başarılı", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("İşlem Başarısız", JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public JsonResult ListUser()
        {
           
            List<User> user = _db.Users.ToList();
            List<UserViewModel> userVm = new List<UserViewModel>();

            foreach (var item in user)
            {
                UserViewModel vm = new UserViewModel();

                vm.ID = item.ID;
                vm.FirstName = item.FirstName;
                vm.LastName = item.LastName;
                vm.Email = item.Email;
                vm.DateOfBirth = item.DateOfBirth;
                vm.UserName = item.UserName;
                vm.Password = item.Password;
                vm.GenderName = item.Gender.Name;
                vm.TitleName = item.Title.Name;
                userVm.Add(vm);
            }

            return Json(userVm, JsonRequestBehavior.AllowGet);

        }
        public JsonResult GetUserById(int id)
        {
            User user = _db.Users.Find(id);
            return Json(user, JsonRequestBehavior.AllowGet);
        }
        public JsonResult UpdateUser(User user)
        {

            User oldUser = _db.Users.Find(user.ID);

            oldUser.FirstName = user.FirstName;
            oldUser.LastName = user.LastName;
            oldUser.Email = user.Email;
            oldUser.DateOfBirth = user.DateOfBirth;
            oldUser.UserName = user.UserName;
            oldUser.Password = user.Password;

            int result = _db.SaveChanges();

            return Json(new { msg = result }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult DeleteUser(int id = 0)
        {
            int result;
            if (id != 0)
            {
                User toBeDeletedUser = _db.Users.Find(id);

                _db.Users.Remove(toBeDeletedUser);
                result = _db.SaveChanges();

                return Json(result, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("Hata", JsonRequestBehavior.AllowGet);
            }


        }


    }
}