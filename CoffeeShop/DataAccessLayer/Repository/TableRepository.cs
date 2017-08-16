using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class TableRepository : BaseRepository<Table>
    {
        public TableRepository(SqlContext context) : base(context)
        {
        }
    }
}
