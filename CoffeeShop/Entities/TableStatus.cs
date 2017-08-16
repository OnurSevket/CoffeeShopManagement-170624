using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class TableStatus
    {
        //Dolu=0,
        //Boş=1,
        //Rezerve=2


        public TableStatus()
        {
             Tables=new HashSet<Table>(); 
        }

        public int ID { get; set; }

        public string Name { get; set; }


        public virtual ICollection<Table> Tables { get; set; }

    }
}