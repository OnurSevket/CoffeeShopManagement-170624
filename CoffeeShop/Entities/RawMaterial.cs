using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class RawMaterial
    {
        public RawMaterial()
        {
            this.Formulas = new HashSet<Formula>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public int UnitsInStock { get; set; }
        public int RecorderedLevel { get; set; }
        public int? SupplierID { get; set; }
        public virtual Supplier Supplier { get; set; }

        public int? RawUnitID { get; set; }
        //Nav Prop
        public virtual RawUnit RawUnit { get; set; }    

        public virtual ICollection<Formula> Formulas { get; set; }
    }
}