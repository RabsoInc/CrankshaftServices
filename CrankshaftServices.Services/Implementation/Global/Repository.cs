using HorsePowerLtd.DbAccess;
using HorsePowerLtd.Services.IRepository.Global;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HorsePowerLtd.Services.Impl.Global
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext db;
        internal DbSet<T> dbSet;

        public Repository(ApplicationDbContext db)
        {
            this.db = db;
            this.dbSet = db.Set<T>();
        }

        public void CreateRecord(T entity)
        {
            dbSet.Add(entity);
        }

        public void DefaultUpdateRecord(T entity)
        {
            dbSet.Update(entity);
        }

        public void DeleteRecord(T entity)
        {
            dbSet.Remove(entity);
        }

        public IEnumerable<T> GetAllRecords(string? includeProperties = null)
        {
            IQueryable<T> query = dbSet;
            if (includeProperties != null)
            {
                foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query.Include(includeProp);
                }
            }
            return query.ToList();
        }

        public T GetSingleRecord(Expression<Func<T, bool>> filter, string? includeProperties = null)
        {
            IQueryable<T> query = dbSet;
            query = query.Where(filter);

            if (includeProperties != null)
            {
                foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp);
                }
            }
            return query.FirstOrDefault();
        }

        public void RemoveMultipleRecords(IEnumerable<T> entities)
        {
            dbSet.RemoveRange(entities);
        }
    }
}