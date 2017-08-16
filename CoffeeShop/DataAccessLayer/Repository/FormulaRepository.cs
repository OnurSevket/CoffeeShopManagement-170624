using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class FormulaRepository : BaseRepository<Formula>
    {
        public FormulaRepository(SqlContext context) : base(context)
        {
        }
    }
}
