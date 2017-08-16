using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Product
    {
        public Product()
        {
            this.Formulas = new HashSet<Formula>();
            this.Orders = new HashSet<Order>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Avaible { get; set; }
        public decimal Price { get; set; }

        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }

        public virtual ICollection<Formula> Formulas { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}