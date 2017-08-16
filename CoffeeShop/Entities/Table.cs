using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Table
    {
        
        public int ID { get; set; }

        public string Name { get; set; }


        public int TableStatusID { get; set; }

        //Nav Prop
        public virtual TableStatus TableStatus { get; set; }

    }
}