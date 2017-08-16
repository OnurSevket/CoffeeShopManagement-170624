using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

       
        public int GenderID { get; set; }

        //Nav Prop
        public virtual Gender Gender { get; set; }

        
        public int TitleID { get; set; }

        //Nav Prop
        public virtual Title Title { get; set; }

    }
}