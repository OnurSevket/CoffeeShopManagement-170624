using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Order
    {

        public Order()
        {
            this.Checks = new HashSet<Check>();
        }

        public int ID { get; set; }

        public int? ProductID { get; set; }
        public virtual Product Product { get; set; }

        public int? UserID { get; set; }
        public virtual User User { get; set; }

        public virtual ICollection<Check> Checks { get; set; }
    }
}