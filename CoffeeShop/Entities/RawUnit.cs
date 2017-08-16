using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class RawUnit
    {
        //Adet=0,
        //Litre=1,
        //Gram=2

        public RawUnit()
        {
            RawMaterials = new HashSet<RawMaterial>();
        }

        public int ID { get; set; }

        public string Name { get; set; }

        public virtual ICollection<RawMaterial> RawMaterials { get; set; }

    }
}