using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoffeeShopUI.Models.ViewModel
{
    public class UserViewModel
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string GenderName { get; set; }
   
        public string TitleName { get; set; }
      

    }
}