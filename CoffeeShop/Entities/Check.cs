using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Check
    {
        public Check()
        {
            Orders = new HashSet<Order>();
        }

        public int ID { get; set; }

        public float Fee { get; set; }

        public int TableID { get; set; }

        public virtual Table Table { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}