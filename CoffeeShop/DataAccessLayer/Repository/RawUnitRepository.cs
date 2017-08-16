﻿using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class RawUnitRepository : BaseRepository<RawUnit>
    {
        public RawUnitRepository(SqlContext context) : base(context)
        {
        }
    }
}
