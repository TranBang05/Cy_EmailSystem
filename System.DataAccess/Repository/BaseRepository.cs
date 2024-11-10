using System;
using System.Collections.Generic;
using System.Database.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace System.DataAccess.Repository
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class

    {
        protected readonly CyDbContext _context;
        private readonly DbSet<T> _dbSet;

        protected BaseRepository(CyDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public async Task<int> CountAsync(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.CountAsync(expression);
        }

        public async Task<T> DeleteAsync(T entity)
        {
            if (entity != null)
            {
                _dbSet.Remove(entity);
              
            }

            return entity;
        }


        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public T GetById(object id)
        {
            return _dbSet.Find(id);
        }

        public async Task<T> GetByIdAsync(object id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetPagedAsync(Expression<Func<T, bool>> filter,
             int pageNumber, int pageSize, string[]? includes = null,
             Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null)
        {
            IQueryable<T> query = _dbSet;

            if (includes != null)
            {
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
            }

            query = query.Where(filter);

            if (orderBy != null)
            {
                query = orderBy(query);
            }

            return await query.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync(); ;
        }


        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }


        public async Task<T> InsertAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await SaveAsync();
            return entity;
        }


        public async Task<T> UpdateAsync(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            return entity;
        }
    }
}
