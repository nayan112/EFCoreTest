using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Core
{
    public class GenericRepository<T>:IGenericRepository<T> where T:class 
    {
        protected DbContext Db;
        protected DbSet<T> DbSet;
        public GenericRepository(DbContext context)
        {
            Db = context;
            DbSet = Db.Set<T>();
        }
        public int Save()
        {
            return Db.SaveChanges();
        }

        public IList<T> Get()
        {
            return DbSet.ToList();
        }
        public virtual T Get(string id)
        {
            return DbSet.Find(id);
        }

        #region Async
        public virtual async Task<IList<T>> GetAsync()
        {
            return await DbSet.ToListAsync();
        }
        public virtual async Task<T> GetAsync(string id)
        {
            return await DbSet.FindAsync(id);
        }
        #endregion
    }
}