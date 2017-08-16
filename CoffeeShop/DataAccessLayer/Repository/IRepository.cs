using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IRepository<TEntity>
    {
        void Add(TEntity item);

        void Remove(TEntity item);

        void Update(TEntity item);

        List<TEntity> GetAll();

        TEntity GetByID(int id);

    }
}
