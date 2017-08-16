using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Gender
    {
        //Erkek=0,
        //Kadın=1

        public Gender()
        {
            Users = new HashSet<User>();
        }

        public int ID { get; set; }

        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}