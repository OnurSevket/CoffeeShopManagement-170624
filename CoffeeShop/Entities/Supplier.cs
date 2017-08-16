using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Supplier
    {
        public Supplier()
        {
            this.RawMaterials = new HashSet<RawMaterial>();
        }
        
        public int ID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public virtual ICollection<RawMaterial> RawMaterials { get; set; }
    }
}