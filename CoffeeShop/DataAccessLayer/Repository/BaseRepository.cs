using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccessLayer
{
    //class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    public abstract class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {

        //todo: SqlContext eklenince buraya Ekle bir ctor la
        private SqlContext _context;

        //Constructor burada!!!
        public BaseRepository(SqlContext context)
        {
            _context = context;
        }

        public void Add(TEntity item)
        {
           
            _context.Entry<TEntity>(item).State = System.Data.Entity.EntityState.Added;
        }

        public List<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public TEntity GetByID(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity item)
        {
            _context.Entry<TEntity>(item).State = System.Data.Entity.EntityState.Deleted;
        }

        public void Update(TEntity item)
        {
            _context.Entry<TEntity>(item).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
