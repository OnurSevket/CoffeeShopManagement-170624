using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Formula
    {
        public int ID { get; set; }
        public string UnitsInFormula { get; set; }

        public int? ProductID { get; set; }
        public virtual Product Products { get; set; }
        public int? RawID { get; set; }
        public virtual RawMaterial RawMaterials { get; set; }
    }
}
// TODO:ASK ERDI HOCA