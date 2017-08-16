using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class TableStatusRepository : BaseRepository<TableStatus>
    {
        public TableStatusRepository(SqlContext context) : base(context)
        {
        }
    }
}
