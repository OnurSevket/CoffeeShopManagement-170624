using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Title
    {
        //Yönetici=0,
        //Garson=1,
        //Kasiyer=2

        public Title()
        {
            Users = new HashSet<User>();
        }

        public int ID { get; set; }

        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}