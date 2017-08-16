using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class SupplierRepository : BaseRepository<Supplier>
    {
        public SupplierRepository(SqlContext context) : base(context)
        {
        }
    }
}
