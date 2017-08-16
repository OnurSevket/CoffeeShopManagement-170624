using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class CheckRepository : BaseRepository<Check>
    {
        public CheckRepository(SqlContext context) : base(context)
        {
        }
    }
}
