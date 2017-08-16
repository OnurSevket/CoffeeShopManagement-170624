using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class CategoryRepository : BaseRepository<Category>
    {
        public CategoryRepository(SqlContext context) : base(context)
        {

        }
    }
}
